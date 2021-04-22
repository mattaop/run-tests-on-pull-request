using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers;
using Xunit;

namespace XUnitTestProject1 {
    public class WeatherForecastControllerTest {
        WeatherForecastController _weatherForecastController;

        [Fact]
        public void TestGet() {
            _weatherForecastController = new WeatherForecastController();
            var result = _weatherForecastController.Get();
            Assert.IsType<OkObjectResult>(result.Result);

        }
    }
}
