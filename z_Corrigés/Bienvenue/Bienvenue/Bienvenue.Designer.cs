namespace Bienvenue
{
    partial class frmBienvenue
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenue));
            this.lblBienvenueTexte = new System.Windows.Forms.Label();
            this.lblBienvenueDate = new System.Windows.Forms.Label();
            this.cmFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenueTexte
            // 
            this.lblBienvenueTexte.AutoSize = true;
            this.lblBienvenueTexte.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenueTexte.Location = new System.Drawing.Point(42, 21);
            this.lblBienvenueTexte.Name = "lblBienvenueTexte";
            this.lblBienvenueTexte.Size = new System.Drawing.Size(373, 36);
            this.lblBienvenueTexte.TabIndex = 0;
            this.lblBienvenueTexte.Text = "Bonjour, nous sommes le";
            // 
            // lblBienvenueDate
            // 
            this.lblBienvenueDate.AutoSize = true;
            this.lblBienvenueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenueDate.Location = new System.Drawing.Point(44, 173);
            this.lblBienvenueDate.Name = "lblBienvenueDate";
            this.lblBienvenueDate.Size = new System.Drawing.Size(25, 24);
            this.lblBienvenueDate.TabIndex = 1;
            this.lblBienvenueDate.Text = "...";
            this.lblBienvenueDate.Click += new System.EventHandler(this.lblBienvenueDate_Click);
            // 
            // cmFermer
            // 
            this.cmFermer.Location = new System.Drawing.Point(307, 167);
            this.cmFermer.Name = "cmFermer";
            this.cmFermer.Size = new System.Drawing.Size(93, 40);
            this.cmFermer.TabIndex = 2;
            this.cmFermer.Text = "Fermer";
            this.cmFermer.UseVisualStyleBackColor = true;
            this.cmFermer.Click += new System.EventHandler(this.cmFermer_Click);
            // 
            // frmBienvenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(437, 240);
            this.Controls.Add(this.cmFermer);
            this.Controls.Add(this.lblBienvenueDate);
            this.Controls.Add(this.lblBienvenueTexte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 20);
            this.Name = "frmBienvenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cours C#";
            this.Load += new System.EventHandler(this.frmBienvenue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenueTexte;
        private System.Windows.Forms.Label lblBienvenueDate;
        private System.Windows.Forms.Button cmFermer;
    }
}

