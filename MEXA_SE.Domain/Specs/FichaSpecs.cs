using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public static class FichaSpecs
    {
        public static Expression<Func<Ficha, bool>> GetAll(int fichaId)
        {
            return x => x.FichaId == fichaId;
        }
    }
}
