namespace SD_Gestion_Hopital
{
    partial class EcranModifSoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranModifSoin));
            this.gbModifMedSoi = new System.Windows.Forms.GroupBox();
            this.btnModifMedSoi = new System.Windows.Forms.Button();
            this.dgvMedecinsSoi = new System.Windows.Forms.DataGridView();
            this.gbModifPatSoi = new System.Windows.Forms.GroupBox();
            this.btnModifPatSoi = new System.Windows.Forms.Button();
            this.dgvPatientsSoi = new System.Windows.Forms.DataGridView();
            this.gbModifSoi = new System.Windows.Forms.GroupBox();
            this.btnModifDateSortieOcc = new System.Windows.Forms.Button();
            this.btnModifDateEntreeOcc = new System.Windows.Forms.Button();
            this.tbModifSoiDateAuthSortie = new System.Windows.Forms.TextBox();
            this.monthCalendarModifSoi = new System.Windows.Forms.MonthCalendar();
            this.tbModifSoiDateOperation = new System.Windows.Forms.TextBox();
            this.lblFicheModifSoiIDMed = new System.Windows.Forms.Label();
            this.tbModifSoiIDMed = new System.Windows.Forms.TextBox();
            this.lblFicheModifSoiIDPat = new System.Windows.Forms.Label();
            this.tbModifSoiIDPat = new System.Windows.Forms.TextBox();
            this.lblFicheModifSoiPrixOperation = new System.Windows.Forms.Label();
            this.lblFicheModifSoiDateAuthSortie = new System.Windows.Forms.Label();
            this.lblFicheModifSoiDateOperation = new System.Windows.Forms.Label();
            this.lblFicheModifSoiID = new System.Windows.Forms.Label();
            this.tbModifSoiPrixOperation = new System.Windows.Forms.TextBox();
            this.tbModifIDSoi = new System.Windows.Forms.TextBox();
            this.btnAnnulerModifSoi = new System.Windows.Forms.Button();
            this.btnConfirmerModifSoi = new System.Windows.Forms.Button();
            this.gbAfficherSoinModif = new System.Windows.Forms.GroupBox();
            this.btnAjouterSoinModif = new System.Windows.Forms.Button();
            this.dgvSoiModif = new System.Windows.Forms.DataGridView();
            this.gbModifMedSoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecinsSoi)).BeginInit();
            this.gbModifPatSoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsSoi)).BeginInit();
            this.gbModifSoi.SuspendLayout();
            this.gbAfficherSoinModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoiModif)).BeginInit();
            this.SuspendLayout();
            // 
            // gbModifMedSoi
            // 
            this.gbModifMedSoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbModifMedSoi.Controls.Add(this.btnModifMedSoi);
            this.gbModifMedSoi.Controls.Add(this.dgvMedecinsSoi);
            this.gbModifMedSoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModifMedSoi.Location = new System.Drawing.Point(794, 299);
            this.gbModifMedSoi.Name = "gbModifMedSoi";
            this.gbModifMedSoi.Size = new System.Drawing.Size(393, 292);
            this.gbModifMedSoi.TabIndex = 20;
            this.gbModifMedSoi.TabStop = false;
            this.gbModifMedSoi.Text = "Liste des médecins :";
            // 
            // btnModifMedSoi
            // 
            this.btnModifMedSoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifMedSoi.Location = new System.Drawing.Point(122, 240);
            this.btnModifMedSoi.Name = "btnModifMedSoi";
            this.btnModifMedSoi.Size = new System.Drawing.Size(158, 42);
            this.btnModifMedSoi.TabIndex = 6;
            this.btnModifMedSoi.Text = "<----    M O D I F I E R";
            this.btnModifMedSoi.UseVisualStyleBackColor = true;
            this.btnModifMedSoi.Click += new System.EventHandler(this.btnModifMedSoi_Click);
            // 
            // dgvMedecinsSoi
            // 
            this.dgvMedecinsSoi.AllowUserToAddRows = false;
            this.dgvMedecinsSoi.AllowUserToDeleteRows = false;
            this.dgvMedecinsSoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedecinsSoi.Location = new System.Drawing.Point(6, 17);
            this.dgvMedecinsSoi.Name = "dgvMedecinsSoi";
            this.dgvMedecinsSoi.ReadOnly = true;
            this.dgvMedecinsSoi.Size = new System.Drawing.Size(381, 217);
            this.dgvMedecinsSoi.TabIndex = 0;
            // 
            // gbModifPatSoi
            // 
            this.gbModifPatSoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbModifPatSoi.Controls.Add(this.btnModifPatSoi);
            this.gbModifPatSoi.Controls.Add(this.dgvPatientsSoi);
            this.gbModifPatSoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModifPatSoi.Location = new System.Drawing.Point(395, 299);
            this.gbModifPatSoi.Name = "gbModifPatSoi";
            this.gbModifPatSoi.Size = new System.Drawing.Size(393, 292);
            this.gbModifPatSoi.TabIndex = 19;
            this.gbModifPatSoi.TabStop = false;
            this.gbModifPatSoi.Text = "Liste des patients :";
            // 
            // btnModifPatSoi
            // 
            this.btnModifPatSoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifPatSoi.Location = new System.Drawing.Point(114, 242);
            this.btnModifPatSoi.Name = "btnModifPatSoi";
            this.btnModifPatSoi.Size = new System.Drawing.Size(158, 42);
            this.btnModifPatSoi.TabIndex = 6;
            this.btnModifPatSoi.Text = "<----    M O D I F I E R";
            this.btnModifPatSoi.UseVisualStyleBackColor = true;
            this.btnModifPatSoi.Click += new System.EventHandler(this.btnModifPatSoi_Click);
            // 
            // dgvPatientsSoi
            // 
            this.dgvPatientsSoi.AllowUserToAddRows = false;
            this.dgvPatientsSoi.AllowUserToDeleteRows = false;
            this.dgvPatientsSoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientsSoi.Location = new System.Drawing.Point(6, 19);
            this.dgvPatientsSoi.Name = "dgvPatientsSoi";
            this.dgvPatientsSoi.ReadOnly = true;
            this.dgvPatientsSoi.Size = new System.Drawing.Size(381, 217);
            this.dgvPatientsSoi.TabIndex = 0;
            // 
            // gbModifSoi
            // 
            this.gbModifSoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbModifSoi.Controls.Add(this.btnModifDateSortieOcc);
            this.gbModifSoi.Controls.Add(this.btnModifDateEntreeOcc);
            this.gbModifSoi.Controls.Add(this.tbModifSoiDateAuthSortie);
            this.gbModifSoi.Controls.Add(this.monthCalendarModifSoi);
            this.gbModifSoi.Controls.Add(this.tbModifSoiDateOperation);
            this.gbModifSoi.Controls.Add(this.lblFicheModifSoiIDMed);
            this.gbModifSoi.Controls.Add(this.tbModifSoiIDMed);
            this.gbModifSoi.Controls.Add(this.lblFicheModifSoiIDPat);
            this.gbModifSoi.Controls.Add(this.tbModifSoiIDPat);
            this.gbModifSoi.Controls.Add(this.lblFicheModifSoiPrixOperation);
            this.gbModifSoi.Controls.Add(this.lblFicheModifSoiDateAuthSortie);
            this.gbModifSoi.Controls.Add(this.lblFicheModifSoiDateOperation);
            this.gbModifSoi.Controls.Add(this.lblFicheModifSoiID);
            this.gbModifSoi.Controls.Add(this.tbModifSoiPrixOperation);
            this.gbModifSoi.Controls.Add(this.tbModifIDSoi);
            this.gbModifSoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModifSoi.Location = new System.Drawing.Point(12, 12);
            this.gbModifSoi.Name = "gbModifSoi";
            this.gbModifSoi.Size = new System.Drawing.Size(377, 579);
            this.gbModifSoi.TabIndex = 18;
            this.gbModifSoi.TabStop = false;
            this.gbModifSoi.Text = "Fiche d\'opération :";
            // 
            // btnModifDateSortieOcc
            // 
            this.btnModifDateSortieOcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifDateSortieOcc.Location = new System.Drawing.Point(172, 473);
            this.btnModifDateSortieOcc.Name = "btnModifDateSortieOcc";
            this.btnModifDateSortieOcc.Size = new System.Drawing.Size(120, 34);
            this.btnModifDateSortieOcc.TabIndex = 35;
            this.btnModifDateSortieOcc.Text = "Modifier authorisation de sortie";
            this.btnModifDateSortieOcc.UseVisualStyleBackColor = true;
            this.btnModifDateSortieOcc.Click += new System.EventHandler(this.btnModifDateSortieOcc_Click);
            // 
            // btnModifDateEntreeOcc
            // 
            this.btnModifDateEntreeOcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifDateEntreeOcc.Location = new System.Drawing.Point(43, 473);
            this.btnModifDateEntreeOcc.Name = "btnModifDateEntreeOcc";
            this.btnModifDateEntreeOcc.Size = new System.Drawing.Size(113, 34);
            this.btnModifDateEntreeOcc.TabIndex = 34;
            this.btnModifDateEntreeOcc.Text = "Modifier date opération";
            this.btnModifDateEntreeOcc.UseVisualStyleBackColor = true;
            this.btnModifDateEntreeOcc.Click += new System.EventHandler(this.btnModifDateEntreeOcc_Click);
            // 
            // tbModifSoiDateAuthSortie
            // 
            this.tbModifSoiDateAuthSortie.Location = new System.Drawing.Point(43, 267);
            this.tbModifSoiDateAuthSortie.Name = "tbModifSoiDateAuthSortie";
            this.tbModifSoiDateAuthSortie.ReadOnly = true;
            this.tbModifSoiDateAuthSortie.Size = new System.Drawing.Size(155, 23);
            this.tbModifSoiDateAuthSortie.TabIndex = 33;
            // 
            // monthCalendarModifSoi
            // 
            this.monthCalendarModifSoi.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendarModifSoi.Location = new System.Drawing.Point(43, 299);
            this.monthCalendarModifSoi.Name = "monthCalendarModifSoi";
            this.monthCalendarModifSoi.ShowWeekNumbers = true;
            this.monthCalendarModifSoi.TabIndex = 32;
            // 
            // tbModifSoiDateOperation
            // 
            this.tbModifSoiDateOperation.Location = new System.Drawing.Point(43, 214);
            this.tbModifSoiDateOperation.Name = "tbModifSoiDateOperation";
            this.tbModifSoiDateOperation.ReadOnly = true;
            this.tbModifSoiDateOperation.Size = new System.Drawing.Size(155, 23);
            this.tbModifSoiDateOperation.TabIndex = 31;
            // 
            // lblFicheModifSoiIDMed
            // 
            this.lblFicheModifSoiIDMed.AutoSize = true;
            this.lblFicheModifSoiIDMed.Location = new System.Drawing.Point(40, 139);
            this.lblFicheModifSoiIDMed.Name = "lblFicheModifSoiIDMed";
            this.lblFicheModifSoiIDMed.Size = new System.Drawing.Size(86, 17);
            this.lblFicheModifSoiIDMed.TabIndex = 30;
            this.lblFicheModifSoiIDMed.Text = "ID Médecin :";
            // 
            // tbModifSoiIDMed
            // 
            this.tbModifSoiIDMed.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbModifSoiIDMed.Location = new System.Drawing.Point(43, 159);
            this.tbModifSoiIDMed.Name = "tbModifSoiIDMed";
            this.tbModifSoiIDMed.ReadOnly = true;
            this.tbModifSoiIDMed.Size = new System.Drawing.Size(155, 23);
            this.tbModifSoiIDMed.TabIndex = 29;
            // 
            // lblFicheModifSoiIDPat
            // 
            this.lblFicheModifSoiIDPat.AutoSize = true;
            this.lblFicheModifSoiIDPat.Location = new System.Drawing.Point(40, 85);
            this.lblFicheModifSoiIDPat.Name = "lblFicheModifSoiIDPat";
            this.lblFicheModifSoiIDPat.Size = new System.Drawing.Size(77, 17);
            this.lblFicheModifSoiIDPat.TabIndex = 28;
            this.lblFicheModifSoiIDPat.Text = "ID Patient :";
            // 
            // tbModifSoiIDPat
            // 
            this.tbModifSoiIDPat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbModifSoiIDPat.Location = new System.Drawing.Point(43, 105);
            this.tbModifSoiIDPat.Name = "tbModifSoiIDPat";
            this.tbModifSoiIDPat.ReadOnly = true;
            this.tbModifSoiIDPat.Size = new System.Drawing.Size(155, 23);
            this.tbModifSoiIDPat.TabIndex = 27;
            // 
            // lblFicheModifSoiPrixOperation
            // 
            this.lblFicheModifSoiPrixOperation.AutoSize = true;
            this.lblFicheModifSoiPrixOperation.Location = new System.Drawing.Point(40, 525);
            this.lblFicheModifSoiPrixOperation.Name = "lblFicheModifSoiPrixOperation";
            this.lblFicheModifSoiPrixOperation.Size = new System.Drawing.Size(129, 17);
            this.lblFicheModifSoiPrixOperation.TabIndex = 26;
            this.lblFicheModifSoiPrixOperation.Text = "Prix de l\'opération :";
            // 
            // lblFicheModifSoiDateAuthSortie
            // 
            this.lblFicheModifSoiDateAuthSortie.AutoSize = true;
            this.lblFicheModifSoiDateAuthSortie.Location = new System.Drawing.Point(40, 247);
            this.lblFicheModifSoiDateAuthSortie.Name = "lblFicheModifSoiDateAuthSortie";
            this.lblFicheModifSoiDateAuthSortie.Size = new System.Drawing.Size(116, 17);
            this.lblFicheModifSoiDateAuthSortie.TabIndex = 25;
            this.lblFicheModifSoiDateAuthSortie.Text = "Sortie prévue le :";
            // 
            // lblFicheModifSoiDateOperation
            // 
            this.lblFicheModifSoiDateOperation.AutoSize = true;
            this.lblFicheModifSoiDateOperation.Location = new System.Drawing.Point(40, 194);
            this.lblFicheModifSoiDateOperation.Name = "lblFicheModifSoiDateOperation";
            this.lblFicheModifSoiDateOperation.Size = new System.Drawing.Size(121, 17);
            this.lblFicheModifSoiDateOperation.TabIndex = 24;
            this.lblFicheModifSoiDateOperation.Text = "Date d\'opération :";
            // 
            // lblFicheModifSoiID
            // 
            this.lblFicheModifSoiID.AutoSize = true;
            this.lblFicheModifSoiID.Location = new System.Drawing.Point(40, 29);
            this.lblFicheModifSoiID.Name = "lblFicheModifSoiID";
            this.lblFicheModifSoiID.Size = new System.Drawing.Size(29, 17);
            this.lblFicheModifSoiID.TabIndex = 23;
            this.lblFicheModifSoiID.Text = "ID :";
            // 
            // tbModifSoiPrixOperation
            // 
            this.tbModifSoiPrixOperation.Location = new System.Drawing.Point(43, 545);
            this.tbModifSoiPrixOperation.Name = "tbModifSoiPrixOperation";
            this.tbModifSoiPrixOperation.Size = new System.Drawing.Size(155, 23);
            this.tbModifSoiPrixOperation.TabIndex = 22;
            // 
            // tbModifIDSoi
            // 
            this.tbModifIDSoi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbModifIDSoi.Location = new System.Drawing.Point(43, 49);
            this.tbModifIDSoi.Name = "tbModifIDSoi";
            this.tbModifIDSoi.ReadOnly = true;
            this.tbModifIDSoi.Size = new System.Drawing.Size(155, 23);
            this.tbModifIDSoi.TabIndex = 21;
            // 
            // btnAnnulerModifSoi
            // 
            this.btnAnnulerModifSoi.Location = new System.Drawing.Point(231, 597);
            this.btnAnnulerModifSoi.Name = "btnAnnulerModifSoi";
            this.btnAnnulerModifSoi.Size = new System.Drawing.Size(158, 42);
            this.btnAnnulerModifSoi.TabIndex = 17;
            this.btnAnnulerModifSoi.Text = "A N N U L E R";
            this.btnAnnulerModifSoi.UseVisualStyleBackColor = true;
            this.btnAnnulerModifSoi.Click += new System.EventHandler(this.btnAnnulerModifSoi_Click);
            // 
            // btnConfirmerModifSoi
            // 
            this.btnConfirmerModifSoi.Location = new System.Drawing.Point(12, 597);
            this.btnConfirmerModifSoi.Name = "btnConfirmerModifSoi";
            this.btnConfirmerModifSoi.Size = new System.Drawing.Size(158, 42);
            this.btnConfirmerModifSoi.TabIndex = 16;
            this.btnConfirmerModifSoi.Text = "C O N F I R M E R";
            this.btnConfirmerModifSoi.UseVisualStyleBackColor = true;
            this.btnConfirmerModifSoi.Click += new System.EventHandler(this.btnConfirmerModifSoi_Click);
            // 
            // gbAfficherSoinModif
            // 
            this.gbAfficherSoinModif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbAfficherSoinModif.Controls.Add(this.btnAjouterSoinModif);
            this.gbAfficherSoinModif.Controls.Add(this.dgvSoiModif);
            this.gbAfficherSoinModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAfficherSoinModif.Location = new System.Drawing.Point(395, 12);
            this.gbAfficherSoinModif.Name = "gbAfficherSoinModif";
            this.gbAfficherSoinModif.Size = new System.Drawing.Size(393, 280);
            this.gbAfficherSoinModif.TabIndex = 21;
            this.gbAfficherSoinModif.TabStop = false;
            this.gbAfficherSoinModif.Text = "Liste des opérations :";
            // 
            // btnAjouterSoinModif
            // 
            this.btnAjouterSoinModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterSoinModif.Location = new System.Drawing.Point(114, 232);
            this.btnAjouterSoinModif.Name = "btnAjouterSoinModif";
            this.btnAjouterSoinModif.Size = new System.Drawing.Size(158, 42);
            this.btnAjouterSoinModif.TabIndex = 6;
            this.btnAjouterSoinModif.Text = "<----    M O D I F I E R";
            this.btnAjouterSoinModif.UseVisualStyleBackColor = true;
            this.btnAjouterSoinModif.Click += new System.EventHandler(this.btnAjouterSoinModif_Click);
            // 
            // dgvSoiModif
            // 
            this.dgvSoiModif.AllowUserToAddRows = false;
            this.dgvSoiModif.AllowUserToDeleteRows = false;
            this.dgvSoiModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoiModif.Location = new System.Drawing.Point(6, 19);
            this.dgvSoiModif.Name = "dgvSoiModif";
            this.dgvSoiModif.ReadOnly = true;
            this.dgvSoiModif.Size = new System.Drawing.Size(381, 207);
            this.dgvSoiModif.TabIndex = 0;
            // 
            // EcranModifSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 654);
            this.Controls.Add(this.gbAfficherSoinModif);
            this.Controls.Add(this.gbModifMedSoi);
            this.Controls.Add(this.gbModifPatSoi);
            this.Controls.Add(this.gbModifSoi);
            this.Controls.Add(this.btnAnnulerModifSoi);
            this.Controls.Add(this.btnConfirmerModifSoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranModifSoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modification d\'une opération";
            this.Load += new System.EventHandler(this.EcranModifSoin_Load);
            this.gbModifMedSoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecinsSoi)).EndInit();
            this.gbModifPatSoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsSoi)).EndInit();
            this.gbModifSoi.ResumeLayout(false);
            this.gbModifSoi.PerformLayout();
            this.gbAfficherSoinModif.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoiModif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbModifMedSoi;
        private System.Windows.Forms.Button btnModifMedSoi;
        private System.Windows.Forms.DataGridView dgvMedecinsSoi;
        private System.Windows.Forms.GroupBox gbModifPatSoi;
        private System.Windows.Forms.Button btnModifPatSoi;
        private System.Windows.Forms.DataGridView dgvPatientsSoi;
        private System.Windows.Forms.GroupBox gbModifSoi;
        private System.Windows.Forms.Button btnAnnulerModifSoi;
        private System.Windows.Forms.Button btnConfirmerModifSoi;
        private System.Windows.Forms.GroupBox gbAfficherSoinModif;
        private System.Windows.Forms.Button btnAjouterSoinModif;
        private System.Windows.Forms.DataGridView dgvSoiModif;
        private System.Windows.Forms.Button btnModifDateSortieOcc;
        private System.Windows.Forms.Button btnModifDateEntreeOcc;
        private System.Windows.Forms.TextBox tbModifSoiDateAuthSortie;
        private System.Windows.Forms.MonthCalendar monthCalendarModifSoi;
        private System.Windows.Forms.TextBox tbModifSoiDateOperation;
        private System.Windows.Forms.Label lblFicheModifSoiIDMed;
        private System.Windows.Forms.TextBox tbModifSoiIDMed;
        private System.Windows.Forms.Label lblFicheModifSoiIDPat;
        private System.Windows.Forms.TextBox tbModifSoiIDPat;
        private System.Windows.Forms.Label lblFicheModifSoiPrixOperation;
        private System.Windows.Forms.Label lblFicheModifSoiDateAuthSortie;
        private System.Windows.Forms.Label lblFicheModifSoiDateOperation;
        private System.Windows.Forms.Label lblFicheModifSoiID;
        private System.Windows.Forms.TextBox tbModifSoiPrixOperation;
        private System.Windows.Forms.TextBox tbModifIDSoi;
    }
}