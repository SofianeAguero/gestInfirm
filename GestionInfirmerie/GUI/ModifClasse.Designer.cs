namespace GUI
{
    partial class modifClasse
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
            this.components = new System.ComponentModel.Container();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.txtEDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPossedeEleve = new System.Windows.Forms.CheckBox();
            this.errorNomClasse = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnFrmAjoutClasse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNomClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 32);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(290, 147);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(3, 223);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Libelle";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(3, 256);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(60, 20);
            this.txtId.TabIndex = 3;
            this.txtId.Text = "ID CLASSE";
            this.txtId.Visible = false;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(29, 298);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(105, 37);
            this.btnModif.TabIndex = 5;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            this.btnModif.Validated += new System.EventHandler(this.btnModif_Validated);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(212, 298);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(107, 37);
            this.btnSupp.TabIndex = 6;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // txtEDT
            // 
            this.txtEDT.Location = new System.Drawing.Point(219, 223);
            this.txtEDT.Name = "txtEDT";
            this.txtEDT.Size = new System.Drawing.Size(100, 20);
            this.txtEDT.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Emploi du temps";
            // 
            // cbPossedeEleve
            // 
            this.cbPossedeEleve.AutoSize = true;
            this.cbPossedeEleve.Location = new System.Drawing.Point(191, 259);
            this.cbPossedeEleve.Name = "cbPossedeEleve";
            this.cbPossedeEleve.Size = new System.Drawing.Size(150, 17);
            this.cbPossedeEleve.TabIndex = 9;
            this.cbPossedeEleve.Text = "Elève(s) dans cette classe";
            this.cbPossedeEleve.UseVisualStyleBackColor = true;
            // 
            // errorNomClasse
            // 
            this.errorNomClasse.ContainerControl = this;
            // 
            // btnFrmAjoutClasse
            // 
            this.btnFrmAjoutClasse.Location = new System.Drawing.Point(238, 3);
            this.btnFrmAjoutClasse.Name = "btnFrmAjoutClasse";
            this.btnFrmAjoutClasse.Size = new System.Drawing.Size(112, 23);
            this.btnFrmAjoutClasse.TabIndex = 10;
            this.btnFrmAjoutClasse.Text = "Ajouter une classe";
            this.btnFrmAjoutClasse.UseVisualStyleBackColor = true;
            this.btnFrmAjoutClasse.Click += new System.EventHandler(this.btnFrmAjoutClasse_Click);
            // 
            // modifClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 341);
            this.Controls.Add(this.btnFrmAjoutClasse);
            this.Controls.Add(this.cbPossedeEleve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEDT);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dgv);
            this.Name = "modifClasse";
            this.Text = "ModifClasse";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNomClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.TextBox txtEDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbPossedeEleve;
        private System.Windows.Forms.ErrorProvider errorNomClasse;
        private System.Windows.Forms.Button btnFrmAjoutClasse;
    }
}