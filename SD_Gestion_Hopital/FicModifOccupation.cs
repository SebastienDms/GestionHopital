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
using System.Globalization;
using Projet_BD_Hopital.Gestion;
using Projet_BD_Hopital.Classes;
using System.IO;

namespace SD_Gestion_Hopital
{
    public partial class EcranModifOccupation : Form
    {
        #region Donnees
        private DataTable t_occuper;
        private BindingSource bs_occuper;
        private DataTable t_patients;
        private BindingSource bs_patients;
        private DataTable t_chambres;
        private BindingSource bs_chambres;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;
        List<C_t_chambres> lTmp_Cha;
        List<C_t_patients> lTmp_Pat;
        List<C_t_occuper> lTmp_Occ;
        #endregion

        public EcranModifOccupation()
        {
            InitializeComponent();
        }

        private void EcranModifOccupation_Load(object sender, EventArgs e)
        {
            // Permet de sélectionner une date et non une plage de date dans le calendrier \\
            monthCalendarModifOcc.MaxSelectionCount = 1;
            // Empêche d'encoder une date passée \\
            monthCalendarModifOcc.MinDate = DateTime.Today;
            AfficherPatients();
            AfficherChambres();
            AfficherOccupation();
        }

        private void ViderTB()
        {
            tbModifIDOcc.Text = tbModifOccIDPat.Text = tbModifOccIDCha.Text = tbModifOccDateEntree.Text = tbModifOccDateSortie.Text = tbModifOccPrixJour.Text = "";
        }
        private void AfficherOccupation()
        {
            t_occuper = new DataTable();
            t_occuper.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_occuper.Columns.Add(new DataColumn("Patient"));
            t_occuper.Columns.Add(new DataColumn("Chambre"));
            t_occuper.Columns.Add(new DataColumn("Entrée le"));
            t_occuper.Columns.Add(new DataColumn("Sortie le"));
            t_occuper.Columns.Add(new DataColumn("Coût journalier"));
            lTmp_Cha = new G_t_chambres(sConnexion).Lire("NomCha");
            lTmp_Pat = new G_t_patients(sConnexion).Lire("NomPat");
            lTmp_Occ = new G_t_occuper(sConnexion).Lire("IDOcc");
            foreach (C_t_occuper o in lTmp_Occ)
            {
                string Chambre = "", Patient = "";

                foreach (C_t_chambres c in lTmp_Cha)
                {
                    if (o.IDCha == c.IDCha)
                    {
                        Chambre = c.NomCha.ToString();
                        break;
                    }
                }
                foreach (C_t_patients p in lTmp_Pat)
                {
                    if (o.IDPat == p.IDPat)
                    {
                        Patient = p.NomPat + " " + p.PrenomPat;
                        break;
                    }
                }

                t_occuper.Rows.Add(o.IDOcc, Patient, Chambre, o.DateEntree.ToShortDateString(),
                    o.DateSortie.ToString(), o.PrixJournalier.ToString());
            }
            bs_occuper = new BindingSource();
            bs_occuper.DataSource = t_occuper;
            dgvOccModif.DataSource = bs_occuper;
        }

        private void AfficherPatients()
        {
            t_patients = new DataTable();
            t_patients.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_patients.Columns.Add(new DataColumn("Nom"));
            t_patients.Columns.Add(new DataColumn("Prénom"));
            lTmp_Pat = new G_t_patients(sConnexion).Lire("NomPat");
            foreach (C_t_patients p in lTmp_Pat)
            {
                t_patients.Rows.Add(p.IDPat, p.NomPat, p.PrenomPat);
            }
            bs_patients = new BindingSource();
            bs_patients.DataSource = t_patients;
            dgvPatientsModif.DataSource = bs_patients;
        }
        private void AfficherChambres()
        {
            t_chambres = new DataTable();
            t_chambres.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_chambres.Columns.Add(new DataColumn("Numéro"));
            t_chambres.Columns.Add(new DataColumn("Etage"));
            t_chambres.Columns.Add(new DataColumn("Service"));
            lTmp_Cha = new G_t_chambres(sConnexion).Lire("NomCha");
            foreach (C_t_chambres c in lTmp_Cha)
            {
                t_chambres.Rows.Add(c.IDCha, c.NomCha, c.EtageCha, c.ServiceCha);
            }
            bs_chambres = new BindingSource();
            bs_chambres.DataSource = t_chambres;
            dgvChambresModif.DataSource = bs_chambres;
        }
        private void btnModifDateEntreeOcc_Click(object sender, EventArgs e)
        {
            tbModifOccDateEntree.Text = monthCalendarModifOcc.SelectionStart.ToShortDateString().ToString();

        }

