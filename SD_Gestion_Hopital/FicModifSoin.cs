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
    public partial class EcranModifSoin : Form
    {
        #region Donnees
        private DataTable t_soigner;
        private BindingSource bs_soigner;
        private DataTable t_patients;
        private BindingSource bs_patients;
        private DataTable t_medecins;
        private BindingSource bs_medecins;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;
        List<C_t_medecins> lTmp_Med;
        List<C_t_patients> lTmp_Pat;
        List<C_t_soigner> lTmp_Soi;
        #endregion

        public EcranModifSoin()
        {
            InitializeComponent();
        }

        private void EcranModifSoin_Load(object sender, EventArgs e)
        {
            // Permet de sélectionner une date et non une plage de date dans le calendrier \\
            monthCalendarModifSoi.MaxSelectionCount = 1;
            // Empêche d'encoder une date passée \\
            monthCalendarModifSoi.MinDate = DateTime.Today;
            AfficherSoins();
        }
        private void AfficherSoins()
        {
            t_soigner = new DataTable();
            t_soigner.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_soigner.Columns.Add(new DataColumn("Médecin"));
            t_soigner.Columns.Add(new DataColumn("Patient"));
            t_soigner.Columns.Add(new DataColumn("Opéré le"));
            t_soigner.Columns.Add(new DataColumn("Sortie prévue le"));
            t_soigner.Columns.Add(new DataColumn("Coût de l'opération"));
            lTmp_Med = new G_t_medecins(sConnexion).Lire("NomMed");
            lTmp_Pat = new G_t_patients(sConnexion).Lire("NomPat");
            lTmp_Soi = new G_t_soigner(sConnexion).Lire("IDSoi");
            foreach (C_t_soigner s in lTmp_Soi)
            {
                string Medecin = "", Patient = "", Date = "";

                foreach (C_t_medecins m in lTmp_Med)
                {
                    if (s.IDMed == m.IDMed)
                    {
                        Medecin = m.NomMed + " " + m.PrenomMed;
                        break;
                    }
                }
                foreach (C_t_patients p in lTmp_Pat)
                {
                    if (s.IDPat == p.IDPat)
                    {
                        Patient = p.NomPat + " " + p.PrenomPat;
                        break;
                    }
                }

                if (DateTime.Compare((DateTime)s.DateAuthorisationSortie, new DateTime(1753, 1, 1)) == 0)
                {
                    Date = "";
                }
                else
                {
                    Date = s.DateAuthorisationSortie.ToLongDateString();
                }
                t_soigner.Rows.Add(s.IDSoi, Medecin, Patient, s.DateOperation.ToShortDateString(),
                    Date, s.PrixOperation.ToString());
            }
            bs_soigner = new BindingSource();
            bs_soigner.DataSource = t_soigner;
            dgvSoiModif.DataSource = bs_soigner;
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
            dgvPatientsSoi.DataSource = bs_patients;
        }
        private void AfficherMedecins()
        {
            t_medecins = new DataTable();
            t_medecins.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_medecins.Columns.Add(new DataColumn("Nom"));
            t_medecins.Columns.Add(new DataColumn("Prénom"));
            t_medecins.Columns.Add(new DataColumn("Spécialité"));
            List<C_t_medecins> lTmp_Med = new G_t_medecins(sConnexion).Lire("NomMed");
            List<C_t_specialites> lTmp_Spe = new G_t_specialites(sConnexion).Lire("NomSpe");
            foreach (C_t_medecins m in lTmp_Med)
            {
                foreach (C_t_specialites s in lTmp_Spe)
                {
                    if (m.IDSpe == s.IDSpe)
                    {
                        t_medecins.Rows.Add(m.IDMed, m.NomMed, m.PrenomMed, s.NomSpe);
                    }
                }
            }
            bs_medecins = new BindingSource();
            bs_medecins.DataSource = t_medecins;
            dgvMedecinsSoi.DataSource = bs_medecins;
        }
        private void ViderTB()
        {
            tbModifIDSoi.Text = tbModifSoiIDPat.Text = tbModifSoiIDMed.Text = tbModifSoiDateOperation.Text =
                tbModifSoiDateAuthSortie.Text = tbModifSoiPrixOperation.Text = "";
        }
        private void btnAjouterSoinModif_Click(object sender, EventArgs e)
        {
            // Try catch pour gérer l'erreur en cas de selection d'une cellule et non de la ligne en entier \\
            try
            {
                if (dgvSoiModif.ColumnCount == dgvSoiModif.SelectedRows[0].Cells.Count)
                {
                    tbModifIDSoi.Text = dgvSoiModif.SelectedRows[0].Cells["ID"].Value.ToString();
                    // Transforme le nom prénom du médecin par l ID qui lui correspond \\
                    string[] nom_prenom_med = dgvSoiModif.SelectedRows[0].Cells["Médecin"].Value.ToString().Split(' ');
                    List<C_t_medecins> lTmp_Med = new G_t_medecins(sConnexion).Lire("NomMed");
                    foreach (C_t_medecins m in lTmp_Med)
                    {
                        if (m.NomMed == nom_prenom_med[0])
                        {
                            if (m.PrenomMed == nom_prenom_med[1])
                            {
                                tbModifSoiIDMed.Text = m.IDMed.ToString();

                            }
                        }
                    }
                    // Transforme le nom prénom du patient par l ID qui lui correspond \\
                    string[] nom_prenom_pat = dgvSoiModif.SelectedRows[0].Cells["Patient"].Value.ToString().Split(' ');
                    lTmp_Pat = new G_t_patients(sConnexion).Lire("NomPat");
                    foreach (C_t_patients p in lTmp_Pat)
                    {
                        if (p.NomPat == nom_prenom_pat[0])
                        {
                            if (p.PrenomPat == nom_prenom_pat[1])
                            {
                                tbModifSoiIDPat.Text = p.IDPat.ToString();

                            }
                        }
                    }
                    tbModifSoiDateOperation.Text = dgvSoiModif.SelectedRows[0].Cells["Opéré le"].Value.ToString();
                    if (dgvSoiModif.SelectedRows[0].Cells["Sortie prévue le"].Value.ToString() == "")
                        tbModifSoiDateAuthSortie.Text = dgvSoiModif.SelectedRows[0].Cells["Sortie prévue le"].Value.ToString();
                    else
                        tbModifSoiDateAuthSortie.Text = DateTime.Parse(dgvSoiModif.SelectedRows[0].Cells["Sortie prévue le"].Value.ToString()).ToString().Remove(10);
                    tbModifSoiPrixOperation.Text = dgvSoiModif.SelectedRows[0].Cells["Coût de l'opération"].Value.ToString();
                }
                AfficherPatients();
                AfficherMedecins();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Merci de bien sélectionner toute la ligne en entier.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnModifPatSoi_Click(object sender, EventArgs e)
        {
            try
            {
                tbModifSoiIDPat.Text = dgvPatientsSoi.SelectedRows[0].Cells["ID"].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Merci de bien sélectionner toute la ligne en entier.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModifMedSoi_Click(object sender, EventArgs e)
        {
            try
            {
                tbModifSoiIDMed.Text = dgvMedecinsSoi.SelectedRows[0].Cells["ID"].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Merci de bien sélectionner toute la ligne en entier.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModifDateEntreeOcc_Click(object sender, EventArgs e)
        {
            tbModifSoiDateOperation.Text = monthCalendarModifSoi.SelectionStart.ToShortDateString().ToString();
        }

        private void btnModifDateSortieOcc_Click(object sender, EventArgs e)
        {
            tbModifSoiDateAuthSortie.Text = monthCalendarModifSoi.SelectionStart.ToShortDateString().ToString();
        }

        private void btnConfirmerModifSoi_Click(object sender, EventArgs e)
        {
            if (tbModifSoiIDPat.Text == "" || tbModifSoiIDMed.Text == "" || tbModifSoiDateOperation.Text == "" ||
                tbModifSoiDateAuthSortie.Text == "" || tbModifSoiPrixOperation.Text == "")
            {
                MessageBox.Show("Veuillez remplir chaque champs de données.", "Attention", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                string nom_pat = "", prenom_pat = "", nom_med = "", prenom_med = "";
                lTmp_Med = new G_t_medecins(sConnexion).Lire("NomMed");
                lTmp_Pat = new G_t_patients(sConnexion).Lire("NomPat");
                foreach (C_t_medecins m in lTmp_Med)
                {
                    if (int.Parse(tbModifSoiIDMed.Text) == m.IDMed)
                    {
                        nom_med = m.NomMed;
                        prenom_med = m.PrenomMed;
                        break;
                    }
                }
                foreach (C_t_patients p in lTmp_Pat)
                {
                    if (int.Parse(tbModifSoiIDPat.Text) == p.IDPat)
                    {
                        nom_pat = p.NomPat;
                        prenom_pat = p.PrenomPat;
                        break;
                    }
                }
                if (MessageBox.Show("La personne " + nom_pat + " " + prenom_pat +
                                    " sera opérée par " + nom_med + " " + prenom_med +
                                    " en date du " + tbModifSoiDateOperation.Text + ".",
                              "Info:", MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    new G_t_soigner(sConnexion).Modifier(int.Parse(tbModifIDSoi.Text), int.Parse(tbModifSoiIDMed.Text),
                        int.Parse(tbModifSoiIDPat.Text),DateTime.Parse(tbModifSoiDateOperation.Text),
                        DateTime.Parse(tbModifSoiDateAuthSortie.Text)/*VerifieDateSortie()*/,
                    int.Parse(tbModifSoiPrixOperation.Text));
                    MessageBox.Show("La résevation a bien été modifiée", "Attention", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vous avez annulez la modification de l'opération du patient " +
                                    dgvPatientsSoi.SelectedRows[0].Cells["Nom"] +
                                    " " +
                                    dgvPatientsSoi.SelectedRows[0].Cells["Prénom"] +
                                    ".", "Attention", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }
        private void btnAnnulerModifSoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La coordination de l'opération a été modifiée.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            ViderTB();
        }
        //private DateTime VerifieDateSortie()
        //{
        //    if (tbModifSoiDateAuthSortie.Text == "")
        //    {
        //        return new DateTime(1753, 1, 1);

        //    }
        //    else
        //    {
        //        return DateTime.Parse(tbModifSoiDateAuthSortie.Text);
        //    }
        //}
    }
}
