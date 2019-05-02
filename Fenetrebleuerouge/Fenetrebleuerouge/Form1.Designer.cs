namespace Fenetrebleuerouge
{
    partial class Fenetre
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
            this.cmdBleu = new System.Windows.Forms.Button();
            this.cmdRouge = new System.Windows.Forms.Button();
            this.cmdStats = new System.Windows.Forms.Button();
            this.cmdHautGauche = new System.Windows.Forms.Button();
            this.cmdHautDroit = new System.Windows.Forms.Button();
            this.cmdBasGauche = new System.Windows.Forms.Button();
            this.cmdBasDroit = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdGo = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdBleu
            // 
            this.cmdBleu.Location = new System.Drawing.Point(201, 95);
            this.cmdBleu.Name = "cmdBleu";
            this.cmdBleu.Size = new System.Drawing.Size(68, 25);
            this.cmdBleu.TabIndex = 0;
            this.cmdBleu.Text = "Bleu";
            this.cmdBleu.UseVisualStyleBackColor = true;
            this.cmdBleu.Click += new System.EventHandler(this.txtBleu_Click);
            // 
            // cmdRouge
            // 
            this.cmdRouge.Location = new System.Drawing.Point(201, 149);
            this.cmdRouge.Name = "cmdRouge";
            this.cmdRouge.Size = new System.Drawing.Size(68, 23);
            this.cmdRouge.TabIndex = 1;
            this.cmdRouge.Text = "Rouge";
            this.cmdRouge.UseVisualStyleBackColor = true;
            this.cmdRouge.Click += new System.EventHandler(this.txtRouge_Click);
            // 
            // cmdStats
            // 
            this.cmdStats.Location = new System.Drawing.Point(201, 202);
            this.cmdStats.Name = "cmdStats";
            this.cmdStats.Size = new System.Drawing.Size(68, 23);
            this.cmdStats.TabIndex = 2;
            this.cmdStats.Text = "Stats";
            this.cmdStats.UseVisualStyleBackColor = true;
            this.cmdStats.Click += new System.EventHandler(this.txtStats_Click);
            // 
            // cmdHautGauche
            // 
            this.cmdHautGauche.Location = new System.Drawing.Point(2, 1);
            this.cmdHautGauche.Name = "cmdHautGauche";
            this.cmdHautGauche.Size = new System.Drawing.Size(75, 23);
            this.cmdHautGauche.TabIndex = 4;
            this.cmdHautGauche.Text = "Haut/Gauche";
            this.cmdHautGauche.UseVisualStyleBackColor = true;
            this.cmdHautGauche.Click += new System.EventHandler(this.txtHautGauche_Click);
            // 
            // cmdHautDroit
            // 
            this.cmdHautDroit.Location = new System.Drawing.Point(378, 1);
            this.cmdHautDroit.Name = "cmdHautDroit";
            this.cmdHautDroit.Size = new System.Drawing.Size(75, 23);
            this.cmdHautDroit.TabIndex = 5;
            this.cmdHautDroit.Text = "Haut/Droite";
            this.cmdHautDroit.UseVisualStyleBackColor = true;
            this.cmdHautDroit.Click += new System.EventHandler(this.txtHautDroit_Click);
            // 
            // cmdBasGauche
            // 
            this.cmdBasGauche.Location = new System.Drawing.Point(2, 424);
            this.cmdBasGauche.Name = "cmdBasGauche";
            this.cmdBasGauche.Size = new System.Drawing.Size(75, 23);
            this.cmdBasGauche.TabIndex = 6;
            this.cmdBasGauche.Text = "Bas/Gauche";
            this.cmdBasGauche.UseVisualStyleBackColor = true;
            this.cmdBasGauche.Click += new System.EventHandler(this.txtBasGauche_Click);
            // 
            // cmdBasDroit
            // 
            this.cmdBasDroit.Location = new System.Drawing.Point(378, 424);
            this.cmdBasDroit.Name = "cmdBasDroit";
            this.cmdBasDroit.Size = new System.Drawing.Size(75, 23);
            this.cmdBasDroit.TabIndex = 7;
            this.cmdBasDroit.Text = "Bas/Droite";
            this.cmdBasDroit.UseVisualStyleBackColor = true;
            this.cmdBasDroit.Click += new System.EventHandler(this.txtBasDroit_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(201, 251);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(68, 25);
            this.cmdQuitter.TabIndex = 8;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.txtQuitter_Click);
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(81, 197);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(75, 23);
            this.cmdGo.TabIndex = 9;
            this.cmdGo.Text = "Go";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(48, 217);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(27, 20);
            this.txtY.TabIndex = 11;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(48, 180);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(27, 20);
            this.txtX.TabIndex = 12;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(28, 183);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 13;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(28, 220);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 14;
            this.lblY.Text = "Y";
            // 
            // Fenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdBasDroit);
            this.Controls.Add(this.cmdBasGauche);
            this.Controls.Add(this.cmdHautDroit);
            this.Controls.Add(this.cmdHautGauche);
            this.Controls.Add(this.cmdStats);
            this.Controls.Add(this.cmdRouge);
            this.Controls.Add(this.cmdBleu);
            this.Name = "Fenetre";
            this.Text = "Fenetre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBleu;
        private System.Windows.Forms.Button cmdRouge;
        private System.Windows.Forms.Button cmdStats;
        private System.Windows.Forms.Button cmdHautGauche;
        private System.Windows.Forms.Button cmdHautDroit;
        private System.Windows.Forms.Button cmdBasGauche;
        private System.Windows.Forms.Button cmdBasDroit;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
    }
}

