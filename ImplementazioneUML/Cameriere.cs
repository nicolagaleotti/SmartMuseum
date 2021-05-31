using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementazioneUML
{
    public class Cameriere : Persona
    {
        public int NTelefono { get; set; }

        public Cameriere(string nome, string cognome, int nTelefono) : base(nome, cognome)
        {
            NTelefono = nTelefono;
        }
    }
}
