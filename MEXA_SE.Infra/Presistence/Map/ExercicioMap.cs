using MEXA_SE.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MEXA_SE.Infra.Presistence.Map
{
    public class ExercicioMap : EntityTypeConfiguration<Exercicio>
    {
        public ExercicioMap()
        {
            ToTable("Exercicio");

            HasKey(x => x.ExercicioId);

            Property(x => x.DsExercicio).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            Property(x => x.TreinoId).HasColumnName("FkExercicio").HasColumnType("int").IsRequired();

            HasRequired(x => x.Treino);

            HasMany(e => e.EvolucaoTreino).WithRequired(e => e.Exercicio).HasForeignKey(e => e.ExercicioId).WillCascadeOnDelete(false);
        }
    }
}
