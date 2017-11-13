using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public class AtividadeDiaSpecs
    {
        public static Expression<Func<AtividadeDia, bool>> GetAllDias(int id, string email)
        {
            return x => x.AtividadeDiaId == id && x.Usuario.Email.Equals(email);
            //return x => x.AtividadeDiaId.Equals(id) && x.Usuario.Email.Equals(email);
        }
    }
}
