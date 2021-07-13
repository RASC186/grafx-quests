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
    public sealed partial class Desafio_3 : Page
    {
        public Desafio_3()
        {
            this.InitializeComponent();
            Proximo.IsEnabled = false;
        }

        private async void Nao_Click(object sender, RoutedEventArgs e)
        {
            Nao.Content = "Errado";

            if (Sim.Content != "Certo")
            {
                Nao.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
                Nao.Background = new SolidColorBrush(Windows.UI.Colors.Red);

                var Caixa_de_Mensagem = new MessageDialog("Os grafos mostrados abaixo são iguais pois têm número de vértices e respctivos graus idênticos.", "Você errou");
                var Resultado = await Caixa_de_Mensagem.ShowAsync();
            }
            Proximo.IsEnabled = true;
        }

        private async void Sim_Click(object sender, RoutedEventArgs e)
        {
            Sim.Content = "Certo";

            if (Nao.Content != "Errado")
            {
                Sim.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
                Sim.Background = new SolidColorBrush(Windows.UI.Colors.Green);
            }
            Proximo.IsEnabled = true;
        }

        private void Anterior_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Desafio_2));
        }

        private async void Proximo_Click(object sender, RoutedEventArgs e)
        {
            var Caixa_de_Mensagem = new MessageDialog("Você concluiu o GrafX_Quests.", "Parabéns!");
            var Resultado = await Caixa_de_Mensagem.ShowAsync();

            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
