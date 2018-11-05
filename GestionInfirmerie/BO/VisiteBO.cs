﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    public class VisiteBO
    {
        private int idVisite;
        private string motif;
        private string commentaire;
        private string heureArrive;
        private string heureDepart;
        private DateTime dateVisite;
        private bool retourDomicile;
        private bool hopital;
        private bool parentsPrevenus;
        private string pouls;
        private int idEleve;
        private string nomEleve;
        private string prenomEleve;

        
        #region Getter/setter

        public int IdVisite
        {
            get { return idVisite; }
            set { idVisite = value; }
        }

        public string Motif
        {
            get { return motif; }
            set { motif = value; }
        }

        public string Commentaire
        {
            get { return commentaire; }
            set { commentaire = value; }
        }

        public string HeureArrive
        {
            get { return heureArrive; }
            set { heureArrive = value; }
        }

        public string HeureDepart
        {
            get { return heureDepart; }
            set { heureDepart = value; }
        }

        public DateTime DateVisite
        {
            get { return dateVisite; }
            set { dateVisite = value; }
        }

        public bool RetourDomicile
        {
            get { return retourDomicile; }
            set { retourDomicile = value; }
        }

        public bool Hopital
        {
            get { return hopital; }
            set { hopital = value; }
        }

        public bool ParentsPrevenus
        {
            get { return parentsPrevenus; }
            set { parentsPrevenus = value; }
        }

        public string Pouls
        {
            get { return pouls; }
            set { pouls = value; }
        }

        public int IdEleve
        {
            get { return idEleve; }
            set { idEleve = value; }
        }

        public string NomEleve
        {
            get { return nomEleve; }
            set { nomEleve = value; }
        }

        public string PrenomEleve
        {
            get { return prenomEleve; }
            set { prenomEleve = value; }
        }
        #endregion

        #region Constructeur avec l'id et nom prenom
        public VisiteBO(int id, string leMotif, string leCommentaire, string lHeureArrive, string lHeureDepart, DateTime laDate, bool leRetour, bool lHopital, bool lesParents, string lePoul, int lIdEleve, string leNom, string lePrenom)
        {
            this.idVisite = id;
            this.motif = leMotif;
            this.commentaire = leCommentaire;
            this.heureArrive = lHeureArrive;
            this.heureDepart = lHeureDepart;
            this.dateVisite = laDate;
            this.retourDomicile = leRetour;
            this.hopital = lHopital;
            this.parentsPrevenus = lesParents;
            this.pouls = lePoul;
            this.idEleve = lIdEleve;
            this.nomEleve = leNom;
            this.prenomEleve = lePrenom;
        }
        #endregion

        #region Constructeur sans l'id
        public VisiteBO(string leMotif, string leCommentaire, string lHeureArrive, string lHeureDepart, DateTime laDate, bool leRetour, bool lHopital, bool lesParents, string lePoul, int lIdEleve)
        {
            this.motif = leMotif;
            this.commentaire = leCommentaire;
            this.heureArrive = lHeureArrive;
            this.heureDepart = lHeureDepart;
            this.dateVisite = laDate;
            this.retourDomicile = leRetour;
            this.hopital = lHopital;
            this.parentsPrevenus = lesParents;
            this.pouls = lePoul;
            this.idEleve = lIdEleve;
        }
        #endregion

        #region Constructeur avec l'id
        public VisiteBO(int id, string leMotif, string leCommentaire, string lHeureArrive, string lHeureDepart, DateTime laDate, bool leRetour, bool lHopital, bool lesParents, string lePoul, int lIdEleve)
        {
            this.idVisite = id;
            this.motif = leMotif;
            this.commentaire = leCommentaire;
            this.heureArrive = lHeureArrive;
            this.heureDepart = lHeureDepart;
            this.dateVisite = laDate;
            this.retourDomicile = leRetour;
            this.hopital = lHopital;
            this.parentsPrevenus = lesParents;
            this.pouls = lePoul;
            this.idEleve = lIdEleve;
        }
        #endregion

    }
}
