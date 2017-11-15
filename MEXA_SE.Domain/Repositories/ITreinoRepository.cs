using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Repositories
{
    public interface ITreinoRepository
    {
        List<Treino> GetAll();
        Treino GetId(int treinoId);
        Treino GetOne(int treinoId, string email);
        Treino GetTreino(string treino);
        void Create(Treino treino);
        void Update(Treino treino);
    }
}
