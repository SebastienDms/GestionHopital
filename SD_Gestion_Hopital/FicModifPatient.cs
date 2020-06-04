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
    public partial class EcranModifPatient : Form
    {
        #region Donnees
        private DataTable t_patients;
        private BindingSource bs_patients;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;
        #endregion

        public EcranModifPatient()
        {
            InitializeComponent();
        }

        private void EcranModifPatient_Load(object sender, EventArgs e)
        {
            AfficherPatients();
        }
        private void ViderTB()
        {
            tbModifPatID.Text = tbModifPatNom.Text = tbModifPatPrenom.Text = tbModifPatAdresse.Text = tbModifPatGSM.Text = "";
        }

        private void AfficherPatients()
        {
            t_patients = new DataTable();
            t_patients.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_patients.Columns.Add(new DataColumn("Nom"));
            t_patients.Columns.Add(new DataColumn("Prénom"));
            t_patients.Columns.Add(new DataColumn("Adresse"));
            t_patients.Columns.Add(new DataColumn("GSM"));
            List<C_t_patients> lTmp_Pat = new G_t_patients(sConnexion).Lire("NomPat");
            foreach (C_t_patients p in lTmp_Pat)
            {
                t_patients.Rows.Add(p.IDPat, p.NomPat, p.PrenomPat, p.AdressePat, p.GSMPat.ToString());
            }
            bs_patients = new BindingSource();
            bs_patients.DataSource = t_patients;
            dgvPatModif.DataSource = bs_patients;
        }

        private void btnAjouterPat_Click(object sender, EventArgs e)
        {
            // Try catch pour gérer l'erreur en cas de selection d'une cellule et non de la ligne en entier \\
            try
            {
                if (dgvPatModif.ColumnCount == dgvPatModif.SelectedRows[0].Cells.Count)
                {
                    tbModifPatID.Text = dgvPatModif.SelectedRows[0].Cells["ID"].Value.ToString();
                    tbModifPatNom.Text = dgvPatModif.SelectedRows[0].Cells["Nom"].Value.ToString();
                    tbModifPatPrenom.Text = dgvPatModif.SelectedRows[0].Cells["Prénom"].Value.ToString();
                    tbModifPatAdresse.Text = dgvPatModif.SelectedRows[0].Cells["Adresse"].Value.ToString();
                    tbModifPatGSM.Text = dgvPatModif.SelectedRows[0].Cells["GSM"].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Merci de bien sélectionner toute la ligne en entier.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnConfirmerModifPat_Click(object sender, EventArgs e)
        {
            if (tbModifPatNom.Text == "" || tbModifPatPrenom.Text == "" || tbModifPatAdresse.Text == "" || tbModifPatGSM.Text == "")
            {
                MessageBox.Show("Veuillez remplir chaque champs de données.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                bool modif_pat = false;

                tbModifPatNom.Text = tbModifPatNom.Text[0].ToString().ToUpper() + tbModifPatNom.Text.Substring(1);
                tbModifPatPrenom.Text = tbModifPatPrenom.Text[0].ToString().ToUpper() + tbModifPatPrenom.Text.Substring(1);

                // On crée la liste des patients de la base de données afin de vérifier si le patient à ajouter existe déjà ou pas \\
                List<C_t_patients> lTmp_Pat = new G_t_patients(sConnexion).Lire("NomPat");
                foreach (C_t_patients p in lTmp_Pat)
                {
                    if (p.IDPat != int.Parse(tbModifPatID.Text))
                    {
                        if (tbModifPatNom.Text == p.NomPat)
                        {
                            if (tbModifPatPrenom.Text == p.PrenomPat)
                            {
                                modif_pat = false;
                            }
                            else
                            {
                                modif_pat = true;
                            }
                        }
                        else
                        {
                            modif_pat = true;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                // Si modif_pat est vrai alors on modifie le patient sinon on affiche un message d'erreur \\
                if (modif_pat)
                {
                    new G_t_patients(sConnexion).Modifier(int.Parse(tbModifPatID.Text), tbModifPatNom.Text, tbModifPatPrenom.Text, tbModifPatAdresse.Text,
                        int.Parse(tbModifPatGSM.Text));
                    MessageBox.Show("Le patient a été modifié.", "Info:", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ViderTB();
                }
                else
                {
                    MessageBox.Show(
                        "Le patient n'a pas été modifié!\nIl existe déjà dans la base de données.",
                        "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViderTB();
                }
            }
            AfficherPatients();
        }

        private void btnAnnulerModifPat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le patient ne sera pas modifié.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            ViderTB();
        }
    }
}
