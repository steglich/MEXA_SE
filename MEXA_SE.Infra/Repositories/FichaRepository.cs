using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
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

        public List<Ficha> Get()
        {
            return _context.Ficha.ToList();
        }

        public Ficha GetOne(int id)
        {
            return _context.Ficha.Find(id);
        }

        public List<Ficha> GetUsuario(string email)
        {
            throw new NotImplementedException();
        }

        public void Update(Ficha ficha)
        {
            _context.Entry<Ficha>(ficha).State = EntityState.Modified;
        }
    }
}
