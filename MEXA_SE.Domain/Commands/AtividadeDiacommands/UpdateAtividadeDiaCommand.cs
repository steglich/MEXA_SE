using System;

namespace MEXA_SE.Domain.Commands.AtividadeDiacommands
{
    public class UpdateAtividadeDiaCommand
    {
        public UpdateAtividadeDiaCommand(int atividadeDiaId, int usuarioId, DateTime atividadeConcluida)
        {
            this.AtividadeDiaId = atividadeDiaId;
            this.UsuarioId = usuarioId;
            this.AtividadeConcluida = atividadeConcluida;
        }

        public int AtividadeDiaId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime AtividadeConcluida { get; set; }

    }
}
