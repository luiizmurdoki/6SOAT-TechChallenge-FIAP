using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IProdutosGateway
    {
        Task<Produto> ObterProdutoPorId(long id);
        Task<List<Produto>> ListarProdutos();
        Task<Produto> InserirProdutos(Produto produto);
        Task<Produto> AtualizarProdutos(Produto produto);
        Task ExcluirProdutos(long id);
        Task<List<Produto>> ListarPorCategoria(long idCategoria);
    }
}
