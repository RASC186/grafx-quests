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
    public sealed partial class Desafio_1 : Page
    {
        int Cliques = 0;
        int Grau_de_A = 3;
        int Grau_de_B = 3;
        int Grau_de_C = 3;
        int Grau_de_D = 3;
        int Grau_de_E = 6;
        int Grau_de_F = 3;
        int Grau_de_G = 3;
        int Numero_de_Graus_Pares = 0;
        int Numero_de_Graus_Impares = 0;

        public Desafio_1()
        {
            this.InitializeComponent();

            Tentar_Novamente.Content = "Concluído";
            Proximo.IsEnabled = false;
        }

        private void Linha_AB_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_A--;
            Grau_de_B--;
            Linha_AB.Visibility = Visibility.Collapsed;
            Caminho_Euleriano();
        }

        private void Linha_AC_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_A--;
            Grau_de_C--;
            Linha_AC.Visibility = Visibility.Collapsed;
            Caminho_Euleriano();
        }

        private void Linha_AE_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_A--;
            Grau_de_E--;
            Linha_AE.Visibility = Visibility.Collapsed;
            Caminho_Euleriano();
        }

        private void Linha_BF_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_B--;
            Grau_de_F--;
            Linha_BF.Visibility = Visibility.Collapsed;
            Caminho_Euleriano();
        }

        private void Linha_BE_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_B--;
            Grau_de_E--;
            Linha_BE.Visibility = Visibility.Collapsed;
            Caminho_Euleriano();
        }

        private void Linha_CD_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_C--;
            Grau_de_D--;
            Linha_CD.Visibility = Visibility.Collapsed;
            Caminho_Euleriano();
        }

        private void Linha_CE_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_C--;
            Grau_de_E--;
            Linha_CE.Visibility = Visibility.Collapsed;
            Caminho_Euleriano();
        }

        private void Linha_EF_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_E--;
            Grau_de_F--;
            Linha_EF.Visibility = Visibility.Collapsed;
            Caminho_Euleriano();
        }

        private void Linha_ED_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_E--;
            Grau_de_D--;
            Linha_ED.Visibility = Visibility.Collapsed;
            Caminho_Euleriano();
        }

        private void Linha_EG_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_E--;
            Grau_de_G--;
            Linha_EG.Visibility = Visibility.Collapsed;
            Caminho_Euleriano();
        }

        private void Linha_FG_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_F--;
            Grau_de_G--;
            Linha_FG.Visibility = Visibility.Collapsed;
            Caminho_Euleriano();
        }

        private void Linha_DG_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_D--;
            Grau_de_G--;
            Linha_DG.Visibility = Visibility.Collapsed;
            Caminho_Euleriano();
        }

        private void Anterior_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Polimorfismo));
        }

        private async void Tentar_Novamente_Click(object sender, RoutedEventArgs e)
        {

            if (Tentar_Novamente.Content != "Correto")
            { 
                if (Grau_de_A % 2 == 0)
                {
                    Numero_de_Graus_Pares++;
                }
                else
                {
                    Numero_de_Graus_Impares++;
                }
                if (Grau_de_B % 2 == 0)
                {
                    Numero_de_Graus_Pares++;
                }
                else
                {
                    Numero_de_Graus_Impares++;
                }
                if (Grau_de_C % 2 == 0)
                {
                    Numero_de_Graus_Pares++;
                }
                else
                {
                    Numero_de_Graus_Impares++;
                }
                if (Grau_de_D % 2 == 0)
                {
                    Numero_de_Graus_Pares++;
                }
                else
                {
                    Numero_de_Graus_Impares++;
                }
                if (Grau_de_E % 2 == 0)
                {
                    Numero_de_Graus_Pares++;
                }
                else
                {
                    Numero_de_Graus_Impares++;
                }
                if (Grau_de_F % 2 == 0)
                {
                    Numero_de_Graus_Pares++;
                }
                else
                {
                    Numero_de_Graus_Impares++;
                }
                if (Grau_de_G % 2 == 0)
                {
                    Numero_de_Graus_Pares++;
                }
                else
                {
                    Numero_de_Graus_Impares++;
                }
            }

            if (Grau_de_A != 0 &&
                Grau_de_B != 0 &&
                Grau_de_C != 0 &&
                Grau_de_D != 0 &&
                Grau_de_E != 0 &&
                Grau_de_F != 0 &&
                Grau_de_G != 0 &&
                Numero_de_Graus_Pares == 7 ||
                Grau_de_A !=0 &&
                Grau_de_B != 0 &&
                Grau_de_C != 0 &&
                Grau_de_D != 0 &&
                Grau_de_E != 0 &&
                Grau_de_F != 0 &&
                Grau_de_G != 0 &&
                Numero_de_Graus_Impares == 2 
                && Numero_de_Graus_Pares == 5)
            {
                Proximo.IsEnabled = true;
                Tentar_Novamente.Content = "Correto";
                Tentar_Novamente.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
                Tentar_Novamente.Background = new SolidColorBrush(Windows.UI.Colors.Green);

                Linha_AB.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_AC.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_AE.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_BF.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_BE.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_CD.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_CE.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_ED.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_EF.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_EG.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_FG.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_DG.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);

                if (Cliques == 2)
                {
                    var Caixa_de_Mensagem = new MessageDialog("Você encontrou um caminho euleriano em " + Cliques + " cliques.", "Parabéns!");
                    var Resultado = await Caixa_de_Mensagem.ShowAsync();
                    var Caixa_de_Mensagem_2 = new MessageDialog("Para tentar outras possibilidades clique no botão \"Restaurar\".");
                    var Resultado_2 = await Caixa_de_Mensagem_2.ShowAsync();
                }
                else
                {
                    var Caixa_de_Mensagem_1 = new MessageDialog("Você encontrou um caminho euleriano em " + Cliques + " cliques. É possível " 
                                                             +"encontrar um caminho euleriano com menos arestas deletadas.", "Parabéns!");
                    var Resultado_1 = await Caixa_de_Mensagem_1.ShowAsync();
                    var Caixa_de_Mensagem_2 = new MessageDialog("Para tentar outras possibilidades clique no botão \"Restaurar\".");
                    var Resultado_2 = await Caixa_de_Mensagem_2.ShowAsync();
                }
            }
            else
            {
                Tentar_Novamente.Content = "Tentar novamente";
                var Caixa_de_Mensagem = new MessageDialog("Tente novamente.", "Você errou");
                var Resultado = await Caixa_de_Mensagem.ShowAsync();
                this.Frame.Navigate(typeof(Desafio_1));
            }

        }

        private void Proximo_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Desafio_2));
        }

        private void Caminho_Euleriano()
        {
            Cliques++;
            Cliques_TextBlock.Text = "Cliques efetuados: " + Cliques;
        }

        private void Restaurar_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Desafio_1));
        }
    }
}
