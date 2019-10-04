using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppLibrary
{
   public class WeatherGenerator
    {
        public async Task<string> GetWeather()  //Method
        {
            HttpClient client = new HttpClient();
            String cptWeather = await client.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=Cape%20Town&appid=248ca220af551521c2584c4f18912d69");
            var weather = JsonConvert.DeserializeObject<WeatherData>(cptWeather);

            string returnString = string.Empty;

            foreach (var weatherItem in weather.weather)
                returnString = weatherItem.description;

            return returnString;

        }
    }
}
