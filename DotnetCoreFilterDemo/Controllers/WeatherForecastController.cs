using System;
using System.Collections.Generic;
using System.Linq;
using DotnetCoreFilterDemo.Filter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotnetCoreFilterDemo.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
   // [CustomerExceptionFilter]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        
        public IEnumerable<WeatherForecast> Get()
        {
            int j = 0;
            int i = 1 / j;

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();

            
        }

        [HttpGet]
        [CustomerActionFilter]
        [CustomerResultFilter]
        [CustomerResourceFilter]
        public void GetT()
        {
            Console.WriteLine("This is GetT");
        }
    }
}
