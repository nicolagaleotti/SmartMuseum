using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementazioneUML
{
    public class Laboratorio
    {
        public Persona Responsabile { get; set; }
        public int NPostazioni { get; set; }
        public int MetriQuadrati { get; set; }
        public int NSoftware { get; set; }

        public Laboratorio(Persona responsabile, int nPostazioni, int metriQuadrati, int nSoftware)
        {
            Responsabile = responsabile;
            NPostazioni = nPostazioni;
            MetriQuadrati = metriQuadrati;
            NSoftware = nSoftware;
        }
    }
}
