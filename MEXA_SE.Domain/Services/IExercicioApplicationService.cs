using MEXA_SE.Domain.Commands.ExercicioCommands;
using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Services
{
    public interface IExercicioApplicationService
    {
        List<Exercicio> GetAll();
        Exercicio GetOne(string email);
        Exercicio GetExercicio(string exercicio);
        Treino GetUsuario(string email);
        Exercicio Create(CreateExercicioCommand command);
        Exercicio Update(UpdateExercicioCommand command);
    }
}
