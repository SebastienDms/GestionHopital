#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Projet_BD_Hopital.Classes;
using System.IO;
#endregion

namespace Projet_BD_Hopital.Acces
{
 /// <summary>
 /// Couche d'accès aux données (Data Access Layer)
 /// </summary>
 public class A_t_medecins : ADBase
 {
  #region Constructeurs
  public A_t_medecins(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string NomMed, string PrenomMed, int GSMMed, int IDSpe)
  {
   CreerCommande("Ajoutert_medecins");
   int res = 0;
   Commande.Parameters.Add("IDMed", SqlDbType.Int);
   Direction("IDMed", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@NomMed", NomMed);
   Commande.Parameters.AddWithValue("@PrenomMed", PrenomMed);
   Commande.Parameters.AddWithValue("@GSMMed", GSMMed);
   Commande.Parameters.AddWithValue("@IDSpe", IDSpe);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("IDMed"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int IDMed, string NomMed, string PrenomMed, int GSMMed, int IDSpe)
  {
   CreerCommande("Modifiert_medecins");
   int res = 0;
   Commande.Parameters.AddWithValue("@IDMed", IDMed);
   Commande.Parameters.AddWithValue("@NomMed", NomMed);
   Commande.Parameters.AddWithValue("@PrenomMed", PrenomMed);
   Commande.Parameters.AddWithValue("@GSMMed", GSMMed);
   Commande.Parameters.AddWithValue("@IDSpe", IDSpe);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_t_medecins> Lire(string Index)
  {
   CreerCommande("Selectionnert_medecins");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_t_medecins> res = new List<C_t_medecins>();
   while (dr.Read())
   {
    C_t_medecins tmp = new C_t_medecins();
    tmp.IDMed = int.Parse(dr["IDMed"].ToString());
    tmp.NomMed = dr["NomMed"].ToString();
    tmp.PrenomMed = dr["PrenomMed"].ToString();
    tmp.GSMMed = int.Parse(dr["GSMMed"].ToString());
    tmp.IDSpe = int.Parse(dr["IDSpe"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_t_medecins Lire_ID(int IDMed)
  {
   CreerCommande("Selectionnert_medecins_ID");
   Commande.Parameters.AddWithValue("@IDMed", IDMed);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_t_medecins res = new C_t_medecins();
   while (dr.Read())
   {
    res.IDMed = int.Parse(dr["IDMed"].ToString());
    res.NomMed = dr["NomMed"].ToString();
    res.PrenomMed = dr["PrenomMed"].ToString();
    res.GSMMed = int.Parse(dr["GSMMed"].ToString());
    res.IDSpe = int.Parse(dr["IDSpe"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int IDMed)
  {
   CreerCommande("Supprimert_medecins");
   int res = 0;
   Commande.Parameters.AddWithValue("@IDMed", IDMed);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
