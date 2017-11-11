using System;

namespace MEXA_SE.Domain.Commands.UsuarioTreinoCommands
{
    public class UpdateUsuarioTreinoCommand
    {
        public UpdateUsuarioTreinoCommand(int usuarioId, int treinoId, DateTime dtTreino)
        {
            this.UsuarioId = usuarioId;
            this.TreinoId = treinoId;
            this.DtTreino = dtTreino;
        }
        
        public int UsuarioId { get; set; }
        public int TreinoId { get; set; }
        public DateTime DtTreino { get; private set; }
    }
}
