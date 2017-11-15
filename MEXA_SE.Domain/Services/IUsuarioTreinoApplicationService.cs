using MEXA_SE.Domain.Commands.UsuarioTreinoCommands;
using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Services
{
    public interface IUsuarioTreinoApplicationService
    {
        List<UsuarioTreino> GetAll();
        UsuarioTreino GetOne(int usuarioTreinoId, string email);
        UsuarioTreino Create(CreateUsuarioTreinoCommand command);
        //UsuarioTreino Update(UpdateUsuarioTreinoCommand command);
    }
}
