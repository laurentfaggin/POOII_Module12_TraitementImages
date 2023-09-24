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
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "files (*.jpeg)|*.jpeg|";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    cheminFichier = ofd.FileName;
                    ImageManipulable image = new ImageManipulable(cheminFichier);
                    pbImage.Image = image.Image;
                }
            }
        }
    }
}