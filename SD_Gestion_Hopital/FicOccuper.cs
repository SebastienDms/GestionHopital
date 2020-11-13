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
    public partial class EcranOccuper : Form
    {
        #region Donnees
        private DataTable t_occuper;
        private BindingSource bs_occuper;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;
        #endregion

        public EcranOccuper()
        {
            InitializeComponent();
        }
        private void AfficherOccupation()
        {
            t_occuper = new DataTable();
            t_occuper.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_occuper.Columns.Add(new DataColumn("Patient"));
            t_occuper.Columns.Add(new DataColumn("Chambre"));
            t_occuper.Columns.Add(new DataColumn("Entrée le"));
            t_occuper.Columns.Add(new DataColumn("Sortie le"));
            t_occuper.Columns.Add(new DataColumn("Coût journalier"));
            List<C_t_chambres> lTmp_Cha = new G_t_chambres(sConnexion).Lire("NomCha");
            List<C_t_patients> lTmp_Pat = new G_t_patients(sConnexion).Lire("NomPat");
            List<C_t_occuper> lTmp_Occ = new G_t_occuper(sConnexion).Lire("IDOcc");
            foreach (C_t_occuper o in lTmp_Occ)
            {
                string Chambre = "", Patient = "";

                foreach (C_t_chambres c in lTmp_Cha)
                {
                    if (o.IDCha == c.IDCha)
                    {
                        Chambre = c.NomCha.ToString();
                        break;
                    }
                }
                foreach (C_t_patients p in lTmp_Pat)
                {
                    if (o.IDPat == p.IDPat)
                    {
                        Patient = p.NomPat + " " + p.PrenomPat;
                        break;
                    }
                }

                t_occuper.Rows.Add(o.IDOcc, Patient, Chambre, o.DateEntree.ToShortDateString(),
                    o.DateSortie.ToString(), o.PrixJournalier.ToString());
            }
            bs_occuper = new BindingSource();
            bs_occuper.DataSource = t_occuper;
            dgvOccupation.DataSource = bs_occuper;
        }

        private void FicOccuper_Load(object sender, EventArgs e)
        {
            AfficherOccupation();
        }
    }
}
