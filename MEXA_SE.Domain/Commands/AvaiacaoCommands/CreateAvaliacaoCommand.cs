using System;

namespace MEXA_SE.Domain.Commands.AvaiacaoCommands
{
    public class CreateAvaliacaoCommand
    {
        public CreateAvaliacaoCommand(int usuarioId, int fichaId, DateTime dtAvaliacao, DateTime reavaliacao)
        {
            this.UsuarioId = usuarioId;
            this.FichaId = fichaId;
            this.DtAvaliacao = dtAvaliacao;
            this.Reavaliacao = reavaliacao;
        }

        public int UsuarioId { get; set; }
        public int FichaId { get; set; }

        public DateTime DtAvaliacao { get; private set; }
        public DateTime Reavaliacao { get; private set; }
    }
}
