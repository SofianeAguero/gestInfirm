using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using BO;
using DAL;

namespace BLL
{
    public class GestionVisiteBLL
    {
        private static GestionVisiteBLL uneGestionVisite; // objet BLL

        // Accesseur en lecture
        public static GestionVisiteBLL GetGestionVisite()
        {
            if (uneGestionVisite == null)
            {
                uneGestionVisite = new GestionVisiteBLL();
            }
            return uneGestionVisite;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        #region // Méthode qui renvoit une List d'objets visite en faisant appel à la méthode GetVisite() de la DAL
        public static List<VisiteBO> GetVisite()
        {
            return VisiteDAL.GetVisite();
        }
        #endregion

        #region // Méthode qui recherche un nom dans une List d'objets Visite en faisant appel à la méthode GetVisite() de la DAL
        // Méthode qui cherche dans une List d'objets Visite en faisant appel à la méthode GetVisite() de la DAL
        public static List<VisiteBO> GetVisiteSearch(string search)
        {
            return VisiteDAL.GetVisiteSearch(search);
        }

        #endregion

        #region // Méthode qui créer un nouvel objet Visite
        // Méthode qui créer un nouvel objet Visite le renvoi en l'ajoutant à la
        // BD avec la méthode AjoutVisite de la DAL
        public static int CreerUneVisite(string motif, string commentaire, string hArrive, string hDepart, DateTime dateVisite, bool domicile, bool hopital, bool parents, string pouls, int eleve)
        {
            VisiteBO visi;
            visi = new VisiteBO(motif, commentaire, hArrive, hDepart, dateVisite, domicile, hopital, parents, pouls, eleve);
            return VisiteDAL.AjoutVisite(visi);
        }
        #endregion

        #region // Méthode qui modifie une visite avec la méthode de la DAL
        // Méthode qui modifie un nouvel visite avec la méthode UpdateUtilisateur de la DAL
        public static int ModifierVisite(int id, string motif, string commentaire, DateTime dateAjout, string heureArr, string heureDep, bool retour, bool hopital, bool prevenu, string pouls, int eleve)
        {
            VisiteBO visi;
            visi = new VisiteBO(id, motif, commentaire, heureArr, heureDep, dateAjout, retour, hopital, prevenu, pouls, eleve);
            return VisiteDAL.UpdateVisite(visi);
        }
        #endregion
    }
}
