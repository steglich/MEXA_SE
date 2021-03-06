﻿using MEXA_SE.Domain.Entities;
using System;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Repositories
{
    public interface IUsuarioTreinoRepository
    {
        List<UsuarioTreino> GetAll();
        UsuarioTreino GetOne(string email);
        //Usuario GetUsuario(string email);
        void Create(UsuarioTreino usuarioTreino);
        void Update(UsuarioTreino usuarioTreino);
    }
}
