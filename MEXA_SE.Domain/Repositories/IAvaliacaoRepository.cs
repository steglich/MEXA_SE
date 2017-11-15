using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Repositories
{
    public interface IAvaliacaoRepository
    {
        List<Avaliacao> GetAll();
        Avaliacao GetId(int avaliacaoId);
        Avaliacao GetOne(int avaliacaoId, string email);
        void Create(Avaliacao avaliacao);
        void Update(Avaliacao avaliacao);
    }
}
