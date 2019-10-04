using Chenpess.QuickBuy.Dominio.BLL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chenpess.QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int id { get; set; }
        public DateTime dataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual  Usuario Usuario { get; set; }
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

        public override void Validade()
        {
            limparMensagemValidacao();
            if (!itensPedido.Any())
                adicionarMensagem("Critica: pedido não pode ser vazio");

            if (string.IsNullOrEmpty(CEP))
                adicionarMensagem("Critica: Cep não pode ser vazio!");


        }

    }
}
