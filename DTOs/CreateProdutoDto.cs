using System.ComponentModel.DataAnnotations;

namespace Product.Api.DTOs
{
    public class CreateProdutoDto
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Preco { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Estoque { get; set; }
    }
}
