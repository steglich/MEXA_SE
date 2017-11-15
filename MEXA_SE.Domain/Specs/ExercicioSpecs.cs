using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public static class ExercicioSpecs
    {
        public static Expression<Func<Exercicio, bool>> GetAll(int exercicioId, string email)
        {
            return x => x.ExercicioId == exercicioId && x.Treino.UsuarioTreino.Usuario.Email == email;
        }
    }
}
