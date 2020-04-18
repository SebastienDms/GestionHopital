#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using Projet_BD_Hopital.Classes;
using Projet_BD_Hopital.Acces;

#endregion

namespace Projet_BD_Hopital.Gestion
{
 public class G_Base
  {
  #region Données membres
  string _ChaineConnexion;
  #endregion
  #region Constructeurs
  public G_Base()
  { ChaineConnexion = ""; }
  public G_Base(string sChaineConnexion)
  { ChaineConnexion = sChaineConnexion; }
  #endregion
  #region Accesseur
  public string ChaineConnexion
  {
   get {	return _ChaineConnexion;	}
   set	{	_ChaineConnexion = value;	}
  }
  #endregion
 }
}
