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
            this.TSMAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAfSpécialités = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAfMédecins = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAfChambres = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAfPatients = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAfOccuper = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAfSoigner = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAjSpécialité = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAjMédecin = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAjChambre = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAjPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAjOccuper = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAjSoigner = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spécialitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médecinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chambresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priseEnChargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spécilitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chambreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.priseEnChargeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.soinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MSHopital.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MSHopital
            // 
            this.MSHopital.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MSHopital.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAfficher,
            this.TSMAjouter,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.MSHopital.Location = new System.Drawing.Point(0, 0);
            this.MSHopital.Name = "MSHopital";
            this.MSHopital.Size = new System.Drawing.Size(800, 29);
            this.MSHopital.TabIndex = 0;
            this.MSHopital.Text = "menuStrip1";
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
            this.TSMAfficher.Size = new System.Drawing.Size(76, 25);
            this.TSMAfficher.Text = "Afficher";
            // 
            // TSMAfSpécialités
            // 
            this.TSMAfSpécialités.Name = "TSMAfSpécialités";
            this.TSMAfSpécialités.Size = new System.Drawing.Size(231, 26);
            this.TSMAfSpécialités.Text = "Spécialités";
            this.TSMAfSpécialités.Click += new System.EventHandler(this.TSMAfSpécialités_Click);
            // 
            // TSMAfMédecins
            // 
            this.TSMAfMédecins.Name = "TSMAfMédecins";
            this.TSMAfMédecins.Size = new System.Drawing.Size(231, 26);
            this.TSMAfMédecins.Text = "Médecins";
            this.TSMAfMédecins.Click += new System.EventHandler(this.TSMAfMédecins_Click);
            // 
            // TSMAfChambres
            // 
            this.TSMAfChambres.Name = "TSMAfChambres";
            this.TSMAfChambres.Size = new System.Drawing.Size(231, 26);
            this.TSMAfChambres.Text = "Chambres";
            this.TSMAfChambres.Click += new System.EventHandler(this.TSMAfChambres_Click);
            // 
            // TSMAfPatients
            // 
            this.TSMAfPatients.Name = "TSMAfPatients";
            this.TSMAfPatients.Size = new System.Drawing.Size(231, 26);
            this.TSMAfPatients.Text = "Patients";
            this.TSMAfPatients.Click += new System.EventHandler(this.TSMAfPatients_Click);
            // 
            // TSMAfOccuper
            // 
            this.TSMAfOccuper.Name = "TSMAfOccuper";
            this.TSMAfOccuper.Size = new System.Drawing.Size(231, 26);
            this.TSMAfOccuper.Text = "Occupation chambres";
            this.TSMAfOccuper.Click += new System.EventHandler(this.TSMAfOccuper_Click);
            // 
            // TSMAfSoigner
            // 
            this.TSMAfSoigner.Name = "TSMAfSoigner";
            this.TSMAfSoigner.Size = new System.Drawing.Size(231, 26);
            this.TSMAfSoigner.Text = "Soins";
            this.TSMAfSoigner.Click += new System.EventHandler(this.TSMAfSoigner_Click);
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
            this.TSMAjouter.Size = new System.Drawing.Size(73, 25);
            this.TSMAjouter.Text = "Ajouter";
            // 
            // TSMAjSpécialité
            // 
            this.TSMAjSpécialité.Name = "TSMAjSpécialité";
            this.TSMAjSpécialité.Size = new System.Drawing.Size(238, 26);
            this.TSMAjSpécialité.Text = "Spécialité";
            this.TSMAjSpécialité.Click += new System.EventHandler(this.TSMAjSpécialité_Click);
            // 
            // TSMAjMédecin
            // 
            this.TSMAjMédecin.Name = "TSMAjMédecin";
            this.TSMAjMédecin.Size = new System.Drawing.Size(238, 26);
            this.TSMAjMédecin.Text = "Médecin";
            this.TSMAjMédecin.Click += new System.EventHandler(this.TSMAjMédecin_Click);
            // 
            // TSMAjChambre
            // 
            this.TSMAjChambre.Name = "TSMAjChambre";
            this.TSMAjChambre.Size = new System.Drawing.Size(238, 26);
            this.TSMAjChambre.Text = "Chambre";
            this.TSMAjChambre.Click += new System.EventHandler(this.TSMAjChambre_Click);
            // 
            // TSMAjPatient
            // 
            this.TSMAjPatient.Name = "TSMAjPatient";
            this.TSMAjPatient.Size = new System.Drawing.Size(238, 26);
            this.TSMAjPatient.Text = "Patient";
            this.TSMAjPatient.Click += new System.EventHandler(this.TSMAjPatient_Click);
            // 
            // TSMAjOccuper
            // 
            this.TSMAjOccuper.Name = "TSMAjOccuper";
            this.TSMAjOccuper.Size = new System.Drawing.Size(238, 26);
            this.TSMAjOccuper.Text = "Prise en charge patient";
            this.TSMAjOccuper.Click += new System.EventHandler(this.TSMAjOccuper_Click);
            // 
            // TSMAjSoigner
            // 
            this.TSMAjSoigner.Name = "TSMAjSoigner";
            this.TSMAjSoigner.Size = new System.Drawing.Size(238, 26);
            this.TSMAjSoigner.Text = "Soin d\'un patient";
            this.TSMAjSoigner.Click += new System.EventHandler(this.TSMAjSoigner_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spécialitéToolStripMenuItem,
            this.médecinsToolStripMenuItem,
            this.chambresToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.priseEnChargeToolStripMenuItem,
            this.soinToolStripMenuItem});
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // spécialitéToolStripMenuItem
            // 
            this.spécialitéToolStripMenuItem.Name = "spécialitéToolStripMenuItem";
            this.spécialitéToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.spécialitéToolStripMenuItem.Text = "Spécialité";
            this.spécialitéToolStripMenuItem.Click += new System.EventHandler(this.spécialitéToolStripMenuItem_Click);
            // 
            // médecinsToolStripMenuItem
            // 
            this.médecinsToolStripMenuItem.Name = "médecinsToolStripMenuItem";
            this.médecinsToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.médecinsToolStripMenuItem.Text = "Médecin";
            this.médecinsToolStripMenuItem.Click += new System.EventHandler(this.médecinsToolStripMenuItem_Click);
            // 
            // chambresToolStripMenuItem
            // 
            this.chambresToolStripMenuItem.Name = "chambresToolStripMenuItem";
            this.chambresToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.chambresToolStripMenuItem.Text = "Chambre";
            this.chambresToolStripMenuItem.Click += new System.EventHandler(this.chambresToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // priseEnChargeToolStripMenuItem
            // 
            this.priseEnChargeToolStripMenuItem.Name = "priseEnChargeToolStripMenuItem";
            this.priseEnChargeToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.priseEnChargeToolStripMenuItem.Text = "Prise en charge";
            // 
            // soinToolStripMenuItem
            // 
            this.soinToolStripMenuItem.Name = "soinToolStripMenuItem";
            this.soinToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.soinToolStripMenuItem.Text = "Soin";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spécilitéToolStripMenuItem,
            this.médecinToolStripMenuItem,
            this.chambreToolStripMenuItem,
            this.patientToolStripMenuItem1,
            this.priseEnChargeToolStripMenuItem1,
            this.soinToolStripMenuItem1});
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // spécilitéToolStripMenuItem
            // 
            this.spécilitéToolStripMenuItem.Name = "spécilitéToolStripMenuItem";
            this.spécilitéToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.spécilitéToolStripMenuItem.Text = "Spécilité";
            // 
            // médecinToolStripMenuItem
            // 
            this.médecinToolStripMenuItem.Name = "médecinToolStripMenuItem";
            this.médecinToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.médecinToolStripMenuItem.Text = "Médecin";
            // 
            // chambreToolStripMenuItem
            // 
            this.chambreToolStripMenuItem.Name = "chambreToolStripMenuItem";
            this.chambreToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.chambreToolStripMenuItem.Text = "Chambre";
            // 
            // patientToolStripMenuItem1
            // 
            this.patientToolStripMenuItem1.Name = "patientToolStripMenuItem1";
            this.patientToolStripMenuItem1.Size = new System.Drawing.Size(186, 26);
            this.patientToolStripMenuItem1.Text = "Patient";
            // 
            // priseEnChargeToolStripMenuItem1
            // 
            this.priseEnChargeToolStripMenuItem1.Name = "priseEnChargeToolStripMenuItem1";
            this.priseEnChargeToolStripMenuItem1.Size = new System.Drawing.Size(186, 26);
            this.priseEnChargeToolStripMenuItem1.Text = "Prise en charge";
            // 
            // soinToolStripMenuItem1
            // 
            this.soinToolStripMenuItem1.Name = "soinToolStripMenuItem1";
            this.soinToolStripMenuItem1.Size = new System.Drawing.Size(186, 26);
            this.soinToolStripMenuItem1.Text = "Soin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SD_Gestion_Hopital.Properties.Resources.fond_hopital1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spécialitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médecinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chambresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priseEnChargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spécilitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chambreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem priseEnChargeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem soinToolStripMenuItem1;
    }
}