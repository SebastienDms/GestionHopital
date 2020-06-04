using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Projet_BD_Hopital.Gestion;
using Projet_BD_Hopital.Classes;
using System.IO;
using System.Net.Mime;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Color = System.Drawing.Color;

namespace SD_Gestion_Hopital
{
    public partial class EcranFacturationDuJour : Form
    {
        #region Donnees
        private DataTable t_occuper;
        private BindingSource bs_occuper;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;
        private List<C_t_occuper> lTmp_Occ;
        private List<C_t_patients> lTmp_Pat;
        private List<C_t_chambres> lTmp_Cha;
        private List<C_t_soigner> lTmp_Soi;
        List<string> Liste_Num_Fac = new List<string>();
        List<string> soins = new List<string>();
        #endregion

        public EcranFacturationDuJour()
        {
            InitializeComponent();
        }

        private void EcranFacturationDuJour_Load(object sender, EventArgs e)
        {
            lblNoFacture.Visible = false;
            AFacturer();
        }

        private void AFacturer()
        {
            bool aFacturer = false;
            t_occuper = new DataTable();
            t_occuper.Columns.Add(new DataColumn("Le Patient"));
            t_occuper.Columns.Add(new DataColumn("qui a occupé la chambre"));
            t_occuper.Columns.Add(new DataColumn("est sorti le"));
            lTmp_Pat = new G_t_patients(sConnexion).Lire("IDPat");
            lTmp_Cha = new G_t_chambres(sConnexion).Lire("IDCha");
            lTmp_Soi = new G_t_soigner(sConnexion).Lire("IDSoi");
            lTmp_Occ = new G_t_occuper(sConnexion).Lire("IDOcc");
            // Recherche et affiche les séjours à l'hopital terminé ce jour, à facturer
            foreach (C_t_occuper o in lTmp_Occ)
            {
                if (o.DateSortie == DateTime.Today /*|| o.DateSortie==DateTime.Today.AddDays(-1)*/)
                {
                    string patient = "", chambre = "", soin = "";

                    foreach (C_t_patients p in lTmp_Pat)
                    {
                        if (o.IDPat == p.IDPat)
                        {
                            patient = p.NomPat + " " + p.PrenomPat;
                            foreach (C_t_soigner s in lTmp_Soi)
                            {
                                if (s.DateOperation >= o.DateEntree && s.DateOperation <= o.DateSortie && s.IDPat == p.IDPat)
                                {
                                    soin = s.IDPat.ToString() + "-" + s.IDSoi.ToString();
                                    soins.Add(soin);
                                }
                            }
                        }
                    }
                    foreach (C_t_chambres c in lTmp_Cha)
                    {
                        if (o.IDCha == c.IDCha)
                        {
                            chambre = c.NomCha.ToString();
                        }
                    }
                    t_occuper.Rows.Add(patient, chambre, o.DateSortie.ToShortDateString());
                    Liste_Num_Fac.Add(o.IDOcc.ToString() + "-" + o.IDPat.ToString());
                    aFacturer = true;
                }
            }

            if (aFacturer)
            {
                // Affiche la liste
                bs_occuper = new BindingSource();
                bs_occuper.DataSource = t_occuper;
                dgvAFacturer.DataSource = bs_occuper;
            }
            else
            {
                // Sinon affiche un message
                dgvAFacturer.Hide();
                btnFacturation.Visible = false;
                lblNoFacture.Visible = true;
                lblNoFacture.Location = new Point(230,200);
                lblNoFacture.ForeColor = Color.Crimson;
                lblNoFacture.Font = new Font(FontFamily.GenericSansSerif, 20);
                lblNoFacture.Text = "Pas de facturation aujourd'hui";
            }
        }

