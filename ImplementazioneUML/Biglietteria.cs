using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementazioneUML
{
    public class Biglietteria
    {
        public Persona Addetto { get; set; }
        public List<Biglietto> BigliettiGiornalieri { get; set; } = new List<Biglietto>();
        public List<Biglietto> Biglietti { get; set; } = new List<Biglietto>();

        public Biglietteria() { }
    }
}
