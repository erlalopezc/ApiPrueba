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
            }
            return Ok(Carro);
            


        }
    }
}
