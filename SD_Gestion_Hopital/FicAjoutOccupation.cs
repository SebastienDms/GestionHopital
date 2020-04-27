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
    public partial class EcranAjoutOccupation : Form
    {
        private DataTable t_patients;
        private BindingSource bs_patients;
        private DataTable t_chambres;
        private BindingSource bs_chambres;
        private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";

        public EcranAjoutOccupation()
        {
            InitializeComponent();
        }

        private void EcranAjoutOccupation_Load(object sender, EventArgs e)
        {
            // Permet de sélectionner une date et non une plage de date dans le calendrier \\
            monthCalendar1.MaxSelectionCount = 1;
            // Empêche d'encoder une date passée \\
            monthCalendar1.MinDate = DateTime.Today;
            AfficherPatients();
            AfficherChambres();
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
            dgvPatients.DataSource = bs_patients;
        }
        private void AfficherChambres()
        {
            t_chambres = new DataTable();
            t_chambres.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_chambres.Columns.Add(new DataColumn("Numéro"));
            t_chambres.Columns.Add(new DataColumn("Etage"));
            t_chambres.Columns.Add(new DataColumn("Service"));
            List<C_t_chambres> lTmp_Cha = new G_t_chambres(sConnexion).Lire("NomCha");
            foreach (C_t_chambres c in lTmp_Cha)
            {
                t_chambres.Rows.Add(c.IDCha, c.NomCha, c.EtageCha, c.ServiceCha);
            }
            bs_chambres = new BindingSource();
            bs_chambres.DataSource = t_chambres;
            dgvChambres.DataSource = bs_chambres;
        }

        private void btnAjouterPatOcc_Click(object sender, EventArgs e)
        {
            tbAjOccIDPat.Text = dgvPatients.SelectedRows[0].Cells["ID"].Value.ToString();
        }

        private void btnAjouterChaOcc_Click(object sender, EventArgs e)
        {
            tbAjOccIDCha.Text = dgvChambres.SelectedRows[0].Cells["ID"].Value.ToString();
        }
        private void btnAjDateEntreeOcc_Click(object sender, EventArgs e)
        {
            tbAjOccDateEntree.Text = monthCalendar1.SelectionStart.ToShortDateString().ToString();
        }

        private void btnAjDateSortieOcc_Click(object sender, EventArgs e)
        {
            tbAjOccDateSortie.Text = monthCalendar1.SelectionStart.ToShortDateString().ToString();
        }

        private void btnConfirmerAjOcc_Click(object sender, EventArgs e)
        {
            if (tbAjOccIDPat.Text == "" || tbAjOccIDCha.Text == "" || tbAjOccDateEntree.Text == "" ||
                tbAjOccPrixJour.Text == "")
            {
                MessageBox.Show("Veuillez remplir chaque champs de données.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("La chambre " + dgvChambres.SelectedRows[0].Cells["Numéro"].Value.ToString() +
                                    " a été réservée pour " +
                                    dgvPatients.SelectedRows[0].Cells["Nom"].Value.ToString() + dgvPatients.SelectedRows[0].Cells["Prénom"].Value.ToString() +
                                    " en date du " + tbAjOccDateEntree.Text + ".",
                              "Info:", MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    new G_t_occuper(sConnexion).Ajouter(int.Parse(tbAjOccIDPat.Text), int.Parse(tbAjOccIDCha.Text),
                        DateTime.Parse(tbAjOccDateEntree.Text), DateTime.Parse(tbAjOccDateSortie.Text),
                        int.Parse(tbAjOccPrixJour.Text));
                    MessageBox.Show("La résevation a bien été effectuée", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vous avez annulez la prise en charge du patient "+
                                    dgvPatients.SelectedRows[0].Cells["Nom"] + " " + dgvPatients.SelectedRows[0].Cells["Prénom"] +
                                    ".", "Attention", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }
        private void btnAnnulerAjOcc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La réservation ne sera pas ajoutée.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            tbAjOccIDPat.Text = tbAjOccIDCha.Text = tbAjOccDateEntree.Text = tbAjOccDateSortie.Text = tbAjOccPrixJour.Text = "";
        }
    }
}
