namespace Déductions
{
    partial class Déductions
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
            this.chkDéductionJeunes = new System.Windows.Forms.CheckBox();
            this.chkDéductionTransports = new System.Windows.Forms.CheckBox();
            this.chkRabaisFidélité = new System.Windows.Forms.CheckBox();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.txtBox5 = new System.Windows.Forms.TextBox();
            this.cmdCalcul = new System.Windows.Forms.Button();
            this.lblRevenuAnnuelBrut = new System.Windows.Forms.Label();
            this.lblCoefficientFamillial = new System.Windows.Forms.Label();
            this.lblRevenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkDéductionJeunes
            // 
            this.chkDéductionJeunes.AutoSize = true;
            this.chkDéductionJeunes.Location = new System.Drawing.Point(101, 186);
            this.chkDéductionJeunes.Name = "chkDéductionJeunes";
            this.chkDéductionJeunes.Size = new System.Drawing.Size(109, 17);
            this.chkDéductionJeunes.TabIndex = 0;
            this.chkDéductionJeunes.Text = "Déduction jeunes";
            this.chkDéductionJeunes.UseVisualStyleBackColor = true;
            // 
            // chkDéductionTransports
            // 
            this.chkDéductionTransports.AutoSize = true;
            this.chkDéductionTransports.Location = new System.Drawing.Point(101, 212);
            this.chkDéductionTransports.Name = "chkDéductionTransports";
            this.chkDéductionTransports.Size = new System.Drawing.Size(128, 17);
            this.chkDéductionTransports.TabIndex = 1;
            this.chkDéductionTransports.Text = "Déduction Transports";
            this.chkDéductionTransports.UseVisualStyleBackColor = true;
            // 
            // chkRabaisFidélité
            // 
            this.chkRabaisFidélité.AutoSize = true;
            this.chkRabaisFidélité.Location = new System.Drawing.Point(101, 238);
            this.chkRabaisFidélité.Name = "chkRabaisFidélité";
            this.chkRabaisFidélité.Size = new System.Drawing.Size(109, 17);
            this.chkRabaisFidélité.TabIndex = 2;
            this.chkRabaisFidélité.Text = "Rabais fidélité (%)";
            this.chkRabaisFidélité.UseVisualStyleBackColor = true;
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(236, 70);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(100, 20);
            this.txtBox1.TabIndex = 3;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(236, 115);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(100, 20);
            this.txtBox2.TabIndex = 4;
            this.txtBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(236, 184);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(100, 20);
            this.txtBox3.TabIndex = 5;
            this.txtBox3.Text = "900";
            // 
            // txtBox4
            // 
            this.txtBox4.Location = new System.Drawing.Point(236, 210);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(100, 20);
            this.txtBox4.TabIndex = 6;
            this.txtBox4.Text = "650";
            // 
            // txtBox5
            // 
            this.txtBox5.Location = new System.Drawing.Point(236, 236);
            this.txtBox5.Name = "txtBox5";
            this.txtBox5.Size = new System.Drawing.Size(100, 20);
            this.txtBox5.TabIndex = 7;
            this.txtBox5.Text = "4";
            // 
            // cmdCalcul
            // 
            this.cmdCalcul.Location = new System.Drawing.Point(105, 287);
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.Size = new System.Drawing.Size(76, 30);
            this.cmdCalcul.TabIndex = 8;
            this.cmdCalcul.Text = "Calcul";
            this.cmdCalcul.UseVisualStyleBackColor = true;
            this.cmdCalcul.Click += new System.EventHandler(this.cmdCalcul_Click);
            // 
            // lblRevenuAnnuelBrut
            // 
            this.lblRevenuAnnuelBrut.AutoSize = true;
            this.lblRevenuAnnuelBrut.Location = new System.Drawing.Point(76, 73);
            this.lblRevenuAnnuelBrut.Name = "lblRevenuAnnuelBrut";
            this.lblRevenuAnnuelBrut.Size = new System.Drawing.Size(101, 13);
            this.lblRevenuAnnuelBrut.TabIndex = 9;
            this.lblRevenuAnnuelBrut.Text = "Revenu annuel brut";
            // 
            // lblCoefficientFamillial
            // 
            this.lblCoefficientFamillial.AutoSize = true;
            this.lblCoefficientFamillial.Location = new System.Drawing.Point(76, 118);
            this.lblCoefficientFamillial.Name = "lblCoefficientFamillial";
            this.lblCoefficientFamillial.Size = new System.Drawing.Size(93, 13);
            this.lblCoefficientFamillial.TabIndex = 10;
            this.lblCoefficientFamillial.Text = "Coefficient famillial";
            // 
            // lblRevenu
            // 
            this.lblRevenu.AutoSize = true;
            this.lblRevenu.Location = new System.Drawing.Point(181, 390);
            this.lblRevenu.Name = "lblRevenu";
            this.lblRevenu.Size = new System.Drawing.Size(0, 13);
            this.lblRevenu.TabIndex = 11;
            // 
            // Déductions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.lblRevenu);
            this.Controls.Add(this.lblCoefficientFamillial);
            this.Controls.Add(this.lblRevenuAnnuelBrut);
            this.Controls.Add(this.cmdCalcul);
            this.Controls.Add(this.txtBox5);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.chkRabaisFidélité);
            this.Controls.Add(this.chkDéductionTransports);
            this.Controls.Add(this.chkDéductionJeunes);
            this.Name = "Déductions";
            this.Text = "Déductions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDéductionJeunes;
        private System.Windows.Forms.CheckBox chkDéductionTransports;
        private System.Windows.Forms.CheckBox chkRabaisFidélité;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.TextBox txtBox5;
        private System.Windows.Forms.Button cmdCalcul;
        private System.Windows.Forms.Label lblRevenuAnnuelBrut;
        private System.Windows.Forms.Label lblCoefficientFamillial;
        private System.Windows.Forms.Label lblRevenu;
    }
}