        private void btnModifDateSortieOcc_Click(object sender, EventArgs e)
        {
            tbModifOccDateSortie.Text = monthCalendarModifOcc.SelectionStart.ToShortDateString().ToString();
        }
        private void btnAjouterPatOccModif_Click(object sender, EventArgs e)
        {
            tbModifOccIDPat.Text = dgvPatientsModif.SelectedRows[0].Cells["ID"].Value.ToString();
        }

        private void btnAjouterChaOccModif_Click(object sender, EventArgs e)
        {
            tbModifOccIDCha.Text = dgvChambresModif.SelectedRows[0].Cells["ID"].Value.ToString();
        }
        private void btnAjouterOccModif_Click(object sender, EventArgs e)
        {
            // Try catch pour gérer l'erreur en cas de selection d'une cellule et non de la ligne en entier \\
            try
            {
                if (dgvOccModif.ColumnCount == dgvOccModif.SelectedRows[0].Cells.Count)
                {
                    tbModifIDOcc.Text = dgvOccModif.SelectedRows[0].Cells["ID"].Value.ToString();
                    // Transforme le nom prénom du patient par l ID qui lui correspond \\
                    string[] nom_prenom = dgvOccModif.SelectedRows[0].Cells["Patient"].Value.ToString().Split(' ');
                    lTmp_Pat = new G_t_patients(sConnexion).Lire("NomPat");
                    foreach (C_t_patients p in lTmp_Pat)
                    {
                        if (p.NomPat == nom_prenom[0])
                        {
                            if (p.PrenomPat == nom_prenom[1])
                            {
                                tbModifOccIDPat.Text = p.IDPat.ToString();

                            }
                        }
                    }
                    lTmp_Cha = new G_t_chambres(sConnexion).Lire("NomCha");
                    foreach (C_t_chambres c in lTmp_Cha)
                    {
                        if (c.NomCha == int.Parse(dgvOccModif.SelectedRows[0].Cells["Chambre"].Value.ToString()))
                        {
                            tbModifOccIDCha.Text = c.IDCha.ToString();
                        }
                    }
                    
                    tbModifOccDateEntree.Text = dgvOccModif.SelectedRows[0].Cells["Entrée le"].Value.ToString();
                    tbModifOccDateSortie.Text = DateTime.Parse(dgvOccModif.SelectedRows[0].Cells["Sortie le"].Value.ToString()).ToString().Remove(10);
                    tbModifOccPrixJour.Text = dgvOccModif.SelectedRows[0].Cells["Coût journalier"].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Merci de bien sélectionner toute la ligne en entier.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnConfirmerModifOcc_Click(object sender, EventArgs e)
        {
            if (tbModifOccIDPat.Text == "" || tbModifOccIDCha.Text == "" || tbModifOccDateEntree.Text == "" ||
                tbModifOccPrixJour.Text == "")
            {
                MessageBox.Show("Veuillez remplir chaque champs de données.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                string patient = "", chambre = "";
                lTmp_Pat = new G_t_patients(sConnexion).Lire("IDPat");
                foreach (C_t_patients p in lTmp_Pat)
                {
                    if (p.IDPat == int.Parse(tbModifOccIDPat.Text))
                    {
                        patient = p.NomPat + " " + p.PrenomPat;
                    }
                }
                lTmp_Cha = new G_t_chambres(sConnexion).Lire("IDCha");
                foreach (C_t_chambres c in lTmp_Cha)
                {
                    if (c.IDCha == int.Parse(tbModifOccIDCha.Text))
                    {
                        chambre = c.NomCha.ToString();
                    }
                }

                if (MessageBox.Show("La chambre " + chambre + " a été réservée pour " + patient +
                                    " en date du " + tbModifOccDateEntree.Text + ".",
                        "Info:", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    new G_t_occuper(sConnexion).Modifier(int.Parse(tbModifIDOcc.Text),int.Parse(tbModifOccIDPat.Text), int.Parse(tbModifOccIDCha.Text),
                        DateTime.Parse(tbModifOccDateEntree.Text), VerifieDateSortie(),
                        int.Parse(tbModifOccPrixJour.Text));
                    MessageBox.Show("La résevation a bien été modifiée", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vous avez annulez la modification de la prise en charge du patient " +
                                    dgvPatientsModif.SelectedRows[0].Cells["Nom"] + " " + dgvPatientsModif.SelectedRows[0].Cells["Prénom"] +
                                    ".", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }

            ViderTB();
        }

        private void btnAnnulerModifOcc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La réservation ne sera pas modifiée.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            ViderTB();
        }
        private DateTime VerifieDateSortie()
        {
            if (tbModifOccDateSortie.Text == "")
            {
                return new DateTime(1753, 1, 1);

            }
            else
            {
                return DateTime.Parse(tbModifOccDateSortie.Text);
            }
        }
    }
}
