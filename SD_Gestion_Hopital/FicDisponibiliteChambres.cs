using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_BD_Hopital.Gestion;
using Projet_BD_Hopital.Classes;


namespace SD_Gestion_Hopital
{
    public partial class EcranDisponibiliteChambres : Form
    {
        private DataTable t_dispo_chambre;
        private BindingSource bs_dispo_chambre;
        private string sConnexion = @"Data Source=DESKTOP-GES02KU;Initial Catalog=BD_Hopital;Integrated Security=True";
        private List<C_t_chambres> lTmp_Cha;
        private List<C_t_occuper> lTmp_Occ;

        public EcranDisponibiliteChambres()
        {
            InitializeComponent();
        }

        private void EcranDisponibiliteChambres_Load(object sender, EventArgs e)
        {
            lblNombreLitLibre.Visible = false;
        }

        public static int NumeroSemaineEnCours()
        {
            DateTimeFormatInfo dateforminfo = DateTimeFormatInfo.CurrentInfo;
            DateTime ajd = DateTime.Today;
            GregorianCalendar Calendrier = new GregorianCalendar();

            return Calendrier.GetWeekOfYear(ajd, dateforminfo.CalendarWeekRule, dateforminfo.FirstDayOfWeek);
        }

        public static DateTime Date_Premier_J_Semaine()
        {
            DateTimeFormatInfo dateforminfo = DateTimeFormatInfo.CurrentInfo;
            GregorianCalendar Calendrier = new GregorianCalendar();
            // On récupère le premier jour de l'année en cours
            DateTime premier_j_annee = new DateTime(DateTime.Today.Year, 1, 1);
            // Calcule de l'offset pur déterminer la première semaine selon la culture ( une semaine complète contient 4 jours minimum)
            int JourOffset = (int) dateforminfo.FirstDayOfWeek - (int) premier_j_annee.DayOfWeek;
            // On calcule du premier de la véritale première semaine
            DateTime Date_premiere_semaine = premier_j_annee.AddDays(JourOffset);
            int Num_premiere_semaine = Calendrier.GetWeekOfYear(premier_j_annee, dateforminfo.CalendarWeekRule,
                dateforminfo.FirstDayOfWeek);
            int Num_semaine = NumeroSemaineEnCours(), nbr_semaine = 52;

            // On vérifie les année qui comptent 53 semaines sur l'année
            if (DateTime.Today.Year == 2020 || DateTime.Today.Year == 2026 || DateTime.Today.Year == 2032 ||
                DateTime.Today.Year == 2037 || DateTime.Today.Year == 2048)
            {
                nbr_semaine = 53;
            }

            // On rectifie le numéro de la semaine en cours
            if ((Num_premiere_semaine <= 1 || Num_premiere_semaine >= nbr_semaine) && JourOffset >= -3)
            {
                Num_semaine -= 1;
            }

            // On calcule le premier jour de la semaine en cours
            return Date_premiere_semaine.AddDays(Num_semaine * 7);
        }

