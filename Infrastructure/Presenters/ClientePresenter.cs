using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Presenters
{
    public class ClientePresenter
    {
        public ClientePresenter() { }

        public ClienteDto MontarCliente(Cliente cliente)
        {
            return new ClienteDto
            {
                Id = cliente.Id,
                Name = cliente.Name,
                Email = cliente.Email.Valor,
                Cpf = cliente.Cpf.Numero

            };
        }
    }
}
