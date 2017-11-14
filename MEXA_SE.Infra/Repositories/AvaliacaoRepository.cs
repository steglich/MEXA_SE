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
    public class AvaliacaoRepository : IAvaliacaoRepository
    {
        private DataContext _context;

        public AvaliacaoRepository(DataContext context)
        {
            this._context = context;
        }

        public void Create(Avaliacao avaliacao)
        {
            _context.Avaliacao.Add(avaliacao);
        }

        public List<Avaliacao> GetAll()
        {
            return _context.Avaliacao.ToList();
        }

        public Avaliacao GetOne(int usuarioId, int fichaId, string email)
        {
            return _context.Avaliacao.Where(AvaliacaoSpecs.GetAll(usuarioId, fichaId, email)).FirstOrDefault();
        }

        public void Update(Avaliacao avaliacao)
        {
            _context.Entry<Avaliacao>(avaliacao).State = EntityState.Modified;
        }
    }
}
