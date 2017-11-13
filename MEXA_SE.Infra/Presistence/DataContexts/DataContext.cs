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
        public virtual DbSet<AtividadeDia> AtividadeDia { get; set; }
        public virtual DbSet<Avaliacao> Avaliacao { get; set; }
        public virtual DbSet<EvolucaoTreino> EvolucaoTreino { get; set; }
        public virtual DbSet<Exercicio> Exercicio { get; set; }
        public virtual DbSet<Ficha> Ficha { get; set; }
        public virtual DbSet<Treino> Treino { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioTreino> UsuarioTreino { get; set; }
    }
}
