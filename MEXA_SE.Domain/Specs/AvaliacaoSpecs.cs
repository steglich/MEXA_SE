﻿using MEXA_SE.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public static class AvaliacaoSpecs
    {
        public static Expression<Func<Avaliacao, bool>> GetAllDias(int usuarioId, int fichaId, string email)
        {
            return x => x.Usuario.UsuarioId == usuarioId && x.Ficha.FichaId == fichaId && x.Usuario.Email.Equals(email);
            //return x => x.AtividadeDiaId.Equals(id) && x.Usuario.Email.Equals(email);
        }
    }
}