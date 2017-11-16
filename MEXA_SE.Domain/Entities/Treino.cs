using MEXA_SE.Domain.Scopes;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Entities
{
    public class Treino
    {
        public Treino()
        {

        }
        public Treino(string dsTreino, int usuarioTreinoId)
        {
            this.DsTreino = dsTreino;
            this.UsuarioTreinoId = usuarioTreinoId;

            this.Exercicio = new List<Exercicio>();
            //this.UsuarioTreino = new List<UsuarioTreino>();
        }

        public int TreinoId { get; set; }
        public string DsTreino { get; private set; }

        public int UsuarioTreinoId { get; set; }
        public virtual UsuarioTreino UsuarioTreino { get; set; }

        public virtual ICollection<Exercicio> Exercicio { get; set; }

        public void CreateTreino()
        {
            this.CreateTreinoScopIsValid();
        }
        public void UpdateTreino(string dsTreino)
        {
            if (!this.UpdateTreinoScopIsValid(dsTreino))
                return;

            this.DsTreino = dsTreino;
        }
    }
}
