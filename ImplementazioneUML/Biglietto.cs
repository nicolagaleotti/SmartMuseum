using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementazioneUML
{
    public class Biglietto
    {
        public DateTime Data { get; set; }
        public bool Elettronico { get; set; }
        public Biglietteria Biglietteria { get; set; }
        public Account Account { get; set; }

        public Biglietto(DateTime data, bool elettronico, Biglietteria biglietteria, Account account)
        {
            Data = data;
            Elettronico = elettronico;
            Biglietteria = biglietteria;
            Account = account;
        }
    }
}
