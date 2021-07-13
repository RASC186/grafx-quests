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
    public sealed partial class O_Teorema_de_Euler_II : Page
    {
        public O_Teorema_de_Euler_II()
        {
            this.InitializeComponent();
        }

        int cont = 0;

        private void Linha_AB_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Linha_AB.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
            cont++;
            Grafo_Interativo_Teste();
        }

        private void Linha_BC_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Linha_BC.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
            cont++;
            Grafo_Interativo_Teste();
        }

        private void Linha_AD_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Linha_AD.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
            cont++;
            Grafo_Interativo_Teste();
        }

        private void Linha_DE_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Linha_DE.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
            cont++;
            Grafo_Interativo_Teste();
        }

        private void Linha_EC_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Linha_EC.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
            cont++;
            Grafo_Interativo_Teste();
        }

        private void Linha_AF_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Linha_AF.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
            cont++;
            Grafo_Interativo_Teste();
        }

        private void Linha_FC_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Linha_FC.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
            cont++;
            Grafo_Interativo_Teste();
        }

        private void Ponto_A_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Ponto_A.Fill = new SolidColorBrush(Windows.UI.Colors.Green);
        }
        private void Ponto_B_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Ponto_B.Fill = new SolidColorBrush(Windows.UI.Colors.Green);
        }
        private void Ponto_C_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Ponto_C.Fill = new SolidColorBrush(Windows.UI.Colors.Green);
        }

        private void Ponto_D_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Ponto_D.Fill = new SolidColorBrush(Windows.UI.Colors.Green);
        }

        private void Ponto_E_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Ponto_E.Fill = new SolidColorBrush(Windows.UI.Colors.Green);
        }

        private void Ponto_F_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Ponto_F.Fill = new SolidColorBrush(Windows.UI.Colors.Green);
        }

        private void Anterior_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(O_Teorema_de_Euler_I));
        }

        private void Restaurar_Click(object sender, RoutedEventArgs e)
        {
            Linha_AB.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            Linha_AF.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            Linha_AD.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            Linha_BC.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            Linha_FC.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            Linha_DE.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            Linha_EC.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);

            Ponto_A.Fill = new SolidColorBrush(Windows.UI.Colors.Blue);
            Ponto_B.Fill = new SolidColorBrush(Windows.UI.Colors.Blue);
            Ponto_C.Fill = new SolidColorBrush(Windows.UI.Colors.Blue);
            Ponto_D.Fill = new SolidColorBrush(Windows.UI.Colors.Blue);
            Ponto_E.Fill = new SolidColorBrush(Windows.UI.Colors.Blue);
            Ponto_F.Fill = new SolidColorBrush(Windows.UI.Colors.Blue);
            
        }

        private async void Grafo_Interativo_Teste()
        {
            if (cont == 1)
            {
                var Caixa_de_Mensagem = new MessageDialog("Os pontos também são interativos neste exemplo didático.", "Grafo Interativo");
                var Resultado = await Caixa_de_Mensagem.ShowAsync();
            }
        }

        private void Proximo_Click(object sender, RoutedEventArgs e)
        {
            if (cont > 4)
            {
                this.Frame.Navigate(typeof(Polimorfismo));
            }
            else
            {
                Aviso_Proximo_Button();
            }
        }

        private async void Aviso_Proximo_Button()
        {
            var Caixa_de_Mensagem = new MessageDialog("Trace um caminho que passe por pelo menos 5 arestas para continuar.", "Grafo Interativo");
            var Resultado = await Caixa_de_Mensagem.ShowAsync();
        }
    }
}
