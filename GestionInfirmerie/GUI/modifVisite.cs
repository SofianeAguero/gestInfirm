using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using BLL;
using BO;

namespace GUI
{
    public partial class modifVisite : Form
    {
        public modifVisite()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionVisiteBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            // Création d'un objet List d'élèves à afficher dans le datagridview
            List<VisiteBO> liste = new List<VisiteBO>();
            liste = GestionVisiteBLL.GetVisite();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;

            // Caché la colonne de l'id
           dgv.Columns[10].Visible = false;
           dgv.Columns[0].Visible = false;

            // Renommer les colonnes
            // -------------------
            // -------------------
            dgv.Columns[0].HeaderText = "iD";
            dgv.Columns[1].HeaderText = "Motif";
            dgv.Columns[2].HeaderText = "Commentaire";
            dgv.Columns[3].HeaderText = "Heure Arrivé";
            dgv.Columns[4].HeaderText = "Heure Départ";
            dgv.Columns[5].HeaderText = "Date Visite";
            dgv.Columns[6].HeaderText = "Retour Domicile";
            dgv.Columns[7].HeaderText = "Hopital";
            dgv.Columns[8].HeaderText = "Parents";
            dgv.Columns[9].HeaderText = "Pouls";
            dgv.Columns[10].HeaderText = "Eleve Id";
            dgv.Columns[11].HeaderText = "Nom";
            dgv.Columns[12].HeaderText = "Prenom";
        }

        private void validerBtn_Click(object sender, EventArgs e)
        {
            // Boite de dialogue qui demande confirmation de la volonté de modifier l'enregistrement
            if (MessageBox.Show("Voulez-vous vraiment modifier cet élèves ?", "Modif", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Actions effectuées si Oui est cliqué dans la message box
                // Appel de la méthode ModifierEleve de la couche BLL

                GestionVisiteBLL.ModifierVisite(Int32.Parse(visiteID.Text.ToString()), motifTxt.Text, commentaireTxt.Text, dateTxt.Value, entreeTxt.Text.ToString(), sortieTxt.Text, domicileCk.Checked, hopitalCk.Checked, prevenuCk.Checked, poulsTxt.Text, Int32.Parse(eleveId.Text.ToString()));

                // Actualisation du datagridview
                // Création d'un objet List d'Utilisateur à afficher dans le datagridview
                List<VisiteBO> liste = new List<VisiteBO>();
                liste = GestionVisiteBLL.GetVisite();

                // Rattachement de la List à la source de données du datagridview
                dgv.DataSource = liste;
                // Boite de dialogue qui confirme la modification en BD
                MessageBox.Show("Modification effectuée !", "Modification");
                motifTxt.Clear();
                commentaireTxt.Clear();
                entreeTxt.Clear();
                sortieTxt.Clear();
                domicileCk.Checked = false;
                hopitalCk.Checked = false;
                prevenuCk.Checked = false;
                poulsTxt.Clear();
                nomTxt.Clear();
                prenomTxt.Clear();
            }     
        }


        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VisiteBO ut = new VisiteBO(Int32.Parse(dgv.CurrentRow.Cells[0].Value.ToString()), dgv.CurrentRow.Cells[1].Value.ToString(), dgv.CurrentRow.Cells[2].Value.ToString(), dgv.CurrentRow.Cells[3].Value.ToString(), dgv.CurrentRow.Cells[4].Value.ToString(), DateTime.Parse(dgv.CurrentRow.Cells[5].Value.ToString()), Boolean.Parse(dgv.CurrentRow.Cells[6].Value.ToString()), Boolean.Parse(dgv.CurrentRow.Cells[7].Value.ToString()), Boolean.Parse(dgv.CurrentRow.Cells[8].Value.ToString()), dgv.CurrentRow.Cells[9].Value.ToString(), Int32.Parse(dgv.CurrentRow.Cells[10].Value.ToString()), dgv.CurrentRow.Cells[11].Value.ToString(), dgv.CurrentRow.Cells[12].Value.ToString());
            visiteID.Text = ut.IdVisite.ToString();
            motifTxt.Text = ut.Motif;
            commentaireTxt.Text = ut.Commentaire;
            dateTxt.Value = ut.DateVisite;
            entreeTxt.Text = ut.HeureArrive;
            sortieTxt.Text = ut.HeureDepart;
            domicileCk.Checked = ut.RetourDomicile;
            hopitalCk.Checked = ut.Hopital;
            prevenuCk.Checked = ut.ParentsPrevenus;
            poulsTxt.Text = ut.Pouls;
            eleveId.Text = ut.IdEleve.ToString();
            nomTxt.Text = ut.NomEleve;
            prenomTxt.Text = ut.PrenomEleve;
        }
    }
}
