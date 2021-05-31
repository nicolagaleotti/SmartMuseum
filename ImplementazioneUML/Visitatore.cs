using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementazioneUML
{
    public class Visitatore : Persona
    {
        public string Email { get; set; }
        List<Account> Accounts { get; set; } = new List<Account>();

        public Visitatore(string nome, string cognome, string email) : base(nome, cognome)
        {
            Email = email;
        }
    }
}
