using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Module12_TraitementImages
{
    [Description("diminution bruit")]
    public class TraitementImageDiminuerBruit: TraitementImageMasque
    {
        private static byte TraiterDonnees(byte[] p_donnees)
        {
            Array.Sort(p_donnees);

            return p_donnees[p_donnees.Length / 2];
        }
        public override string ToString()
        {
            return "diminution du bruit";
        }
    }
}
