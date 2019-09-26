using System;
using System.Collections.Generic;
using System.Text;

namespace Chenpess.QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int id { get; set; }
        public int produtoId { get; set; }
        public int quantidade { get; set; }

        public override void Validade()
        {
            throw new NotImplementedException();
        }
    }
}
