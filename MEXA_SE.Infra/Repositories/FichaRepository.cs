using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Specs;
using MEXA_SE.Infra.Presistence.DataContexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MEXA_SE.Infra.Repositories
{
    public class FichaRepository : IFichaRepository
    {
        private DataContext _context;

        public FichaRepository(DataContext context)
        {
            this._context = context;
        }

        public void Create(Ficha ficha)
        {
            _context.Ficha.Add(ficha);
        }

        public List<Ficha> GetAll()
        {
            return _context.Ficha.ToList();
        }

        public Ficha GetId(int fichaId)
        {
            return _context.Ficha.Find(fichaId);
        }

        public Ficha GetOne(string email)
        {
            return _context.Ficha.OrderByDescending(x => x.Avaliacao.DtAvaliacao).FirstOrDefault(FichaSpecs.GetAll(email));
        }

        public void Update(Ficha ficha)
        {
            _context.Entry<Ficha>(ficha).State = EntityState.Modified;
        }
    }
}
