﻿#pragma checksum "C:\Users\Computador\Desktop\Teoria dos Grafos\GrafX_Quests\GrafX_Quests\GrafX_Quests\Questao_1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "71867A559B93F1F827AC840DA0BFF427"
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
    partial class Questao_1 : 
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
                    this.Resposta_Border = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 2:
                {
                    this.Restaurar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 51 "..\..\..\Questao_1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Restaurar).Click += this.Restaurar_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.Botoes_RelativePanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 4:
                {
                    this.Anterior_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 94 "..\..\..\Questao_1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Anterior_Button).Click += this.Anterior_Button_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.Dica_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 99 "..\..\..\Questao_1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Dica_Button).Click += this.Dica_Button_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.Proximo_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 141 "..\..\..\Questao_1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Proximo_Button).Click += this.Proximo_Button_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.A = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                    #line 60 "..\..\..\Questao_1.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Ellipse)this.A).Tapped += this.A_Tapped;
                    #line default
                }
                break;
            case 8:
                {
                    this.B = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                    #line 66 "..\..\..\Questao_1.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Ellipse)this.B).Tapped += this.B_Tapped;
                    #line default
                }
                break;
            case 9:
                {
                    this.C = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                    #line 72 "..\..\..\Questao_1.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Ellipse)this.C).Tapped += this.C_Tapped;
                    #line default
                }
                break;
            case 10:
                {
                    this.D = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                    #line 78 "..\..\..\Questao_1.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Ellipse)this.D).Tapped += this.D_Tapped;
                    #line default
                }
                break;
            case 11:
                {
                    this.Titulo_TextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.Questao_TextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
