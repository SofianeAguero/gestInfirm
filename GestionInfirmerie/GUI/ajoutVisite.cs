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
    public partial class ajoutVisite : Form
    {
        public ajoutVisite()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionElevesBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            // Création d'un objet List d'élèves à afficher dans le datagridview
            List<EleveBO> liste = new List<EleveBO>();
            liste = GestionElevesBLL.GetEleves();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;

            // Caché la colonne de l'id, date de naissance, santé, les téléphones, archives, tiers temps et visite
            dgv.Columns[11].Visible = false;
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].Visible = false;

            // Renommer les colonnes
            // -------------------
            // -------------------
            dgv.Columns[0].HeaderText = "Nom";
            dgv.Columns[1].HeaderText = "Prénom";
            dgv.Columns[2].HeaderText = "Date de naissance";

        }

        private void btnApp_Click(object sender, EventArgs e)
        {

            if (this.motifVisite.TextLength == 0 || this.heureDepartVisite.TextLength == 0 || this.heureArriveVisite.TextLength == 0)
            {
                if (this.motifVisite.TextLength == 0)
                {
                    errorMotif.SetError(motifVisite, "Le champ ne peut pas être vide!");
                }
                else
                {
                    if (this.heureDepartVisite.TextLength == 0)
                    {
                        errorDepart.SetError(heureDepartVisite, "Le champ ne peut pas être vide!");
                    }
                    else
                    {
                        if (this.heureArriveVisite.TextLength == 0)
                        {
                            errorArrivee.SetError(heureArriveVisite, "Le champ ne peut pas être vide!");
                        }
                    }
                }

            }
            else
            {
                // Boite de dialogue qui demande confirmation de la volonté d'ajouter une visite
                if (MessageBox.Show("Voulez-vous vraiment ajout cette visite ?", "Visite", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Actions effectuées si Oui est cliqué dans la message box
                    // Appel de la méthode AjoutVisiter de la couche BLL

                    GestionVisiteBLL.CreerUneVisite(motifVisite.Text, comVisite.Text.ToString(), heureArriveVisite.Text, heureDepartVisite.Text, dateVisite.Value, domicileVisite.Checked, hopitalVisite.Checked, parentsVisite.Checked, poulsVisite.Text, Int32.Parse(textId.Text.ToString()));

                    // Actualisation du datagridview
                    // Création d'un objet List d'Eleve à afficher dans le datagridview
                    List<EleveBO> liste = new List<EleveBO>();
                    liste = GestionElevesBLL.GetEleves();

                    // Rattachement de la List à la source de données du datagridview
                    dgv.DataSource = liste;
                    // Boite de dialogue qui confirme l'ajout en BD
                    MessageBox.Show("Ajout effectuée !", "Ajout d'une visite");
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EleveBO ut = new EleveBO(Int32.Parse(dgv.CurrentRow.Cells[11].Value.ToString()), dgv.CurrentRow.Cells[0].Value.ToString(), dgv.CurrentRow.Cells[1].Value.ToString(), DateTime.Parse(dgv.CurrentRow.Cells[2].Value.ToString()), dgv.CurrentRow.Cells[3].Value.ToString(), dgv.CurrentRow.Cells[4].Value.ToString(), dgv.CurrentRow.Cells[5].Value.ToString(), dgv.CurrentRow.Cells[6].Value.ToString(), Boolean.Parse(dgv.CurrentRow.Cells[7].Value.ToString()), Boolean.Parse(dgv.CurrentRow.Cells[8].Value.ToString()), Boolean.Parse(dgv.CurrentRow.Cells[9].Value.ToString()), Int32.Parse(dgv.CurrentRow.Cells[11].Value.ToString()));
            textId.Text = ut.IdEleve.ToString();
            txtNom.Text = ut.NomEleve;
            txtPrenom.Text = ut.PrenomEleve;
        }



    }
}
