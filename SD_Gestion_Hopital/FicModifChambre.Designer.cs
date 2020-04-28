namespace SD_Gestion_Hopital
{
    partial class EcranModifChambre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranModifChambre));
            this.gbAjMedSpe = new System.Windows.Forms.GroupBox();
            this.btnAjouterMedSpe = new System.Windows.Forms.Button();
            this.dgvSpecialites = new System.Windows.Forms.DataGridView();
            this.gbAjMed = new System.Windows.Forms.GroupBox();
            this.lblFicheAjMedSpe = new System.Windows.Forms.Label();
            this.lblFicheAjMedGSM = new System.Windows.Forms.Label();
            this.lblFicheAjMedPrenom = new System.Windows.Forms.Label();
            this.lblFicheAjMedNom = new System.Windows.Forms.Label();
            this.lblFicheAjMedID = new System.Windows.Forms.Label();
            this.tbMedIDSpe = new System.Windows.Forms.TextBox();
            this.tbMedGSM = new System.Windows.Forms.TextBox();
            this.tbMedPrenom = new System.Windows.Forms.TextBox();
            this.tbMedNom = new System.Windows.Forms.TextBox();
            this.tbIDMed = new System.Windows.Forms.TextBox();
            this.btnAnnulerAjMed = new System.Windows.Forms.Button();
            this.btnConfirmerAjMed = new System.Windows.Forms.Button();
            this.gbAjMedSpe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialites)).BeginInit();
            this.gbAjMed.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAjMedSpe
            // 
            this.gbAjMedSpe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbAjMedSpe.Controls.Add(this.btnAjouterMedSpe);
            this.gbAjMedSpe.Controls.Add(this.dgvSpecialites);
            this.gbAjMedSpe.Location = new System.Drawing.Point(395, 12);
            this.gbAjMedSpe.Name = "gbAjMedSpe";
            this.gbAjMedSpe.Size = new System.Drawing.Size(393, 378);
            this.gbAjMedSpe.TabIndex = 9;
            this.gbAjMedSpe.TabStop = false;
            this.gbAjMedSpe.Text = "Liste des spécialités";
            // 
            // btnAjouterMedSpe
            // 
            this.btnAjouterMedSpe.Location = new System.Drawing.Point(123, 330);
            this.btnAjouterMedSpe.Name = "btnAjouterMedSpe";
            this.btnAjouterMedSpe.Size = new System.Drawing.Size(158, 42);
            this.btnAjouterMedSpe.TabIndex = 6;
            this.btnAjouterMedSpe.Text = "<----    A J O U T E R";
            this.btnAjouterMedSpe.UseVisualStyleBackColor = true;
            // 
            // dgvSpecialites
            // 
            this.dgvSpecialites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecialites.Location = new System.Drawing.Point(6, 19);
            this.dgvSpecialites.Name = "dgvSpecialites";
            this.dgvSpecialites.Size = new System.Drawing.Size(381, 305);
            this.dgvSpecialites.TabIndex = 0;
            // 
            // gbAjMed
            // 
            this.gbAjMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbAjMed.Controls.Add(this.lblFicheAjMedSpe);
            this.gbAjMed.Controls.Add(this.lblFicheAjMedGSM);
            this.gbAjMed.Controls.Add(this.lblFicheAjMedPrenom);
            this.gbAjMed.Controls.Add(this.lblFicheAjMedNom);
            this.gbAjMed.Controls.Add(this.lblFicheAjMedID);
            this.gbAjMed.Controls.Add(this.tbMedIDSpe);
            this.gbAjMed.Controls.Add(this.tbMedGSM);
            this.gbAjMed.Controls.Add(this.tbMedPrenom);
            this.gbAjMed.Controls.Add(this.tbMedNom);
            this.gbAjMed.Controls.Add(this.tbIDMed);
            this.gbAjMed.Location = new System.Drawing.Point(12, 12);
            this.gbAjMed.Name = "gbAjMed";
            this.gbAjMed.Size = new System.Drawing.Size(377, 378);
            this.gbAjMed.TabIndex = 8;
            this.gbAjMed.TabStop = false;
            this.gbAjMed.Text = "Fiche du médecin";
            // 
            // lblFicheAjMedSpe
            // 
            this.lblFicheAjMedSpe.AutoSize = true;
            this.lblFicheAjMedSpe.Location = new System.Drawing.Point(42, 311);
            this.lblFicheAjMedSpe.Name = "lblFicheAjMedSpe";
            this.lblFicheAjMedSpe.Size = new System.Drawing.Size(59, 13);
            this.lblFicheAjMedSpe.TabIndex = 9;
            this.lblFicheAjMedSpe.Text = "Spécialité :";
            // 
            // lblFicheAjMedGSM
            // 
            this.lblFicheAjMedGSM.AutoSize = true;
            this.lblFicheAjMedGSM.Location = new System.Drawing.Point(42, 228);
            this.lblFicheAjMedGSM.Name = "lblFicheAjMedGSM";
            this.lblFicheAjMedGSM.Size = new System.Drawing.Size(37, 13);
            this.lblFicheAjMedGSM.TabIndex = 8;
            this.lblFicheAjMedGSM.Text = "GSM :";
            // 
            // lblFicheAjMedPrenom
            // 
            this.lblFicheAjMedPrenom.AutoSize = true;
            this.lblFicheAjMedPrenom.Location = new System.Drawing.Point(42, 168);
            this.lblFicheAjMedPrenom.Name = "lblFicheAjMedPrenom";
            this.lblFicheAjMedPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblFicheAjMedPrenom.TabIndex = 7;
            this.lblFicheAjMedPrenom.Text = "Prénom :";
            // 
            // lblFicheAjMedNom
            // 
            this.lblFicheAjMedNom.AutoSize = true;
            this.lblFicheAjMedNom.Location = new System.Drawing.Point(42, 103);
            this.lblFicheAjMedNom.Name = "lblFicheAjMedNom";
            this.lblFicheAjMedNom.Size = new System.Drawing.Size(35, 13);
            this.lblFicheAjMedNom.TabIndex = 6;
            this.lblFicheAjMedNom.Text = "Nom :";
            // 
            // lblFicheAjMedID
            // 
            this.lblFicheAjMedID.AutoSize = true;
            this.lblFicheAjMedID.Location = new System.Drawing.Point(42, 41);
            this.lblFicheAjMedID.Name = "lblFicheAjMedID";
            this.lblFicheAjMedID.Size = new System.Drawing.Size(24, 13);
            this.lblFicheAjMedID.TabIndex = 5;
            this.lblFicheAjMedID.Text = "ID :";
            // 
            // tbMedIDSpe
            // 
            this.tbMedIDSpe.Location = new System.Drawing.Point(45, 330);
            this.tbMedIDSpe.Name = "tbMedIDSpe";
            this.tbMedIDSpe.Size = new System.Drawing.Size(100, 20);
            this.tbMedIDSpe.TabIndex = 4;
            // 
            // tbMedGSM
            // 
            this.tbMedGSM.Location = new System.Drawing.Point(45, 244);
            this.tbMedGSM.Name = "tbMedGSM";
            this.tbMedGSM.Size = new System.Drawing.Size(282, 20);
            this.tbMedGSM.TabIndex = 3;
            // 
            // tbMedPrenom
            // 
            this.tbMedPrenom.Location = new System.Drawing.Point(45, 184);
            this.tbMedPrenom.Name = "tbMedPrenom";
            this.tbMedPrenom.Size = new System.Drawing.Size(282, 20);
            this.tbMedPrenom.TabIndex = 2;
            // 
            // tbMedNom
            // 
            this.tbMedNom.Location = new System.Drawing.Point(45, 128);
            this.tbMedNom.Name = "tbMedNom";
            this.tbMedNom.Size = new System.Drawing.Size(282, 20);
            this.tbMedNom.TabIndex = 1;
            // 
            // tbIDMed
            // 
            this.tbIDMed.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbIDMed.Location = new System.Drawing.Point(45, 57);
            this.tbIDMed.Name = "tbIDMed";
            this.tbIDMed.ReadOnly = true;
            this.tbIDMed.Size = new System.Drawing.Size(100, 20);
            this.tbIDMed.TabIndex = 0;
            // 
            // btnAnnulerAjMed
            // 
            this.btnAnnulerAjMed.Location = new System.Drawing.Point(231, 396);
            this.btnAnnulerAjMed.Name = "btnAnnulerAjMed";
            this.btnAnnulerAjMed.Size = new System.Drawing.Size(158, 42);
            this.btnAnnulerAjMed.TabIndex = 7;
            this.btnAnnulerAjMed.Text = "A N N U L E R";
            this.btnAnnulerAjMed.UseVisualStyleBackColor = true;
            // 
            // btnConfirmerAjMed
            // 
            this.btnConfirmerAjMed.Location = new System.Drawing.Point(12, 396);
            this.btnConfirmerAjMed.Name = "btnConfirmerAjMed";
            this.btnConfirmerAjMed.Size = new System.Drawing.Size(158, 42);
            this.btnConfirmerAjMed.TabIndex = 6;
            this.btnConfirmerAjMed.Text = "C O N F I R M E R";
            this.btnConfirmerAjMed.UseVisualStyleBackColor = true;
            // 
            // EcranModifChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbAjMedSpe);
            this.Controls.Add(this.gbAjMed);
            this.Controls.Add(this.btnAnnulerAjMed);
            this.Controls.Add(this.btnConfirmerAjMed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranModifChambre";
            this.Text = "Modification d\'une chambre";
            this.gbAjMedSpe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialites)).EndInit();
            this.gbAjMed.ResumeLayout(false);
            this.gbAjMed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAjMedSpe;
        private System.Windows.Forms.Button btnAjouterMedSpe;
        private System.Windows.Forms.DataGridView dgvSpecialites;
        private System.Windows.Forms.GroupBox gbAjMed;
        private System.Windows.Forms.Label lblFicheAjMedSpe;
        private System.Windows.Forms.Label lblFicheAjMedGSM;
        private System.Windows.Forms.Label lblFicheAjMedPrenom;
        private System.Windows.Forms.Label lblFicheAjMedNom;
        private System.Windows.Forms.Label lblFicheAjMedID;
        private System.Windows.Forms.TextBox tbMedIDSpe;
        private System.Windows.Forms.TextBox tbMedGSM;
        private System.Windows.Forms.TextBox tbMedPrenom;
        private System.Windows.Forms.TextBox tbMedNom;
        private System.Windows.Forms.TextBox tbIDMed;
        private System.Windows.Forms.Button btnAnnulerAjMed;
        private System.Windows.Forms.Button btnConfirmerAjMed;
    }
}