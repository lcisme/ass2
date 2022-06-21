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
using T2108M_UWP.Services;
using T2108M_UWP.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2108M_UWP.Pages
{
  
    public sealed partial class Weather : Page
    {
        public Weather()
        {
            this.InitializeComponent();
            PrintTemp();
            
        }

        public async void PrintTemp()
        {
            WeatherServices ws = new WeatherServices();
            ListWeather lw = await ws.GetListWeather();
            // lay api weather
            TempList1.Items.Add(lw.city);
            for(int i =0; i < 10; i++)
            {
                TempList.Items.Add(lw.list[i]);
            
            }

               /*   for(int i = 0; i < cw.list.Count;i++)
                  // cach 1
                        {
                   //   Console.WriteLine(cw.list[i].main.temp);
                   Temp.Text = cw.list[i].main.feels_like.ToString(); 
                    // tuwj viet them
               }*/
              /*  //cach 2
                  foreach (List tt in cw.list)
            {
                // Console.WriteLine(tt.main.temp);
                Temp.Text = tt.main.temp.ToString();
                FeelLike.Text = tt.main.feels_like.ToString();
                TempMin.Text = tt.main.temp_min.ToString();
                TempMax.Text = tt.main.temp_max.ToString();
                Sealevel.Text = tt.main.sea_level.ToString();
                Pressure.Text = tt.main.pressure.ToString();
                Grndlevel.Text = tt.main.grnd_level.ToString();
                Humidity.Text = tt.main.humidity.ToString();
                Tempkf.Text = tt.main.temp_kf.ToString();
            }*/

            /*      cach 3
                 Temp.Text = cw.city.name;
                 FeelLike.Text = cw.city.coord.ToString();
                 TempMin.Text = cw.city.country.ToString();
                 TempMax.Text = cw.city.population.ToString();
                 Pressure.Text = cw.city.timezone.ToString();
                 Grndlevel.Text = cw.city.sunrise.ToString();
                 Humidity.Text = cw.city.sunset.ToString();
            */

            /*// câu 4
            foreach(List tt in cw.list)
            {
                Time.Text = cw.city.timezone.ToString();
                Temp.Text = tt.main.temp.ToString();
                Description.Text = tt.weather[0].description.ToString();
            }*/
        }
    }
}
