using MEXA_SE.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MEXA_SE.Infra.Presistence.Map
{
    public class AtividadeDiaMap : EntityTypeConfiguration<AtividadeDia>
    {
        public AtividadeDiaMap()
        {
            ToTable("AtividadeDia");

            HasKey(x => x.AtividadeDiaId);

            Property(x => x.AtividadeConcluida).HasColumnType("smalldatetime").IsRequired();
            Property(x => x.UsuarioId).HasColumnName("FkUsuario").HasColumnType("int").IsRequired();

            HasRequired(x => x.Usuario);
        }
    }
}
