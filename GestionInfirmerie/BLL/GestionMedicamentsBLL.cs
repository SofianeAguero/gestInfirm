using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using BO;
using DAL;

namespace BLL
{
    public class GestionMedicamentsBLL
    {
        private static GestionMedicamentsBLL uneGestionMedicament; // objet BLL

        // Accesseur en lecture
        public static GestionMedicamentsBLL GetGestionMedicaments()
        {
            if (uneGestionMedicament == null)
            {
                uneGestionMedicament = new GestionMedicamentsBLL();
            }
            return uneGestionMedicament;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        #region // Méthode qui renvoit une List d'objets Medicament en faisant appel à la méthode GetMedicaments() de la DAL
        // Méthode qui renvoit une List d'objets Medicament en faisant appel à la méthode GetMedicaments() de la DAL
        public static List<MedicamentBO> GetMedicaments()
        {
            return MedicamentsDAL.GetMedicaments();
        }

        #endregion

        #region // Méthode qui modifie un nouveau Medicament avec la méthode UpdateUtilisateur de la DAL
        // Méthode qui modifie un nouveau Medicament avec la méthode UpdateUtilisateur de la DAL
        public static int ModifierMedicament(int id, string nom, bool archive, bool utilisation)
        {
            MedicamentBO med;
            med = new MedicamentBO(id, nom, archive, utilisation);
            return MedicamentsDAL.UpdateMedicament(med);
        }
        #endregion

        #region // Méthode qui créer un nouvel objet Medicament à partir de son id et de son nom
        // Méthode qui créer un nouvel objet Eleve à partir de son id et de son nom et qui le renvoi en l'ajoutant à la
        // BD avec la méthode AjoutEleve de la DAL
        public static int CreerUnMedicament(string nom, bool archive, bool utilisation)
        {
            MedicamentBO med;
            med = new MedicamentBO(nom, archive, utilisation);
            return MedicamentsDAL.AjoutMedicament(med);
        }
        #endregion

        #region // Méthode qui supprime un Medicament avec la méthode DeleteUtilisateur de la DAL
        // Méthode qui supprime un Eleve avec la méthode DeleteUtilisateur de la DAL
        public static int SupprimerMedicament(int id)
        {
            return MedicamentsDAL.DeleteMedicament(id);
        }
        #endregion

        #region // Méthode qui recherche un nom dans une List d'objets medicament en faisant appel à la méthode GetMedicament() de la DAL
        // Méthode qui cherche dans une List d'objets Visite en faisant appel à la méthode GetVisite() de la DAL
        public static List<MedicamentBO> GetMedicamentSearch(string search)
        {
            return MedicamentsDAL.GetMedicamentSearch(search);
        }

        #endregion
    }
}
