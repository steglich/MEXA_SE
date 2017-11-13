using MEXA_SE.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MEXA_SE.Infra.Presistence.Map
{
    public class EvolucaoTreinoMap : EntityTypeConfiguration<EvolucaoTreino>
    {
        public EvolucaoTreinoMap()
        {
            ToTable("EvolucaoTreino");

            HasKey(x => x.EvolucaoTreinoId);

            Property(x => x.Repeticao).HasColumnType("int").IsRequired();
            Property(x => x.Carga).HasColumnType("int").IsRequired();
            Property(x => x.AumetoTreino).HasColumnType("smalldatetime").IsRequired();
            Property(x => x.ExercicioId).HasColumnName("FkExercicio").HasColumnType("int").IsRequired();

            HasRequired(x => x.Exercicio);
        }
    }
}
