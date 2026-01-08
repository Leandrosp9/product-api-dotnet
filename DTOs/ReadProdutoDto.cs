namespace Product.Api.DTOs
{
    public class ReadProdutoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
