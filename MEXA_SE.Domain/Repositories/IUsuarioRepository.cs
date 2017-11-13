using MEXA_SE.Domain.Entities;

namespace MEXA_SE.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario GetAuthenticateUsuario(string emial, string senha);
        Usuario GetOne(int id);
        Usuario GetByEmail(string email);
        void Create(Usuario usuario);
        void Update(Usuario usuario);
    }
}
