namespace GUI
{
    partial class modifVisite
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
            this.motifTxt = new System.Windows.Forms.TextBox();
            this.commentaireTxt = new System.Windows.Forms.TextBox();
            this.entreeTxt = new System.Windows.Forms.TextBox();
            this.sortieTxt = new System.Windows.Forms.TextBox();
            this.poulsTxt = new System.Windows.Forms.TextBox();
            this.hopitalCk = new System.Windows.Forms.CheckBox();
            this.prevenuCk = new System.Windows.Forms.CheckBox();
            this.domicileCk = new System.Windows.Forms.CheckBox();
            this.dateTxt = new System.Windows.Forms.DateTimePicker();
            this.lblNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.validerBtn = new System.Windows.Forms.Button();
            this.visiteID = new System.Windows.Forms.TextBox();
            this.eleveId = new System.Windows.Forms.TextBox();
            this.nomTxt = new System.Windows.Forms.TextBox();
            this.prenomTxt = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // motifTxt
            // 
            this.motifTxt.Location = new System.Drawing.Point(12, 328);
            this.motifTxt.Name = "motifTxt";
            this.motifTxt.Size = new System.Drawing.Size(200, 22);
            this.motifTxt.TabIndex = 1;
            // 
            // commentaireTxt
            // 
            this.commentaireTxt.Location = new System.Drawing.Point(307, 328);
            this.commentaireTxt.Multiline = true;
            this.commentaireTxt.Name = "commentaireTxt";
            this.commentaireTxt.Size = new System.Drawing.Size(320, 84);
            this.commentaireTxt.TabIndex = 2;
            // 
            // entreeTxt
            // 
            this.entreeTxt.Location = new System.Drawing.Point(12, 385);
            this.entreeTxt.Name = "entreeTxt";
            this.entreeTxt.Size = new System.Drawing.Size(200, 22);
            this.entreeTxt.TabIndex = 3;
            // 
            // sortieTxt
            // 
            this.sortieTxt.Location = new System.Drawing.Point(12, 442);
            this.sortieTxt.Name = "sortieTxt";
            this.sortieTxt.Size = new System.Drawing.Size(200, 22);
            this.sortieTxt.TabIndex = 4;
            // 
            // poulsTxt
            // 
            this.poulsTxt.Location = new System.Drawing.Point(12, 499);
            this.poulsTxt.Name = "poulsTxt";
            this.poulsTxt.Size = new System.Drawing.Size(200, 22);
            this.poulsTxt.TabIndex = 5;
            // 
            // hopitalCk
            // 
            this.hopitalCk.AutoSize = true;
            this.hopitalCk.Location = new System.Drawing.Point(307, 419);
            this.hopitalCk.Name = "hopitalCk";
            this.hopitalCk.Size = new System.Drawing.Size(74, 21);
            this.hopitalCk.TabIndex = 6;
            this.hopitalCk.Text = "Hopital";
            this.hopitalCk.UseVisualStyleBackColor = true;
            // 
            // prevenuCk
            // 
            this.prevenuCk.AutoSize = true;
            this.prevenuCk.Location = new System.Drawing.Point(307, 458);
            this.prevenuCk.Name = "prevenuCk";
            this.prevenuCk.Size = new System.Drawing.Size(128, 21);
            this.prevenuCk.TabIndex = 7;
            this.prevenuCk.Text = "Parent prevenu";
            this.prevenuCk.UseVisualStyleBackColor = true;
            // 
            // domicileCk
            // 
            this.domicileCk.AutoSize = true;
            this.domicileCk.Location = new System.Drawing.Point(307, 494);
            this.domicileCk.Name = "domicileCk";
            this.domicileCk.Size = new System.Drawing.Size(128, 21);
            this.domicileCk.TabIndex = 8;
            this.domicileCk.Text = "Retour domicile";
            this.domicileCk.UseVisualStyleBackColor = true;
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(12, 556);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(200, 22);
            this.dateTxt.TabIndex = 9;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(7, 296);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(77, 29);
            this.lblNom.TabIndex = 22;
            this.lblNom.Text = "Motif :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Commentaire :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 353);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Heure entré :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 524);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 410);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Heure sortie :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 467);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Pouls : ";
            // 
            // validerBtn
            // 
            this.validerBtn.Location = new System.Drawing.Point(397, 555);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.Size = new System.Drawing.Size(75, 23);
            this.validerBtn.TabIndex = 28;
            this.validerBtn.Text = "button1";
            this.validerBtn.UseVisualStyleBackColor = true;
            this.validerBtn.Click += new System.EventHandler(this.validerBtn_Click);
            // 
            // visiteID
            // 
            this.visiteID.Location = new System.Drawing.Point(827, 607);
            this.visiteID.Margin = new System.Windows.Forms.Padding(4);
            this.visiteID.Name = "visiteID";
            this.visiteID.Size = new System.Drawing.Size(132, 22);
            this.visiteID.TabIndex = 49;
            this.visiteID.Text = "visiteID";
            this.visiteID.Visible = false;
            // 
            // eleveId
            // 
            this.eleveId.Location = new System.Drawing.Point(826, 577);
            this.eleveId.Margin = new System.Windows.Forms.Padding(4);
            this.eleveId.Name = "eleveId";
            this.eleveId.Size = new System.Drawing.Size(132, 22);
            this.eleveId.TabIndex = 50;
            this.eleveId.Text = "ID eleve";
            this.eleveId.Visible = false;
            // 
            // nomTxt
            // 
            this.nomTxt.Location = new System.Drawing.Point(695, 319);
            this.nomTxt.Name = "nomTxt";
            this.nomTxt.Size = new System.Drawing.Size(200, 22);
            this.nomTxt.TabIndex = 51;
            // 
            // prenomTxt
            // 
            this.prenomTxt.Location = new System.Drawing.Point(695, 360);
            this.prenomTxt.Name = "prenomTxt";
            this.prenomTxt.Size = new System.Drawing.Size(200, 22);
            this.prenomTxt.TabIndex = 52;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 13);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(947, 233);
            this.dgv.TabIndex = 53;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.dateTimePicker1.Location = new System.Drawing.Point(439, 607);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(554, 502);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 55;
            // 
            // modifVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 642);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.prenomTxt);
            this.Controls.Add(this.nomTxt);
            this.Controls.Add(this.eleveId);
            this.Controls.Add(this.visiteID);
            this.Controls.Add(this.validerBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.domicileCk);
            this.Controls.Add(this.prevenuCk);
            this.Controls.Add(this.hopitalCk);
            this.Controls.Add(this.poulsTxt);
            this.Controls.Add(this.sortieTxt);
            this.Controls.Add(this.entreeTxt);
            this.Controls.Add(this.commentaireTxt);
            this.Controls.Add(this.motifTxt);
            this.Name = "modifVisite";
            this.Text = "modifVisite";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox motifTxt;
        private System.Windows.Forms.TextBox commentaireTxt;
        private System.Windows.Forms.TextBox entreeTxt;
        private System.Windows.Forms.TextBox sortieTxt;
        private System.Windows.Forms.TextBox poulsTxt;
        private System.Windows.Forms.CheckBox hopitalCk;
        private System.Windows.Forms.CheckBox prevenuCk;
        private System.Windows.Forms.CheckBox domicileCk;
        private System.Windows.Forms.DateTimePicker dateTxt;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button validerBtn;
        private System.Windows.Forms.TextBox visiteID;
        private System.Windows.Forms.TextBox eleveId;
        private System.Windows.Forms.TextBox nomTxt;
        private System.Windows.Forms.TextBox prenomTxt;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}