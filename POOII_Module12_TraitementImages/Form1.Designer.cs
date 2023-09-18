namespace POOII_Module12_TraitementImages
{
    partial class fTraitementImages
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.scPrincipal = new System.Windows.Forms.SplitContainer();
            this.scSuiteTraiements = new System.Windows.Forms.SplitContainer();
            this.cbTraitementAAjouter = new System.Windows.Forms.ComboBox();
            this.bSuiteTraitementsDeplacerHaut = new System.Windows.Forms.Button();
            this.bSuiteTraitementsDeplacerBas = new System.Windows.Forms.Button();
            this.bSupprimerTraitement = new System.Windows.Forms.Button();
            this.bAjouterTraitement = new System.Windows.Forms.Button();
            this.lbListeTraitementAAppliquer = new System.Windows.Forms.ListBox();
            this.bAppliquer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).BeginInit();
            this.scPrincipal.Panel1.SuspendLayout();
            this.scPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSuiteTraiements)).BeginInit();
            this.scSuiteTraiements.Panel1.SuspendLayout();
            this.scSuiteTraiements.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPrincipal});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msPrincipal
            // 
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(66, 24);
            this.msPrincipal.Text = "Fichier";
            // 
            // scPrincipal
            // 
            this.scPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scPrincipal.Location = new System.Drawing.Point(0, 28);
            this.scPrincipal.Name = "scPrincipal";
            // 
            // scPrincipal.Panel1
            // 
            this.scPrincipal.Panel1.Controls.Add(this.scSuiteTraiements);
            this.scPrincipal.Size = new System.Drawing.Size(880, 539);
            this.scPrincipal.SplitterDistance = 293;
            this.scPrincipal.TabIndex = 1;
            // 
            // scSuiteTraiements
            // 
            this.scSuiteTraiements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSuiteTraiements.Location = new System.Drawing.Point(0, 0);
            this.scSuiteTraiements.Name = "scSuiteTraiements";
            this.scSuiteTraiements.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scSuiteTraiements.Panel1
            // 
            this.scSuiteTraiements.Panel1.Controls.Add(this.bAppliquer);
            this.scSuiteTraiements.Panel1.Controls.Add(this.lbListeTraitementAAppliquer);
            this.scSuiteTraiements.Panel1.Controls.Add(this.bAjouterTraitement);
            this.scSuiteTraiements.Panel1.Controls.Add(this.bSupprimerTraitement);
            this.scSuiteTraiements.Panel1.Controls.Add(this.bSuiteTraitementsDeplacerBas);
            this.scSuiteTraiements.Panel1.Controls.Add(this.bSuiteTraitementsDeplacerHaut);
            this.scSuiteTraiements.Panel1.Controls.Add(this.cbTraitementAAjouter);
            this.scSuiteTraiements.Size = new System.Drawing.Size(293, 539);
            this.scSuiteTraiements.SplitterDistance = 243;
            this.scSuiteTraiements.TabIndex = 0;
            // 
            // cbTraitementAAjouter
            // 
            this.cbTraitementAAjouter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbTraitementAAjouter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTraitementAAjouter.FormattingEnabled = true;
            this.cbTraitementAAjouter.Location = new System.Drawing.Point(12, 13);
            this.cbTraitementAAjouter.Name = "cbTraitementAAjouter";
            this.cbTraitementAAjouter.Size = new System.Drawing.Size(264, 28);
            this.cbTraitementAAjouter.TabIndex = 0;
            // 
            // bSuiteTraitementsDeplacerHaut
            // 
            this.bSuiteTraitementsDeplacerHaut.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bSuiteTraitementsDeplacerHaut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSuiteTraitementsDeplacerHaut.Location = new System.Drawing.Point(12, 61);
            this.bSuiteTraitementsDeplacerHaut.Margin = new System.Windows.Forms.Padding(0);
            this.bSuiteTraitementsDeplacerHaut.Name = "bSuiteTraitementsDeplacerHaut";
            this.bSuiteTraitementsDeplacerHaut.Size = new System.Drawing.Size(40, 40);
            this.bSuiteTraitementsDeplacerHaut.TabIndex = 1;
            this.bSuiteTraitementsDeplacerHaut.Text = "^";
            this.bSuiteTraitementsDeplacerHaut.UseVisualStyleBackColor = false;
            // 
            // bSuiteTraitementsDeplacerBas
            // 
            this.bSuiteTraitementsDeplacerBas.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bSuiteTraitementsDeplacerBas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSuiteTraitementsDeplacerBas.Location = new System.Drawing.Point(62, 61);
            this.bSuiteTraitementsDeplacerBas.Margin = new System.Windows.Forms.Padding(0);
            this.bSuiteTraitementsDeplacerBas.Name = "bSuiteTraitementsDeplacerBas";
            this.bSuiteTraitementsDeplacerBas.Size = new System.Drawing.Size(40, 40);
            this.bSuiteTraitementsDeplacerBas.TabIndex = 2;
            this.bSuiteTraitementsDeplacerBas.Text = "v";
            this.bSuiteTraitementsDeplacerBas.UseVisualStyleBackColor = false;
            // 
            // bSupprimerTraitement
            // 
            this.bSupprimerTraitement.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bSupprimerTraitement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSupprimerTraitement.Location = new System.Drawing.Point(232, 61);
            this.bSupprimerTraitement.Name = "bSupprimerTraitement";
            this.bSupprimerTraitement.Size = new System.Drawing.Size(40, 40);
            this.bSupprimerTraitement.TabIndex = 3;
            this.bSupprimerTraitement.Text = "-";
            this.bSupprimerTraitement.UseVisualStyleBackColor = false;
            // 
            // bAjouterTraitement
            // 
            this.bAjouterTraitement.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bAjouterTraitement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAjouterTraitement.Location = new System.Drawing.Point(182, 61);
            this.bAjouterTraitement.Margin = new System.Windows.Forms.Padding(0);
            this.bAjouterTraitement.Name = "bAjouterTraitement";
            this.bAjouterTraitement.Size = new System.Drawing.Size(40, 40);
            this.bAjouterTraitement.TabIndex = 4;
            this.bAjouterTraitement.Text = "+";
            this.bAjouterTraitement.UseVisualStyleBackColor = false;
            // 
            // lbListeTraitementAAppliquer
            // 
            this.lbListeTraitementAAppliquer.FormattingEnabled = true;
            this.lbListeTraitementAAppliquer.ItemHeight = 20;
            this.lbListeTraitementAAppliquer.Location = new System.Drawing.Point(12, 119);
            this.lbListeTraitementAAppliquer.Name = "lbListeTraitementAAppliquer";
            this.lbListeTraitementAAppliquer.Size = new System.Drawing.Size(264, 64);
            this.lbListeTraitementAAppliquer.TabIndex = 5;
            // 
            // bAppliquer
            // 
            this.bAppliquer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bAppliquer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAppliquer.Location = new System.Drawing.Point(12, 200);
            this.bAppliquer.Margin = new System.Windows.Forms.Padding(0);
            this.bAppliquer.Name = "bAppliquer";
            this.bAppliquer.Size = new System.Drawing.Size(264, 40);
            this.bAppliquer.TabIndex = 6;
            this.bAppliquer.Text = "Appliquer";
            this.bAppliquer.UseVisualStyleBackColor = false;
            // 
            // fTraitementImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 567);
            this.Controls.Add(this.scPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTraitementImages";
            this.Text = "Traitement d\'images";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.scPrincipal.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).EndInit();
            this.scPrincipal.ResumeLayout(false);
            this.scSuiteTraiements.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSuiteTraiements)).EndInit();
            this.scSuiteTraiements.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem msPrincipal;
        private SplitContainer scPrincipal;
        private SplitContainer scSuiteTraiements;
        private Button bSupprimerTraitement;
        private Button bSuiteTraitementsDeplacerBas;
        private Button bSuiteTraitementsDeplacerHaut;
        private ComboBox cbTraitementAAjouter;
        private Button bAjouterTraitement;
        private Button bAppliquer;
        private ListBox lbListeTraitementAAppliquer;
    }
}