        private void btnFacturation_Click(object sender, EventArgs e)
        {
            // Génère un fichier pdf pour les facture du jour

            for (int i = 0; i < Liste_Num_Fac.Count; i++)
            {
                string Coordonnées_client = "";
                string Date_entree = "", Date_Sortie = "", Prix_journalier = "";
                int Nbr_jour_sejour = 0, Prix_total_sejour = 0;
                int? prix_total_ope = 0;
                string[] ID = Liste_Num_Fac[i].Split('-');
                List<string> DateOpe = new List<string>();
                List<int?> PrixOpe = new List<int?>();

                // Recherche les infos des opération pendant le séjour du patient
                foreach (string s in soins)
                {
                    string[] soin = s.Split('-');
                    if (soin[0] == ID[1])
                    {
                        foreach (C_t_soigner so in lTmp_Soi)
                        {
                            if (soin[1] == so.IDSoi.ToString())
                            {
                                DateOpe.Add(so.DateOperation.ToShortDateString());
                                PrixOpe.Add(so.PrixOperation);
                                prix_total_ope = prix_total_ope + so.PrixOperation;
                            }
                        }
                    }
                }

                // Recherche les infos du patient concerné
                foreach (C_t_patients p in lTmp_Pat)
                {
                    if (int.Parse(ID[1]) == p.IDPat)
                    {
                        Coordonnées_client = p.NomPat + " " + p.PrenomPat +"\n"+p.AdressePat;
                    }
                }

                // Recherche les infos du séjour
                foreach (C_t_occuper o in lTmp_Occ)
                {
                    if (int.Parse(ID[0]) == o.IDOcc)
                    {
                        Date_entree = o.DateEntree.ToShortDateString();
                        Date_Sortie = o.DateSortie.ToShortDateString();
                        Prix_journalier = o.PrixJournalier.ToString();
                        Nbr_jour_sejour = (o.DateSortie - o.DateEntree).Days;
                        if (Nbr_jour_sejour==0)
                            Nbr_jour_sejour = 1;
                        Prix_total_sejour = Nbr_jour_sejour * int.Parse(Prix_journalier);
                    }
                }

                // création du fichier de facturation dans le dossier indiqué et portera le nom "Facture num_client.pdf
                PdfWriter writer = new PdfWriter(@"C:\Users\sebas\Documents\HEL - Informatique\Fichiers_hopital\Facturations\Facture " +
                                                 Liste_Num_Fac[i] + ".pdf");
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                // Logo
                iText.Layout.Element.Image logo = new iText.Layout.Element.Image(ImageDataFactory
                        .Create(@"C:\Users\sebas\Documents\HEL - Informatique\BLOC 2\Travaux\Q2\2-1 Progra Even\Gestion hopital\images\logo_facture.png"))
                    .SetHeight(125)
                    .SetWidth(89)
                    .SetTextAlignment(TextAlignment.LEFT);
                //Coordonnées du client
                Paragraph Données_client = new Paragraph(Coordonnées_client)
                    .SetMarginLeft(350)
                    .SetMarginBottom(10)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(12);
                // Titre du document
                Paragraph titre = new Paragraph("FACTURE N°" + Liste_Num_Fac[i] + " :")
                    .SetMarginBottom(10)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(20);
                Paragraph espace = new Paragraph("\n\n\n");
                //Tableau séjour
                Table tableau = new Table(5, false).UseAllAvailableWidth();
                //Ligne de titre du tableau
                Cell cell11 = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("Date d'entrée"));
                Cell cell12 = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("Date de sortie"));
                Cell cell13 = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("Nombre de jours"));
                Cell cell14 = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("Prix journalier"));
                Cell cell15 = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("Prix total du séjour"));
                //Contenu du taleau;
                Cell cell21 = new Cell(1, 1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(Date_entree));
                Cell cell22 = new Cell(1, 1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(Date_Sortie));
                Cell cell23 = new Cell(1, 1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(Nbr_jour_sejour.ToString()));
                Cell cell24 = new Cell(1, 1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(Prix_journalier));
                Cell cell25 = new Cell(1, 1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(Prix_total_sejour.ToString()));
                //Ajout des cellules au tableau
                tableau.AddCell(cell11);
                tableau.AddCell(cell12);
                tableau.AddCell(cell13);
                tableau.AddCell(cell14);
                tableau.AddCell(cell15);
                tableau.AddCell(cell21);
                tableau.AddCell(cell22);
                tableau.AddCell(cell23);
                tableau.AddCell(cell24);
                tableau.AddCell(cell25);
                //Tableau séjour
                Table tableau1 = new Table(2, false).UseAllAvailableWidth();
                //Ligne de titre du tableau
                Cell cellbis11 = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("Date d'opération"));
                Cell cellbis12 = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("Prix de l'opération"));
                tableau1.AddCell(cellbis11);
                tableau1.AddCell(cellbis12);
                //Contenu du taleau
                for (int j = 0; j < DateOpe.Count; j++)
                {
                    Cell cellbis1 = new Cell(1, 1)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(DateOpe[j]));
                    Cell cellbis2 = new Cell(1, 1)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(PrixOpe[j].ToString()));
                    tableau1.AddCell(cellbis1);
                    tableau1.AddCell(cellbis2);
                }
                // Ligne prix total pour l'ensemble des opérations
                Cell cellbisDer1 = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("Prix total opération(s) :"));
                Cell cellbisDer2 = new Cell(1, 1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(prix_total_ope.ToString()));
                tableau1.AddCell(cellbisDer1);
                tableau1.AddCell(cellbisDer2);
                // Ligne prix total de facuration
                Table tableau2 = new Table(2, false).UseAllAvailableWidth();
                //Ligne de titre du tableau
                Cell cellTer1 = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("Prix total"));
                Cell cellTer2 = new Cell(1, 1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph((Prix_total_sejour + prix_total_ope).ToString()));
                tableau2.AddCell(cellTer1);
                tableau2.AddCell(cellTer2);
                //Ligne séparatrice
                LineSeparator ls = new LineSeparator(new SolidLine());

                document.Add(logo);
                document.Add(Données_client);
                document.Add(titre);
                document.Add(tableau);
                document.Add(espace);
                document.Add(tableau1);
                document.Add(espace);
                document.Add(tableau2);
                document.Add(espace);
                document.Add(ls);
                document.Close();
            }

            MessageBox.Show("Facturation effectuée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
