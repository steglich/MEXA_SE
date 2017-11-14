using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Infra.Presistence.DataContexts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MEXA_SE.Infra.Repositories
{
    public class ExercicioRepository : IExercicioRepository
    {
        private DataContext _context;

        public ExercicioRepository(DataContext context)
        {
            this._context = context;
        }

        public void Create(Exercicio exercico)
        {
            _context.Exercicio.Add(exercico);
        }

        public List<Exercicio> Get()
        {
            return _context.Exercicio.ToList();
        }

        public Exercicio GetExercicio(string exercicio)
        {
            return _context.Exercicio.Find(exercicio);
        }

        public Exercicio GetOne(int exercicioId, int treinoId)
        {
            return _context.Exercicio.Find(exercicioId, treinoId);
        }

        public void Update(Exercicio exercico)
        {
            _context.Entry<Exercicio>(exercico).State = EntityState.Modified;
        }
    }
}
