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

namespace SD_Gestion_Hopital
{
    public partial class EcranAjoutSoin : Form
    {
        private DataTable t_patients;
        private BindingSource bs_patients;
        private DataTable t_medecins;
        private BindingSource bs_medecins;
        private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";

        public EcranAjoutSoin()
        {
            InitializeComponent();
        }

        private void EcranAjoutSoin_Load(object sender, EventArgs e)
        {
            // Permet de sélectionner une date et non une plage de date dans le calendrier \\
            monthCalendar2.MaxSelectionCount = 1;
            // Empêche d'encoder une date passée \\
            monthCalendar2.MinDate = DateTime.Today;
            AfficherPatients();
            AfficherMedecins();
        }
        private void AfficherPatients()
        {
            t_patients = new DataTable();
            t_patients.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_patients.Columns.Add(new DataColumn("Nom"));
            t_patients.Columns.Add(new DataColumn("Prénom"));
            List<C_t_patients> lTmp_Pat = new G_t_patients(sConnexion).Lire("NomPat");
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
            t_medecins.Columns.Add(new DataColumn("Non prénom"));
            t_medecins.Columns.Add(new DataColumn("Spécialité"));
            List<C_t_medecins> lTmp_Med = new G_t_medecins(sConnexion).Lire("NomMed");
            List<C_t_specialites> lTmp_Spe = new G_t_specialites(sConnexion).Lire("NomSpe");
            foreach (C_t_medecins m in lTmp_Med)
            {
                foreach (C_t_specialites s in lTmp_Spe)
                {
                    if (m.IDSpe == s.IDSpe)
                    {
                        t_medecins.Rows.Add(m.IDMed, m.NomMed + " " + m.PrenomMed, s.NomSpe);
                    }
                }
            }
            bs_medecins = new BindingSource();
            bs_medecins.DataSource = t_medecins;
            dgvMedecinsSoi.DataSource = bs_medecins;
        }

        private void btnAjouterPatSoi_Click(object sender, EventArgs e)
        {
            tbAjSoiIDPat.Text = dgvPatientsSoi.SelectedRows[0].Cells["ID"].Value.ToString();
        }

        private void btnAjouterMedSoi_Click(object sender, EventArgs e)
        {
            tbAjSoiIDMed.Text = dgvMedecinsSoi.SelectedRows[0].Cells["ID"].Value.ToString();
        }

        private void btnAjDateEntreeOcc_Click(object sender, EventArgs e)
        {
            tbAjSoiDateOperation.Text = monthCalendar2.SelectionStart.ToShortDateString().ToString();
        }

        private void btnAjDateSortieOcc_Click(object sender, EventArgs e)
        {
            tbAjSoiDateAuthSortie.Text = monthCalendar2.SelectionStart.ToShortDateString().ToString();
        }

        private void btnConfirmerAjSoi_Click(object sender, EventArgs e)
        {
            if (tbAjSoiIDPat.Text == "" || tbAjSoiIDMed.Text == "" || tbAjSoiDateOperation.Text == "" ||
                tbAjSoiPrixOperation.Text == "")
            {
                MessageBox.Show("Veuillez remplir chaque champs de données.", "Attention", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("La personne " +
                                    dgvPatientsSoi.SelectedRows[0].Cells["Nom"].Value.ToString() +
                                    dgvPatientsSoi.SelectedRows[0].Cells["Prénom"].Value.ToString() +
                                    " sera opérée par " +
                                    dgvMedecinsSoi.SelectedRows[0].Cells["Non prénom"].Value.ToString() +
                                    " en date du " + tbAjSoiDateOperation.Text + ".",
                              "Info:", MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    new G_t_soigner(sConnexion).Ajouter(int.Parse(tbAjSoiIDMed.Text), int.Parse(tbAjSoiIDPat.Text),
                        DateTime.Parse(tbAjSoiDateOperation.Text), VerifieDateSortie(),
                    int.Parse(tbAjSoiPrixOperation.Text));
                    MessageBox.Show("La résevation a bien été effectuée", "Attention", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vous avez annulez l'organisation de l'opération du patient " +
                                    dgvPatientsSoi.SelectedRows[0].Cells["Nom"] +
                                    " " +
                                    dgvPatientsSoi.SelectedRows[0].Cells["Prénom"] +
                                    ".", "Attention", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAnnulerAjSoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La coordination de l'opération a été annulée.", "Attention", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            tbAjSoiIDPat.Text = tbAjSoiIDMed.Text = tbAjSoiDateOperation.Text = tbAjSoiDateAuthSortie.Text = tbAjSoiPrixOperation.Text = "";
        }

        private DateTime VerifieDateSortie()
        {
            if (tbAjSoiDateAuthSortie.Text == "")
            {
                return new DateTime(1753,1,1);

            }
            else
            {
                return DateTime.Parse(tbAjSoiDateAuthSortie.Text);
            }
        }
    }
}
