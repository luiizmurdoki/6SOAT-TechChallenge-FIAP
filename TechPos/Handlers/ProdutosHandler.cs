using Application.UseCase.Produtos;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechPosAPI.Handlers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosHandler : ControllerBase
    {
        private readonly IProdutosUseCase _produtosUseCase;

        public ProdutosHandler(IProdutosUseCase produtosUseCase)
        {
            _produtosUseCase = produtosUseCase;
        }


        [HttpGet]
        public async Task<IActionResult> ListarProdutos()
        {
            var produtos = await _produtosUseCase.Listar();

            return Ok(produtos);
        }


        [HttpGet("categoria-produtos/{id}")]
        public async Task<IActionResult> ListarProdutosId(long id)
        {
            var produtosCategoria = await _produtosUseCase.ListarPorCategoria(id);

            return Ok(produtosCategoria);
        }


        [HttpPost]
        public async Task<IActionResult> Cadastrar(Produto produto)
        {
            await _produtosUseCase.Cadastrar(produto);

            return Ok();
        }


        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch([FromBody] Produto produto)
        {
            await _produtosUseCase.Atualizar(produto);

            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Remover(long id)
        {
            await _produtosUseCase.Excluir(id);

            return Ok();
        }
    }
}
