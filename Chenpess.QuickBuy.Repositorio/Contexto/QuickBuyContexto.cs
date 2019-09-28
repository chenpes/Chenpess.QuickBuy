using Chenpess.QuickBuy.Dominio.BLL;
using Chenpess.QuickBuy.Dominio.Entidades;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Chenpess.QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto: DbContext
    {

        public DbSet<Usuario> Usuarios  { get; set; }
        public DbSet<Produto> Produtos  { get; set; }
        public DbSet<Pedido> Pedidos  { get; set; }
        public DbSet<ItemPedido> ItemPedido  { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {

        }
    }
}
