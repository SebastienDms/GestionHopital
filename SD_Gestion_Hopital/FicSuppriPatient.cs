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
    public partial class EcranSuppriPatient : Form
    {
        #region Donnees
        private DataTable t_patients;
        private BindingSource bs_patients;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;

        private List<C_t_patients> lTmp_Pat;
        #endregion

        public EcranSuppriPatient()
        {
            InitializeComponent();
        }

        private void EcranSuppriPatient_Load(object sender, EventArgs e)
        {
            btnChercherPat.Enabled = false;
        }
        private void AfficherPatients()
        {
            t_patients = new DataTable();
            t_patients.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_patients.Columns.Add(new DataColumn("Nom"));
            t_patients.Columns.Add(new DataColumn("Prénom"));
            t_patients.Columns.Add(new DataColumn("Adresse"));
            t_patients.Columns.Add(new DataColumn("GSM"));
            lTmp_Pat = new G_t_patients(sConnexion).Lire("NomPat");
            foreach (C_t_patients p in lTmp_Pat)
            {
                t_patients.Rows.Add(p.IDPat, p.NomPat, p.PrenomPat, p.AdressePat, p.GSMPat.ToString());
            }
            bs_patients = new BindingSource();
            bs_patients.DataSource = t_patients;
            dgvPatSup.DataSource = bs_patients;
        }
        private void ViderTBResultat()
        {
            tbIDPatSup.Text = tbNomPatSup.Text = tbPrenomPatSup.Text = tbAdressePatSup.Text = tbGSMPatSup.Text = "";
        }

        private void ViderAllTB()
        {
            ViderTBResultat();
            tbNomPatRech.Text = tbPrenomPatRech.Text = "";
        }
        private void ViderDGV()
        {
            dgvPatSup.DataSource = null;
            dgvPatSup.Invalidate();
        }
        private void ViderRecherche()
        {
            ViderAllTB();
            ViderDGV();
        }

        private void tbNomPatRech_Click(object sender, EventArgs e)
        {
            btnChercherPat.Enabled = true;
            ViderDGV();
        }

        private void btnAfficherListePat_Click(object sender, EventArgs e)
        {
            AfficherPatients();
            ViderAllTB();
        }

        private void btnChercherPat_Click(object sender, EventArgs e)
        {
            ViderTBResultat();
            try
            {
                // Majuscule aux nom et prénom recherchés
                tbNomPatRech.Text = tbNomPatRech.Text[0].ToString().ToUpper() + tbNomPatRech.Text.Substring(1);
                tbPrenomPatRech.Text = tbPrenomPatRech.Text[0].ToString().ToUpper() + tbPrenomPatRech.Text.Substring(1);

                lTmp_Pat = new G_t_patients(sConnexion).Lire("NomPat");
                // Recherche du patient
                foreach (C_t_patients p in lTmp_Pat)
                {
                    if (tbNomPatRech.Text == p.NomPat && tbPrenomPatRech.Text == p.PrenomPat)
                    {
                        tbIDPatSup.Text = p.IDPat.ToString();
                        tbNomPatSup.Text = p.NomPat;
                        tbPrenomPatSup.Text = p.PrenomPat;
                        tbAdressePatSup.Text = p.AdressePat;
                        tbGSMPatSup.Text = p.GSMPat.ToString();
                        break;
                    }
                }
                // On teste si la recherche à trouvé l'élément \\
                if (tbIDPatSup.Text == "")
                {
                    MessageBox.Show("Le patient n'a pas été trouvé.\nSoit il n'existe pas soit il y a une faute dans la barre de recherche.",
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

        private void btnConfirmerSupPat_Click(object sender, EventArgs e)
        {
            int ID_Sup = 0;
            if (tbIDPatSup.Text != "")
            {
                // Récupère l'ID du patient cherché
                ID_Sup = int.Parse(tbIDPatSup.Text);
                if (MessageBox.Show("Souhaitez-vous supprimer le patient " +
                                    tbNomPatSup.Text + " " + tbPrenomPatSup.Text + " ?",
                    "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK
                )
                {
                    try
                    {
                        new G_t_patients(sConnexion).Supprimer(ID_Sup);
                        MessageBox.Show("Suppression effectuée.", "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ViderRecherche();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Impossible de supprimer ce patient pour une question intégrité/historique des données.",
                            "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("La suppression a été annulée.", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    ViderTBResultat();
                }
            }
            else
            {
                try
                {
                    if (dgvPatSup.SelectedRows[0].Selected == true)
                    {
                        // Récupère l'ID du patient sélectionné
                        ID_Sup = (int)dgvPatSup.SelectedRows[0].Cells["ID"].Value;
                        if (MessageBox.Show("Souhaitez-vous supprimer le patient " +
                                            dgvPatSup.SelectedRows[0].Cells["Nom"].Value.ToString() + " " +
                                            dgvPatSup.SelectedRows[0].Cells["Prénom"].Value.ToString() + " ?",
                                "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) ==
                            DialogResult.OK
                        )
                        {
                            try
                            {
                                new G_t_patients(sConnexion).Supprimer(ID_Sup);
                                MessageBox.Show("Suppression effectuée.", "Information", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                ViderRecherche();
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show("Impossible de supprimer ce patient pour une question intégrité/historique des données.",
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
                    MessageBox.Show("Veuillez effectuer une recherche ou sélectionner le patient à supprimer.",
                        "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAnnulerSupPat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La suppression a été annulée.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            ViderRecherche();
        }
    }
}
