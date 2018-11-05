using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using BO;
using System.Configuration;

namespace GUI
{
    public partial class ajoutClasses : Form
    {
        gestClasses frmGestClasses;
        modifClasse frmModifClasse;

        public ajoutClasses()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionClassesBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
        }

        private void btnAjoutClasse_Click(object sender, EventArgs e)
        {
            if (this.txtNomClasse.TextLength == 0)
            {
                errorNomClasse.SetError(txtNomClasse, "Le champ ne peut pas être vide!");
            }
            else
            {
                // Boite de dialogue qui demande confirmation de la volonté de supprimer l'enregistrement
                if (MessageBox.Show("Voulez-vous vraiment ajouter cet élèves ?", "Ajout", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Actions effectuées si Oui est cliqué dans la message box
                    // Appel de la méthode CreerUneClasse de la couche BLL

                    GestionClassesBLL.CreerUneClasse(txtNomClasse.Text.ToString(), txtEDT.Text.ToString());

                    // Redirection vers le formulaire contenant la liste des classes (dgv)
                    frmModifClasse = new modifClasse();
                    frmModifClasse.Show();
                    this.Hide();
                }
            }
        }

        // Bouton Annuler
        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmGestClasses = new gestClasses();
            frmGestClasses.Show();
            this.Hide();
        }
    }
}
