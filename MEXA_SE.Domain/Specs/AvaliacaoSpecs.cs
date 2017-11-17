using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public static class AvaliacaoSpecs
    {
        public static Expression<Func<Avaliacao, bool>> GetAll( string email)
        {
            return x => x.Usuario.Email == email;
        }
    }
}
