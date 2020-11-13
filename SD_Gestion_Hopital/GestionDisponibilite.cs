using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_BD_Hopital.Classes;
using Projet_BD_Hopital.Gestion;

namespace SD_Gestion_Hopital
{
    static class GestionDisponibilite
    {
        public static void AfficherDispoCha(string NumCha, DataGridView dgv, int i)
        {
            if (NumCha == "")
            {
                MessageBox.Show("Veuillez saisir un numéro de chambre.", "Attention!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                int id = 0, nbr_lit = 0;
                DateTime Premier_J_Semaine = GestionDates.Date_Premier_J_Semaine(i);
                DataTable t_dispo_chambre = new DataTable();
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
                List<C_t_chambres> lTmp_Cha = new G_t_chambres(TablesDeDonnees.SConnexion).Lire("IDCha");
                foreach (C_t_chambres c in lTmp_Cha)
                {
                    if (c.NomCha == int.Parse(NumCha))
                    {
                        id = c.IDCha;
                        nbr_lit = c.QuantiteLits;
                        break;
                    }
                }

                if (id != 0)
                {
                    int[] Lit_occupe = new int[] { 0, 0, 0, 0, 0, 0, 0 };
                    List<C_t_occuper> lTmp_Occ = new G_t_occuper(TablesDeDonnees.SConnexion).Lire("IDOcc");
                    for (int j = 0; j < 7; j++)
                    {
                        DateTime Date_Comp = Premier_J_Semaine.AddDays(j);
                        foreach (C_t_occuper o in lTmp_Occ)
                        {
                            if (o.IDCha == id &&
                                (Date_Comp.Date >= o.DateEntree.Date && Date_Comp.Date <= o.DateSortie.Value))
                            {
                                Lit_occupe[j] += 1;
                            }
                        }
                    }

                    t_dispo_chambre.Rows.Add(nbr_lit - Lit_occupe[0], nbr_lit - Lit_occupe[1], nbr_lit - Lit_occupe[2],
                        nbr_lit - Lit_occupe[3],
                        nbr_lit - Lit_occupe[4], nbr_lit - Lit_occupe[5], nbr_lit - Lit_occupe[6]);

                    BindingSource bs_dispo_chambre = new BindingSource();
                    bs_dispo_chambre.DataSource = t_dispo_chambre;
                    dgv.DataSource = bs_dispo_chambre;
                    // Bloque du tri sur les colonnes \\
                    dgv.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgv.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgv.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgv.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgv.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgv.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgv.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
                    // désactive le fait d'avoir la première cellule sélectionnée \\
                    dgv.FirstDisplayedCell.Selected = false;
                }
                else
                {
                    MessageBox.Show("La chambre recherchée n'existe pas!", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        public static List<DateTime> DispoMed(string nom, string prenom)
        {
            if (nom == "" || prenom == "")
            {
                MessageBox.Show("Veuillez sélectionner un médecin.", "Attention!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return null;
            }
            else
            {
                int id = 0;
                List<C_t_medecins> lTmp_Med = new G_t_medecins(TablesDeDonnees.SConnexion).Lire("ID");
                foreach (C_t_medecins m in lTmp_Med)
                {
                    if (nom == m.NomMed && prenom == m.PrenomMed)
                    {
                        id = m.IDMed;
                        break;
                    }
                }

                if (id != 0)
                {
                    List<DateTime> jour_operation = new List<DateTime>();
                    int Annee_Comp = DateTime.Today.Year;

                    List<C_t_soigner> lTmp_Soi = new G_t_soigner(TablesDeDonnees.SConnexion).Lire("ID");
                    foreach (C_t_soigner o in lTmp_Soi)
                    {
                        if (o.IDMed == id && Annee_Comp == o.DateOperation.Date.Year)
                        {
                            jour_operation.Add(o.DateOperation);
                        }
                    }

                    return jour_operation;
                }
                else
                {
                    MessageBox.Show("La chambre recherchée n'existe pas!", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return null;
                }
            }
        }
    }
}
