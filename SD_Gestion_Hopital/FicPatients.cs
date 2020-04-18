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
    public partial class EcranPatients : Form
    {
        private DataTable t_patients;
        private BindingSource bs_patients;
        private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";

        public EcranPatients()
        {
            InitializeComponent();
        }
        private void AfficherPatients()
        {
            t_patients = new DataTable();
            t_patients.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_patients.Columns.Add(new DataColumn("Nom"));
            t_patients.Columns.Add(new DataColumn("Prénom"));
            t_patients.Columns.Add(new DataColumn("Adresse"));
            t_patients.Columns.Add(new DataColumn("GSM"));
            List<C_t_patients> lTmp_Pat = new G_t_patients(sConnexion).Lire("Nom");
            foreach (C_t_patients pat in lTmp_Pat)
            {
                t_patients.Rows.Add(pat.IDPat, pat.NomPat, pat.PrenomPat, pat.AdressePat, pat.GSMPat.ToString());
            }
            bs_patients = new BindingSource();
            bs_patients.DataSource = t_patients;
            dgvPatients.DataSource = bs_patients;
        }

        private void EcranPatients_Load(object sender, EventArgs e)
        {
            AfficherPatients();
        }
    }
}
