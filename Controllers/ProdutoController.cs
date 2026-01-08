using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Product.Api.Data;
using Product.Api.DTOs;
using Product.Api.Models;
using Product.Api.Services.Interfaces;

namespace Product.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutoController(IProdutoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CadastraProdutoAsync(CreateProdutoDto dto)
        {
            var produto = await _service.CriarAsync(dto);

            return CreatedAtAction(nameof(GetId), new {id = produto.Id},produto);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadProdutoDto>>> Get()
        {
            var produtos = await _service.ListarAsync();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadProdutoDto>> GetId(int id)
        {
            var produto = await _service.BuscarPorIdAsync(id);

            if(produto == null) return  NotFound();

            return Ok(produto);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizaProduto(int id , UpdateProdutoDto dto)
        {
            var sucesso = await _service.AtualizarAsync(id, dto);

            if (!sucesso) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletaProduto (int id)
        {
            var sucesso = await _service.DeletarAsync(id);

            if (!sucesso) return NotFound();

            return NoContent();
        }
    }
}
