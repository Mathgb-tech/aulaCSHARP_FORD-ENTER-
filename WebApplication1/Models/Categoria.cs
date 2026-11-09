using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Categoria
    {
        public int Id { get; private set; }

        [Required]
        [MaxLength(60)]
        public string Nome { get; set; } = string.Empty;
    }
}
