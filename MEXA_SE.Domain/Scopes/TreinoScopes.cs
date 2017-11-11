using MEXA_SE.Domain.Entities;
using MEXA_SE.SharedKernel.Validation;

namespace MEXA_SE.Domain.Scopes
{
    public static class TreinoScopes
    {
        public static bool CreateTreinoScopIsValid(this Treino treino)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(treino.DsTreino, "O campo treino é Obrigatório!")
                );
        }
        public static bool UpdateTreinoScopIsValid(this Treino treino, string dsTreino)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(dsTreino, "O campo treino é Obrigatório!")
                );
        }
    }
}
