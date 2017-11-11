using MEXA_SE.Domain.Entities;
using MEXA_SE.SharedKernel.Validation;

namespace MEXA_SE.Domain.Scopes
{
    public static class UsuarioTreinoScopes
    {
        public static bool CreateUsuarioTreinoScopIsValid(this UsuarioTreino usuarioTreino)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertDateEqualToDate(usuarioTreino.DtTreino, "A data deve ser mesma data de hoje!")
                );
        }

        //public static bool UpdateUsuarioTreinoScopIsValid(this UsuarioTreino usuarioTreino, DateTime dtTreino)
        //{
        //    return AssertionConcern.IsSatisfiedBy(
        //        AssertionConcern.AssertDateEqualToDate(dtTreino, "A data deve ser mesma data de hoje!")
        //        );
        //}
    }
}
