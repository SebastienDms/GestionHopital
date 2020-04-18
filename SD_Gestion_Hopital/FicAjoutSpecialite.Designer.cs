namespace SD_Gestion_Hopital
{
    partial class EcranAjoutSpecialite
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
            this.gbAjoutSpe = new System.Windows.Forms.GroupBox();
            this.tbNomSpe = new System.Windows.Forms.TextBox();
            this.tbIDSpe = new System.Windows.Forms.TextBox();
            this.lblFicheAjSpeNom = new System.Windows.Forms.Label();
            this.lblFicheAjSpeID = new System.Windows.Forms.Label();
            this.btnConfirmerAj = new System.Windows.Forms.Button();
            this.btnAnnulerAj = new System.Windows.Forms.Button();
            this.gbAjoutSpe.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAjoutSpe
            // 
            this.gbAjoutSpe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbAjoutSpe.Controls.Add(this.tbNomSpe);
            this.gbAjoutSpe.Controls.Add(this.tbIDSpe);
            this.gbAjoutSpe.Controls.Add(this.lblFicheAjSpeNom);
            this.gbAjoutSpe.Controls.Add(this.lblFicheAjSpeID);
            this.gbAjoutSpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAjoutSpe.Location = new System.Drawing.Point(12, 12);
            this.gbAjoutSpe.Name = "gbAjoutSpe";
            this.gbAjoutSpe.Size = new System.Drawing.Size(443, 240);
            this.gbAjoutSpe.TabIndex = 0;
            this.gbAjoutSpe.TabStop = false;
            this.gbAjoutSpe.Text = "Fiche de la spécalité";
            // 
            // tbNomSpe
            // 
            this.tbNomSpe.Location = new System.Drawing.Point(35, 133);
            this.tbNomSpe.Name = "tbNomSpe";
            this.tbNomSpe.Size = new System.Drawing.Size(296, 21);
            this.tbNomSpe.TabIndex = 3;
            // 
            // tbIDSpe
            // 
            this.tbIDSpe.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbIDSpe.Location = new System.Drawing.Point(35, 64);
            this.tbIDSpe.Name = "tbIDSpe";
            this.tbIDSpe.ReadOnly = true;
            this.tbIDSpe.Size = new System.Drawing.Size(123, 21);
            this.tbIDSpe.TabIndex = 2;
            // 
            // lblFicheAjSpeNom
            // 
            this.lblFicheAjSpeNom.AutoSize = true;
            this.lblFicheAjSpeNom.Location = new System.Drawing.Point(32, 101);
            this.lblFicheAjSpeNom.Name = "lblFicheAjSpeNom";
            this.lblFicheAjSpeNom.Size = new System.Drawing.Size(40, 15);
            this.lblFicheAjSpeNom.TabIndex = 1;
            this.lblFicheAjSpeNom.Text = "Nom :";
            // 
            // lblFicheAjSpeID
            // 
            this.lblFicheAjSpeID.AutoSize = true;
            this.lblFicheAjSpeID.Location = new System.Drawing.Point(32, 35);
            this.lblFicheAjSpeID.Name = "lblFicheAjSpeID";
            this.lblFicheAjSpeID.Size = new System.Drawing.Size(110, 15);
            this.lblFicheAjSpeID.TabIndex = 0;
            this.lblFicheAjSpeID.Text = "ID de la spécialité :";
            // 
            // btnConfirmerAj
            // 
            this.btnConfirmerAj.Location = new System.Drawing.Point(12, 258);
            this.btnConfirmerAj.Name = "btnConfirmerAj";
            this.btnConfirmerAj.Size = new System.Drawing.Size(158, 42);
            this.btnConfirmerAj.TabIndex = 1;
            this.btnConfirmerAj.Text = "C O N F I R M E R";
            this.btnConfirmerAj.UseVisualStyleBackColor = true;
            this.btnConfirmerAj.Click += new System.EventHandler(this.btnConfirmerAj_Click);
            // 
            // btnAnnulerAj
            // 
            this.btnAnnulerAj.Location = new System.Drawing.Point(297, 258);
            this.btnAnnulerAj.Name = "btnAnnulerAj";
            this.btnAnnulerAj.Size = new System.Drawing.Size(158, 42);
            this.btnAnnulerAj.TabIndex = 2;
            this.btnAnnulerAj.Text = "A N N U L E R";
            this.btnAnnulerAj.UseVisualStyleBackColor = true;
            this.btnAnnulerAj.Click += new System.EventHandler(this.btnAnnulerAj_Click);
            // 
            // EcranAjoutSpecialite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 310);
            this.Controls.Add(this.btnAnnulerAj);
            this.Controls.Add(this.btnConfirmerAj);
            this.Controls.Add(this.gbAjoutSpe);
            this.Name = "EcranAjoutSpecialite";
            this.Text = "Ajout d\'une spécialité";
            this.gbAjoutSpe.ResumeLayout(false);
            this.gbAjoutSpe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAjoutSpe;
        private System.Windows.Forms.TextBox tbNomSpe;
        private System.Windows.Forms.TextBox tbIDSpe;
        private System.Windows.Forms.Label lblFicheAjSpeNom;
        private System.Windows.Forms.Label lblFicheAjSpeID;
        private System.Windows.Forms.Button btnConfirmerAj;
        private System.Windows.Forms.Button btnAnnulerAj;
    }
}