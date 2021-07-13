using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GrafX_Quests
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Polimorfismo : Page
    {
        public Polimorfismo()
        {
            this.InitializeComponent();
            Proximo.IsEnabled = false;
        }

        private void Anterior_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(O_Teorema_de_Euler_II));
        }
        
        private void Proximo_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Desafio_1));
        }

        private void Sim_Button_Click(object sender, RoutedEventArgs e)
        {
            Sim_Button.Content = "Errado";

            if (Nao_Button.Content != "Certo")
            {                
                Sim_Button.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
                Sim_Button.Background = new SolidColorBrush(Windows.UI.Colors.Red);
            }
            Proximo.IsEnabled = true;
        }

        private void Nao_Button_Click(object sender, RoutedEventArgs e)
        {
            Nao_Button.Content = "Certo";

            if (Sim_Button.Content != "Errado")
            {
                Nao_Button.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
                Nao_Button.Background = new SolidColorBrush(Windows.UI.Colors.Green);
            }
            Proximo.IsEnabled = true;
        }
    }
}
