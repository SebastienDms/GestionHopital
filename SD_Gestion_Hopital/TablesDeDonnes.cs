using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Projet_BD_Hopital.Gestion;
using Projet_BD_Hopital.Classes;

namespace SD_Gestion_Hopital
{
    static class TablesDeDonnees
    {
        #region ChaineDeConnexionDB
        private static string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";

        #endregion
        #region Datatables
        public static DataTable t_specialites = new DataTable();
        public static BindingSource bs_specialites = new BindingSource();
        public static DataTable t_medecins = new DataTable();
        public static BindingSource bs_medecins = new BindingSource();
        public static DataTable t_chambres = new DataTable();
        public static BindingSource bs_chambres = new BindingSource();
        public static DataTable t_patients = new DataTable();
        public static BindingSource bs_patients = new BindingSource();
        public static DataTable t_occuper = new DataTable();
        public static BindingSource bs_occuper = new BindingSource();
        public static DataTable t_soigner = new DataTable();
        public static BindingSource bs_soigner = new BindingSource();
        #endregion
        #region DataList
        public static List<C_t_specialites> lTmp_Spe = new G_t_specialites(sConnexion).Lire("ID");
        public static List<C_t_medecins> lTmp_Med = new G_t_medecins(sConnexion).Lire("ID");
        public static List<C_t_chambres> lTmp_Cha = new G_t_chambres(sConnexion).Lire("ID");
        public static List<C_t_patients> lTmp_Pat = new G_t_patients(sConnexion).Lire("ID");
        public static List<C_t_occuper> lTmp_Occ = new G_t_occuper(sConnexion).Lire("ID");
        public static List<C_t_soigner> lTmp_Soi = new G_t_soigner(sConnexion).Lire("ID");
        #endregion

        #region Accesseurs
        public static string SConnexion { get => sConnexion; set => sConnexion = value; }
        #endregion
    }
}
