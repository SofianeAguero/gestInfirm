using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using BO;
using DAL;

namespace BLL
{
    public class GestionClassesBLL
    {
        private static GestionClassesBLL uneGestionClasse; // objet BLL

        // Accesseur en lecture
        public static GestionClassesBLL GetGestionClasses()
        {
            if (uneGestionClasse == null)
            {
                uneGestionClasse = new GestionClassesBLL();
            }
            return uneGestionClasse;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Medicament en faisant appel à la méthode GetClasses() de la DAL
        public static List<ClasseBO> GetClasses()
        {
            return ClassesDAL.GetClasses();
        }

        #region // Méthode qui modifie un nouveau Medicament avec la méthode UpdateUtilisateur de la DAL
        // Méthode qui modifie un nouveau Medicament avec la méthode UpdateUtilisateur de la DAL
        public static int ModifierClasse(int id, string nom, string emploiDuTemps, bool eleve)
        {
            ClasseBO med;
            med = new ClasseBO(id, nom, emploiDuTemps, eleve);
            return ClassesDAL.UpdateClasse(med);
        }
        #endregion

        #region // Méthode qui créer un nouvel objet Medicament à partir de son id et de son nom
        // Méthode qui créer un nouvel objet Eleve à partir de son id et de son nom et qui le renvoi en l'ajoutant à la
        // BD avec la méthode AjoutEleve de la DAL
        public static int CreerUneClasse(string nom, string emploiDuTemps)
        {
            ClasseBO med;
            med = new ClasseBO(nom, emploiDuTemps);
            return ClassesDAL.AjoutClasse(med);
        }
        #endregion

        #region // Méthode qui supprime un Medicament avec la méthode DeleteUtilisateur de la DAL
        // Méthode qui supprime un Eleve avec la méthode DeleteUtilisateur de la DAL
        public static int SupprimerClasse(int id)
        {
            return ClassesDAL.DeleteClasse(id);
        }
        #endregion
    }
}
