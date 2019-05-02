namespace Fenetre
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
            this.cmdHG = new System.Windows.Forms.Button();
            this.cmdHD = new System.Windows.Forms.Button();
            this.cmdBD = new System.Windows.Forms.Button();
            this.cmdBG = new System.Windows.Forms.Button();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.cmdStats = new System.Windows.Forms.Button();
            this.txtGoX = new System.Windows.Forms.TextBox();
            this.txtGoY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdGoXY = new System.Windows.Forms.Button();
            this.cmdHaut = new System.Windows.Forms.Button();
            this.cmdBas = new System.Windows.Forms.Button();
            this.cmdDroite = new System.Windows.Forms.Button();
            this.cmdGauche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdBleu
            // 
            this.cmdBleu.Location = new System.Drawing.Point(132, 52);
            this.cmdBleu.Name = "cmdBleu";
            this.cmdBleu.Size = new System.Drawing.Size(75, 23);
            this.cmdBleu.TabIndex = 0;
            this.cmdBleu.Text = "Bleu";
            this.cmdBleu.UseVisualStyleBackColor = true;
            this.cmdBleu.Click += new System.EventHandler(this.cmdBleu_Click);
            // 
            // cmdRouge
            // 
            this.cmdRouge.Location = new System.Drawing.Point(132, 81);
            this.cmdRouge.Name = "cmdRouge";
            this.cmdRouge.Size = new System.Drawing.Size(75, 23);
            this.cmdRouge.TabIndex = 1;
            this.cmdRouge.Text = "Rouge";
            this.cmdRouge.UseVisualStyleBackColor = true;
            this.cmdRouge.Click += new System.EventHandler(this.cmdRouge_Click);
            // 
            // cmdHG
            // 
            this.cmdHG.Location = new System.Drawing.Point(2, 2);
            this.cmdHG.Name = "cmdHG";
            this.cmdHG.Size = new System.Drawing.Size(85, 23);
            this.cmdHG.TabIndex = 2;
            this.cmdHG.Text = "Haut/Gauche";
            this.cmdHG.UseVisualStyleBackColor = true;
            this.cmdHG.Click += new System.EventHandler(this.cmdHG_Click);
            // 
            // cmdHD
            // 
            this.cmdHD.Location = new System.Drawing.Point(245, 2);
            this.cmdHD.Name = "cmdHD";
            this.cmdHD.Size = new System.Drawing.Size(85, 23);
            this.cmdHD.TabIndex = 3;
            this.cmdHD.Text = "Haut/Droite";
            this.cmdHD.UseVisualStyleBackColor = true;
            this.cmdHD.Click += new System.EventHandler(this.cmdHD_Click);
            // 
            // cmdBD
            // 
            this.cmdBD.Location = new System.Drawing.Point(245, 247);
            this.cmdBD.Name = "cmdBD";
            this.cmdBD.Size = new System.Drawing.Size(85, 23);
            this.cmdBD.TabIndex = 4;
            this.cmdBD.Text = "Bas/Droite";
            this.cmdBD.UseVisualStyleBackColor = true;
            this.cmdBD.Click += new System.EventHandler(this.cmdBD_Click);
            // 
            // cmdBG
            // 
            this.cmdBG.Location = new System.Drawing.Point(2, 247);
            this.cmdBG.Name = "cmdBG";
            this.cmdBG.Size = new System.Drawing.Size(85, 23);
            this.cmdBG.TabIndex = 5;
            this.cmdBG.Text = "Bas/Gauche";
            this.cmdBG.UseVisualStyleBackColor = true;
            this.cmdBG.Click += new System.EventHandler(this.cmdBG_Click);
            // 
            // cmdQuit
            // 
            this.cmdQuit.Location = new System.Drawing.Point(132, 184);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(75, 23);
            this.cmdQuit.TabIndex = 7;
            this.cmdQuit.Text = "Quitter";
            this.cmdQuit.UseVisualStyleBackColor = true;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // cmdStats
            // 
            this.cmdStats.Location = new System.Drawing.Point(132, 135);
            this.cmdStats.Name = "cmdStats";
            this.cmdStats.Size = new System.Drawing.Size(75, 23);
            this.cmdStats.TabIndex = 8;
            this.cmdStats.Text = "Stats";
            this.cmdStats.UseVisualStyleBackColor = true;
            this.cmdStats.Click += new System.EventHandler(this.cmdStats_Click);
            // 
            // txtGoX
            // 
            this.txtGoX.Location = new System.Drawing.Point(22, 112);
            this.txtGoX.Name = "txtGoX";
            this.txtGoX.Size = new System.Drawing.Size(25, 20);
            this.txtGoX.TabIndex = 9;
            // 
            // txtGoY
            // 
            this.txtGoY.Location = new System.Drawing.Point(22, 138);
            this.txtGoY.Name = "txtGoY";
            this.txtGoY.Size = new System.Drawing.Size(25, 20);
            this.txtGoY.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Y";
            // 
            // cmdGoXY
            // 
            this.cmdGoXY.Location = new System.Drawing.Point(53, 124);
            this.cmdGoXY.Name = "cmdGoXY";
            this.cmdGoXY.Size = new System.Drawing.Size(39, 23);
            this.cmdGoXY.TabIndex = 13;
            this.cmdGoXY.Text = "Aller";
            this.cmdGoXY.UseVisualStyleBackColor = true;
            this.cmdGoXY.Click += new System.EventHandler(this.cmdGoXY_Click);
            // 
            // cmdHaut
            // 
            this.cmdHaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHaut.Location = new System.Drawing.Point(276, 81);
            this.cmdHaut.Name = "cmdHaut";
            this.cmdHaut.Size = new System.Drawing.Size(25, 23);
            this.cmdHaut.TabIndex = 14;
            this.cmdHaut.Text = "H";
            this.cmdHaut.UseVisualStyleBackColor = true;
            this.cmdHaut.MouseHover += new System.EventHandler(this.cmdHaut_MouseHover);
            // 
            // cmdBas
            // 
            this.cmdBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBas.Location = new System.Drawing.Point(276, 124);
            this.cmdBas.Name = "cmdBas";
            this.cmdBas.Size = new System.Drawing.Size(25, 23);
            this.cmdBas.TabIndex = 15;
            this.cmdBas.Text = "B";
            this.cmdBas.UseVisualStyleBackColor = true;
            this.cmdBas.MouseHover += new System.EventHandler(this.cmdBas_MouseHover);
            // 
            // cmdDroite
            // 
            this.cmdDroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDroite.Location = new System.Drawing.Point(299, 102);
            this.cmdDroite.Name = "cmdDroite";
            this.cmdDroite.Size = new System.Drawing.Size(25, 23);
            this.cmdDroite.TabIndex = 16;
            this.cmdDroite.Text = "D";
            this.cmdDroite.UseVisualStyleBackColor = true;
            this.cmdDroite.MouseHover += new System.EventHandler(this.cmdDroite_MouseHover);
            // 
            // cmdGauche
            // 
            this.cmdGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGauche.Location = new System.Drawing.Point(252, 102);
            this.cmdGauche.Name = "cmdGauche";
            this.cmdGauche.Size = new System.Drawing.Size(25, 23);
            this.cmdGauche.TabIndex = 17;
            this.cmdGauche.Text = "G";
            this.cmdGauche.UseVisualStyleBackColor = true;
            this.cmdGauche.MouseHover += new System.EventHandler(this.cmdGauche_MouseHover);
            // 
            // Fenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 273);
            this.Controls.Add(this.cmdGauche);
            this.Controls.Add(this.cmdDroite);
            this.Controls.Add(this.cmdBas);
            this.Controls.Add(this.cmdHaut);
            this.Controls.Add(this.cmdGoXY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGoY);
            this.Controls.Add(this.txtGoX);
            this.Controls.Add(this.cmdStats);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdBG);
            this.Controls.Add(this.cmdBD);
            this.Controls.Add(this.cmdHD);
            this.Controls.Add(this.cmdHG);
            this.Controls.Add(this.cmdRouge);
            this.Controls.Add(this.cmdBleu);
            this.Name = "Fenetre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fenetre";
            this.Load += new System.EventHandler(this.Fenetre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBleu;
        private System.Windows.Forms.Button cmdRouge;
        private System.Windows.Forms.Button cmdHG;
        private System.Windows.Forms.Button cmdHD;
        private System.Windows.Forms.Button cmdBD;
        private System.Windows.Forms.Button cmdBG;
        private System.Windows.Forms.Button cmdQuit;
        private System.Windows.Forms.Button cmdStats;
        private System.Windows.Forms.TextBox txtGoX;
        private System.Windows.Forms.TextBox txtGoY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdGoXY;
        private System.Windows.Forms.Button cmdHaut;
        private System.Windows.Forms.Button cmdBas;
        private System.Windows.Forms.Button cmdDroite;
        private System.Windows.Forms.Button cmdGauche;
    }
}

