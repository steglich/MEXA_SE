using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public class AtividadeDiaSpecs
    {
        public static Expression<Func<AtividadeDia, bool>> GetAllDias(int atividadeDiaId, string email)
        {
            return x => x.AtividadeDiaId == atividadeDiaId && x.Usuario.Email.Equals(email);
        }
    }
}
