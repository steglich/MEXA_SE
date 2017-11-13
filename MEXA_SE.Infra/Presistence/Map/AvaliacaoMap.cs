using MEXA_SE.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MEXA_SE.Infra.Presistence.Map
{
    public class AvaliacaoMap : EntityTypeConfiguration<Avaliacao>
    {
        public AvaliacaoMap()
        {
            ToTable("Avaliacao");

            HasKey(x => new { x.UsuarioId, x.FichaId });

            Property(x => x.UsuarioId).HasColumnName("PfkUsuario").HasColumnType("int").IsRequired();
            Property(x => x.FichaId).HasColumnName("PfkFicha").HasColumnType("int").IsRequired();
            Property(x => x.DtAvaliacao).HasColumnType("smalldatetime").IsRequired();
            Property(x => x.Reavaliacao).HasColumnType("smalldatetime").IsRequired();

            //HasRequired(a => a.Usuario).WithMany(b => b.Avaliacao).HasForeignKey(c => c.UsuarioId);
            //HasRequired(a => a.Ficha).WithMany(b => b.Avaliacao).HasForeignKey(c => c.FichaId);
        }
    }
}
