using MEXA_SE.Domain.Scopes;
using System;

namespace MEXA_SE.Domain.Entities
{
    public class UsuarioTreino
    {
        public UsuarioTreino(int usuarioId, int treinoId, DateTime dtTreino)
        {
            this.UsuarioId = usuarioId;
            this.TreinoId = treinoId;
            this.DtTreino = dtTreino;
        }
        
        public int UsuarioId { get; set; }        
        public int TreinoId { get; set; }
        public DateTime DtTreino { get; private set; }

        public virtual Treino Treino { get; set; }
        public virtual Usuario Usuario { get; set; }

        public void CreateUsuarioTreino()
        {
            this.CreateUsuarioTreinoScopIsValid();
        }
        //public void UpdateUsuarioTreino(DateTime dtTreino)
        //{
        //    if (!this.UpdateUsuarioTreinoScopIsValid(dtTreino))
        //        return;

        //    this.DtTreino = dtTreino;
        //}
    }
}
