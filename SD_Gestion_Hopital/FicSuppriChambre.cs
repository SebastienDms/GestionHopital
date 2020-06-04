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
    public partial class EcranSuppriChambre : Form
    {
        #region Donnees
        private DataTable t_chambres;
        private BindingSource bs_chambres;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;
        private List<C_t_chambres> lTmp_Cha;
        #endregion

        public EcranSuppriChambre()
        {
            InitializeComponent();
        }

        private void FicSuppriChambre_Load(object sender, EventArgs e)
        {
            btnChercherCha.Enabled = false;
        }
        private void AfficherChambres()
        {
            t_chambres = new DataTable();
            t_chambres.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_chambres.Columns.Add(new DataColumn("Numéro"));
            t_chambres.Columns.Add(new DataColumn("Nombre de lit"));
            t_chambres.Columns.Add(new DataColumn("Type"));
            t_chambres.Columns.Add(new DataColumn("Etage"));
            t_chambres.Columns.Add(new DataColumn("Service"));
            lTmp_Cha = new G_t_chambres(sConnexion).Lire("NomCha");
            foreach (C_t_chambres c in lTmp_Cha)
            {
                t_chambres.Rows.Add(c.IDCha, c.NomCha.ToString(), c.QuantiteLits.ToString(), c.TypeCha, c.EtageCha.ToString(), c.ServiceCha);
            }
            bs_chambres = new BindingSource();
            bs_chambres.DataSource = t_chambres;
            dgvChaSup.DataSource = bs_chambres;
        }
        private void ViderTBResultat()
        {
            tbIDChaSup.Text = tbNomChaSup.Text = tbQuantLitChaSup.Text =
                tbTypeChaSup.Text = tbEtageChaSup.Text = tbServiceChaSup.Text = "";
        }

        private void ViderAllTB()
        {
            ViderTBResultat();
            tbNomChaRech.Text = "";
        }
        private void ViderDGV()
        {
            dgvChaSup.DataSource = null;
            dgvChaSup.Invalidate();
        }
        private void ViderRecherche()
        {
            ViderAllTB();
            ViderDGV();
        }

        private void tbNomChaRech_Click(object sender, EventArgs e)
        {
            btnChercherCha.Enabled = true;
            ViderDGV();
        }

        private void btnChercherCha_Click(object sender, EventArgs e)
        {
            ViderTBResultat();
            try
            {
                lTmp_Cha = new G_t_chambres(sConnexion).Lire("NomCha");
                foreach (C_t_chambres c in lTmp_Cha)
                {
                    if (int.Parse(tbNomChaRech.Text) == c.NomCha)
                    {
                        tbIDChaSup.Text = c.IDCha.ToString();
                        tbNomChaSup.Text = c.NomCha.ToString();
                        tbQuantLitChaSup.Text = c.QuantiteLits.ToString();
                        tbTypeChaSup.Text = c.TypeCha;
                        tbEtageChaSup.Text = c.EtageCha.ToString();
                        tbServiceChaSup.Text = c.ServiceCha;
                        break;
                    }
                }
                // On teste si la recherche à trouvé l'élément \\
                if (tbIDChaSup.Text == "")
                {
                    MessageBox.Show("La chambre n'a pas été trouvée.\nSoit elle n'existe pas soit il y a une faute dans la barre de recherche.",
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
        private void btnAfficherListeCha_Click(object sender, EventArgs e)
        {
            AfficherChambres();
        }
        private void btnConfirmerSupCha_Click(object sender, EventArgs e)
        {
            int ID_Sup = 0;
            if (tbIDChaSup.Text != "")
            {
                // Récupération de l'ID de la chambre à supprimer
                ID_Sup = int.Parse(tbIDChaSup.Text);
                if (MessageBox.Show("Souhaitez-vous supprimer la chambre " +
                                    tbNomChaSup.Text + " ?",
                    "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK
                )
                {
                    try
                    {
                        new G_t_chambres(sConnexion).Supprimer(ID_Sup);
                        MessageBox.Show("Suppression effectuée.", "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ViderRecherche();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Impossible de supprimer la chambre pour une question intégrité/historique des données.",
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
                    if (dgvChaSup.SelectedRows[0].Selected == true)
                    {
                        ID_Sup = (int)dgvChaSup.SelectedRows[0].Cells["ID"].Value;
                        if (MessageBox.Show("Souhaitez-vous supprimer la chambre " +
                                            dgvChaSup.SelectedRows[0].Cells["Numéro"].Value.ToString() + " ?",
                                "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) ==
                            DialogResult.OK
                        )
                        {
                            try
                            {
                                new G_t_chambres(sConnexion).Supprimer(ID_Sup);
                                MessageBox.Show("Suppression effectuée.", "Information", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                ViderRecherche();
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show("Impossible de supprimer ce médecin pour une question intégrité/historique des données.",
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
                    MessageBox.Show("Veuillez effectuer une recherche ou sélectionner la chambre à supprimer.",
                        "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }
        private void btnAnnulerSupCha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La suppression a été annulée.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            ViderRecherche();
        }
    }
}
