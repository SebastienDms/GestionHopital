using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            Teste();
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

        private void Teste()
        {
            string sRep = @"C:\Users\sebas\Documents\HEL - Informatique\Fichiers_hopital\Dispo_chambres";
            try
            {
                lvFichier.Items.Clear();
                if (!Directory.Exists(sRep))
                {
                    string[] sTemp = {"Non opérationnel", "", "", ""};
                    lvFichier.Items.Add(new ListViewItem(sTemp, 0));
                }
                else
                {
                    LireFichier(sRep);
                }
            }
            catch (IOException fot)
            {
                MessageBox.Show("Erreur lors de l'accès à " + sRep + " (" + fot.Message + ")");
            }
        }

        private void LireFichier(string sRep)
        {
            lvFichier.Items.Clear();

            try
            {
                string[] sFichiers = Directory.GetFiles(sRep);
                string[] sColonnes = new string[4];
                string stemp1 = "";
                FileInfo fiFichier;
                long tailleFichier;

                foreach (string sf in sFichiers)
                {
                    stemp1 = sf.ToUpper();
                    if (stemp1 != "PAGEFILE.SYS")
                    {
                        fiFichier = new FileInfo(sf);
                        tailleFichier = fiFichier.Length;
                        sColonnes[0] = NomFichier(sf);
                        if (tailleFichier > 1024 * 1024 * 1024)
                        {
                            sColonnes[1] = (tailleFichier / (1024 * 1024 * 1024)).ToString() + " gb";
                        }
                        else if (tailleFichier > 1024 * 1024)
                        {
                            sColonnes[1] = (tailleFichier / (1024 * 1024)).ToString() + " mb";
                        }
                        else if (tailleFichier > 1024)
                        {
                            sColonnes[1] = (tailleFichier / (1024)).ToString() + " kb";
                        }
                        else
                        {
                            sColonnes[1] = tailleFichier.ToString() + " b";
                        }
                        sColonnes[2] = fiFichier.CreationTime.ToString("dd/MM/yyyy");
                        sColonnes[3] = fiFichier.LastWriteTime.ToString("dd/MM/yyyy");
                        lvFichier.Items.Add(new ListViewItem(sColonnes, 0));
                    }
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("Erreur lors de l'accès" + sRep + " (" + e.Message + ")");
            }
        }
        private String NomFichier(string sFichier)
        {
            return sFichier.Substring(1 + sFichier.LastIndexOf('\\'));
        }

        private void lvFichier_ItemActivate(object sender, EventArgs e)
        {
            FileInfo fiFicSelect = new FileInfo(lvFichier.SelectedItems[0].Text);
            string url = @"C:\Users\sebas\Documents\HEL - Informatique\Fichiers_hopital\Dispo_chambres\" + lvFichier.SelectedItems[0].Text;
            //MessageBox.Show(url);
            wbDispoChaSem.Url = new Uri(@url);
        }
    }
}
