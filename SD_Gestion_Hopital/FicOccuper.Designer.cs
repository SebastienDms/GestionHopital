namespace SD_Gestion_Hopital
{
    partial class EcranOccuper
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
            this.dgvOccupation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccupation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOccupation
            // 
            this.dgvOccupation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOccupation.Location = new System.Drawing.Point(12, 12);
            this.dgvOccupation.Name = "dgvOccupation";
            this.dgvOccupation.Size = new System.Drawing.Size(776, 336);
            this.dgvOccupation.TabIndex = 0;
            // 
            // EcranOccuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOccupation);
            this.Name = "EcranOccuper";
            this.Text = "Liste des occupations des chambres";
            this.Load += new System.EventHandler(this.FicOccuper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccupation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOccupation;
    }
}