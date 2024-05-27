using ApiCadenas.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiCadenas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ICadenas MiCadena;
        public WeatherForecastController(ICadenas micadena)
        {
            this.MiCadena = micadena;
        }
        [HttpGet]
        [Route("Concatena/{cadena1}/{cadena2}")]
        public string Concatena(string cadena1, string cadena2)
        {
            return MiCadena.Concatena(cadena1, cadena2);
        }
        [HttpGet]
        [Route("Cuenta/{cadena1}/{cadena2}")]
        public int Cuenta(string cadena1, string cadena2)
        {
            return MiCadena.Cuenta(cadena1, cadena2);

        }
    }
}
