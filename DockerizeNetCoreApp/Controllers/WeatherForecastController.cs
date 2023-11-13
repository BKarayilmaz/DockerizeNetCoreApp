using Microsoft.AspNetCore.Mvc;

namespace DockerizeNetCoreApp.Controllers
{
    [ApiController]
    [Route("/test")]
    public class WeatherForecastController : ControllerBase
    {
       
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Dockerize .Net Core API 0.2";
        }
    }
}