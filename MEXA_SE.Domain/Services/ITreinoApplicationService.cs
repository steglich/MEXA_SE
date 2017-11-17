using MEXA_SE.Domain.Commands.TreinoCommands;
using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Services
{
    public interface ITreinoApplicationService
    {
        List<Treino> GetAll();
        Treino GetOne(string email);
        Treino GetTreino(string treino);
        Treino Create(CreateTreinoCommand command);
        Treino Update(UpdateTreinoCommand command);
    }
}
