using MEXA_SE.Domain.Entities;
using MEXA_SE.SharedKernel.Helpers;
using System;
using System.Linq.Expressions;

namespace MEXA_SE.Domain.Specs
{
    public static class UsuarioSpecs
    {
        public static Expression<Func<Usuario, bool>> AuthenticateUsuario(string email, string senha)
        {
            string encriptedSenha = StringHelper.Encrypt(senha);
            return x => x.Email.Equals(email) && x.Senha.Equals(encriptedSenha);
            //return x => x.Email == email && x.Senha == encriptedSenha;
        }

        public static Expression<Func<Usuario, bool>> GetByEmail(string email)
        {
            return x => x.Email == email;
        }
    }
}
