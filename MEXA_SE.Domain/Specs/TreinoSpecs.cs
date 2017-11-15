using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public static class TreinoSpecs
    {
        public static Expression<Func<Treino, bool>> GetAll(int treinoId, string email)
        {
            return x => x.TreinoId == treinoId && x.UsuarioTreino.Usuario.Email == email;
        }
    }
}
