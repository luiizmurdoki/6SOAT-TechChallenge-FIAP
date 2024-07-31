using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IClienteGateway
    {
        Task<Cliente> ObterPorCPF(string cpf);
        Task<Cliente> ObterPorId(long id);
        Task<Cliente> Inserir(Cliente cliente); 
        bool ValidaCliente(string cpf);
    }
}
