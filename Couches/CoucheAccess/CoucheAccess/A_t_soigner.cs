#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Projet_BD_Hopital.Classes;
#endregion

namespace Projet_BD_Hopital.Acces
{
 /// <summary>
 /// Couche d'accès aux données (Data Access Layer)
 /// </summary>
 public class A_t_soigner : ADBase
 {
  #region Constructeurs
  public A_t_soigner(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int IDMed, int IDPat, DateTime DateOperation, DateTime DateAuthorisationSortie, int? PrixOperation)
  {
   CreerCommande("Ajoutert_soigner");
   int res = 0;
   Commande.Parameters.Add("IDSoi", SqlDbType.Int);
   Direction("IDSoi", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@IDMed", IDMed);
   Commande.Parameters.AddWithValue("@IDPat", IDPat);
   Commande.Parameters.AddWithValue("@DateOperation", DateOperation);
   Commande.Parameters.AddWithValue("@DateAuthorisationSortie", DateAuthorisationSortie);
   if(PrixOperation == null) Commande.Parameters.AddWithValue("@PrixOperation", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PrixOperation", PrixOperation);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("IDSoi"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int IDSoi, int IDMed, int IDPat, DateTime DateOperation, DateTime DateAuthorisationSortie, int? PrixOperation)
  {
   CreerCommande("Modifiert_soigner");
   int res = 0;
   Commande.Parameters.AddWithValue("@IDSoi", IDSoi);
   Commande.Parameters.AddWithValue("@IDMed", IDMed);
   Commande.Parameters.AddWithValue("@IDPat", IDPat);
   Commande.Parameters.AddWithValue("@DateOperation", DateOperation);
   Commande.Parameters.AddWithValue("@DateAuthorisationSortie", DateAuthorisationSortie);
   if(PrixOperation == null) Commande.Parameters.AddWithValue("@PrixOperation", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PrixOperation", PrixOperation);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_t_soigner> Lire(string Index)
  {
   CreerCommande("Selectionnert_soigner");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_t_soigner> res = new List<C_t_soigner>();
   while (dr.Read())
   {
    C_t_soigner tmp = new C_t_soigner();
    tmp.IDSoi = int.Parse(dr["IDSoi"].ToString());
    tmp.IDMed = int.Parse(dr["IDMed"].ToString());
    tmp.IDPat = int.Parse(dr["IDPat"].ToString());
    tmp.DateOperation = DateTime.Parse(dr["DateOperation"].ToString());
    tmp.DateAuthorisationSortie = DateTime.Parse(dr["DateAuthorisationSortie"].ToString());
   if(dr["PrixOperation"] != DBNull.Value) tmp.PrixOperation = int.Parse(dr["PrixOperation"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_t_soigner Lire_ID(int IDSoi)
  {
   CreerCommande("Selectionnert_soigner_ID");
   Commande.Parameters.AddWithValue("@IDSoi", IDSoi);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_t_soigner res = new C_t_soigner();
   while (dr.Read())
   {
    res.IDSoi = int.Parse(dr["IDSoi"].ToString());
    res.IDMed = int.Parse(dr["IDMed"].ToString());
    res.IDPat = int.Parse(dr["IDPat"].ToString());
    res.DateOperation = DateTime.Parse(dr["DateOperation"].ToString());
    res.DateAuthorisationSortie = DateTime.Parse(dr["DateAuthorisationSortie"].ToString());
   if(dr["PrixOperation"] != DBNull.Value) res.PrixOperation = int.Parse(dr["PrixOperation"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int IDSoi)
  {
   CreerCommande("Supprimert_soigner");
   int res = 0;
   Commande.Parameters.AddWithValue("@IDSoi", IDSoi);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
