using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Specs;
using MEXA_SE.Infra.Presistence.DataContexts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MEXA_SE.Infra.Repositories
{
    public class EvolucaoTreinoRepository : IEvolucaoTreinoRepository
    {
        private DataContext _context;

        public EvolucaoTreinoRepository(DataContext context)
        {
            this._context = context;
        }

        public void Create(EvolucaoTreino quantidade)
        {
            _context.EvolucaoTreino.Add(quantidade);
        }

        public List<EvolucaoTreino> GetAll(string email, string exercicio)
        {
            return _context.EvolucaoTreino.Where(EvolucaoTreinoSpecs.GetAll(email, exercicio)).ToList();
        }

        public EvolucaoTreino GetId(int evolucaoTreinoId)
        {
            return _context.EvolucaoTreino.Find(evolucaoTreinoId);
        }

        public EvolucaoTreino GetOne(string email, string exercicio)
        {
            return _context.EvolucaoTreino.OrderByDescending(x => x.AumetoTreino).FirstOrDefault(EvolucaoTreinoSpecs.GetAll(email, exercicio));
        }

        public Exercicio GetUsuario(string email)
        {
            return _context.Exercicio.OrderByDescending(x => x.Treino.UsuarioTreino.DtTreino).FirstOrDefault(ExercicioSpecs.GetByEmail(email));
        }

        public void Update(EvolucaoTreino evolucaoTreino)
        {
            _context.Entry<EvolucaoTreino>(evolucaoTreino).State = EntityState.Modified;
        }
    }
}
