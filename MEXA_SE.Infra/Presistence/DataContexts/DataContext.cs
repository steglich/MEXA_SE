using MEXA_SE.Domain.Entities;
using MEXA_SE.Infra.Presistence.Map;
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
        public virtual DbSet<AtividadeDia> AtividadeDia { get; set; }
        public virtual DbSet<Avaliacao> Avaliacao { get; set; }
        public virtual DbSet<EvolucaoTreino> EvolucaoTreino { get; set; }
        public virtual DbSet<Exercicio> Exercicio { get; set; }
        public virtual DbSet<Ficha> Ficha { get; set; }
        public virtual DbSet<Treino> Treino { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioTreino> UsuarioTreino { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*Toda propriedade do tipo string na entidade POCO
            seja configurado como VARCHAR no SQL Server*/
            //modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new AtividadeDiaMap());
            modelBuilder.Configurations.Add(new FichaMap());
            modelBuilder.Configurations.Add(new TreinoMap());
            modelBuilder.Configurations.Add(new ExercicioMap());
            modelBuilder.Configurations.Add(new AvaliacaoMap());
            modelBuilder.Configurations.Add(new UsuarioTreinoMap());
            modelBuilder.Configurations.Add(new EvolucaoTreinoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
