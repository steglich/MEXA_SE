using MEXA_SE.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MEXA_SE.Infra.Presistence.Map
{
    public class TreinoMap : EntityTypeConfiguration<Treino>
    {
        public TreinoMap()
        {
            ToTable("Ficha");

            HasKey(x => x.TreinoId);

            Property(x => x.DsTreino).HasColumnType("varchar").HasMaxLength(30).IsRequired();

            HasMany(e => e.Exercicio).WithRequired(e => e.Treino).HasForeignKey(e => e.TreinoId).WillCascadeOnDelete(false);
            HasMany(e => e.UsuarioTreino).WithRequired(e => e.Treino).HasForeignKey(e => e.TreinoId).WillCascadeOnDelete(false);
        }
    }
}
