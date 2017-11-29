using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Specs;
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

        public List<Exercicio> GetAll()
        {
            return _context.Exercicio.ToList();
        }

        public Exercicio GetExercicio(string exercicio)
        {
            return _context.Exercicio.Find(exercicio);
        }

        public Exercicio GetId(int exercicioId)
        {
            return _context.Exercicio.Find(exercicioId);
        }

        public Exercicio GetByEmail(string email)
        {
            return _context.Exercicio.OrderByDescending(x => x.Treino.UsuarioTreino.DtTreino).FirstOrDefault(ExercicioSpecs.GetByEmail(email));
        }

        public Exercicio GetByExercicio(string email, string exercicio)
        {
            return _context.Exercicio.OrderByDescending(x => x.Treino.UsuarioTreino.DtTreino).FirstOrDefault(ExercicioSpecs.GetByExercicio(email, exercicio));
        }

        public Treino getUsuario(string email, string treino)
        {
            return _context.Treino.OrderByDescending(x => x.UsuarioTreino.DtTreino).FirstOrDefault(TreinoSpecs.GetByTreino(email, treino));
        }

        public void Update(Exercicio exercico)
        {
            _context.Entry<Exercicio>(exercico).State = EntityState.Modified;
        }
    }
}
