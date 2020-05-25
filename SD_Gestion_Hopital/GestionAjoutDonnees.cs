using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_BD_Hopital.Gestion;
using Projet_BD_Hopital.Classes;


namespace SD_Gestion_Hopital
{
    static class GestionAjoutDonnees
    {
        public static void AjouterPat(string nom, string prenom, string adresse, string gsm)
        {
            if (nom == "" || prenom == "" || adresse == "" || gsm == "")
            {
                MessageBox.Show("Veuillez remplir chaque champs de données.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                bool ajout_pat = false;

                nom = nom[0].ToString().ToUpper() + nom.Substring(1);
                prenom = prenom[0].ToString().ToUpper() + prenom.Substring(1);

                // On crée la liste des patients de la base de données afin de vérifier si le patient à ajouter existe déjà ou pas \\
                List<C_t_patients> lTmp_Pat = TablesDeDonnees.lTmp_Pat;
                foreach (C_t_patients p in lTmp_Pat)
                {
                    if (nom == p.NomPat)
                    {
                        if (prenom == p.PrenomPat)
                        {
                            ajout_pat = false;
                        }
                        else
                        {
                            ajout_pat = true;
                        }
                    }
                    else
                    {
                        ajout_pat = true;
                    }
                }
                // Si la liste est vide on ajoute le patient \\
                if (lTmp_Pat.Count == 0)
                {
                    ajout_pat = true;
                }
                // Si ajout_pat est vrai alors on ajoute le patient sinon on affiche un message d'erreur \\
                if (ajout_pat)
                {
                    new G_t_patients(TablesDeDonnees.SConnexion).Ajouter(nom, prenom, adresse,int.Parse(gsm));
                    MessageBox.Show("Le patient a été ajouté.", "Info:", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    //tbNomPat.Text = tbPrePat.Text = tbAdrPat.Text = tbGSMPat.Text = "";
                }
                else
                {
                    MessageBox.Show(
                        "Le patient n'a pas été ajoutée!\nIl existe déjà dans la base de données.",
                        "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //tbNomPat.Text = tbPrePat.Text = tbAdrPat.Text = tbGSMPat.Text = "";
                }
            }

        }
    }
}
