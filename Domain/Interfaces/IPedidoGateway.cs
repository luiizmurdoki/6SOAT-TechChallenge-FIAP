using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IPedidoGateway
    {
        Task<List<Pedido>> ListarPedidos();
        Task<Pedido> ObterPorId(long id);
        Task<Pedido> Inserir(Pedido pedido);
        Task<Pedido> Atualizar(Pedido pedido);
    }
}
