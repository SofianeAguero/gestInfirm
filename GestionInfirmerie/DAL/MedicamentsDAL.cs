using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class MedicamentsDAL
    {
        private static MedicamentsDAL unMedicament;

        // Accesseur en lecture, renvoi une instance
        public static MedicamentsDAL GetunMedicament()
        {
            if (unMedicament == null)
            {
                unMedicament = new MedicamentsDAL();
            }
            return unMedicament;
        }

        #region // Cette méthode retourne une List contenant les objets medicaments contenus dans la table medicament
        // Cette méthode retourne une List contenant les objets medicaments contenus dans la table medicament
        public static List<MedicamentBO> GetMedicaments()
        {
            int id;
            string nom;
            bool archive;
            bool utilisation;
            MedicamentBO unMedicament;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Medicaments
            List<MedicamentBO> lesMedicaments = new List<MedicamentBO>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM medicament", maConnexion);
                SqlDataReader monReader = cmd.ExecuteReader();

                // Remplissage de la liste
                while (monReader.Read())
                {
                    id = Int32.Parse(monReader["Id_medicament"].ToString());

                    if (monReader["Libelle_medicament"] == DBNull.Value)
                    {
                        nom = default(string);
                    }
                    else
                    {
                        nom = monReader["Libelle_medicament"].ToString();
                    }

                    if (monReader["Archive_medicament"] == DBNull.Value)
                    {
                        archive = default(bool);
                    }
                    else
                    {
                        archive = Boolean.Parse(monReader["Archive_medicament"].ToString());
                    }

                    if (monReader["Possede_visite_medicament"] == DBNull.Value)
                    {
                        utilisation = default(bool);
                    }
                    else
                    {
                        utilisation = Boolean.Parse(monReader["Possede_visite_medicament"].ToString());
                    }

                    unMedicament = new MedicamentBO(id, nom, archive, utilisation);
                    lesMedicaments.Add(unMedicament);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesMedicaments;
        }
        #endregion

        #region // Cette méthode modifie un Medicament passé en paramètre dans la BD
        // Cette méthode modifie un Medicament passé en paramètre dans la BD
        public static int UpdateMedicament(MedicamentBO unMedicament)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("UPDATE medicament SET Libelle_medicament = @leNom, Archive_medicament = @leArchive," +
                " Possede_visite_medicament = @leUtilisationDansUneVisite  WHERE Id_medicament = @leId", maConnexion);

            // Création et déclaration des paramètres 
            cmd.Parameters.Add(new SqlParameter("@leNom", SqlDbType.NVarChar, 11));
            cmd.Parameters.Add(new SqlParameter("@leArchive", SqlDbType.Bit, 2));
            cmd.Parameters.Add(new SqlParameter("@leUtilisationDansUneVisite", SqlDbType.Bit, 2));
            cmd.Parameters.Add(new SqlParameter("@leId", SqlDbType.Int, 11));

            // Attribution des valeurs aux paramètres 
            cmd.Parameters["@leNom"].Value = unMedicament.NomMedicament;
            cmd.Parameters["@leArchive"].Value = Convert.ToBoolean(unMedicament.ArchiveMedicament);
            cmd.Parameters["@leUtilisationDansUneVisite"].Value = unMedicament.UtilisationDansUneVisite;
            cmd.Parameters["@leId"].Value = Convert.ToInt32(unMedicament.IdMedicament);

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        #endregion

        #region // Cette méthode supprime de la BD un Medicament dont l'id est passé en paramètre
        // Cette méthode supprime de la BD un Eleve dont l'id est passé en paramètre
        public static int DeleteMedicament(int id)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("DELETE FROM medicament WHERE Id_medicament = @leId", maConnexion);

            // Création et déclaration des paramètres 
            cmd.Parameters.Add(new SqlParameter("@leId", SqlDbType.Int, 11));

            // Attribution des valeurs aux paramètres 
            cmd.Parameters["@leId"].Value = id;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
        #endregion

        #region // Cette méthode insert un nouveau medicament passé en paramètre dans la BD
        // Cette méthode insert un nouvel Eleve passé en paramètre dans la BD
        public static int AjoutMedicament(MedicamentBO unMedicament)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand("INSERT INTO medicament (Libelle_medicament, Archive_medicament, Possede_visite_medicament) VALUES (@leLibelle, @leArchive, @leVisiteMedicament)", maConnexion);

            // Attribution des valeurs aux paramètres 
            cmd.Parameters.AddWithValue("@leLibelle", unMedicament.NomMedicament);
            cmd.Parameters.AddWithValue("@leArchive", unMedicament.ArchiveMedicament);
            cmd.Parameters.AddWithValue("@leVisiteMedicament", unMedicament.UtilisationDansUneVisite);

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
        #endregion

        #region // Cette méthode retourne une List de recherceh contenant les objets medicaments contenus dans la table medicament
        // Cette méthode retourne une List contenant les objets medicaments contenus dans la table medicament
        public static List<MedicamentBO> GetMedicamentSearch(string search)
        {
            int id;
            string nom;
            bool archive;
            bool utilisation;
            MedicamentBO unMedicament;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Medicaments
            List<MedicamentBO> lesMedicaments = new List<MedicamentBO>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM medicament where Libelle_medicament LIKE '%" + search + "%'", maConnexion);
                SqlDataReader monReader = cmd.ExecuteReader();

                // Remplissage de la liste
                while (monReader.Read())
                {
                    id = Int32.Parse(monReader["Id_medicament"].ToString());

                    if (monReader["Libelle_medicament"] == DBNull.Value)
                    {
                        nom = default(string);
                    }
                    else
                    {
                        nom = monReader["Libelle_medicament"].ToString();
                    }

                    if (monReader["Archive_medicament"] == DBNull.Value)
                    {
                        archive = default(bool);
                    }
                    else
                    {
                        archive = Boolean.Parse(monReader["Archive_medicament"].ToString());
                    }

                    if (monReader["Possede_visite_medicament"] == DBNull.Value)
                    {
                        utilisation = default(bool);
                    }
                    else
                    {
                        utilisation = Boolean.Parse(monReader["Possede_visite_medicament"].ToString());
                    }

                    unMedicament = new MedicamentBO(id, nom, archive, utilisation);
                    lesMedicaments.Add(unMedicament);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesMedicaments;
        }
        #endregion

    }
}
