namespace SD_Gestion_Hopital
{
    partial class EcranAjoutSoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranAjoutSoin));
            this.gbAjMedSoi = new System.Windows.Forms.GroupBox();
            this.btnAjouterMedSoi = new System.Windows.Forms.Button();
            this.dgvMedecinsSoi = new System.Windows.Forms.DataGridView();
            this.gbAjPatSoi = new System.Windows.Forms.GroupBox();
            this.btnAjouterPatSoi = new System.Windows.Forms.Button();
            this.dgvPatientsSoi = new System.Windows.Forms.DataGridView();
            this.gbAjSoi = new System.Windows.Forms.GroupBox();
            this.btnAjDateSortieOcc = new System.Windows.Forms.Button();
            this.btnAjDateEntreeOcc = new System.Windows.Forms.Button();
            this.tbAjSoiDateAuthSortie = new System.Windows.Forms.TextBox();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.tbAjSoiDateOperation = new System.Windows.Forms.TextBox();
            this.lblFicheAjSoiIDMed = new System.Windows.Forms.Label();
            this.tbAjSoiIDMed = new System.Windows.Forms.TextBox();
            this.lblFicheAjSoiIDPat = new System.Windows.Forms.Label();
            this.tbAjSoiIDPat = new System.Windows.Forms.TextBox();
            this.lblFicheAjSoiPrixOperation = new System.Windows.Forms.Label();
            this.lblFicheAjSoiDateAuthSortie = new System.Windows.Forms.Label();
            this.lblFicheAjSoiDateOperation = new System.Windows.Forms.Label();
            this.lblFicheAjSoiID = new System.Windows.Forms.Label();
            this.tbAjSoiPrixOperation = new System.Windows.Forms.TextBox();
            this.tbIDSoi = new System.Windows.Forms.TextBox();
            this.btnAnnulerAjSoi = new System.Windows.Forms.Button();
            this.btnConfirmerAjSoi = new System.Windows.Forms.Button();
            this.gbAjMedSoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecinsSoi)).BeginInit();
            this.gbAjPatSoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsSoi)).BeginInit();
            this.gbAjSoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAjMedSoi
            // 
            this.gbAjMedSoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbAjMedSoi.Controls.Add(this.btnAjouterMedSoi);
            this.gbAjMedSoi.Controls.Add(this.dgvMedecinsSoi);
            this.gbAjMedSoi.Location = new System.Drawing.Point(794, 12);
            this.gbAjMedSoi.Name = "gbAjMedSoi";
            this.gbAjMedSoi.Size = new System.Drawing.Size(393, 378);
            this.gbAjMedSoi.TabIndex = 15;
            this.gbAjMedSoi.TabStop = false;
            this.gbAjMedSoi.Text = "Liste des médecins :";
            // 
            // btnAjouterMedSoi
            // 
            this.btnAjouterMedSoi.Location = new System.Drawing.Point(123, 330);
            this.btnAjouterMedSoi.Name = "btnAjouterMedSoi";
            this.btnAjouterMedSoi.Size = new System.Drawing.Size(158, 42);
            this.btnAjouterMedSoi.TabIndex = 6;
            this.btnAjouterMedSoi.Text = "<----    A J O U T E R";
            this.btnAjouterMedSoi.UseVisualStyleBackColor = true;
            this.btnAjouterMedSoi.Click += new System.EventHandler(this.btnAjouterMedSoi_Click);
            // 
            // dgvMedecinsSoi
            // 
            this.dgvMedecinsSoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedecinsSoi.Location = new System.Drawing.Point(6, 17);
            this.dgvMedecinsSoi.Name = "dgvMedecinsSoi";
            this.dgvMedecinsSoi.Size = new System.Drawing.Size(381, 305);
            this.dgvMedecinsSoi.TabIndex = 0;
            // 
            // gbAjPatSoi
            // 
            this.gbAjPatSoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbAjPatSoi.Controls.Add(this.btnAjouterPatSoi);
            this.gbAjPatSoi.Controls.Add(this.dgvPatientsSoi);
            this.gbAjPatSoi.Location = new System.Drawing.Point(395, 12);
            this.gbAjPatSoi.Name = "gbAjPatSoi";
            this.gbAjPatSoi.Size = new System.Drawing.Size(393, 378);
            this.gbAjPatSoi.TabIndex = 14;
            this.gbAjPatSoi.TabStop = false;
            this.gbAjPatSoi.Text = "Liste des patients :";
            // 
            // btnAjouterPatSoi
            // 
            this.btnAjouterPatSoi.Location = new System.Drawing.Point(123, 330);
            this.btnAjouterPatSoi.Name = "btnAjouterPatSoi";
            this.btnAjouterPatSoi.Size = new System.Drawing.Size(158, 42);
            this.btnAjouterPatSoi.TabIndex = 6;
            this.btnAjouterPatSoi.Text = "<----    A J O U T E R";
            this.btnAjouterPatSoi.UseVisualStyleBackColor = true;
            this.btnAjouterPatSoi.Click += new System.EventHandler(this.btnAjouterPatSoi_Click);
            // 
            // dgvPatientsSoi
            // 
            this.dgvPatientsSoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientsSoi.Location = new System.Drawing.Point(6, 19);
            this.dgvPatientsSoi.Name = "dgvPatientsSoi";
            this.dgvPatientsSoi.Size = new System.Drawing.Size(381, 305);
            this.dgvPatientsSoi.TabIndex = 0;
            // 
            // gbAjSoi
            // 
            this.gbAjSoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbAjSoi.Controls.Add(this.btnAjDateSortieOcc);
            this.gbAjSoi.Controls.Add(this.btnAjDateEntreeOcc);
            this.gbAjSoi.Controls.Add(this.tbAjSoiDateAuthSortie);
            this.gbAjSoi.Controls.Add(this.monthCalendar2);
            this.gbAjSoi.Controls.Add(this.tbAjSoiDateOperation);
            this.gbAjSoi.Controls.Add(this.lblFicheAjSoiIDMed);
            this.gbAjSoi.Controls.Add(this.tbAjSoiIDMed);
            this.gbAjSoi.Controls.Add(this.lblFicheAjSoiIDPat);
            this.gbAjSoi.Controls.Add(this.tbAjSoiIDPat);
            this.gbAjSoi.Controls.Add(this.lblFicheAjSoiPrixOperation);
            this.gbAjSoi.Controls.Add(this.lblFicheAjSoiDateAuthSortie);
            this.gbAjSoi.Controls.Add(this.lblFicheAjSoiDateOperation);
            this.gbAjSoi.Controls.Add(this.lblFicheAjSoiID);
            this.gbAjSoi.Controls.Add(this.tbAjSoiPrixOperation);
            this.gbAjSoi.Controls.Add(this.tbIDSoi);
            this.gbAjSoi.Location = new System.Drawing.Point(12, 12);
            this.gbAjSoi.Name = "gbAjSoi";
            this.gbAjSoi.Size = new System.Drawing.Size(377, 579);
            this.gbAjSoi.TabIndex = 13;
            this.gbAjSoi.TabStop = false;
            this.gbAjSoi.Text = "Fiche d\'opération :";
            // 
            // btnAjDateSortieOcc
            // 
            this.btnAjDateSortieOcc.Location = new System.Drawing.Point(180, 481);
            this.btnAjDateSortieOcc.Name = "btnAjDateSortieOcc";
            this.btnAjDateSortieOcc.Size = new System.Drawing.Size(114, 34);
            this.btnAjDateSortieOcc.TabIndex = 20;
            this.btnAjDateSortieOcc.Text = "Ajouter authorisation de sortie";
            this.btnAjDateSortieOcc.UseVisualStyleBackColor = true;
            this.btnAjDateSortieOcc.Click += new System.EventHandler(this.btnAjDateSortieOcc_Click);
            // 
            // btnAjDateEntreeOcc
            // 
            this.btnAjDateEntreeOcc.Location = new System.Drawing.Point(45, 481);
            this.btnAjDateEntreeOcc.Name = "btnAjDateEntreeOcc";
            this.btnAjDateEntreeOcc.Size = new System.Drawing.Size(113, 34);
            this.btnAjDateEntreeOcc.TabIndex = 19;
            this.btnAjDateEntreeOcc.Text = "Ajouter date opération";
            this.btnAjDateEntreeOcc.UseVisualStyleBackColor = true;
            this.btnAjDateEntreeOcc.Click += new System.EventHandler(this.btnAjDateEntreeOcc_Click);
            // 
            // tbAjSoiDateAuthSortie
            // 
            this.tbAjSoiDateAuthSortie.Location = new System.Drawing.Point(45, 275);
            this.tbAjSoiDateAuthSortie.Name = "tbAjSoiDateAuthSortie";
            this.tbAjSoiDateAuthSortie.ReadOnly = true;
            this.tbAjSoiDateAuthSortie.Size = new System.Drawing.Size(100, 20);
            this.tbAjSoiDateAuthSortie.TabIndex = 18;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar2.Location = new System.Drawing.Point(45, 307);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.ShowWeekNumbers = true;
            this.monthCalendar2.TabIndex = 17;
            // 
            // tbAjSoiDateOperation
            // 
            this.tbAjSoiDateOperation.Location = new System.Drawing.Point(45, 222);
            this.tbAjSoiDateOperation.Name = "tbAjSoiDateOperation";
            this.tbAjSoiDateOperation.ReadOnly = true;
            this.tbAjSoiDateOperation.Size = new System.Drawing.Size(100, 20);
            this.tbAjSoiDateOperation.TabIndex = 16;
            // 
            // lblFicheAjSoiIDMed
            // 
            this.lblFicheAjSoiIDMed.AutoSize = true;
            this.lblFicheAjSoiIDMed.Location = new System.Drawing.Point(42, 151);
            this.lblFicheAjSoiIDMed.Name = "lblFicheAjSoiIDMed";
            this.lblFicheAjSoiIDMed.Size = new System.Drawing.Size(54, 13);
            this.lblFicheAjSoiIDMed.TabIndex = 12;
            this.lblFicheAjSoiIDMed.Text = "Médecin :";
            // 
            // tbAjSoiIDMed
            // 
            this.tbAjSoiIDMed.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbAjSoiIDMed.Location = new System.Drawing.Point(45, 167);
            this.tbAjSoiIDMed.Name = "tbAjSoiIDMed";
            this.tbAjSoiIDMed.ReadOnly = true;
            this.tbAjSoiIDMed.Size = new System.Drawing.Size(100, 20);
            this.tbAjSoiIDMed.TabIndex = 11;
            // 
            // lblFicheAjSoiIDPat
            // 
            this.lblFicheAjSoiIDPat.AutoSize = true;
            this.lblFicheAjSoiIDPat.Location = new System.Drawing.Point(42, 97);
            this.lblFicheAjSoiIDPat.Name = "lblFicheAjSoiIDPat";
            this.lblFicheAjSoiIDPat.Size = new System.Drawing.Size(46, 13);
            this.lblFicheAjSoiIDPat.TabIndex = 10;
            this.lblFicheAjSoiIDPat.Text = "Patient :";
            // 
            // tbAjSoiIDPat
            // 
            this.tbAjSoiIDPat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbAjSoiIDPat.Location = new System.Drawing.Point(45, 113);
            this.tbAjSoiIDPat.Name = "tbAjSoiIDPat";
            this.tbAjSoiIDPat.ReadOnly = true;
            this.tbAjSoiIDPat.Size = new System.Drawing.Size(100, 20);
            this.tbAjSoiIDPat.TabIndex = 9;
            // 
            // lblFicheAjSoiPrixOperation
            // 
            this.lblFicheAjSoiPrixOperation.AutoSize = true;
            this.lblFicheAjSoiPrixOperation.Location = new System.Drawing.Point(44, 537);
            this.lblFicheAjSoiPrixOperation.Name = "lblFicheAjSoiPrixOperation";
            this.lblFicheAjSoiPrixOperation.Size = new System.Drawing.Size(96, 13);
            this.lblFicheAjSoiPrixOperation.TabIndex = 8;
            this.lblFicheAjSoiPrixOperation.Text = "Prix de l\'opération :";
            // 
            // lblFicheAjSoiDateAuthSortie
            // 
            this.lblFicheAjSoiDateAuthSortie.AutoSize = true;
            this.lblFicheAjSoiDateAuthSortie.Location = new System.Drawing.Point(44, 259);
            this.lblFicheAjSoiDateAuthSortie.Name = "lblFicheAjSoiDateAuthSortie";
            this.lblFicheAjSoiDateAuthSortie.Size = new System.Drawing.Size(117, 13);
            this.lblFicheAjSoiDateAuthSortie.TabIndex = 7;
            this.lblFicheAjSoiDateAuthSortie.Text = "Authorisation de sortie :";
            // 
            // lblFicheAjSoiDateOperation
            // 
            this.lblFicheAjSoiDateOperation.AutoSize = true;
            this.lblFicheAjSoiDateOperation.Location = new System.Drawing.Point(44, 206);
            this.lblFicheAjSoiDateOperation.Name = "lblFicheAjSoiDateOperation";
            this.lblFicheAjSoiDateOperation.Size = new System.Drawing.Size(91, 13);
            this.lblFicheAjSoiDateOperation.TabIndex = 6;
            this.lblFicheAjSoiDateOperation.Text = "Date d\'opération :";
            // 
            // lblFicheAjSoiID
            // 
            this.lblFicheAjSoiID.AutoSize = true;
            this.lblFicheAjSoiID.Location = new System.Drawing.Point(42, 41);
            this.lblFicheAjSoiID.Name = "lblFicheAjSoiID";
            this.lblFicheAjSoiID.Size = new System.Drawing.Size(24, 13);
            this.lblFicheAjSoiID.TabIndex = 5;
            this.lblFicheAjSoiID.Text = "ID :";
            // 
            // tbAjSoiPrixOperation
            // 
            this.tbAjSoiPrixOperation.Location = new System.Drawing.Point(45, 553);
            this.tbAjSoiPrixOperation.Name = "tbAjSoiPrixOperation";
            this.tbAjSoiPrixOperation.Size = new System.Drawing.Size(100, 20);
            this.tbAjSoiPrixOperation.TabIndex = 3;
            // 
            // tbIDSoi
            // 
            this.tbIDSoi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbIDSoi.Location = new System.Drawing.Point(45, 57);
            this.tbIDSoi.Name = "tbIDSoi";
            this.tbIDSoi.ReadOnly = true;
            this.tbIDSoi.Size = new System.Drawing.Size(100, 20);
            this.tbIDSoi.TabIndex = 0;
            // 
            // btnAnnulerAjSoi
            // 
            this.btnAnnulerAjSoi.Location = new System.Drawing.Point(231, 597);
            this.btnAnnulerAjSoi.Name = "btnAnnulerAjSoi";
            this.btnAnnulerAjSoi.Size = new System.Drawing.Size(158, 42);
            this.btnAnnulerAjSoi.TabIndex = 12;
            this.btnAnnulerAjSoi.Text = "A N N U L E R";
            this.btnAnnulerAjSoi.UseVisualStyleBackColor = true;
            this.btnAnnulerAjSoi.Click += new System.EventHandler(this.btnAnnulerAjSoi_Click);
            // 
            // btnConfirmerAjSoi
            // 
            this.btnConfirmerAjSoi.Location = new System.Drawing.Point(12, 597);
            this.btnConfirmerAjSoi.Name = "btnConfirmerAjSoi";
            this.btnConfirmerAjSoi.Size = new System.Drawing.Size(158, 42);
            this.btnConfirmerAjSoi.TabIndex = 11;
            this.btnConfirmerAjSoi.Text = "C O N F I R M E R";
            this.btnConfirmerAjSoi.UseVisualStyleBackColor = true;
            this.btnConfirmerAjSoi.Click += new System.EventHandler(this.btnConfirmerAjSoi_Click);
            // 
            // EcranAjoutSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 649);
            this.Controls.Add(this.gbAjMedSoi);
            this.Controls.Add(this.gbAjPatSoi);
            this.Controls.Add(this.gbAjSoi);
            this.Controls.Add(this.btnAnnulerAjSoi);
            this.Controls.Add(this.btnConfirmerAjSoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranAjoutSoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Coordination d\'une opération";
            this.Load += new System.EventHandler(this.EcranAjoutSoin_Load);
            this.gbAjMedSoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecinsSoi)).EndInit();
            this.gbAjPatSoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsSoi)).EndInit();
            this.gbAjSoi.ResumeLayout(false);
            this.gbAjSoi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAjMedSoi;
        private System.Windows.Forms.Button btnAjouterMedSoi;
        private System.Windows.Forms.DataGridView dgvMedecinsSoi;
        private System.Windows.Forms.GroupBox gbAjPatSoi;
        private System.Windows.Forms.Button btnAjouterPatSoi;
        private System.Windows.Forms.DataGridView dgvPatientsSoi;
        private System.Windows.Forms.GroupBox gbAjSoi;
        private System.Windows.Forms.Button btnAjDateSortieOcc;
        private System.Windows.Forms.Button btnAjDateEntreeOcc;
        private System.Windows.Forms.TextBox tbAjSoiDateAuthSortie;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.TextBox tbAjSoiDateOperation;
        private System.Windows.Forms.Label lblFicheAjSoiIDMed;
        private System.Windows.Forms.TextBox tbAjSoiIDMed;
        private System.Windows.Forms.Label lblFicheAjSoiIDPat;
        private System.Windows.Forms.TextBox tbAjSoiIDPat;
        private System.Windows.Forms.Label lblFicheAjSoiPrixOperation;
        private System.Windows.Forms.Label lblFicheAjSoiDateAuthSortie;
        private System.Windows.Forms.Label lblFicheAjSoiDateOperation;
        private System.Windows.Forms.Label lblFicheAjSoiID;
        private System.Windows.Forms.TextBox tbAjSoiPrixOperation;
        private System.Windows.Forms.TextBox tbIDSoi;
        private System.Windows.Forms.Button btnAnnulerAjSoi;
        private System.Windows.Forms.Button btnConfirmerAjSoi;
    }
}