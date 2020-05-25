namespace SD_Gestion_Hopital
{
    partial class EcranModifSpecialite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranModifSpecialite));
            this.gbModifAfficheSpe = new System.Windows.Forms.GroupBox();
            this.btnModifSpeSelection = new System.Windows.Forms.Button();
            this.dgvModifSpecialites = new System.Windows.Forms.DataGridView();
            this.gbModifSpe = new System.Windows.Forms.GroupBox();
            this.lblFicheModifSpeNom = new System.Windows.Forms.Label();
            this.lblFicheModifSpeID = new System.Windows.Forms.Label();
            this.tbModifNomSpe = new System.Windows.Forms.TextBox();
            this.tbIDSpe = new System.Windows.Forms.TextBox();
            this.btnAnnulerModifSpe = new System.Windows.Forms.Button();
            this.btnConfirmerModifSpe = new System.Windows.Forms.Button();
            this.gbModifAfficheSpe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifSpecialites)).BeginInit();
            this.gbModifSpe.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbModifAfficheSpe
            // 
            this.gbModifAfficheSpe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbModifAfficheSpe.Controls.Add(this.btnModifSpeSelection);
            this.gbModifAfficheSpe.Controls.Add(this.dgvModifSpecialites);
            this.gbModifAfficheSpe.Location = new System.Drawing.Point(395, 12);
            this.gbModifAfficheSpe.Name = "gbModifAfficheSpe";
            this.gbModifAfficheSpe.Size = new System.Drawing.Size(393, 378);
            this.gbModifAfficheSpe.TabIndex = 9;
            this.gbModifAfficheSpe.TabStop = false;
            this.gbModifAfficheSpe.Text = "Liste des spécialités :";
            // 
            // btnModifSpeSelection
            // 
            this.btnModifSpeSelection.Location = new System.Drawing.Point(134, 330);
            this.btnModifSpeSelection.Name = "btnModifSpeSelection";
            this.btnModifSpeSelection.Size = new System.Drawing.Size(144, 42);
            this.btnModifSpeSelection.TabIndex = 6;
            this.btnModifSpeSelection.Text = "<----    M O D I F I E R";
            this.btnModifSpeSelection.UseVisualStyleBackColor = true;
            this.btnModifSpeSelection.Click += new System.EventHandler(this.btnModifSpeSelection_Click);
            // 
            // dgvModifSpecialites
            // 
            this.dgvModifSpecialites.AllowUserToAddRows = false;
            this.dgvModifSpecialites.AllowUserToDeleteRows = false;
            this.dgvModifSpecialites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifSpecialites.Location = new System.Drawing.Point(6, 19);
            this.dgvModifSpecialites.Name = "dgvModifSpecialites";
            this.dgvModifSpecialites.ReadOnly = true;
            this.dgvModifSpecialites.Size = new System.Drawing.Size(381, 305);
            this.dgvModifSpecialites.TabIndex = 0;
            // 
            // gbModifSpe
            // 
            this.gbModifSpe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbModifSpe.Controls.Add(this.lblFicheModifSpeNom);
            this.gbModifSpe.Controls.Add(this.lblFicheModifSpeID);
            this.gbModifSpe.Controls.Add(this.tbModifNomSpe);
            this.gbModifSpe.Controls.Add(this.tbIDSpe);
            this.gbModifSpe.Location = new System.Drawing.Point(12, 12);
            this.gbModifSpe.Name = "gbModifSpe";
            this.gbModifSpe.Size = new System.Drawing.Size(377, 324);
            this.gbModifSpe.TabIndex = 8;
            this.gbModifSpe.TabStop = false;
            this.gbModifSpe.Text = "Modification de la spécialité :";
            // 
            // lblFicheModifSpeNom
            // 
            this.lblFicheModifSpeNom.AutoSize = true;
            this.lblFicheModifSpeNom.Location = new System.Drawing.Point(41, 171);
            this.lblFicheModifSpeNom.Name = "lblFicheModifSpeNom";
            this.lblFicheModifSpeNom.Size = new System.Drawing.Size(35, 13);
            this.lblFicheModifSpeNom.TabIndex = 6;
            this.lblFicheModifSpeNom.Text = "Nom :";
            // 
            // lblFicheModifSpeID
            // 
            this.lblFicheModifSpeID.AutoSize = true;
            this.lblFicheModifSpeID.Location = new System.Drawing.Point(41, 100);
            this.lblFicheModifSpeID.Name = "lblFicheModifSpeID";
            this.lblFicheModifSpeID.Size = new System.Drawing.Size(24, 13);
            this.lblFicheModifSpeID.TabIndex = 5;
            this.lblFicheModifSpeID.Text = "ID :";
            // 
            // tbModifNomSpe
            // 
            this.tbModifNomSpe.Location = new System.Drawing.Point(44, 187);
            this.tbModifNomSpe.Name = "tbModifNomSpe";
            this.tbModifNomSpe.Size = new System.Drawing.Size(282, 20);
            this.tbModifNomSpe.TabIndex = 1;
            // 
            // tbIDSpe
            // 
            this.tbIDSpe.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbIDSpe.Location = new System.Drawing.Point(44, 116);
            this.tbIDSpe.Name = "tbIDSpe";
            this.tbIDSpe.ReadOnly = true;
            this.tbIDSpe.Size = new System.Drawing.Size(100, 20);
            this.tbIDSpe.TabIndex = 0;
            // 
            // btnAnnulerModifSpe
            // 
            this.btnAnnulerModifSpe.Location = new System.Drawing.Point(231, 348);
            this.btnAnnulerModifSpe.Name = "btnAnnulerModifSpe";
            this.btnAnnulerModifSpe.Size = new System.Drawing.Size(158, 42);
            this.btnAnnulerModifSpe.TabIndex = 7;
            this.btnAnnulerModifSpe.Text = "A N N U L E R";
            this.btnAnnulerModifSpe.UseVisualStyleBackColor = true;
            this.btnAnnulerModifSpe.Click += new System.EventHandler(this.btnAnnulerModifSpe_Click);
            // 
            // btnConfirmerModifSpe
            // 
            this.btnConfirmerModifSpe.Location = new System.Drawing.Point(12, 348);
            this.btnConfirmerModifSpe.Name = "btnConfirmerModifSpe";
            this.btnConfirmerModifSpe.Size = new System.Drawing.Size(158, 42);
            this.btnConfirmerModifSpe.TabIndex = 6;
            this.btnConfirmerModifSpe.Text = "C O N F I R M E R";
            this.btnConfirmerModifSpe.UseVisualStyleBackColor = true;
            this.btnConfirmerModifSpe.Click += new System.EventHandler(this.btnConfirmerModifSpe_Click);
            // 
            // EcranModifSpecialite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.gbModifAfficheSpe);
            this.Controls.Add(this.gbModifSpe);
            this.Controls.Add(this.btnAnnulerModifSpe);
            this.Controls.Add(this.btnConfirmerModifSpe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranModifSpecialite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modification d\'une spécialité";
            this.Load += new System.EventHandler(this.EcranModifSpecialite_Load);
            this.gbModifAfficheSpe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifSpecialites)).EndInit();
            this.gbModifSpe.ResumeLayout(false);
            this.gbModifSpe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbModifAfficheSpe;
        private System.Windows.Forms.Button btnModifSpeSelection;
        private System.Windows.Forms.DataGridView dgvModifSpecialites;
        private System.Windows.Forms.GroupBox gbModifSpe;
        private System.Windows.Forms.Label lblFicheModifSpeNom;
        private System.Windows.Forms.Label lblFicheModifSpeID;
        private System.Windows.Forms.TextBox tbModifNomSpe;
        private System.Windows.Forms.TextBox tbIDSpe;
        private System.Windows.Forms.Button btnAnnulerModifSpe;
        private System.Windows.Forms.Button btnConfirmerModifSpe;
    }
}