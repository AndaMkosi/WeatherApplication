using System;
using System.Threading.Tasks;
using WeatherAppLibrary;


namespace WeatherAppLibrary
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            WeatherGenerator weatherGenerator = new WeatherGenerator();
            string cptWeather = await weatherGenerator.GetWeather();                      

            Console.WriteLine(cptWeather);


        }
    }
}
