namespace SD_Gestion_Hopital
{
    partial class EcranSuppriSoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranSuppriSoin));
            this.btnAnnulerSupSoi = new System.Windows.Forms.Button();
            this.btnConfirmerSupSoi = new System.Windows.Forms.Button();
            this.gbRechercheSoiSup = new System.Windows.Forms.GroupBox();
            this.lblRechercheMed = new System.Windows.Forms.Label();
            this.lblPrenomMedRechSoi = new System.Windows.Forms.Label();
            this.tbPrenomMedRechSoiSup = new System.Windows.Forms.TextBox();
            this.lblNomMedRechSoi = new System.Windows.Forms.Label();
            this.tbNomMedRechSoiSup = new System.Windows.Forms.TextBox();
            this.btnValiderDateOpeOccpSup = new System.Windows.Forms.Button();
            this.tbDateOperationOccSup = new System.Windows.Forms.TextBox();
            this.dgvResRecSoinSup = new System.Windows.Forms.DataGridView();
            this.dtpDateOpeRechercheOccSup = new System.Windows.Forms.DateTimePicker();
            this.lblRechercheDateOperation = new System.Windows.Forms.Label();
            this.lblRecherchePat = new System.Windows.Forms.Label();
            this.lblPrenomPatRechSoi = new System.Windows.Forms.Label();
            this.tbPrenomPatRechSoiSup = new System.Windows.Forms.TextBox();
            this.btnChercherSoiSup = new System.Windows.Forms.Button();
            this.lblResultatRechercheOpe = new System.Windows.Forms.Label();
            this.lblNomPatRechSoi = new System.Windows.Forms.Label();
            this.tbNomPatRechSoiSup = new System.Windows.Forms.TextBox();
            this.gbRechercheSoiSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResRecSoinSup)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnulerSupSoi
            // 
            this.btnAnnulerSupSoi.Location = new System.Drawing.Point(476, 534);
            this.btnAnnulerSupSoi.Name = "btnAnnulerSupSoi";
            this.btnAnnulerSupSoi.Size = new System.Drawing.Size(150, 50);
            this.btnAnnulerSupSoi.TabIndex = 16;
            this.btnAnnulerSupSoi.Text = "A N N U L E R";
            this.btnAnnulerSupSoi.UseVisualStyleBackColor = true;
            this.btnAnnulerSupSoi.Click += new System.EventHandler(this.btnAnnulerSupSoi_Click);
            // 
            // btnConfirmerSupSoi
            // 
            this.btnConfirmerSupSoi.Location = new System.Drawing.Point(187, 534);
            this.btnConfirmerSupSoi.Name = "btnConfirmerSupSoi";
            this.btnConfirmerSupSoi.Size = new System.Drawing.Size(150, 50);
            this.btnConfirmerSupSoi.TabIndex = 15;
            this.btnConfirmerSupSoi.Text = "S U P P R I M E R";
            this.btnConfirmerSupSoi.UseVisualStyleBackColor = true;
            this.btnConfirmerSupSoi.Click += new System.EventHandler(this.btnConfirmerSupSoi_Click);
            // 
            // gbRechercheSoiSup
            // 
            this.gbRechercheSoiSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbRechercheSoiSup.Controls.Add(this.lblRechercheMed);
            this.gbRechercheSoiSup.Controls.Add(this.lblPrenomMedRechSoi);
            this.gbRechercheSoiSup.Controls.Add(this.tbPrenomMedRechSoiSup);
            this.gbRechercheSoiSup.Controls.Add(this.lblNomMedRechSoi);
            this.gbRechercheSoiSup.Controls.Add(this.tbNomMedRechSoiSup);
            this.gbRechercheSoiSup.Controls.Add(this.btnValiderDateOpeOccpSup);
            this.gbRechercheSoiSup.Controls.Add(this.tbDateOperationOccSup);
            this.gbRechercheSoiSup.Controls.Add(this.dgvResRecSoinSup);
            this.gbRechercheSoiSup.Controls.Add(this.dtpDateOpeRechercheOccSup);
            this.gbRechercheSoiSup.Controls.Add(this.lblRechercheDateOperation);
            this.gbRechercheSoiSup.Controls.Add(this.lblRecherchePat);
            this.gbRechercheSoiSup.Controls.Add(this.lblPrenomPatRechSoi);
            this.gbRechercheSoiSup.Controls.Add(this.tbPrenomPatRechSoiSup);
            this.gbRechercheSoiSup.Controls.Add(this.btnChercherSoiSup);
            this.gbRechercheSoiSup.Controls.Add(this.lblResultatRechercheOpe);
            this.gbRechercheSoiSup.Controls.Add(this.lblNomPatRechSoi);
            this.gbRechercheSoiSup.Controls.Add(this.tbNomPatRechSoiSup);
            this.gbRechercheSoiSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRechercheSoiSup.Location = new System.Drawing.Point(12, 12);
            this.gbRechercheSoiSup.Name = "gbRechercheSoiSup";
            this.gbRechercheSoiSup.Size = new System.Drawing.Size(776, 504);
            this.gbRechercheSoiSup.TabIndex = 14;
            this.gbRechercheSoiSup.TabStop = false;
            this.gbRechercheSoiSup.Text = "Recherche :";
            // 
            // lblRechercheMed
            // 
            this.lblRechercheMed.AutoSize = true;
            this.lblRechercheMed.Location = new System.Drawing.Point(6, 167);
            this.lblRechercheMed.Name = "lblRechercheMed";
            this.lblRechercheMed.Size = new System.Drawing.Size(95, 17);
            this.lblRechercheMed.TabIndex = 25;
            this.lblRechercheMed.Text = "Par médecin :";
            // 
            // lblPrenomMedRechSoi
            // 
            this.lblPrenomMedRechSoi.AutoSize = true;
            this.lblPrenomMedRechSoi.Location = new System.Drawing.Point(403, 167);
            this.lblPrenomMedRechSoi.Name = "lblPrenomMedRechSoi";
            this.lblPrenomMedRechSoi.Size = new System.Drawing.Size(65, 17);
            this.lblPrenomMedRechSoi.TabIndex = 24;
            this.lblPrenomMedRechSoi.Text = "Prénom :";
            // 
            // tbPrenomMedRechSoiSup
            // 
            this.tbPrenomMedRechSoiSup.Location = new System.Drawing.Point(406, 188);
            this.tbPrenomMedRechSoiSup.Name = "tbPrenomMedRechSoiSup";
            this.tbPrenomMedRechSoiSup.Size = new System.Drawing.Size(200, 23);
            this.tbPrenomMedRechSoiSup.TabIndex = 23;
            // 
            // lblNomMedRechSoi
            // 
            this.lblNomMedRechSoi.AutoSize = true;
            this.lblNomMedRechSoi.Location = new System.Drawing.Point(183, 168);
            this.lblNomMedRechSoi.Name = "lblNomMedRechSoi";
            this.lblNomMedRechSoi.Size = new System.Drawing.Size(45, 17);
            this.lblNomMedRechSoi.TabIndex = 22;
            this.lblNomMedRechSoi.Text = "Nom :";
            // 
            // tbNomMedRechSoiSup
            // 
            this.tbNomMedRechSoiSup.Location = new System.Drawing.Point(186, 188);
            this.tbNomMedRechSoiSup.Name = "tbNomMedRechSoiSup";
            this.tbNomMedRechSoiSup.Size = new System.Drawing.Size(200, 23);
            this.tbNomMedRechSoiSup.TabIndex = 21;
            // 
            // btnValiderDateOpeOccpSup
            // 
            this.btnValiderDateOpeOccpSup.Location = new System.Drawing.Point(406, 38);
            this.btnValiderDateOpeOccpSup.Name = "btnValiderDateOpeOccpSup";
            this.btnValiderDateOpeOccpSup.Size = new System.Drawing.Size(126, 25);
            this.btnValiderDateOpeOccpSup.TabIndex = 20;
            this.btnValiderDateOpeOccpSup.Text = "Valider date";
            this.btnValiderDateOpeOccpSup.UseVisualStyleBackColor = true;
            this.btnValiderDateOpeOccpSup.Click += new System.EventHandler(this.btnValiderDateOpeOccpSup_Click);
            // 
            // tbDateOperationOccSup
            // 
            this.tbDateOperationOccSup.Location = new System.Drawing.Point(551, 40);
            this.tbDateOperationOccSup.Name = "tbDateOperationOccSup";
            this.tbDateOperationOccSup.Size = new System.Drawing.Size(128, 23);
            this.tbDateOperationOccSup.TabIndex = 19;
            // 
            // dgvResRecSoinSup
            // 
            this.dgvResRecSoinSup.AllowUserToAddRows = false;
            this.dgvResRecSoinSup.AllowUserToDeleteRows = false;
            this.dgvResRecSoinSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResRecSoinSup.Location = new System.Drawing.Point(149, 274);
            this.dgvResRecSoinSup.Name = "dgvResRecSoinSup";
            this.dgvResRecSoinSup.ReadOnly = true;
            this.dgvResRecSoinSup.Size = new System.Drawing.Size(530, 220);
            this.dgvResRecSoinSup.TabIndex = 18;
            // 
            // dtpDateOpeRechercheOccSup
            // 
            this.dtpDateOpeRechercheOccSup.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOpeRechercheOccSup.Location = new System.Drawing.Point(186, 38);
            this.dtpDateOpeRechercheOccSup.Name = "dtpDateOpeRechercheOccSup";
            this.dtpDateOpeRechercheOccSup.Size = new System.Drawing.Size(200, 23);
            this.dtpDateOpeRechercheOccSup.TabIndex = 17;
            this.dtpDateOpeRechercheOccSup.Value = new System.DateTime(2020, 5, 14, 0, 0, 0, 0);
            this.dtpDateOpeRechercheOccSup.Enter += new System.EventHandler(this.dtpDateOpeRechercheOccSup_Enter);
            // 
            // lblRechercheDateOperation
            // 
            this.lblRechercheDateOperation.AutoSize = true;
            this.lblRechercheDateOperation.Location = new System.Drawing.Point(6, 43);
            this.lblRechercheDateOperation.Name = "lblRechercheDateOperation";
            this.lblRechercheDateOperation.Size = new System.Drawing.Size(126, 17);
            this.lblRechercheDateOperation.TabIndex = 14;
            this.lblRechercheDateOperation.Text = "Par date d\'entrée :";
            // 
            // lblRecherchePat
            // 
            this.lblRecherchePat.AutoSize = true;
            this.lblRecherchePat.Location = new System.Drawing.Point(6, 102);
            this.lblRecherchePat.Name = "lblRecherchePat";
            this.lblRecherchePat.Size = new System.Drawing.Size(86, 17);
            this.lblRecherchePat.TabIndex = 12;
            this.lblRecherchePat.Text = "Par Patient :";
            // 
            // lblPrenomPatRechSoi
            // 
            this.lblPrenomPatRechSoi.AutoSize = true;
            this.lblPrenomPatRechSoi.Location = new System.Drawing.Point(403, 102);
            this.lblPrenomPatRechSoi.Name = "lblPrenomPatRechSoi";
            this.lblPrenomPatRechSoi.Size = new System.Drawing.Size(65, 17);
            this.lblPrenomPatRechSoi.TabIndex = 9;
            this.lblPrenomPatRechSoi.Text = "Prénom :";
            // 
            // tbPrenomPatRechSoiSup
            // 
            this.tbPrenomPatRechSoiSup.Location = new System.Drawing.Point(406, 123);
            this.tbPrenomPatRechSoiSup.Name = "tbPrenomPatRechSoiSup";
            this.tbPrenomPatRechSoiSup.Size = new System.Drawing.Size(200, 23);
            this.tbPrenomPatRechSoiSup.TabIndex = 8;
            // 
            // btnChercherSoiSup
            // 
            this.btnChercherSoiSup.Location = new System.Drawing.Point(317, 220);
            this.btnChercherSoiSup.Name = "btnChercherSoiSup";
            this.btnChercherSoiSup.Size = new System.Drawing.Size(126, 33);
            this.btnChercherSoiSup.TabIndex = 7;
            this.btnChercherSoiSup.Text = "C H E R C H E R";
            this.btnChercherSoiSup.UseVisualStyleBackColor = true;
            this.btnChercherSoiSup.Click += new System.EventHandler(this.btnChercherSoiSup_Click);
            // 
            // lblResultatRechercheOpe
            // 
            this.lblResultatRechercheOpe.AutoSize = true;
            this.lblResultatRechercheOpe.Location = new System.Drawing.Point(6, 254);
            this.lblResultatRechercheOpe.Name = "lblResultatRechercheOpe";
            this.lblResultatRechercheOpe.Size = new System.Drawing.Size(68, 17);
            this.lblResultatRechercheOpe.TabIndex = 6;
            this.lblResultatRechercheOpe.Text = "Résultat :";
            // 
            // lblNomPatRechSoi
            // 
            this.lblNomPatRechSoi.AutoSize = true;
            this.lblNomPatRechSoi.Location = new System.Drawing.Point(183, 103);
            this.lblNomPatRechSoi.Name = "lblNomPatRechSoi";
            this.lblNomPatRechSoi.Size = new System.Drawing.Size(45, 17);
            this.lblNomPatRechSoi.TabIndex = 3;
            this.lblNomPatRechSoi.Text = "Nom :";
            // 
            // tbNomPatRechSoiSup
            // 
            this.tbNomPatRechSoiSup.Location = new System.Drawing.Point(186, 123);
            this.tbNomPatRechSoiSup.Name = "tbNomPatRechSoiSup";
            this.tbNomPatRechSoiSup.Size = new System.Drawing.Size(200, 23);
            this.tbNomPatRechSoiSup.TabIndex = 0;
            // 
            // EcranSuppriSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.btnAnnulerSupSoi);
            this.Controls.Add(this.btnConfirmerSupSoi);
            this.Controls.Add(this.gbRechercheSoiSup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranSuppriSoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Suppression d\'une opération";
            this.Load += new System.EventHandler(this.EcanSuppriSoin_Load);
            this.gbRechercheSoiSup.ResumeLayout(false);
            this.gbRechercheSoiSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResRecSoinSup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnnulerSupSoi;
        private System.Windows.Forms.Button btnConfirmerSupSoi;
        private System.Windows.Forms.GroupBox gbRechercheSoiSup;
        private System.Windows.Forms.Button btnValiderDateOpeOccpSup;
        private System.Windows.Forms.TextBox tbDateOperationOccSup;
        private System.Windows.Forms.DataGridView dgvResRecSoinSup;
        private System.Windows.Forms.DateTimePicker dtpDateOpeRechercheOccSup;
        private System.Windows.Forms.Label lblRechercheDateOperation;
        private System.Windows.Forms.Label lblRecherchePat;
        private System.Windows.Forms.Label lblPrenomPatRechSoi;
        private System.Windows.Forms.TextBox tbPrenomPatRechSoiSup;
        private System.Windows.Forms.Button btnChercherSoiSup;
        private System.Windows.Forms.Label lblResultatRechercheOpe;
        private System.Windows.Forms.Label lblNomPatRechSoi;
        private System.Windows.Forms.TextBox tbNomPatRechSoiSup;
        private System.Windows.Forms.Label lblRechercheMed;
        private System.Windows.Forms.Label lblPrenomMedRechSoi;
        private System.Windows.Forms.TextBox tbPrenomMedRechSoiSup;
        private System.Windows.Forms.Label lblNomMedRechSoi;
        private System.Windows.Forms.TextBox tbNomMedRechSoiSup;
    }
}