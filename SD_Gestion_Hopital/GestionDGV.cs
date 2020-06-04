using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_BD_Hopital.Gestion;
using Projet_BD_Hopital.Classes;

namespace SD_Gestion_Hopital
{
    static class GestionDGV
    {
        public static DataTable t_patients;
        public static BindingSource AfficherMedecins()
        {
            DataTable t_medecins = new DataTable();
            //t_medecins.Columns.Add(new DataColumn("IDMed", System.Type.GetType("System.Int32")));
            t_medecins.Columns.Add(new DataColumn("Nom"));
            t_medecins.Columns.Add(new DataColumn("Prénom"));
            t_medecins.Columns.Add(new DataColumn("GSM"));
            t_medecins.Columns.Add(new DataColumn("Spécialité"));
            List<C_t_medecins> lTmp_Med = new G_t_medecins(TablesDeDonnees.SConnexion).Lire("ID");
            List<C_t_specialites> lTmp_Spe = new G_t_specialites(TablesDeDonnees.SConnexion).Lire("ID");
            foreach (C_t_medecins m in lTmp_Med)
            {
                string Nom_Spe = "";

                foreach (C_t_specialites spe in lTmp_Spe)
                {
                    if (m.IDSpe == spe.IDSpe)
                    {
                        Nom_Spe = spe.NomSpe;
                        break;
                    }
                }

                t_medecins.Rows.Add(m.NomMed, m.PrenomMed, m.GSMMed.ToString(), Nom_Spe);
            }
            BindingSource bs_medecins = TablesDeDonnees.bs_medecins;
            bs_medecins.DataSource = t_medecins;
            return bs_medecins;
        }
        public static BindingSource AfficherPatients()
        {
            t_patients = new DataTable();
            //t_patients.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_patients.Columns.Add(new DataColumn("Nom"));
            t_patients.Columns.Add(new DataColumn("Prénom"));
            t_patients.Columns.Add(new DataColumn("Adresse"));
            t_patients.Columns.Add(new DataColumn("GSM"));
            List<C_t_patients> lTmp_Pat = new G_t_patients(TablesDeDonnees.SConnexion).Lire("ID");
            foreach (C_t_patients pat in lTmp_Pat)
            {
                t_patients.Rows.Add(pat.NomPat, pat.PrenomPat, pat.AdressePat, pat.GSMPat.ToString());
            }
            BindingSource bs_patients = TablesDeDonnees.bs_patients;
            bs_patients.DataSource = t_patients;
            return bs_patients;
        }
        public static BindingSource AfficherChambres()
        {
            DataTable t_chambres = new DataTable();
            //t_chambres.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_chambres.Columns.Add(new DataColumn("Numéro"));
            t_chambres.Columns.Add(new DataColumn("Nombre de lit"));
            t_chambres.Columns.Add(new DataColumn("Type"));
            t_chambres.Columns.Add(new DataColumn("Etage"));
            t_chambres.Columns.Add(new DataColumn("Service"));
            List<C_t_chambres> lTmp_Cha = new G_t_chambres(TablesDeDonnees.SConnexion).Lire("ID");
            foreach (C_t_chambres cha in lTmp_Cha)
            {
                t_chambres.Rows.Add(cha.NomCha.ToString(), cha.QuantiteLits.ToString(), cha.TypeCha, cha.EtageCha.ToString(), cha.ServiceCha);
            }
            BindingSource bs_chambres = TablesDeDonnees.bs_chambres;
            bs_chambres.DataSource = t_chambres;
            return bs_chambres;
        }
        public static BindingSource ReafficherPatients()
        {
            t_patients = TablesDeDonnees.t_patients;
            List<C_t_patients> lTmp_Pat = new G_t_patients(TablesDeDonnees.SConnexion).Lire("ID");
            foreach (C_t_patients pat in lTmp_Pat)
            {
                t_patients.Rows.Add(pat.NomPat, pat.PrenomPat, pat.AdressePat, pat.GSMPat.ToString());
            }
            BindingSource bs_patients = TablesDeDonnees.bs_patients;
            bs_patients.DataSource = t_patients;
            return bs_patients;
        }

    }
}
