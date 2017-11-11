using MEXA_SE.Domain.Scopes;
using System;

namespace MEXA_SE.Domain.Entities
{
    public class Avaliacao
    {
        public Avaliacao(int usuarioId, int fichaId, DateTime dtAvaliacao, DateTime reavaliacao)
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

        public virtual Usuario Usuario { get; set; }
        public virtual Ficha Ficha { get; set; }

        public void CreateAvaliacao()
        {
            this.CreateAvaliacaoScopIsValid();
        }
        public void UpdateAvaliacao(DateTime dtAvaliacao, DateTime reavaliacao)
        {
            if (!this.UpdateAvaliacaoScopIsValid(dtAvaliacao, reavaliacao))
                return;

            this.DtAvaliacao = dtAvaliacao;
            this.Reavaliacao = reavaliacao;
        }
    }
}
