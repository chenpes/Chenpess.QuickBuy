using Chenpess.QuickBuy.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chenpess.QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.id);
            builder
                .Property(u => u.email)
                .IsRequired()
                .HasMaxLength(80);
            builder
                .Property(u => u.senha)
                .IsRequired()
                .HasMaxLength(400);
            builder
                .Property(u => u.nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(u => u.sobreNome)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasMany(u => u.pedidos)
                .WithOne(p => p.Usuario);

        }
    }
}
