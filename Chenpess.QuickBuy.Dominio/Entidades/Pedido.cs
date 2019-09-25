using Chenpess.QuickBuy.Dominio.BLL;
using System;
using System.Collections.Generic;

namespace Chenpess.QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int id { get; set; }
        public DateTime dataPedido { get; set; }
        public int usuarioId { get; set; }

        public DateTime dataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }
        public string uf { get; set; }
        public string cidade { get; set; }
        public string enderecoCompleto { get; set; }
        public string numeroEndereco{ get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento formaPagamento { get; set; }

        /// <summary>
        /// pedido deve ter pelo menos 1 item de pedido
        /// </summary>
        public ICollection<ItemPedido> itensPedido { get; set; }

    }
}
