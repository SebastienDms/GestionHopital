namespace SD_Gestion_Hopital
{
    partial class EcranAjoutChambre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranAjoutChambre));
            this.gbAjoutCha = new System.Windows.Forms.GroupBox();
            this.lblFicheAjChaServ = new System.Windows.Forms.Label();
            this.lblFicheAjChaEta = new System.Windows.Forms.Label();
            this.lblFicheAjChaTyp = new System.Windows.Forms.Label();
            this.lblFicheAjChaQuaLit = new System.Windows.Forms.Label();
            this.tbServCha = new System.Windows.Forms.TextBox();
            this.tbEtaCha = new System.Windows.Forms.TextBox();
            this.tbTypCha = new System.Windows.Forms.TextBox();
            this.tbQuaLitCha = new System.Windows.Forms.TextBox();
            this.tbNomCha = new System.Windows.Forms.TextBox();
            this.tbIDCha = new System.Windows.Forms.TextBox();
            this.lblFicheAjChaNom = new System.Windows.Forms.Label();
            this.lblFicheAjChaID = new System.Windows.Forms.Label();
            this.btnAnnulerAjCha = new System.Windows.Forms.Button();
            this.btnConfirmerAjCha = new System.Windows.Forms.Button();
            this.gbAjoutCha.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAjoutCha
            // 
            this.gbAjoutCha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbAjoutCha.Controls.Add(this.lblFicheAjChaServ);
            this.gbAjoutCha.Controls.Add(this.lblFicheAjChaEta);
            this.gbAjoutCha.Controls.Add(this.lblFicheAjChaTyp);
            this.gbAjoutCha.Controls.Add(this.lblFicheAjChaQuaLit);
            this.gbAjoutCha.Controls.Add(this.tbServCha);
            this.gbAjoutCha.Controls.Add(this.tbEtaCha);
            this.gbAjoutCha.Controls.Add(this.tbTypCha);
            this.gbAjoutCha.Controls.Add(this.tbQuaLitCha);
            this.gbAjoutCha.Controls.Add(this.tbNomCha);
            this.gbAjoutCha.Controls.Add(this.tbIDCha);
            this.gbAjoutCha.Controls.Add(this.lblFicheAjChaNom);
            this.gbAjoutCha.Controls.Add(this.lblFicheAjChaID);
            this.gbAjoutCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAjoutCha.Location = new System.Drawing.Point(12, 12);
            this.gbAjoutCha.Name = "gbAjoutCha";
            this.gbAjoutCha.Size = new System.Drawing.Size(480, 414);
            this.gbAjoutCha.TabIndex = 3;
            this.gbAjoutCha.TabStop = false;
            this.gbAjoutCha.Text = "Fiche d\'une chambre";
            // 
            // lblFicheAjChaServ
            // 
            this.lblFicheAjChaServ.AutoSize = true;
            this.lblFicheAjChaServ.Location = new System.Drawing.Point(32, 354);
            this.lblFicheAjChaServ.Name = "lblFicheAjChaServ";
            this.lblFicheAjChaServ.Size = new System.Drawing.Size(95, 15);
            this.lblFicheAjChaServ.TabIndex = 11;
            this.lblFicheAjChaServ.Text = "Liée au service :";
            // 
            // lblFicheAjChaEta
            // 
            this.lblFicheAjChaEta.AutoSize = true;
            this.lblFicheAjChaEta.Location = new System.Drawing.Point(32, 291);
            this.lblFicheAjChaEta.Name = "lblFicheAjChaEta";
            this.lblFicheAjChaEta.Size = new System.Drawing.Size(98, 15);
            this.lblFicheAjChaEta.TabIndex = 10;
            this.lblFicheAjChaEta.Text = "Située à l\'étage :";
            // 
            // lblFicheAjChaTyp
            // 
            this.lblFicheAjChaTyp.AutoSize = true;
            this.lblFicheAjChaTyp.Location = new System.Drawing.Point(32, 225);
            this.lblFicheAjChaTyp.Name = "lblFicheAjChaTyp";
            this.lblFicheAjChaTyp.Size = new System.Drawing.Size(108, 15);
            this.lblFicheAjChaTyp.TabIndex = 9;
            this.lblFicheAjChaTyp.Text = "Type de chambre :";
            // 
            // lblFicheAjChaQuaLit
            // 
            this.lblFicheAjChaQuaLit.AutoSize = true;
            this.lblFicheAjChaQuaLit.Location = new System.Drawing.Point(32, 162);
            this.lblFicheAjChaQuaLit.Name = "lblFicheAjChaQuaLit";
            this.lblFicheAjChaQuaLit.Size = new System.Drawing.Size(102, 15);
            this.lblFicheAjChaQuaLit.TabIndex = 8;
            this.lblFicheAjChaQuaLit.Text = "Quantité de lit(s) :";
            // 
            // tbServCha
            // 
            this.tbServCha.Location = new System.Drawing.Point(35, 372);
            this.tbServCha.Name = "tbServCha";
            this.tbServCha.Size = new System.Drawing.Size(296, 21);
            this.tbServCha.TabIndex = 7;
            // 
            // tbEtaCha
            // 
            this.tbEtaCha.Location = new System.Drawing.Point(35, 309);
            this.tbEtaCha.Name = "tbEtaCha";
            this.tbEtaCha.Size = new System.Drawing.Size(296, 21);
            this.tbEtaCha.TabIndex = 6;
            // 
            // tbTypCha
            // 
            this.tbTypCha.Location = new System.Drawing.Point(35, 243);
            this.tbTypCha.Name = "tbTypCha";
            this.tbTypCha.Size = new System.Drawing.Size(296, 21);
            this.tbTypCha.TabIndex = 5;
            // 
            // tbQuaLitCha
            // 
            this.tbQuaLitCha.Location = new System.Drawing.Point(35, 180);
            this.tbQuaLitCha.Name = "tbQuaLitCha";
            this.tbQuaLitCha.Size = new System.Drawing.Size(296, 21);
            this.tbQuaLitCha.TabIndex = 4;
            // 
            // tbNomCha
            // 
            this.tbNomCha.Location = new System.Drawing.Point(35, 115);
            this.tbNomCha.Name = "tbNomCha";
            this.tbNomCha.Size = new System.Drawing.Size(296, 21);
            this.tbNomCha.TabIndex = 3;
            this.tbNomCha.Click += new System.EventHandler(this.tbNomCha_Click);
            // 
            // tbIDCha
            // 
            this.tbIDCha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbIDCha.Location = new System.Drawing.Point(36, 61);
            this.tbIDCha.Name = "tbIDCha";
            this.tbIDCha.ReadOnly = true;
            this.tbIDCha.Size = new System.Drawing.Size(123, 21);
            this.tbIDCha.TabIndex = 2;
            // 
            // lblFicheAjChaNom
            // 
            this.lblFicheAjChaNom.AutoSize = true;
            this.lblFicheAjChaNom.Location = new System.Drawing.Point(32, 97);
            this.lblFicheAjChaNom.Name = "lblFicheAjChaNom";
            this.lblFicheAjChaNom.Size = new System.Drawing.Size(58, 15);
            this.lblFicheAjChaNom.TabIndex = 1;
            this.lblFicheAjChaNom.Text = "Numéro :";
            // 
            // lblFicheAjChaID
            // 
            this.lblFicheAjChaID.AutoSize = true;
            this.lblFicheAjChaID.Location = new System.Drawing.Point(33, 43);
            this.lblFicheAjChaID.Name = "lblFicheAjChaID";
            this.lblFicheAjChaID.Size = new System.Drawing.Size(107, 15);
            this.lblFicheAjChaID.TabIndex = 0;
            this.lblFicheAjChaID.Text = "ID de la chambre :";
            // 
            // btnAnnulerAjCha
            // 
            this.btnAnnulerAjCha.Location = new System.Drawing.Point(340, 432);
            this.btnAnnulerAjCha.Name = "btnAnnulerAjCha";
            this.btnAnnulerAjCha.Size = new System.Drawing.Size(152, 30);
            this.btnAnnulerAjCha.TabIndex = 5;
            this.btnAnnulerAjCha.Text = "A N N U L E R";
            this.btnAnnulerAjCha.UseVisualStyleBackColor = true;
            this.btnAnnulerAjCha.Click += new System.EventHandler(this.btnAnnulerAjCha_Click);
            // 
            // btnConfirmerAjCha
            // 
            this.btnConfirmerAjCha.Location = new System.Drawing.Point(12, 432);
            this.btnConfirmerAjCha.Name = "btnConfirmerAjCha";
            this.btnConfirmerAjCha.Size = new System.Drawing.Size(152, 30);
            this.btnConfirmerAjCha.TabIndex = 4;
            this.btnConfirmerAjCha.Text = "C O N F I R M E R";
            this.btnConfirmerAjCha.UseVisualStyleBackColor = true;
            this.btnConfirmerAjCha.Click += new System.EventHandler(this.btnConfirmerAjCha_Click);
            // 
            // EcranAjoutChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 469);
            this.Controls.Add(this.gbAjoutCha);
            this.Controls.Add(this.btnAnnulerAjCha);
            this.Controls.Add(this.btnConfirmerAjCha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranAjoutChambre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajout d\'une chambre";
            this.Load += new System.EventHandler(this.FicAjoutChambre_Load);
            this.gbAjoutCha.ResumeLayout(false);
            this.gbAjoutCha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAjoutCha;
        private System.Windows.Forms.TextBox tbNomCha;
        private System.Windows.Forms.TextBox tbIDCha;
        private System.Windows.Forms.Label lblFicheAjChaNom;
        private System.Windows.Forms.Label lblFicheAjChaID;
        private System.Windows.Forms.Button btnAnnulerAjCha;
        private System.Windows.Forms.Button btnConfirmerAjCha;
        private System.Windows.Forms.TextBox tbServCha;
        private System.Windows.Forms.TextBox tbEtaCha;
        private System.Windows.Forms.TextBox tbTypCha;
        private System.Windows.Forms.TextBox tbQuaLitCha;
        private System.Windows.Forms.Label lblFicheAjChaServ;
        private System.Windows.Forms.Label lblFicheAjChaEta;
        private System.Windows.Forms.Label lblFicheAjChaTyp;
        private System.Windows.Forms.Label lblFicheAjChaQuaLit;
    }
}