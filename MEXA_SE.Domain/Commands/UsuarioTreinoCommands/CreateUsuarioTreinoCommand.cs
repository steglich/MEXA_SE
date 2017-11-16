using System;

namespace MEXA_SE.Domain.Commands.UsuarioTreinoCommands
{
    public class CreateUsuarioTreinoCommand
    {
        public CreateUsuarioTreinoCommand(int usuarioId)
        {
            //this.DtTreino = dtTreino;
            this.UsuarioId = usuarioId;
        }


        //public DateTime DtTreino { get; private set; }
        public int UsuarioId { get; set; }
    }
}
