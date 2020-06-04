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
using Projet_BD_Hopital.Acces;

namespace SD_Gestion_Hopital
{
    public partial class EcranHitParadeMedecins : Form
    {
        #region Donnees
        private DataTable t_hitparade;
        private BindingSource bs_hitparade;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;
        private List<C_t_medecins> lTmp_Med;
        private List<C_t_soigner> lTmp_Soi;
        private List<(int, int)> list_HitParade;
        #endregion

        public EcranHitParadeMedecins()
        {
            InitializeComponent();
        }

        private void FicHitParadeMedecins_Load(object sender, EventArgs e)
        {
            HitParade();
        }

        private void HitParade()
        {
            // Création de liste Hit parade des médecins
            list_HitParade = new List<(int, int)>();
            lTmp_Med = new G_t_medecins(sConnexion).Lire("NomMed");
            foreach (C_t_medecins m in lTmp_Med)
            {
                list_HitParade.Add((m.IDMed, count(m.IDMed)));
            }
            AfficherHitPar();
        }
        private int count(int ID)
        {
            // Compte le nombre d'opérations pour chaque médecin
            int count = 0;
            lTmp_Soi = new G_t_soigner(sConnexion).Lire("IDSoi");
            foreach (C_t_soigner s in lTmp_Soi)
            {
                if (s.IDMed == ID)
                {
                    count++;
                }
            }
            return count;
        }

        private void AfficherHitPar()
        {
            string medecin = "";
            t_hitparade = new DataTable();
            t_hitparade.Columns.Add(new DataColumn("Médecin"));
            t_hitparade.Columns.Add(new DataColumn("Nombre d'opérations"));
            foreach ((int, int) ligne in list_HitParade)
            {
                foreach (C_t_medecins m in lTmp_Med)
                {
                    if (m.IDMed == ligne.Item1)
                    {
                        medecin = m.NomMed + " " + m.PrenomMed;
                    }
                }
                t_hitparade.Rows.Add(medecin, ligne.Item2);
            }
            bs_hitparade = new BindingSource();
            bs_hitparade.DataSource = t_hitparade;
            dgvHitParade.DataSource = bs_hitparade;
            // Tri du tableau selon le nombre d'opérations descendant \\
            dgvHitParade.Sort(dgvHitParade.Columns["Nombre d'opérations"],ListSortDirection.Descending);
            // Bloque du tri sur les colonnes \\
            dgvHitParade.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvHitParade.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            // désactive le fait d'avoir la première cellule sélectionnée \\
            dgvHitParade.FirstDisplayedCell.Selected = false;
        }
    }
}
