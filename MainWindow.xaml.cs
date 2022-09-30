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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AzulRadioButton.IsChecked = true;
        }


        private void CajaTextoInputTextBoxChanged(object sender, TextChangedEventArgs e)
        {
            CajaTextoOutputTextBox.Text = CajaTextoInputTextBox.Text;

        }

        private void NegritaCheckBoxChecked(object sender, RoutedEventArgs e)
        {
            CajaTextoOutputTextBox.FontWeight = FontWeights.Bold;
        }

        private void NegritaCheckBoxUnchecked(object sender, RoutedEventArgs e)
        {
            CajaTextoOutputTextBox.FontWeight = FontWeights.Normal;
        }

        private void CursivaCheckBoxChecked(object sender, RoutedEventArgs e)
        {
            CajaTextoOutputTextBox.FontStyle = FontStyles.Italic;

        }

        private void CursivaCheckBoxUnchecked(object sender, RoutedEventArgs e)
        {
            CajaTextoOutputTextBox.FontStyle = FontStyles.Normal;

        }

        private void AzulRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            CajaTextoOutputTextBox.Foreground = new SolidColorBrush(Colors.Blue);
        }

        private void RojoRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            CajaTextoOutputTextBox.Foreground = new SolidColorBrush(Colors.Red);

        }

        private void VerdeRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            CajaTextoOutputTextBox.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void AzulRadioButtonUnchecked(object sender, RoutedEventArgs e)
        {
            CajaTextoOutputTextBox.Foreground = new SolidColorBrush(Colors.White);

        }

        private void RojoRadioButtonUnchecked(object sender, RoutedEventArgs e)
        {
            CajaTextoOutputTextBox.Foreground = new SolidColorBrush(Colors.White);

        }

        private void VerdeRadioButtonUnchecked(object sender, RoutedEventArgs e)
        {
            CajaTextoOutputTextBox.Foreground = new SolidColorBrush(Colors.White);
        }
    }
}
