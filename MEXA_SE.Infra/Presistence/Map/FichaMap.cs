using MEXA_SE.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MEXA_SE.Infra.Presistence.Map
{
    public class FichaMap : EntityTypeConfiguration<Ficha>
    {
        public FichaMap()
        {
            ToTable("Ficha");

            HasKey(x => x.FichaId);

            Property(x => x.Peso).HasColumnType("float").IsRequired();
            Property(x => x.Altura).HasColumnType("float").IsRequired();
            Property(x => x.Imc).HasColumnType("float").IsRequired();
            Property(x => x.Gordura).HasColumnType("float").IsRequired();
            Property(x => x.Peito).HasColumnType("float").IsRequired();
            Property(x => x.Cintura).HasColumnType("float").IsRequired();
            Property(x => x.Quadril).HasColumnType("float").IsRequired();
            Property(x => x.AnteBracoDireito).HasColumnType("float").IsRequired();
            Property(x => x.AnteBracoEsquerdo).HasColumnType("float").IsRequired();
            Property(x => x.BracoDireito).HasColumnType("float").IsRequired();
            Property(x => x.BracoEsquerdo).HasColumnType("float").IsRequired();
            Property(x => x.CoxaDireita).HasColumnType("float").IsRequired();
            Property(x => x.CoxaEsquerda).HasColumnType("float").IsRequired();
            Property(x => x.PantuDireita).HasColumnType("float").IsRequired();
            Property(x => x.PantuEsquerda).HasColumnType("float").IsRequired();

            HasMany(e => e.Avaliacao).WithRequired(e => e.Ficha).HasForeignKey(e => e.FichaId).WillCascadeOnDelete(false);
        }
    }
}
