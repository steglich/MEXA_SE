using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Specs;
using MEXA_SE.Infra.Presistence.DataContexts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MEXA_SE.Infra.Repositories
{
    public class TreinoRepository : ITreinoRepository
    {
        private DataContext _context;

        public TreinoRepository(DataContext context)
        {
            this._context = context;
        }

        public void Create(Treino treino)
        {
            _context.Treino.Add(treino);
        }

        public List<Treino> GetAll()
        {
            return _context.Treino.ToList();
        }

        public Treino GetId(int treinoId)
        {
            return _context.Treino.Find(treinoId);
        }

        public Treino GetOne(string email)
        {
            return _context.Treino.OrderByDescending(x => x.UsuarioTreino.DtTreino).FirstOrDefault(TreinoSpecs.GetAll(email));
        }

        public Treino GetTreino(string treino)
        {
            return _context.Treino.Find(treino);
        }

        public void Update(Treino treino)
        {
            _context.Entry<Treino>(treino).State = EntityState.Modified;
        }
    }
}
