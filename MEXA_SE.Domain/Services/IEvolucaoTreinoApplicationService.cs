using MEXA_SE.Domain.Commands.EvolucaoTreinoCommands;
using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Services
{
    public interface IEvolucaoTreinoApplicationService
    {
        List<EvolucaoTreino> Get();
        EvolucaoTreino GetOne(int evolucaoTreinoId, int exercicioid);
        void Create(CreateEvolucaoTreinoCommand command);
        void Update(UpdateEvolucaoTreinoCommand command);
    }
}
