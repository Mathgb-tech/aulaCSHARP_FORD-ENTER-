using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoasVindasController : ControllerBase
    {
        [HttpGet("Buscar_Boas-Vindas")]
        public IActionResult GetMensagemBoasVindas()
        {
            var mensagemBoasVindas = "Seja bem-vindo(a) à nossa API!";

            Console.WriteLine("Hello world!");
            return Ok(mensagemBoasVindas);
        }

    }
}
