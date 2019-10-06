using Chenpess.QuickBuy.Dominio.BLL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chenpess.QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.id);

            builder
                .Property(f => f.nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(f => f.descricao)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
