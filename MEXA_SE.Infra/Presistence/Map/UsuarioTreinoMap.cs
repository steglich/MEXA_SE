using MEXA_SE.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MEXA_SE.Infra.Presistence.Map
{
    public class UsuarioTreinoMap : EntityTypeConfiguration<UsuarioTreino>
    {
        public UsuarioTreinoMap()
        {
            ToTable("UsuarioTreino");

            HasKey(x => new { x.UsuarioId, x.TreinoId });

            Property(x => x.UsuarioId).HasColumnName("PfkUsuario").HasColumnType("int").IsRequired();
            Property(x => x.TreinoId).HasParameterName("PfkTreino").HasColumnType("int").IsRequired();
            Property(x => x.DtTreino).HasColumnType("smalldatetime").IsRequired();

            //HasRequired(a => a.Usuario).WithMany(b => b.UsuarioTreino).HasForeignKey(c => c.UsuarioId);
            //HasRequired(a => a.Treino).WithMany(b => b.UsuarioTreino).HasForeignKey(c => c.TreinoId);
        }
    }
}
