using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Module12_TraitementImages
{
    public abstract class TraitementImageMasque : ITraitementImage
    {
        private int m_largeur;
        public ITraitementImage Suivant { get; set; }
        public Func<byte[], byte> Transformation { get; set; }
        public int Largeur
        {
            get { return m_largeur; }
            set 
            { 
                if (this.m_largeur % 2 == 0) { 
                    throw new ArgumentException ("la largeur doit etre impaire", nameof(this.Largeur));
                } 
                if ((this.m_largeur & 1) == 1)
                {
                    throw new ArgumentException ("la largeur ne peut etre inferieure a 1", nameof(this.Largeur));
                }
                m_largeur = value;
            }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void TraiterImage(ImageManipulable p_image)
        {
            byte[] raw = p_image.Raw;
            byte[] res = new byte[raw.Length];
            int width = p_image.Width;
            int height = p_image.Height;
            int stride = p_image.Stride;
            byte[] donneesCourantes = new byte[this.Largeur * this.Largeur];
            for (int colonne = 0; colonne < width; colonne++)
            {
                for (int ligne = 0; ligne < height; ligne++)
                {
                    for (int composante = 0; composante < 3; composante++)
                    {
                        int posDonneesCourantes = 0;
                        for (int masqueX = -this.Largeur / 2; masqueX <= this.Largeur / 2; masqueX++)
                        {
                            int posX = Math.Min(Math.Max(0, colonne + masqueX), width - 1);
                            for (int masqueY = -this.Largeur / 2; masqueY <= this.Largeur / 2; masqueY++)
                            {
                                int posY = Math.Min(Math.Max(0, ligne + masqueY), height - 1);
                                donneesCourantes[posDonneesCourantes] = raw[posY * stride + posX * 3 + composante];
                                ++posDonneesCourantes;
                            }
                        }
                        res[ligne * stride + colonne * 3 + composante] = this.Transformation(donneesCourantes);
                    }
                }
            }

            Array.Copy(res, raw, raw.Length);
            this.Suivant?.TraiterImage(p_image);
        }
    }
}
