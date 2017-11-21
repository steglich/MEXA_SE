using MEXA_SE.Domain.Commands.UsuarioCommands;
using MEXA_SE.Domain.Entities;

namespace MEXA_SE.Domain.Services
{
    public interface IUsuarioApplicationService
    {
        Usuario GetAuthenticateUsuario(string email, string senha);
        //Usuario GetAuthenticateUsuario(AutenticaUsuarioCommand command);
        Usuario GetOne(int id);
        Usuario GetByEmail(string email);
        Usuario Create(RegisterUsuarioCommand command);
        Usuario Update(UpdateUsuarioCommand command);
    }
}
