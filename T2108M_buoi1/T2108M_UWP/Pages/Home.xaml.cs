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
using T2108M_UWP.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2108M_UWP.Pages
{
   
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
            StudentList.Items.Add (new Student()
            { 
                Id = 1,
                Name = " Le Cuong",
                Age = 18,
                Address = "Long Bien, Ha Noi"
            });
        }
    }
}
