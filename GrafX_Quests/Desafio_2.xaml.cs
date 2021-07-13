using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class Desafio_2 : Page
    {
        public Desafio_2()
        {
            this.InitializeComponent();
            Sim.IsEnabled = false;
            Nao.IsEnabled = false;
            Proximo.IsEnabled = false;
        }

        private async void Avancar_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Grau_de_0.Text == "2" &&
               Grau_de_1.Text == "3" &&
               Grau_de_2.Text == "4" &&
               Grau_de_3.Text == "3" &&
               Grau_de_4.Text == "5" &&
               Grau_de_5.Text == "3" &&
               Grau_de_6.Text == "2" &&
               Grau_de_8.Text == "4" &&
               Grau_de_9.Text == "3" &&
               Grau_de_10.Text == "3")
            {
                Sim.IsEnabled = true;
                Nao.IsEnabled = true;
                Avancar_Button.Content = "Correto";
                Avancar_Button.IsEnabled = false;
            }
            else
            {
                /*
                Avancar_Button.Content = "Errado";
                Avancar_Button.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
                Avancar_Button.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                */
                var Caixa_de_Mensagem = new MessageDialog("Tente novamente.", "Você errou");
                var Resultado = await Caixa_de_Mensagem.ShowAsync();
            }
        }

        private void Restaurar_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Desafio_2));
        }

        private async void Sim_Click(object sender, RoutedEventArgs e)
        {
            Sim.Content = "Errado";

            if (Nao.Content != "Certo")
            {
                Sim.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
                Sim.Background = new SolidColorBrush(Windows.UI.Colors.Red);

                var Caixa_de_Mensagem = new MessageDialog("O grafo possui mais de 2 vértices de grau ímpar, logo, ele não é euleriano.", "Você errou");
                var Resultado = await Caixa_de_Mensagem.ShowAsync();
            }
            Proximo.IsEnabled = true;
        }

        private void Nao_Click(object sender, RoutedEventArgs e)
        {
            Nao.Content = "Certo";

            if (Sim.Content != "Errado")
            {
                Nao.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
                Nao.Background = new SolidColorBrush(Windows.UI.Colors.Green);
            }
            Proximo.IsEnabled = true;

        }

        private void Anterior_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Desafio_1));
        }
              
        private void Proximo_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Desafio_3));
        }
    }
}
