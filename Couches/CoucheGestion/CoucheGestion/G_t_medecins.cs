#region Ressources extérieures
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Projet_BD_Hopital.Classes;
using Projet_BD_Hopital.Acces;
#endregion

namespace Projet_BD_Hopital.Gestion
{
 /// <summary>
 /// Couche intermédiaire de gestion (Business Layer)
 /// </summary>
 public class G_t_medecins : G_Base
 {
  #region Constructeurs
  public G_t_medecins()
   : base()
  { }
  public G_t_medecins(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string NomMed, string PrenomMed, int GSMMed, int IDSpe)
  { return new A_t_medecins(ChaineConnexion).Ajouter(NomMed, PrenomMed, GSMMed, IDSpe); }
  public int Modifier(int IDMed, string NomMed, string PrenomMed, int GSMMed, int IDSpe)
  { return new A_t_medecins(ChaineConnexion).Modifier(IDMed, NomMed, PrenomMed, GSMMed, IDSpe); }
  public List<C_t_medecins> Lire(string Index)
  { return new A_t_medecins(ChaineConnexion).Lire(Index); }
  public C_t_medecins Lire_ID(int IDMed)
  { return new A_t_medecins(ChaineConnexion).Lire_ID(IDMed); }
  public int Supprimer(int IDMed)
  { return new A_t_medecins(ChaineConnexion).Supprimer(IDMed); }
 }
}
