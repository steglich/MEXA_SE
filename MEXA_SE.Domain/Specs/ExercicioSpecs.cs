using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public static class ExercicioSpecs
    {
        public static Expression<Func<Exercicio, bool>> GetAll(int exercicioId, int treinoId)
        {
            return x => x.ExercicioId == exercicioId && x.Treino.TreinoId == treinoId;
        }
    }
}
