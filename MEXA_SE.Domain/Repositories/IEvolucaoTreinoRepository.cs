using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Repositories
{
    public interface IEvolucaoTreinoRepository
    {
        List<EvolucaoTreino> GetAll();
        EvolucaoTreino GetOne(int evolucaoTreinoId, int exercicioid);
        void Create(EvolucaoTreino evolucaoTreino);
        void Update(EvolucaoTreino evolucaoTreino);
    }
}
