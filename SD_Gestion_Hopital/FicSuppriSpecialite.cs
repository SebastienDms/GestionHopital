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
    public partial class EcranSuppriSpecialite : Form
    {
        #region Donnees
        private DataTable t_specialites;
        private BindingSource bs_specialites;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;

        private List<C_t_specialites> lTmp_Spe;
        #endregion

        public EcranSuppriSpecialite()
        {
            InitializeComponent();
        }

        private void FicSuppriSpecialite_Load(object sender, EventArgs e)
        {
            btnChercherSpe.Enabled = true;
        }
        private void AfficherSpecialites()
        {
            t_specialites = new DataTable();
            t_specialites.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_specialites.Columns.Add(new DataColumn("Spécialité"));
            lTmp_Spe = new G_t_specialites(sConnexion).Lire("NomSpe");
            foreach (C_t_specialites spe in lTmp_Spe)
            {
                t_specialites.Rows.Add(spe.IDSpe, spe.NomSpe);
            }
            bs_specialites = new BindingSource();
            bs_specialites.DataSource = t_specialites;
            dgvSpeSup.DataSource = bs_specialites;
        }

        private void ViderTB()
        {
            tblIDSpeSup.Text = tblNomSpeSup.Text = "";
        }
        private void btnChercherSpe_Click(object sender, EventArgs e)
        {
            ViderTB();
            try
            {
                // Majuscule au nom de la spécialité
                tblNomSpeRech.Text = tblNomSpeRech.Text[0].ToString().ToUpper() + tblNomSpeRech.Text.Substring(1);

                lTmp_Spe = new G_t_specialites(sConnexion).Lire("NomSpe");
                // Recherche  la psécialité par le nom saisi
                foreach (C_t_specialites s in lTmp_Spe)
                {
                    if (tblNomSpeRech.Text == s.NomSpe)
                    {
                        tblIDSpeSup.Text = s.IDSpe.ToString();
                        tblNomSpeSup.Text = s.NomSpe;
                    }
                }
                // On teste si la recherche à trouvé l'élément \\
                if (tblIDSpeSup.Text == "")
                {
                    MessageBox.Show("La spécialité n'a pas été trouvée.\nSoit elle n'existe pas soit il y a une faute dans la barre de recherche.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViderTB();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Veuillez saisir quelque chose dans la barre de recherche.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tblNomSpeRech_Click(object sender, EventArgs e)
        {
            btnChercherSpe.Enabled = true;
        }

        private void btnAfficherListeSpe_Click(object sender, EventArgs e)
        {
            AfficherSpecialites();
        }

        private void btnConfirmerSupSpe_Click(object sender, EventArgs e)
        {
            int ID_Sup = 0;
            if (tblIDSpeSup.Text !="")
            {
                // Récupère l'ID recherché
                ID_Sup = int.Parse(tblIDSpeSup.Text);
                if (MessageBox.Show("Souhaitez-vous supprimer " + tblNomSpeRech.Text + " ?",
                    "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK
                )
                {
                    new G_t_specialites(sConnexion).Supprimer(ID_Sup);
                    MessageBox.Show("Suppression effectuée.", "Information", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La suppression a été annulée.", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    if (dgvSpeSup.SelectedRows[0].Selected == true)
                    {
                        // Récupère l'ID de la spécialité sélectionnée
                        ID_Sup = (int) dgvSpeSup.SelectedRows[0].Cells["ID"].Value;
                        if (MessageBox.Show("Souhaitez-vous supprimer " +
                                            dgvSpeSup.SelectedRows[0].Cells["Spécialité"].Value.ToString() + " ?",
                                "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) ==
                            DialogResult.OK
                        )
                        {
                            new G_t_specialites(sConnexion).Supprimer(ID_Sup);
                            MessageBox.Show("Suppression effectuée.", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("La suppression a été annulée.", "Attention", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Veuillez effectuer une recherche ou sélectionner une spécialité à supprimer.",
                        "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAnnulerSupSpe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La suppression a été annulée.","Attention",MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
