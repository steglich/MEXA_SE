using System;

namespace MEXA_SE.Domain.Commands.AvaiacaoCommands
{
    public class UpdateAvaliacaoCommand
    {
        public UpdateAvaliacaoCommand(int avaliacaoId, DateTime reavaliacao)
        {
            this.AvaliacaoId = avaliacaoId;
            //this.DtAvaliacao = dtAvaliacao;
            this.Reavaliacao = reavaliacao;
            //this.UsarioId = UsarioId;
        }

        public int AvaliacaoId { get; set; }

        //public DateTime DtAvaliacao { get; private set; }
        public DateTime Reavaliacao { get; private set; }

        //public int UsarioId { get; set; }
    }
}
