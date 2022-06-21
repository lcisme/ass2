using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2108M_UWP.Models;
using System.Net.Http;
using Newtonsoft.Json;
namespace T2108M_UWP.Services
{
    class WeatherServices
    {
        public async Task<ListWeather> GetListWeather()
        {
            HttpClient client = new HttpClient();
            string url = "http://api.openweathermap.org/data/2.5/forecast?q=rome,itali&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
            var rs = await client.GetAsync(url);
            if (rs.IsSuccessStatusCode)
            {
                var stringContent = await rs.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ListWeather>(stringContent);
            }
            return null;
        }
    }
}
