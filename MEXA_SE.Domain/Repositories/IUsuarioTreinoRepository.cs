using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Repositories
{
    public interface IUsuarioTreinoRepository
    {
        List<UsuarioTreino> Get();
        UsuarioTreino GetOne(int usuarioId, int treinoId);
        void Create(UsuarioTreino usuarioTreino);
        void Update(UsuarioTreino usuarioTreino);
    }
}
