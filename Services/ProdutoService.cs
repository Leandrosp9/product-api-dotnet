using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Product.Api.Data;
using Product.Api.DTOs;
using Product.Api.Models;
using Product.Api.Services.Interfaces;
using System.Runtime.CompilerServices;

namespace Product.Api.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ProdutoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> AtualizarAsync(int id, UpdateProdutoDto dto)
        {
            var produto = await _context.Produtos.FindAsync(id);
           
            if (produto == null) return false;

            produto.Nome = dto.Nome;
            produto.Preco = dto.Preco;
            produto.Estoque = dto.Estoque;

            _mapper.Map(dto, produto);
            await _context.SaveChangesAsync();
            
            return true;
        }

        public async Task<ReadProdutoDto?> BuscarPorIdAsync(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            
            if (produto == null) return null;

            var readDto = _mapper.Map<ReadProdutoDto>(produto);
            return readDto;
        }

        public async Task<ReadProdutoDto> CriarAsync(CreateProdutoDto dto)
        {
            var produto = _mapper.Map<Produto>(dto);

            _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();

            var readDto = _mapper.Map<ReadProdutoDto>(produto);

            return readDto;
        }

        public async Task<bool> DeletarAsync(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            
            if (produto == null) return false;

            _context.Produtos.Remove(produto);
            _context.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<ReadProdutoDto>> ListarAsync()
        {
            var produtos = await _context.Produtos.ToListAsync();

            return _mapper.Map<IEnumerable<ReadProdutoDto>>(produtos);
        }
    }
}
