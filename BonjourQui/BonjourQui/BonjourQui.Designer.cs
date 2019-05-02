namespace BonjourQui
{
    partial class BonjourQui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BonjourQui));
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.cmdBienvenue = new System.Windows.Forms.Button();
            this.lblBonjour = new System.Windows.Forms.Label();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(101, 39);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 20);
            this.txtNom.TabIndex = 0;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged_1);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(38, 42);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(57, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Votre Nom";
            // 
            // cmdBienvenue
            // 
            this.cmdBienvenue.Location = new System.Drawing.Point(146, 196);
            this.cmdBienvenue.Name = "cmdBienvenue";
            this.cmdBienvenue.Size = new System.Drawing.Size(155, 54);
            this.cmdBienvenue.TabIndex = 2;
            this.cmdBienvenue.Text = "Bienvenue";
            this.cmdBienvenue.UseVisualStyleBackColor = true;
            this.cmdBienvenue.Click += new System.EventHandler(this.cmdBienvenue_Click);
            // 
            // lblBonjour
            // 
            this.lblBonjour.AutoSize = true;
            this.lblBonjour.Location = new System.Drawing.Point(24, 123);
            this.lblBonjour.Name = "lblBonjour";
            this.lblBonjour.Size = new System.Drawing.Size(16, 13);
            this.lblBonjour.TabIndex = 3;
            this.lblBonjour.Text = "...";
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Image = ((System.Drawing.Image)(resources.GetObject("cmdQuitter.Image")));
            this.cmdQuitter.Location = new System.Drawing.Point(373, 211);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(37, 39);
            this.cmdQuitter.TabIndex = 4;
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // BonjourQui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.lblBonjour);
            this.Controls.Add(this.cmdBienvenue);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtNom);
            this.Name = "BonjourQui";
            this.Text = "BonjourQui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button cmdBienvenue;
        private System.Windows.Forms.Label lblBonjour;
        private System.Windows.Forms.Button cmdQuitter;
    }
}

