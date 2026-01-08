using Product.Api.DTOs;

namespace Product.Api.Services.Interfaces
{
    public interface IProdutoService
    {
        Task<ReadProdutoDto> CriarAsync(CreateProdutoDto dto);
        Task<IEnumerable<ReadProdutoDto>> ListarAsync();
        Task<ReadProdutoDto?> BuscarPorIdAsync(int id);
        Task<bool> AtualizarAsync(int id, UpdateProdutoDto dto);
        Task<bool> DeletarAsync(int id);
    }
}
