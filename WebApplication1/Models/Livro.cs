using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1.Models
{
    public class Livro
    {
        public int Id { get; private set; } //a linguagem ja identifica como chave-primaria 

        [Required]
        [MaxLength(80)]
        public string Titulo { get; set; } = string.Empty; // string.Empty força o programa a n quebrar a aplicação caso seja nulo a string

        [Required]
        [MaxLength(60)]
        public string Autor { get; set; } = string.Empty;

        public int AnoLancamento { get; set; }
    }
}
