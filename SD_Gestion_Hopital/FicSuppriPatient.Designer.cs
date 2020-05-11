namespace SD_Gestion_Hopital
{
    partial class EcranSuppriPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranSuppriPatient));
            this.btnAnnulerSupPat = new System.Windows.Forms.Button();
            this.btnConfirmerSupPat = new System.Windows.Forms.Button();
            this.gbSelectPatSup = new System.Windows.Forms.GroupBox();
            this.btnAfficherListePat = new System.Windows.Forms.Button();
            this.dgvPatSup = new System.Windows.Forms.DataGridView();
            this.gbRecherchePatSup = new System.Windows.Forms.GroupBox();
            this.lblGSMPatSup = new System.Windows.Forms.Label();
            this.tbGSMPatSup = new System.Windows.Forms.TextBox();
            this.lblAdressePatSup = new System.Windows.Forms.Label();
            this.tbAdressePatSup = new System.Windows.Forms.TextBox();
            this.lblPrenomPatSup = new System.Windows.Forms.Label();
            this.tbPrenomPatSup = new System.Windows.Forms.TextBox();
            this.lblPrenomPatRech = new System.Windows.Forms.Label();
            this.tbPrenomPatRech = new System.Windows.Forms.TextBox();
            this.btnChercherPat = new System.Windows.Forms.Button();
            this.lblResultatRecherchePat = new System.Windows.Forms.Label();
            this.lblNomPatSup = new System.Windows.Forms.Label();
            this.lblIDPatSup = new System.Windows.Forms.Label();
            this.lblNomPatRech = new System.Windows.Forms.Label();
            this.tbNomPatSup = new System.Windows.Forms.TextBox();
            this.tbIDPatSup = new System.Windows.Forms.TextBox();
            this.tbNomPatRech = new System.Windows.Forms.TextBox();
            this.gbSelectPatSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatSup)).BeginInit();
            this.gbRecherchePatSup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnulerSupPat
            // 
            this.btnAnnulerSupPat.Location = new System.Drawing.Point(468, 531);
            this.btnAnnulerSupPat.Name = "btnAnnulerSupPat";
            this.btnAnnulerSupPat.Size = new System.Drawing.Size(150, 50);
            this.btnAnnulerSupPat.TabIndex = 11;
            this.btnAnnulerSupPat.Text = "A N N U L E R";
            this.btnAnnulerSupPat.UseVisualStyleBackColor = true;
            this.btnAnnulerSupPat.Click += new System.EventHandler(this.btnAnnulerSupPat_Click);
            // 
            // btnConfirmerSupPat
            // 
            this.btnConfirmerSupPat.Location = new System.Drawing.Point(179, 531);
            this.btnConfirmerSupPat.Name = "btnConfirmerSupPat";
            this.btnConfirmerSupPat.Size = new System.Drawing.Size(150, 50);
            this.btnConfirmerSupPat.TabIndex = 10;
            this.btnConfirmerSupPat.Text = "S U P P R I M E R";
            this.btnConfirmerSupPat.UseVisualStyleBackColor = true;
            this.btnConfirmerSupPat.Click += new System.EventHandler(this.btnConfirmerSupPat_Click);
            // 
            // gbSelectPatSup
            // 
            this.gbSelectPatSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbSelectPatSup.Controls.Add(this.btnAfficherListePat);
            this.gbSelectPatSup.Controls.Add(this.dgvPatSup);
            this.gbSelectPatSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelectPatSup.Location = new System.Drawing.Point(11, 237);
            this.gbSelectPatSup.Name = "gbSelectPatSup";
            this.gbSelectPatSup.Size = new System.Drawing.Size(776, 270);
            this.gbSelectPatSup.TabIndex = 9;
            this.gbSelectPatSup.TabStop = false;
            this.gbSelectPatSup.Text = "Sélectionner :";
            // 
            // btnAfficherListePat
            // 
            this.btnAfficherListePat.Location = new System.Drawing.Point(6, 45);
            this.btnAfficherListePat.Name = "btnAfficherListePat";
            this.btnAfficherListePat.Size = new System.Drawing.Size(83, 60);
            this.btnAfficherListePat.TabIndex = 1;
            this.btnAfficherListePat.Text = "AFFICHER LA LISTE";
            this.btnAfficherListePat.UseVisualStyleBackColor = true;
            this.btnAfficherListePat.Click += new System.EventHandler(this.btnAfficherListePat_Click);
            // 
            // dgvPatSup
            // 
            this.dgvPatSup.AllowUserToAddRows = false;
            this.dgvPatSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatSup.Location = new System.Drawing.Point(95, 45);
            this.dgvPatSup.Name = "dgvPatSup";
            this.dgvPatSup.ReadOnly = true;
            this.dgvPatSup.Size = new System.Drawing.Size(561, 191);
            this.dgvPatSup.TabIndex = 0;
            // 
            // gbRecherchePatSup
            // 
            this.gbRecherchePatSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbRecherchePatSup.Controls.Add(this.lblGSMPatSup);
            this.gbRecherchePatSup.Controls.Add(this.tbGSMPatSup);
            this.gbRecherchePatSup.Controls.Add(this.lblAdressePatSup);
            this.gbRecherchePatSup.Controls.Add(this.tbAdressePatSup);
            this.gbRecherchePatSup.Controls.Add(this.lblPrenomPatSup);
            this.gbRecherchePatSup.Controls.Add(this.tbPrenomPatSup);
            this.gbRecherchePatSup.Controls.Add(this.lblPrenomPatRech);
            this.gbRecherchePatSup.Controls.Add(this.tbPrenomPatRech);
            this.gbRecherchePatSup.Controls.Add(this.btnChercherPat);
            this.gbRecherchePatSup.Controls.Add(this.lblResultatRecherchePat);
            this.gbRecherchePatSup.Controls.Add(this.lblNomPatSup);
            this.gbRecherchePatSup.Controls.Add(this.lblIDPatSup);
            this.gbRecherchePatSup.Controls.Add(this.lblNomPatRech);
            this.gbRecherchePatSup.Controls.Add(this.tbNomPatSup);
            this.gbRecherchePatSup.Controls.Add(this.tbIDPatSup);
            this.gbRecherchePatSup.Controls.Add(this.tbNomPatRech);
            this.gbRecherchePatSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecherchePatSup.Location = new System.Drawing.Point(11, 10);
            this.gbRecherchePatSup.Name = "gbRecherchePatSup";
            this.gbRecherchePatSup.Size = new System.Drawing.Size(776, 221);
            this.gbRecherchePatSup.TabIndex = 8;
            this.gbRecherchePatSup.TabStop = false;
            this.gbRecherchePatSup.Text = "Recherche :";
            // 
            // lblGSMPatSup
            // 
            this.lblGSMPatSup.AutoSize = true;
            this.lblGSMPatSup.Location = new System.Drawing.Point(454, 163);
            this.lblGSMPatSup.Name = "lblGSMPatSup";
            this.lblGSMPatSup.Size = new System.Drawing.Size(47, 17);
            this.lblGSMPatSup.TabIndex = 15;
            this.lblGSMPatSup.Text = "GSM :";
            // 
            // tbGSMPatSup
            // 
            this.tbGSMPatSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbGSMPatSup.Location = new System.Drawing.Point(457, 183);
            this.tbGSMPatSup.Name = "tbGSMPatSup";
            this.tbGSMPatSup.ReadOnly = true;
            this.tbGSMPatSup.Size = new System.Drawing.Size(152, 23);
            this.tbGSMPatSup.TabIndex = 14;
            // 
            // lblAdressePatSup
            // 
            this.lblAdressePatSup.AutoSize = true;
            this.lblAdressePatSup.Location = new System.Drawing.Point(92, 163);
            this.lblAdressePatSup.Name = "lblAdressePatSup";
            this.lblAdressePatSup.Size = new System.Drawing.Size(68, 17);
            this.lblAdressePatSup.TabIndex = 13;
            this.lblAdressePatSup.Text = "Adresse :";
            // 
            // tbAdressePatSup
            // 
            this.tbAdressePatSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbAdressePatSup.Location = new System.Drawing.Point(95, 183);
            this.tbAdressePatSup.Name = "tbAdressePatSup";
            this.tbAdressePatSup.ReadOnly = true;
            this.tbAdressePatSup.Size = new System.Drawing.Size(320, 23);
            this.tbAdressePatSup.TabIndex = 12;
            // 
            // lblPrenomPatSup
            // 
            this.lblPrenomPatSup.AutoSize = true;
            this.lblPrenomPatSup.Location = new System.Drawing.Point(454, 108);
            this.lblPrenomPatSup.Name = "lblPrenomPatSup";
            this.lblPrenomPatSup.Size = new System.Drawing.Size(65, 17);
            this.lblPrenomPatSup.TabIndex = 11;
            this.lblPrenomPatSup.Text = "Prénom :";
            // 
            // tbPrenomPatSup
            // 
            this.tbPrenomPatSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbPrenomPatSup.Location = new System.Drawing.Point(457, 128);
            this.tbPrenomPatSup.Name = "tbPrenomPatSup";
            this.tbPrenomPatSup.ReadOnly = true;
            this.tbPrenomPatSup.Size = new System.Drawing.Size(199, 23);
            this.tbPrenomPatSup.TabIndex = 10;
            // 
            // lblPrenomPatRech
            // 
            this.lblPrenomPatRech.AutoSize = true;
            this.lblPrenomPatRech.Location = new System.Drawing.Point(260, 23);
            this.lblPrenomPatRech.Name = "lblPrenomPatRech";
            this.lblPrenomPatRech.Size = new System.Drawing.Size(65, 17);
            this.lblPrenomPatRech.TabIndex = 9;
            this.lblPrenomPatRech.Text = "Prénom :";
            // 
            // tbPrenomPatRech
            // 
            this.tbPrenomPatRech.Location = new System.Drawing.Point(263, 43);
            this.tbPrenomPatRech.Name = "tbPrenomPatRech";
            this.tbPrenomPatRech.Size = new System.Drawing.Size(139, 23);
            this.tbPrenomPatRech.TabIndex = 8;
            // 
            // btnChercherPat
            // 
            this.btnChercherPat.Location = new System.Drawing.Point(481, 38);
            this.btnChercherPat.Name = "btnChercherPat";
            this.btnChercherPat.Size = new System.Drawing.Size(126, 33);
            this.btnChercherPat.TabIndex = 7;
            this.btnChercherPat.Text = "C H E R C H E R";
            this.btnChercherPat.UseVisualStyleBackColor = true;
            this.btnChercherPat.Click += new System.EventHandler(this.btnChercherPat_Click);
            // 
            // lblResultatRecherchePat
            // 
            this.lblResultatRecherchePat.AutoSize = true;
            this.lblResultatRecherchePat.Location = new System.Drawing.Point(15, 82);
            this.lblResultatRecherchePat.Name = "lblResultatRecherchePat";
            this.lblResultatRecherchePat.Size = new System.Drawing.Size(68, 17);
            this.lblResultatRecherchePat.TabIndex = 6;
            this.lblResultatRecherchePat.Text = "Résultat :";
            // 
            // lblNomPatSup
            // 
            this.lblNomPatSup.AutoSize = true;
            this.lblNomPatSup.Location = new System.Drawing.Point(213, 108);
            this.lblNomPatSup.Name = "lblNomPatSup";
            this.lblNomPatSup.Size = new System.Drawing.Size(45, 17);
            this.lblNomPatSup.TabIndex = 5;
            this.lblNomPatSup.Text = "Nom :";
            // 
            // lblIDPatSup
            // 
            this.lblIDPatSup.AutoSize = true;
            this.lblIDPatSup.Location = new System.Drawing.Point(92, 108);
            this.lblIDPatSup.Name = "lblIDPatSup";
            this.lblIDPatSup.Size = new System.Drawing.Size(29, 17);
            this.lblIDPatSup.TabIndex = 4;
            this.lblIDPatSup.Text = "ID :";
            // 
            // lblNomPatRech
            // 
            this.lblNomPatRech.AutoSize = true;
            this.lblNomPatRech.Location = new System.Drawing.Point(92, 23);
            this.lblNomPatRech.Name = "lblNomPatRech";
            this.lblNomPatRech.Size = new System.Drawing.Size(45, 17);
            this.lblNomPatRech.TabIndex = 3;
            this.lblNomPatRech.Text = "Nom :";
            // 
            // tbNomPatSup
            // 
            this.tbNomPatSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbNomPatSup.Location = new System.Drawing.Point(216, 128);
            this.tbNomPatSup.Name = "tbNomPatSup";
            this.tbNomPatSup.ReadOnly = true;
            this.tbNomPatSup.Size = new System.Drawing.Size(199, 23);
            this.tbNomPatSup.TabIndex = 2;
            // 
            // tbIDPatSup
            // 
            this.tbIDPatSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbIDPatSup.Location = new System.Drawing.Point(95, 128);
            this.tbIDPatSup.Name = "tbIDPatSup";
            this.tbIDPatSup.ReadOnly = true;
            this.tbIDPatSup.Size = new System.Drawing.Size(87, 23);
            this.tbIDPatSup.TabIndex = 1;
            // 
            // tbNomPatRech
            // 
            this.tbNomPatRech.Location = new System.Drawing.Point(95, 43);
            this.tbNomPatRech.Name = "tbNomPatRech";
            this.tbNomPatRech.Size = new System.Drawing.Size(139, 23);
            this.tbNomPatRech.TabIndex = 0;
            this.tbNomPatRech.Click += new System.EventHandler(this.tbNomPatRech_Click);
            // 
            // EcranSuppriPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 591);
            this.Controls.Add(this.btnAnnulerSupPat);
            this.Controls.Add(this.btnConfirmerSupPat);
            this.Controls.Add(this.gbSelectPatSup);
            this.Controls.Add(this.gbRecherchePatSup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranSuppriPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Suppression d\'un patient";
            this.Load += new System.EventHandler(this.EcranSuppriPatient_Load);
            this.gbSelectPatSup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatSup)).EndInit();
            this.gbRecherchePatSup.ResumeLayout(false);
            this.gbRecherchePatSup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnnulerSupPat;
        private System.Windows.Forms.Button btnConfirmerSupPat;
        private System.Windows.Forms.GroupBox gbSelectPatSup;
        private System.Windows.Forms.Button btnAfficherListePat;
        private System.Windows.Forms.DataGridView dgvPatSup;
        private System.Windows.Forms.GroupBox gbRecherchePatSup;
        private System.Windows.Forms.Label lblGSMPatSup;
        private System.Windows.Forms.TextBox tbGSMPatSup;
        private System.Windows.Forms.Label lblAdressePatSup;
        private System.Windows.Forms.TextBox tbAdressePatSup;
        private System.Windows.Forms.Label lblPrenomPatSup;
        private System.Windows.Forms.TextBox tbPrenomPatSup;
        private System.Windows.Forms.Label lblPrenomPatRech;
        private System.Windows.Forms.TextBox tbPrenomPatRech;
        private System.Windows.Forms.Button btnChercherPat;
        private System.Windows.Forms.Label lblResultatRecherchePat;
        private System.Windows.Forms.Label lblNomPatSup;
        private System.Windows.Forms.Label lblIDPatSup;
        private System.Windows.Forms.Label lblNomPatRech;
        private System.Windows.Forms.TextBox tbNomPatSup;
        private System.Windows.Forms.TextBox tbIDPatSup;
        private System.Windows.Forms.TextBox tbNomPatRech;
    }
}