﻿using Domain.Enums;

namespace Application.DTOs
{
    public class PedidoDto
    {
        public long Id { get; set; }
        public DateTime DataCriacao { get; set; }       
        public long? ClienteId { get; set; }
        public decimal ValorTotal { get; set; }
        public StatusEnum Status { get; set; }
        public virtual ICollection<PedidoProdutoDto> Produtos { get; set; }
    }
}