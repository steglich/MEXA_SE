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

        public static Expression<Func<Ficha, bool>> GetIdAvaliacao(int id)
        {
            return x => x.Avaliacao.AvaliacaoId == id;
        }

        public static Expression<Func<Ficha, bool>> GetIdFicha(int id)
        {
            return x => x.FichaId == id;
        }
    }
}
