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
    public partial class EcranModifSpecialite : Form
    {
        #region Donnees
        private DataTable t_specialites;
        private BindingSource bs_specialites;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;
        #endregion

        public EcranModifSpecialite()
        {
            InitializeComponent();
        }

        private void EcranModifSpecialite_Load(object sender, EventArgs e)
        {
            ActiveBouton(false);
            AfficherSpecialites();
        }

        private void ActiveBouton(bool active)
        {
            btnConfirmerModifSpe.Enabled = btnAnnulerModifSpe.Enabled = active;
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
            dgvModifSpecialites.DataSource = bs_specialites;
        }

        private void btnModifSpeSelection_Click(object sender, EventArgs e)
        {
            ActiveBouton(true);
            tbIDSpe.Text = dgvModifSpecialites.SelectedRows[0].Cells["ID"].Value.ToString();
            tbModifNomSpe.Text = dgvModifSpecialites.SelectedRows[0].Cells["Spécialité"].Value.ToString();
        }

        private void btnConfirmerModifSpe_Click(object sender, EventArgs e)
        {
            if (tbModifNomSpe.Text == "")
            {
                MessageBox.Show("Veuillez saisir le nom de la spécialité à modifier.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                // Force la majuscule au nom de la spécialité \\
                tbModifNomSpe.Text = tbModifNomSpe.Text[0].ToString().ToUpper() + tbModifNomSpe.Text.Substring(1);

                new G_t_specialites(sConnexion).Modifier(int.Parse(tbIDSpe.Text), tbModifNomSpe.Text);
                MessageBox.Show("La spécialité a été modifiée.", "Info:", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                tbIDSpe.Text = tbModifNomSpe.Text = "";
            }
            ActiveBouton(false);
            AfficherSpecialites();
        }

        private void btnAnnulerModifSpe_Click(object sender, EventArgs e)
        {
            ActiveBouton(false);
            MessageBox.Show("La spécialité ne sera pas modifiée.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            tbIDSpe.Text = tbModifNomSpe.Text = "";
        }
    }
}
