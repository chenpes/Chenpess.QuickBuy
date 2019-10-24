using Chenpess.QuickBuy.Dominio.Contratos;
using Chenpess.QuickBuy.Dominio.Entidades;
using Chenpess.QuickBuy.Repositorio.Contexto;

namespace Chenpess.QuickBuy.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {
        }
    }
}
