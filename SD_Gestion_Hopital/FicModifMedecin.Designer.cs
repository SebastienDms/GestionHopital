namespace SD_Gestion_Hopital
{
    partial class EcranModifMedecin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranModifMedecin));
            this.gbModifAfficheMed = new System.Windows.Forms.GroupBox();
            this.btnModifierMed = new System.Windows.Forms.Button();
            this.dgvModifAfficheMed = new System.Windows.Forms.DataGridView();
            this.gbModifMed = new System.Windows.Forms.GroupBox();
            this.lblFicheModifMedSpe = new System.Windows.Forms.Label();
            this.lblFicheModifMedGSM = new System.Windows.Forms.Label();
            this.lblFicheModifMedPrenom = new System.Windows.Forms.Label();
            this.lblFicheModifMedNom = new System.Windows.Forms.Label();
            this.lblFicheModifMedID = new System.Windows.Forms.Label();
            this.tbModifMedIDSpe = new System.Windows.Forms.TextBox();
            this.tbModifMedGSM = new System.Windows.Forms.TextBox();
            this.tbModifMedPrenom = new System.Windows.Forms.TextBox();
            this.tbModifMedNom = new System.Windows.Forms.TextBox();
            this.tbModifIDMed = new System.Windows.Forms.TextBox();
            this.btnAnnulerModifMed = new System.Windows.Forms.Button();
            this.btnConfirmerModifMed = new System.Windows.Forms.Button();
            this.gbModifMedAfficheSpe = new System.Windows.Forms.GroupBox();
            this.btnModifMedSpe = new System.Windows.Forms.Button();
            this.dgvModifMedAfficheSpe = new System.Windows.Forms.DataGridView();
            this.gbModifAfficheMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifAfficheMed)).BeginInit();
            this.gbModifMed.SuspendLayout();
            this.gbModifMedAfficheSpe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifMedAfficheSpe)).BeginInit();
            this.SuspendLayout();
            // 
            // gbModifAfficheMed
            // 
            this.gbModifAfficheMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbModifAfficheMed.Controls.Add(this.btnModifierMed);
            this.gbModifAfficheMed.Controls.Add(this.dgvModifAfficheMed);
            this.gbModifAfficheMed.Location = new System.Drawing.Point(395, 12);
            this.gbModifAfficheMed.Name = "gbModifAfficheMed";
            this.gbModifAfficheMed.Size = new System.Drawing.Size(473, 378);
            this.gbModifAfficheMed.TabIndex = 9;
            this.gbModifAfficheMed.TabStop = false;
            this.gbModifAfficheMed.Text = "Liste des médecins :";
            // 
            // btnModifierMed
            // 
            this.btnModifierMed.Location = new System.Drawing.Point(160, 330);
            this.btnModifierMed.Name = "btnModifierMed";
            this.btnModifierMed.Size = new System.Drawing.Size(158, 42);
            this.btnModifierMed.TabIndex = 6;
            this.btnModifierMed.Text = "<----    M O D I F I E R";
            this.btnModifierMed.UseVisualStyleBackColor = true;
            this.btnModifierMed.Click += new System.EventHandler(this.btnModifierMed_Click);
            // 
            // dgvModifAfficheMed
            // 
            this.dgvModifAfficheMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifAfficheMed.Location = new System.Drawing.Point(6, 19);
            this.dgvModifAfficheMed.Name = "dgvModifAfficheMed";
            this.dgvModifAfficheMed.Size = new System.Drawing.Size(461, 305);
            this.dgvModifAfficheMed.TabIndex = 0;
            // 
            // gbModifMed
            // 
            this.gbModifMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbModifMed.Controls.Add(this.lblFicheModifMedSpe);
            this.gbModifMed.Controls.Add(this.lblFicheModifMedGSM);
            this.gbModifMed.Controls.Add(this.lblFicheModifMedPrenom);
            this.gbModifMed.Controls.Add(this.lblFicheModifMedNom);
            this.gbModifMed.Controls.Add(this.lblFicheModifMedID);
            this.gbModifMed.Controls.Add(this.tbModifMedIDSpe);
            this.gbModifMed.Controls.Add(this.tbModifMedGSM);
            this.gbModifMed.Controls.Add(this.tbModifMedPrenom);
            this.gbModifMed.Controls.Add(this.tbModifMedNom);
            this.gbModifMed.Controls.Add(this.tbModifIDMed);
            this.gbModifMed.Location = new System.Drawing.Point(12, 12);
            this.gbModifMed.Name = "gbModifMed";
            this.gbModifMed.Size = new System.Drawing.Size(377, 378);
            this.gbModifMed.TabIndex = 8;
            this.gbModifMed.TabStop = false;
            this.gbModifMed.Text = "Modification d\'un médecin :";
            // 
            // lblFicheModifMedSpe
            // 
            this.lblFicheModifMedSpe.AutoSize = true;
            this.lblFicheModifMedSpe.Location = new System.Drawing.Point(42, 292);
            this.lblFicheModifMedSpe.Name = "lblFicheModifMedSpe";
            this.lblFicheModifMedSpe.Size = new System.Drawing.Size(59, 13);
            this.lblFicheModifMedSpe.TabIndex = 9;
            this.lblFicheModifMedSpe.Text = "Spécialité :";
            // 
            // lblFicheModifMedGSM
            // 
            this.lblFicheModifMedGSM.AutoSize = true;
            this.lblFicheModifMedGSM.Location = new System.Drawing.Point(42, 228);
            this.lblFicheModifMedGSM.Name = "lblFicheModifMedGSM";
            this.lblFicheModifMedGSM.Size = new System.Drawing.Size(37, 13);
            this.lblFicheModifMedGSM.TabIndex = 8;
            this.lblFicheModifMedGSM.Text = "GSM :";
            // 
            // lblFicheModifMedPrenom
            // 
            this.lblFicheModifMedPrenom.AutoSize = true;
            this.lblFicheModifMedPrenom.Location = new System.Drawing.Point(42, 168);
            this.lblFicheModifMedPrenom.Name = "lblFicheModifMedPrenom";
            this.lblFicheModifMedPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblFicheModifMedPrenom.TabIndex = 7;
            this.lblFicheModifMedPrenom.Text = "Prénom :";
            // 
            // lblFicheModifMedNom
            // 
            this.lblFicheModifMedNom.AutoSize = true;
            this.lblFicheModifMedNom.Location = new System.Drawing.Point(42, 112);
            this.lblFicheModifMedNom.Name = "lblFicheModifMedNom";
            this.lblFicheModifMedNom.Size = new System.Drawing.Size(35, 13);
            this.lblFicheModifMedNom.TabIndex = 6;
            this.lblFicheModifMedNom.Text = "Nom :";
            // 
            // lblFicheModifMedID
            // 
            this.lblFicheModifMedID.AutoSize = true;
            this.lblFicheModifMedID.Location = new System.Drawing.Point(42, 41);
            this.lblFicheModifMedID.Name = "lblFicheModifMedID";
            this.lblFicheModifMedID.Size = new System.Drawing.Size(24, 13);
            this.lblFicheModifMedID.TabIndex = 5;
            this.lblFicheModifMedID.Text = "ID :";
            // 
            // tbModifMedIDSpe
            // 
            this.tbModifMedIDSpe.Location = new System.Drawing.Point(45, 308);
            this.tbModifMedIDSpe.Name = "tbModifMedIDSpe";
            this.tbModifMedIDSpe.ReadOnly = true;
            this.tbModifMedIDSpe.Size = new System.Drawing.Size(100, 20);
            this.tbModifMedIDSpe.TabIndex = 4;
            this.tbModifMedIDSpe.Click += new System.EventHandler(this.tbModifMedIDSpe_Click);
            // 
            // tbModifMedGSM
            // 
            this.tbModifMedGSM.Location = new System.Drawing.Point(45, 244);
            this.tbModifMedGSM.Name = "tbModifMedGSM";
            this.tbModifMedGSM.Size = new System.Drawing.Size(282, 20);
            this.tbModifMedGSM.TabIndex = 3;
            // 
            // tbModifMedPrenom
            // 
            this.tbModifMedPrenom.Location = new System.Drawing.Point(45, 184);
            this.tbModifMedPrenom.Name = "tbModifMedPrenom";
            this.tbModifMedPrenom.Size = new System.Drawing.Size(282, 20);
            this.tbModifMedPrenom.TabIndex = 2;
            // 
            // tbModifMedNom
            // 
            this.tbModifMedNom.Location = new System.Drawing.Point(45, 128);
            this.tbModifMedNom.Name = "tbModifMedNom";
            this.tbModifMedNom.Size = new System.Drawing.Size(282, 20);
            this.tbModifMedNom.TabIndex = 1;
            // 
            // tbModifIDMed
            // 
            this.tbModifIDMed.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbModifIDMed.Location = new System.Drawing.Point(45, 57);
            this.tbModifIDMed.Name = "tbModifIDMed";
            this.tbModifIDMed.ReadOnly = true;
            this.tbModifIDMed.Size = new System.Drawing.Size(100, 20);
            this.tbModifIDMed.TabIndex = 0;
            // 
            // btnAnnulerModifMed
            // 
            this.btnAnnulerModifMed.Location = new System.Drawing.Point(231, 396);
            this.btnAnnulerModifMed.Name = "btnAnnulerModifMed";
            this.btnAnnulerModifMed.Size = new System.Drawing.Size(158, 42);
            this.btnAnnulerModifMed.TabIndex = 7;
            this.btnAnnulerModifMed.Text = "A N N U L E R";
            this.btnAnnulerModifMed.UseVisualStyleBackColor = true;
            this.btnAnnulerModifMed.Click += new System.EventHandler(this.btnAnnulerModifMed_Click);
            // 
            // btnConfirmerModifMed
            // 
            this.btnConfirmerModifMed.Location = new System.Drawing.Point(12, 396);
            this.btnConfirmerModifMed.Name = "btnConfirmerModifMed";
            this.btnConfirmerModifMed.Size = new System.Drawing.Size(158, 42);
            this.btnConfirmerModifMed.TabIndex = 6;
            this.btnConfirmerModifMed.Text = "C O N F I R M E R";
            this.btnConfirmerModifMed.UseVisualStyleBackColor = true;
            this.btnConfirmerModifMed.Click += new System.EventHandler(this.btnConfirmerModifMed_Click);
            // 
            // gbModifMedAfficheSpe
            // 
            this.gbModifMedAfficheSpe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbModifMedAfficheSpe.Controls.Add(this.btnModifMedSpe);
            this.gbModifMedAfficheSpe.Controls.Add(this.dgvModifMedAfficheSpe);
            this.gbModifMedAfficheSpe.Location = new System.Drawing.Point(874, 12);
            this.gbModifMedAfficheSpe.Name = "gbModifMedAfficheSpe";
            this.gbModifMedAfficheSpe.Size = new System.Drawing.Size(313, 378);
            this.gbModifMedAfficheSpe.TabIndex = 10;
            this.gbModifMedAfficheSpe.TabStop = false;
            this.gbModifMedAfficheSpe.Text = "Liste des spécialités :";
            // 
            // btnModifMedSpe
            // 
            this.btnModifMedSpe.Location = new System.Drawing.Point(83, 330);
            this.btnModifMedSpe.Name = "btnModifMedSpe";
            this.btnModifMedSpe.Size = new System.Drawing.Size(158, 42);
            this.btnModifMedSpe.TabIndex = 6;
            this.btnModifMedSpe.Text = "<----    M O D I F I E R";
            this.btnModifMedSpe.UseVisualStyleBackColor = true;
            this.btnModifMedSpe.Click += new System.EventHandler(this.btnModifMedSpe_Click);
            // 
            // dgvModifMedAfficheSpe
            // 
            this.dgvModifMedAfficheSpe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifMedAfficheSpe.Location = new System.Drawing.Point(6, 19);
            this.dgvModifMedAfficheSpe.Name = "dgvModifMedAfficheSpe";
            this.dgvModifMedAfficheSpe.Size = new System.Drawing.Size(301, 305);
            this.dgvModifMedAfficheSpe.TabIndex = 0;
            // 
            // EcranModifMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 450);
            this.Controls.Add(this.gbModifMedAfficheSpe);
            this.Controls.Add(this.gbModifAfficheMed);
            this.Controls.Add(this.gbModifMed);
            this.Controls.Add(this.btnAnnulerModifMed);
            this.Controls.Add(this.btnConfirmerModifMed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranModifMedecin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modification d\'un médecin";
            this.Load += new System.EventHandler(this.EcranModifMedecin_Load);
            this.gbModifAfficheMed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifAfficheMed)).EndInit();
            this.gbModifMed.ResumeLayout(false);
            this.gbModifMed.PerformLayout();
            this.gbModifMedAfficheSpe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifMedAfficheSpe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbModifAfficheMed;
        private System.Windows.Forms.Button btnModifierMed;
        private System.Windows.Forms.DataGridView dgvModifAfficheMed;
        private System.Windows.Forms.GroupBox gbModifMed;
        private System.Windows.Forms.Label lblFicheModifMedSpe;
        private System.Windows.Forms.Label lblFicheModifMedGSM;
        private System.Windows.Forms.Label lblFicheModifMedPrenom;
        private System.Windows.Forms.Label lblFicheModifMedNom;
        private System.Windows.Forms.Label lblFicheModifMedID;
        private System.Windows.Forms.TextBox tbModifMedIDSpe;
        private System.Windows.Forms.TextBox tbModifMedGSM;
        private System.Windows.Forms.TextBox tbModifMedPrenom;
        private System.Windows.Forms.TextBox tbModifMedNom;
        private System.Windows.Forms.TextBox tbModifIDMed;
        private System.Windows.Forms.Button btnAnnulerModifMed;
        private System.Windows.Forms.Button btnConfirmerModifMed;
        private System.Windows.Forms.GroupBox gbModifMedAfficheSpe;
        private System.Windows.Forms.Button btnModifMedSpe;
        private System.Windows.Forms.DataGridView dgvModifMedAfficheSpe;
    }
}