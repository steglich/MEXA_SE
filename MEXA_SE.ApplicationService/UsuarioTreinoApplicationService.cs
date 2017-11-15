using MEXA_SE.Domain.Commands.UsuarioTreinoCommands;
using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Services;
using MEXA_SE.Infra.Presistence;
using System.Collections.Generic;

namespace MEXA_SE.ApplicationService
{
    public class UsuarioTreinoApplicationService : ApplicationServiceBase, IUsuarioTreinoApplicationService
    {
        private IUsuarioTreinoRepository _repository;

        public UsuarioTreinoApplicationService(IUsuarioTreinoRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public UsuarioTreino Create(CreateUsuarioTreinoCommand command)
        {
            //var usuarioTreino = new UsuarioTreino(command.UsuarioId, command.TreinoId, command.DtTreino);
            var usuarioTreino = new UsuarioTreino(command.DtTreino);
            usuarioTreino.CreateUsuarioTreino();
            _repository.Create(usuarioTreino);

            if (Commit())
            {
                return usuarioTreino;
            }

            return null;
        }

        public List<UsuarioTreino> GetAll()
        {
            return _repository.GetAll();
        }

        public UsuarioTreino GetOne(int usuarioId, string email)
        {
            return _repository.GetOne(usuarioId, email);
        }

        //public UsuarioTreino Update(UpdateUsuarioTreinoCommand command)
        //{
        //    var usuarioTreino = _repository.GetOne(command.UsuarioId, command.TreinoId);
        //    usuarioTreino.UpdateUsuarioTreino(command.DtTreino);
        //    _repository.Create(usuarioTreino);

        //    if (Commit())
        //    {
        //        return usuarioTreino;
        //    }

        //    return null;
        //}
    }
}
