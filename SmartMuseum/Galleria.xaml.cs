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
    /// Interaction logic for Galleria.xaml
    /// </summary>
    public partial class Galleria : Window
    {
        public Galleria()
        {
            InitializeComponent();
        }

        private void btnGioconda_Click(object sender, RoutedEventArgs e)
        {
            new Gioconda().ShowDialog();
        }

        private void btnPrimavera_Click(object sender, RoutedEventArgs e)
        {
            new Primavera().ShowDialog();
        }

        private void btnIlBacio_Click(object sender, RoutedEventArgs e)
        {
            new IlBacio().ShowDialog();
        }

        private void btnAlberoDellaVita_Click(object sender, RoutedEventArgs e)
        {
            new AlberoDellaVita().ShowDialog();
        }

        private void btnBaccoAdolescente_Click(object sender, RoutedEventArgs e)
        {
            new BaccoAdolescente().ShowDialog();
        }
    }
}
