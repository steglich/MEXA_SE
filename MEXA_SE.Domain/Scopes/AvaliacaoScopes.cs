using MEXA_SE.Domain.Entities;
using MEXA_SE.SharedKernel.Validation;
using System;

namespace MEXA_SE.Domain.Scopes
{
    public static class AvaliacaoScopes
    {
        public static bool CreateAvaliacaoScopIsValid(this Avaliacao avaliacao)
        {
            return AssertionConcern.IsSatisfiedBy(
                //AssertionConcern.AssertNotEmpty(avaliacao.DtAvaliacao.ToString(), "O campo reavaliação é Obrigatório!"),
                //AssertionConcern.AssertDateEqualToDate(avaliacao.DtAvaliacao, "Data avaliação inválida!"),
                AssertionConcern.AssertNotEmpty(avaliacao.Reavaliacao.ToString(), "O campo reavaliação é Obrigatório!"),
                AssertionConcern.AssertLessThanDate(avaliacao.Reavaliacao, "Data reavaliação invalida!")
                );
        }
        
        public static bool UpdateAvaliacaoScopIsValid(this Avaliacao avaliacao, DateTime reavaliacao)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(reavaliacao.ToString(), "O campo reavaliação é Obrigatório!"),
                AssertionConcern.AssertLessThanDate(reavaliacao, "Data invalida!")
                );
        }
    }
}
