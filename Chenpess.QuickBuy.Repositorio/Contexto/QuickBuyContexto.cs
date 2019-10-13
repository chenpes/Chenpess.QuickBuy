using Chenpess.QuickBuy.Dominio.BLL;
using Chenpess.QuickBuy.Dominio.Entidades;
using Chenpess.QuickBuy.Repositorio.Config;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Chenpess.QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento()
                {
                    id = 1,
                    descricao = "Forma de pagamento Boleto",
                    nome = "Boleto"
                },
                new FormaPagamento()
                {
                    id = 2,
                    descricao = "Forma de pagamento cartão",
                    nome = "Cartao"
                },
                new FormaPagamento()
                {
                    id = 3,
                    descricao = "Forma de pagamento Deposito",
                    nome = "Deposito"
                }
         );

            base.OnModelCreating(modelBuilder);
        }
    }
}
