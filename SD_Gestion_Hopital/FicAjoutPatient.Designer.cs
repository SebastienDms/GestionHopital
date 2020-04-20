namespace SD_Gestion_Hopital
{
    partial class EcranAjoutPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranAjoutPatient));
            this.gbAjoutPat = new System.Windows.Forms.GroupBox();
            this.lblFicheAjPatGSM = new System.Windows.Forms.Label();
            this.lblFicheAjPatAdr = new System.Windows.Forms.Label();
            this.lblFicheAjPatPre = new System.Windows.Forms.Label();
            this.tbGSMPat = new System.Windows.Forms.TextBox();
            this.tbAdrPat = new System.Windows.Forms.TextBox();
            this.tbPrePat = new System.Windows.Forms.TextBox();
            this.tbNomPat = new System.Windows.Forms.TextBox();
            this.tbIDPat = new System.Windows.Forms.TextBox();
            this.lblFicheAjPatNom = new System.Windows.Forms.Label();
            this.lblFicheAjPatID = new System.Windows.Forms.Label();
            this.btnAnnulerAjPat = new System.Windows.Forms.Button();
            this.btnConfirmerAjPat = new System.Windows.Forms.Button();
            this.gbAjoutPat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAjoutPat
            // 
            this.gbAjoutPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbAjoutPat.Controls.Add(this.lblFicheAjPatGSM);
            this.gbAjoutPat.Controls.Add(this.lblFicheAjPatAdr);
            this.gbAjoutPat.Controls.Add(this.lblFicheAjPatPre);
            this.gbAjoutPat.Controls.Add(this.tbGSMPat);
            this.gbAjoutPat.Controls.Add(this.tbAdrPat);
            this.gbAjoutPat.Controls.Add(this.tbPrePat);
            this.gbAjoutPat.Controls.Add(this.tbNomPat);
            this.gbAjoutPat.Controls.Add(this.tbIDPat);
            this.gbAjoutPat.Controls.Add(this.lblFicheAjPatNom);
            this.gbAjoutPat.Controls.Add(this.lblFicheAjPatID);
            this.gbAjoutPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAjoutPat.Location = new System.Drawing.Point(12, 9);
            this.gbAjoutPat.Name = "gbAjoutPat";
            this.gbAjoutPat.Size = new System.Drawing.Size(480, 365);
            this.gbAjoutPat.TabIndex = 6;
            this.gbAjoutPat.TabStop = false;
            this.gbAjoutPat.Text = "Fiche d\'encodage du patient";
            // 
            // lblFicheAjPatGSM
            // 
            this.lblFicheAjPatGSM.AutoSize = true;
            this.lblFicheAjPatGSM.Location = new System.Drawing.Point(32, 291);
            this.lblFicheAjPatGSM.Name = "lblFicheAjPatGSM";
            this.lblFicheAjPatGSM.Size = new System.Drawing.Size(106, 15);
            this.lblFicheAjPatGSM.TabIndex = 10;
            this.lblFicheAjPatGSM.Text = "Numéro de GSM :";
            // 
            // lblFicheAjPatAdr
            // 
            this.lblFicheAjPatAdr.AutoSize = true;
            this.lblFicheAjPatAdr.Location = new System.Drawing.Point(32, 225);
            this.lblFicheAjPatAdr.Name = "lblFicheAjPatAdr";
            this.lblFicheAjPatAdr.Size = new System.Drawing.Size(114, 15);
            this.lblFicheAjPatAdr.TabIndex = 9;
            this.lblFicheAjPatAdr.Text = "Adresse du patient :";
            // 
            // lblFicheAjPatPre
            // 
            this.lblFicheAjPatPre.AutoSize = true;
            this.lblFicheAjPatPre.Location = new System.Drawing.Point(32, 162);
            this.lblFicheAjPatPre.Name = "lblFicheAjPatPre";
            this.lblFicheAjPatPre.Size = new System.Drawing.Size(57, 15);
            this.lblFicheAjPatPre.TabIndex = 8;
            this.lblFicheAjPatPre.Text = "Prénom :";
            // 
            // tbGSMPat
            // 
            this.tbGSMPat.Location = new System.Drawing.Point(35, 309);
            this.tbGSMPat.Name = "tbGSMPat";
            this.tbGSMPat.Size = new System.Drawing.Size(296, 21);
            this.tbGSMPat.TabIndex = 6;
            // 
            // tbAdrPat
            // 
            this.tbAdrPat.Location = new System.Drawing.Point(35, 243);
            this.tbAdrPat.Name = "tbAdrPat";
            this.tbAdrPat.Size = new System.Drawing.Size(296, 21);
            this.tbAdrPat.TabIndex = 5;
            // 
            // tbPrePat
            // 
            this.tbPrePat.Location = new System.Drawing.Point(35, 180);
            this.tbPrePat.Name = "tbPrePat";
            this.tbPrePat.Size = new System.Drawing.Size(296, 21);
            this.tbPrePat.TabIndex = 4;
            // 
            // tbNomPat
            // 
            this.tbNomPat.Location = new System.Drawing.Point(35, 115);
            this.tbNomPat.Name = "tbNomPat";
            this.tbNomPat.Size = new System.Drawing.Size(296, 21);
            this.tbNomPat.TabIndex = 3;
            this.tbNomPat.Click += new System.EventHandler(this.tbNomPat_Click);
            // 
            // tbIDPat
            // 
            this.tbIDPat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbIDPat.Location = new System.Drawing.Point(36, 61);
            this.tbIDPat.Name = "tbIDPat";
            this.tbIDPat.ReadOnly = true;
            this.tbIDPat.Size = new System.Drawing.Size(123, 21);
            this.tbIDPat.TabIndex = 2;
            // 
            // lblFicheAjPatNom
            // 
            this.lblFicheAjPatNom.AutoSize = true;
            this.lblFicheAjPatNom.Location = new System.Drawing.Point(32, 97);
            this.lblFicheAjPatNom.Name = "lblFicheAjPatNom";
            this.lblFicheAjPatNom.Size = new System.Drawing.Size(40, 15);
            this.lblFicheAjPatNom.TabIndex = 1;
            this.lblFicheAjPatNom.Text = "Nom :";
            // 
            // lblFicheAjPatID
            // 
            this.lblFicheAjPatID.AutoSize = true;
            this.lblFicheAjPatID.Location = new System.Drawing.Point(33, 43);
            this.lblFicheAjPatID.Name = "lblFicheAjPatID";
            this.lblFicheAjPatID.Size = new System.Drawing.Size(82, 15);
            this.lblFicheAjPatID.TabIndex = 0;
            this.lblFicheAjPatID.Text = "ID du patient :";
            // 
            // btnAnnulerAjPat
            // 
            this.btnAnnulerAjPat.Location = new System.Drawing.Point(340, 380);
            this.btnAnnulerAjPat.Name = "btnAnnulerAjPat";
            this.btnAnnulerAjPat.Size = new System.Drawing.Size(152, 30);
            this.btnAnnulerAjPat.TabIndex = 8;
            this.btnAnnulerAjPat.Text = "A N N U L E R";
            this.btnAnnulerAjPat.UseVisualStyleBackColor = true;
            this.btnAnnulerAjPat.Click += new System.EventHandler(this.btnAnnulerAjPat_Click);
            // 
            // btnConfirmerAjPat
            // 
            this.btnConfirmerAjPat.Location = new System.Drawing.Point(12, 380);
            this.btnConfirmerAjPat.Name = "btnConfirmerAjPat";
            this.btnConfirmerAjPat.Size = new System.Drawing.Size(152, 30);
            this.btnConfirmerAjPat.TabIndex = 7;
            this.btnConfirmerAjPat.Text = "C O N F I R M E R";
            this.btnConfirmerAjPat.UseVisualStyleBackColor = true;
            this.btnConfirmerAjPat.Click += new System.EventHandler(this.btnConfirmerAjPat_Click);
            // 
            // EcranAjoutPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 422);
            this.Controls.Add(this.gbAjoutPat);
            this.Controls.Add(this.btnAnnulerAjPat);
            this.Controls.Add(this.btnConfirmerAjPat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranAjoutPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajout d\'un patient";
            this.Load += new System.EventHandler(this.EcranAjoutPatient_Load);
            this.gbAjoutPat.ResumeLayout(false);
            this.gbAjoutPat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAjoutPat;
        private System.Windows.Forms.Label lblFicheAjPatGSM;
        private System.Windows.Forms.Label lblFicheAjPatAdr;
        private System.Windows.Forms.Label lblFicheAjPatPre;
        private System.Windows.Forms.TextBox tbGSMPat;
        private System.Windows.Forms.TextBox tbAdrPat;
        private System.Windows.Forms.TextBox tbPrePat;
        private System.Windows.Forms.TextBox tbNomPat;
        private System.Windows.Forms.TextBox tbIDPat;
        private System.Windows.Forms.Label lblFicheAjPatNom;
        private System.Windows.Forms.Label lblFicheAjPatID;
        private System.Windows.Forms.Button btnAnnulerAjPat;
        private System.Windows.Forms.Button btnConfirmerAjPat;
    }
}