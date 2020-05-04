namespace SD_Gestion_Hopital
{
    partial class EcranModifPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranModifPatient));
            this.gbAffichePatModif = new System.Windows.Forms.GroupBox();
            this.btnAjouterPat = new System.Windows.Forms.Button();
            this.dgvPatModif = new System.Windows.Forms.DataGridView();
            this.gbModifPat = new System.Windows.Forms.GroupBox();
            this.lblFicheModifPatGSM = new System.Windows.Forms.Label();
            this.lblFicheModifPatAdresse = new System.Windows.Forms.Label();
            this.lblFicheModfPatPrenom = new System.Windows.Forms.Label();
            this.lblFicheModifPatNom = new System.Windows.Forms.Label();
            this.lblFicheModifPatdID = new System.Windows.Forms.Label();
            this.tbModifPatGSM = new System.Windows.Forms.TextBox();
            this.tbModifPatAdresse = new System.Windows.Forms.TextBox();
            this.tbModifPatPrenom = new System.Windows.Forms.TextBox();
            this.tbModifPatNom = new System.Windows.Forms.TextBox();
            this.tbModifPatID = new System.Windows.Forms.TextBox();
            this.btnAnnulerModifPat = new System.Windows.Forms.Button();
            this.btnConfirmerModifPat = new System.Windows.Forms.Button();
            this.gbAffichePatModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatModif)).BeginInit();
            this.gbModifPat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAffichePatModif
            // 
            this.gbAffichePatModif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbAffichePatModif.Controls.Add(this.btnAjouterPat);
            this.gbAffichePatModif.Controls.Add(this.dgvPatModif);
            this.gbAffichePatModif.Location = new System.Drawing.Point(395, 12);
            this.gbAffichePatModif.Name = "gbAffichePatModif";
            this.gbAffichePatModif.Size = new System.Drawing.Size(393, 378);
            this.gbAffichePatModif.TabIndex = 9;
            this.gbAffichePatModif.TabStop = false;
            this.gbAffichePatModif.Text = "Liste des Patients :";
            // 
            // btnAjouterPat
            // 
            this.btnAjouterPat.Location = new System.Drawing.Point(123, 330);
            this.btnAjouterPat.Name = "btnAjouterPat";
            this.btnAjouterPat.Size = new System.Drawing.Size(158, 42);
            this.btnAjouterPat.TabIndex = 6;
            this.btnAjouterPat.Text = "<----    A J O U T E R";
            this.btnAjouterPat.UseVisualStyleBackColor = true;
            this.btnAjouterPat.Click += new System.EventHandler(this.btnAjouterPat_Click);
            // 
            // dgvPatModif
            // 
            this.dgvPatModif.AllowUserToAddRows = false;
            this.dgvPatModif.AllowUserToDeleteRows = false;
            this.dgvPatModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatModif.Location = new System.Drawing.Point(6, 19);
            this.dgvPatModif.Name = "dgvPatModif";
            this.dgvPatModif.ReadOnly = true;
            this.dgvPatModif.Size = new System.Drawing.Size(381, 305);
            this.dgvPatModif.TabIndex = 0;
            // 
            // gbModifPat
            // 
            this.gbModifPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbModifPat.Controls.Add(this.lblFicheModifPatGSM);
            this.gbModifPat.Controls.Add(this.lblFicheModifPatAdresse);
            this.gbModifPat.Controls.Add(this.lblFicheModfPatPrenom);
            this.gbModifPat.Controls.Add(this.lblFicheModifPatNom);
            this.gbModifPat.Controls.Add(this.lblFicheModifPatdID);
            this.gbModifPat.Controls.Add(this.tbModifPatGSM);
            this.gbModifPat.Controls.Add(this.tbModifPatAdresse);
            this.gbModifPat.Controls.Add(this.tbModifPatPrenom);
            this.gbModifPat.Controls.Add(this.tbModifPatNom);
            this.gbModifPat.Controls.Add(this.tbModifPatID);
            this.gbModifPat.Location = new System.Drawing.Point(12, 12);
            this.gbModifPat.Name = "gbModifPat";
            this.gbModifPat.Size = new System.Drawing.Size(377, 378);
            this.gbModifPat.TabIndex = 8;
            this.gbModifPat.TabStop = false;
            this.gbModifPat.Text = "Fiche du patient :";
            // 
            // lblFicheModifPatGSM
            // 
            this.lblFicheModifPatGSM.AutoSize = true;
            this.lblFicheModifPatGSM.Location = new System.Drawing.Point(42, 311);
            this.lblFicheModifPatGSM.Name = "lblFicheModifPatGSM";
            this.lblFicheModifPatGSM.Size = new System.Drawing.Size(37, 13);
            this.lblFicheModifPatGSM.TabIndex = 9;
            this.lblFicheModifPatGSM.Text = "GSM :";
            // 
            // lblFicheModifPatAdresse
            // 
            this.lblFicheModifPatAdresse.AutoSize = true;
            this.lblFicheModifPatAdresse.Location = new System.Drawing.Point(42, 228);
            this.lblFicheModifPatAdresse.Name = "lblFicheModifPatAdresse";
            this.lblFicheModifPatAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblFicheModifPatAdresse.TabIndex = 8;
            this.lblFicheModifPatAdresse.Text = "Adresse :";
            // 
            // lblFicheModfPatPrenom
            // 
            this.lblFicheModfPatPrenom.AutoSize = true;
            this.lblFicheModfPatPrenom.Location = new System.Drawing.Point(42, 168);
            this.lblFicheModfPatPrenom.Name = "lblFicheModfPatPrenom";
            this.lblFicheModfPatPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblFicheModfPatPrenom.TabIndex = 7;
            this.lblFicheModfPatPrenom.Text = "Prénom :";
            // 
            // lblFicheModifPatNom
            // 
            this.lblFicheModifPatNom.AutoSize = true;
            this.lblFicheModifPatNom.Location = new System.Drawing.Point(42, 103);
            this.lblFicheModifPatNom.Name = "lblFicheModifPatNom";
            this.lblFicheModifPatNom.Size = new System.Drawing.Size(35, 13);
            this.lblFicheModifPatNom.TabIndex = 6;
            this.lblFicheModifPatNom.Text = "Nom :";
            // 
            // lblFicheModifPatdID
            // 
            this.lblFicheModifPatdID.AutoSize = true;
            this.lblFicheModifPatdID.Location = new System.Drawing.Point(42, 41);
            this.lblFicheModifPatdID.Name = "lblFicheModifPatdID";
            this.lblFicheModifPatdID.Size = new System.Drawing.Size(24, 13);
            this.lblFicheModifPatdID.TabIndex = 5;
            this.lblFicheModifPatdID.Text = "ID :";
            // 
            // tbModifPatGSM
            // 
            this.tbModifPatGSM.Location = new System.Drawing.Point(45, 330);
            this.tbModifPatGSM.Name = "tbModifPatGSM";
            this.tbModifPatGSM.Size = new System.Drawing.Size(130, 20);
            this.tbModifPatGSM.TabIndex = 4;
            // 
            // tbModifPatAdresse
            // 
            this.tbModifPatAdresse.Location = new System.Drawing.Point(45, 244);
            this.tbModifPatAdresse.Name = "tbModifPatAdresse";
            this.tbModifPatAdresse.Size = new System.Drawing.Size(282, 20);
            this.tbModifPatAdresse.TabIndex = 3;
            // 
            // tbModifPatPrenom
            // 
            this.tbModifPatPrenom.Location = new System.Drawing.Point(45, 184);
            this.tbModifPatPrenom.Name = "tbModifPatPrenom";
            this.tbModifPatPrenom.Size = new System.Drawing.Size(282, 20);
            this.tbModifPatPrenom.TabIndex = 2;
            // 
            // tbModifPatNom
            // 
            this.tbModifPatNom.Location = new System.Drawing.Point(45, 128);
            this.tbModifPatNom.Name = "tbModifPatNom";
            this.tbModifPatNom.Size = new System.Drawing.Size(282, 20);
            this.tbModifPatNom.TabIndex = 1;
            // 
            // tbModifPatID
            // 
            this.tbModifPatID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbModifPatID.Location = new System.Drawing.Point(45, 57);
            this.tbModifPatID.Name = "tbModifPatID";
            this.tbModifPatID.ReadOnly = true;
            this.tbModifPatID.Size = new System.Drawing.Size(100, 20);
            this.tbModifPatID.TabIndex = 0;
            // 
            // btnAnnulerModifPat
            // 
            this.btnAnnulerModifPat.Location = new System.Drawing.Point(231, 396);
            this.btnAnnulerModifPat.Name = "btnAnnulerModifPat";
            this.btnAnnulerModifPat.Size = new System.Drawing.Size(158, 42);
            this.btnAnnulerModifPat.TabIndex = 7;
            this.btnAnnulerModifPat.Text = "A N N U L E R";
            this.btnAnnulerModifPat.UseVisualStyleBackColor = true;
            this.btnAnnulerModifPat.Click += new System.EventHandler(this.btnAnnulerModifPat_Click);
            // 
            // btnConfirmerModifPat
            // 
            this.btnConfirmerModifPat.Location = new System.Drawing.Point(12, 396);
            this.btnConfirmerModifPat.Name = "btnConfirmerModifPat";
            this.btnConfirmerModifPat.Size = new System.Drawing.Size(158, 42);
            this.btnConfirmerModifPat.TabIndex = 6;
            this.btnConfirmerModifPat.Text = "C O N F I R M E R";
            this.btnConfirmerModifPat.UseVisualStyleBackColor = true;
            this.btnConfirmerModifPat.Click += new System.EventHandler(this.btnConfirmerModifPat_Click);
            // 
            // EcranModifPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbAffichePatModif);
            this.Controls.Add(this.gbModifPat);
            this.Controls.Add(this.btnAnnulerModifPat);
            this.Controls.Add(this.btnConfirmerModifPat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranModifPatient";
            this.Text = "Modification d\'un patient";
            this.Load += new System.EventHandler(this.EcranModifPatient_Load);
            this.gbAffichePatModif.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatModif)).EndInit();
            this.gbModifPat.ResumeLayout(false);
            this.gbModifPat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAffichePatModif;
        private System.Windows.Forms.Button btnAjouterPat;
        private System.Windows.Forms.DataGridView dgvPatModif;
        private System.Windows.Forms.GroupBox gbModifPat;
        private System.Windows.Forms.Label lblFicheModifPatGSM;
        private System.Windows.Forms.Label lblFicheModifPatAdresse;
        private System.Windows.Forms.Label lblFicheModfPatPrenom;
        private System.Windows.Forms.Label lblFicheModifPatNom;
        private System.Windows.Forms.Label lblFicheModifPatdID;
        private System.Windows.Forms.TextBox tbModifPatGSM;
        private System.Windows.Forms.TextBox tbModifPatAdresse;
        private System.Windows.Forms.TextBox tbModifPatPrenom;
        private System.Windows.Forms.TextBox tbModifPatNom;
        private System.Windows.Forms.TextBox tbModifPatID;
        private System.Windows.Forms.Button btnAnnulerModifPat;
        private System.Windows.Forms.Button btnConfirmerModifPat;
    }
}