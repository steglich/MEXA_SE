using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Repositories
{
    public interface IExercicioRepository
    {
        List<Exercicio> Get();
        Exercicio GetOne(int exercicioId, int treinoId);
        Exercicio GetExercicio(string exercicio);
        void Create(Exercicio exercico);
        void Update(Exercicio exercico);
    }
}
