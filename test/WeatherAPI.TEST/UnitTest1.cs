using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using WeatherAPI.Controllers;
using WeatherAPI;

namespace SimpleAPI.TEST
{
    public class WeatherConditionControllerTests
    {
        [Fact]
        public async Task CityReturnsWeatherData()
        {
            // Arrange
            var loggerMock = Mock.Of<ILogger<WeatherController>>();
            var controller = new WeatherController(loggerMock);

            // Act
            var result = await controller.City("Ha Noi");

            // Assert
            Assert.NotNull(result); 
            Assert.IsType<OkObjectResult>(result); 
        }
    }
}



