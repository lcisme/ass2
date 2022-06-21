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
using T2108M_UWP.Helpers;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T2108M_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {// mainframe ở đây là khi mở hiện luôn ra trang home
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Pages.Home));
            SQLiteHelper sq = SQLiteHelper.GetInstance();
        }

        private void Click_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }
        private void Home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Home));
        }

        private void Account_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Account));
        }

        private void Weather_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Weather));
        }
        private void QLSV_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.QLSV));
        }
    }
}
