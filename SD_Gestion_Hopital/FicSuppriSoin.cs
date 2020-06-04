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
    public partial class EcranSuppriSoin : Form
    {
        #region Donnees
        private DataTable t_soigner;
        private BindingSource bs_soigner;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;

        private List<C_t_soigner> lTmp_Soi;
        private List<C_t_patients> lTmp_Pat;
        private List<C_t_medecins> lTmp_Med;
        #endregion

        public EcranSuppriSoin()
        {
            InitializeComponent();
        }
        private void EcanSuppriSoin_Load(object sender, EventArgs e)
        {
            btnValiderDateOpeOccpSup.Enabled = btnConfirmerSupSoi.Enabled = false;
            dtpDateOpeRechercheOccSup.Value=DateTime.Today;
        }
        private void ViderDGV()
        {
            dgvResRecSoinSup.DataSource = null;
            dgvResRecSoinSup.Invalidate();
        }

        private void dtpDateOpeRechercheOccSup_Enter(object sender, EventArgs e)
        {
            btnValiderDateOpeOccpSup.Enabled = true;
        }

        private void btnValiderDateOpeOccpSup_Click(object sender, EventArgs e)
        {
            tbDateOperationOccSup.Text = dtpDateOpeRechercheOccSup.Value.ToShortDateString();

        }

        private void btnChercherSoiSup_Click(object sender, EventArgs e)
        {
            int id_pat = 0, id_med = 0;
            string Medecin = "", Patient = "";
            t_soigner = new DataTable();
            t_soigner.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_soigner.Columns.Add(new DataColumn("Médecin"));
            t_soigner.Columns.Add(new DataColumn("Patient"));
            t_soigner.Columns.Add(new DataColumn("Opération prévue le"));
            t_soigner.Columns.Add(new DataColumn("Sortie prévue le"));
            t_soigner.Columns.Add(new DataColumn("Coût de l'opération"));
            lTmp_Pat = new G_t_patients(sConnexion).Lire("NomPat");
            // Recherche du patient
            if (tbNomPatRechSoiSup.Text != "" && tbPrenomPatRechSoiSup.Text != "")
            {
                foreach (C_t_patients p in lTmp_Pat)
                {
                    if (tbNomPatRechSoiSup.Text == p.NomPat && tbPrenomPatRechSoiSup.Text == p.PrenomPat)
                    {
                        id_pat = p.IDPat;
                        Patient = p.NomPat + " " + p.PrenomPat;
                        break;
                    }
                }
            }
            lTmp_Med = new G_t_medecins(sConnexion).Lire("NomMed");
            // Recherche du médecin
            if (tbNomMedRechSoiSup.Text != "" && tbPrenomMedRechSoiSup.Text != "")
            {
                foreach (C_t_medecins m in lTmp_Med)
                {
                    if (tbNomMedRechSoiSup.Text == m.NomMed && tbPrenomMedRechSoiSup.Text == m.PrenomMed)
                    {
                        id_med = m.IDMed;
                        Medecin = m.NomMed + " " + m.PrenomMed;
                        break;
                    }
                }
            }
            try
            {
                lTmp_Soi = new G_t_soigner(sConnexion).Lire("IDSoi");
                if (tbDateOperationOccSup.Text != "")
                {
                    if (id_pat != 0 || id_med != 0)
                    {
                        // Recherche de l'opération combiné patient/médecin et date d'opération
                        foreach (C_t_soigner s in lTmp_Soi)
                        {
                            if ((id_pat == s.IDPat || id_med == s.IDMed) &&
                                DateTime.Parse(tbDateOperationOccSup.Text) == s.DateOperation)
                            {
                                foreach (C_t_patients p in lTmp_Pat)
                                {
                                    if (s.IDPat == p.IDPat)
                                    {
                                        Patient = p.NomPat + " " + p.PrenomPat;
                                        break;
                                    }
                                }
                                foreach (C_t_medecins m in lTmp_Med)
                                {
                                    if (s.IDMed == m.IDMed)
                                    {
                                        Medecin = m.NomMed + " " + m.PrenomMed;
                                        break;
                                    }
                                }
                                t_soigner.Rows.Add(s.IDSoi, Medecin, Patient, s.DateOperation.ToShortDateString(),
                                    s.DateAuthorisationSortie.ToShortDateString(), s.PrixOperation.ToString());
                            }
                        }
                        bs_soigner = new BindingSource();
                        bs_soigner.DataSource = t_soigner;
                        dgvResRecSoinSup.DataSource = bs_soigner;
                        btnConfirmerSupSoi.Enabled = true;
                    }
                    else
                    {
                        bool trouve = false;
                        // Recherche par date d'opération
                        foreach (C_t_soigner s in lTmp_Soi)
                        {
                            if (DateTime.Parse(tbDateOperationOccSup.Text) == s.DateOperation)
                            {
                                foreach (C_t_patients p in lTmp_Pat)
                                {
                                    if (s.IDPat == p.IDPat)
                                    {
                                        Patient = p.NomPat + " " + p.PrenomPat;
                                        break;
                                    }
                                }
                                foreach (C_t_medecins m in lTmp_Med)
                                {
                                    if (s.IDMed == m.IDMed)
                                    {
                                        Medecin = m.NomMed + " " + m.PrenomMed;
                                        break;
                                    }
                                }
                                t_soigner.Rows.Add(s.IDSoi, Medecin, Patient, s.DateOperation.ToShortDateString(),
                                    s.DateAuthorisationSortie.ToShortDateString(), s.PrixOperation.ToString());
                                trouve = true;
                            }
                        }
                        if (trouve)
                        {
                            // Affiche si correspond aux citères
                            bs_soigner = new BindingSource();
                            bs_soigner.DataSource = t_soigner;
                            dgvResRecSoinSup.DataSource = bs_soigner;
                            btnConfirmerSupSoi.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Il n'y a pas d'opération prévue le " + tbDateOperationOccSup.Text + " .",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    if (id_pat != 0 || id_med != 0)
                    {
                        // Recherche par patient/médecin
                        foreach (C_t_soigner s in lTmp_Soi)
                        {
                            if (id_pat == s.IDPat || id_med == s.IDMed)
                            {
                                foreach (C_t_patients p in lTmp_Pat)
                                {
                                    if (s.IDPat == p.IDPat)
                                    {
                                        Patient = p.NomPat + " " + p.PrenomPat;
                                        break;
                                    }
                                }
                                foreach (C_t_medecins m in lTmp_Med)
                                {
                                    if (s.IDMed == m.IDMed)
                                    {
                                        Medecin = m.NomMed + " " + m.PrenomMed;
                                        break;
                                    }
                                }
                                t_soigner.Rows.Add(s.IDSoi, Medecin, Patient, s.DateOperation.ToShortDateString(),
                                    s.DateAuthorisationSortie.ToShortDateString(), s.PrixOperation.ToString());
                            }
                        }
                        bs_soigner = new BindingSource();
                        bs_soigner.DataSource = t_soigner;
                        dgvResRecSoinSup.DataSource = bs_soigner;
                        btnConfirmerSupSoi.Enabled = true;
                    }
                    else
                    {
                        if (tbNomPatRechSoiSup.Text == "" && tbPrenomPatRechSoiSup.Text == "" &&
                            tbNomMedRechSoiSup.Text == "" && tbPrenomMedRechSoiSup.Text == "")
                        {
                            MessageBox.Show("Veuillez saisir quelque chose dans la partie recherche.",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ViderDGV();
                        }
                        else
                        {
                            MessageBox.Show("Le patient ou le médecin n'existent pas.",
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
        private void btnConfirmerSupSoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvResRecSoinSup.SelectedRows[0].Selected == true)
                {
                    // Suppression du soin sélectionné
                    if (MessageBox.Show("Souhaitez-vous supprimer l'opération sélectionnée?", "Information",
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information) ==
                        DialogResult.OK)
                    {
                        new G_t_soigner(sConnexion).Supprimer((int) dgvResRecSoinSup.SelectedRows[0].Cells["ID"].Value);
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
                MessageBox.Show("Veuillez sélectionner l'opération à supprimer.",
                    "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAnnulerSupSoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La suppression a été annulée.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
