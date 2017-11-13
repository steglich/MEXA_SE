﻿using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public static class TreinoSpecs
    {
        public static Expression<Func<Treino, bool>> GetAll(int treinoId)
        {
            return x => x.TreinoId == treinoId;
        }
    }
}