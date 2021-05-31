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
    /// Interaction logic for Biglietti.xaml
    /// </summary>
    public partial class Biglietti : Window
    {
        public Biglietti()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Biglietto(20, 10).Show();
        }

        private void BtnGalleria_Click(object sender, RoutedEventArgs e)
        {
            new Biglietto(15, 8).Show();
        }

        private void BtnGiardino_Click(object sender, RoutedEventArgs e)
        {
            new Biglietto(8, 4).Show();
        }

        private void btnpass_Click(object sender, RoutedEventArgs e)
        {
            new Biglietto(60, 35).Show();
        }
    }
}
