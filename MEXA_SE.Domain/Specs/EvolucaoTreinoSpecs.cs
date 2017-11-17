﻿using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public static class EvolucaoTreinoSpecs
    {
        public static Expression<Func<EvolucaoTreino, bool>> GetAll(string email)
        {
            return x => x.Exercicio.Treino.UsuarioTreino.Usuario.Email == email;
        }
    }
}
