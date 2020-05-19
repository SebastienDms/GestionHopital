namespace SD_Gestion_Hopital
{
    partial class EcranDisponibiliteChambres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranDisponibiliteChambres));
            this.lblbTitreDispoCha = new System.Windows.Forms.Label();
            this.lblRechercheDispoCha = new System.Windows.Forms.Label();
            this.tbNumChaChercher = new System.Windows.Forms.TextBox();
            this.dgvDispoCha = new System.Windows.Forms.DataGridView();
            this.btnChercherChaDispo = new System.Windows.Forms.Button();
            this.lblNombreLitLibre = new System.Windows.Forms.Label();
            this.btnGenererHtml = new System.Windows.Forms.Button();
            this.btnReinitRecherche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispoCha)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbTitreDispoCha
            // 
            this.lblbTitreDispoCha.AutoSize = true;
            this.lblbTitreDispoCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbTitreDispoCha.Location = new System.Drawing.Point(251, 22);
            this.lblbTitreDispoCha.Name = "lblbTitreDispoCha";
            this.lblbTitreDispoCha.Size = new System.Drawing.Size(316, 20);
            this.lblbTitreDispoCha.TabIndex = 0;
            this.lblbTitreDispoCha.Text = "Visualisation hebdomadaire de la chambre :";
            // 
            // lblRechercheDispoCha
            // 
            this.lblRechercheDispoCha.AutoSize = true;
            this.lblRechercheDispoCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercheDispoCha.Location = new System.Drawing.Point(48, 84);
            this.lblRechercheDispoCha.Name = "lblRechercheDispoCha";
            this.lblRechercheDispoCha.Size = new System.Drawing.Size(299, 20);
            this.lblRechercheDispoCha.TabIndex = 2;
            this.lblRechercheDispoCha.Text = "Saisir le numéro de chambre à visualiser :";
            // 
            // tbNumChaChercher
            // 
            this.tbNumChaChercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumChaChercher.Location = new System.Drawing.Point(388, 81);
            this.tbNumChaChercher.Name = "tbNumChaChercher";
            this.tbNumChaChercher.Size = new System.Drawing.Size(134, 26);
            this.tbNumChaChercher.TabIndex = 3;
            // 
            // dgvDispoCha
            // 
            this.dgvDispoCha.AllowUserToAddRows = false;
            this.dgvDispoCha.AllowUserToDeleteRows = false;
            this.dgvDispoCha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispoCha.Location = new System.Drawing.Point(26, 162);
            this.dgvDispoCha.Name = "dgvDispoCha";
            this.dgvDispoCha.ReadOnly = true;
            this.dgvDispoCha.Size = new System.Drawing.Size(744, 200);
            this.dgvDispoCha.TabIndex = 4;
            // 
            // btnChercherChaDispo
            // 
            this.btnChercherChaDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercherChaDispo.Location = new System.Drawing.Point(575, 81);
            this.btnChercherChaDispo.Name = "btnChercherChaDispo";
            this.btnChercherChaDispo.Size = new System.Drawing.Size(148, 26);
            this.btnChercherChaDispo.TabIndex = 5;
            this.btnChercherChaDispo.Text = "C H E R C H E R";
            this.btnChercherChaDispo.UseVisualStyleBackColor = true;
            this.btnChercherChaDispo.Click += new System.EventHandler(this.btnChercherChaDispo_Click);
            // 
            // lblNombreLitLibre
            // 
            this.lblNombreLitLibre.AutoSize = true;
            this.lblNombreLitLibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLitLibre.Location = new System.Drawing.Point(48, 139);
            this.lblNombreLitLibre.Name = "lblNombreLitLibre";
            this.lblNombreLitLibre.Size = new System.Drawing.Size(159, 20);
            this.lblNombreLitLibre.TabIndex = 6;
            this.lblNombreLitLibre.Text = "Nombre de lits libres :";
            // 
            // btnGenererHtml
            // 
            this.btnGenererHtml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenererHtml.Location = new System.Drawing.Point(199, 386);
            this.btnGenererHtml.Name = "btnGenererHtml";
            this.btnGenererHtml.Size = new System.Drawing.Size(148, 31);
            this.btnGenererHtml.TabIndex = 7;
            this.btnGenererHtml.Text = "Générer fichier";
            this.btnGenererHtml.UseVisualStyleBackColor = true;
            this.btnGenererHtml.Click += new System.EventHandler(this.btnGenererHtml_Click);
            // 
            // btnReinitRecherche
            // 
            this.btnReinitRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinitRecherche.Location = new System.Drawing.Point(484, 386);
            this.btnReinitRecherche.Name = "btnReinitRecherche";
            this.btnReinitRecherche.Size = new System.Drawing.Size(181, 31);
            this.btnReinitRecherche.TabIndex = 8;
            this.btnReinitRecherche.Text = "Nouvelle recherche";
            this.btnReinitRecherche.UseVisualStyleBackColor = true;
            this.btnReinitRecherche.Click += new System.EventHandler(this.btnReinitRecherche_Click);
            // 
            // EcranDisponibiliteChambres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReinitRecherche);
            this.Controls.Add(this.btnGenererHtml);
            this.Controls.Add(this.lblNombreLitLibre);
            this.Controls.Add(this.btnChercherChaDispo);
            this.Controls.Add(this.dgvDispoCha);
            this.Controls.Add(this.tbNumChaChercher);
            this.Controls.Add(this.lblRechercheDispoCha);
            this.Controls.Add(this.lblbTitreDispoCha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranDisponibiliteChambres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Disponibilité des chambres";
            this.Load += new System.EventHandler(this.EcranDisponibiliteChambres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispoCha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbTitreDispoCha;
        private System.Windows.Forms.Label lblRechercheDispoCha;
        private System.Windows.Forms.TextBox tbNumChaChercher;
        private System.Windows.Forms.DataGridView dgvDispoCha;
        private System.Windows.Forms.Button btnChercherChaDispo;
        private System.Windows.Forms.Label lblNombreLitLibre;
        private System.Windows.Forms.Button btnGenererHtml;
        private System.Windows.Forms.Button btnReinitRecherche;
    }
}