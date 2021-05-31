using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementazioneUML
{
    public class AddettoSicurezza : Persona
    {
        public int NIdentificativo { get; set; }

        public AddettoSicurezza(string nome, string cognome, int nIdentificativo) : base(nome, cognome)
        {
            NIdentificativo = nIdentificativo;
        }
    }
}
