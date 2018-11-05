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
    public partial class modifClasse : Form
    {
        ajoutClasses frmAjoutClasses;

        public modifClasse()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionClassesBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            // Création d'un objet List de Medicaments à afficher dans le datagridview
            List<ClasseBO> liste = new List<ClasseBO>();
            liste = GestionClassesBLL.GetClasses();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;

            // Caché la colonne de l'id et celle de "Possede eleve"
            dgv.Columns[0].Visible = false;
            dgv.Columns[3].Visible = false;

            // Renommer les colonnes
            // -------------------
            // -------------------
            dgv.Columns[1].HeaderText = "Libellé";
            dgv.Columns[2].HeaderText = "Emploi du temps";
        }

        // Bouton Modifier
        private void btnModif_Click(object sender, EventArgs e)
        {
            // Appel de la méthode ModifierMedicament de la couche BLL
            if (this.txtNom.TextLength == 0)
            {
                errorNomClasse.SetError(txtNom, "Le champ ne peut pas être vide!");
            }

            else
            {
                GestionClassesBLL.ModifierClasse(Int32.Parse(txtId.Text.ToString()), txtNom.Text, txtEDT.Text, Boolean.Parse(cbPossedeEleve.Checked.ToString()));

                dgv.Refresh();

                // Une fois la suppression effectuée, rendre innopérants certains contrôles
                txtNom.Enabled = false;
                txtEDT.Enabled = false;
                cbPossedeEleve.Enabled = false;
                btnModif.Enabled = false;
                btnSupp.Enabled = false;

                // Actualisation du datagridview
                // Création d'un objet List Classe à afficher dans le datagridview
                List<ClasseBO> liste = new List<ClasseBO>();
                liste = GestionClassesBLL.GetClasses();

                // Rattachement de la List à la source de données du datagridview
                dgv.DataSource = liste;

                // Boite de dialogue qui confirme la suppression en BD
                MessageBox.Show("Modification effectuée !", "Modification");
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            // Boite de dialogue qui demande confirmation de la volonté de supprimer l'enregistrement
            if (MessageBox.Show("Voulez-vous vraiment supprimer cet élèves ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Actions effectuées si Oui est cliqué dans la message box
                // Appel de la méthode SupprimerEleve de la couche BLL

                GestionClassesBLL.SupprimerClasse(Int32.Parse(dgv.CurrentRow.Cells[0].Value.ToString()));

                dgv.Refresh();

                // Une fois la suppression effectuée, rendre innopérants certains contrôles
                txtNom.Enabled = false;
                txtEDT.Enabled = false;
                cbPossedeEleve.Enabled = false;
                btnModif.Enabled = false;
                btnSupp.Enabled = false;

                // Actualisation du datagridview
                // Création d'un objet List Classe à afficher dans le datagridview
                List<ClasseBO> liste = new List<ClasseBO>();
                liste = GestionClassesBLL.GetClasses();

                // Rattachement de la List à la source de données du datagridview
                dgv.DataSource = liste;

                // Boite de dialogue qui confirme la suppression en BD
                MessageBox.Show("Supression effectuée !", "Suppression");
            }
        }

        // Redirection vers le formulaire d'ajout d'une classe
        private void btnFrmAjoutClasse_Click(object sender, EventArgs e)
        {
            frmAjoutClasses = new ajoutClasses();
            frmAjoutClasses.Show();
            this.Hide();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClasseBO laClasse = new ClasseBO(Int32.Parse(dgv.CurrentRow.Cells[0].Value.ToString()), dgv.CurrentRow.Cells[1].Value.ToString(), dgv.CurrentRow.Cells[2].Value.ToString(), Boolean.Parse(dgv.CurrentRow.Cells[3].Value.ToString()));
            txtId.Text = laClasse.IdClasse.ToString();
            txtNom.Text = laClasse.NomClasse;
            txtEDT.Text = laClasse.EmploiDuTemps;
            cbPossedeEleve.Checked = laClasse.PossedeEleve;

            // Déblocage des boutons de modification et de suppression sur clique d'une ligne
            txtNom.Enabled = true;
            txtEDT.Enabled = true;
            cbPossedeEleve.Enabled = true;
            btnModif.Enabled = true;
            btnSupp.Enabled = true;
        }

        private void btnModif_Validated(object sender, EventArgs e)
        {
            // Si toutes les conditions ont été remplisent : clear l'errorProvider
            // Ou si on clique sur un row de la dgv : clear l'errorProvider
            errorNomClasse.SetError(txtNom, "");
        }
    }
}
