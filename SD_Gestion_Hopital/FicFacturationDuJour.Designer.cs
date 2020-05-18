namespace SD_Gestion_Hopital
{
    partial class EcranFacturationDuJour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranFacturationDuJour));
            this.dgvAFacturer = new System.Windows.Forms.DataGridView();
            this.btnFacturation = new System.Windows.Forms.Button();
            this.lblNoFacture = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAFacturer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAFacturer
            // 
            this.dgvAFacturer.AllowUserToAddRows = false;
            this.dgvAFacturer.AllowUserToDeleteRows = false;
            this.dgvAFacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAFacturer.Location = new System.Drawing.Point(12, 12);
            this.dgvAFacturer.Name = "dgvAFacturer";
            this.dgvAFacturer.ReadOnly = true;
            this.dgvAFacturer.Size = new System.Drawing.Size(328, 426);
            this.dgvAFacturer.TabIndex = 0;
            // 
            // btnFacturation
            // 
            this.btnFacturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturation.Location = new System.Drawing.Point(535, 201);
            this.btnFacturation.Name = "btnFacturation";
            this.btnFacturation.Size = new System.Drawing.Size(253, 58);
            this.btnFacturation.TabIndex = 1;
            this.btnFacturation.Text = "Lancer la facturation";
            this.btnFacturation.UseVisualStyleBackColor = true;
            this.btnFacturation.Click += new System.EventHandler(this.btnFacturation_Click);
            // 
            // lblNoFacture
            // 
            this.lblNoFacture.AutoSize = true;
            this.lblNoFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoFacture.Location = new System.Drawing.Point(368, 221);
            this.lblNoFacture.Name = "lblNoFacture";
            this.lblNoFacture.Size = new System.Drawing.Size(0, 20);
            this.lblNoFacture.TabIndex = 2;
            // 
            // EcranFacturationDuJour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNoFacture);
            this.Controls.Add(this.btnFacturation);
            this.Controls.Add(this.dgvAFacturer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranFacturationDuJour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facturation du jour";
            this.Load += new System.EventHandler(this.EcranFacturationDuJour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAFacturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAFacturer;
        private System.Windows.Forms.Button btnFacturation;
        private System.Windows.Forms.Label lblNoFacture;
    }
}