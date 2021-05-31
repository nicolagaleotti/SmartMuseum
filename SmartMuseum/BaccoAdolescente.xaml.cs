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
    /// Interaction logic for BaccoAdolescente.xaml
    /// </summary>
    public partial class BaccoAdolescente : Window
    {
        public BaccoAdolescente()
        {
            InitializeComponent();
            lblBaccoAdolescente.Text =
            "Il Bacco è un dipinto realizzato da Caravaggio (nome d'arte di Michelangelo Merisi) tra il 1596 e il 1598 ed è conservata nella Galleria degli Uffizi a Firenze.\n\n"
            +
            "Fu commissionato dal cardinale Francesco Maria Bourbon del Monte per regalarlo a Ferdinando I de' Medici in occasione della celebrazione delle nozze del figlio Cosimo II, in modo da rinsaldare l'amicizia con la famiglia.\n\n"
            +
            "L'opera inizialmente venne destinata alla villa d'Artimino e solo in seguito venne collocata presso le collezioni granducali degli Uffizi con una cornice nera filettata d'oro, come riporta l'inventario mediceo del 1609.\n\n"
            +
            "L'opera rappresenta Bacco, dio del vino e dell'ebbrezza.\n"
            +
            "Secondo l'iconografia tradizionale è nudo, con una corona di foglie di vite o di edera, con in mano il tirso e un grappolo d'uva o una coppa di vino. Si presenta seduto su una specie di triclinio, coperto da un lenzuolo in forma di tunica che scopre parte del torso. Il dio offre la coppa di vino appena versato con la mano sinistra, per cui si pensa che il pittore abbia usato uno specchio in cui si riflette la propria immagine.";
        }
    }
}
