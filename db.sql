/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: classe
------------------------------------------------------------*/
CREATE TABLE classe(
	Id_classe            INT IDENTITY (1,1) NOT NULL ,
	Libelle_classe       VARCHAR (255) NOT NULL ,
	Emploi_du_temps      VARCHAR (255)  ,
	Possede_eleve_classe bit  NOT NULL ,
	Id_niveau            INT  NOT NULL ,
	CONSTRAINT prk_constraint_classe PRIMARY KEY NONCLUSTERED (Id_classe)
);


/*------------------------------------------------------------
-- Table: niveau
------------------------------------------------------------*/
CREATE TABLE niveau(
	Id_niveau      INT IDENTITY (1,1) NOT NULL ,
	Libelle_niveau VARCHAR (255)  ,
	CONSTRAINT prk_constraint_niveau PRIMARY KEY NONCLUSTERED (Id_niveau)
);


/*------------------------------------------------------------
-- Table: eleve
------------------------------------------------------------*/
CREATE TABLE eleve(
	Id_eleve                 INT IDENTITY (1,1) NOT NULL ,
	Nom_eleve                VARCHAR (25) NOT NULL ,
	Prenom_eleve             VARCHAR (25) NOT NULL ,
	Date_naissance_eleve     DATETIME  ,
	Sante_eleve              VARCHAR (255) NOT NULL ,
	Tel_eleve                VARCHAR (25)  ,
	Tel_pere_eleve           VARCHAR (25)  ,
	Tel_mere_eleve           VARCHAR (25)  ,
	Archive_eleve            bit  ,
	Possede_tiers_temps_exam bit  ,
	Possede_visite           bit  ,
	Id_classe                INT  NOT NULL ,
	CONSTRAINT prk_constraint_eleve PRIMARY KEY NONCLUSTERED (Id_eleve)
);


/*------------------------------------------------------------
-- Table: visite
------------------------------------------------------------*/
CREATE TABLE visite(
	Id_visite               INT IDENTITY (1,1) NOT NULL ,
	Motif_visite            VARCHAR (255)  ,
	Commentaire_visite      VARCHAR (512)  ,
	Heure_entree_visite     VARCHAR (8)  ,
	Heure_sortie_visite     VARCHAR (8)  ,
	Date_visite             DATETIME NOT NULL ,
	Retour_domicile_visite  bit  NOT NULL ,
	Hopital_visite          bit  NOT NULL ,
	Parents_prevenus_visite bit  NOT NULL ,
	Pouls_eleve_visite      VARCHAR (25)  ,
	Id_eleve                INT  NOT NULL ,
	CONSTRAINT prk_constraint_visite PRIMARY KEY NONCLUSTERED (Id_visite)
);


/*------------------------------------------------------------
-- Table: medicament
------------------------------------------------------------*/
CREATE TABLE medicament(
	Id_medicament             INT IDENTITY (1,1) NOT NULL ,
	Libelle_medicament        VARCHAR (35) NOT NULL ,
	Archive_medicament        bit  NOT NULL ,
	Possede_visite_medicament bit  NOT NULL ,
	CONSTRAINT prk_constraint_medicament PRIMARY KEY NONCLUSTERED (Id_medicament)
);


/*------------------------------------------------------------
-- Table: utilisateur
------------------------------------------------------------*/
CREATE TABLE utilisateur(
	Id_utilisateur    INT IDENTITY (1,1) NOT NULL ,
	Login_utilisateur VARCHAR (255) NOT NULL ,
	Mdp_utilisateur   VARCHAR (512) NOT NULL ,
	Type_utilisateur  VARCHAR (255) NOT NULL ,
	CONSTRAINT prk_constraint_utilisateur PRIMARY KEY NONCLUSTERED (Id_utilisateur)
);


/*------------------------------------------------------------
-- Table: prescrire
------------------------------------------------------------*/
CREATE TABLE prescrire(
	Id_medicament INT  NOT NULL ,
	Id_visite     INT  NOT NULL ,
	CONSTRAINT prk_constraint_prescrire PRIMARY KEY NONCLUSTERED (Id_medicament,Id_visite)
);



ALTER TABLE classe ADD CONSTRAINT FK_classe_Id_niveau FOREIGN KEY (Id_niveau) REFERENCES niveau(Id_niveau);
ALTER TABLE eleve ADD CONSTRAINT FK_eleve_Id_classe FOREIGN KEY (Id_classe) REFERENCES classe(Id_classe);
ALTER TABLE visite ADD CONSTRAINT FK_visite_Id_eleve FOREIGN KEY (Id_eleve) REFERENCES eleve(Id_eleve);
ALTER TABLE prescrire ADD CONSTRAINT FK_prescrire_Id_medicament FOREIGN KEY (Id_medicament) REFERENCES medicament(Id_medicament);
ALTER TABLE prescrire ADD CONSTRAINT FK_prescrire_Id_visite FOREIGN KEY (Id_visite) REFERENCES visite(Id_visite);
