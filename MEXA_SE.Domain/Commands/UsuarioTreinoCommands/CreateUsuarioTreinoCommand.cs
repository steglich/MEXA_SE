using System;

namespace MEXA_SE.Domain.Commands.UsuarioTreinoCommands
{
    public class CreateUsuarioTreinoCommand
    {
        public CreateUsuarioTreinoCommand(DateTime dtTreino, int usuarioId, int treinoId)
        {
            this.DtTreino = dtTreino;
            this.UsuarioId = usuarioId;
            this.TreinoId = treinoId;
        }


        public DateTime DtTreino { get; private set; }
        public int UsuarioId { get; set; }
        public int TreinoId { get; set; }
    }
}
