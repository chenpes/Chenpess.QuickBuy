using Chenpess.QuickBuy.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chenpess.QuickBuy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.id);
            builder
                .Property(p => p.nome)
                .IsRequired()
                .HasMaxLength(80);
            builder
                .Property(p => p.preco)
                .IsRequired();
            builder
                .Property(p => p.quantidade)
                .IsRequired();
        }
    }
}
