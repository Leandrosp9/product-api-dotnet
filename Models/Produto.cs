using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product.Api.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
        public string? Nome { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Estoque não pode ser negativo")]
        public int Estoque { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    }
}
