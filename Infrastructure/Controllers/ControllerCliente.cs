using Application.DTOs;
using Application.UseCase;
using Domain.Entities;
using Domain.Interfaces;
using Domain.ValueObjects;
using Infrastructure.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Controllers
{
    public class ControllerCliente
    {
        private readonly IClienteUseCase _clienteUseCase;
        private readonly ClientePresenter _clientePresenter;
        public ControllerCliente(IClienteUseCase clienteUseCase
            )
        {
            _clienteUseCase = clienteUseCase;
            _clientePresenter = new ClientePresenter();
        }

        public async Task<ClienteDto> Obter(string cpf)
        {
            var validaCpf = new CPF(cpf);
            var cliente = await _clienteUseCase.Obter(cpf);
            return _clientePresenter.MontarCliente(cliente);
        }

        public async Task Cadastrar(Cliente cliente)
        {
            string cpf = cliente.Cpf.Numero;
            var validaCpf = new CPF(cpf);

            if (validaCpf.EhValido())
            {
                await _clienteUseCase.Cadastrar(cliente);
                Console.WriteLine("Cliente cadastrado com sucesso");
            }
            else
            {
                Console.WriteLine("CPF Inválido");
            }
        }

    }
}
