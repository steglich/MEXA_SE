using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public static class UsuarioTreinoSpecs
    {
        public static Expression<Func<UsuarioTreino, bool>> GetAll(int usuarioId, int treinoId, string email)
        {
            return x => x.Usuario.UsuarioId == usuarioId && x.Treino.TreinoId == treinoId && x.Usuario.Email.Equals(email);
        }
    }
}
