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
    /// Interaction logic for AlberoDellaVita.xaml
    /// </summary>
    public partial class AlberoDellaVita : Window
    {
        public AlberoDellaVita()
        {
            InitializeComponent();
            lblAlberoDellaVita.Text =
            "L'opera fa parte di un mosaico più grande chiamato Fregio di Palazzo Stoclet realizzato da Gustav Klimt tra il 1905 e il 1909, per l'omonimo palazzo che si trova a Bruxelles. Al momento è esposto nel Museum für angewandte Kunst di Vienna.\n\n"
            +
            "Quest'opera è il motivo centrale del fregio: mostra i suoi elegantissimi e spiraleggianti rami che ricoprono l'intera superficie del mosaico.\n"
            +
            "Tra i rami dell'albero spiccano numerosi elementi ornamentali, tra i quali svariati fiori caratteristici per la loro forma a occhi egizi.\n\n"
            +
            "L'Albero della vita rappresenta la salvezza giunta ai pagani dopo l'apocalisse ed è il simbolo dell'età dell'oro, molto ricorrente nelle opere di Klimt.\n\n"
            +
            "L'albero è quindi l'asse portante dell'intera rappresentazione al cui interno sono incastonate le altre figure appartenenti al fregio, l' Attesa e l'Abbraccio.";
        }
    }
}
