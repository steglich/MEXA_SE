using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Specs;
using MEXA_SE.Infra.Presistence.DataContexts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MEXA_SE.Infra.Repositories
{
    public class UsuarioTreinoRepository : IUsuarioTreinoRepository
    {
        private DataContext _context;

        public UsuarioTreinoRepository(DataContext context)
        {
            this._context = context;
        }

        public void Create(UsuarioTreino usuarioTreino)
        {
            _context.UsuarioTreino.Add(usuarioTreino);
        }

        public List<UsuarioTreino> GetAll()
        {
            return _context.UsuarioTreino.ToList();
        }

        public UsuarioTreino GetOne(int usuarioTreinoId, string email)
        {
            return _context.UsuarioTreino.Where(UsuarioTreinoSpecs.GetAll(usuarioTreinoId, email)).FirstOrDefault();
        }

        public void Update(UsuarioTreino usuarioTreino)
        {
            _context.Entry<UsuarioTreino>(usuarioTreino).State = EntityState.Modified;
        }
    }
}
