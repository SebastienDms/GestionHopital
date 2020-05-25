using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_BD_Hopital.Classes;
using Projet_BD_Hopital.Gestion;

namespace SD_Gestion_Hopital
{
    static class GestionRechercheID
    {
        public static int IDPat(string nom, string prenom)
        {
            int id = 0;
            List<C_t_patients> lTmp_Pat = new G_t_patients(TablesDeDonnees.SConnexion).Lire("ID");
            foreach (C_t_patients p in lTmp_Pat)
            {
                if (nom == p.NomPat && prenom == p.PrenomPat)
                {
                    id = p.IDPat;
                    break;
                }
            }

            return id;
        }

        public static int IDMed(string nom, string prenom)
        {
            int id = 0;
            List<C_t_medecins> lTmp_Med = new G_t_medecins(TablesDeDonnees.SConnexion).Lire("ID");
            foreach (C_t_medecins m in lTmp_Med)
            {
                if (nom == m.NomMed && prenom == m.PrenomMed)
                {
                    id = m.IDMed;
                    break;
                }
            }

            return id;
        }

        public static int IDCha(string numero)
        {
            int id = 0;
            List<C_t_chambres> lTmp_Cha = new G_t_chambres(TablesDeDonnees.SConnexion).Lire("ID");
            foreach (C_t_chambres c in lTmp_Cha)
            {
                if (numero == c.NomCha.ToString())
                {
                    id = c.IDCha;
                    break;
                }
            }

            return id;
        }
    }
}
