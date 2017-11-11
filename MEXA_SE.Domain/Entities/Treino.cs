using MEXA_SE.Domain.Scopes;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Entities
{
    public class Treino
    {
        public Treino(string dsTreino)
        {
            this.DsTreino = dsTreino;

            this.Exercicio = new List<Exercicio>();
            this.UsuarioTreino = new List<UsuarioTreino>();
        }

        public int TreinoId { get; set; }
        public string DsTreino { get; private set; }
        
        public virtual ICollection<Exercicio> Exercicio { get; set; }
        public virtual ICollection<UsuarioTreino> UsuarioTreino { get; set; }

        public void CreateTreino()
        {
            this.CreateTreinoScopIsValid();
        }
        public void UpdateTreino(string dsTreino)
        {
            if (!this.UpdateTreinoScopIsValid(dsTreino))
                return;

            this.DsTreino = DsTreino;
        }
    }
}
