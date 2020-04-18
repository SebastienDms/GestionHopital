#region Ressources extérieures
using System;
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
 public class G_t_soigner : G_Base
 {
  #region Constructeurs
  public G_t_soigner()
   : base()
  { }
  public G_t_soigner(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int IDMed, int IDPat, DateTime DateOperation, DateTime DateAuthorisationSortie, int? PrixOperation)
  { return new A_t_soigner(ChaineConnexion).Ajouter(IDMed, IDPat, DateOperation, DateAuthorisationSortie, PrixOperation); }
  public int Modifier(int IDSoi, int IDMed, int IDPat, DateTime DateOperation, DateTime DateAuthorisationSortie, int? PrixOperation)
  { return new A_t_soigner(ChaineConnexion).Modifier(IDSoi, IDMed, IDPat, DateOperation, DateAuthorisationSortie, PrixOperation); }
  public List<C_t_soigner> Lire(string Index)
  { return new A_t_soigner(ChaineConnexion).Lire(Index); }
  public C_t_soigner Lire_ID(int IDSoi)
  { return new A_t_soigner(ChaineConnexion).Lire_ID(IDSoi); }
  public int Supprimer(int IDSoi)
  { return new A_t_soigner(ChaineConnexion).Supprimer(IDSoi); }
 }
}
