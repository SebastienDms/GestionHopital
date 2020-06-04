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
    public partial class EcranAjoutMedecin : Form
    {
        #region Donnees
        private DataTable t_specialites;
        private BindingSource bs_specialites;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;
        #endregion

        public EcranAjoutMedecin()
        {
            InitializeComponent();
        }
        private void EcranAjoutMedecin_Load(object sender, EventArgs e)
        {
            btnAjouterMedSpe.Enabled = false;
        }
        private void AfficherSpecialites()
        {
            t_specialites = new DataTable();
            t_specialites.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_specialites.Columns.Add(new DataColumn("Spécialité"));
            List<C_t_specialites> lTmp_Spe = new G_t_specialites(sConnexion).Lire("NomSpe");
            foreach (C_t_specialites spe in lTmp_Spe)
            {
                t_specialites.Rows.Add(spe.IDSpe, spe.NomSpe);
            }
            bs_specialites = new BindingSource();
            bs_specialites.DataSource = t_specialites;
            dgvSpecialites.DataSource = bs_specialites;
        }

        private void btnConfirmerAjMed_Click(object sender, EventArgs e)
        {
            if (tbMedNom.Text == "" || tbMedPrenom.Text == "" || tbMedGSM.Text == "" || tbMedIDSpe.Text == "")
            {
                MessageBox.Show("Veuillez remplir chaque champs de donnée", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                // Force la majuscule au nom et au prénom \\
                tbMedNom.Text = tbMedNom.Text[0].ToString().ToUpper() + tbMedNom.Text.Substring(1);
                tbMedPrenom.Text = tbMedPrenom.Text[0].ToString().ToUpper() + tbMedPrenom.Text.Substring(1);
                // Ajout du médecin \\
                new G_t_medecins(sConnexion).Ajouter(tbMedNom.Text, tbMedPrenom.Text, int.Parse(tbMedGSM.Text),
                    int.Parse(tbMedIDSpe.Text));
                MessageBox.Show("Le médecin a été ajouté", "Info:", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                tbMedNom.Text = tbMedPrenom.Text = tbMedGSM.Text = tbMedIDSpe.Text = "";
            }
        }

        private void btnAnnulerAjMed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le médecin ne sera pas ajouté", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            tbMedNom.Text = tbMedPrenom.Text = tbMedGSM.Text = tbMedIDSpe.Text = "";
        }

        private void btnAjouterMedSpe_Click(object sender, EventArgs e)
        {
            tbMedIDSpe.Text = dgvSpecialites.SelectedRows[0].Cells["ID"].Value.ToString();
        }

        private void tbMedIDSpe_Click(object sender, EventArgs e)
        {
            AfficherSpecialites();
            btnAjouterMedSpe.Enabled = true;
        }
    }
}
