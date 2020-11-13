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
using System.Windows.Forms.VisualStyles;

namespace SD_Gestion_Hopital
{
    public partial class EcranSuppriOccupation : Form
    {
        #region Donnees
        private DataTable t_occuper;
        private BindingSource bs_occuper;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;

        private List<C_t_occuper> lTmp_Occ;
        private List<C_t_patients> lTmp_Pat;
        private List<C_t_chambres> lTmp_Cha;
        #endregion

        public EcranSuppriOccupation()
        {
            InitializeComponent();
        }

        private void EcranSuppriOccupation_Load(object sender, EventArgs e)
        {
            btnConfirmerSupOcc.Enabled = btnValiderDateEntrreOccpSup.Enabled = false;
            dtpDateEntreeRechercheOccSup.Value = DateTime.Today;
        }
        private void ViderDGV()
        {
            dgvResRecOccpSup.DataSource = null;
            dgvResRecOccpSup.Invalidate();
        }

        private void dtpDateEntreeRechercheOccSup_Enter(object sender, EventArgs e)
        {
            btnValiderDateEntrreOccpSup.Enabled = true;
        }
        private void dtpDateEntreeRechercheOccSup_Leave(object sender, EventArgs e)
        {
            //btnValiderDateEntrreOccpSup.Enabled = true;
        }
        private void btnValiderDateEntrreOccpSup_Click(object sender, EventArgs e)
        {
            tbDateEntreeOccSup.Text = dtpDateEntreeRechercheOccSup.Value.ToShortDateString();
        }
        private void btnChercherOccSup_Click(object sender, EventArgs e)
        {
            int id_pat = 0, id_cha = 0;
            t_occuper = new DataTable();
            t_occuper.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_occuper.Columns.Add(new DataColumn("Patient"));
            t_occuper.Columns.Add(new DataColumn("Chambre"));
            t_occuper.Columns.Add(new DataColumn("Entrée le"));
            t_occuper.Columns.Add(new DataColumn("Sortie le"));
            t_occuper.Columns.Add(new DataColumn("Coût journalier"));
            lTmp_Pat = new G_t_patients(sConnexion).Lire("NomPat");
            // Recheche du patient
            if (tbNomPatRechOccSup.Text != "" && tbPrenomPatRechOccSup.Text != "")
            {
                foreach (C_t_patients p in lTmp_Pat)
                {
                    if (tbNomPatRechOccSup.Text == p.NomPat && tbPrenomPatRechOccSup.Text == p.PrenomPat)
                    {
                        id_pat = p.IDPat;
                        break;
                    }
                }
            }
            // Recherche de la chambre
            lTmp_Cha = new G_t_chambres(sConnexion).Lire("NomCha");
            if (tbNomChaRechOccSup.Text != "")
            {
                foreach (C_t_chambres c in lTmp_Cha)
                {
                    if (int.Parse(tbNomChaRechOccSup.Text) == c.NomCha)
                    {
                        id_cha = c.IDCha;
                        break;
                    }
                }
            }

            try
            {
                lTmp_Occ = new G_t_occuper(sConnexion).Lire("IDOcc");
                if (tbDateEntreeOccSup.Text != "")
                {
                    // Recherche combinée date entrée et patient ou chambre
                    if (id_pat != 0 || id_cha != 0)
                    {
                        foreach (C_t_occuper o in lTmp_Occ)
                        {
                            if ((id_pat == o.IDPat || id_cha == o.IDCha) && DateTime.Parse(tbDateEntreeOccSup.Text) == o.DateEntree)
                            {
                                t_occuper.Rows.Add(o.IDOcc, o.IDPat, o.IDCha, o.DateEntree.ToShortDateString(),
                                    o.DateSortie.ToString(), o.PrixJournalier.ToString());
                            }
                        }
                        bs_occuper = new BindingSource();
                        bs_occuper.DataSource = t_occuper;
                        dgvResRecOccpSup.DataSource = bs_occuper;
                        btnConfirmerSupOcc.Enabled = true;
                    }
                    else
                    {
                        bool trouve = false;
                        // Recherche par date d'entrée
                        foreach (C_t_occuper o in lTmp_Occ)
                        {
                            if (DateTime.Parse(tbDateEntreeOccSup.Text) == o.DateEntree)
                            {
                                t_occuper.Rows.Add(o.IDOcc, o.IDPat, o.IDCha, o.DateEntree.ToShortDateString(),
                                    o.DateSortie.ToString(), o.PrixJournalier.ToString());
                                trouve = true;
                            }
                        }

                        if (trouve)
                        {
                            // Affiche si une occupation correspond aux citères
                            bs_occuper = new BindingSource();
                            bs_occuper.DataSource = t_occuper;
                            dgvResRecOccpSup.DataSource = bs_occuper;
                            btnConfirmerSupOcc.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Il n'y a pas de chambre occupée le " + tbDateEntreeOccSup.Text + " .",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    if (id_pat != 0 || id_cha != 0)
                    {
                        // Recherche combinée patient et chambre
                        foreach (C_t_occuper o in lTmp_Occ)
                        {
                            if (id_pat == o.IDPat || id_cha == o.IDCha)
                            {
                                t_occuper.Rows.Add(o.IDOcc, o.IDPat, o.IDCha, o.DateEntree.ToShortDateString(),
                                    o.DateSortie.ToString(), o.PrixJournalier.ToString());
                            }
                        }
                        bs_occuper = new BindingSource();
                        bs_occuper.DataSource = t_occuper;
                        dgvResRecOccpSup.DataSource = bs_occuper;
                        btnConfirmerSupOcc.Enabled = true;
                    }
                    else
                    {
                        if (tbNomPatRechOccSup.Text == "" && tbPrenomPatRechOccSup.Text == "" && tbNomChaRechOccSup.Text =="")
                        {
                            MessageBox.Show("Veuillez saisir quelque chose dans la partie recherche.",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ViderDGV();
                        }
                        else
                        {
                            MessageBox.Show("Le patient ou la chambre n'existent pas.",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Veuillez saisir quelque chose dans la partie recherche.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViderDGV();
            }
        }

        private void btnConfirmerSupOcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvResRecOccpSup.SelectedRows[0].Selected == true)
                {
                    if (MessageBox.Show("Souhaitez-vous supprimer l'occupation de la chambre?","Information",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information) ==
                        DialogResult.OK)
                    {
                        new G_t_occuper(sConnexion).Supprimer((int)dgvResRecOccpSup.SelectedRows[0].Cells["ID"].Value);
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
                MessageBox.Show("Veuillez sélectionner l'élément à supprimer.",
                    "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAnnulerSupOcc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La suppression a été annulée.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
