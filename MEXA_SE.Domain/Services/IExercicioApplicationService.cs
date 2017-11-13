using MEXA_SE.Domain.Commands.ExercicioCommands;
using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Services
{
    public interface IExercicioApplicationService
    {
        List<Exercicio> Get();
        Exercicio GetOne(int exercicioId, int treinoId);
        Exercicio GetExercicio(string exercicio);
        void Create(CreateExercicioCommand command);
        void Update(UpdateExercicioCommand command);
    }
}
