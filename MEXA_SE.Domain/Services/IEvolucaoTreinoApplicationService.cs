using MEXA_SE.Domain.Commands.EvolucaoTreinoCommands;
using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Services
{
    public interface IEvolucaoTreinoApplicationService
    {
        List<EvolucaoTreino> GetAll();
        EvolucaoTreino GetOne(int evolucaoTreinoId, string email);
        EvolucaoTreino Create(CreateEvolucaoTreinoCommand command);
        EvolucaoTreino Update(UpdateEvolucaoTreinoCommand command);
    }
}
