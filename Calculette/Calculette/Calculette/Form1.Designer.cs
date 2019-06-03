namespace Calculette
{
    partial class frmCalculate
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.grpOperation = new System.Windows.Forms.GroupBox();
            this.optMoin = new System.Windows.Forms.RadioButton();
            this.optDiv = new System.Windows.Forms.RadioButton();
            this.optPlus = new System.Windows.Forms.RadioButton();
            this.optMult = new System.Windows.Forms.RadioButton();
            this.cmdCalcul = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblResultat2 = new System.Windows.Forms.Label();
            this.grpOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(27, 121);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(27, 198);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // grpOperation
            // 
            this.grpOperation.Controls.Add(this.optMoin);
            this.grpOperation.Controls.Add(this.optDiv);
            this.grpOperation.Controls.Add(this.optPlus);
            this.grpOperation.Controls.Add(this.optMult);
            this.grpOperation.Location = new System.Drawing.Point(12, 149);
            this.grpOperation.Name = "grpOperation";
            this.grpOperation.Size = new System.Drawing.Size(151, 43);
            this.grpOperation.TabIndex = 2;
            this.grpOperation.TabStop = false;
            // 
            // optMoin
            // 
            this.optMoin.AutoSize = true;
            this.optMoin.Location = new System.Drawing.Point(46, 19);
            this.optMoin.Name = "optMoin";
            this.optMoin.Size = new System.Drawing.Size(28, 17);
            this.optMoin.TabIndex = 6;
            this.optMoin.TabStop = true;
            this.optMoin.Text = "-";
            this.optMoin.UseVisualStyleBackColor = true;
            // 
            // optDiv
            // 
            this.optDiv.AutoSize = true;
            this.optDiv.Location = new System.Drawing.Point(120, 19);
            this.optDiv.Name = "optDiv";
            this.optDiv.Size = new System.Drawing.Size(30, 17);
            this.optDiv.TabIndex = 4;
            this.optDiv.TabStop = true;
            this.optDiv.Text = "/";
            this.optDiv.UseVisualStyleBackColor = true;
            // 
            // optPlus
            // 
            this.optPlus.AutoSize = true;
            this.optPlus.Checked = true;
            this.optPlus.Location = new System.Drawing.Point(9, 19);
            this.optPlus.Name = "optPlus";
            this.optPlus.Size = new System.Drawing.Size(31, 17);
            this.optPlus.TabIndex = 3;
            this.optPlus.TabStop = true;
            this.optPlus.Text = "+";
            this.optPlus.UseVisualStyleBackColor = true;
            // 
            // optMult
            // 
            this.optMult.AutoSize = true;
            this.optMult.Location = new System.Drawing.Point(83, 19);
            this.optMult.Name = "optMult";
            this.optMult.Size = new System.Drawing.Size(29, 17);
            this.optMult.TabIndex = 5;
            this.optMult.Text = "*";
            this.optMult.UseVisualStyleBackColor = true;
            // 
            // cmdCalcul
            // 
            this.cmdCalcul.Location = new System.Drawing.Point(215, 194);
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.Size = new System.Drawing.Size(75, 23);
            this.cmdCalcul.TabIndex = 3;
            this.cmdCalcul.Text = "Calcul";
            this.cmdCalcul.UseVisualStyleBackColor = true;
            this.cmdCalcul.Click += new System.EventHandler(this.CmdCalcul_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(283, 366);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(52, 13);
            this.lblResultat.TabIndex = 4;
            this.lblResultat.Text = "Résultat :";
            // 
            // lblResultat2
            // 
            this.lblResultat2.AutoSize = true;
            this.lblResultat2.Location = new System.Drawing.Point(293, 400);
            this.lblResultat2.Name = "lblResultat2";
            this.lblResultat2.Size = new System.Drawing.Size(0, 13);
            this.lblResultat2.TabIndex = 5;
            // 
            // frmCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.lblResultat2);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.cmdCalcul);
            this.Controls.Add(this.grpOperation);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "frmCalculate";
            this.Text = "Machine à calculer";
            this.grpOperation.ResumeLayout(false);
            this.grpOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.GroupBox grpOperation;
        private System.Windows.Forms.RadioButton optMoin;
        private System.Windows.Forms.RadioButton optDiv;
        private System.Windows.Forms.RadioButton optPlus;
        private System.Windows.Forms.RadioButton optMult;
        private System.Windows.Forms.Button cmdCalcul;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblResultat2;
    }
}

