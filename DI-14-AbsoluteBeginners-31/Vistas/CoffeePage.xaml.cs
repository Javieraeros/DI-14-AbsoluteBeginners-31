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

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace DI_14_AbsoluteBeginners_31.Vistas
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        private String roast, sweetener, cream;
        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void Roast_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            roast = selected.Text;
            muestraResultado();
        }


        private void Sweetener_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            sweetener = selected.Text;
            muestraResultado();
        }

        private void Cream_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            cream = selected.Text;
            muestraResultado();
        }

        private void muestraResultado()
        {
            if(roast!="None" && !String.IsNullOrEmpty(roast))
            {
                ResultTextBlock.Text = roast;
                if(cream != "None" && !String.IsNullOrEmpty(cream))
                {
                    ResultTextBlock.Text += " + " + cream;
                }
                if (sweetener != "None" && !String.IsNullOrEmpty(sweetener))
                {
                    ResultTextBlock.Text += " + " + sweetener;
                }

            }
            else
            {
                ResultTextBlock.Text = "None";
            }
        }
    }
}
