using MEXA_SE.Domain.Commands.ExercicioCommands;
using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Services
{
    public interface IExercicioApplicationService
    {
        List<Exercicio> GetAll();
        Exercicio GetByEmail(string email);
        Exercicio GetByExercicio(string email, string exercicio);
        Exercicio GetExercicio(string exercicio);
        Treino GetUsuario(string email, string treino);
        Exercicio Create(CreateExercicioCommand command);
        Exercicio Update(UpdateExercicioCommand command);
    }
}
