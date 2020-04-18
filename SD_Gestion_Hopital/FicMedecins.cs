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
    public partial class EcranMedecins : Form
    {
        private DataTable t_medecins;
        private BindingSource bs_medecins;
        private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";

        public EcranMedecins()
        {
            InitializeComponent();
        }
        private void AfficherMedecins()
        {
            t_medecins = new DataTable();
            t_medecins.Columns.Add(new DataColumn("IDMed", System.Type.GetType("System.Int32")));
            t_medecins.Columns.Add(new DataColumn("Nom"));
            t_medecins.Columns.Add(new DataColumn("Prénom"));
            t_medecins.Columns.Add(new DataColumn("GSM"));
            // t_medecins.Columns.Add(new DataColumn("ID Spécialité"));
            t_medecins.Columns.Add(new DataColumn("Spécialité"));
            List<C_t_medecins> lTmp_Med = new G_t_medecins(sConnexion).Lire("Nom");
            List<C_t_specialites> lTmp_Spe = new G_t_specialites(sConnexion).Lire("NomSpe");
            foreach (C_t_medecins m in lTmp_Med)
            {
                string Nom_Spe="";

                foreach (C_t_specialites spe in lTmp_Spe)
                {
                    if (m.IDSpe == spe.IDSpe)
                    {
                        Nom_Spe = spe.NomSpe;
                        break;
                    }
                }

                t_medecins.Rows.Add(m.IDMed, m.NomMed, m.PrenomMed, m.GSMMed.ToString(), Nom_Spe);
            }
            bs_medecins = new BindingSource();
            bs_medecins.DataSource = t_medecins;
            dgvMedecins.DataSource = bs_medecins;
        }

        private void EcranMedecins_Load(object sender, EventArgs e)
        {
            AfficherMedecins();
        }
    }
}
