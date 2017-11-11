using System;

namespace MEXA_SE.Domain.Commands.AtividadeDiacommands
{
    public class CreateAtividadeDiaCommand
    {
        public CreateAtividadeDiaCommand(int usuarioId, DateTime atividadeConcluida)
        {
            this.UsuarioId = usuarioId;
            this.AtividadeConcluida = atividadeConcluida;
        }

        public DateTime AtividadeConcluida { get; set; }
        public int UsuarioId { get; set; }
    }
}
