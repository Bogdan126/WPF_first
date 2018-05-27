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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public int dzialanie = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dzialanie = 1;
            Dzial.Text = "Dodawanie";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dzialanie = 2;
            Dzial.Text = "Odejmowanie";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            dzialanie = 3;
            Dzial.Text = "Mnożenie";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            dzialanie = 4;
            Dzial.Text = "Dzielenie";
        }

        private void Suma_Click(object sender, RoutedEventArgs e)
        {

            if (dzialanie == 1)
            {
                double result = Double.Parse(Pliczba.Text) + Double.Parse(Dliczba.Text);
                Wynik.Text = result.ToString();
            }
            else if(dzialanie ==2)
            {
                double result = Double.Parse(Pliczba.Text) - Double.Parse(Dliczba.Text);
                Wynik.Text = result.ToString();
            }
            else if (dzialanie == 3)
            {
                double result = Double.Parse(Pliczba.Text) * Double.Parse(Dliczba.Text);
                Wynik.Text = result.ToString();
            }
            else if (dzialanie == 4)
            {
                double result = Double.Parse(Pliczba.Text) / Double.Parse(Dliczba.Text);
                Wynik.Text = result.ToString();
            }
        }
    }
}
