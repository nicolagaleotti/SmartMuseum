using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementazioneUML
{
    public class Souvenir
    {
        public NegozioSouvenir NegozioSouvenir { get; set; }

        public Souvenir(NegozioSouvenir negozioSouvenir)
        {
            NegozioSouvenir = negozioSouvenir;
        }
    }
}
