using MEXA_SE.Domain.Commands.UsuarioTreinoCommands;
using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Services
{
    public interface IUsuarioTreinoApplicationService
    {
        List<UsuarioTreino> Get();
        UsuarioTreino GetOne(int usuarioId, int treinoId);
        void Create(CreateUsuarioTreinoCommand command);
        void Update(UpdateUsuarioTreinoCommand command);
    }
}
