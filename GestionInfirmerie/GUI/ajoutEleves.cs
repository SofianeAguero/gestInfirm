﻿using System;
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
    public partial class ajoutEleves : Form
    {
        public ajoutEleves()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionElevesBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

        }

        private void btn_enregistrer_Click_1(object sender, EventArgs e)
        {

            if (this.txtNom.TextLength == 0 || this.txtPrenom.TextLength == 0 || this.txtTelEleve.TextLength == 0 || this.txtTelPere.TextLength == 0 || this.txtTelMere.TextLength == 0)
            {
                if (this.txtNom.TextLength == 0)
                {
                    errorProviderNom.SetError(txtNom, "Le champ ne peut pas être vide!");
                }
                else
                {
                    if (this.txtPrenom.TextLength == 0)
                    {
                        errorProviderPrenom.SetError(txtPrenom, "Le champ ne peut pas être vide!");
                    }
                    else
                    {
                        if (this.txtTelEleve.TextLength == 0)
                        {
                            errorProviderTelEl.SetError(txtTelEleve, "Le champ ne peut pas être vide!");
                        }
                        else
                        {
                            if (this.txtTelPere.TextLength == 0)
                            {
                                errorProviderTelPere.SetError(txtTelPere, "Le champ ne peut pas être vide!");
                            }
                            else
                            {
                                if (this.txtTelMere.TextLength == 0)
                                {
                                    errorProviderTelMere.SetError(txtTelMere, "Le champ ne peut pas être vide!");
                                }
                            }
                        }

                    }
                }

            }
            else 
            {
                // Boite de dialogue qui demande confirmation de la volonté de supprimer l'enregistrement
                if (MessageBox.Show("Voulez-vous vraiment ajouter cet élèves ?", "Ajout", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Actions effectuées si Oui est cliqué dans la message box
                    // Appel de la méthode SupprimerEleve de la couche BLL

                    GestionElevesBLL.CreerUneleve(txtNom.Text.ToString(), txtPrenom.Text.ToString(), dateNaissance.Value, txtSante.Text.ToString(), txtTelEleve.Text.ToString(), txtTelPere.Text.ToString(), txtTelMere.Text.ToString(), Int32.Parse(cbClasse.SelectedValue.ToString()));

                    // Boite de dialogue qui confirme la suppression en BD
                    MessageBox.Show("Ajout effectuée !", "Ajout");


                }
            
            }
        }

        private void ajoutEleves_Load_1(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_infirmerieDataSet1.classe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.classeTableAdapter1.Fill(this.gestion_infirmerieDataSet1.classe);

        }
    }
}
