namespace Déductions
{
    partial class frmMain
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
            this.txtBrut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoeff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDeducJeune = new System.Windows.Forms.CheckBox();
            this.chkDeducTrans = new System.Windows.Forms.CheckBox();
            this.chkRabaisFidélité = new System.Windows.Forms.CheckBox();
            this.lblRevenuImposable = new System.Windows.Forms.Label();
            this.cmdCalcul = new System.Windows.Forms.Button();
            this.txtDeducJeune = new System.Windows.Forms.TextBox();
            this.txtDeducTrans = new System.Windows.Forms.TextBox();
            this.txtRabais = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBrut
            // 
            this.txtBrut.Location = new System.Drawing.Point(152, 22);
            this.txtBrut.Name = "txtBrut";
            this.txtBrut.Size = new System.Drawing.Size(100, 20);
            this.txtBrut.TabIndex = 1;
            this.txtBrut.Text = "0";
            this.txtBrut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBrut.TextChanged += new System.EventHandler(this.txtBrut_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revenu annuel brut";
            // 
            // txtCoeff
            // 
            this.txtCoeff.Location = new System.Drawing.Point(208, 58);
            this.txtCoeff.Name = "txtCoeff";
            this.txtCoeff.Size = new System.Drawing.Size(44, 20);
            this.txtCoeff.TabIndex = 2;
            this.txtCoeff.Text = "1";
            this.txtCoeff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCoeff.TextChanged += new System.EventHandler(this.txtCoeff_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Coefficient familial";
            // 
            // chkDeducJeune
            // 
            this.chkDeducJeune.AutoSize = true;
            this.chkDeducJeune.Location = new System.Drawing.Point(53, 111);
            this.chkDeducJeune.Name = "chkDeducJeune";
            this.chkDeducJeune.Size = new System.Drawing.Size(104, 17);
            this.chkDeducJeune.TabIndex = 3;
            this.chkDeducJeune.Text = "Déduction jeune";
            this.chkDeducJeune.UseVisualStyleBackColor = true;
            // 
            // chkDeducTrans
            // 
            this.chkDeducTrans.AutoSize = true;
            this.chkDeducTrans.Location = new System.Drawing.Point(53, 137);
            this.chkDeducTrans.Name = "chkDeducTrans";
            this.chkDeducTrans.Size = new System.Drawing.Size(119, 17);
            this.chkDeducTrans.TabIndex = 5;
            this.chkDeducTrans.Text = "Déduction transport";
            this.chkDeducTrans.UseVisualStyleBackColor = true;
            // 
            // chkRabaisFidélité
            // 
            this.chkRabaisFidélité.AutoSize = true;
            this.chkRabaisFidélité.Location = new System.Drawing.Point(53, 163);
            this.chkRabaisFidélité.Name = "chkRabaisFidélité";
            this.chkRabaisFidélité.Size = new System.Drawing.Size(109, 17);
            this.chkRabaisFidélité.TabIndex = 7;
            this.chkRabaisFidélité.Text = "Rabais fidélité (%)";
            this.chkRabaisFidélité.UseVisualStyleBackColor = true;
            // 
            // lblRevenuImposable
            // 
            this.lblRevenuImposable.AutoSize = true;
            this.lblRevenuImposable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenuImposable.Location = new System.Drawing.Point(50, 234);
            this.lblRevenuImposable.Name = "lblRevenuImposable";
            this.lblRevenuImposable.Size = new System.Drawing.Size(0, 16);
            this.lblRevenuImposable.TabIndex = 0;
            // 
            // cmdCalcul
            // 
            this.cmdCalcul.Location = new System.Drawing.Point(91, 194);
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.Size = new System.Drawing.Size(75, 23);
            this.cmdCalcul.TabIndex = 9;
            this.cmdCalcul.Text = "Calcul";
            this.cmdCalcul.UseVisualStyleBackColor = true;
            this.cmdCalcul.Click += new System.EventHandler(this.cmdCalcul_Click);
            // 
            // txtDeducJeune
            // 
            this.txtDeducJeune.Location = new System.Drawing.Point(208, 109);
            this.txtDeducJeune.Name = "txtDeducJeune";
            this.txtDeducJeune.Size = new System.Drawing.Size(44, 20);
            this.txtDeducJeune.TabIndex = 4;
            this.txtDeducJeune.Text = "900";
            this.txtDeducJeune.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDeducJeune.TextChanged += new System.EventHandler(this.txtDeducJeune_TextChanged);
            // 
            // txtDeducTrans
            // 
            this.txtDeducTrans.Location = new System.Drawing.Point(208, 135);
            this.txtDeducTrans.Name = "txtDeducTrans";
            this.txtDeducTrans.Size = new System.Drawing.Size(44, 20);
            this.txtDeducTrans.TabIndex = 6;
            this.txtDeducTrans.Text = "650";
            this.txtDeducTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDeducTrans.TextChanged += new System.EventHandler(this.txtDeducTrans_TextChanged);
            // 
            // txtRabais
            // 
            this.txtRabais.Location = new System.Drawing.Point(208, 161);
            this.txtRabais.Name = "txtRabais";
            this.txtRabais.Size = new System.Drawing.Size(44, 20);
            this.txtRabais.TabIndex = 8;
            this.txtRabais.Text = "0";
            this.txtRabais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRabais.TextChanged += new System.EventHandler(this.txtRabais_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 269);
            this.Controls.Add(this.txtRabais);
            this.Controls.Add(this.txtDeducTrans);
            this.Controls.Add(this.txtDeducJeune);
            this.Controls.Add(this.cmdCalcul);
            this.Controls.Add(this.lblRevenuImposable);
            this.Controls.Add(this.chkRabaisFidélité);
            this.Controls.Add(this.chkDeducTrans);
            this.Controls.Add(this.chkDeducJeune);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCoeff);
            this.Controls.Add(this.txtBrut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCoeff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDeducJeune;
        private System.Windows.Forms.CheckBox chkDeducTrans;
        private System.Windows.Forms.CheckBox chkRabaisFidélité;
        private System.Windows.Forms.Label lblRevenuImposable;
        private System.Windows.Forms.Button cmdCalcul;
        private System.Windows.Forms.TextBox txtDeducJeune;
        private System.Windows.Forms.TextBox txtDeducTrans;
        private System.Windows.Forms.TextBox txtRabais;
    }
}