        private void btnChercherChaDispo_Click(object sender, EventArgs e)
        {
            if (tbNumChaChercher.Text == "")
            {
                MessageBox.Show("Veuillez saisir un numéro de chambre.", "Attention!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                int id = 0, nbr_lit = 0;
                DateTime Premier_J_Semaine = Date_Premier_J_Semaine();
                t_dispo_chambre = new DataTable();
                t_dispo_chambre.Columns.Add(new DataColumn("Lundi\n" + Premier_J_Semaine.ToShortDateString()));
                t_dispo_chambre.Columns.Add(
                    new DataColumn("Mardi\n" + Premier_J_Semaine.AddDays(1).ToShortDateString()));
                t_dispo_chambre.Columns.Add(
                    new DataColumn("Mercredi\n" + Premier_J_Semaine.AddDays(2).ToShortDateString()));
                t_dispo_chambre.Columns.Add(
                    new DataColumn("Jeudi\n" + Premier_J_Semaine.AddDays(3).ToShortDateString()));
                t_dispo_chambre.Columns.Add(
                    new DataColumn("Vendredi\n" + Premier_J_Semaine.AddDays(4).ToShortDateString()));
                t_dispo_chambre.Columns.Add(
                    new DataColumn("Samedi\n" + Premier_J_Semaine.AddDays(5).ToShortDateString()));
                t_dispo_chambre.Columns.Add(
                    new DataColumn("Dimanche\n" + Premier_J_Semaine.AddDays(6).ToShortDateString()));
                lTmp_Cha = new G_t_chambres(sConnexion).Lire("IDCha");
                foreach (C_t_chambres c in lTmp_Cha)
                {
                    if (c.NomCha == int.Parse(tbNumChaChercher.Text))
                    {
                        id = c.IDCha;
                        nbr_lit = c.QuantiteLits;
                        break;
                    }
                }

                if (id != 0)
                {
                    int[] Lit_occupe = new int[] {0, 0, 0, 0, 0, 0, 0};
                    lTmp_Occ = new G_t_occuper(sConnexion).Lire("IDOcc");
                    for (int i = 0; i < 7; i++)
                    {
                        DateTime Date_Comp = Premier_J_Semaine.AddDays(i);
                        foreach (C_t_occuper o in lTmp_Occ)
                        {
                            if (o.IDCha == id &&
                                (Date_Comp.Date >= o.DateEntree.Date && Date_Comp.Date <= o.DateSortie.Date))
                            {
                                Lit_occupe[i] += 1;
                            }
                        }
                    }

                    t_dispo_chambre.Rows.Add(nbr_lit - Lit_occupe[0], nbr_lit - Lit_occupe[1], nbr_lit - Lit_occupe[2],
                        nbr_lit - Lit_occupe[3],
                        nbr_lit - Lit_occupe[4], nbr_lit - Lit_occupe[5], nbr_lit - Lit_occupe[6]);

                    lblNombreLitLibre.Visible = true;
                    bs_dispo_chambre = new BindingSource();
                    bs_dispo_chambre.DataSource = t_dispo_chambre;
                    dgvDispoCha.DataSource = bs_dispo_chambre;
                    // Bloque du tri sur les colonnes \\
                    dgvDispoCha.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDispoCha.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDispoCha.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDispoCha.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDispoCha.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDispoCha.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvDispoCha.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
                    // désactive le fait d'avoir la première cellule sélectionnée \\
                    dgvDispoCha.FirstDisplayedCell.Selected = false;
                    tbNumChaChercher.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("La chambre recherchée n'existe pas!", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnGenererHtml_Click(object sender, EventArgs e)
        {
            string html = "<!DOCTYPE html>" +
                          "\r\n<html>" +
                          "\r\n\t<head>" +
                          "\r\n\t\t<meta charset=\"utf-8\" />" +
                          "\r\n\t\t<title>Vue hebdomadaire</title>" +
                          "\r\n\t</head>" +
                          "\r\n\t<body>" +
                          "\r\n\t\t<header>" +
                          "\r\n\t\t\t<h1 align='center'>Vue hebdomadaire de la chambre " + tbNumChaChercher.Text +
                          " semaine " + NumeroSemaineEnCours().ToString() + "</h1>" +
                          "\r\n\t\t</header><br>";
            //Table start.
            html +=
                "<table align='center' cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";

            //Adding HeaderRow.
            html += "<tr>";
            foreach (DataGridViewColumn column in dgvDispoCha.Columns)
            {
                html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.HeaderText + "</th>";
            }

            html += "</tr>";

            //Adding DataRow.
            foreach (DataGridViewRow row in dgvDispoCha.Rows)
            {
                html += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    html += "<td style='width:120px;border: 1px solid #ccc'>" + cell.Value.ToString() + "</td>";
                }

                html += "</tr>";
            }

            //Table end.
            html += "\r\n\t\t</table><br>" +
                    "\r\n\t\t<footer>" +
                    "\r\n\t\t\t<p align='center'>SD Hopital Rue du Covid, 19 1000 Confiné Belgique" +
                    "\r\n\t\t\t</P>" +
                    "\r\n\t\t</footer>" +
                    "\r\n\t</body>" +
                    "\r\n</html>";

            File.WriteAllText(@"C:\Users\sebas\Documents\HEL - Informatique\Dispo_chambres\" +
                              NumeroSemaineEnCours().ToString() + "-" + tbNumChaChercher.Text + ".html", html);
            MessageBox.Show("Fichier sauvé!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReinitRecherche_Click(object sender, EventArgs e)
        {
            tbNumChaChercher.ReadOnly = false;

        }
    }
}