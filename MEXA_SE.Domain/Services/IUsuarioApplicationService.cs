using MEXA_SE.Domain.Commands.UsuarioCommands;
using MEXA_SE.Domain.Entities;

namespace MEXA_SE.Domain.Services
{
    public interface IUsuarioApplicationService
    {
        Usuario GetAuthenticateUsuario(string emial, string senha);
        Usuario GetOne(int id);
        Usuario GetByEmail(string email);
        void Create(RegisterUsuarioCommand command);
        void Update(UpdateUsuarioCommand command);
    }
}
