namespace SD_Gestion_Hopital
{
    partial class EcranSuppriSpecialite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranSuppriSpecialite));
            this.gbRechercheSupSpe = new System.Windows.Forms.GroupBox();
            this.btnChercherSpe = new System.Windows.Forms.Button();
            this.lblResultatRechercheSpe = new System.Windows.Forms.Label();
            this.lblNomSpeSup = new System.Windows.Forms.Label();
            this.lblIDSpeSup = new System.Windows.Forms.Label();
            this.lblNomSpeRech = new System.Windows.Forms.Label();
            this.tblNomSpeSup = new System.Windows.Forms.TextBox();
            this.tblIDSpeSup = new System.Windows.Forms.TextBox();
            this.tblNomSpeRech = new System.Windows.Forms.TextBox();
            this.gbSelectSupSpe = new System.Windows.Forms.GroupBox();
            this.btnAfficherListeSpe = new System.Windows.Forms.Button();
            this.dgvSpeSup = new System.Windows.Forms.DataGridView();
            this.btnConfirmerSupSpe = new System.Windows.Forms.Button();
            this.btnAnnulerSupSpe = new System.Windows.Forms.Button();
            this.gbRechercheSupSpe.SuspendLayout();
            this.gbSelectSupSpe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeSup)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRechercheSupSpe
            // 
            this.gbRechercheSupSpe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbRechercheSupSpe.Controls.Add(this.btnChercherSpe);
            this.gbRechercheSupSpe.Controls.Add(this.lblResultatRechercheSpe);
            this.gbRechercheSupSpe.Controls.Add(this.lblNomSpeSup);
            this.gbRechercheSupSpe.Controls.Add(this.lblIDSpeSup);
            this.gbRechercheSupSpe.Controls.Add(this.lblNomSpeRech);
            this.gbRechercheSupSpe.Controls.Add(this.tblNomSpeSup);
            this.gbRechercheSupSpe.Controls.Add(this.tblIDSpeSup);
            this.gbRechercheSupSpe.Controls.Add(this.tblNomSpeRech);
            this.gbRechercheSupSpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRechercheSupSpe.Location = new System.Drawing.Point(12, 12);
            this.gbRechercheSupSpe.Name = "gbRechercheSupSpe";
            this.gbRechercheSupSpe.Size = new System.Drawing.Size(776, 180);
            this.gbRechercheSupSpe.TabIndex = 0;
            this.gbRechercheSupSpe.TabStop = false;
            this.gbRechercheSupSpe.Text = "Recherche :";
            // 
            // btnChercherSpe
            // 
            this.btnChercherSpe.Location = new System.Drawing.Point(331, 43);
            this.btnChercherSpe.Name = "btnChercherSpe";
            this.btnChercherSpe.Size = new System.Drawing.Size(126, 25);
            this.btnChercherSpe.TabIndex = 7;
            this.btnChercherSpe.Text = "C H E R C H E R";
            this.btnChercherSpe.UseVisualStyleBackColor = true;
            this.btnChercherSpe.Click += new System.EventHandler(this.btnChercherSpe_Click);
            // 
            // lblResultatRechercheSpe
            // 
            this.lblResultatRechercheSpe.AutoSize = true;
            this.lblResultatRechercheSpe.Location = new System.Drawing.Point(15, 82);
            this.lblResultatRechercheSpe.Name = "lblResultatRechercheSpe";
            this.lblResultatRechercheSpe.Size = new System.Drawing.Size(68, 17);
            this.lblResultatRechercheSpe.TabIndex = 6;
            this.lblResultatRechercheSpe.Text = "Résultat :";
            // 
            // lblNomSpeSup
            // 
            this.lblNomSpeSup.AutoSize = true;
            this.lblNomSpeSup.Location = new System.Drawing.Point(328, 108);
            this.lblNomSpeSup.Name = "lblNomSpeSup";
            this.lblNomSpeSup.Size = new System.Drawing.Size(45, 17);
            this.lblNomSpeSup.TabIndex = 5;
            this.lblNomSpeSup.Text = "Nom :";
            // 
            // lblIDSpeSup
            // 
            this.lblIDSpeSup.AutoSize = true;
            this.lblIDSpeSup.Location = new System.Drawing.Point(92, 108);
            this.lblIDSpeSup.Name = "lblIDSpeSup";
            this.lblIDSpeSup.Size = new System.Drawing.Size(29, 17);
            this.lblIDSpeSup.TabIndex = 4;
            this.lblIDSpeSup.Text = "ID :";
            // 
            // lblNomSpeRech
            // 
            this.lblNomSpeRech.AutoSize = true;
            this.lblNomSpeRech.Location = new System.Drawing.Point(92, 23);
            this.lblNomSpeRech.Name = "lblNomSpeRech";
            this.lblNomSpeRech.Size = new System.Drawing.Size(45, 17);
            this.lblNomSpeRech.TabIndex = 3;
            this.lblNomSpeRech.Text = "Nom :";
            // 
            // tblNomSpeSup
            // 
            this.tblNomSpeSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tblNomSpeSup.Location = new System.Drawing.Point(331, 128);
            this.tblNomSpeSup.Name = "tblNomSpeSup";
            this.tblNomSpeSup.ReadOnly = true;
            this.tblNomSpeSup.Size = new System.Drawing.Size(185, 23);
            this.tblNomSpeSup.TabIndex = 2;
            // 
            // tblIDSpeSup
            // 
            this.tblIDSpeSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tblIDSpeSup.Location = new System.Drawing.Point(95, 128);
            this.tblIDSpeSup.Name = "tblIDSpeSup";
            this.tblIDSpeSup.ReadOnly = true;
            this.tblIDSpeSup.Size = new System.Drawing.Size(139, 23);
            this.tblIDSpeSup.TabIndex = 1;
            // 
            // tblNomSpeRech
            // 
            this.tblNomSpeRech.Location = new System.Drawing.Point(95, 43);
            this.tblNomSpeRech.Name = "tblNomSpeRech";
            this.tblNomSpeRech.Size = new System.Drawing.Size(139, 23);
            this.tblNomSpeRech.TabIndex = 0;
            this.tblNomSpeRech.Click += new System.EventHandler(this.tblNomSpeRech_Click);
            // 
            // gbSelectSupSpe
            // 
            this.gbSelectSupSpe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbSelectSupSpe.Controls.Add(this.btnAfficherListeSpe);
            this.gbSelectSupSpe.Controls.Add(this.dgvSpeSup);
            this.gbSelectSupSpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelectSupSpe.Location = new System.Drawing.Point(12, 198);
            this.gbSelectSupSpe.Name = "gbSelectSupSpe";
            this.gbSelectSupSpe.Size = new System.Drawing.Size(776, 270);
            this.gbSelectSupSpe.TabIndex = 1;
            this.gbSelectSupSpe.TabStop = false;
            this.gbSelectSupSpe.Text = "Sélectionner :";
            // 
            // btnAfficherListeSpe
            // 
            this.btnAfficherListeSpe.Location = new System.Drawing.Point(6, 45);
            this.btnAfficherListeSpe.Name = "btnAfficherListeSpe";
            this.btnAfficherListeSpe.Size = new System.Drawing.Size(83, 60);
            this.btnAfficherListeSpe.TabIndex = 1;
            this.btnAfficherListeSpe.Text = "AFFICHER LA LISTE";
            this.btnAfficherListeSpe.UseVisualStyleBackColor = true;
            this.btnAfficherListeSpe.Click += new System.EventHandler(this.btnAfficherListeSpe_Click);
            // 
            // dgvSpeSup
            // 
            this.dgvSpeSup.AllowUserToAddRows = false;
            this.dgvSpeSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpeSup.Location = new System.Drawing.Point(95, 45);
            this.dgvSpeSup.Name = "dgvSpeSup";
            this.dgvSpeSup.ReadOnly = true;
            this.dgvSpeSup.Size = new System.Drawing.Size(362, 191);
            this.dgvSpeSup.TabIndex = 0;
            // 
            // btnConfirmerSupSpe
            // 
            this.btnConfirmerSupSpe.Location = new System.Drawing.Point(180, 492);
            this.btnConfirmerSupSpe.Name = "btnConfirmerSupSpe";
            this.btnConfirmerSupSpe.Size = new System.Drawing.Size(150, 50);
            this.btnConfirmerSupSpe.TabIndex = 2;
            this.btnConfirmerSupSpe.Text = "S U P P R I M E R";
            this.btnConfirmerSupSpe.UseVisualStyleBackColor = true;
            this.btnConfirmerSupSpe.Click += new System.EventHandler(this.btnConfirmerSupSpe_Click);
            // 
            // btnAnnulerSupSpe
            // 
            this.btnAnnulerSupSpe.Location = new System.Drawing.Point(469, 492);
            this.btnAnnulerSupSpe.Name = "btnAnnulerSupSpe";
            this.btnAnnulerSupSpe.Size = new System.Drawing.Size(150, 50);
            this.btnAnnulerSupSpe.TabIndex = 3;
            this.btnAnnulerSupSpe.Text = "A N N U L E R";
            this.btnAnnulerSupSpe.UseVisualStyleBackColor = true;
            this.btnAnnulerSupSpe.Click += new System.EventHandler(this.btnAnnulerSupSpe_Click);
            // 
            // EcranSuppriSpecialite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.btnAnnulerSupSpe);
            this.Controls.Add(this.btnConfirmerSupSpe);
            this.Controls.Add(this.gbSelectSupSpe);
            this.Controls.Add(this.gbRechercheSupSpe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranSuppriSpecialite";
            this.Text = "Suppression d\'une spécialité";
            this.Load += new System.EventHandler(this.FicSuppriSpecialite_Load);
            this.gbRechercheSupSpe.ResumeLayout(false);
            this.gbRechercheSupSpe.PerformLayout();
            this.gbSelectSupSpe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeSup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRechercheSupSpe;
        private System.Windows.Forms.GroupBox gbSelectSupSpe;
        private System.Windows.Forms.Button btnConfirmerSupSpe;
        private System.Windows.Forms.Button btnAnnulerSupSpe;
        private System.Windows.Forms.Label lblNomSpeSup;
        private System.Windows.Forms.Label lblIDSpeSup;
        private System.Windows.Forms.Label lblNomSpeRech;
        private System.Windows.Forms.TextBox tblNomSpeSup;
        private System.Windows.Forms.TextBox tblIDSpeSup;
        private System.Windows.Forms.TextBox tblNomSpeRech;
        private System.Windows.Forms.DataGridView dgvSpeSup;
        private System.Windows.Forms.Label lblResultatRechercheSpe;
        private System.Windows.Forms.Button btnChercherSpe;
        private System.Windows.Forms.Button btnAfficherListeSpe;
    }
}