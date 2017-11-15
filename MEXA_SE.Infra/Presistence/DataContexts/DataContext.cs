using MEXA_SE.Domain.Entities;
using System.Data.Entity;

namespace MEXA_SE.Infra.Presistence.DataContexts
{
    public class DataContext : DbContext
    {
        public DataContext() : base("MEXASE")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Ficha> Ficha { get; set; }
        public virtual DbSet<Treino> Treino { get; set; }
        public virtual DbSet<Exercicio> Exercicio { get; set; }
        public virtual DbSet<AtividadeDia> AtividadeDia { get; set; }
        public virtual DbSet<Avaliacao> Avaliacao { get; set; }
        public virtual DbSet<EvolucaoTreino> EvolucaoTreino { get; set; }
        public virtual DbSet<UsuarioTreino> UsuarioTreino { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(60).IsRequired();
            modelBuilder.Entity<Usuario>().Property(x => x.Email).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Usuario>().Property(x => x.IsAdmin).HasColumnType("bit").IsRequired();

            modelBuilder.Entity<AtividadeDia>().Property(x => x.AtividadeConcluida).HasColumnType("smalldatetime").IsRequired();

            modelBuilder.Entity<Avaliacao>().Property(x => x.DtAvaliacao).HasColumnType("smalldatetime").IsRequired();
            modelBuilder.Entity<Avaliacao>().Property(x => x.Reavaliacao).HasColumnType("smalldatetime").IsRequired();

            modelBuilder.Entity<Ficha>().Property(x => x.Peso).HasColumnType("float").IsRequired();
            modelBuilder.Entity<Ficha>().Property(x => x.Altura).HasColumnType("float").IsRequired();
            modelBuilder.Entity<Ficha>().Property(x => x.Imc).HasColumnType("float").IsRequired();
            modelBuilder.Entity<Ficha>().Property(x => x.Gordura).HasColumnType("float").IsRequired();
            modelBuilder.Entity<Ficha>().Property(x => x.Peito).HasColumnType("float").IsRequired();
            modelBuilder.Entity<Ficha>().Property(x => x.Cintura).HasColumnType("float").IsRequired();
            modelBuilder.Entity<Ficha>().Property(x => x.Quadril).HasColumnType("float").IsRequired();
            modelBuilder.Entity<Ficha>().Property(x => x.AnteBracoDireito).HasColumnType("float").IsRequired();
            modelBuilder.Entity<Ficha>().Property(x => x.AnteBracoEsquerdo).HasColumnType("float").IsRequired();
            modelBuilder.Entity<Ficha>().Property(x => x.BracoDireito).HasColumnType("float").IsRequired();
            modelBuilder.Entity<Ficha>().Property(x => x.BracoEsquerdo).HasColumnType("float").IsRequired();
            modelBuilder.Entity<Ficha>().Property(x => x.CoxaDireita).HasColumnType("float").IsRequired();
            modelBuilder.Entity<Ficha>().Property(x => x.CoxaEsquerda).HasColumnType("float").IsRequired();
            modelBuilder.Entity<Ficha>().Property(x => x.PantuDireita).HasColumnType("float").IsRequired();
            modelBuilder.Entity<Ficha>().Property(x => x.PantuEsquerda).HasColumnType("float").IsRequired();

            modelBuilder.Entity<UsuarioTreino>().Property(x => x.DtTreino).HasColumnType("smalldatetime").IsRequired();

            modelBuilder.Entity<Treino>().Property(x => x.DsTreino).HasColumnType("varchar").HasMaxLength(30).IsRequired();

            modelBuilder.Entity<Exercicio>().Property(x => x.DsExercicio).HasColumnType("varchar").HasMaxLength(30).IsRequired();

            modelBuilder.Entity<EvolucaoTreino>().Property(x => x.Repeticao).HasColumnType("int").IsRequired();
            modelBuilder.Entity<EvolucaoTreino>().Property(x => x.Carga).HasColumnType("int").IsRequired();
            modelBuilder.Entity<EvolucaoTreino>().Property(x => x.AumetoTreino).HasColumnType("smalldatetime").IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
