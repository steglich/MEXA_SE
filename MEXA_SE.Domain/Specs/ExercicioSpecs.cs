using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public static class ExercicioSpecs
    {
        public static Expression<Func<Exercicio, bool>> GetByEmail(string email)
        {
            return x => x.Treino.UsuarioTreino.Usuario.Email == email;
        }
        public static Expression<Func<Exercicio, bool>> GetByExercicio(string email, string exercicio)
        {
            return x => x.Treino.UsuarioTreino.Usuario.Email == email && x.DsExercicio.Equals(exercicio);
        }
        public static Expression<Func<Exercicio, bool>> GetAll(string email, string treino)
        {
            return x => x.Treino.UsuarioTreino.Usuario.Email == email && x.Treino.DsTreino.Equals(treino);
        }
    }
}
