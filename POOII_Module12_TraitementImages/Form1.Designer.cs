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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTraitementImages));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scPrincipal = new System.Windows.Forms.SplitContainer();
            this.scSuiteTraiements = new System.Windows.Forms.SplitContainer();
            this.pControlSuiteTraitements = new System.Windows.Forms.Panel();
            this.bAjouterTraitement = new System.Windows.Forms.Button();
            this.bSupprimerTraitement = new System.Windows.Forms.Button();
            this.bSuiteTraitementsDeplacerHaut = new System.Windows.Forms.Button();
            this.cbTraitementAAjouter = new System.Windows.Forms.ComboBox();
            this.bSuiteTraitementsDeplacerBas = new System.Windows.Forms.Button();
            this.bAppliquer = new System.Windows.Forms.Button();
            this.lbListeTraitementAAppliquer = new System.Windows.Forms.ListBox();
            this.pgProprieteTraitementSelectionne = new System.Windows.Forms.PropertyGrid();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.ssStatut = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).BeginInit();
            this.scPrincipal.Panel1.SuspendLayout();
            this.scPrincipal.Panel2.SuspendLayout();
            this.scPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSuiteTraiements)).BeginInit();
            this.scSuiteTraiements.Panel1.SuspendLayout();
            this.scSuiteTraiements.Panel2.SuspendLayout();
            this.scSuiteTraiements.SuspendLayout();
            this.pControlSuiteTraitements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.ssStatut.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPrincipal});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msPrincipal
            // 
            this.msPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem});
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(66, 24);
            this.msPrincipal.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
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
            // 
            // scPrincipal.Panel2
            // 
            this.scPrincipal.Panel2.Controls.Add(this.toolStrip1);
            this.scPrincipal.Panel2.Controls.Add(this.pbImage);
            this.scPrincipal.Panel2.Controls.Add(this.ssStatut);
            this.scPrincipal.Size = new System.Drawing.Size(977, 675);
            this.scPrincipal.SplitterDistance = 324;
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
            this.scSuiteTraiements.Panel1.Controls.Add(this.pControlSuiteTraitements);
            this.scSuiteTraiements.Panel1.Controls.Add(this.bAppliquer);
            this.scSuiteTraiements.Panel1.Controls.Add(this.lbListeTraitementAAppliquer);
            // 
            // scSuiteTraiements.Panel2
            // 
            this.scSuiteTraiements.Panel2.Controls.Add(this.pgProprieteTraitementSelectionne);
            this.scSuiteTraiements.Size = new System.Drawing.Size(324, 675);
            this.scSuiteTraiements.SplitterDistance = 303;
            this.scSuiteTraiements.TabIndex = 0;
            // 
            // pControlSuiteTraitements
            // 
            this.pControlSuiteTraitements.Controls.Add(this.bAjouterTraitement);
            this.pControlSuiteTraitements.Controls.Add(this.bSupprimerTraitement);
            this.pControlSuiteTraitements.Controls.Add(this.bSuiteTraitementsDeplacerHaut);
            this.pControlSuiteTraitements.Controls.Add(this.cbTraitementAAjouter);
            this.pControlSuiteTraitements.Controls.Add(this.bSuiteTraitementsDeplacerBas);
            this.pControlSuiteTraitements.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControlSuiteTraitements.Location = new System.Drawing.Point(0, 0);
            this.pControlSuiteTraitements.Name = "pControlSuiteTraitements";
            this.pControlSuiteTraitements.Size = new System.Drawing.Size(324, 113);
            this.pControlSuiteTraitements.TabIndex = 7;
            // 
            // bAjouterTraitement
            // 
            this.bAjouterTraitement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAjouterTraitement.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bAjouterTraitement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAjouterTraitement.Location = new System.Drawing.Point(213, 53);
            this.bAjouterTraitement.Margin = new System.Windows.Forms.Padding(0);
            this.bAjouterTraitement.Name = "bAjouterTraitement";
            this.bAjouterTraitement.Size = new System.Drawing.Size(40, 40);
            this.bAjouterTraitement.TabIndex = 4;
            this.bAjouterTraitement.Text = "+";
            this.bAjouterTraitement.UseVisualStyleBackColor = false;
            // 
            // bSupprimerTraitement
            // 
            this.bSupprimerTraitement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSupprimerTraitement.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bSupprimerTraitement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSupprimerTraitement.Location = new System.Drawing.Point(270, 53);
            this.bSupprimerTraitement.Name = "bSupprimerTraitement";
            this.bSupprimerTraitement.Size = new System.Drawing.Size(40, 40);
            this.bSupprimerTraitement.TabIndex = 3;
            this.bSupprimerTraitement.Text = "-";
            this.bSupprimerTraitement.UseVisualStyleBackColor = false;
            // 
            // bSuiteTraitementsDeplacerHaut
            // 
            this.bSuiteTraitementsDeplacerHaut.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bSuiteTraitementsDeplacerHaut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSuiteTraitementsDeplacerHaut.Location = new System.Drawing.Point(12, 53);
            this.bSuiteTraitementsDeplacerHaut.Margin = new System.Windows.Forms.Padding(0);
            this.bSuiteTraitementsDeplacerHaut.Name = "bSuiteTraitementsDeplacerHaut";
            this.bSuiteTraitementsDeplacerHaut.Size = new System.Drawing.Size(40, 40);
            this.bSuiteTraitementsDeplacerHaut.TabIndex = 1;
            this.bSuiteTraitementsDeplacerHaut.Text = "^";
            this.bSuiteTraitementsDeplacerHaut.UseVisualStyleBackColor = false;
            // 
            // cbTraitementAAjouter
            // 
            this.cbTraitementAAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTraitementAAjouter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbTraitementAAjouter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTraitementAAjouter.FormattingEnabled = true;
            this.cbTraitementAAjouter.Location = new System.Drawing.Point(12, 12);
            this.cbTraitementAAjouter.Name = "cbTraitementAAjouter";
            this.cbTraitementAAjouter.Size = new System.Drawing.Size(299, 28);
            this.cbTraitementAAjouter.TabIndex = 0;
            // 
            // bSuiteTraitementsDeplacerBas
            // 
            this.bSuiteTraitementsDeplacerBas.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bSuiteTraitementsDeplacerBas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSuiteTraitementsDeplacerBas.Location = new System.Drawing.Point(65, 53);
            this.bSuiteTraitementsDeplacerBas.Margin = new System.Windows.Forms.Padding(0);
            this.bSuiteTraitementsDeplacerBas.Name = "bSuiteTraitementsDeplacerBas";
            this.bSuiteTraitementsDeplacerBas.Size = new System.Drawing.Size(40, 40);
            this.bSuiteTraitementsDeplacerBas.TabIndex = 2;
            this.bSuiteTraitementsDeplacerBas.Text = "v";
            this.bSuiteTraitementsDeplacerBas.UseVisualStyleBackColor = false;
            // 
            // bAppliquer
            // 
            this.bAppliquer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bAppliquer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bAppliquer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAppliquer.Location = new System.Drawing.Point(0, 251);
            this.bAppliquer.Margin = new System.Windows.Forms.Padding(0);
            this.bAppliquer.Name = "bAppliquer";
            this.bAppliquer.Size = new System.Drawing.Size(324, 52);
            this.bAppliquer.TabIndex = 6;
            this.bAppliquer.Text = "Appliquer";
            this.bAppliquer.UseVisualStyleBackColor = false;
            // 
            // lbListeTraitementAAppliquer
            // 
            this.lbListeTraitementAAppliquer.FormattingEnabled = true;
            this.lbListeTraitementAAppliquer.ItemHeight = 20;
            this.lbListeTraitementAAppliquer.Location = new System.Drawing.Point(0, 113);
            this.lbListeTraitementAAppliquer.Name = "lbListeTraitementAAppliquer";
            this.lbListeTraitementAAppliquer.Size = new System.Drawing.Size(304, 64);
            this.lbListeTraitementAAppliquer.TabIndex = 5;
            // 
            // pgProprieteTraitementSelectionne
            // 
            this.pgProprieteTraitementSelectionne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgProprieteTraitementSelectionne.Location = new System.Drawing.Point(0, 0);
            this.pgProprieteTraitementSelectionne.Name = "pgProprieteTraitementSelectionne";
            this.pgProprieteTraitementSelectionne.Size = new System.Drawing.Size(324, 368);
            this.pgProprieteTraitementSelectionne.TabIndex = 0;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(196, 94);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // ssStatut
            // 
            this.ssStatut.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssStatut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.ssStatut.Location = new System.Drawing.Point(0, 651);
            this.ssStatut.Name = "ssStatut";
            this.ssStatut.Size = new System.Drawing.Size(649, 24);
            this.ssStatut.TabIndex = 0;
            this.ssStatut.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // fTraitementImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 703);
            this.Controls.Add(this.scPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTraitementImages";
            this.Text = "Traitement d\'images";
            this.Load += new System.EventHandler(this.fTraitementImages_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.scPrincipal.Panel1.ResumeLayout(false);
            this.scPrincipal.Panel2.ResumeLayout(false);
            this.scPrincipal.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).EndInit();
            this.scPrincipal.ResumeLayout(false);
            this.scSuiteTraiements.Panel1.ResumeLayout(false);
            this.scSuiteTraiements.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSuiteTraiements)).EndInit();
            this.scSuiteTraiements.ResumeLayout(false);
            this.pControlSuiteTraitements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ssStatut.ResumeLayout(false);
            this.ssStatut.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private Panel pControlSuiteTraitements;
        private PropertyGrid pgProprieteTraitementSelectionne;
        private PictureBox pbImage;
        private StatusStrip ssStatut;
        private ToolStripMenuItem ouvrirToolStripMenuItem;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
    }
}