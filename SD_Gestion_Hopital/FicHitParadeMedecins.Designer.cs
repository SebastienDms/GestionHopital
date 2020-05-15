namespace SD_Gestion_Hopital
{
    partial class EcranHitParadeMedecins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranHitParadeMedecins));
            this.dgvHitParade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHitParade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHitParade
            // 
            this.dgvHitParade.AllowUserToAddRows = false;
            this.dgvHitParade.AllowUserToDeleteRows = false;
            this.dgvHitParade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHitParade.Location = new System.Drawing.Point(12, 12);
            this.dgvHitParade.Name = "dgvHitParade";
            this.dgvHitParade.ReadOnly = true;
            this.dgvHitParade.Size = new System.Drawing.Size(378, 627);
            this.dgvHitParade.TabIndex = 0;
            // 
            // EcranHitParadeMedecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 651);
            this.Controls.Add(this.dgvHitParade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranHitParadeMedecins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hit parade des médecins";
            this.Load += new System.EventHandler(this.FicHitParadeMedecins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHitParade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHitParade;
    }
}