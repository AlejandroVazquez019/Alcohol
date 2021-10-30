using Alcohol.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Alcohol.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlcoholController : ControllerBase
    {
        [HttpGet]
        [Route("Datos")]
        
        public IActionResult Calcula(string bebida,int cantidad, int peso)
        {
            
            var resultado = new Bebidas();
            resultado.AlcoholIngerido(bebida,cantidad);
            if(bebida.ToLower()!= "licor" && bebida.ToLower()!="vermu" && bebida.ToLower()!="cava" 
            &&bebida.ToLower()!="vino" && bebida.ToLower()!="cerveza" && bebida.ToLower()!="brandy")
            {
                return Ok("Usted a Ingresado Una Bebida INCORRECTA.");
            }
            resultado.CantidadAlcoholSangre(peso);
            
            return Ok(resultado.Validar());
        }
    }
}