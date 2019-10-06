using Chenpess.QuickBuy.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chenpess.QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.id);

            builder
                .Property(p => p.dataPedido)
                .IsRequired();

            builder
                .Property(p => p.dataPrevisaoEntrega)
                .IsRequired();

            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(p => p.cidade)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.uf)
                .IsRequired()
                .HasMaxLength(2);

            builder
                .Property(p => p.enderecoCompleto)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.numeroEndereco)
                .IsRequired();

        }
    }
}
