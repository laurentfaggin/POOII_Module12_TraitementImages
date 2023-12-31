using System.DirectoryServices.ActiveDirectory;

namespace POOII_Module12_TraitementImages
{
    public partial class fTraitementImages : Form
    {
        private ImageManipulable m_image;
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
                m_image= image;
            }            
        }

        private void bAjouterTraitement_Click(object sender, EventArgs e)
        {
            lbListeTraitementAAppliquer.Items.Add(((CreateurTraitement)cbTraitementAAjouter.SelectedItem).Creer());
        }

        private void bSupprimerTraitement_Click(object sender, EventArgs e)
        {
            lbListeTraitementAAppliquer.Items.Remove(lbListeTraitementAAppliquer.SelectedItem);
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

        private void lbListeTraitementAAppliquer_SelectedIndexChanged(object sender, EventArgs e)
        {
            pgProprieteTraitementSelectionne.SelectedObject = lbListeTraitementAAppliquer.SelectedItem;
        }

        private void bAppliquer_Click(object sender, EventArgs e)
        {
            List <ITraitementImage> traitement = new List <ITraitementImage>();
            foreach (var t in lbListeTraitementAAppliquer.Items)
            {
                traitement.Add((ITraitementImage)((ITraitementImage)t).Clone());
            }
            for (int i = 0; i < traitement.Count-1; i++)
            {
                traitement[i].Suivant = traitement[i+1];
            }
            traitement[0].TraiterImage(m_image);
            pbImage.Image = m_image.Image;
        }
    }
}