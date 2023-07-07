using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        [HttpPost]
        public ActionResult Post([FromBody] carroModel Carro)
        {
            if (Carro.Modelo == "X3") {
                Carro.Placa = "BMW";
                Carro.NumeroPuertas = 100;
            }
            else if(Carro.Modelo == "X5")
            {
                Carro.Placa = "P232323";
                Carro.NumeroPuertas = 4;
            }
            return Ok(Carro);
            


        }
    }
}
