﻿namespace Application.DTOs
{
    public class PedidoProdutoDto
    {
        public long Id { get; set; }
        public long ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public string Observacao { get; set; }
    }
}