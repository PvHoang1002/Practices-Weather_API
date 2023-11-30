using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace WeatherAPI.Controllers
{
    [Route("api")]
    public class WeatherForecastController : Controller
    {
        [HttpGet("getweatherforecast")]
        public async Task<IActionResult> GetWeatherForecast(string city)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://api.openweathermap.org");
                    var response = await client.GetAsync($"/data/2.5/forecast?lat=21.0278&lon=105.8342&appid=65e0559440b25d3b571b98e12437c350&units=metric");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var weatherData = JsonConvert.DeserializeObject<OpenWeatherForecastResponse>(stringResult);

                    if (weatherData == null)
                    {
                        return BadRequest("Weather data is null");
                    }

                    var weatherList = weatherData.List!.Select(entry => new
                    {
                        DateTime = entry.Dt_Txt,
                        Temp = entry.Main!.Temp,
                        Humidity = entry.Main!.Humidity,
                        Description = entry.Weather!.FirstOrDefault()?.Description,
                        City = weatherData.City?.Name
                    }).ToList();

                    return Ok(weatherList);
                }
                catch (HttpRequestException httpRequestException)
                {
                    return BadRequest($"Error getting weather forecast from OpenWeather: {httpRequestException.Message}");
                }
            }
        }
    }
}
