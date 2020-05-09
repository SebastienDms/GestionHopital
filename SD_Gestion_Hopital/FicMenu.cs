using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_Gestion_Hopital
{
    public partial class FicMenu : Form
    {
        public FicMenu()
        {
            InitializeComponent();
        }

        private void FicMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

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

        }

        private void patientToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void priseEnChargeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void soinToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
