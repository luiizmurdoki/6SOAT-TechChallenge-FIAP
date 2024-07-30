using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCase
{
    public class ClienteUseCase : IClienteUseCase
    {
        private readonly IClienteGateway _repository;
        public ClienteUseCase(IClienteGateway repository)
        {
            _repository = repository;
        }
        public async Task<Cliente> Cadastrar(Cliente cliente)
        {

            bool validaClienteExiste = _repository.ValidaCliente(cliente.Cpf.Numero);

            if (!validaClienteExiste)
            {
                return await _repository.Inserir(cliente);
            }

            throw new ArgumentNullException("Cliente já cadastrado");

        }

        public async Task<Cliente> Obter(string cpf)
        {
            return await _repository.ObterPorCPF(cpf);
        }
    }
}