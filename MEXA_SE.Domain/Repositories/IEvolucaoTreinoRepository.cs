using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Repositories
{
    public interface IEvolucaoTreinoRepository
    {
        List<EvolucaoTreino> GetAll(string email, string exercicio);
        EvolucaoTreino GetId(int evolucaoTreinoId);
        EvolucaoTreino GetOne(string email, string exercicio);
        Exercicio GetUsuario(string email);
        void Create(EvolucaoTreino evolucaoTreino);
        void Update(EvolucaoTreino evolucaoTreino);
    }
}
