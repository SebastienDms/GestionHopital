﻿using System;
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
    public partial class EcranSoigner : Form
    {
        #region Donnees
        private DataTable t_soigner;
        private BindingSource bs_soigner;
        //private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private string sConnexion = TablesDeDonnees.SConnexion;
        #endregion

        public EcranSoigner()
        {
            InitializeComponent();
        }
        private void EcranSoigner_Load(object sender, EventArgs e)
        {
            AfficherSoins();
        }

        private void AfficherSoins()
        {
            t_soigner = new DataTable();
            t_soigner.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            t_soigner.Columns.Add(new DataColumn("Médecin"));
            t_soigner.Columns.Add(new DataColumn("Patient"));
            t_soigner.Columns.Add(new DataColumn("Opération prévue le"));
            t_soigner.Columns.Add(new DataColumn("Sortie prévue le"));
            t_soigner.Columns.Add(new DataColumn("Coût de l'opération"));
            List<C_t_medecins> lTmp_Med = new G_t_medecins(sConnexion).Lire("NomMed");
            List<C_t_patients> lTmp_Pat = new G_t_patients(sConnexion).Lire("NomPat");
            List<C_t_soigner> lTmp_Soin = new G_t_soigner(sConnexion).Lire("IDSoi");
            foreach (C_t_soigner s in lTmp_Soin)
            {
                string Medecin = "", Patient = "";
                // Recherche du nom et prénom du médecin
                foreach (C_t_medecins m in lTmp_Med)
                {
                    if (s.IDMed == m.IDMed)
                    {
                        Medecin = m.NomMed + " " + m.PrenomMed;
                        break;
                    }
                }

                // Recherche du nom et prénom du patient
                foreach (C_t_patients p in lTmp_Pat)
                {
                    if (s.IDPat == p.IDPat)
                    {
                        Patient = p.NomPat + " " + p.PrenomPat;
                        break;
                    }
                }

                t_soigner.Rows.Add(s.IDSoi, Medecin, Patient, s.DateOperation.ToShortDateString(),
                    s.DateAuthorisationSortie.ToString(), s.PrixOperation.ToString());
            }
            bs_soigner = new BindingSource();
            bs_soigner.DataSource = t_soigner;
            dgvSoins.DataSource = bs_soigner;
        }
    }
}
