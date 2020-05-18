﻿using System;
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
        private DataTable t_occuper;
        private BindingSource bs_occuper;
        private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private List<C_t_occuper> lTmp_Occ;
        private List<C_t_patients> lTmp_Pat;
        private List<C_t_chambres> lTmp_Cha;
        List<string> Liste_Num_Fac = new List<string>();

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
            lTmp_Occ = new G_t_occuper(sConnexion).Lire("IDOcc");
            foreach (C_t_occuper o in lTmp_Occ)
            {
                if (o.DateSortie == DateTime.Today || o.DateSortie==DateTime.Today.AddDays(-1))
                {
                    string patient = "", chambre = "";
                    foreach (C_t_patients p in lTmp_Pat)
                    {
                        if (o.IDPat == p.IDPat)
                        {
                            patient = p.NomPat + " " + p.PrenomPat;
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
                bs_occuper = new BindingSource();
                bs_occuper.DataSource = t_occuper;
                dgvAFacturer.DataSource = bs_occuper;
            }
            else
            {
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
            for (int i = 0; i < Liste_Num_Fac.Count; i++)
            {
                string Coordonnées_client = "";
                string Date_entree = "", Date_Sortie = "", Prix_journalier = "";
                int Nbr_jour_sejour = 0, Prix_total_sejour = 0;
                string[] ID = Liste_Num_Fac[i].Split('-');
                foreach (C_t_patients p in lTmp_Pat)
                {
                    if (int.Parse(ID[1]) == p.IDPat)
                    {
                        Coordonnées_client = p.NomPat + " " + p.PrenomPat +"\n"+p.AdressePat;
                    }
                }

                foreach (C_t_occuper o in lTmp_Occ)
                {
                    if (int.Parse(ID[0]) == o.IDOcc)
                    {
                        Date_entree = o.DateEntree.ToShortDateString();
                        Date_Sortie = o.DateSortie.ToShortDateString();
                        Prix_journalier = o.PrixJournalier.ToString();
                        Nbr_jour_sejour = (o.DateSortie - o.DateEntree).Days;
                        Prix_total_sejour = Nbr_jour_sejour * int.Parse(Prix_journalier);
                    }
                }

                PdfWriter writer = new PdfWriter("C:\\Users\\sebas\\Documents\\HEL - Informatique\\Facturations\\Facture "+
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
                //Ligne séparatrice
                LineSeparator ls = new LineSeparator(new SolidLine());

                document.Add(logo);
                document.Add(Données_client);
                document.Add(titre);
                document.Add(tableau);
                document.Add(espace);
                document.Add(ls);
                document.Close();
            }

            MessageBox.Show("Facturation effectuée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
