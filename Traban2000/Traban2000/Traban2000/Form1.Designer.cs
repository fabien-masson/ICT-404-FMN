namespace Traban2000
{
    partial class Form1
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
            this.lblPrixBase = new System.Windows.Forms.Label();
            this.txtPrixBase = new System.Windows.Forms.TextBox();
            this.lblMoteur = new System.Windows.Forms.Label();
            this.grpMoteur = new System.Windows.Forms.GroupBox();
            this.opt14 = new System.Windows.Forms.RadioButton();
            this.opt16 = new System.Windows.Forms.RadioButton();
            this.chkTaxes = new System.Windows.Forms.CheckBox();
            this.txtTaxes = new System.Windows.Forms.TextBox();
            this.cmdValeurs = new System.Windows.Forms.Button();
            this.cmdTotal = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grpMoteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrixBase
            // 
            this.lblPrixBase.AutoSize = true;
            this.lblPrixBase.Location = new System.Drawing.Point(25, 58);
            this.lblPrixBase.Name = "lblPrixBase";
            this.lblPrixBase.Size = new System.Drawing.Size(65, 13);
            this.lblPrixBase.TabIndex = 0;
            this.lblPrixBase.Text = "Prix de base";
            // 
            // txtPrixBase
            // 
            this.txtPrixBase.Location = new System.Drawing.Point(96, 55);
            this.txtPrixBase.Name = "txtPrixBase";
            this.txtPrixBase.Size = new System.Drawing.Size(100, 20);
            this.txtPrixBase.TabIndex = 1;
            this.txtPrixBase.Text = "12300";
            // 
            // lblMoteur
            // 
            this.lblMoteur.AutoSize = true;
            this.lblMoteur.Location = new System.Drawing.Point(34, 114);
            this.lblMoteur.Name = "lblMoteur";
            this.lblMoteur.Size = new System.Drawing.Size(40, 13);
            this.lblMoteur.TabIndex = 2;
            this.lblMoteur.Text = "Moteur";
            // 
            // grpMoteur
            // 
            this.grpMoteur.Controls.Add(this.opt16);
            this.grpMoteur.Controls.Add(this.opt14);
            this.grpMoteur.Location = new System.Drawing.Point(92, 116);
            this.grpMoteur.Name = "grpMoteur";
            this.grpMoteur.Size = new System.Drawing.Size(203, 78);
            this.grpMoteur.TabIndex = 3;
            this.grpMoteur.TabStop = false;
            // 
            // opt14
            // 
            this.opt14.AutoSize = true;
            this.opt14.Location = new System.Drawing.Point(6, 10);
            this.opt14.Name = "opt14";
            this.opt14.Size = new System.Drawing.Size(174, 17);
            this.opt14.TabIndex = 0;
            this.opt14.TabStop = true;
            this.opt14.Text = "1.4L, inclut dans le prix de base";
            this.opt14.UseVisualStyleBackColor = true;
            // 
            // opt16
            // 
            this.opt16.AutoSize = true;
            this.opt16.Location = new System.Drawing.Point(6, 33);
            this.opt16.Name = "opt16";
            this.opt16.Size = new System.Drawing.Size(82, 17);
            this.opt16.TabIndex = 1;
            this.opt16.TabStop = true;
            this.opt16.Text = "1.6L, 2210$";
            this.opt16.UseVisualStyleBackColor = true;
            // 
            // chkTaxes
            // 
            this.chkTaxes.AutoSize = true;
            this.chkTaxes.Location = new System.Drawing.Point(57, 205);
            this.chkTaxes.Name = "chkTaxes";
            this.chkTaxes.Size = new System.Drawing.Size(55, 17);
            this.chkTaxes.TabIndex = 4;
            this.chkTaxes.Text = "Taxes";
            this.chkTaxes.UseVisualStyleBackColor = true;
            // 
            // txtTaxes
            // 
            this.txtTaxes.Location = new System.Drawing.Point(118, 205);
            this.txtTaxes.Name = "txtTaxes";
            this.txtTaxes.Size = new System.Drawing.Size(36, 20);
            this.txtTaxes.TabIndex = 5;
            this.txtTaxes.Text = "6.8";
            // 
            // cmdValeurs
            // 
            this.cmdValeurs.Location = new System.Drawing.Point(28, 264);
            this.cmdValeurs.Name = "cmdValeurs";
            this.cmdValeurs.Size = new System.Drawing.Size(106, 23);
            this.cmdValeurs.TabIndex = 6;
            this.cmdValeurs.Text = "Valeurs initiales";
            this.cmdValeurs.UseVisualStyleBackColor = true;
            // 
            // cmdTotal
            // 
            this.cmdTotal.Location = new System.Drawing.Point(266, 270);
            this.cmdTotal.Name = "cmdTotal";
            this.cmdTotal.Size = new System.Drawing.Size(75, 23);
            this.cmdTotal.TabIndex = 7;
            this.cmdTotal.Text = "Total";
            this.cmdTotal.UseVisualStyleBackColor = true;
            this.cmdTotal.Click += new System.EventHandler(this.cmdTotal_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(266, 299);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(181, 64);
            this.txtTotal.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 396);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cmdTotal);
            this.Controls.Add(this.cmdValeurs);
            this.Controls.Add(this.txtTaxes);
            this.Controls.Add(this.chkTaxes);
            this.Controls.Add(this.grpMoteur);
            this.Controls.Add(this.lblMoteur);
            this.Controls.Add(this.txtPrixBase);
            this.Controls.Add(this.lblPrixBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMoteur.ResumeLayout(false);
            this.grpMoteur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrixBase;
        private System.Windows.Forms.TextBox txtPrixBase;
        private System.Windows.Forms.Label lblMoteur;
        private System.Windows.Forms.GroupBox grpMoteur;
        private System.Windows.Forms.RadioButton opt16;
        private System.Windows.Forms.RadioButton opt14;
        private System.Windows.Forms.CheckBox chkTaxes;
        private System.Windows.Forms.TextBox txtTaxes;
        private System.Windows.Forms.Button cmdValeurs;
        private System.Windows.Forms.Button cmdTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

