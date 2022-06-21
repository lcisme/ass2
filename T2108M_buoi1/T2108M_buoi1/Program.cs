using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2108M_buoi1.Session1;
using System.Net.Http;
using T2108M_buoi1.DTO;
using Newtonsoft.Json;

namespace T2108M_buoi1
{
    class Program
    {
       /* static async void Main(string[] args)
        {
            CurrentWeather currentWeather = null;
            // call api de lay object
            currentWeather = await GetCurrentWeather();
            // in weather infor
            Console.WriteLine("Nhiet do: " + currentWeather.main.temp);

        }
        // call api -> return 1 object currentweather
        static async Task<CurrentWeather> GetCurrentWeather()
        {
            CurrentWeather current = null;
            HttpClient client = new HttpClient();
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
            HttpResponseMessage res = await client.GetAsync(url);
            if (res.IsSuccessStatusCode)
            {
               string s = await res.Content.ReadAsStringAsync();
               current = JsonConvert.DeserializeObject<CurrentWeather>(s);
            }
            
            return current;

        }*/
        static void Main(string[] args)
        {
            int x = 10;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("x + i = "+(x+i));
            }
            Male m = new Male();
            Male m1 = new Male();

            Car c = new Car();
            Car c1 = new Car();

            c1.Brand = "Mercedes";
            c.Brand = "Vinfast";
            Console.WriteLine(c1.Brand);
            Console.WriteLine(c.Brand);
            List<Car> arr = new List<Car>();
            arr.Add(c);
            arr.Add(new Car());

            Car d = new Car();
            d.Owners.Add("Nguyen Van Cu");
            d.Owners.Add("Nguyen Van Dong");
               
            for(int i = 0; i< d.Owners.Count; i++)
            {
                Console.WriteLine(d.Owners[i]);
            }
            /*
             d.Owners[0] = " LE LE LE"
             d[0] = "Le LE LE"
             tương tự nhau
             */

        }
        
    }
}
