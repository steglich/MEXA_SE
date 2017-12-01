using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Repositories
{
    public interface ITreinoRepository
    {
        List<Treino> GetAll(string email);
        Treino GetId(int treinoId);
        Treino GetByEmail(string email);
        Treino GetByTreino(string email, string dsTreino);
        Treino GetTreino(string treino);
        UsuarioTreino GetUsuario(string email);
        void Create(Treino treino);
        void Update(Treino treino);
    }
}
