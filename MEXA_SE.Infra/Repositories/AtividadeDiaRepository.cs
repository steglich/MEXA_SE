﻿using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Specs;
using MEXA_SE.Infra.Presistence.DataContexts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MEXA_SE.Infra.Repositories
{
    public class AtividadeDiaRepository : IAtividadeDiaRepository
    {
        private DataContext _context;

        public AtividadeDiaRepository(DataContext context)
        {
            this._context = context;
        }

        public void Create(AtividadeDia atividadeDia)
        {
            _context.AtividadeDia.Add(atividadeDia);
        }

        public List<AtividadeDia> GetAll(string email)
        {
            return _context.AtividadeDia.Where(AtividadeDiaSpecs.GetAllDias(email)).ToList();
        }

        //public AtividadeDia GetOne(int id, string email)
        //{
        //    return _context.AtividadeDia.Where(x => x.UsuarioId == x.Usuario.UsuarioId && x.Usuario.Email.Equals(email) && x.AtividadeDiaId == id).FirstOrDefault();
        //}

        public void Update(AtividadeDia atividadeDia)
        {
            _context.Entry<AtividadeDia>(atividadeDia).State = EntityState.Modified;
        }
    }
}
