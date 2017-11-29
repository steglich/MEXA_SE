using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public static class TreinoSpecs
    {
        public static Expression<Func<Treino, bool>> GetByEmail(string email)
        {
            return x => x.UsuarioTreino.Usuario.Email.Equals(email);
        }
        public static Expression<Func<Treino, bool>> GetByTreino(string email, string dsTreino)
        {
            return x => x.UsuarioTreino.Usuario.Email.Equals(email) && x.DsTreino.Equals(dsTreino);
        }
    }
}
