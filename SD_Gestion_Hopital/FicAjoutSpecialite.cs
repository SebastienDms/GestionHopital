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
    public partial class EcranAjoutSpecialite : Form
    {
        private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        public EcranAjoutSpecialite()
        {
            InitializeComponent();
        }

        private void btnConfirmerAj_Click(object sender, EventArgs e)
        {
            if (tbNomSpe.Text == "")
            {
                MessageBox.Show("Veuillez saisir le nom de la spécialité à ajouter.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                // Force la majuscule au nom de la spécialité \\
                tbNomSpe.Text = tbNomSpe.Text[0].ToString().ToUpper() + tbNomSpe.Text.Substring(1);

                new G_t_specialites(sConnexion).Ajouter(tbNomSpe.Text);
                MessageBox.Show("La spécialité a été ajoutée.", "Info:", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                tbNomSpe.Text = "";
            }
        }

        private void btnAnnulerAj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La spécialité ne sera pas ajoutée.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            tbNomSpe.Text = "";
        }
    }
}
