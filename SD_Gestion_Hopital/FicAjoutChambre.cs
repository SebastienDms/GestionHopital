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
    public partial class EcranAjoutChambre : Form
    {
        private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";

        public EcranAjoutChambre()
        {
            InitializeComponent();
        }

        private void FicAjoutChambre_Load(object sender, EventArgs e)
        {
            btnConfirmerAjCha.Enabled = btnAnnulerAjCha.Enabled = false;
        }

        private void btnConfirmerAjCha_Click(object sender, EventArgs e)
        {
            if (tbNomCha.Text == "" || tbQuaLitCha.Text == "" || tbTypCha.Text == "" || tbEtaCha.Text == "" || tbServCha.Text == "")
            {
                MessageBox.Show("Veuillez remplir chaque champs de données.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                tbTypCha.Text = tbTypCha.Text[0].ToString().ToUpper() + tbTypCha.Text.Substring(1);
                tbServCha.Text = tbServCha.Text[0].ToString().ToUpper() + tbServCha.Text.Substring(1);
                if (int.Parse(tbQuaLitCha.Text) < 1)
                {
                    MessageBox.Show("Une chambre contient au moins un lit.", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    if (int.Parse(tbQuaLitCha.Text) == 1 && tbTypCha.Text == "Individuelle")
                    {
                        new G_t_chambres(sConnexion).Ajouter(int.Parse(tbNomCha.Text), int.Parse(tbQuaLitCha.Text),
                            tbTypCha.Text, int.Parse(tbEtaCha.Text), tbServCha.Text);
                        MessageBox.Show("La chambre a été ajoutée.", "Info:", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        tbNomCha.Text = tbQuaLitCha.Text = tbTypCha.Text = tbEtaCha.Text = tbServCha.Text = "";
                    }
                    else
                    {
                        if (int.Parse(tbQuaLitCha.Text) > 1 && tbTypCha.Text == "Commune")
                        {
                            new G_t_chambres(sConnexion).Ajouter(int.Parse(tbNomCha.Text), int.Parse(tbQuaLitCha.Text),
                                tbTypCha.Text, int.Parse(tbEtaCha.Text), tbServCha.Text);
                            MessageBox.Show("La chambre a été ajoutée.", "Info:", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            tbNomCha.Text = tbQuaLitCha.Text = tbTypCha.Text = tbEtaCha.Text = tbServCha.Text = "";
                        }
                        else
                        {
                            MessageBox.Show(
                                "La chambre n'a pas été ajoutée!\nVérifiez que le type de chambre correspond à la quantité de lit indiquée.",
                                "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnAnnulerAjCha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La chambre ne sera pas ajoutée.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            tbNomCha.Text = tbQuaLitCha.Text = tbTypCha.Text = tbEtaCha.Text = tbServCha.Text = "";
        }

        private void tbNomCha_Click(object sender, EventArgs e)
        {
            btnConfirmerAjCha.Enabled = btnAnnulerAjCha.Enabled = true;
        }
    }
}
