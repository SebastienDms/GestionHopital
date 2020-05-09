namespace SD_Gestion_Hopital
{
    partial class EcranSuppriMedecin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranSuppriMedecin));
            this.btnAnnulerSupMed = new System.Windows.Forms.Button();
            this.btnConfirmerSupMed = new System.Windows.Forms.Button();
            this.gbSelectSupMed = new System.Windows.Forms.GroupBox();
            this.btnAfficherListeMed = new System.Windows.Forms.Button();
            this.dgvMedSup = new System.Windows.Forms.DataGridView();
            this.gbRechercheSupMed = new System.Windows.Forms.GroupBox();
            this.lblSpecialiteMedSup = new System.Windows.Forms.Label();
            this.tbSpecialiteMedSup = new System.Windows.Forms.TextBox();
            this.lblGSMMedSup = new System.Windows.Forms.Label();
            this.tbGSMMedSup = new System.Windows.Forms.TextBox();
            this.lblPrenomMedSup = new System.Windows.Forms.Label();
            this.tbPrenomMedSup = new System.Windows.Forms.TextBox();
            this.lblPrenomMedRech = new System.Windows.Forms.Label();
            this.tbPrenomMedRech = new System.Windows.Forms.TextBox();
            this.btnChercherMed = new System.Windows.Forms.Button();
            this.lblResultatRechercheMed = new System.Windows.Forms.Label();
            this.lblNomMedSup = new System.Windows.Forms.Label();
            this.lblIDMedSup = new System.Windows.Forms.Label();
            this.lblNomMedRech = new System.Windows.Forms.Label();
            this.tbNomMedSup = new System.Windows.Forms.TextBox();
            this.tbIDMedSup = new System.Windows.Forms.TextBox();
            this.tbNomMedRech = new System.Windows.Forms.TextBox();
            this.gbSelectSupMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedSup)).BeginInit();
            this.gbRechercheSupMed.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnulerSupMed
            // 
            this.btnAnnulerSupMed.Location = new System.Drawing.Point(469, 533);
            this.btnAnnulerSupMed.Name = "btnAnnulerSupMed";
            this.btnAnnulerSupMed.Size = new System.Drawing.Size(150, 50);
            this.btnAnnulerSupMed.TabIndex = 7;
            this.btnAnnulerSupMed.Text = "A N N U L E R";
            this.btnAnnulerSupMed.UseVisualStyleBackColor = true;
            this.btnAnnulerSupMed.Click += new System.EventHandler(this.btnAnnulerSupMed_Click);
            // 
            // btnConfirmerSupMed
            // 
            this.btnConfirmerSupMed.Location = new System.Drawing.Point(180, 533);
            this.btnConfirmerSupMed.Name = "btnConfirmerSupMed";
            this.btnConfirmerSupMed.Size = new System.Drawing.Size(150, 50);
            this.btnConfirmerSupMed.TabIndex = 6;
            this.btnConfirmerSupMed.Text = "S U P P R I M E R";
            this.btnConfirmerSupMed.UseVisualStyleBackColor = true;
            this.btnConfirmerSupMed.Click += new System.EventHandler(this.btnConfirmerSupMed_Click);
            // 
            // gbSelectSupMed
            // 
            this.gbSelectSupMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbSelectSupMed.Controls.Add(this.btnAfficherListeMed);
            this.gbSelectSupMed.Controls.Add(this.dgvMedSup);
            this.gbSelectSupMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelectSupMed.Location = new System.Drawing.Point(12, 239);
            this.gbSelectSupMed.Name = "gbSelectSupMed";
            this.gbSelectSupMed.Size = new System.Drawing.Size(776, 270);
            this.gbSelectSupMed.TabIndex = 5;
            this.gbSelectSupMed.TabStop = false;
            this.gbSelectSupMed.Text = "Sélectionner :";
            // 
            // btnAfficherListeMed
            // 
            this.btnAfficherListeMed.Location = new System.Drawing.Point(6, 45);
            this.btnAfficherListeMed.Name = "btnAfficherListeMed";
            this.btnAfficherListeMed.Size = new System.Drawing.Size(83, 60);
            this.btnAfficherListeMed.TabIndex = 1;
            this.btnAfficherListeMed.Text = "AFFICHER LA LISTE";
            this.btnAfficherListeMed.UseVisualStyleBackColor = true;
            this.btnAfficherListeMed.Click += new System.EventHandler(this.btnAfficherListeMed_Click);
            // 
            // dgvMedSup
            // 
            this.dgvMedSup.AllowUserToAddRows = false;
            this.dgvMedSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedSup.Location = new System.Drawing.Point(95, 45);
            this.dgvMedSup.Name = "dgvMedSup";
            this.dgvMedSup.ReadOnly = true;
            this.dgvMedSup.Size = new System.Drawing.Size(561, 191);
            this.dgvMedSup.TabIndex = 0;
            // 
            // gbRechercheSupMed
            // 
            this.gbRechercheSupMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbRechercheSupMed.Controls.Add(this.lblSpecialiteMedSup);
            this.gbRechercheSupMed.Controls.Add(this.tbSpecialiteMedSup);
            this.gbRechercheSupMed.Controls.Add(this.lblGSMMedSup);
            this.gbRechercheSupMed.Controls.Add(this.tbGSMMedSup);
            this.gbRechercheSupMed.Controls.Add(this.lblPrenomMedSup);
            this.gbRechercheSupMed.Controls.Add(this.tbPrenomMedSup);
            this.gbRechercheSupMed.Controls.Add(this.lblPrenomMedRech);
            this.gbRechercheSupMed.Controls.Add(this.tbPrenomMedRech);
            this.gbRechercheSupMed.Controls.Add(this.btnChercherMed);
            this.gbRechercheSupMed.Controls.Add(this.lblResultatRechercheMed);
            this.gbRechercheSupMed.Controls.Add(this.lblNomMedSup);
            this.gbRechercheSupMed.Controls.Add(this.lblIDMedSup);
            this.gbRechercheSupMed.Controls.Add(this.lblNomMedRech);
            this.gbRechercheSupMed.Controls.Add(this.tbNomMedSup);
            this.gbRechercheSupMed.Controls.Add(this.tbIDMedSup);
            this.gbRechercheSupMed.Controls.Add(this.tbNomMedRech);
            this.gbRechercheSupMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRechercheSupMed.Location = new System.Drawing.Point(12, 12);
            this.gbRechercheSupMed.Name = "gbRechercheSupMed";
            this.gbRechercheSupMed.Size = new System.Drawing.Size(776, 221);
            this.gbRechercheSupMed.TabIndex = 4;
            this.gbRechercheSupMed.TabStop = false;
            this.gbRechercheSupMed.Text = "Recherche :";
            // 
            // lblSpecialiteMedSup
            // 
            this.lblSpecialiteMedSup.AutoSize = true;
            this.lblSpecialiteMedSup.Location = new System.Drawing.Point(260, 163);
            this.lblSpecialiteMedSup.Name = "lblSpecialiteMedSup";
            this.lblSpecialiteMedSup.Size = new System.Drawing.Size(77, 17);
            this.lblSpecialiteMedSup.TabIndex = 15;
            this.lblSpecialiteMedSup.Text = "Spécialité :";
            // 
            // tbSpecialiteMedSup
            // 
            this.tbSpecialiteMedSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbSpecialiteMedSup.Location = new System.Drawing.Point(263, 183);
            this.tbSpecialiteMedSup.Name = "tbSpecialiteMedSup";
            this.tbSpecialiteMedSup.ReadOnly = true;
            this.tbSpecialiteMedSup.Size = new System.Drawing.Size(152, 23);
            this.tbSpecialiteMedSup.TabIndex = 14;
            // 
            // lblGSMMedSup
            // 
            this.lblGSMMedSup.AutoSize = true;
            this.lblGSMMedSup.Location = new System.Drawing.Point(92, 163);
            this.lblGSMMedSup.Name = "lblGSMMedSup";
            this.lblGSMMedSup.Size = new System.Drawing.Size(47, 17);
            this.lblGSMMedSup.TabIndex = 13;
            this.lblGSMMedSup.Text = "GSM :";
            // 
            // tbGSMMedSup
            // 
            this.tbGSMMedSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbGSMMedSup.Location = new System.Drawing.Point(95, 183);
            this.tbGSMMedSup.Name = "tbGSMMedSup";
            this.tbGSMMedSup.ReadOnly = true;
            this.tbGSMMedSup.Size = new System.Drawing.Size(121, 23);
            this.tbGSMMedSup.TabIndex = 12;
            // 
            // lblPrenomMedSup
            // 
            this.lblPrenomMedSup.AutoSize = true;
            this.lblPrenomMedSup.Location = new System.Drawing.Point(454, 108);
            this.lblPrenomMedSup.Name = "lblPrenomMedSup";
            this.lblPrenomMedSup.Size = new System.Drawing.Size(65, 17);
            this.lblPrenomMedSup.TabIndex = 11;
            this.lblPrenomMedSup.Text = "Prénom :";
            // 
            // tbPrenomMedSup
            // 
            this.tbPrenomMedSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbPrenomMedSup.Location = new System.Drawing.Point(457, 128);
            this.tbPrenomMedSup.Name = "tbPrenomMedSup";
            this.tbPrenomMedSup.ReadOnly = true;
            this.tbPrenomMedSup.Size = new System.Drawing.Size(199, 23);
            this.tbPrenomMedSup.TabIndex = 10;
            // 
            // lblPrenomMedRech
            // 
            this.lblPrenomMedRech.AutoSize = true;
            this.lblPrenomMedRech.Location = new System.Drawing.Point(260, 23);
            this.lblPrenomMedRech.Name = "lblPrenomMedRech";
            this.lblPrenomMedRech.Size = new System.Drawing.Size(65, 17);
            this.lblPrenomMedRech.TabIndex = 9;
            this.lblPrenomMedRech.Text = "Prénom :";
            // 
            // tbPrenomMedRech
            // 
            this.tbPrenomMedRech.Location = new System.Drawing.Point(263, 43);
            this.tbPrenomMedRech.Name = "tbPrenomMedRech";
            this.tbPrenomMedRech.Size = new System.Drawing.Size(139, 23);
            this.tbPrenomMedRech.TabIndex = 8;
            // 
            // btnChercherMed
            // 
            this.btnChercherMed.Location = new System.Drawing.Point(481, 38);
            this.btnChercherMed.Name = "btnChercherMed";
            this.btnChercherMed.Size = new System.Drawing.Size(126, 33);
            this.btnChercherMed.TabIndex = 7;
            this.btnChercherMed.Text = "C H E R C H E R";
            this.btnChercherMed.UseVisualStyleBackColor = true;
            this.btnChercherMed.Click += new System.EventHandler(this.btnChercherMed_Click);
            // 
            // lblResultatRechercheMed
            // 
            this.lblResultatRechercheMed.AutoSize = true;
            this.lblResultatRechercheMed.Location = new System.Drawing.Point(15, 82);
            this.lblResultatRechercheMed.Name = "lblResultatRechercheMed";
            this.lblResultatRechercheMed.Size = new System.Drawing.Size(68, 17);
            this.lblResultatRechercheMed.TabIndex = 6;
            this.lblResultatRechercheMed.Text = "Résultat :";
            // 
            // lblNomMedSup
            // 
            this.lblNomMedSup.AutoSize = true;
            this.lblNomMedSup.Location = new System.Drawing.Point(213, 108);
            this.lblNomMedSup.Name = "lblNomMedSup";
            this.lblNomMedSup.Size = new System.Drawing.Size(45, 17);
            this.lblNomMedSup.TabIndex = 5;
            this.lblNomMedSup.Text = "Nom :";
            // 
            // lblIDMedSup
            // 
            this.lblIDMedSup.AutoSize = true;
            this.lblIDMedSup.Location = new System.Drawing.Point(92, 108);
            this.lblIDMedSup.Name = "lblIDMedSup";
            this.lblIDMedSup.Size = new System.Drawing.Size(29, 17);
            this.lblIDMedSup.TabIndex = 4;
            this.lblIDMedSup.Text = "ID :";
            // 
            // lblNomMedRech
            // 
            this.lblNomMedRech.AutoSize = true;
            this.lblNomMedRech.Location = new System.Drawing.Point(92, 23);
            this.lblNomMedRech.Name = "lblNomMedRech";
            this.lblNomMedRech.Size = new System.Drawing.Size(45, 17);
            this.lblNomMedRech.TabIndex = 3;
            this.lblNomMedRech.Text = "Nom :";
            // 
            // tbNomMedSup
            // 
            this.tbNomMedSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbNomMedSup.Location = new System.Drawing.Point(216, 128);
            this.tbNomMedSup.Name = "tbNomMedSup";
            this.tbNomMedSup.ReadOnly = true;
            this.tbNomMedSup.Size = new System.Drawing.Size(199, 23);
            this.tbNomMedSup.TabIndex = 2;
            // 
            // tbIDMedSup
            // 
            this.tbIDMedSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbIDMedSup.Location = new System.Drawing.Point(95, 128);
            this.tbIDMedSup.Name = "tbIDMedSup";
            this.tbIDMedSup.ReadOnly = true;
            this.tbIDMedSup.Size = new System.Drawing.Size(87, 23);
            this.tbIDMedSup.TabIndex = 1;
            // 
            // tbNomMedRech
            // 
            this.tbNomMedRech.Location = new System.Drawing.Point(95, 43);
            this.tbNomMedRech.Name = "tbNomMedRech";
            this.tbNomMedRech.Size = new System.Drawing.Size(139, 23);
            this.tbNomMedRech.TabIndex = 0;
            this.tbNomMedRech.Click += new System.EventHandler(this.tbNomMedRech_Click);
            // 
            // EcranSuppriMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.btnAnnulerSupMed);
            this.Controls.Add(this.btnConfirmerSupMed);
            this.Controls.Add(this.gbSelectSupMed);
            this.Controls.Add(this.gbRechercheSupMed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranSuppriMedecin";
            this.Text = "Suppression d\'un médecin";
            this.Load += new System.EventHandler(this.FicSuppriMedecin_Load);
            this.gbSelectSupMed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedSup)).EndInit();
            this.gbRechercheSupMed.ResumeLayout(false);
            this.gbRechercheSupMed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnnulerSupMed;
        private System.Windows.Forms.Button btnConfirmerSupMed;
        private System.Windows.Forms.GroupBox gbSelectSupMed;
        private System.Windows.Forms.Button btnAfficherListeMed;
        private System.Windows.Forms.DataGridView dgvMedSup;
        private System.Windows.Forms.GroupBox gbRechercheSupMed;
        private System.Windows.Forms.Label lblPrenomMedSup;
        private System.Windows.Forms.TextBox tbPrenomMedSup;
        private System.Windows.Forms.Label lblPrenomMedRech;
        private System.Windows.Forms.TextBox tbPrenomMedRech;
        private System.Windows.Forms.Button btnChercherMed;
        private System.Windows.Forms.Label lblResultatRechercheMed;
        private System.Windows.Forms.Label lblNomMedSup;
        private System.Windows.Forms.Label lblIDMedSup;
        private System.Windows.Forms.Label lblNomMedRech;
        private System.Windows.Forms.TextBox tbNomMedSup;
        private System.Windows.Forms.TextBox tbIDMedSup;
        private System.Windows.Forms.TextBox tbNomMedRech;
        private System.Windows.Forms.Label lblSpecialiteMedSup;
        private System.Windows.Forms.TextBox tbSpecialiteMedSup;
        private System.Windows.Forms.Label lblGSMMedSup;
        private System.Windows.Forms.TextBox tbGSMMedSup;
    }
}