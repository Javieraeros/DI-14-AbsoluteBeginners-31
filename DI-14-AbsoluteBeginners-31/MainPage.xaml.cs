using DI_14_AbsoluteBeginners_31.Vistas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DI_14_AbsoluteBeginners_31
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(200, 150));
            MyFrame.Navigate(typeof(DonutPage));
        }

        private void donutClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(DonutPage));
        }

        private void coffeeClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(CoffeePage));
        }

        private void scheduleClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(SchedulePage));
        }

        private void completeClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(CompletePage));
        }


    }
}
