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
    public partial class EcranSpecialites : Form
    {
        #region Donnees
        private DataTable t_specialites;
        private BindingSource bs_specialites;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;
        #endregion

        public EcranSpecialites()
        {
            InitializeComponent();
        }
        private void AfficherSpecialites()
        {
            t_specialites = new DataTable();
            t_specialites.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_specialites.Columns.Add(new DataColumn("Spécialité"));
            t_specialites.Columns.Add(new DataColumn("Médecin"));
            List<C_t_medecins> lTmp_Med = new G_t_medecins(sConnexion).Lire("Nom");
            List<C_t_specialites> lTmp_Spe = new G_t_specialites(sConnexion).Lire("NomSpe");
            foreach (C_t_specialites spe in lTmp_Spe)
            {
                t_specialites.Rows.Add(spe.IDSpe, spe.NomSpe);

                foreach (C_t_medecins m in lTmp_Med)
                {
                    if (spe.IDSpe == m.IDSpe)
                    {
                        t_specialites.Rows.Add(null, "", m.NomMed + " " + m.PrenomMed);
                    }
                }
            }
            bs_specialites = new BindingSource();
            bs_specialites.DataSource = t_specialites;
            dgvSpecialites.DataSource = bs_specialites;
            // Bloque du tri sur les colonnes \\
            dgvSpecialites.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvSpecialites.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvSpecialites.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            // désactive le fait d'avoir la première cellule sélectionnée \\
            dgvSpecialites.FirstDisplayedCell.Selected = false;
        }

        private void EcranSpecialites_Load(object sender, EventArgs e)
        {
            AfficherSpecialites();
        }
    }
}
