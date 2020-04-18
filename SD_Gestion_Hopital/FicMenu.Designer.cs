namespace SD_Gestion_Hopital
{
    partial class FicMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicMenu));
            this.MSHopital = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TSMAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAfSpécialités = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAfMédecins = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAfChambres = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAfPatients = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAfOccuper = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAfSoigner = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAjSpécialité = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAjMédecin = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAjChambre = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAjPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAjOccuper = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAjSoigner = new System.Windows.Forms.ToolStripMenuItem();
            this.MSHopital.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MSHopital
            // 
            this.MSHopital.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAfficher,
            this.TSMAjouter});
            this.MSHopital.Location = new System.Drawing.Point(0, 0);
            this.MSHopital.Name = "MSHopital";
            this.MSHopital.Size = new System.Drawing.Size(800, 24);
            this.MSHopital.TabIndex = 0;
            this.MSHopital.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SD_Gestion_Hopital.Properties.Resources.fond_hopital1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TSMAfficher
            // 
            this.TSMAfficher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAfSpécialités,
            this.TSMAfMédecins,
            this.TSMAfChambres,
            this.TSMAfPatients,
            this.TSMAfOccuper,
            this.TSMAfSoigner});
            this.TSMAfficher.Name = "TSMAfficher";
            this.TSMAfficher.Size = new System.Drawing.Size(61, 20);
            this.TSMAfficher.Text = "Afficher";
            // 
            // TSMAjouter
            // 
            this.TSMAjouter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAjSpécialité,
            this.TSMAjMédecin,
            this.TSMAjChambre,
            this.TSMAjPatient,
            this.TSMAjOccuper,
            this.TSMAjSoigner});
            this.TSMAjouter.Name = "TSMAjouter";
            this.TSMAjouter.Size = new System.Drawing.Size(58, 20);
            this.TSMAjouter.Text = "Ajouter";
            // 
            // TSMAfSpécialités
            // 
            this.TSMAfSpécialités.Name = "TSMAfSpécialités";
            this.TSMAfSpécialités.Size = new System.Drawing.Size(191, 22);
            this.TSMAfSpécialités.Text = "Spécialités";
            this.TSMAfSpécialités.Click += new System.EventHandler(this.TSMAfSpécialités_Click);
            // 
            // TSMAfMédecins
            // 
            this.TSMAfMédecins.Name = "TSMAfMédecins";
            this.TSMAfMédecins.Size = new System.Drawing.Size(191, 22);
            this.TSMAfMédecins.Text = "Médecins";
            this.TSMAfMédecins.Click += new System.EventHandler(this.TSMAfMédecins_Click);
            // 
            // TSMAfChambres
            // 
            this.TSMAfChambres.Name = "TSMAfChambres";
            this.TSMAfChambres.Size = new System.Drawing.Size(191, 22);
            this.TSMAfChambres.Text = "Chambres";
            this.TSMAfChambres.Click += new System.EventHandler(this.TSMAfChambres_Click);
            // 
            // TSMAfPatients
            // 
            this.TSMAfPatients.Name = "TSMAfPatients";
            this.TSMAfPatients.Size = new System.Drawing.Size(191, 22);
            this.TSMAfPatients.Text = "Patients";
            this.TSMAfPatients.Click += new System.EventHandler(this.TSMAfPatients_Click);
            // 
            // TSMAfOccuper
            // 
            this.TSMAfOccuper.Name = "TSMAfOccuper";
            this.TSMAfOccuper.Size = new System.Drawing.Size(191, 22);
            this.TSMAfOccuper.Text = "Occupation chambres";
            this.TSMAfOccuper.Click += new System.EventHandler(this.TSMAfOccuper_Click);
            // 
            // TSMAfSoigner
            // 
            this.TSMAfSoigner.Name = "TSMAfSoigner";
            this.TSMAfSoigner.Size = new System.Drawing.Size(191, 22);
            this.TSMAfSoigner.Text = "Soins";
            this.TSMAfSoigner.Click += new System.EventHandler(this.TSMAfSoigner_Click);
            // 
            // TSMAjSpécialité
            // 
            this.TSMAjSpécialité.Name = "TSMAjSpécialité";
            this.TSMAjSpécialité.Size = new System.Drawing.Size(194, 22);
            this.TSMAjSpécialité.Text = "Spécialité";
            this.TSMAjSpécialité.Click += new System.EventHandler(this.TSMAjSpécialité_Click);
            // 
            // TSMAjMédecin
            // 
            this.TSMAjMédecin.Name = "TSMAjMédecin";
            this.TSMAjMédecin.Size = new System.Drawing.Size(194, 22);
            this.TSMAjMédecin.Text = "Médecin";
            this.TSMAjMédecin.Click += new System.EventHandler(this.TSMAjMédecin_Click);
            // 
            // TSMAjChambre
            // 
            this.TSMAjChambre.Name = "TSMAjChambre";
            this.TSMAjChambre.Size = new System.Drawing.Size(194, 22);
            this.TSMAjChambre.Text = "Chambre";
            this.TSMAjChambre.Click += new System.EventHandler(this.TSMAjChambre_Click);
            // 
            // TSMAjPatient
            // 
            this.TSMAjPatient.Name = "TSMAjPatient";
            this.TSMAjPatient.Size = new System.Drawing.Size(194, 22);
            this.TSMAjPatient.Text = "Patient";
            this.TSMAjPatient.Click += new System.EventHandler(this.TSMAjPatient_Click);
            // 
            // TSMAjOccuper
            // 
            this.TSMAjOccuper.Name = "TSMAjOccuper";
            this.TSMAjOccuper.Size = new System.Drawing.Size(194, 22);
            this.TSMAjOccuper.Text = "Prise en charge patient";
            this.TSMAjOccuper.Click += new System.EventHandler(this.TSMAjOccuper_Click);
            // 
            // TSMAjSoigner
            // 
            this.TSMAjSoigner.Name = "TSMAjSoigner";
            this.TSMAjSoigner.Size = new System.Drawing.Size(194, 22);
            this.TSMAjSoigner.Text = "Soin d\'un patient";
            this.TSMAjSoigner.Click += new System.EventHandler(this.TSMAjSoigner_Click);
            // 
            // FicMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MSHopital);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MSHopital;
            this.Name = "FicMenu";
            this.Text = "FicMenu";
            this.Load += new System.EventHandler(this.FicMenu_Load);
            this.MSHopital.ResumeLayout(false);
            this.MSHopital.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSHopital;
        private System.Windows.Forms.ToolStripMenuItem TSMAfficher;
        private System.Windows.Forms.ToolStripMenuItem TSMAfSpécialités;
        private System.Windows.Forms.ToolStripMenuItem TSMAfMédecins;
        private System.Windows.Forms.ToolStripMenuItem TSMAfChambres;
        private System.Windows.Forms.ToolStripMenuItem TSMAfPatients;
        private System.Windows.Forms.ToolStripMenuItem TSMAfOccuper;
        private System.Windows.Forms.ToolStripMenuItem TSMAfSoigner;
        private System.Windows.Forms.ToolStripMenuItem TSMAjouter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem TSMAjSpécialité;
        private System.Windows.Forms.ToolStripMenuItem TSMAjMédecin;
        private System.Windows.Forms.ToolStripMenuItem TSMAjChambre;
        private System.Windows.Forms.ToolStripMenuItem TSMAjPatient;
        private System.Windows.Forms.ToolStripMenuItem TSMAjOccuper;
        private System.Windows.Forms.ToolStripMenuItem TSMAjSoigner;
    }
}