using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ImplementazioneUML
{
    public class Opera
    {
        public string Nome { get; set; }
        public Persona Autore { get; set; }
        public string Descrizione { get; set; }

        //public Image qr { get; set; }

        public Opera(string nome, Persona autore, string descrizione)
        {
            Nome = nome;
            Autore = autore;
            Descrizione = descrizione;
        }
    }
}
