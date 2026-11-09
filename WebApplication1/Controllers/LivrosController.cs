using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")] // /api/Livros --> simplificação da rota
    [ApiController]
    public class LivrosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetLivros()
        {
            var livrosBancoFalso = new List<string> 
            { 
                "Varity",
                "Os elefantes não esquecem",
                "Beladonna",
                "Harry Potter e a Pedra Filosofal"
            };

            return Ok(livrosBancoFalso);
        }
    }
}
