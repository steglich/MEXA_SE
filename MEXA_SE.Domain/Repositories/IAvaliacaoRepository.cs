using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Repositories
{
    public interface IAvaliacaoRepository
    {
        List<Avaliacao> GetAll();
        Avaliacao GetOne(int usuarioId, int fichaId, string email);
        void Create(Avaliacao avaliacao);
        void Update(Avaliacao avaliacao);
    }
}
