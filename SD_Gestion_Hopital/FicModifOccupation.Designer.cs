namespace SD_Gestion_Hopital
{
    partial class EcranModifOccupation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranModifOccupation));
            this.gbModifChaOcc = new System.Windows.Forms.GroupBox();
            this.btnAjouterChaOccModif = new System.Windows.Forms.Button();
            this.dgvChambresModif = new System.Windows.Forms.DataGridView();
            this.gbModifPatOcc = new System.Windows.Forms.GroupBox();
            this.btnAjouterPatOccModif = new System.Windows.Forms.Button();
            this.dgvPatientsModif = new System.Windows.Forms.DataGridView();
            this.gbModifOcc = new System.Windows.Forms.GroupBox();
            this.btnModifDateSortieOcc = new System.Windows.Forms.Button();
            this.btnModifDateEntreeOcc = new System.Windows.Forms.Button();
            this.tbModifOccDateSortie = new System.Windows.Forms.TextBox();
            this.monthCalendarModifOcc = new System.Windows.Forms.MonthCalendar();
            this.tbModifOccDateEntree = new System.Windows.Forms.TextBox();
            this.lblFicheModifOccIDCha = new System.Windows.Forms.Label();
            this.tbModifOccIDCha = new System.Windows.Forms.TextBox();
            this.lblFicheModifOccIDPat = new System.Windows.Forms.Label();
            this.tbModifOccIDPat = new System.Windows.Forms.TextBox();
            this.lblFicheModifOccPrixJour = new System.Windows.Forms.Label();
            this.lblFicheModifOccDateSortie = new System.Windows.Forms.Label();
            this.lblFicheModifOccDateEntree = new System.Windows.Forms.Label();
            this.lblFicheModifOccID = new System.Windows.Forms.Label();
            this.tbModifOccPrixJour = new System.Windows.Forms.TextBox();
            this.tbModifIDOcc = new System.Windows.Forms.TextBox();
            this.btnAnnulerModifOcc = new System.Windows.Forms.Button();
            this.btnConfirmerModifOcc = new System.Windows.Forms.Button();
            this.gbAfficherOccModif = new System.Windows.Forms.GroupBox();
            this.btnAjouterOccModif = new System.Windows.Forms.Button();
            this.dgvOccModif = new System.Windows.Forms.DataGridView();
            this.gbModifChaOcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambresModif)).BeginInit();
            this.gbModifPatOcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsModif)).BeginInit();
            this.gbModifOcc.SuspendLayout();
            this.gbAfficherOccModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccModif)).BeginInit();
            this.SuspendLayout();
            // 
            // gbModifChaOcc
            // 
            this.gbModifChaOcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbModifChaOcc.Controls.Add(this.btnAjouterChaOccModif);
            this.gbModifChaOcc.Controls.Add(this.dgvChambresModif);
            this.gbModifChaOcc.Location = new System.Drawing.Point(792, 299);
            this.gbModifChaOcc.Name = "gbModifChaOcc";
            this.gbModifChaOcc.Size = new System.Drawing.Size(393, 293);
            this.gbModifChaOcc.TabIndex = 15;
            this.gbModifChaOcc.TabStop = false;
            this.gbModifChaOcc.Text = "Liste des chambres :";
            // 
            // btnAjouterChaOccModif
            // 
            this.btnAjouterChaOccModif.Location = new System.Drawing.Point(135, 245);
            this.btnAjouterChaOccModif.Name = "btnAjouterChaOccModif";
            this.btnAjouterChaOccModif.Size = new System.Drawing.Size(158, 42);
            this.btnAjouterChaOccModif.TabIndex = 6;
            this.btnAjouterChaOccModif.Text = "<----    A J O U T E R";
            this.btnAjouterChaOccModif.UseVisualStyleBackColor = true;
            this.btnAjouterChaOccModif.Click += new System.EventHandler(this.btnAjouterChaOccModif_Click);
            // 
            // dgvChambresModif
            // 
            this.dgvChambresModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChambresModif.Location = new System.Drawing.Point(6, 19);
            this.dgvChambresModif.Name = "dgvChambresModif";
            this.dgvChambresModif.Size = new System.Drawing.Size(381, 216);
            this.dgvChambresModif.TabIndex = 0;
            // 
            // gbModifPatOcc
            // 
            this.gbModifPatOcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbModifPatOcc.Controls.Add(this.btnAjouterPatOccModif);
            this.gbModifPatOcc.Controls.Add(this.dgvPatientsModif);
            this.gbModifPatOcc.Location = new System.Drawing.Point(393, 299);
            this.gbModifPatOcc.Name = "gbModifPatOcc";
            this.gbModifPatOcc.Size = new System.Drawing.Size(393, 293);
            this.gbModifPatOcc.TabIndex = 14;
            this.gbModifPatOcc.TabStop = false;
            this.gbModifPatOcc.Text = "Liste des patients :";
            // 
            // btnAjouterPatOccModif
            // 
            this.btnAjouterPatOccModif.Location = new System.Drawing.Point(119, 245);
            this.btnAjouterPatOccModif.Name = "btnAjouterPatOccModif";
            this.btnAjouterPatOccModif.Size = new System.Drawing.Size(158, 42);
            this.btnAjouterPatOccModif.TabIndex = 6;
            this.btnAjouterPatOccModif.Text = "<----    A J O U T E R";
            this.btnAjouterPatOccModif.UseVisualStyleBackColor = true;
            this.btnAjouterPatOccModif.Click += new System.EventHandler(this.btnAjouterPatOccModif_Click);
            // 
            // dgvPatientsModif
            // 
            this.dgvPatientsModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientsModif.Location = new System.Drawing.Point(6, 19);
            this.dgvPatientsModif.Name = "dgvPatientsModif";
            this.dgvPatientsModif.Size = new System.Drawing.Size(381, 217);
            this.dgvPatientsModif.TabIndex = 0;
            // 
            // gbModifOcc
            // 
            this.gbModifOcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbModifOcc.Controls.Add(this.btnModifDateSortieOcc);
            this.gbModifOcc.Controls.Add(this.btnModifDateEntreeOcc);
            this.gbModifOcc.Controls.Add(this.tbModifOccDateSortie);
            this.gbModifOcc.Controls.Add(this.monthCalendarModifOcc);
            this.gbModifOcc.Controls.Add(this.tbModifOccDateEntree);
            this.gbModifOcc.Controls.Add(this.lblFicheModifOccIDCha);
            this.gbModifOcc.Controls.Add(this.tbModifOccIDCha);
            this.gbModifOcc.Controls.Add(this.lblFicheModifOccIDPat);
            this.gbModifOcc.Controls.Add(this.tbModifOccIDPat);
            this.gbModifOcc.Controls.Add(this.lblFicheModifOccPrixJour);
            this.gbModifOcc.Controls.Add(this.lblFicheModifOccDateSortie);
            this.gbModifOcc.Controls.Add(this.lblFicheModifOccDateEntree);
            this.gbModifOcc.Controls.Add(this.lblFicheModifOccID);
            this.gbModifOcc.Controls.Add(this.tbModifOccPrixJour);
            this.gbModifOcc.Controls.Add(this.tbModifIDOcc);
            this.gbModifOcc.Location = new System.Drawing.Point(10, 13);
            this.gbModifOcc.Name = "gbModifOcc";
            this.gbModifOcc.Size = new System.Drawing.Size(377, 579);
            this.gbModifOcc.TabIndex = 13;
            this.gbModifOcc.TabStop = false;
            this.gbModifOcc.Text = "Fiche de prise en charge :";
            // 
            // btnModifDateSortieOcc
            // 
            this.btnModifDateSortieOcc.Location = new System.Drawing.Point(194, 481);
            this.btnModifDateSortieOcc.Name = "btnModifDateSortieOcc";
            this.btnModifDateSortieOcc.Size = new System.Drawing.Size(100, 23);
            this.btnModifDateSortieOcc.TabIndex = 20;
            this.btnModifDateSortieOcc.Text = "Ajouter Sortie";
            this.btnModifDateSortieOcc.UseVisualStyleBackColor = true;
            this.btnModifDateSortieOcc.Click += new System.EventHandler(this.btnModifDateSortieOcc_Click);
            // 
            // btnModifDateEntreeOcc
            // 
            this.btnModifDateEntreeOcc.Location = new System.Drawing.Point(45, 481);
            this.btnModifDateEntreeOcc.Name = "btnModifDateEntreeOcc";
            this.btnModifDateEntreeOcc.Size = new System.Drawing.Size(100, 23);
            this.btnModifDateEntreeOcc.TabIndex = 19;
            this.btnModifDateEntreeOcc.Text = "Ajouter entrée";
            this.btnModifDateEntreeOcc.UseVisualStyleBackColor = true;
            this.btnModifDateEntreeOcc.Click += new System.EventHandler(this.btnModifDateEntreeOcc_Click);
            // 
            // tbModifOccDateSortie
            // 
            this.tbModifOccDateSortie.Location = new System.Drawing.Point(45, 275);
            this.tbModifOccDateSortie.Name = "tbModifOccDateSortie";
            this.tbModifOccDateSortie.Size = new System.Drawing.Size(100, 20);
            this.tbModifOccDateSortie.TabIndex = 18;
            // 
            // monthCalendarModifOcc
            // 
            this.monthCalendarModifOcc.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendarModifOcc.Location = new System.Drawing.Point(45, 307);
            this.monthCalendarModifOcc.Name = "monthCalendarModifOcc";
            this.monthCalendarModifOcc.ShowWeekNumbers = true;
            this.monthCalendarModifOcc.TabIndex = 17;
            // 
            // tbModifOccDateEntree
            // 
            this.tbModifOccDateEntree.Location = new System.Drawing.Point(45, 222);
            this.tbModifOccDateEntree.Name = "tbModifOccDateEntree";
            this.tbModifOccDateEntree.Size = new System.Drawing.Size(100, 20);
            this.tbModifOccDateEntree.TabIndex = 16;
            // 
            // lblFicheModifOccIDCha
            // 
            this.lblFicheModifOccIDCha.AutoSize = true;
            this.lblFicheModifOccIDCha.Location = new System.Drawing.Point(42, 151);
            this.lblFicheModifOccIDCha.Name = "lblFicheModifOccIDCha";
            this.lblFicheModifOccIDCha.Size = new System.Drawing.Size(95, 13);
            this.lblFicheModifOccIDCha.TabIndex = 12;
            this.lblFicheModifOccIDCha.Text = "ID de la Chambre :";
            // 
            // tbModifOccIDCha
            // 
            this.tbModifOccIDCha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbModifOccIDCha.Location = new System.Drawing.Point(45, 167);
            this.tbModifOccIDCha.Name = "tbModifOccIDCha";
            this.tbModifOccIDCha.ReadOnly = true;
            this.tbModifOccIDCha.Size = new System.Drawing.Size(100, 20);
            this.tbModifOccIDCha.TabIndex = 11;
            // 
            // lblFicheModifOccIDPat
            // 
            this.lblFicheModifOccIDPat.AutoSize = true;
            this.lblFicheModifOccIDPat.Location = new System.Drawing.Point(42, 97);
            this.lblFicheModifOccIDPat.Name = "lblFicheModifOccIDPat";
            this.lblFicheModifOccIDPat.Size = new System.Drawing.Size(74, 13);
            this.lblFicheModifOccIDPat.TabIndex = 10;
            this.lblFicheModifOccIDPat.Text = "ID du patient :";
            // 
            // tbModifOccIDPat
            // 
            this.tbModifOccIDPat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbModifOccIDPat.Location = new System.Drawing.Point(45, 113);
            this.tbModifOccIDPat.Name = "tbModifOccIDPat";
            this.tbModifOccIDPat.ReadOnly = true;
            this.tbModifOccIDPat.Size = new System.Drawing.Size(100, 20);
            this.tbModifOccIDPat.TabIndex = 9;
            // 
            // lblFicheModifOccPrixJour
            // 
            this.lblFicheModifOccPrixJour.AutoSize = true;
            this.lblFicheModifOccPrixJour.Location = new System.Drawing.Point(44, 537);
            this.lblFicheModifOccPrixJour.Name = "lblFicheModifOccPrixJour";
            this.lblFicheModifOccPrixJour.Size = new System.Drawing.Size(75, 13);
            this.lblFicheModifOccPrixJour.TabIndex = 8;
            this.lblFicheModifOccPrixJour.Text = "Prix journalier :";
            // 
            // lblFicheModifOccDateSortie
            // 
            this.lblFicheModifOccDateSortie.AutoSize = true;
            this.lblFicheModifOccDateSortie.Location = new System.Drawing.Point(44, 259);
            this.lblFicheModifOccDateSortie.Name = "lblFicheModifOccDateSortie";
            this.lblFicheModifOccDateSortie.Size = new System.Drawing.Size(79, 13);
            this.lblFicheModifOccDateSortie.TabIndex = 7;
            this.lblFicheModifOccDateSortie.Text = "Date de sortie :";
            // 
            // lblFicheModifOccDateEntree
            // 
            this.lblFicheModifOccDateEntree.AutoSize = true;
            this.lblFicheModifOccDateEntree.Location = new System.Drawing.Point(44, 206);
            this.lblFicheModifOccDateEntree.Name = "lblFicheModifOccDateEntree";
            this.lblFicheModifOccDateEntree.Size = new System.Drawing.Size(77, 13);
            this.lblFicheModifOccDateEntree.TabIndex = 6;
            this.lblFicheModifOccDateEntree.Text = "Date d\'entrée :";
            // 
            // lblFicheModifOccID
            // 
            this.lblFicheModifOccID.AutoSize = true;
            this.lblFicheModifOccID.Location = new System.Drawing.Point(42, 41);
            this.lblFicheModifOccID.Name = "lblFicheModifOccID";
            this.lblFicheModifOccID.Size = new System.Drawing.Size(24, 13);
            this.lblFicheModifOccID.TabIndex = 5;
            this.lblFicheModifOccID.Text = "ID :";
            // 
            // tbModifOccPrixJour
            // 
            this.tbModifOccPrixJour.Location = new System.Drawing.Point(45, 553);
            this.tbModifOccPrixJour.Name = "tbModifOccPrixJour";
            this.tbModifOccPrixJour.Size = new System.Drawing.Size(100, 20);
            this.tbModifOccPrixJour.TabIndex = 3;
            // 
            // tbModifIDOcc
            // 
            this.tbModifIDOcc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbModifIDOcc.Location = new System.Drawing.Point(45, 57);
            this.tbModifIDOcc.Name = "tbModifIDOcc";
            this.tbModifIDOcc.ReadOnly = true;
            this.tbModifIDOcc.Size = new System.Drawing.Size(100, 20);
            this.tbModifIDOcc.TabIndex = 0;
            // 
            // btnAnnulerModifOcc
            // 
            this.btnAnnulerModifOcc.Location = new System.Drawing.Point(229, 598);
            this.btnAnnulerModifOcc.Name = "btnAnnulerModifOcc";
            this.btnAnnulerModifOcc.Size = new System.Drawing.Size(158, 42);
            this.btnAnnulerModifOcc.TabIndex = 12;
            this.btnAnnulerModifOcc.Text = "A N N U L E R";
            this.btnAnnulerModifOcc.UseVisualStyleBackColor = true;
            this.btnAnnulerModifOcc.Click += new System.EventHandler(this.btnAnnulerModifOcc_Click);
            // 
            // btnConfirmerModifOcc
            // 
            this.btnConfirmerModifOcc.Location = new System.Drawing.Point(10, 598);
            this.btnConfirmerModifOcc.Name = "btnConfirmerModifOcc";
            this.btnConfirmerModifOcc.Size = new System.Drawing.Size(158, 42);
            this.btnConfirmerModifOcc.TabIndex = 11;
            this.btnConfirmerModifOcc.Text = "C O N F I R M E R";
            this.btnConfirmerModifOcc.UseVisualStyleBackColor = true;
            this.btnConfirmerModifOcc.Click += new System.EventHandler(this.btnConfirmerModifOcc_Click);
            // 
            // gbAfficherOccModif
            // 
            this.gbAfficherOccModif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbAfficherOccModif.Controls.Add(this.btnAjouterOccModif);
            this.gbAfficherOccModif.Controls.Add(this.dgvOccModif);
            this.gbAfficherOccModif.Location = new System.Drawing.Point(393, 13);
            this.gbAfficherOccModif.Name = "gbAfficherOccModif";
            this.gbAfficherOccModif.Size = new System.Drawing.Size(393, 280);
            this.gbAfficherOccModif.TabIndex = 16;
            this.gbAfficherOccModif.TabStop = false;
            this.gbAfficherOccModif.Text = "Liste des prises en charges :";
            // 
            // btnAjouterOccModif
            // 
            this.btnAjouterOccModif.Location = new System.Drawing.Point(119, 232);
            this.btnAjouterOccModif.Name = "btnAjouterOccModif";
            this.btnAjouterOccModif.Size = new System.Drawing.Size(158, 42);
            this.btnAjouterOccModif.TabIndex = 6;
            this.btnAjouterOccModif.Text = "<----    A J O U T E R";
            this.btnAjouterOccModif.UseVisualStyleBackColor = true;
            this.btnAjouterOccModif.Click += new System.EventHandler(this.btnAjouterOccModif_Click);
            // 
            // dgvOccModif
            // 
            this.dgvOccModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOccModif.Location = new System.Drawing.Point(6, 19);
            this.dgvOccModif.Name = "dgvOccModif";
            this.dgvOccModif.Size = new System.Drawing.Size(381, 207);
            this.dgvOccModif.TabIndex = 0;
            // 
            // EcranModifOccupation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 646);
            this.Controls.Add(this.gbAfficherOccModif);
            this.Controls.Add(this.gbModifChaOcc);
            this.Controls.Add(this.gbModifPatOcc);
            this.Controls.Add(this.gbModifOcc);
            this.Controls.Add(this.btnAnnulerModifOcc);
            this.Controls.Add(this.btnConfirmerModifOcc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranModifOccupation";
            this.Text = "Modification d\'une prise en charge";
            this.Load += new System.EventHandler(this.EcranModifOccupation_Load);
            this.gbModifChaOcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambresModif)).EndInit();
            this.gbModifPatOcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsModif)).EndInit();
            this.gbModifOcc.ResumeLayout(false);
            this.gbModifOcc.PerformLayout();
            this.gbAfficherOccModif.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccModif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbModifChaOcc;
        private System.Windows.Forms.Button btnAjouterChaOccModif;
        private System.Windows.Forms.DataGridView dgvChambresModif;
        private System.Windows.Forms.GroupBox gbModifPatOcc;
        private System.Windows.Forms.Button btnAjouterPatOccModif;
        private System.Windows.Forms.DataGridView dgvPatientsModif;
        private System.Windows.Forms.GroupBox gbModifOcc;
        private System.Windows.Forms.Button btnModifDateSortieOcc;
        private System.Windows.Forms.Button btnModifDateEntreeOcc;
        private System.Windows.Forms.TextBox tbModifOccDateSortie;
        private System.Windows.Forms.MonthCalendar monthCalendarModifOcc;
        private System.Windows.Forms.TextBox tbModifOccDateEntree;
        private System.Windows.Forms.Label lblFicheModifOccIDCha;
        private System.Windows.Forms.TextBox tbModifOccIDCha;
        private System.Windows.Forms.Label lblFicheModifOccIDPat;
        private System.Windows.Forms.TextBox tbModifOccIDPat;
        private System.Windows.Forms.Label lblFicheModifOccPrixJour;
        private System.Windows.Forms.Label lblFicheModifOccDateSortie;
        private System.Windows.Forms.Label lblFicheModifOccDateEntree;
        private System.Windows.Forms.Label lblFicheModifOccID;
        private System.Windows.Forms.TextBox tbModifOccPrixJour;
        private System.Windows.Forms.TextBox tbModifIDOcc;
        private System.Windows.Forms.Button btnAnnulerModifOcc;
        private System.Windows.Forms.Button btnConfirmerModifOcc;
        private System.Windows.Forms.GroupBox gbAfficherOccModif;
        private System.Windows.Forms.Button btnAjouterOccModif;
        private System.Windows.Forms.DataGridView dgvOccModif;
    }
}