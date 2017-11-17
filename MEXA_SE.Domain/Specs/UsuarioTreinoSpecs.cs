using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public static class UsuarioTreinoSpecs
    {
        public static Expression<Func<UsuarioTreino, bool>> GetAll(string email)
        {
            return x => x.Usuario.Email.Equals(email);
        }
    }
}
