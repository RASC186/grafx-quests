﻿#pragma checksum "C:\Users\Computador\Desktop\UWP Applications\GrafX_Quests\GrafX_Quests\GrafX_Quests\O_Teorema_de_Euler_I.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "03DC62F0C5131F786F4CA882B6ACB3DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrafX_Quests
{
    partial class O_Teorema_de_Euler_I : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Titulo_O_Teorema_de_Euler_I = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    this.Anterior = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 442 "..\..\..\O_Teorema_de_Euler_I.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Anterior).Click += this.Anterior_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.Restaurar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 446 "..\..\..\O_Teorema_de_Euler_I.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Restaurar).Click += this.Restaurar_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.Proximo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 451 "..\..\..\O_Teorema_de_Euler_I.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Proximo).Click += this.Proximo_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.Grafo_Interativo = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6:
                {
                    this.Grau_de_D = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.Grau_de_C = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.Grau_de_B = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.Grau_de_A = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.Linha_AB = (global::Windows.UI.Xaml.Shapes.Polyline)(target);
                    #line 62 "..\..\..\O_Teorema_de_Euler_I.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Polyline)this.Linha_AB).Tapped += this.Linha_AB_Tapped;
                    #line default
                }
                break;
            case 11:
                {
                    this.Linha_BC = (global::Windows.UI.Xaml.Shapes.Polyline)(target);
                    #line 67 "..\..\..\O_Teorema_de_Euler_I.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Polyline)this.Linha_BC).Tapped += this.Linha_BC_Tapped;
                    #line default
                }
                break;
            case 12:
                {
                    this.Linha_BD = (global::Windows.UI.Xaml.Shapes.Polyline)(target);
                    #line 72 "..\..\..\O_Teorema_de_Euler_I.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Polyline)this.Linha_BD).Tapped += this.Linha_BD_Tapped;
                    #line default
                }
                break;
            case 13:
                {
                    this.Linha_CD1 = (global::Windows.UI.Xaml.Shapes.Polyline)(target);
                    #line 77 "..\..\..\O_Teorema_de_Euler_I.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Polyline)this.Linha_CD1).Tapped += this.Linha_CD1_Tapped;
                    #line default
                }
                break;
            case 14:
                {
                    this.Linha_CD2 = (global::Windows.UI.Xaml.Shapes.Polyline)(target);
                    #line 82 "..\..\..\O_Teorema_de_Euler_I.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Polyline)this.Linha_CD2).Tapped += this.Linha_CD2_Tapped;
                    #line default
                }
                break;
            case 15:
                {
                    this.Linha_AD1 = (global::Windows.UI.Xaml.Shapes.Polyline)(target);
                    #line 87 "..\..\..\O_Teorema_de_Euler_I.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Polyline)this.Linha_AD1).Tapped += this.Linha_AD1_Tapped;
                    #line default
                }
                break;
            case 16:
                {
                    this.Linha_AD2 = (global::Windows.UI.Xaml.Shapes.Polyline)(target);
                    #line 92 "..\..\..\O_Teorema_de_Euler_I.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Polyline)this.Linha_AD2).Tapped += this.Linha_AD2_Tapped;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

