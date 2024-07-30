using Application.UseCase;
using Domain.Entities;
using Domain.ValueObjects;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechPosAPI.ControllersRest
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteControllerRest : ControllerBase
    {
        private readonly IClienteUseCase _clienteUseCase;
        public ClienteControllerRest(IClienteUseCase clienteUseCase)
        {
            _clienteUseCase = clienteUseCase;
        }

        [HttpGet]
        public async Task<IActionResult> Obter(string cpf)
        {
            var validaCpf = new CPF(cpf);

            if (validaCpf.EhValido())
            {
                var cliente = await _clienteUseCase.Obter(cpf);
                return Ok(cliente);
            }
            return BadRequest("CPF Inválido");

        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(Cliente cliente)
        {
            string cpf = cliente.Cpf.Numero;
            var validaCpf = new CPF(cpf);

            if (validaCpf.EhValido())
            {
                await _clienteUseCase.Cadastrar(cliente);
                return Ok();
            }

            return BadRequest("CPF Inválido");
        }
    }
}
