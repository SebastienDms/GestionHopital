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
    public partial class EcranVisionneuseHTML : Form
    {
        public EcranVisionneuseHTML()
        {
            InitializeComponent();
        }

        private void EcranVisionneuseHTML_Load(object sender, EventArgs e)
        {
            wbDispoChaSem.Url= new Uri(@"C:\Users\sebas\Documents\HEL - Informatique\Fichiers_hopital\accueil.html");
        }

        private void btnOuvrirDossier_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\sebas\Documents\HEL - Informatique\Fichiers_hopital\Dispo_chambres";
            // Affiche uniquement les fichier .html \\
            ofd.Filter = "Fichiers HTML |*.html";
            // Permet de sélectionner un fichier à la fois \\
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string url = string.Empty;
                // Récupère le chemin d'accès du fichier sélectionné \\
                url = ofd.FileName;
                // Lecture du fichier sélectionné dans la visionneuse \\
                wbDispoChaSem.Url = new Uri(@url);
            }
            
        }
    }
}
