using Microsoft.AspNetCore.Mvc;
using PruebasInicial.Services;

namespace PruebasInicial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ICalculadora Micalculadora;
        public WeatherForecastController(ICalculadora micalculadora)
        {
            this.Micalculadora = micalculadora;
        }
        [HttpGet]
        [Route("Suma/{numero1:int}/{numero2:int}")]
        public double Suma(int numero1, int numero2)
        {
            return Micalculadora.Suma(numero1, numero2);
        }
        [HttpGet]
        [Route("Resta/{numero1:int}/{numero2:int}")]
        public double Resta(int numero1, int numero2)
        {
            return Micalculadora.Resta(numero1, numero2);

        }
        [HttpGet]
        [Route("Multiplica/{numero1:int}/{numero2:int}")]
        public double Multiplica(int numero1, int numero2)
        {
            return Micalculadora.Multiplica(numero1, numero2);
        }
        [HttpGet]
        [Route("Divide/{numero1:int}/{numero2:int}")]
        public double Divide(int numero1, int numero2)
        {
            return Micalculadora.Divide(numero1, numero2);
        }
    }
}
