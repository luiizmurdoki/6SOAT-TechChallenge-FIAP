using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCase
{
    public class ClienteUseCase : IClienteUseCase
    {
        private readonly IClienteGateway _gateway;
        public ClienteUseCase(IClienteGateway gateway)
        {
            _gateway = gateway;
        }
        public async Task<Cliente> Cadastrar(Cliente cliente)
        {

            bool validaClienteExiste = _gateway.ValidaCliente(cliente.Cpf.Numero);

            if (!validaClienteExiste)
            {
                return await _gateway.Inserir(cliente);
            }

            throw new ArgumentNullException("Cliente já cadastrado");

        }

        public async Task<Cliente> Obter(string cpf)
        {
            return await _gateway.ObterPorCPF(cpf);
        }
    }
}