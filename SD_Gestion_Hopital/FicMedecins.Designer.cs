namespace SD_Gestion_Hopital
{
    partial class EcranMedecins
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
            this.dgvMedecins = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecins)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedecins
            // 
            this.dgvMedecins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedecins.Location = new System.Drawing.Point(12, 12);
            this.dgvMedecins.Name = "dgvMedecins";
            this.dgvMedecins.RowHeadersVisible = false;
            this.dgvMedecins.Size = new System.Drawing.Size(776, 362);
            this.dgvMedecins.TabIndex = 0;
            // 
            // EcranMedecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMedecins);
            this.Name = "EcranMedecins";
            this.Text = "Médecins de l\'hopital";
            this.Load += new System.EventHandler(this.EcranMedecins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedecins;
    }
}