using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public static class FichaSpecs
    {
        public static Expression<Func<Ficha, bool>> GetAll(string email)
        {
            return x => x.Avaliacao.Usuario.Email == email;
        }
    }
}
