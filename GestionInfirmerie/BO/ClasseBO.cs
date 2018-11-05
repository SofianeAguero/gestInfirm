using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    public class ClasseBO
    {
        private int idClasse;
        private string nomClasse;
        private string emploiDuTemps;
        private bool possedeEleve;

        #region // Constructeur avec l'id
        // Constructeur avec l'id
        public ClasseBO(int id, string leNom, string lEmploiDuTemps, bool eleve)
        {
            this.idClasse = id;
            this.nomClasse = leNom;
            this.emploiDuTemps = lEmploiDuTemps;
            this.possedeEleve = eleve;
        }
        #endregion

        #region // Constructeur sans l'id l'archive et lutilisation
        // Constructeur avec l'id
        public ClasseBO(string leNom)
        {
            this.nomClasse = leNom;
        }
        #endregion

        #region // Constructeur sans l'id et possedeEleve
        // Constructeur sans l'id et possedeEleve (pour l'ajout d'une classe)
        public ClasseBO(string leNom, string lEmploiDuTemps)
        {
            this.nomClasse = leNom;
            this.emploiDuTemps = lEmploiDuTemps;
        }
        #endregion

        #region // getter/setter
        public int IdClasse
        {
            get { return idClasse; }
            set { idClasse = value; }
        }

        public string NomClasse
        {
            get { return nomClasse; }
            set { nomClasse = value; }
        }

        public string EmploiDuTemps
        {
            get { return emploiDuTemps; }
            set { emploiDuTemps = value; }
        }


        public bool PossedeEleve
        {
            get { return possedeEleve; }
            set { possedeEleve = value; }
        }
        #endregion
    }
}
