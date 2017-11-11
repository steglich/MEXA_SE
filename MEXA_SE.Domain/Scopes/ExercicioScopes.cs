using MEXA_SE.Domain.Entities;
using MEXA_SE.SharedKernel.Validation;

namespace MEXA_SE.Domain.Scopes
{
    public static class ExercicioScopes
    {
        public static bool CreateExrecicioScopIsValid(this Exercicio exercicio)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(exercicio.DsExercicio, "O campo exercício é Obrigatório!")
                );
        }
        public static bool UpdateExrecicioScopIsValid(this Exercicio exercicio, string dsExercicio)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(dsExercicio, "O campo exercício é Obrigatório!")
                );
        }
    }
}
