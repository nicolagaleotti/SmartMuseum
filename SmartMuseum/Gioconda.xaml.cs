using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SmartMuseum
{
    /// <summary>
    /// Interaction logic for Gioconda.xaml
    /// </summary>
    public partial class Gioconda : Window
    {
        public Gioconda()
        {
            InitializeComponent();
            lblGioconda.Text =
            "Chiamata anche Monna Lisa, la Gioconda è un dipinto ad olio su tavola di legno di pioppo di Leonardo Da Vinci. Databile tra il 1503 e il 1504, è un dipinto di dimensioni 77x53 cm, conservato nel Museo del Louvre di Parigi.\n\n"
            +
            "La donna rappresentata sembra sia Lisa Gherardini, moglie di Francesco del Giocondo (per questo chiamata la 'Gioconda'). Viene confermata questa notizia da Giorgio Vasari (anche lui pittore e artista) quando scrisse che ''Prese Lionardo a fare per Francesco del Giocondo il ritratto di Monna Lisa ('mia signora') sua moglie...''.\n\n"
            +
            "Leonardo stesso portò il dipinto in Francia nel 1516. L'opera venne lasciata al Louvre, dopo averla nascosta per la guerra Franco-Prussiana del 1870-71.\n\n"
            +
            "Nel 1911 la Gioconda venne rubata da un impiegato del Louvre, Vincenzo Peruggia, convinto che il dipinto appartenesse all'Italia e che in Italia dovessere rimanere. Una volta recuperato venne esposto intutta Italia, prima a Firenze, poi a Roma e Milano. Alla fine del suo tour italiano, l'opera venne riportata al Louvre in Francia.\n\n"
            +
            "Al momento mostra una fessura sul retro e altri danni causati da atti vandalici, perciò viene conservata dietro una teca di vetro infrangibile, con temperatura e umidità controllate. Date queste condizioni, il prestito dell'opera è divenuto un evento improbabile, infatti nel 2011 ne venne negato il prestito agli Uffizi di Firenze.";
        }
    }
}
