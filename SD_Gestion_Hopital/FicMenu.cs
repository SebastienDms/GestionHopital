using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_Gestion_Hopital
{
    public partial class FicMenu : Form
    {
        #region Donnees
        private int i = 0;
        #endregion

        #region Accesseurs
        public int I
        {
            get => i;
            set
            {
                i = value;
                if (i < 0)
                {
                    i = 0;
                }
            }
        }
        #endregion
        public FicMenu()
        {
            InitializeComponent();
            dataGridView1.DataSource = GestionDGV.AfficherMedecins();
            dataGridView2.DataSource = GestionDGV.AfficherPatients();
            dataGridView3.DataSource = GestionDGV.AfficherChambres();
            gbAj.Visible = false;
        }
        private void FicMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            monthCalendar2.MinDate = DateTime.Today;
        }
        #region BarreMenu
        #region Affichage
        private void TSMAfSpécialités_Click(object sender, EventArgs e)
        {
            EcranSpecialites eAfSpe = new EcranSpecialites();
            eAfSpe.ShowDialog();
        }

        private void TSMAfMédecins_Click(object sender, EventArgs e)
        {
            EcranMedecins eAfMed = new EcranMedecins();
            eAfMed.ShowDialog();
        }

        private void TSMAfChambres_Click(object sender, EventArgs e)
        {
            EcranChambres eAfCha = new EcranChambres();
            eAfCha.ShowDialog();
        }

        private void TSMAfPatients_Click(object sender, EventArgs e)
        {
            EcranPatients eAfPat = new EcranPatients();
            eAfPat.ShowDialog();
        }

        private void TSMAfOccuper_Click(object sender, EventArgs e)
        {
            EcranOccuper eAfOcc = new EcranOccuper();
            eAfOcc.ShowDialog();
        }

        private void TSMAfSoigner_Click(object sender, EventArgs e)
        {
            EcranSoigner eAfSoi = new EcranSoigner();
            eAfSoi.ShowDialog();
        }
        #endregion

        #region Ajout
        private void TSMAjSpécialité_Click(object sender, EventArgs e)
        {
            EcranAjoutSpecialite eAjSpe = new EcranAjoutSpecialite();
            eAjSpe.ShowDialog();
        }

        private void TSMAjMédecin_Click(object sender, EventArgs e)
        {
            EcranAjoutMedecin eAjMed = new EcranAjoutMedecin();
            eAjMed.ShowDialog();
        }

        private void TSMAjChambre_Click(object sender, EventArgs e)
        {
            EcranAjoutChambre eAjCha = new EcranAjoutChambre();
            eAjCha.ShowDialog();
        }

        private void TSMAjPatient_Click(object sender, EventArgs e)
        {
            EcranAjoutPatient eAjPat = new EcranAjoutPatient();
            eAjPat.ShowDialog();
        }

        private void TSMAjOccuper_Click(object sender, EventArgs e)
        {
            EcranAjoutOccupation eAjOcc = new EcranAjoutOccupation();
            eAjOcc.ShowDialog();
        }

        private void TSMAjSoigner_Click(object sender, EventArgs e)
        {
            EcranAjoutSoin eAjSoi = new EcranAjoutSoin();
            eAjSoi.ShowDialog();
        }
        #endregion

        #region Modification
        private void spécialitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranModifSpecialite eModSpe = new EcranModifSpecialite();
            eModSpe.ShowDialog();
        }

        private void médecinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranModifMedecin eModMed = new EcranModifMedecin();
            eModMed.ShowDialog();
        }

        private void chambresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranModifChambre eModCha = new EcranModifChambre();
            eModCha.ShowDialog();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranModifPatient eModPat = new EcranModifPatient();
            eModPat.ShowDialog();
        }

        private void priseEnChargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranModifOccupation eModOcc = new EcranModifOccupation();
            eModOcc.ShowDialog();
        }

        private void soinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranModifSoin eModSoi = new EcranModifSoin();
            eModSoi.ShowDialog();
        }
        #endregion

        #region Suppression
        private void spécilitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranSuppriSpecialite eSupSpe = new EcranSuppriSpecialite();
            eSupSpe.ShowDialog();
        }

        private void médecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranSuppriMedecin eSupMed = new EcranSuppriMedecin();
            eSupMed.ShowDialog();
        }

        private void chambreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranSuppriChambre eSupCha = new EcranSuppriChambre();
            eSupCha.ShowDialog();
        }

        private void patientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EcranSuppriPatient eSupPat = new EcranSuppriPatient();
            eSupPat.ShowDialog();
        }

        private void priseEnChargeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EcranSuppriOccupation eSupOcc= new EcranSuppriOccupation();
            eSupOcc.ShowDialog();
        }

        private void soinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EcranSuppriSoin eSupSoi = new EcranSuppriSoin();
            eSupSoi.ShowDialog();
        }

        #endregion
        #region Options
        private void hitParadeMédecinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranHitParadeMedecins eHitPar = new EcranHitParadeMedecins();
            eHitPar.ShowDialog();
        }

        private void facturationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranFacturationDuJour eFacJour = new EcranFacturationDuJour();
            eFacJour.ShowDialog();
        }

        private void disponibilitéDesChambresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranDisponibiliteChambres eDispoCha = new EcranDisponibiliteChambres();
            eDispoCha.ShowDialog();
        }

        private void visionneuseHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranVisionneuseHTML eVisHTML = new EcranVisionneuseHTML();
            eVisHTML.ShowDialog();
        }
        #endregion
        #endregion

        #region TableauDeBord

        private void ViderTB()
        {
            tbAjID1.Text = tbAjID2.Text = tbAjDateIn.Text = tbAjDateOut.Text = tbAjPrix.Text = "";
        }
        private void AfficherMed()
        {
            dataGridView1.DataSource = GestionDGV.AfficherMedecins();
        }

        private void AfficherPat()
        {
            dataGridView2.DataSource = GestionDGV.AfficherPatients();
        }

        private void AfficherCha()
        {
            dataGridView3.DataSource = GestionDGV.AfficherChambres();
        }

        private void btnAjouterPat_Click(object sender, EventArgs e)
        {
            try
            {
                GestionAjoutDonnees.AjouterPat(dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells["Nom"].Value.ToString(),
                    dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells["Prénom"].Value.ToString(),
                    dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells["Adresse"].Value.ToString(),
                    dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells["GSM"].Value.ToString());
                ViderDGV2();
                dataGridView2.DataSource = GestionDGV.ReafficherPatients();
                dataGridView2.AllowUserToAddRows = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Veuillez remplir la dernière ligne de la grille!", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void ViderDGV2()
        {
            GestionDGV.t_patients.Clear();
            dataGridView2.DataSource = null;
            dataGridView2.Invalidate();
        }
        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ReadOnly = false;
        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                I = 0;
                GestionDisponibilite.AfficherDispoCha(dataGridView3.SelectedRows[0].Cells["Numéro"].Value.ToString(), dgvDispoChambre, I);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Veuillez choisir la chambre!", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void btnSemaineSuivante_Click(object sender, EventArgs e)
        {
            try
            {
                I++;
                GestionDisponibilite.AfficherDispoCha(dataGridView3.SelectedRows[0].Cells["Numéro"].Value.ToString(), dgvDispoChambre, I);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Veuillez choisir la chambre!", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnSemainePrecedente_Click(object sender, EventArgs e)
        {
            try
            {
                I--;
                GestionDisponibilite.AfficherDispoCha(dataGridView3.SelectedRows[0].Cells["Numéro"].Value.ToString(), dgvDispoChambre, I);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Veuillez choisir la chambre!", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            monthCalendar1.BoldedDates = GestionDisponibilite.DispoMed(dataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString(),
                dataGridView1.SelectedRows[0].Cells["Prénom"].Value.ToString()).ToArray();
            monthCalendar1.UpdateBoldedDates();
        }

        private void btnAjouterRDV_Click(object sender, EventArgs e)
        {
            ViderTB();
            gbAj.Text = "Fiche d'opération :";
            lblFicheAjID1.Text = "Patient :";
            lblFicheAjID2.Text = "Médecin :";
            lblFicheAjDateIn.Text = "Date d'opération :";
            lblFicheAjDateOut.Text = "Sortie prévue le :";
            btnAjDateIn.Text = "Ajouter date d'opération";
            btnAjDateOut.Text = "Ajouter date de sortie prévue";
            lblFicheAjPrix.Text = "Prix de l'opération :";
            gbAj.Visible = true;
        }

        private void btnAjouterOcc_Click(object sender, EventArgs e)
        {
            ViderTB();
            gbAj.Text = "Fiche de prise en charge :";
            lblFicheAjID1.Text = "Patient :";
            lblFicheAjID2.Text = "Chambre :";
            lblFicheAjDateIn.Text = "Date d'entrée :";
            lblFicheAjDateOut.Text = "Date de sortie :";
            btnAjDateIn.Text = "Ajouter date d'entrée";
            btnAjDateOut.Text = "Ajouter date de sortie";
            lblFicheAjPrix.Text = "Prix journalier :";
            gbAj.Visible = true;
        }

        private void btnAjouterID1_Click(object sender, EventArgs e)
        {
            try
            {
                string nom_pat = dataGridView2.SelectedRows[0].Cells["Nom"].Value.ToString(),
                    prenom_pat = dataGridView2.SelectedRows[0].Cells["Prénom"].Value.ToString();
                tbAjID1.Text = GestionRechercheID.IDPat(nom_pat, prenom_pat).ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Veuillez sélectionner le patient!", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void btnAjouterID2_Click(object sender, EventArgs e)
        {
            if (lblFicheAjID2.Text == "Médecin :")
            {
                try
                {
                    string nom_med = dataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString(),
                        prenom_med = dataGridView1.SelectedRows[0].Cells["Prénom"].Value.ToString();
                    tbAjID2.Text = GestionRechercheID.IDMed(nom_med, prenom_med).ToString();

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Veuillez sélectionner le médecin!", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }

            if (lblFicheAjID2.Text == "Chambre :")
            {
                try
                {
                    string numero = dataGridView3.SelectedRows[0].Cells["Numéro"].Value.ToString();
                    tbAjID2.Text = GestionRechercheID.IDCha(numero).ToString();

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Veuillez sélectionner la chambre!", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }
        private void btnAjDateIn_Click(object sender, EventArgs e)
        {
            tbAjDateIn.Text = monthCalendar2.SelectionStart.ToShortDateString().ToString();
        }

        private void btnAjDateOut_Click(object sender, EventArgs e)
        {
            tbAjDateOut.Text = monthCalendar2.SelectionStart.ToShortDateString().ToString();
        }

        private void btnConfirmerAj_Click(object sender, EventArgs e)
        {
            if (gbAj.Text == "Fiche d'opération :")
            {
                string nom_pat = dataGridView2.SelectedRows[0].Cells["Nom"].Value.ToString(),
                    prenom_pat = dataGridView2.SelectedRows[0].Cells["Prénom"].Value.ToString(),
                    nom_med = dataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString(),
                    prenom_med = dataGridView1.SelectedRows[0].Cells["Prénom"].Value.ToString();

                GestionAjoutDonnees.AjouterSoi(GestionRechercheID.IDPat(nom_pat, prenom_pat).ToString(), nom_pat, prenom_pat,
                    GestionRechercheID.IDMed(nom_med, prenom_med).ToString(), nom_med, prenom_med, tbAjDateIn.Text,
                    tbAjDateOut.Text, tbAjPrix.Text);
            }

            if (gbAj.Text == "Fiche de prise en charge :")
            {
                string nom_pat = dataGridView2.SelectedRows[0].Cells["Nom"].Value.ToString(),
                    prenom_pat = dataGridView2.SelectedRows[0].Cells["Prénom"].Value.ToString(),
                    numero = dataGridView3.SelectedRows[0].Cells["Numéro"].Value.ToString();

                GestionAjoutDonnees.AjouterOcc(GestionRechercheID.IDPat(nom_pat,prenom_pat).ToString(), nom_pat, prenom_pat,GestionRechercheID.IDCha(numero).ToString(),
                    numero, tbAjDateIn.Text, tbAjDateOut.Text, tbAjPrix.Text);
            }
        }

        private void btnAnnulerAj_Click(object sender, EventArgs e)
        {
            if (gbAj.Text == "Fiche d'opération :")
            {
                MessageBox.Show("La coordination de l'opération a été annulée.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (gbAj.Text == "Fiche de prise en charge :")
            {
                MessageBox.Show("La réservation ne sera pas ajoutée.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        #endregion

    }
}
