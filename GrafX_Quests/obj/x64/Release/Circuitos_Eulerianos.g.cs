#pragma checksum "C:\Users\Computador\Desktop\UWP Applications\GrafX_Quests\GrafX_Quests\GrafX_Quests\Circuitos_Eulerianos.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C1D39170DCCDFA28E5A090F0E4396B46"
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
    partial class Circuitos_Eulerianos : 
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
                    this.Titulo_Caminhos_Eulerianos = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    this.Anterior = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 60 "..\..\..\Circuitos_Eulerianos.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Anterior).Click += this.Anterior_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.Proximo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 65 "..\..\..\Circuitos_Eulerianos.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Proximo).Click += this.Proximo_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.Grafo_1 = (global::Windows.UI.Xaml.Controls.Image)(target);
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

