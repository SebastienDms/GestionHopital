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
    public partial class EcranModifOccupation : Form
    {
        private DataTable t_patients;
        private BindingSource bs_patients;
        private DataTable t_chambres;
        private BindingSource bs_chambres;
        private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";

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

        }

        private void ViderTB()
        {
            tbModifIDOcc.Text = tbModifOccIDPat.Text = tbModifOccIDCha.Text = tbModifOccDateEntree.Text = tbModifOccDateSortie.Text = tbModifOccPrixJour.Text = "";
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
            dgvPatientsModif.DataSource = bs_patients;
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

        private void btnConfirmerModifOcc_Click(object sender, EventArgs e)
        {

            tbModifIDOcc.Text = tbModifOccIDPat.Text = tbModifOccIDCha.Text = tbModifOccDateEntree.Text = tbModifOccDateSortie.Text = tbModifOccPrixJour.Text = "";
        }

        private void btnAnnulerModifOcc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La réservation ne sera pas modifiée.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            ViderTB();
        }
    }
}
