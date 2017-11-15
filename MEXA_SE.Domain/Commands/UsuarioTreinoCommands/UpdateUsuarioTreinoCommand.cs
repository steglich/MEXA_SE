using System;

namespace MEXA_SE.Domain.Commands.UsuarioTreinoCommands
{
    public class UpdateUsuarioTreinoCommand
    {
        public UpdateUsuarioTreinoCommand(int usuarioTreinoId, DateTime dtTreino, int usuarioId)
        {
            this.UsuarioTreinoId = usuarioTreinoId;
            this.DtTreino = dtTreino;
            this.UsuarioId = usuarioId;
        }
        
        public int UsuarioTreinoId { get; set; }
        public DateTime DtTreino { get; private set; }

        public int UsuarioId { get; set; }
    }
}
