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
    /// Interaction logic for IlBacio.xaml
    /// </summary>
    public partial class IlBacio : Window
    {
        public IlBacio()
        {
            InitializeComponent();
            lblIlBacio.Text =
            "Il bacio è una pittura a olio su tela (di dimensioni 180 x 180 cm) realizzato tra il 1907 e il 1908 da Gustav Klimt. Ad oggi è conservato nell'Osterreichische Galerie Belvedere di Vienna.\n\n"
            +
            "L'opera mostra il bacio tra un uomo e una donna: lo sfondo non è ben definito, lei è abbandonata pienamente nell'amplesso e ha gli occhi chiusi, mentre lui le stringe delicatamente la testa in segno di protezione e affetto.\n\n"
            +
            "Presenta un intenso uso del colore oro, che elimina l'effetto di profondità, proprio come nelle tecniche usate per i mosaici bizantini, apprezzati da Klimt nel 1903 a Ravenna.\n\n"
            +
            "Klimt con quest'opera cerca di glorificare il trionfo dellla potenza vivificatrice dell'amore, in grado di trascendere le antitesi tra sesso maschile e femminile.\n\n"
            +
            "La fusione tra uomo e donna avviene nonostante i due sessi vengano mostrati totalmente diversi: l'uomo, con pelle più scura e con vesti formate da elementi geografici verticali e spigolosi di colore nero, grigio e bianco; la donna, con pelle lucente e con vesti riportanti forme circolari e spiraliformi variopinte.";
        }
    }
}
