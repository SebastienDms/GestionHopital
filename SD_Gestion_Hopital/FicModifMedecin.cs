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
    public partial class EcranModifMedecin : Form
    {
        #region Donnees
        private DataTable t_medecins;
        private BindingSource bs_medecins;
        private DataTable t_specialites;
        private BindingSource bs_specialites;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;
        List<C_t_specialites> lTmp_Spe;
        #endregion

        public EcranModifMedecin()
        {
            InitializeComponent();
        }

        private void EcranModifMedecin_Load(object sender, EventArgs e)
        {
            lTmp_Spe = new G_t_specialites(sConnexion).Lire("NomSpe");
            AfficherMedecins();
            ActiverBoutons(false);
            btnModifMedSpe.Enabled = false;
        }

        private void ActiverBoutons(bool active)
        {
            btnConfirmerModifMed.Enabled = btnAnnulerModifMed.Enabled = active;
        }
        private void AfficherMedecins()
        {
            t_medecins = new DataTable();
            t_medecins.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_medecins.Columns.Add(new DataColumn("Nom"));
            t_medecins.Columns.Add(new DataColumn("Prénom"));
            t_medecins.Columns.Add(new DataColumn("GSM"));
            t_medecins.Columns.Add(new DataColumn("Spécialité"));
            List<C_t_medecins> lTmp_Med = new G_t_medecins(sConnexion).Lire("NomMed");
            foreach (C_t_medecins m in lTmp_Med)
            {
                foreach (C_t_specialites s in lTmp_Spe)
                {
                    if (m.IDSpe == s.IDSpe)
                    {
                        t_medecins.Rows.Add(m.IDMed, m.NomMed, m.PrenomMed, m.GSMMed, s.NomSpe);
                    }
                }
            }
            bs_medecins = new BindingSource();
            bs_medecins.DataSource = t_medecins;
            dgvModifAfficheMed.DataSource = bs_medecins;
        }
        private void AfficherSpecialites()
        {
            t_specialites = new DataTable();
            t_specialites.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_specialites.Columns.Add(new DataColumn("Spécialité"));
            foreach (C_t_specialites spe in lTmp_Spe)
            {
                t_specialites.Rows.Add(spe.IDSpe, spe.NomSpe);
            }
            bs_specialites = new BindingSource();
            bs_specialites.DataSource = t_specialites;
            dgvModifMedAfficheSpe.DataSource = bs_specialites;
        }

        private void btnModifierMed_Click(object sender, EventArgs e)
        {
            tbModifIDMed.Text = dgvModifAfficheMed.SelectedRows[0].Cells["ID"].Value.ToString();
            tbModifMedNom.Text = dgvModifAfficheMed.SelectedRows[0].Cells["Nom"].Value.ToString();
            tbModifMedPrenom.Text = dgvModifAfficheMed.SelectedRows[0].Cells["Prénom"].Value.ToString();
            tbModifMedGSM.Text = dgvModifAfficheMed.SelectedRows[0].Cells["GSM"].Value.ToString();
            foreach (C_t_specialites s in lTmp_Spe)
            {
                if (s.NomSpe == dgvModifAfficheMed.SelectedRows[0].Cells["Spécialité"].Value.ToString())
                {
                    tbModifMedIDSpe.Text = s.IDSpe.ToString();
                }
            }
            ActiverBoutons(true);
        }

        private void btnModifMedSpe_Click(object sender, EventArgs e)
        {
            tbModifMedIDSpe.Text = dgvModifMedAfficheSpe.SelectedRows[0].Cells["ID"].Value.ToString();
            btnModifMedSpe.Enabled = false;
        }

        private void tbModifMedIDSpe_Click(object sender, EventArgs e)
        {
            AfficherSpecialites();
            btnModifMedSpe.Enabled = true;
        }

        private void btnConfirmerModifMed_Click(object sender, EventArgs e)
        {
            if (tbModifMedNom.Text == "" || tbModifMedPrenom.Text == "" || tbModifMedGSM.Text == "" || tbModifMedIDSpe.Text == "")
            {
                MessageBox.Show("Veuillez remplir chaque champs de donnée.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                // Force la majuscule au nom et au prénom \\
                tbModifMedNom.Text = tbModifMedNom.Text[0].ToString().ToUpper() + tbModifMedNom.Text.Substring(1);
                tbModifMedPrenom.Text = tbModifMedPrenom.Text[0].ToString().ToUpper() + tbModifMedPrenom.Text.Substring(1);
                // Ajout du médecin modifié \\
                new G_t_medecins(sConnexion).Modifier(int.Parse(tbModifIDMed.Text), tbModifMedNom.Text, tbModifMedPrenom.Text, int.Parse(tbModifMedGSM.Text),
                    int.Parse(tbModifMedIDSpe.Text));
                MessageBox.Show("Le médecin a été modifié.", "Info:", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                tbModifIDMed.Text = tbModifMedNom.Text = tbModifMedPrenom.Text = tbModifMedGSM.Text = tbModifMedIDSpe.Text = "";
                ActiverBoutons(false);
            }
        }

        private void btnAnnulerModifMed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le médecin ne sera pas modifié.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            tbModifIDMed.Text = tbModifMedNom.Text = tbModifMedPrenom.Text = tbModifMedGSM.Text = tbModifMedIDSpe.Text = "";
            ActiverBoutons(false);
        }
    }
}
