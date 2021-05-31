using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementazioneUML
{
    public class NegozioSouvenir
    {
        public List<Souvenir> SouvenirVenduti { get; set; } = new List<Souvenir>();
        public DateTime Chiusura { get; set; }
        public List<Souvenir> Souvenir { get; set; } = new List<Souvenir>();

        public NegozioSouvenir(DateTime chiusura)
        {
            Chiusura = chiusura;
        }
    }
}
