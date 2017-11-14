using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Specs;
using MEXA_SE.Infra.Presistence.DataContexts;
using System.Data.Entity;
using System.Linq;

namespace MEXA_SE.Infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private DataContext _context;

        public UsuarioRepository(DataContext context)
        {
            this._context = context;
        }

        public void Create(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
        }

        public Usuario GetAuthenticateUsuario(string email, string senha)
        {
            return _context.Usuario.Where(UsuarioSpecs.AuthenticateUsuario(email, senha)).FirstOrDefault();
        }

        public Usuario GetByEmail(string email)
        {
            return _context.Usuario.Where(UsuarioSpecs.GetByEmail(email)).FirstOrDefault();
        }

        public Usuario GetOne(int id)
        {
            return _context.Usuario.Find(id);
        }

        public void Update(Usuario usuario)
        {
            _context.Entry<Usuario>(usuario).State = EntityState.Modified;
        }
    }
}
