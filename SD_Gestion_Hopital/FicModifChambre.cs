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
    public partial class EcranModifChambre : Form
    {
        private DataTable t_chambres;
        private BindingSource bs_chambres;
        private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        List<C_t_chambres> lTmp_Cha;

        public EcranModifChambre()
        {
            InitializeComponent();
        }

        private void EcranModifChambre_Load(object sender, EventArgs e)
        {
            AfficherChambres();
        }
        private void AfficherChambres()
        {
            t_chambres = new DataTable();
            t_chambres.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_chambres.Columns.Add(new DataColumn("Nom"));
            t_chambres.Columns.Add(new DataColumn("Nombre de lit"));
            t_chambres.Columns.Add(new DataColumn("Type"));
            t_chambres.Columns.Add(new DataColumn("Etage"));
            t_chambres.Columns.Add(new DataColumn("Service"));
            lTmp_Cha = new G_t_chambres(sConnexion).Lire("NomCha");
            foreach (C_t_chambres c in lTmp_Cha)
            {
                t_chambres.Rows.Add(c.IDCha, c.NomCha, c.QuantiteLits, c.TypeCha, c.EtageCha, c.ServiceCha);
            }
            bs_chambres = new BindingSource();
            bs_chambres.DataSource = t_chambres;
            dgvChambresModif.DataSource = bs_chambres;
        }

        private void ViderTB()
        {
            tbIDCha.Text = tbModifChaNom.Text = tbModifQuantiteLit.Text = tbModifTypeCha.Text = tbModifEtageCha.Text = tbModifServiceCha.Text = "";
        }
        // test count row et column  ==> colonnes correspondent /!\ ligne compte en plus la ligne vide en fin de liste \\
        //MessageBox.Show("Le nombre de colonne est de : " + dgvChambresModif.ColumnCount.ToString() + " ." +
        //"Le nombre de ligne est de : " + dgvChambresModif.RowCount.ToString() + " .");
        // test comparatif nbr colonne datagrid et colonne ligne sélectionnée \\
        //MessageBox.Show("Le nombre de colonne est de : " + dgvChambresModif.ColumnCount.ToString() + " ." +
        //"Le nombre de colonne sélec est de : " + dgvChambresModif.SelectedRows[0].Cells.Count.ToString() + " .");

        private void btnModifCha_Click(object sender, EventArgs e)
        {
            // Try catch pour gérer l'erreur en cas de selection d'une cellule et non de la ligne en entier \\
            try
            {
                if (dgvChambresModif.ColumnCount == dgvChambresModif.SelectedRows[0].Cells.Count)
                {
                    tbIDCha.Text = dgvChambresModif.SelectedRows[0].Cells["ID"].Value.ToString();
                    tbModifChaNom.Text = dgvChambresModif.SelectedRows[0].Cells["Nom"].Value.ToString();
                    tbModifQuantiteLit.Text = dgvChambresModif.SelectedRows[0].Cells["Nombre de lit"].Value.ToString();
                    tbModifTypeCha.Text = dgvChambresModif.SelectedRows[0].Cells["Type"].Value.ToString();
                    tbModifEtageCha.Text = dgvChambresModif.SelectedRows[0].Cells["Etage"].Value.ToString();
                    tbModifServiceCha.Text = dgvChambresModif.SelectedRows[0].Cells["Service"].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Merci de bien sélectionner toute la ligne en entier.", "Attention",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmerModifCha_Click(object sender, EventArgs e)
        {
            if (tbModifChaNom.Text == "" || tbModifQuantiteLit.Text == "" || tbModifTypeCha.Text == "" || tbModifEtageCha.Text == "" || tbModifServiceCha.Text == "")
            {
                MessageBox.Show("Veuillez remplir chaque champs de données.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                tbModifTypeCha.Text = tbModifTypeCha.Text[0].ToString().ToUpper() + tbModifTypeCha.Text.Substring(1);
                tbModifServiceCha.Text = tbModifServiceCha.Text[0].ToString().ToUpper() + tbModifServiceCha.Text.Substring(1);
                if (int.Parse(tbModifQuantiteLit.Text) < 1)
                {
                    MessageBox.Show("Une chambre contient au moins un lit.", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    if (int.Parse(tbModifQuantiteLit.Text) == 1 && tbModifTypeCha.Text == "Individuelle")
                    {
                        new G_t_chambres(sConnexion).Modifier(int.Parse(tbIDCha.Text), int.Parse(tbModifChaNom.Text),
                                    int.Parse(tbModifQuantiteLit.Text),
                                    tbModifTypeCha.Text, int.Parse(tbModifEtageCha.Text), tbModifServiceCha.Text);
                        MessageBox.Show("La chambre a été modifiée.", "Info:", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ViderTB();
                    }
                    else
                    {
                        if (int.Parse(tbModifQuantiteLit.Text) > 1 && tbModifTypeCha.Text == "Commune")
                        {
                            new G_t_chambres(sConnexion).Modifier(int.Parse(tbIDCha.Text), 
                                        int.Parse(tbModifChaNom.Text), int.Parse(tbModifQuantiteLit.Text), 
                                        tbModifTypeCha.Text, int.Parse(tbModifEtageCha.Text), tbModifServiceCha.Text);
                            MessageBox.Show("La chambre a été modifiée.", "Info:", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ViderTB();
                        }
                        else
                        {
                            MessageBox.Show(
                                "La chambre ne sera pas modifiée!\nVérifiez que le type de chambre correspond à la quantité de lit indiquée.",
                                "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            AfficherChambres();
        }

        private void btnAnnulerModifCha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La chambre ne sera pas modifiée.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            ViderTB();
        }
    }
}
