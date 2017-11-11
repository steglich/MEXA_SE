using MEXA_SE.Domain.Scopes;
using System;

namespace MEXA_SE.Domain.Entities
{
    public class AtividadeDia
    {
        public AtividadeDia(int usuarioId, DateTime atividadeConcluida)
        {
            this.UsuarioId = usuarioId;
            this.AtividadeConcluida = atividadeConcluida;
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
