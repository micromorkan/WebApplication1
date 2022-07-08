using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost(Name = "PostWeatherForecast")]
        public IEnumerable<WeatherForecast> Post(Estojo estojo)
        {
            //Lapis lapis = new Lapis();
            //lapis.Ponta = estojo.PontaLapis;
            //lapis.Marca = estojo.MarcaLapis;

            //LapisNegocio.InserirLapis(lapis);

            //Caneta caneta = new Caneta();
            //caneta.Marca = estojo.MarcaCaneta;
            //caneta.Cor = estojo.CorCaneta;

            //CanetaNegocio.InsetirCaneta(caneta)

            return null;
        }
    }

    public class Caneta
    {
        public string Cor { get; set; }
        public string Marca { get; set; }
    }

    public class Lapis
    {
        public string Marca { get; set; }
        public decimal Ponta { get; set; }
    }

    public class Estojo
    {
        public string MarcaA { get; set; }
        public string CorCaneta { get; set; }
        public string MarcaB { get; set; }
        public decimal PontaLapis { get; set; }
    }
}