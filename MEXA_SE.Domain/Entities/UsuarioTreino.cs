using MEXA_SE.Domain.Scopes;
using System;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Entities
{
    public class UsuarioTreino
    {
        public UsuarioTreino()
        {

        }
        public UsuarioTreino(int usuarioId)
        {
            this.DtTreino = DateTime.Now.Date;
            this.UsuarioId = usuarioId;
            //this.TreinoId = treinoId;

            this.Treino = new List<Treino>();
        }
               
        public int UsuarioTreinoId { get; set; }
        public DateTime DtTreino { get; private set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<Treino> Treino { get; set; }

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
