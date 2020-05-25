namespace SD_Gestion_Hopital
{
    partial class EcranAjoutOccupation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranAjoutOccupation));
            this.gbAjPatOcc = new System.Windows.Forms.GroupBox();
            this.btnAjouterPatOcc = new System.Windows.Forms.Button();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.gbAjOcc = new System.Windows.Forms.GroupBox();
            this.btnAjDateSortieOcc = new System.Windows.Forms.Button();
            this.btnAjDateEntreeOcc = new System.Windows.Forms.Button();
            this.tbAjOccDateSortie = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tbAjOccDateEntree = new System.Windows.Forms.TextBox();
            this.lblFicheAjOccIDCha = new System.Windows.Forms.Label();
            this.tbAjOccIDCha = new System.Windows.Forms.TextBox();
            this.lblFicheAjOccIDPat = new System.Windows.Forms.Label();
            this.tbAjOccIDPat = new System.Windows.Forms.TextBox();
            this.lblFicheAjOccPrixJour = new System.Windows.Forms.Label();
            this.lblFicheAjOccDateSortie = new System.Windows.Forms.Label();
            this.lblFicheAjOccDateEntree = new System.Windows.Forms.Label();
            this.lblFicheAjOccID = new System.Windows.Forms.Label();
            this.tbAjOccPrixJour = new System.Windows.Forms.TextBox();
            this.tbIDOcc = new System.Windows.Forms.TextBox();
            this.btnAnnulerAjOcc = new System.Windows.Forms.Button();
            this.btnConfirmerAjOcc = new System.Windows.Forms.Button();
            this.gbAjChaOcc = new System.Windows.Forms.GroupBox();
            this.btnAjouterChaOcc = new System.Windows.Forms.Button();
            this.dgvChambres = new System.Windows.Forms.DataGridView();
            this.gbAjPatOcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.gbAjOcc.SuspendLayout();
            this.gbAjChaOcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambres)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAjPatOcc
            // 
            this.gbAjPatOcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbAjPatOcc.Controls.Add(this.btnAjouterPatOcc);
            this.gbAjPatOcc.Controls.Add(this.dgvPatients);
            this.gbAjPatOcc.Location = new System.Drawing.Point(395, 12);
            this.gbAjPatOcc.Name = "gbAjPatOcc";
            this.gbAjPatOcc.Size = new System.Drawing.Size(393, 378);
            this.gbAjPatOcc.TabIndex = 9;
            this.gbAjPatOcc.TabStop = false;
            this.gbAjPatOcc.Text = "Liste des patients";
            // 
            // btnAjouterPatOcc
            // 
            this.btnAjouterPatOcc.Location = new System.Drawing.Point(123, 330);
            this.btnAjouterPatOcc.Name = "btnAjouterPatOcc";
            this.btnAjouterPatOcc.Size = new System.Drawing.Size(158, 42);
            this.btnAjouterPatOcc.TabIndex = 6;
            this.btnAjouterPatOcc.Text = "<----    A J O U T E R";
            this.btnAjouterPatOcc.UseVisualStyleBackColor = true;
            this.btnAjouterPatOcc.Click += new System.EventHandler(this.btnAjouterPatOcc_Click);
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(6, 19);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.Size = new System.Drawing.Size(381, 305);
            this.dgvPatients.TabIndex = 0;
            // 
            // gbAjOcc
            // 
            this.gbAjOcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbAjOcc.Controls.Add(this.btnAjDateSortieOcc);
            this.gbAjOcc.Controls.Add(this.btnAjDateEntreeOcc);
            this.gbAjOcc.Controls.Add(this.tbAjOccDateSortie);
            this.gbAjOcc.Controls.Add(this.monthCalendar1);
            this.gbAjOcc.Controls.Add(this.tbAjOccDateEntree);
            this.gbAjOcc.Controls.Add(this.lblFicheAjOccIDCha);
            this.gbAjOcc.Controls.Add(this.tbAjOccIDCha);
            this.gbAjOcc.Controls.Add(this.lblFicheAjOccIDPat);
            this.gbAjOcc.Controls.Add(this.tbAjOccIDPat);
            this.gbAjOcc.Controls.Add(this.lblFicheAjOccPrixJour);
            this.gbAjOcc.Controls.Add(this.lblFicheAjOccDateSortie);
            this.gbAjOcc.Controls.Add(this.lblFicheAjOccDateEntree);
            this.gbAjOcc.Controls.Add(this.lblFicheAjOccID);
            this.gbAjOcc.Controls.Add(this.tbAjOccPrixJour);
            this.gbAjOcc.Controls.Add(this.tbIDOcc);
            this.gbAjOcc.Location = new System.Drawing.Point(12, 12);
            this.gbAjOcc.Name = "gbAjOcc";
            this.gbAjOcc.Size = new System.Drawing.Size(377, 579);
            this.gbAjOcc.TabIndex = 8;
            this.gbAjOcc.TabStop = false;
            this.gbAjOcc.Text = "Fiche de prise en charge :";
            // 
            // btnAjDateSortieOcc
            // 
            this.btnAjDateSortieOcc.Location = new System.Drawing.Point(194, 481);
            this.btnAjDateSortieOcc.Name = "btnAjDateSortieOcc";
            this.btnAjDateSortieOcc.Size = new System.Drawing.Size(100, 23);
            this.btnAjDateSortieOcc.TabIndex = 20;
            this.btnAjDateSortieOcc.Text = "Ajouter Sortie";
            this.btnAjDateSortieOcc.UseVisualStyleBackColor = true;
            this.btnAjDateSortieOcc.Click += new System.EventHandler(this.btnAjDateSortieOcc_Click);
            // 
            // btnAjDateEntreeOcc
            // 
            this.btnAjDateEntreeOcc.Location = new System.Drawing.Point(45, 481);
            this.btnAjDateEntreeOcc.Name = "btnAjDateEntreeOcc";
            this.btnAjDateEntreeOcc.Size = new System.Drawing.Size(100, 23);
            this.btnAjDateEntreeOcc.TabIndex = 19;
            this.btnAjDateEntreeOcc.Text = "Ajouter entrée";
            this.btnAjDateEntreeOcc.UseVisualStyleBackColor = true;
            this.btnAjDateEntreeOcc.Click += new System.EventHandler(this.btnAjDateEntreeOcc_Click);
            // 
            // tbAjOccDateSortie
            // 
            this.tbAjOccDateSortie.Location = new System.Drawing.Point(45, 275);
            this.tbAjOccDateSortie.Name = "tbAjOccDateSortie";
            this.tbAjOccDateSortie.Size = new System.Drawing.Size(100, 20);
            this.tbAjOccDateSortie.TabIndex = 18;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(45, 307);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 17;
            // 
            // tbAjOccDateEntree
            // 
            this.tbAjOccDateEntree.Location = new System.Drawing.Point(45, 222);
            this.tbAjOccDateEntree.Name = "tbAjOccDateEntree";
            this.tbAjOccDateEntree.Size = new System.Drawing.Size(100, 20);
            this.tbAjOccDateEntree.TabIndex = 16;
            // 
            // lblFicheAjOccIDCha
            // 
            this.lblFicheAjOccIDCha.AutoSize = true;
            this.lblFicheAjOccIDCha.Location = new System.Drawing.Point(42, 151);
            this.lblFicheAjOccIDCha.Name = "lblFicheAjOccIDCha";
            this.lblFicheAjOccIDCha.Size = new System.Drawing.Size(55, 13);
            this.lblFicheAjOccIDCha.TabIndex = 12;
            this.lblFicheAjOccIDCha.Text = "Chambre :";
            // 
            // tbAjOccIDCha
            // 
            this.tbAjOccIDCha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbAjOccIDCha.Location = new System.Drawing.Point(45, 167);
            this.tbAjOccIDCha.Name = "tbAjOccIDCha";
            this.tbAjOccIDCha.ReadOnly = true;
            this.tbAjOccIDCha.Size = new System.Drawing.Size(100, 20);
            this.tbAjOccIDCha.TabIndex = 11;
            // 
            // lblFicheAjOccIDPat
            // 
            this.lblFicheAjOccIDPat.AutoSize = true;
            this.lblFicheAjOccIDPat.Location = new System.Drawing.Point(42, 97);
            this.lblFicheAjOccIDPat.Name = "lblFicheAjOccIDPat";
            this.lblFicheAjOccIDPat.Size = new System.Drawing.Size(46, 13);
            this.lblFicheAjOccIDPat.TabIndex = 10;
            this.lblFicheAjOccIDPat.Text = "Patient :";
            // 
            // tbAjOccIDPat
            // 
            this.tbAjOccIDPat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbAjOccIDPat.Location = new System.Drawing.Point(45, 113);
            this.tbAjOccIDPat.Name = "tbAjOccIDPat";
            this.tbAjOccIDPat.ReadOnly = true;
            this.tbAjOccIDPat.Size = new System.Drawing.Size(100, 20);
            this.tbAjOccIDPat.TabIndex = 9;
            // 
            // lblFicheAjOccPrixJour
            // 
            this.lblFicheAjOccPrixJour.AutoSize = true;
            this.lblFicheAjOccPrixJour.Location = new System.Drawing.Point(44, 537);
            this.lblFicheAjOccPrixJour.Name = "lblFicheAjOccPrixJour";
            this.lblFicheAjOccPrixJour.Size = new System.Drawing.Size(75, 13);
            this.lblFicheAjOccPrixJour.TabIndex = 8;
            this.lblFicheAjOccPrixJour.Text = "Prix journalier :";
            // 
            // lblFicheAjOccDateSortie
            // 
            this.lblFicheAjOccDateSortie.AutoSize = true;
            this.lblFicheAjOccDateSortie.Location = new System.Drawing.Point(44, 259);
            this.lblFicheAjOccDateSortie.Name = "lblFicheAjOccDateSortie";
            this.lblFicheAjOccDateSortie.Size = new System.Drawing.Size(79, 13);
            this.lblFicheAjOccDateSortie.TabIndex = 7;
            this.lblFicheAjOccDateSortie.Text = "Date de sortie :";
            // 
            // lblFicheAjOccDateEntree
            // 
            this.lblFicheAjOccDateEntree.AutoSize = true;
            this.lblFicheAjOccDateEntree.Location = new System.Drawing.Point(44, 206);
            this.lblFicheAjOccDateEntree.Name = "lblFicheAjOccDateEntree";
            this.lblFicheAjOccDateEntree.Size = new System.Drawing.Size(77, 13);
            this.lblFicheAjOccDateEntree.TabIndex = 6;
            this.lblFicheAjOccDateEntree.Text = "Date d\'entrée :";
            // 
            // lblFicheAjOccID
            // 
            this.lblFicheAjOccID.AutoSize = true;
            this.lblFicheAjOccID.Location = new System.Drawing.Point(42, 41);
            this.lblFicheAjOccID.Name = "lblFicheAjOccID";
            this.lblFicheAjOccID.Size = new System.Drawing.Size(24, 13);
            this.lblFicheAjOccID.TabIndex = 5;
            this.lblFicheAjOccID.Text = "ID :";
            // 
            // tbAjOccPrixJour
            // 
            this.tbAjOccPrixJour.Location = new System.Drawing.Point(45, 553);
            this.tbAjOccPrixJour.Name = "tbAjOccPrixJour";
            this.tbAjOccPrixJour.Size = new System.Drawing.Size(100, 20);
            this.tbAjOccPrixJour.TabIndex = 3;
            // 
            // tbIDOcc
            // 
            this.tbIDOcc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbIDOcc.Location = new System.Drawing.Point(45, 57);
            this.tbIDOcc.Name = "tbIDOcc";
            this.tbIDOcc.ReadOnly = true;
            this.tbIDOcc.Size = new System.Drawing.Size(100, 20);
            this.tbIDOcc.TabIndex = 0;
            // 
            // btnAnnulerAjOcc
            // 
            this.btnAnnulerAjOcc.Location = new System.Drawing.Point(231, 597);
            this.btnAnnulerAjOcc.Name = "btnAnnulerAjOcc";
            this.btnAnnulerAjOcc.Size = new System.Drawing.Size(158, 42);
            this.btnAnnulerAjOcc.TabIndex = 7;
            this.btnAnnulerAjOcc.Text = "A N N U L E R";
            this.btnAnnulerAjOcc.UseVisualStyleBackColor = true;
            this.btnAnnulerAjOcc.Click += new System.EventHandler(this.btnAnnulerAjOcc_Click);
            // 
            // btnConfirmerAjOcc
            // 
            this.btnConfirmerAjOcc.Location = new System.Drawing.Point(12, 597);
            this.btnConfirmerAjOcc.Name = "btnConfirmerAjOcc";
            this.btnConfirmerAjOcc.Size = new System.Drawing.Size(158, 42);
            this.btnConfirmerAjOcc.TabIndex = 6;
            this.btnConfirmerAjOcc.Text = "C O N F I R M E R";
            this.btnConfirmerAjOcc.UseVisualStyleBackColor = true;
            this.btnConfirmerAjOcc.Click += new System.EventHandler(this.btnConfirmerAjOcc_Click);
            // 
            // gbAjChaOcc
            // 
            this.gbAjChaOcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbAjChaOcc.Controls.Add(this.btnAjouterChaOcc);
            this.gbAjChaOcc.Controls.Add(this.dgvChambres);
            this.gbAjChaOcc.Location = new System.Drawing.Point(794, 12);
            this.gbAjChaOcc.Name = "gbAjChaOcc";
            this.gbAjChaOcc.Size = new System.Drawing.Size(393, 378);
            this.gbAjChaOcc.TabIndex = 10;
            this.gbAjChaOcc.TabStop = false;
            this.gbAjChaOcc.Text = "Liste des chambres";
            // 
            // btnAjouterChaOcc
            // 
            this.btnAjouterChaOcc.Location = new System.Drawing.Point(123, 330);
            this.btnAjouterChaOcc.Name = "btnAjouterChaOcc";
            this.btnAjouterChaOcc.Size = new System.Drawing.Size(158, 42);
            this.btnAjouterChaOcc.TabIndex = 6;
            this.btnAjouterChaOcc.Text = "<----    A J O U T E R";
            this.btnAjouterChaOcc.UseVisualStyleBackColor = true;
            this.btnAjouterChaOcc.Click += new System.EventHandler(this.btnAjouterChaOcc_Click);
            // 
            // dgvChambres
            // 
            this.dgvChambres.AllowUserToAddRows = false;
            this.dgvChambres.AllowUserToDeleteRows = false;
            this.dgvChambres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChambres.Location = new System.Drawing.Point(6, 17);
            this.dgvChambres.Name = "dgvChambres";
            this.dgvChambres.ReadOnly = true;
            this.dgvChambres.Size = new System.Drawing.Size(381, 305);
            this.dgvChambres.TabIndex = 0;
            // 
            // EcranAjoutOccupation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 651);
            this.Controls.Add(this.gbAjChaOcc);
            this.Controls.Add(this.gbAjPatOcc);
            this.Controls.Add(this.gbAjOcc);
            this.Controls.Add(this.btnAnnulerAjOcc);
            this.Controls.Add(this.btnConfirmerAjOcc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranAjoutOccupation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajout prise en charge d\'un patient";
            this.Load += new System.EventHandler(this.EcranAjoutOccupation_Load);
            this.gbAjPatOcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.gbAjOcc.ResumeLayout(false);
            this.gbAjOcc.PerformLayout();
            this.gbAjChaOcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAjPatOcc;
        private System.Windows.Forms.Button btnAjouterPatOcc;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.GroupBox gbAjOcc;
        private System.Windows.Forms.Label lblFicheAjOccIDCha;
        private System.Windows.Forms.TextBox tbAjOccIDCha;
        private System.Windows.Forms.Label lblFicheAjOccIDPat;
        private System.Windows.Forms.TextBox tbAjOccIDPat;
        private System.Windows.Forms.Label lblFicheAjOccPrixJour;
        private System.Windows.Forms.Label lblFicheAjOccDateSortie;
        private System.Windows.Forms.Label lblFicheAjOccDateEntree;
        private System.Windows.Forms.Label lblFicheAjOccID;
        private System.Windows.Forms.TextBox tbAjOccPrixJour;
        private System.Windows.Forms.TextBox tbIDOcc;
        private System.Windows.Forms.Button btnAnnulerAjOcc;
        private System.Windows.Forms.Button btnConfirmerAjOcc;
        private System.Windows.Forms.GroupBox gbAjChaOcc;
        private System.Windows.Forms.Button btnAjouterChaOcc;
        private System.Windows.Forms.DataGridView dgvChambres;
        private System.Windows.Forms.TextBox tbAjOccDateSortie;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox tbAjOccDateEntree;
        private System.Windows.Forms.Button btnAjDateSortieOcc;
        private System.Windows.Forms.Button btnAjDateEntreeOcc;
    }
}