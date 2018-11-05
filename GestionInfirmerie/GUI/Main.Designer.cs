namespace GUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesÉlèvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesVisitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listesDesVistesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieDesVisitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifDesVisitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesMédicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesMédicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDesMédicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supModifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synthèseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivesDesÉlèvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivesDesMédicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesÉlèvesToolStripMenuItem,
            this.gestionDesVisitesToolStripMenuItem,
            this.gestionDesMédicamentsToolStripMenuItem,
            this.synthèseToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.bilanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1239, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesÉlèvesToolStripMenuItem
            // 
            this.gestionDesÉlèvesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeToolStripMenuItem,
            this.ajoutToolStripMenuItem,
            this.supToolStripMenuItem});
            this.gestionDesÉlèvesToolStripMenuItem.Name = "gestionDesÉlèvesToolStripMenuItem";
            this.gestionDesÉlèvesToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.gestionDesÉlèvesToolStripMenuItem.Text = "Gestion des élèves";
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.ajoutToolStripMenuItem.Text = "Ajout";
            this.ajoutToolStripMenuItem.Click += new System.EventHandler(this.ajoutToolStripMenuItem_Click);
            // 
            // supToolStripMenuItem
            // 
            this.supToolStripMenuItem.Name = "supToolStripMenuItem";
            this.supToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.supToolStripMenuItem.Text = "Suppression/modifcation";
            this.supToolStripMenuItem.Click += new System.EventHandler(this.supToolStripMenuItem_Click);
            // 
            // gestionDesVisitesToolStripMenuItem
            // 
            this.gestionDesVisitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listesDesVistesToolStripMenuItem,
            this.saisieDesVisitesToolStripMenuItem,
            this.modifDesVisitesToolStripMenuItem});
            this.gestionDesVisitesToolStripMenuItem.Name = "gestionDesVisitesToolStripMenuItem";
            this.gestionDesVisitesToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.gestionDesVisitesToolStripMenuItem.Text = "Gestion des visites";
            // 
            // listesDesVistesToolStripMenuItem
            // 
            this.listesDesVistesToolStripMenuItem.Name = "listesDesVistesToolStripMenuItem";
            this.listesDesVistesToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.listesDesVistesToolStripMenuItem.Text = "Listes des vistes";
            this.listesDesVistesToolStripMenuItem.Click += new System.EventHandler(this.listesDesVistesToolStripMenuItem_Click);
            // 
            // saisieDesVisitesToolStripMenuItem
            // 
            this.saisieDesVisitesToolStripMenuItem.Name = "saisieDesVisitesToolStripMenuItem";
            this.saisieDesVisitesToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.saisieDesVisitesToolStripMenuItem.Text = "Saisie des visites";
            this.saisieDesVisitesToolStripMenuItem.Click += new System.EventHandler(this.saisieDesVisitesToolStripMenuItem_Click);
            // 
            // modifDesVisitesToolStripMenuItem
            // 
            this.modifDesVisitesToolStripMenuItem.Name = "modifDesVisitesToolStripMenuItem";
            this.modifDesVisitesToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.modifDesVisitesToolStripMenuItem.Text = "Modif des visites";
            this.modifDesVisitesToolStripMenuItem.Click += new System.EventHandler(this.modifDesVisitesToolStripMenuItem_Click);
            // 
            // gestionDesMédicamentsToolStripMenuItem
            // 
            this.gestionDesMédicamentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesMédicamentsToolStripMenuItem,
            this.ajoutDesMédicamentsToolStripMenuItem,
            this.supModifToolStripMenuItem});
            this.gestionDesMédicamentsToolStripMenuItem.Name = "gestionDesMédicamentsToolStripMenuItem";
            this.gestionDesMédicamentsToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.gestionDesMédicamentsToolStripMenuItem.Text = "Gestion des médicaments";
            // 
            // listeDesMédicamentsToolStripMenuItem
            // 
            this.listeDesMédicamentsToolStripMenuItem.Name = "listeDesMédicamentsToolStripMenuItem";
            this.listeDesMédicamentsToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.listeDesMédicamentsToolStripMenuItem.Text = "Liste des médicaments";
            this.listeDesMédicamentsToolStripMenuItem.Click += new System.EventHandler(this.listeDesMédicamentsToolStripMenuItem_Click);
            // 
            // ajoutDesMédicamentsToolStripMenuItem
            // 
            this.ajoutDesMédicamentsToolStripMenuItem.Name = "ajoutDesMédicamentsToolStripMenuItem";
            this.ajoutDesMédicamentsToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.ajoutDesMédicamentsToolStripMenuItem.Text = "Ajout des médicaments";
            this.ajoutDesMédicamentsToolStripMenuItem.Click += new System.EventHandler(this.ajoutDesMédicamentsToolStripMenuItem_Click);
            // 
            // supModifToolStripMenuItem
            // 
            this.supModifToolStripMenuItem.Name = "supModifToolStripMenuItem";
            this.supModifToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.supModifToolStripMenuItem.Text = "Suppression / Modification";
            this.supModifToolStripMenuItem.Click += new System.EventHandler(this.supModifToolStripMenuItem_Click);
            // 
            // synthèseToolStripMenuItem
            // 
            this.synthèseToolStripMenuItem.Name = "synthèseToolStripMenuItem";
            this.synthèseToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.synthèseToolStripMenuItem.Text = "Synthèse";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesClassesToolStripMenuItem,
            this.archivesDesÉlèvesToolStripMenuItem,
            this.archivesDesMédicamentsToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // gestionDesClassesToolStripMenuItem
            // 
            this.gestionDesClassesToolStripMenuItem.Name = "gestionDesClassesToolStripMenuItem";
            this.gestionDesClassesToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.gestionDesClassesToolStripMenuItem.Text = "Gestion des classes";
            this.gestionDesClassesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesClassesToolStripMenuItem_Click);
            // 
            // archivesDesÉlèvesToolStripMenuItem
            // 
            this.archivesDesÉlèvesToolStripMenuItem.Name = "archivesDesÉlèvesToolStripMenuItem";
            this.archivesDesÉlèvesToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.archivesDesÉlèvesToolStripMenuItem.Text = "Archives des élèves";
            // 
            // archivesDesMédicamentsToolStripMenuItem
            // 
            this.archivesDesMédicamentsToolStripMenuItem.Name = "archivesDesMédicamentsToolStripMenuItem";
            this.archivesDesMédicamentsToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.archivesDesMédicamentsToolStripMenuItem.Text = "Archives des médicaments";
            // 
            // bilanToolStripMenuItem
            // 
            this.bilanToolStripMenuItem.Name = "bilanToolStripMenuItem";
            this.bilanToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.bilanToolStripMenuItem.Text = "Bilan";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1239, 575);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesÉlèvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesVisitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listesDesVistesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieDesVisitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesMédicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesMédicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDesMédicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem synthèseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivesDesÉlèvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivesDesMédicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supModifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifDesVisitesToolStripMenuItem;
    }
}