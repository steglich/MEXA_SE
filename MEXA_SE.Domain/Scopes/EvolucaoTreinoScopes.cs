using MEXA_SE.Domain.Entities;
using MEXA_SE.SharedKernel.Validation;
using System;

namespace MEXA_SE.Domain.Scopes
{
    public static class EvolucaoTreinoScopes
    {
        public static bool CreateEvolucaoTreinoScopIsValid(this EvolucaoTreino evolucaoTreino)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(evolucaoTreino.Repeticao.ToString(), "O campo repetição é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(evolucaoTreino.Repeticao, 0, "O campo carga deve ser maior que 0!"),
                AssertionConcern.AssertNotEmpty(evolucaoTreino.Carga.ToString(), "O campo carga é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(evolucaoTreino.Carga, 0, "O campo carga deve ser maior que 0!"),
                AssertionConcern.AssertNotEmpty(evolucaoTreino.AumetoTreino.ToString(), "O campo reavaliação é Obrigatório!"),
                AssertionConcern.AssertLessThanDateEvolucao(evolucaoTreino.AumetoTreino, "Data invalida!")
                );
        }

        public static bool UpdateEvolucaoTreinoScopIsValid(this EvolucaoTreino evolucaoTreino, int repeticao, int carga)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(repeticao.ToString(), "O campo repetição é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(repeticao, 0, "O campo carga deve ser maior que 0!"),
                AssertionConcern.AssertNotEmpty(carga.ToString(), "O campo carga é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(carga, 0, "O campo carga deve ser maior que 0!")
                //AssertionConcern.AssertNotEmpty(aumentoTreino.ToString(), "O campo reavaliação é Obrigatório!"),
                //AssertionConcern.AssertLessThanDateEvolucao(aumentoTreino, "Data invalida!")
                );
        }
    }
}
