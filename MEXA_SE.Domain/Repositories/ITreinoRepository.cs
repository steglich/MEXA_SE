using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Repositories
{
    public interface ITreinoRepository
    {
        List<Treino> Get();
        Treino GetOne(int treinoId);
        Treino GetTreino(string treino);
        void Create(Treino treino);
        void Update(Treino treino);
    }
}
