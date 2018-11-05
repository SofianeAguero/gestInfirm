namespace GUI
{
    partial class ajoutVisite
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.classeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_infirmerieDataSet1 = new GUI.gestion_infirmerieDataSet1();
            this.eleveBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_infirmerieDataSet = new GUI.gestion_infirmerieDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motifVisite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateVisite = new System.Windows.Forms.DateTimePicker();
            this.parentsVisite = new System.Windows.Forms.CheckBox();
            this.hopitalVisite = new System.Windows.Forms.CheckBox();
            this.domicileVisite = new System.Windows.Forms.CheckBox();
            this.btnApp = new System.Windows.Forms.Button();
            this.poulsVisite = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.eleveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heureArriveVisite = new System.Windows.Forms.TextBox();
            this.lblSante = new System.Windows.Forms.Label();
            this.fKvisiteIdeleveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTelEleve = new System.Windows.Forms.Label();
            this.eleveTableAdapter = new GUI.gestion_infirmerieDataSetTableAdapters.eleveTableAdapter();
            this.comVisite = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.errorDepart = new System.Windows.Forms.ErrorProvider(this.components);
            this.heureDepartVisite = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTelMere = new System.Windows.Forms.Label();
            this.errorArrivee = new System.Windows.Forms.ErrorProvider(this.components);
            this.classeTableAdapter = new GUI.gestion_infirmerieDataSet1TableAdapters.classeTableAdapter();
            this.lblTelPere = new System.Windows.Forms.Label();
            this.lblDateNaiss = new System.Windows.Forms.Label();
            this.errorMotif = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPrenom = new System.Windows.Forms.Label();
            this.gestion_infirmerieDataSet11 = new GUI.gestion_infirmerieDataSet1();
            this.visiteTableAdapter = new GUI.gestion_infirmerieDataSetTableAdapters.visiteTableAdapter();
            this.lblNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKvisiteIdeleveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArrivee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet11)).BeginInit();
            this.SuspendLayout();
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
            this.dgv.Location = new System.Drawing.Point(135, 10);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(656, 233);
            this.dgv.TabIndex = 125;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.classeBindingSource1, "Id_classe", true));
            this.comboBox2.DataSource = this.eleveBindingSource1;
            this.comboBox2.DisplayMember = "Nom_eleve";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(705, 353);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 124;
            this.comboBox2.ValueMember = "Id_eleve";
            // 
            // classeBindingSource1
            // 
            this.classeBindingSource1.DataMember = "classe";
            this.classeBindingSource1.DataSource = this.gestion_infirmerieDataSet1;
            // 
            // gestion_infirmerieDataSet1
            // 
            this.gestion_infirmerieDataSet1.DataSetName = "gestion_infirmerieDataSet1";
            this.gestion_infirmerieDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eleveBindingSource1
            // 
            this.eleveBindingSource1.DataMember = "eleve";
            this.eleveBindingSource1.DataSource = this.gestion_infirmerieDataSet;
            // 
            // gestion_infirmerieDataSet
            // 
            this.gestion_infirmerieDataSet.DataSetName = "gestion_infirmerieDataSet";
            this.gestion_infirmerieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.classeBindingSource, "Id_classe", true));
            this.comboBox1.DataSource = this.classeBindingSource1;
            this.comboBox1.DisplayMember = "Libelle_classe";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(705, 314);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 123;
            this.comboBox1.ValueMember = "Id_classe";
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataMember = "classe";
            this.classeBindingSource.DataSource = this.gestion_infirmerieDataSet1;
            // 
            // motifVisite
            // 
            this.motifVisite.Location = new System.Drawing.Point(135, 458);
            this.motifVisite.Margin = new System.Windows.Forms.Padding(4);
            this.motifVisite.Name = "motifVisite";
            this.motifVisite.Size = new System.Drawing.Size(197, 22);
            this.motifVisite.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 424);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 121;
            this.label1.Text = "Motif visite :";
            // 
            // dateVisite
            // 
            this.dateVisite.Location = new System.Drawing.Point(132, 400);
            this.dateVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateVisite.Name = "dateVisite";
            this.dateVisite.Size = new System.Drawing.Size(200, 22);
            this.dateVisite.TabIndex = 120;
            // 
            // parentsVisite
            // 
            this.parentsVisite.AutoSize = true;
            this.parentsVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentsVisite.Location = new System.Drawing.Point(473, 513);
            this.parentsVisite.Margin = new System.Windows.Forms.Padding(4);
            this.parentsVisite.Name = "parentsVisite";
            this.parentsVisite.Size = new System.Drawing.Size(222, 33);
            this.parentsVisite.TabIndex = 119;
            this.parentsVisite.Text = "Parents prévenus";
            this.parentsVisite.UseVisualStyleBackColor = true;
            // 
            // hopitalVisite
            // 
            this.hopitalVisite.AutoSize = true;
            this.hopitalVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopitalVisite.Location = new System.Drawing.Point(473, 472);
            this.hopitalVisite.Margin = new System.Windows.Forms.Padding(4);
            this.hopitalVisite.Name = "hopitalVisite";
            this.hopitalVisite.Size = new System.Drawing.Size(111, 33);
            this.hopitalVisite.TabIndex = 118;
            this.hopitalVisite.Text = "Hopital";
            this.hopitalVisite.UseVisualStyleBackColor = true;
            // 
            // domicileVisite
            // 
            this.domicileVisite.AutoSize = true;
            this.domicileVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domicileVisite.Location = new System.Drawing.Point(473, 432);
            this.domicileVisite.Margin = new System.Windows.Forms.Padding(4);
            this.domicileVisite.Name = "domicileVisite";
            this.domicileVisite.Size = new System.Drawing.Size(205, 33);
            this.domicileVisite.TabIndex = 117;
            this.domicileVisite.Text = "Retour domicile";
            this.domicileVisite.UseVisualStyleBackColor = true;
            // 
            // btnApp
            // 
            this.btnApp.Location = new System.Drawing.Point(337, 653);
            this.btnApp.Margin = new System.Windows.Forms.Padding(4);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(188, 59);
            this.btnApp.TabIndex = 116;
            this.btnApp.Text = "Ajouter une visite";
            this.btnApp.UseVisualStyleBackColor = true;
            // 
            // poulsVisite
            // 
            this.poulsVisite.Location = new System.Drawing.Point(473, 401);
            this.poulsVisite.Margin = new System.Windows.Forms.Padding(4);
            this.poulsVisite.Name = "poulsVisite";
            this.poulsVisite.Size = new System.Drawing.Size(197, 22);
            this.poulsVisite.TabIndex = 115;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(133, 672);
            this.textId.Margin = new System.Windows.Forms.Padding(4);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(132, 22);
            this.textId.TabIndex = 114;
            this.textId.Text = "ID eleve";
            this.textId.Visible = false;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(132, 280);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(197, 22);
            this.txtNom.TabIndex = 113;
            // 
            // eleveBindingSource
            // 
            this.eleveBindingSource.DataMember = "eleve";
            this.eleveBindingSource.DataSource = this.gestion_infirmerieDataSet;
            // 
            // heureArriveVisite
            // 
            this.heureArriveVisite.Location = new System.Drawing.Point(473, 283);
            this.heureArriveVisite.Margin = new System.Windows.Forms.Padding(4);
            this.heureArriveVisite.Name = "heureArriveVisite";
            this.heureArriveVisite.Size = new System.Drawing.Size(197, 22);
            this.heureArriveVisite.TabIndex = 109;
            // 
            // lblSante
            // 
            this.lblSante.AutoSize = true;
            this.lblSante.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSante.Location = new System.Drawing.Point(127, 523);
            this.lblSante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSante.Name = "lblSante";
            this.lblSante.Size = new System.Drawing.Size(176, 29);
            this.lblSante.TabIndex = 108;
            this.lblSante.Text = "Commentaire  :";
            // 
            // fKvisiteIdeleveBindingSource
            // 
            this.fKvisiteIdeleveBindingSource.DataMember = "FK_visite_Id_eleve";
            this.fKvisiteIdeleveBindingSource.DataSource = this.eleveBindingSource;
            // 
            // lblTelEleve
            // 
            this.lblTelEleve.AutoSize = true;
            this.lblTelEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelEleve.Location = new System.Drawing.Point(468, 247);
            this.lblTelEleve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelEleve.Name = "lblTelEleve";
            this.lblTelEleve.Size = new System.Drawing.Size(189, 29);
            this.lblTelEleve.TabIndex = 107;
            this.lblTelEleve.Text = "Heure d\'arrivée :";
            // 
            // eleveTableAdapter
            // 
            this.eleveTableAdapter.ClearBeforeFill = true;
            // 
            // comVisite
            // 
            this.comVisite.Location = new System.Drawing.Point(132, 556);
            this.comVisite.Margin = new System.Windows.Forms.Padding(4);
            this.comVisite.Multiline = true;
            this.comVisite.Name = "comVisite";
            this.comVisite.Size = new System.Drawing.Size(639, 73);
            this.comVisite.TabIndex = 111;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(132, 342);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(197, 22);
            this.txtPrenom.TabIndex = 112;
            // 
            // errorDepart
            // 
            this.errorDepart.ContainerControl = this;
            // 
            // heureDepartVisite
            // 
            this.heureDepartVisite.Location = new System.Drawing.Point(473, 342);
            this.heureDepartVisite.Margin = new System.Windows.Forms.Padding(4);
            this.heureDepartVisite.Name = "heureDepartVisite";
            this.heureDepartVisite.Size = new System.Drawing.Size(197, 22);
            this.heureDepartVisite.TabIndex = 110;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(544, 535);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 17);
            this.label11.TabIndex = 106;
            // 
            // lblTelMere
            // 
            this.lblTelMere.AutoSize = true;
            this.lblTelMere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelMere.Location = new System.Drawing.Point(468, 368);
            this.lblTelMere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelMere.Name = "lblTelMere";
            this.lblTelMere.Size = new System.Drawing.Size(86, 29);
            this.lblTelMere.TabIndex = 105;
            this.lblTelMere.Text = "Pouls :";
            // 
            // errorArrivee
            // 
            this.errorArrivee.ContainerControl = this;
            // 
            // classeTableAdapter
            // 
            this.classeTableAdapter.ClearBeforeFill = true;
            // 
            // lblTelPere
            // 
            this.lblTelPere.AutoSize = true;
            this.lblTelPere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelPere.Location = new System.Drawing.Point(468, 309);
            this.lblTelPere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelPere.Name = "lblTelPere";
            this.lblTelPere.Size = new System.Drawing.Size(200, 29);
            this.lblTelPere.TabIndex = 104;
            this.lblTelPere.Text = "Heure de départ :";
            // 
            // lblDateNaiss
            // 
            this.lblDateNaiss.AutoSize = true;
            this.lblDateNaiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNaiss.Location = new System.Drawing.Point(127, 368);
            this.lblDateNaiss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateNaiss.Name = "lblDateNaiss";
            this.lblDateNaiss.Size = new System.Drawing.Size(170, 29);
            this.lblDateNaiss.TabIndex = 103;
            this.lblDateNaiss.Text = "Date de visite :";
            // 
            // errorMotif
            // 
            this.errorMotif.ContainerControl = this;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(127, 309);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(110, 29);
            this.lblPrenom.TabIndex = 102;
            this.lblPrenom.Text = "Prénom :";
            // 
            // gestion_infirmerieDataSet11
            // 
            this.gestion_infirmerieDataSet11.DataSetName = "gestion_infirmerieDataSet1";
            this.gestion_infirmerieDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visiteTableAdapter
            // 
            this.visiteTableAdapter.ClearBeforeFill = true;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(127, 247);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(77, 29);
            this.lblNom.TabIndex = 101;
            this.lblNom.Text = "Nom :";
            // 
            // ajoutVisites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 723);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.motifVisite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateVisite);
            this.Controls.Add(this.parentsVisite);
            this.Controls.Add(this.hopitalVisite);
            this.Controls.Add(this.domicileVisite);
            this.Controls.Add(this.btnApp);
            this.Controls.Add(this.poulsVisite);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.heureArriveVisite);
            this.Controls.Add(this.lblSante);
            this.Controls.Add(this.lblTelEleve);
            this.Controls.Add(this.comVisite);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.heureDepartVisite);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTelMere);
            this.Controls.Add(this.lblTelPere);
            this.Controls.Add(this.lblDateNaiss);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Name = "ajoutVisites";
            this.Text = "ajoutVisites";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKvisiteIdeleveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArrivee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource classeBindingSource1;
        private gestion_infirmerieDataSet1 gestion_infirmerieDataSet1;
        private System.Windows.Forms.BindingSource eleveBindingSource1;
        private gestion_infirmerieDataSet gestion_infirmerieDataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private System.Windows.Forms.TextBox motifVisite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateVisite;
        private System.Windows.Forms.CheckBox parentsVisite;
        private System.Windows.Forms.CheckBox hopitalVisite;
        private System.Windows.Forms.CheckBox domicileVisite;
        private System.Windows.Forms.Button btnApp;
        private System.Windows.Forms.TextBox poulsVisite;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.BindingSource eleveBindingSource;
        private System.Windows.Forms.TextBox heureArriveVisite;
        private System.Windows.Forms.Label lblSante;
        private System.Windows.Forms.BindingSource fKvisiteIdeleveBindingSource;
        private System.Windows.Forms.Label lblTelEleve;
        private gestion_infirmerieDataSetTableAdapters.eleveTableAdapter eleveTableAdapter;
        private System.Windows.Forms.TextBox comVisite;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.ErrorProvider errorDepart;
        private System.Windows.Forms.TextBox heureDepartVisite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTelMere;
        private System.Windows.Forms.Label lblTelPere;
        private System.Windows.Forms.Label lblDateNaiss;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ErrorProvider errorArrivee;
        private gestion_infirmerieDataSet1TableAdapters.classeTableAdapter classeTableAdapter;
        private System.Windows.Forms.ErrorProvider errorMotif;
        private gestion_infirmerieDataSet1 gestion_infirmerieDataSet11;
        private gestion_infirmerieDataSetTableAdapters.visiteTableAdapter visiteTableAdapter;
    }
}