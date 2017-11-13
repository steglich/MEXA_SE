using MEXA_SE.Domain.Commands.TreinoCommands;
using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Services
{
    public interface ITreinoApplicationService
    {
        List<Treino> Get();
        Treino GetOne(int treinoId);
        Treino GetTreino(string treino);
        void Create(CreateTreinoCommand command);
        void Update(UpdateTreinoCommand command);
    }
}
