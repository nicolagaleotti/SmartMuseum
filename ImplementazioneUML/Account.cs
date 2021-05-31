using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementazioneUML
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Biglietto> Biglietti { get; set; } = new List<Biglietto>();
        public Visitatore Visitatore { get; set; }

        public Account(string username, string password, Visitatore visitatore)
        {
            Username = username;
            Password = password;
            Visitatore = visitatore;
        }
    }
}
