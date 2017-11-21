using MEXA_SE.Domain.Commands.UsuarioCommands;
using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Services;
using MEXA_SE.Infra.Presistence;
using MEXA_SE.SharedKernel;
using MEXA_SE.SharedKernel.Events;
using MEXA_SE.SharedKernel.Helpers;

namespace MEXA_SE.ApplicationService
{
    public class UsuarioApplicationService : ApplicationServiceBase, IUsuarioApplicationService
    {
        private IUsuarioRepository _repository;
        private IHandler<DomainNotification> _notification;

        public UsuarioApplicationService(IUsuarioRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
            this._notification = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
        }

        public Usuario Create(RegisterUsuarioCommand command)
        {
            var usuario = new Usuario(command.Nome, command.Email, command.Senha);
            usuario.RegisterUsuario();
            _repository.Create(usuario);

            if (Commit())
            {
                return usuario;
            }

            return null;
        }

        public Usuario GetAuthenticateUsuario(string email, string senha)
        {
            return _repository.GetAuthenticateUsuario(email, senha);

            //if(_repository.GetAuthenticateUsuario(email, senha) == null)
            //{

            //    var usuario = new Usuario(StringHelper.Encrypt(email), senha);
            //    usuario.Authenticate(usuario.Email, usuario.Senha);

            //    if (_notification.HasNotifications())
            //    {
            //        return null;
            //    }

            //}
            //return _repository.GetAuthenticateUsuario(email, senha);
        }

        public Usuario GetByEmail(string email)
        {
            return _repository.GetByEmail(email);
        }

        public Usuario GetOne(int id)
        {
            return _repository.GetOne(id);
        }

        public Usuario Update(UpdateUsuarioCommand command)
        {
            var usuario = _repository.GetOne(command.Id);
            usuario.UpdateUsuario(command.Nome, command.Email, command.Senha);
            _repository.Update(usuario);

            if (Commit())
            {
                return usuario;
            }

            return null;
        }
    }
}
