namespace SD_Gestion_Hopital
{
    partial class EcranSpecialites
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
            this.dgvSpecialites = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialites)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpecialites
            // 
            this.dgvSpecialites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecialites.Location = new System.Drawing.Point(12, 12);
            this.dgvSpecialites.Name = "dgvSpecialites";
            this.dgvSpecialites.Size = new System.Drawing.Size(776, 359);
            this.dgvSpecialites.TabIndex = 0;
            // 
            // EcranSpecialites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSpecialites);
            this.Name = "EcranSpecialites";
            this.Text = "Liste des spécialités";
            this.Load += new System.EventHandler(this.EcranSpecialites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialites)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpecialites;
    }
}