using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Gateways
{
    public class ProdutosGateways : IProdutosDataSource
    {
        private readonly TechChallengeContext _context;

        public ProdutosGateways(TechChallengeContext context)
        {
            _context = context;
        }

        public async Task<Produto> ObterProdutoPorId(long id) => await _context.Produto.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<List<Produto>> ListarProdutos()
        {
            return _context.Produto.Include(x => x.Categoria).ToList();
             
        }

        public async Task<Produto> InserirProdutos(Produto produto)
        {
            if (produto is null)
            {
                throw new ArgumentNullException(nameof(produto));
            }
            var categoria = await _context.Categoria.FirstOrDefaultAsync(x => x.Id == produto.Categoria.Id);
            produto.Categoria = categoria;
            _context.Produto.Add(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto> AtualizarProdutos(Produto produto)
        {
            var produtoDb = _context.Produto.Find(produto.Id);
            var categoria = await _context.Categoria.FirstOrDefaultAsync(x => x.Id == produto.Categoria.Id);

            produtoDb.Valor = produto.Valor;
            produtoDb.Descricao = produto.Descricao;
            produtoDb.Categoria = categoria;
            produtoDb.Categoria.Id = produto.Categoria.Id;
            produtoDb.Categoria.Descricao = produto.Categoria.Descricao;
             
            _context.Produto.Update(produtoDb);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task ExcluirProdutos(long id)
        {
             _context.Produto.Remove(_context.Produto.Find(id));
            await _context.SaveChangesAsync();
           
        }

        public async Task<List<Produto>> ListarPorCategoria(long idCategoria)
        {
            var produtosCategoria =  _context.Produto.Include(x => x.Categoria).Where(x => x.Categoria.Id == idCategoria);
            return produtosCategoria.ToList();
        }
    }
}
