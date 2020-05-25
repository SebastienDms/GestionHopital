namespace SD_Gestion_Hopital
{
    partial class EcranSuppriChambre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranSuppriChambre));
            this.btnAnnulerSupCha = new System.Windows.Forms.Button();
            this.btnConfirmerSupCha = new System.Windows.Forms.Button();
            this.gbSelectChaSup = new System.Windows.Forms.GroupBox();
            this.btnAfficherListeCha = new System.Windows.Forms.Button();
            this.dgvChaSup = new System.Windows.Forms.DataGridView();
            this.gbRechercheChaSup = new System.Windows.Forms.GroupBox();
            this.lblServiceChaSup = new System.Windows.Forms.Label();
            this.tbServiceChaSup = new System.Windows.Forms.TextBox();
            this.lblEtageChaSup = new System.Windows.Forms.Label();
            this.tbEtageChaSup = new System.Windows.Forms.TextBox();
            this.lblTypeChaSup = new System.Windows.Forms.Label();
            this.tbTypeChaSup = new System.Windows.Forms.TextBox();
            this.lblQuantiteLitChaSup = new System.Windows.Forms.Label();
            this.tbQuantLitChaSup = new System.Windows.Forms.TextBox();
            this.btnChercherCha = new System.Windows.Forms.Button();
            this.lblResultatRechercheCha = new System.Windows.Forms.Label();
            this.lblNomChaSup = new System.Windows.Forms.Label();
            this.lblIDChaSup = new System.Windows.Forms.Label();
            this.lblNomChaRech = new System.Windows.Forms.Label();
            this.tbNomChaSup = new System.Windows.Forms.TextBox();
            this.tbIDChaSup = new System.Windows.Forms.TextBox();
            this.tbNomChaRech = new System.Windows.Forms.TextBox();
            this.gbSelectChaSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChaSup)).BeginInit();
            this.gbRechercheChaSup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnulerSupCha
            // 
            this.btnAnnulerSupCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerSupCha.Location = new System.Drawing.Point(469, 535);
            this.btnAnnulerSupCha.Name = "btnAnnulerSupCha";
            this.btnAnnulerSupCha.Size = new System.Drawing.Size(150, 50);
            this.btnAnnulerSupCha.TabIndex = 11;
            this.btnAnnulerSupCha.Text = "A N N U L E R";
            this.btnAnnulerSupCha.UseVisualStyleBackColor = true;
            this.btnAnnulerSupCha.Click += new System.EventHandler(this.btnAnnulerSupCha_Click);
            // 
            // btnConfirmerSupCha
            // 
            this.btnConfirmerSupCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmerSupCha.Location = new System.Drawing.Point(180, 535);
            this.btnConfirmerSupCha.Name = "btnConfirmerSupCha";
            this.btnConfirmerSupCha.Size = new System.Drawing.Size(150, 50);
            this.btnConfirmerSupCha.TabIndex = 10;
            this.btnConfirmerSupCha.Text = "S U P P R I M E R";
            this.btnConfirmerSupCha.UseVisualStyleBackColor = true;
            this.btnConfirmerSupCha.Click += new System.EventHandler(this.btnConfirmerSupCha_Click);
            // 
            // gbSelectChaSup
            // 
            this.gbSelectChaSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbSelectChaSup.Controls.Add(this.btnAfficherListeCha);
            this.gbSelectChaSup.Controls.Add(this.dgvChaSup);
            this.gbSelectChaSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelectChaSup.Location = new System.Drawing.Point(12, 241);
            this.gbSelectChaSup.Name = "gbSelectChaSup";
            this.gbSelectChaSup.Size = new System.Drawing.Size(776, 270);
            this.gbSelectChaSup.TabIndex = 9;
            this.gbSelectChaSup.TabStop = false;
            this.gbSelectChaSup.Text = "Sélectionner :";
            // 
            // btnAfficherListeCha
            // 
            this.btnAfficherListeCha.Location = new System.Drawing.Point(6, 45);
            this.btnAfficherListeCha.Name = "btnAfficherListeCha";
            this.btnAfficherListeCha.Size = new System.Drawing.Size(83, 60);
            this.btnAfficherListeCha.TabIndex = 1;
            this.btnAfficherListeCha.Text = "AFFICHER LA LISTE";
            this.btnAfficherListeCha.UseVisualStyleBackColor = true;
            this.btnAfficherListeCha.Click += new System.EventHandler(this.btnAfficherListeCha_Click);
            // 
            // dgvChaSup
            // 
            this.dgvChaSup.AllowUserToAddRows = false;
            this.dgvChaSup.AllowUserToDeleteRows = false;
            this.dgvChaSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChaSup.Location = new System.Drawing.Point(95, 45);
            this.dgvChaSup.Name = "dgvChaSup";
            this.dgvChaSup.ReadOnly = true;
            this.dgvChaSup.Size = new System.Drawing.Size(561, 191);
            this.dgvChaSup.TabIndex = 0;
            // 
            // gbRechercheChaSup
            // 
            this.gbRechercheChaSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbRechercheChaSup.Controls.Add(this.lblServiceChaSup);
            this.gbRechercheChaSup.Controls.Add(this.tbServiceChaSup);
            this.gbRechercheChaSup.Controls.Add(this.lblEtageChaSup);
            this.gbRechercheChaSup.Controls.Add(this.tbEtageChaSup);
            this.gbRechercheChaSup.Controls.Add(this.lblTypeChaSup);
            this.gbRechercheChaSup.Controls.Add(this.tbTypeChaSup);
            this.gbRechercheChaSup.Controls.Add(this.lblQuantiteLitChaSup);
            this.gbRechercheChaSup.Controls.Add(this.tbQuantLitChaSup);
            this.gbRechercheChaSup.Controls.Add(this.btnChercherCha);
            this.gbRechercheChaSup.Controls.Add(this.lblResultatRechercheCha);
            this.gbRechercheChaSup.Controls.Add(this.lblNomChaSup);
            this.gbRechercheChaSup.Controls.Add(this.lblIDChaSup);
            this.gbRechercheChaSup.Controls.Add(this.lblNomChaRech);
            this.gbRechercheChaSup.Controls.Add(this.tbNomChaSup);
            this.gbRechercheChaSup.Controls.Add(this.tbIDChaSup);
            this.gbRechercheChaSup.Controls.Add(this.tbNomChaRech);
            this.gbRechercheChaSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRechercheChaSup.Location = new System.Drawing.Point(12, 14);
            this.gbRechercheChaSup.Name = "gbRechercheChaSup";
            this.gbRechercheChaSup.Size = new System.Drawing.Size(776, 221);
            this.gbRechercheChaSup.TabIndex = 8;
            this.gbRechercheChaSup.TabStop = false;
            this.gbRechercheChaSup.Text = "Recherche :";
            // 
            // lblServiceChaSup
            // 
            this.lblServiceChaSup.AutoSize = true;
            this.lblServiceChaSup.Location = new System.Drawing.Point(269, 164);
            this.lblServiceChaSup.Name = "lblServiceChaSup";
            this.lblServiceChaSup.Size = new System.Drawing.Size(104, 17);
            this.lblServiceChaSup.TabIndex = 17;
            this.lblServiceChaSup.Text = "Lié au service :";
            // 
            // tbServiceChaSup
            // 
            this.tbServiceChaSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbServiceChaSup.Location = new System.Drawing.Point(272, 184);
            this.tbServiceChaSup.Name = "tbServiceChaSup";
            this.tbServiceChaSup.ReadOnly = true;
            this.tbServiceChaSup.Size = new System.Drawing.Size(152, 23);
            this.tbServiceChaSup.TabIndex = 16;
            // 
            // lblEtageChaSup
            // 
            this.lblEtageChaSup.AutoSize = true;
            this.lblEtageChaSup.Location = new System.Drawing.Point(92, 164);
            this.lblEtageChaSup.Name = "lblEtageChaSup";
            this.lblEtageChaSup.Size = new System.Drawing.Size(106, 17);
            this.lblEtageChaSup.TabIndex = 15;
            this.lblEtageChaSup.Text = "Situé à l\'étage :";
            // 
            // tbEtageChaSup
            // 
            this.tbEtageChaSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbEtageChaSup.Location = new System.Drawing.Point(95, 184);
            this.tbEtageChaSup.Name = "tbEtageChaSup";
            this.tbEtageChaSup.ReadOnly = true;
            this.tbEtageChaSup.Size = new System.Drawing.Size(103, 23);
            this.tbEtageChaSup.TabIndex = 14;
            // 
            // lblTypeChaSup
            // 
            this.lblTypeChaSup.AutoSize = true;
            this.lblTypeChaSup.Location = new System.Drawing.Point(508, 108);
            this.lblTypeChaSup.Name = "lblTypeChaSup";
            this.lblTypeChaSup.Size = new System.Drawing.Size(48, 17);
            this.lblTypeChaSup.TabIndex = 13;
            this.lblTypeChaSup.Text = "Type :";
            // 
            // tbTypeChaSup
            // 
            this.tbTypeChaSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbTypeChaSup.Location = new System.Drawing.Point(511, 128);
            this.tbTypeChaSup.Name = "tbTypeChaSup";
            this.tbTypeChaSup.ReadOnly = true;
            this.tbTypeChaSup.Size = new System.Drawing.Size(127, 23);
            this.tbTypeChaSup.TabIndex = 12;
            // 
            // lblQuantiteLitChaSup
            // 
            this.lblQuantiteLitChaSup.AutoSize = true;
            this.lblQuantiteLitChaSup.Location = new System.Drawing.Point(379, 108);
            this.lblQuantiteLitChaSup.Name = "lblQuantiteLitChaSup";
            this.lblQuantiteLitChaSup.Size = new System.Drawing.Size(100, 17);
            this.lblQuantiteLitChaSup.TabIndex = 11;
            this.lblQuantiteLitChaSup.Text = "Nombre de lit :";
            // 
            // tbQuantLitChaSup
            // 
            this.tbQuantLitChaSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbQuantLitChaSup.Location = new System.Drawing.Point(382, 128);
            this.tbQuantLitChaSup.Name = "tbQuantLitChaSup";
            this.tbQuantLitChaSup.ReadOnly = true;
            this.tbQuantLitChaSup.Size = new System.Drawing.Size(97, 23);
            this.tbQuantLitChaSup.TabIndex = 10;
            // 
            // btnChercherCha
            // 
            this.btnChercherCha.Location = new System.Drawing.Point(289, 38);
            this.btnChercherCha.Name = "btnChercherCha";
            this.btnChercherCha.Size = new System.Drawing.Size(126, 33);
            this.btnChercherCha.TabIndex = 7;
            this.btnChercherCha.Text = "C H E R C H E R";
            this.btnChercherCha.UseVisualStyleBackColor = true;
            this.btnChercherCha.Click += new System.EventHandler(this.btnChercherCha_Click);
            // 
            // lblResultatRechercheCha
            // 
            this.lblResultatRechercheCha.AutoSize = true;
            this.lblResultatRechercheCha.Location = new System.Drawing.Point(15, 82);
            this.lblResultatRechercheCha.Name = "lblResultatRechercheCha";
            this.lblResultatRechercheCha.Size = new System.Drawing.Size(68, 17);
            this.lblResultatRechercheCha.TabIndex = 6;
            this.lblResultatRechercheCha.Text = "Résultat :";
            // 
            // lblNomChaSup
            // 
            this.lblNomChaSup.AutoSize = true;
            this.lblNomChaSup.Location = new System.Drawing.Point(213, 108);
            this.lblNomChaSup.Name = "lblNomChaSup";
            this.lblNomChaSup.Size = new System.Drawing.Size(66, 17);
            this.lblNomChaSup.TabIndex = 5;
            this.lblNomChaSup.Text = "Numéro :";
            // 
            // lblIDChaSup
            // 
            this.lblIDChaSup.AutoSize = true;
            this.lblIDChaSup.Location = new System.Drawing.Point(92, 108);
            this.lblIDChaSup.Name = "lblIDChaSup";
            this.lblIDChaSup.Size = new System.Drawing.Size(29, 17);
            this.lblIDChaSup.TabIndex = 4;
            this.lblIDChaSup.Text = "ID :";
            // 
            // lblNomChaRech
            // 
            this.lblNomChaRech.AutoSize = true;
            this.lblNomChaRech.Location = new System.Drawing.Point(92, 23);
            this.lblNomChaRech.Name = "lblNomChaRech";
            this.lblNomChaRech.Size = new System.Drawing.Size(66, 17);
            this.lblNomChaRech.TabIndex = 3;
            this.lblNomChaRech.Text = "Numéro :";
            // 
            // tbNomChaSup
            // 
            this.tbNomChaSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbNomChaSup.Location = new System.Drawing.Point(216, 128);
            this.tbNomChaSup.Name = "tbNomChaSup";
            this.tbNomChaSup.ReadOnly = true;
            this.tbNomChaSup.Size = new System.Drawing.Size(123, 23);
            this.tbNomChaSup.TabIndex = 2;
            // 
            // tbIDChaSup
            // 
            this.tbIDChaSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbIDChaSup.Location = new System.Drawing.Point(95, 128);
            this.tbIDChaSup.Name = "tbIDChaSup";
            this.tbIDChaSup.ReadOnly = true;
            this.tbIDChaSup.Size = new System.Drawing.Size(87, 23);
            this.tbIDChaSup.TabIndex = 1;
            // 
            // tbNomChaRech
            // 
            this.tbNomChaRech.Location = new System.Drawing.Point(95, 43);
            this.tbNomChaRech.Name = "tbNomChaRech";
            this.tbNomChaRech.Size = new System.Drawing.Size(139, 23);
            this.tbNomChaRech.TabIndex = 0;
            this.tbNomChaRech.Click += new System.EventHandler(this.tbNomChaRech_Click);
            // 
            // EcranSuppriChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.btnAnnulerSupCha);
            this.Controls.Add(this.btnConfirmerSupCha);
            this.Controls.Add(this.gbSelectChaSup);
            this.Controls.Add(this.gbRechercheChaSup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranSuppriChambre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Suppression d\'une chambre";
            this.Load += new System.EventHandler(this.FicSuppriChambre_Load);
            this.gbSelectChaSup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChaSup)).EndInit();
            this.gbRechercheChaSup.ResumeLayout(false);
            this.gbRechercheChaSup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnnulerSupCha;
        private System.Windows.Forms.Button btnConfirmerSupCha;
        private System.Windows.Forms.GroupBox gbSelectChaSup;
        private System.Windows.Forms.Button btnAfficherListeCha;
        private System.Windows.Forms.DataGridView dgvChaSup;
        private System.Windows.Forms.GroupBox gbRechercheChaSup;
        private System.Windows.Forms.Label lblEtageChaSup;
        private System.Windows.Forms.TextBox tbEtageChaSup;
        private System.Windows.Forms.Label lblTypeChaSup;
        private System.Windows.Forms.TextBox tbTypeChaSup;
        private System.Windows.Forms.Label lblQuantiteLitChaSup;
        private System.Windows.Forms.TextBox tbQuantLitChaSup;
        private System.Windows.Forms.Button btnChercherCha;
        private System.Windows.Forms.Label lblResultatRechercheCha;
        private System.Windows.Forms.Label lblNomChaSup;
        private System.Windows.Forms.Label lblIDChaSup;
        private System.Windows.Forms.Label lblNomChaRech;
        private System.Windows.Forms.TextBox tbNomChaSup;
        private System.Windows.Forms.TextBox tbIDChaSup;
        private System.Windows.Forms.TextBox tbNomChaRech;
        private System.Windows.Forms.Label lblServiceChaSup;
        private System.Windows.Forms.TextBox tbServiceChaSup;
    }
}