namespace SD_Gestion_Hopital
{
    partial class EcranVisionneuseHTML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranVisionneuseHTML));
            this.wbDispoChaSem = new System.Windows.Forms.WebBrowser();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnOuvrirDossier = new System.Windows.Forms.Button();
            this.lvFichier = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbDispoChaSem
            // 
            this.wbDispoChaSem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbDispoChaSem.Location = new System.Drawing.Point(0, 0);
            this.wbDispoChaSem.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDispoChaSem.Name = "wbDispoChaSem";
            this.wbDispoChaSem.Size = new System.Drawing.Size(591, 450);
            this.wbDispoChaSem.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvFichier);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.wbDispoChaSem);
            this.splitContainer1.Size = new System.Drawing.Size(859, 450);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnOuvrirDossier
            // 
            this.btnOuvrirDossier.Location = new System.Drawing.Point(865, 209);
            this.btnOuvrirDossier.Name = "btnOuvrirDossier";
            this.btnOuvrirDossier.Size = new System.Drawing.Size(164, 62);
            this.btnOuvrirDossier.TabIndex = 1;
            this.btnOuvrirDossier.Text = "O U V R I R";
            this.btnOuvrirDossier.UseVisualStyleBackColor = true;
            this.btnOuvrirDossier.Click += new System.EventHandler(this.btnOuvrirDossier_Click);
            // 
            // lvFichier
            // 
            this.lvFichier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFichier.FullRowSelect = true;
            this.lvFichier.HideSelection = false;
            this.lvFichier.Location = new System.Drawing.Point(0, 0);
            this.lvFichier.MultiSelect = false;
            this.lvFichier.Name = "lvFichier";
            this.lvFichier.Size = new System.Drawing.Size(264, 450);
            this.lvFichier.TabIndex = 0;
            this.lvFichier.UseCompatibleStateImageBehavior = false;
            this.lvFichier.View = System.Windows.Forms.View.List;
            this.lvFichier.ItemActivate += new System.EventHandler(this.lvFichier_ItemActivate);
            // 
            // EcranVisionneuseHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.btnOuvrirDossier);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranVisionneuseHTML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aperçu disponibilté des lits des chambres";
            this.Load += new System.EventHandler(this.EcranVisionneuseHTML_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbDispoChaSem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnOuvrirDossier;
        private System.Windows.Forms.ListView lvFichier;
    }
}