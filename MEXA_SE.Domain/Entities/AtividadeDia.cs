using MEXA_SE.Domain.Scopes;
using System;

namespace MEXA_SE.Domain.Entities
{
    public class AtividadeDia
    {
        public AtividadeDia()
        {

        }
        public AtividadeDia(int usuarioId)
        {
            this.AtividadeConcluida = DateTime.Now;
            this.UsuarioId = usuarioId;
        }

        public int AtividadeDiaId { get; set; }
        public DateTime AtividadeConcluida { get; private set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public void CreateAtividadeDia()
        {
            this.CreateAtividadeDiaScopIsValid();
        }
    }
}
