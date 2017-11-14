using MEXA_SE.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MEXA_SE.Infra.Presistence.Map
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");

            HasKey(x => x.UsuarioId);


            Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(60).IsRequired();
            Property(x => x.Email).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(x => x.Senha).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(x => x.IsAdmin).HasColumnType("bit").IsRequired();


            HasMany(e => e.AtividadeDia).WithRequired(e => e.Usuario).HasForeignKey(e => e.UsuarioId).WillCascadeOnDelete(false);
            HasMany(e => e.Avaliacao).WithRequired(e => e.Usuario).HasForeignKey(e => e.UsuarioId).WillCascadeOnDelete(false);
            HasMany(e => e.UsuarioTreino).WithRequired(e => e.Usuario).HasForeignKey(e => e.UsuarioId).WillCascadeOnDelete(false);
        }
    }
}
