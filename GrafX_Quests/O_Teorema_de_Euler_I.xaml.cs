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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GrafX_Quests
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class O_Teorema_de_Euler_I : Page
    {
        int cont = 0;

        int Grau_de_A_Int = 3, Grau_de_B_Int = 3, Grau_de_C_Int = 3, Grau_de_D_Int = 5;
        public O_Teorema_de_Euler_I()
        {
            this.InitializeComponent();
            Grau_de_A.Text = "" + Grau_de_A_Int;
            Grau_de_B.Text = "" + Grau_de_B_Int;
            Grau_de_C.Text = "" + Grau_de_C_Int;
            Grau_de_D.Text = "" + Grau_de_D_Int;
        }

        private void Linha_AB_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_A_Int = Grau_de_A_Int - 1;
            Grau_de_A.Text = "" + Grau_de_A_Int;
            Grau_de_B_Int = Grau_de_B_Int - 1;
            Grau_de_B.Text = "" + Grau_de_B_Int;
            Linha_AB.Visibility = Visibility.Collapsed;

            Teste_de_Caminho_Euleriano();
        }

        private void Linha_BC_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_B_Int = Grau_de_B_Int - 1;
            Grau_de_B.Text = "" + Grau_de_B_Int;
            Grau_de_C_Int = Grau_de_C_Int - 1;
            Grau_de_C.Text = "" + Grau_de_C_Int;
            Linha_BC.Visibility = Visibility.Collapsed;

            Teste_de_Caminho_Euleriano();
        }

        private void Linha_BD_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_B_Int = Grau_de_B_Int - 1;
            Grau_de_B.Text = "" + Grau_de_B_Int;
            Grau_de_D_Int = Grau_de_D_Int - 1;
            Grau_de_D.Text = "" + Grau_de_D_Int;
            Linha_BD.Visibility = Visibility.Collapsed;

            Teste_de_Caminho_Euleriano();
        }

        private void Linha_CD1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_C_Int = Grau_de_C_Int - 1;
            Grau_de_C.Text = "" + Grau_de_C_Int;
            Grau_de_D_Int = Grau_de_D_Int - 1;
            Grau_de_D.Text = "" + Grau_de_D_Int;
            Linha_CD1.Visibility = Visibility.Collapsed;

            Teste_de_Caminho_Euleriano();
        }       

        private void Linha_CD2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_C_Int = Grau_de_C_Int - 1;
            Grau_de_C.Text = "" + Grau_de_C_Int;
            Grau_de_D_Int = Grau_de_D_Int - 1;
            Grau_de_D.Text = "" + Grau_de_D_Int;
            Linha_CD2.Visibility = Visibility.Collapsed;

            Teste_de_Caminho_Euleriano();
        }

        private void Linha_AD1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_A_Int = Grau_de_A_Int - 1;
            Grau_de_A.Text = "" + Grau_de_A_Int;
            Grau_de_D_Int = Grau_de_D_Int - 1;
            Grau_de_D.Text = "" + Grau_de_D_Int;
            Linha_AD1.Visibility = Visibility.Collapsed;

            Teste_de_Caminho_Euleriano();
        }

        private void Linha_AD2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grau_de_A_Int = Grau_de_A_Int - 1;
            Grau_de_A.Text = "" + Grau_de_A_Int;
            Grau_de_D_Int = Grau_de_D_Int - 1;
            Grau_de_D.Text = "" + Grau_de_D_Int;
            Linha_AD2.Visibility = Visibility.Collapsed;

            Teste_de_Caminho_Euleriano();
        }

        public async void Teste_de_Caminho_Euleriano()
        {
            if (Grau_de_A_Int % 2 == 0 &&
                Grau_de_B_Int % 2 == 0 &&
                Grau_de_C_Int % 2 == 0 &&
                Grau_de_D_Int % 2 == 0 &&
                Grau_de_A_Int != 0 &&
                Grau_de_B_Int != 0 &&
                Grau_de_C_Int != 0 &&
                Grau_de_D_Int != 0)
            {
                cont++;

                Grau_de_A.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                Grau_de_B.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                Grau_de_C.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                Grau_de_D.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);

                Linha_AB.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_AD1.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_AD2.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_BC.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_BD.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_CD1.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);
                Linha_CD2.Stroke = new SolidColorBrush(Windows.UI.Colors.Green);

                var Caixa_de_Mensagem = new MessageDialog("Você encontrou um caminho euleriano!", "Parabéns!");
                var Resultado = await Caixa_de_Mensagem.ShowAsync();
            }
            else
            {
                Grau_de_A.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);
                Grau_de_B.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);
                Grau_de_C.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);
                Grau_de_D.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);

                Linha_AB.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
                Linha_AD1.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
                Linha_AD2.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
                Linha_BC.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
                Linha_BD.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
                Linha_CD1.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
                Linha_CD2.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            }
        }

        private void Anterior_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Graus_dos_Vertices));
        }

        private void Restaurar_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(O_Teorema_de_Euler_I));
        }

        private void Proximo_Click(object sender, RoutedEventArgs e)
        {
            if (cont > 0)
            {
                this.Frame.Navigate(typeof(O_Teorema_de_Euler_II));
            }
            else
            {
                Aviso_Proximo_Button();
            }
        }

        private async void Aviso_Proximo_Button()
        {
            var Caixa_de_Mensagem = new MessageDialog("Forme um caminho euleriano deletando arestas para continuar.", "Grafo Interativo");
            var Resultado = await Caixa_de_Mensagem.ShowAsync();
        }
    }
}
