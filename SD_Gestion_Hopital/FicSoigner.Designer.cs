namespace SD_Gestion_Hopital
{
    partial class EcranSoigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranSoigner));
            this.dgvSoins = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoins)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSoins
            // 
            this.dgvSoins.AllowUserToAddRows = false;
            this.dgvSoins.AllowUserToDeleteRows = false;
            this.dgvSoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoins.Location = new System.Drawing.Point(12, 12);
            this.dgvSoins.Name = "dgvSoins";
            this.dgvSoins.ReadOnly = true;
            this.dgvSoins.Size = new System.Drawing.Size(776, 319);
            this.dgvSoins.TabIndex = 0;
            // 
            // EcranSoigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSoins);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranSoigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des soins";
            this.Load += new System.EventHandler(this.EcranSoigner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSoins;
    }
}