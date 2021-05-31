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
    /// Interaction logic for Primavera.xaml
    /// </summary>
    public partial class Primavera : Window
    {
        public Primavera()
        {
            InitializeComponent();
            lblPrimavera.Text =
            "La Primavera è un dipinto a tempera su tavola realizzato da Sandro Botticelli tra il 1477 e il 1490 (probabilmente nel 1482 per le nozze del committente). L'opera ha dimensioni 207x319 cm ed è conservata nella Galeria degli Uffizi a Firenze.\n\n"
            +
            "E' una delle opere più famose del Risorgimento italiano, insieme alla Nascita di Venere (sempre di Botticelli), con la quale condivide la provenienza storica, il formato e alcuni riferimenti filosofici.\n"
            +
            "Il fascino che esercita quest'opera nel pubblico sembra sia legato all'aura di mistero che la circonda, dato che il significato non è stato completamente svelato.\n\n"
            +
            "Il dipinto venne eseguito per Lorenzo di Piefrancesco de' Medici e venne esposto nel Palazzo di via Larga, come conferma Giorgio Vasari nel 1550. Dopo essere stato trasferito nel 1853 alla Galleria dell'Accademia per favorire lo studio di giovani artisti, nel 1919 venne trasferito agli Uffizi con il riordino delle collezioni fiorentine.\n\n"
            +
            "L'opera mostra la ricerca della bellezza ideale e dell'armonia, tipiche dell'arte di Botticelli, che genera pose sinuose e sciolte, con profili idealmente perfetti. Ai personaggi è rivolta tutta l'attenzione, che in secondo luogo passa alle specie vegetali, mentre lo sfondo è meno curato e più cupo.";
        }
    }
}
