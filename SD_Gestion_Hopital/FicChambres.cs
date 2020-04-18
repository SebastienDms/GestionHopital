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
    public partial class EcranChambres : Form
    {
        private DataTable t_chambres;
        private BindingSource bs_chambres;
        private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";

        public EcranChambres()
        {
            InitializeComponent();
        }
        private void AfficherChambres()
        {
            t_chambres = new DataTable();
            t_chambres.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_chambres.Columns.Add(new DataColumn("Numéro"));
            t_chambres.Columns.Add(new DataColumn("Nombre de lit"));
            t_chambres.Columns.Add(new DataColumn("Type"));
            t_chambres.Columns.Add(new DataColumn("Etage"));
            t_chambres.Columns.Add(new DataColumn("Service"));
            List<C_t_chambres> lTmp_Cha = new G_t_chambres(sConnexion).Lire("NomCha");
            foreach (C_t_chambres cha in lTmp_Cha)
            {
                t_chambres.Rows.Add(cha.IDCha, cha.NomCha.ToString(), cha.QuantiteLits.ToString(), cha.TypeCha, cha.EtageCha.ToString(),cha.ServiceCha);
            }
            bs_chambres = new BindingSource();
            bs_chambres.DataSource = t_chambres;
            dgvChambres.DataSource = bs_chambres;
        }

        private void EcranChambres_Load(object sender, EventArgs e)
        {
            AfficherChambres();
        }
    }
}
