using System;

namespace MEXA_SE.Domain.Commands.AtividadeDiacommands
{
    public class CreateAtividadeDiaCommand
    {
        public CreateAtividadeDiaCommand(int usuarioId)
        {
            //this.AtividadeConcluida = atividadeConcluida;
            this.UsuarioId = usuarioId;
        }

        //public DateTime AtividadeConcluida { get; set; }
        public int UsuarioId { get; set; }
    }
}
