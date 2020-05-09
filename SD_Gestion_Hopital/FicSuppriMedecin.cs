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
    public partial class EcranSuppriMedecin : Form
    {
        private DataTable t_medecins;
        private BindingSource bs_medecins;
        private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private List<C_t_medecins> lTmp_Med;
        private List<C_t_specialites> lTmp_Spe;

        public EcranSuppriMedecin()
        {
            InitializeComponent();
        }

        private void FicSuppriMedecin_Load(object sender, EventArgs e)
        {
            btnChercherMed.Enabled = false;
        }
        private void AfficherMedecins()
        {
            t_medecins = new DataTable();
            t_medecins.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_medecins.Columns.Add(new DataColumn("Nom"));
            t_medecins.Columns.Add(new DataColumn("Prénom"));
            t_medecins.Columns.Add(new DataColumn("GSM"));
            t_medecins.Columns.Add(new DataColumn("Spécialité"));
            lTmp_Med = new G_t_medecins(sConnexion).Lire("NomMed");
            lTmp_Spe = new G_t_specialites(sConnexion).Lire("NomSpe");
            foreach (C_t_medecins m in lTmp_Med)
            {
                string Nom_Spe = "";

                foreach (C_t_specialites spe in lTmp_Spe)
                {
                    if (m.IDSpe == spe.IDSpe)
                    {
                        Nom_Spe = spe.NomSpe;
                        break;
                    }
                }

                t_medecins.Rows.Add(m.IDMed, m.NomMed, m.PrenomMed, m.GSMMed.ToString(), Nom_Spe);
            }
            bs_medecins = new BindingSource();
            bs_medecins.DataSource = t_medecins;
            dgvMedSup.DataSource = bs_medecins;
        }

        private void ViderTBResultat()
        {
            tbIDMedSup.Text = tbNomMedSup.Text = tbPrenomMedSup.Text = tbGSMMedSup.Text = tbSpecialiteMedSup.Text = "";
        }

        private void ViderAllTB()
        {
            ViderTBResultat();
            tbNomMedRech.Text = tbPrenomMedRech.Text = "";
        }
        private void ViderDGV()
        {
            dgvMedSup.DataSource = null;
            dgvMedSup.Invalidate();
        }
        private void ViderRecherche()
        {
            ViderAllTB();
            ViderDGV();
        }

        private void btnAfficherListeMed_Click(object sender, EventArgs e)
        {
            AfficherMedecins();
            ViderAllTB();
        }

        private void tbNomMedRech_Click(object sender, EventArgs e)
        {
            btnChercherMed.Enabled = true;
            ViderDGV();
        }

        private void btnChercherMed_Click(object sender, EventArgs e)
        {
            ViderTBResultat();
            try
            {
                tbNomMedRech.Text = tbNomMedRech.Text[0].ToString().ToUpper() + tbNomMedRech.Text.Substring(1);
                tbPrenomMedRech.Text = tbPrenomMedRech.Text[0].ToString().ToUpper() + tbPrenomMedRech.Text.Substring(1);
                lTmp_Med = new G_t_medecins(sConnexion).Lire("NomMed");
                lTmp_Spe = new G_t_specialites(sConnexion).Lire("NomSpe");
                foreach (C_t_medecins m in lTmp_Med)
                {
                    if (tbNomMedRech.Text == m.NomMed && tbPrenomMedRech.Text == m.PrenomMed)
                    {
                        tbIDMedSup.Text = m.IDMed.ToString();
                        tbNomMedSup.Text = m.NomMed;
                        tbPrenomMedSup.Text = m.PrenomMed;
                        tbGSMMedSup.Text = m.GSMMed.ToString();
                        foreach (C_t_specialites s in lTmp_Spe)
                        {
                            if (m.IDSpe == s.IDSpe)
                            {
                                tbSpecialiteMedSup.Text = s.NomSpe;
                                break;
                            }
                        }
                    }
                }
                // On teste si la recherche à trouvé l'élément \\
                if (tbIDMedSup.Text == "")
                {
                    MessageBox.Show("Le médecin n'a pas été trouvé.\nSoit il n'existe pas soit il y a une faute dans la barre de recherche.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViderTBResultat();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Veuillez saisir quelque chose dans la barre de recherche.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConfirmerSupMed_Click(object sender, EventArgs e)
        {
            int ID_Sup = 0;
            if (tbIDMedSup.Text != "")
            {
                ID_Sup = int.Parse(tbIDMedSup.Text);
                if (MessageBox.Show("Souhaitez-vous supprimer le médecin " +
                                    tbNomMedSup.Text + " " + tbPrenomMedSup.Text + " ?",
                    "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK
                )
                {
                    try
                    {
                        new G_t_medecins(sConnexion).Supprimer(ID_Sup);
                        MessageBox.Show("Suppression effectuée.", "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ViderRecherche();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Impossible de supprimer ce médecin pour une question historique des données.",
                            "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
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
                    if (dgvMedSup.SelectedRows[0].Selected == true)
                    {
                        ID_Sup = (int)dgvMedSup.SelectedRows[0].Cells["ID"].Value;
                        if (MessageBox.Show("Souhaitez-vous supprimer le médecin " +
                                            dgvMedSup.SelectedRows[0].Cells["Nom"].Value.ToString() + " " +
                                            dgvMedSup.SelectedRows[0].Cells["Prénom"].Value.ToString() + " ?",
                                "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) ==
                            DialogResult.OK
                        )
                        {
                            try
                            {
                                new G_t_medecins(sConnexion).Supprimer(ID_Sup);
                                MessageBox.Show("Suppression effectuée.", "Information", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                ViderRecherche();
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show("Impossible de supprimer ce médecin pour une question historique des données.",
                                    "Information", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
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
                    MessageBox.Show("Veuillez effectuer une recherche ou sélectionner le médecin à supprimer.",
                        "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAnnulerSupMed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La suppression a été annulée.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            ViderRecherche();
        }
    }
}
