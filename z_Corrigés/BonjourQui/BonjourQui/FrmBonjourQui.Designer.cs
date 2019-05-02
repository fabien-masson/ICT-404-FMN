namespace BonjourQui
{
    partial class FrmBonjourQui
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmdBienvenue = new System.Windows.Forms.Button();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votre nom";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(107, 6);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(165, 30);
            this.txtNom.TabIndex = 1;
            this.txtNom.TextChanged += new System.EventHandler(this.k);
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(12, 63);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(31, 23);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "...";
            // 
            // cmdBienvenue
            // 
            this.cmdBienvenue.Enabled = false;
            this.cmdBienvenue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBienvenue.Location = new System.Drawing.Point(84, 102);
            this.cmdBienvenue.Name = "cmdBienvenue";
            this.cmdBienvenue.Size = new System.Drawing.Size(109, 37);
            this.cmdBienvenue.TabIndex = 3;
            this.cmdBienvenue.Text = "Bienvenue";
            this.cmdBienvenue.UseVisualStyleBackColor = true;
            this.cmdBienvenue.Click += new System.EventHandler(this.cmdBienvenue_Click);
            this.cmdBienvenue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmdBienvenue_KeyPress);
            // 
            // cmdQuit
            // 
            this.cmdQuit.Image = global::BonjourQui.Properties.Resources.a;
            this.cmdQuit.Location = new System.Drawing.Point(233, 102);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(39, 37);
            this.cmdQuit.TabIndex = 4;
            this.cmdQuit.UseVisualStyleBackColor = true;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // FrmBonjourQui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdBienvenue);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBonjourQui";
            this.Text = "Bonjour Qui ?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button cmdBienvenue;
        private System.Windows.Forms.Button cmdQuit;
    }
}

