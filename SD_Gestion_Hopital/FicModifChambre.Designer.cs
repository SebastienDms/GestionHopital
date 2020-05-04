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
            this.gbAfficheChaModif = new System.Windows.Forms.GroupBox();
            this.btnModifCha = new System.Windows.Forms.Button();
            this.dgvChambresModif = new System.Windows.Forms.DataGridView();
            this.gbModifCha = new System.Windows.Forms.GroupBox();
            this.lblFicheModifChaService = new System.Windows.Forms.Label();
            this.lblFicheModifChaType = new System.Windows.Forms.Label();
            this.lblFicheModifChaNbrLit = new System.Windows.Forms.Label();
            this.lblFicheModifChaNom = new System.Windows.Forms.Label();
            this.lblFicheModifChaID = new System.Windows.Forms.Label();
            this.tbModifServiceCha = new System.Windows.Forms.TextBox();
            this.tbModifTypeCha = new System.Windows.Forms.TextBox();
            this.tbModifQuantiteLit = new System.Windows.Forms.TextBox();
            this.tbModifChaNom = new System.Windows.Forms.TextBox();
            this.tbIDCha = new System.Windows.Forms.TextBox();
            this.btnAnnulerModifCha = new System.Windows.Forms.Button();
            this.btnConfirmerModifCha = new System.Windows.Forms.Button();
            this.lblFicheModifChaEtage = new System.Windows.Forms.Label();
            this.tbModifEtageCha = new System.Windows.Forms.TextBox();
            this.gbAfficheChaModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambresModif)).BeginInit();
            this.gbModifCha.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAfficheChaModif
            // 
            this.gbAfficheChaModif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbAfficheChaModif.Controls.Add(this.btnModifCha);
            this.gbAfficheChaModif.Controls.Add(this.dgvChambresModif);
            this.gbAfficheChaModif.Location = new System.Drawing.Point(395, 12);
            this.gbAfficheChaModif.Name = "gbAfficheChaModif";
            this.gbAfficheChaModif.Size = new System.Drawing.Size(393, 378);
            this.gbAfficheChaModif.TabIndex = 9;
            this.gbAfficheChaModif.TabStop = false;
            this.gbAfficheChaModif.Text = "Liste des chambres :";
            // 
            // btnModifCha
            // 
            this.btnModifCha.Location = new System.Drawing.Point(113, 330);
            this.btnModifCha.Name = "btnModifCha";
            this.btnModifCha.Size = new System.Drawing.Size(158, 42);
            this.btnModifCha.TabIndex = 6;
            this.btnModifCha.Text = "<----    A J O U T E R";
            this.btnModifCha.UseVisualStyleBackColor = true;
            this.btnModifCha.Click += new System.EventHandler(this.btnModifCha_Click);
            // 
            // dgvChambresModif
            // 
            this.dgvChambresModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChambresModif.Location = new System.Drawing.Point(6, 19);
            this.dgvChambresModif.Name = "dgvChambresModif";
            this.dgvChambresModif.Size = new System.Drawing.Size(381, 305);
            this.dgvChambresModif.TabIndex = 0;
            // 
            // gbModifCha
            // 
            this.gbModifCha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbModifCha.Controls.Add(this.lblFicheModifChaEtage);
            this.gbModifCha.Controls.Add(this.tbModifEtageCha);
            this.gbModifCha.Controls.Add(this.lblFicheModifChaService);
            this.gbModifCha.Controls.Add(this.lblFicheModifChaType);
            this.gbModifCha.Controls.Add(this.lblFicheModifChaNbrLit);
            this.gbModifCha.Controls.Add(this.lblFicheModifChaNom);
            this.gbModifCha.Controls.Add(this.lblFicheModifChaID);
            this.gbModifCha.Controls.Add(this.tbModifServiceCha);
            this.gbModifCha.Controls.Add(this.tbModifTypeCha);
            this.gbModifCha.Controls.Add(this.tbModifQuantiteLit);
            this.gbModifCha.Controls.Add(this.tbModifChaNom);
            this.gbModifCha.Controls.Add(this.tbIDCha);
            this.gbModifCha.Location = new System.Drawing.Point(12, 12);
            this.gbModifCha.Name = "gbModifCha";
            this.gbModifCha.Size = new System.Drawing.Size(377, 378);
            this.gbModifCha.TabIndex = 8;
            this.gbModifCha.TabStop = false;
            this.gbModifCha.Text = "Fiche de la chambre :";
            // 
            // lblFicheModifChaService
            // 
            this.lblFicheModifChaService.AutoSize = true;
            this.lblFicheModifChaService.Location = new System.Drawing.Point(42, 312);
            this.lblFicheModifChaService.Name = "lblFicheModifChaService";
            this.lblFicheModifChaService.Size = new System.Drawing.Size(49, 13);
            this.lblFicheModifChaService.TabIndex = 9;
            this.lblFicheModifChaService.Text = "Service :";
            // 
            // lblFicheModifChaType
            // 
            this.lblFicheModifChaType.AutoSize = true;
            this.lblFicheModifChaType.Location = new System.Drawing.Point(42, 218);
            this.lblFicheModifChaType.Name = "lblFicheModifChaType";
            this.lblFicheModifChaType.Size = new System.Drawing.Size(37, 13);
            this.lblFicheModifChaType.TabIndex = 8;
            this.lblFicheModifChaType.Text = "Type :";
            // 
            // lblFicheModifChaNbrLit
            // 
            this.lblFicheModifChaNbrLit.AutoSize = true;
            this.lblFicheModifChaNbrLit.Location = new System.Drawing.Point(42, 168);
            this.lblFicheModifChaNbrLit.Name = "lblFicheModifChaNbrLit";
            this.lblFicheModifChaNbrLit.Size = new System.Drawing.Size(75, 13);
            this.lblFicheModifChaNbrLit.TabIndex = 7;
            this.lblFicheModifChaNbrLit.Text = "Nombre de lit :";
            // 
            // lblFicheModifChaNom
            // 
            this.lblFicheModifChaNom.AutoSize = true;
            this.lblFicheModifChaNom.Location = new System.Drawing.Point(42, 112);
            this.lblFicheModifChaNom.Name = "lblFicheModifChaNom";
            this.lblFicheModifChaNom.Size = new System.Drawing.Size(35, 13);
            this.lblFicheModifChaNom.TabIndex = 6;
            this.lblFicheModifChaNom.Text = "Nom :";
            // 
            // lblFicheModifChaID
            // 
            this.lblFicheModifChaID.AutoSize = true;
            this.lblFicheModifChaID.Location = new System.Drawing.Point(42, 41);
            this.lblFicheModifChaID.Name = "lblFicheModifChaID";
            this.lblFicheModifChaID.Size = new System.Drawing.Size(24, 13);
            this.lblFicheModifChaID.TabIndex = 5;
            this.lblFicheModifChaID.Text = "ID :";
            // 
            // tbModifServiceCha
            // 
            this.tbModifServiceCha.Location = new System.Drawing.Point(45, 331);
            this.tbModifServiceCha.Name = "tbModifServiceCha";
            this.tbModifServiceCha.Size = new System.Drawing.Size(135, 20);
            this.tbModifServiceCha.TabIndex = 4;
            // 
            // tbModifTypeCha
            // 
            this.tbModifTypeCha.Location = new System.Drawing.Point(45, 234);
            this.tbModifTypeCha.Name = "tbModifTypeCha";
            this.tbModifTypeCha.Size = new System.Drawing.Size(135, 20);
            this.tbModifTypeCha.TabIndex = 3;
            // 
            // tbModifQuantiteLit
            // 
            this.tbModifQuantiteLit.Location = new System.Drawing.Point(45, 184);
            this.tbModifQuantiteLit.Name = "tbModifQuantiteLit";
            this.tbModifQuantiteLit.Size = new System.Drawing.Size(135, 20);
            this.tbModifQuantiteLit.TabIndex = 2;
            // 
            // tbModifChaNom
            // 
            this.tbModifChaNom.Location = new System.Drawing.Point(45, 128);
            this.tbModifChaNom.Name = "tbModifChaNom";
            this.tbModifChaNom.Size = new System.Drawing.Size(135, 20);
            this.tbModifChaNom.TabIndex = 1;
            // 
            // tbIDCha
            // 
            this.tbIDCha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbIDCha.Location = new System.Drawing.Point(45, 57);
            this.tbIDCha.Name = "tbIDCha";
            this.tbIDCha.ReadOnly = true;
            this.tbIDCha.Size = new System.Drawing.Size(100, 20);
            this.tbIDCha.TabIndex = 0;
            // 
            // btnAnnulerModifCha
            // 
            this.btnAnnulerModifCha.Location = new System.Drawing.Point(231, 396);
            this.btnAnnulerModifCha.Name = "btnAnnulerModifCha";
            this.btnAnnulerModifCha.Size = new System.Drawing.Size(158, 42);
            this.btnAnnulerModifCha.TabIndex = 7;
            this.btnAnnulerModifCha.Text = "A N N U L E R";
            this.btnAnnulerModifCha.UseVisualStyleBackColor = true;
            this.btnAnnulerModifCha.Click += new System.EventHandler(this.btnAnnulerModifCha_Click);
            // 
            // btnConfirmerModifCha
            // 
            this.btnConfirmerModifCha.Location = new System.Drawing.Point(12, 396);
            this.btnConfirmerModifCha.Name = "btnConfirmerModifCha";
            this.btnConfirmerModifCha.Size = new System.Drawing.Size(158, 42);
            this.btnConfirmerModifCha.TabIndex = 6;
            this.btnConfirmerModifCha.Text = "C O N F I R M E R";
            this.btnConfirmerModifCha.UseVisualStyleBackColor = true;
            this.btnConfirmerModifCha.Click += new System.EventHandler(this.btnConfirmerModifCha_Click);
            // 
            // lblFicheModifChaEtage
            // 
            this.lblFicheModifChaEtage.AutoSize = true;
            this.lblFicheModifChaEtage.Location = new System.Drawing.Point(42, 267);
            this.lblFicheModifChaEtage.Name = "lblFicheModifChaEtage";
            this.lblFicheModifChaEtage.Size = new System.Drawing.Size(41, 13);
            this.lblFicheModifChaEtage.TabIndex = 11;
            this.lblFicheModifChaEtage.Text = "Etage :";
            // 
            // tbModifEtageCha
            // 
            this.tbModifEtageCha.Location = new System.Drawing.Point(45, 283);
            this.tbModifEtageCha.Name = "tbModifEtageCha";
            this.tbModifEtageCha.Size = new System.Drawing.Size(135, 20);
            this.tbModifEtageCha.TabIndex = 10;
            // 
            // EcranModifChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbAfficheChaModif);
            this.Controls.Add(this.gbModifCha);
            this.Controls.Add(this.btnAnnulerModifCha);
            this.Controls.Add(this.btnConfirmerModifCha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranModifChambre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modification d\'une chambre";
            this.Load += new System.EventHandler(this.EcranModifChambre_Load);
            this.gbAfficheChaModif.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambresModif)).EndInit();
            this.gbModifCha.ResumeLayout(false);
            this.gbModifCha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAfficheChaModif;
        private System.Windows.Forms.Button btnModifCha;
        private System.Windows.Forms.DataGridView dgvChambresModif;
        private System.Windows.Forms.GroupBox gbModifCha;
        private System.Windows.Forms.Label lblFicheModifChaService;
        private System.Windows.Forms.Label lblFicheModifChaType;
        private System.Windows.Forms.Label lblFicheModifChaNbrLit;
        private System.Windows.Forms.Label lblFicheModifChaNom;
        private System.Windows.Forms.Label lblFicheModifChaID;
        private System.Windows.Forms.TextBox tbModifServiceCha;
        private System.Windows.Forms.TextBox tbModifTypeCha;
        private System.Windows.Forms.TextBox tbModifQuantiteLit;
        private System.Windows.Forms.TextBox tbModifChaNom;
        private System.Windows.Forms.TextBox tbIDCha;
        private System.Windows.Forms.Button btnAnnulerModifCha;
        private System.Windows.Forms.Button btnConfirmerModifCha;
        private System.Windows.Forms.Label lblFicheModifChaEtage;
        private System.Windows.Forms.TextBox tbModifEtageCha;
    }
}