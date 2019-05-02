namespace Arche_de_noe
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.cmdMove = new System.Windows.Forms.Button();
            this.cmdMove2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Rinophéros",
            "Pikachu",
            "Bill Gates",
            "Albinos",
            "Lapin",
            "Bob Marley",
            "ephélant",
            "Laos",
            "Kangourou",
            "Luca Bassi"});
            this.listBox1.Location = new System.Drawing.Point(94, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 251);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(322, 113);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(116, 251);
            this.listBox2.TabIndex = 1;
            // 
            // cmdMove
            // 
            this.cmdMove.Location = new System.Drawing.Point(231, 127);
            this.cmdMove.Name = "cmdMove";
            this.cmdMove.Size = new System.Drawing.Size(75, 23);
            this.cmdMove.TabIndex = 2;
            this.cmdMove.Text = "===>";
            this.cmdMove.UseVisualStyleBackColor = true;
            this.cmdMove.Click += new System.EventHandler(this.cmdMove_Click);
            // 
            // cmdMove2
            // 
            this.cmdMove2.Location = new System.Drawing.Point(231, 206);
            this.cmdMove2.Name = "cmdMove2";
            this.cmdMove2.Size = new System.Drawing.Size(75, 23);
            this.cmdMove2.TabIndex = 3;
            this.cmdMove2.Text = "<===";
            this.cmdMove2.UseVisualStyleBackColor = true;
            this.cmdMove2.Click += new System.EventHandler(this.cmdMove2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.cmdMove2);
            this.Controls.Add(this.cmdMove);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button cmdMove;
        private System.Windows.Forms.Button cmdMove2;
    }
}

