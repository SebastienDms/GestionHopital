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
    public partial class EcranAjoutPatient : Form
    {
        #region Donnees
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;
        #endregion

        public EcranAjoutPatient()
        {
            InitializeComponent();
        }
        private void EcranAjoutPatient_Load(object sender, EventArgs e)
        {
            btnConfirmerAjPat.Enabled = btnAnnulerAjPat.Enabled = false;
        }
        private void tbNomPat_Click(object sender, EventArgs e)
        {
            btnConfirmerAjPat.Enabled = btnAnnulerAjPat.Enabled = true;
        }
        private void btnConfirmerAjPat_Click(object sender, EventArgs e)
        {
            if (tbNomPat.Text == "" || tbPrePat.Text == "" || tbAdrPat.Text == "" || tbGSMPat.Text == "")
            {
                MessageBox.Show("Veuillez remplir chaque champs de données.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                bool ajout_pat=false;
                // Majuscule pour les noms et prénoms
                tbNomPat.Text = tbNomPat.Text[0].ToString().ToUpper() + tbNomPat.Text.Substring(1);
                tbPrePat.Text = tbPrePat.Text[0].ToString().ToUpper() + tbPrePat.Text.Substring(1);
                
                // On crée la liste des patients de la base de données afin de vérifier si le patient à ajouter existe déjà ou pas \\
                List<C_t_patients> lTmp_Pat = new G_t_patients(sConnexion).Lire("Nom");
                foreach (C_t_patients p in lTmp_Pat)
                {
                    if (tbNomPat.Text == p.NomPat)
                    {
                        if (tbPrePat.Text == p.PrenomPat)
                        {
                            ajout_pat = false;
                        }
                        else
                        {
                            ajout_pat = true;
                        }
                    }
                    else
                    {
                        ajout_pat = true;
                    }
                }
                // Si la liste est vide on ajoute le patient \\
                if (lTmp_Pat.Count == 0)
                {
                    ajout_pat = true;
                }
                // Si ajout_pat est vrai alors on ajoute le patient sinon on affiche un message d'erreur \\
                if (ajout_pat)
                {
                    new G_t_patients(sConnexion).Ajouter(tbNomPat.Text, tbPrePat.Text, tbAdrPat.Text,
                        int.Parse(tbGSMPat.Text));
                    MessageBox.Show("Le patient a été ajouté.", "Info:", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    tbNomPat.Text = tbPrePat.Text = tbAdrPat.Text = tbGSMPat.Text = "";
                }
                else
                {
                    MessageBox.Show(
                        "Le patient n'a pas été ajoutée!\nIl existe déjà dans la base de données.",
                        "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbNomPat.Text = tbPrePat.Text = tbAdrPat.Text = tbGSMPat.Text = "";
                }
            }
        }
        private void btnAnnulerAjPat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le patient ne sera pas ajouté.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            tbNomPat.Text = tbPrePat.Text = tbAdrPat.Text = tbGSMPat.Text = "";
        }
    }
}
