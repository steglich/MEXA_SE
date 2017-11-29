using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Repositories
{
    public interface IExercicioRepository
    {
        List<Exercicio> GetAll();
        Exercicio GetId(int exercicioId);
        Exercicio GetByEmail(string email);
        Exercicio GetByExercicio(string email, string exercicio);
        Exercicio GetExercicio(string exercicio);
        Treino getUsuario(string email, string treino);
        void Create(Exercicio exercico);
        void Update(Exercicio exercico);
    }
}
