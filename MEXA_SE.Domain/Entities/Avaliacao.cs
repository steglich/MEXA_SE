using MEXA_SE.Domain.Scopes;
using System;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Entities
{
    public class Avaliacao
    {
        public Avaliacao()
        {

        }
        public Avaliacao(DateTime reavaliacao, int usuarioId)
        {
            //this.FichaId = fichaId;
            this.DtAvaliacao = DateTime.Now;
            this.Reavaliacao = reavaliacao;
            this.UsuarioId = usuarioId;

            this.Ficha = new List<Ficha>();
        }
                
        public int AvaliacaoId { get; set; }   
        
        public DateTime DtAvaliacao { get; private set; }
        public DateTime Reavaliacao { get; private set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Ficha> Ficha { get; set; }

        public void CreateAvaliacao()
        {
            this.CreateAvaliacaoScopIsValid();
        }
        public void UpdateAvaliacao(DateTime reavaliacao)
        {
            if (!this.UpdateAvaliacaoScopIsValid(reavaliacao))
                return;
            
            this.Reavaliacao = reavaliacao;
        }
    }
}
