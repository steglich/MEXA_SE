using MEXA_SE.Domain.Entities;
using MEXA_SE.SharedKernel.Validation;

namespace MEXA_SE.Domain.Scopes
{
    public static class AtividadeDiaScopes
    {
        public static bool CreateAtividadeDiaScopIsValid(this AtividadeDia atividadeDia)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertDateEqualToDate(atividadeDia.AtividadeConcluida, "A data deve ser mesma data de hoje!")
                );
        }

        //public static bool UpdateAtividadeDiaScopIsValid(this AtividadeDia atividadeDia, DateTime atividadeConcluida)
        //{
        //    return AssertionConcern.IsSatisfiedBy(
        //        AssertionConcern.AssertDateEqualToDate(atividadeConcluida, "A data deve ser mesma data de hoje!")
        //        );
        //}
    }
}
