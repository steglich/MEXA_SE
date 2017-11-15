using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public static class UsuarioTreinoSpecs
    {
        public static Expression<Func<UsuarioTreino, bool>> GetAll(int usuarioTreinoId, string email)
        {
            return x => x.UsuarioTreinoId == usuarioTreinoId && x.Usuario.Email.Equals(email);
        }
    }
}
