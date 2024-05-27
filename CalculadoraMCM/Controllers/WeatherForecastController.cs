using CalculadoraMCM.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraMCM.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ICalculadora MiCalculadora;
        public WeatherForecastController(ICalculadora micalculadora)
        {
            this.MiCalculadora = micalculadora;
        }
        [HttpGet]
        [Route("MCD/{numero1:int}/{numero2:int}")]
        public int MCD(int numero1, int numero2)
        {
            return MiCalculadora.MCD(numero1, numero2);
        }
        [HttpGet]
        [Route("MCM/{numero1:int}/{numero2:int}")]
        public int MCM(int numero1, int numero2)
        {
            return MiCalculadora.MCM(numero1, numero2);

        }
    }
}
