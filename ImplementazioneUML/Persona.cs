using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementazioneUML
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }
    }
}
