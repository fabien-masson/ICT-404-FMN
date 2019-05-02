namespace Pizza
{
    partial class Pizza
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
            this.cmdCommander = new System.Windows.Forms.Button();
            this.chkAnchois = new System.Windows.Forms.CheckBox();
            this.chkCâpres = new System.Windows.Forms.CheckBox();
            this.chkJambon = new System.Windows.Forms.CheckBox();
            this.chkCrevettes = new System.Windows.Forms.CheckBox();
            this.cmdBox = new System.Windows.Forms.TextBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblCommande = new System.Windows.Forms.Label();
            this.rdoExtraFine = new System.Windows.Forms.RadioButton();
            this.rdoFine = new System.Windows.Forms.RadioButton();
            this.rdoNormale = new System.Windows.Forms.RadioButton();
            this.rdoEpaisse = new System.Windows.Forms.RadioButton();
            this.gboxPizza = new System.Windows.Forms.GroupBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.gboxMozzarella = new System.Windows.Forms.GroupBox();
            this.rdoMaigre = new System.Windows.Forms.RadioButton();
            this.rdoBufflone = new System.Windows.Forms.RadioButton();
            this.rdoNormale2 = new System.Windows.Forms.RadioButton();
            this.gboxPizza.SuspendLayout();
            this.gboxMozzarella.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCommander
            // 
            this.cmdCommander.Location = new System.Drawing.Point(296, 332);
            this.cmdCommander.Name = "cmdCommander";
            this.cmdCommander.Size = new System.Drawing.Size(75, 23);
            this.cmdCommander.TabIndex = 0;
            this.cmdCommander.Text = "Commander";
            this.cmdCommander.UseVisualStyleBackColor = true;
            this.cmdCommander.Click += new System.EventHandler(this.cmdCommander_Click);
            // 
            // chkAnchois
            // 
            this.chkAnchois.AutoSize = true;
            this.chkAnchois.Location = new System.Drawing.Point(296, 57);
            this.chkAnchois.Name = "chkAnchois";
            this.chkAnchois.Size = new System.Drawing.Size(64, 17);
            this.chkAnchois.TabIndex = 1;
            this.chkAnchois.Text = "Anchois";
            this.chkAnchois.UseVisualStyleBackColor = true;
            // 
            // chkCâpres
            // 
            this.chkCâpres.AutoSize = true;
            this.chkCâpres.Location = new System.Drawing.Point(296, 80);
            this.chkCâpres.Name = "chkCâpres";
            this.chkCâpres.Size = new System.Drawing.Size(59, 17);
            this.chkCâpres.TabIndex = 2;
            this.chkCâpres.Text = "Câpres";
            this.chkCâpres.UseVisualStyleBackColor = true;
            // 
            // chkJambon
            // 
            this.chkJambon.AutoSize = true;
            this.chkJambon.Location = new System.Drawing.Point(296, 103);
            this.chkJambon.Name = "chkJambon";
            this.chkJambon.Size = new System.Drawing.Size(63, 17);
            this.chkJambon.TabIndex = 3;
            this.chkJambon.Text = "Jambon";
            this.chkJambon.UseVisualStyleBackColor = true;
            this.chkJambon.CheckedChanged += new System.EventHandler(this.chkJambon_CheckedChanged);
            // 
            // chkCrevettes
            // 
            this.chkCrevettes.AutoSize = true;
            this.chkCrevettes.Location = new System.Drawing.Point(296, 126);
            this.chkCrevettes.Name = "chkCrevettes";
            this.chkCrevettes.Size = new System.Drawing.Size(71, 17);
            this.chkCrevettes.TabIndex = 4;
            this.chkCrevettes.Text = "Crevettes";
            this.chkCrevettes.UseVisualStyleBackColor = true;
            this.chkCrevettes.CheckedChanged += new System.EventHandler(this.chkCrevettes_CheckedChanged);
            // 
            // cmdBox
            // 
            this.cmdBox.Location = new System.Drawing.Point(43, 12);
            this.cmdBox.Name = "cmdBox";
            this.cmdBox.Size = new System.Drawing.Size(33, 20);
            this.cmdBox.TabIndex = 5;
            this.cmdBox.Text = "42";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(2, 15);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(34, 13);
            this.lblTable.TabIndex = 6;
            this.lblTable.Text = "Table";
            // 
            // lblCommande
            // 
            this.lblCommande.AutoSize = true;
            this.lblCommande.Location = new System.Drawing.Point(40, 337);
            this.lblCommande.Name = "lblCommande";
            this.lblCommande.Size = new System.Drawing.Size(60, 13);
            this.lblCommande.TabIndex = 7;
            this.lblCommande.Text = "Commande";
            // 
            // rdoExtraFine
            // 
            this.rdoExtraFine.AutoSize = true;
            this.rdoExtraFine.Location = new System.Drawing.Point(6, 19);
            this.rdoExtraFine.Name = "rdoExtraFine";
            this.rdoExtraFine.Size = new System.Drawing.Size(72, 17);
            this.rdoExtraFine.TabIndex = 8;
            this.rdoExtraFine.TabStop = true;
            this.rdoExtraFine.Text = "Extra-Fine";
            this.rdoExtraFine.UseVisualStyleBackColor = true;
            // 
            // rdoFine
            // 
            this.rdoFine.AutoSize = true;
            this.rdoFine.Location = new System.Drawing.Point(6, 42);
            this.rdoFine.Name = "rdoFine";
            this.rdoFine.Size = new System.Drawing.Size(45, 17);
            this.rdoFine.TabIndex = 9;
            this.rdoFine.TabStop = true;
            this.rdoFine.Text = "Fine";
            this.rdoFine.UseVisualStyleBackColor = true;
            // 
            // rdoNormale
            // 
            this.rdoNormale.AutoSize = true;
            this.rdoNormale.Location = new System.Drawing.Point(6, 65);
            this.rdoNormale.Name = "rdoNormale";
            this.rdoNormale.Size = new System.Drawing.Size(64, 17);
            this.rdoNormale.TabIndex = 10;
            this.rdoNormale.TabStop = true;
            this.rdoNormale.Text = "Normale";
            this.rdoNormale.UseVisualStyleBackColor = true;
            // 
            // rdoEpaisse
            // 
            this.rdoEpaisse.AutoSize = true;
            this.rdoEpaisse.Location = new System.Drawing.Point(6, 88);
            this.rdoEpaisse.Name = "rdoEpaisse";
            this.rdoEpaisse.Size = new System.Drawing.Size(62, 17);
            this.rdoEpaisse.TabIndex = 11;
            this.rdoEpaisse.TabStop = true;
            this.rdoEpaisse.Text = "Epaisse";
            this.rdoEpaisse.UseVisualStyleBackColor = true;
            // 
            // gboxPizza
            // 
            this.gboxPizza.Controls.Add(this.rdoExtraFine);
            this.gboxPizza.Controls.Add(this.rdoEpaisse);
            this.gboxPizza.Controls.Add(this.rdoFine);
            this.gboxPizza.Controls.Add(this.rdoNormale);
            this.gboxPizza.Location = new System.Drawing.Point(12, 38);
            this.gboxPizza.Name = "gboxPizza";
            this.gboxPizza.Size = new System.Drawing.Size(88, 113);
            this.gboxPizza.TabIndex = 12;
            this.gboxPizza.TabStop = false;
            this.gboxPizza.Text = "Pâte";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(43, 370);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(328, 57);
            this.txtBox.TabIndex = 13;
            // 
            // gboxMozzarella
            // 
            this.gboxMozzarella.Controls.Add(this.rdoMaigre);
            this.gboxMozzarella.Controls.Add(this.rdoBufflone);
            this.gboxMozzarella.Controls.Add(this.rdoNormale2);
            this.gboxMozzarella.Location = new System.Drawing.Point(158, 38);
            this.gboxMozzarella.Name = "gboxMozzarella";
            this.gboxMozzarella.Size = new System.Drawing.Size(88, 89);
            this.gboxMozzarella.TabIndex = 13;
            this.gboxMozzarella.TabStop = false;
            this.gboxMozzarella.Text = "Mozzarella";
            // 
            // rdoMaigre
            // 
            this.rdoMaigre.AutoSize = true;
            this.rdoMaigre.Location = new System.Drawing.Point(6, 19);
            this.rdoMaigre.Name = "rdoMaigre";
            this.rdoMaigre.Size = new System.Drawing.Size(57, 17);
            this.rdoMaigre.TabIndex = 8;
            this.rdoMaigre.TabStop = true;
            this.rdoMaigre.Text = "Maigre";
            this.rdoMaigre.UseVisualStyleBackColor = true;
            // 
            // rdoBufflone
            // 
            this.rdoBufflone.AutoSize = true;
            this.rdoBufflone.Location = new System.Drawing.Point(6, 65);
            this.rdoBufflone.Name = "rdoBufflone";
            this.rdoBufflone.Size = new System.Drawing.Size(64, 17);
            this.rdoBufflone.TabIndex = 11;
            this.rdoBufflone.TabStop = true;
            this.rdoBufflone.Text = "Bufflone";
            this.rdoBufflone.UseVisualStyleBackColor = true;
            // 
            // rdoNormale2
            // 
            this.rdoNormale2.AutoSize = true;
            this.rdoNormale2.Location = new System.Drawing.Point(6, 42);
            this.rdoNormale2.Name = "rdoNormale2";
            this.rdoNormale2.Size = new System.Drawing.Size(64, 17);
            this.rdoNormale2.TabIndex = 9;
            this.rdoNormale2.TabStop = true;
            this.rdoNormale2.Text = "Normale";
            this.rdoNormale2.UseVisualStyleBackColor = true;
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.gboxMozzarella);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.gboxPizza);
            this.Controls.Add(this.lblCommande);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.cmdBox);
            this.Controls.Add(this.chkCrevettes);
            this.Controls.Add(this.chkJambon);
            this.Controls.Add(this.chkCâpres);
            this.Controls.Add(this.chkAnchois);
            this.Controls.Add(this.cmdCommander);
            this.Name = "Pizza";
            this.Text = "Pizza";
            this.gboxPizza.ResumeLayout(false);
            this.gboxPizza.PerformLayout();
            this.gboxMozzarella.ResumeLayout(false);
            this.gboxMozzarella.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCommander;
        private System.Windows.Forms.CheckBox chkAnchois;
        private System.Windows.Forms.CheckBox chkCâpres;
        private System.Windows.Forms.CheckBox chkJambon;
        private System.Windows.Forms.CheckBox chkCrevettes;
        private System.Windows.Forms.TextBox cmdBox;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblCommande;
        private System.Windows.Forms.RadioButton rdoExtraFine;
        private System.Windows.Forms.RadioButton rdoFine;
        private System.Windows.Forms.RadioButton rdoNormale;
        private System.Windows.Forms.RadioButton rdoEpaisse;
        private System.Windows.Forms.GroupBox gboxPizza;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.GroupBox gboxMozzarella;
        private System.Windows.Forms.RadioButton rdoMaigre;
        private System.Windows.Forms.RadioButton rdoBufflone;
        private System.Windows.Forms.RadioButton rdoNormale2;
    }
}

