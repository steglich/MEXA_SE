using System;

namespace MEXA_SE.Domain.Commands.AvaiacaoCommands
{
    public class CreateAvaliacaoCommand
    {
        public CreateAvaliacaoCommand(DateTime reavaliacao, int usuarioId)
        {
            //this.DtAvaliacao = dtAvaliacao;
            this.Reavaliacao = reavaliacao;
            this.UsuarioId = usuarioId;
        }

        //public DateTime DtAvaliacao { get; private set; }
        public DateTime Reavaliacao { get; private set; }

        public int UsuarioId { get; set; }
    }
}
