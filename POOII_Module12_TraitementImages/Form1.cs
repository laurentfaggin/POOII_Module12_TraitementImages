namespace POOII_Module12_TraitementImages
{
    public partial class fTraitementImages : Form
    {
        public fTraitementImages()
        {
            InitializeComponent();
        }

        private void fTraitementImages_Load(object sender, EventArgs e)
        {
            var traitements = UtilitaireTraitements.RechercherTraitementsImage();
            foreach(var traitement in traitements)
            {
                cbTraitementAAjouter.Items.Add(traitement);
            }
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cheminFichier = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();        
            ofd.Filter = "Fichier JPEG (*.jpeg)|*.jpeg|JPG (*.jpg)|*.jpg";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            { 
                cheminFichier = ofd.FileName;
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                ImageManipulable image = new ImageManipulable(cheminFichier);
                pbImage.Image = image.Image;
            }            
        }

        private void bAjouterTraitement_Click(object sender, EventArgs e)
        {
            lbListeTraitementAAppliquer.Items.Add(cbTraitementAAjouter.SelectedItem);
        }

        private void bSupprimerTraitement_Click(object sender, EventArgs e)
        {
            lbListeTraitementAAppliquer.Items.Remove(cbTraitementAAjouter.SelectedItem);
        }

        private void bSuiteTraitementsDeplacerBas_Click(object sender, EventArgs e)
        {
            if (lbListeTraitementAAppliquer.SelectedIndex < lbListeTraitementAAppliquer.Items.Count-1)
            {
                lbListeTraitementAAppliquer.SelectedIndex++;
            }
            else
            {
                lbListeTraitementAAppliquer.SelectedIndex = 0;
            }
        }

        private void bSuiteTraitementsDeplacerHaut_Click(object sender, EventArgs e)
        {
            if (lbListeTraitementAAppliquer.SelectedIndex > 0)
            {
                lbListeTraitementAAppliquer.SelectedIndex--;
            }
            else
            {
                lbListeTraitementAAppliquer.SelectedIndex = lbListeTraitementAAppliquer.Items.Count-1;
            }
        }
    }
}