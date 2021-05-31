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
    /// Interaction logic for Biglietto.xaml
    /// </summary>
    public partial class Biglietto : Window
    {
        public Biglietto(int intero, int ridotto)
        {
            InitializeComponent();
            this.intero = intero;
            this.ridotto = ridotto;
        }
        int intero;
        int ridotto;

        private void BtnResoconto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string email = "";
                if (TxtEmail.Text != "")
                    email = TxtEmail.Text;
                else
                {
                    throw new Exception("Inserisci una email!");
                }

                int prezzo = 0;
                if (CmbBiglietto.SelectedIndex == -1)
                {
                    throw new Exception("Selezionare il tipo di biglietto!");
                }
                if (CmbBiglietto.SelectedIndex == 0)
                {
                    prezzo = intero;
                }
                else if (CmbBiglietto.SelectedIndex == 1)
                {
                    prezzo = ridotto;
                }

                Random r = new Random();

                string username = "";
                for (int i = 0; i < 10; i++)
                {
                    username += (char)r.Next('a', 'z');
                }
                TxtUserName.Text = username;

                string password = "";
                for (int i = 0; i < 10; i++)
                {
                    password += r.Next(0, 9).ToString();
                }
                TxtPassword.Text = password;

                TxtResoconto.Text = $"Il biglietto è stato aquistato all'email: {email}.\nIl prezzo del biglietto è: {prezzo}€";

                TxtEmail.Clear();
                CmbBiglietto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_Loaded(object sender, RoutedEventArgs e)
        {
            CmbBiglietto.Items.Add("Intero");
            CmbBiglietto.Items.Add("Ridotto");
        }
    }
}
