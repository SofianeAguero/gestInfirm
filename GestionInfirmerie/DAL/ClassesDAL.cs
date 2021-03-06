﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ClassesDAL
    {
        private static ClassesDAL uneClasse;

        // Accesseur en lecture, renvoi une instance
        public static ClassesDAL GetuneClasse()
        {
            if (uneClasse == null)
            {
                uneClasse = new ClassesDAL();
            }
            return uneClasse;
        }

        #region // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Identification
        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Identification
        public static List<ClasseBO> GetClasses()
        {
            int id;
            string nom;
            string emploiDuTemps;
            bool eleve;
            ClasseBO uneClasse;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Classes
            List<ClasseBO> lesClasses = new List<ClasseBO>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM classe ORDER BY Libelle_classe asc", maConnexion);
                SqlDataReader monReader = cmd.ExecuteReader();

                // Remplissage de la liste
                while (monReader.Read())
                {
                    id = Int32.Parse(monReader["Id_classe"].ToString());

                    if (monReader["Libelle_classe"] == DBNull.Value)
                    {
                        nom = default(string);
                    }
                    else
                    {
                        nom = monReader["Libelle_classe"].ToString();
                    }

                    if (monReader["Emploi_du_temps"] == DBNull.Value)
                    {
                        emploiDuTemps = default(string);
                    }
                    else
                    {
                        emploiDuTemps = monReader["Emploi_du_temps"].ToString();
                    }

                    if (monReader["Possede_eleve_classe"] == DBNull.Value)
                    {
                        eleve = default(bool);
                    }
                    else
                    {
                        eleve = Boolean.Parse(monReader["Possede_eleve_classe"].ToString());
                    }

                    uneClasse = new ClasseBO(id, nom, emploiDuTemps, eleve);
                    lesClasses.Add(uneClasse);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesClasses;
        }
        #endregion

        #region // Cette méthode modifie un Medicament passé en paramètre dans la BD
        // Cette méthode modifie un Medicament passé en paramètre dans la BD
        public static int UpdateClasse(ClasseBO uneClasse)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("UPDATE classe SET Libelle_classe = @leNom, Emploi_du_temps = @leEDT, Possede_eleve_classe = @lePossedeEleve WHERE Id_classe = @leId", maConnexion);

            // Création et déclaration des paramètres 
            cmd.Parameters.Add(new SqlParameter("@leNom", SqlDbType.NVarChar, 25));
            cmd.Parameters.Add(new SqlParameter("@leEDT", SqlDbType.NVarChar, 255));
            cmd.Parameters.Add(new SqlParameter("@lePossedeEleve", SqlDbType.Bit, 2));
            cmd.Parameters.Add(new SqlParameter("@leId", SqlDbType.Int, 11));

            // Attribution des valeurs aux paramètres 
            cmd.Parameters["@leNom"].Value = uneClasse.NomClasse;
            cmd.Parameters["@leEDT"].Value = uneClasse.EmploiDuTemps;
            cmd.Parameters["@lePossedeEleve"].Value = uneClasse.PossedeEleve;
            cmd.Parameters["@leId"].Value = Convert.ToInt32(uneClasse.IdClasse);

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        #endregion

        #region // Cette méthode supprime de la BD un Medicament dont l'id est passé en paramètre
        // Cette méthode supprime de la BD un Eleve dont l'id est passé en paramètre
        public static int DeleteClasse(int id)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("DELETE FROM classe WHERE Id_classe = @leId", maConnexion);

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
        public static int AjoutClasse(ClasseBO uneClasse)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand("INSERT INTO classe (Libelle_classe, Emploi_du_temps, Possede_eleve_classe) VALUES (@leNom, @leEDT, 0)", maConnexion);

            // Attribution des valeurs aux paramètres 
            cmd.Parameters.AddWithValue("@leNom", uneClasse.NomClasse);
            cmd.Parameters.AddWithValue("@leEDT", uneClasse.EmploiDuTemps);

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
        #endregion
    }
}
