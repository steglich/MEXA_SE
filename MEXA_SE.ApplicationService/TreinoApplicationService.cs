using MEXA_SE.Domain.Commands.TreinoCommands;
using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Services;
using MEXA_SE.Infra.Presistence;
using System.Collections.Generic;

namespace MEXA_SE.ApplicationService
{
    public class TreinoApplicationService : ApplicationServiceBase, ITreinoApplicationService
    {
        private ITreinoRepository _repository;

        public TreinoApplicationService(ITreinoRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Treino Create(CreateTreinoCommand command)
        {
            var treino = new Treino(command.DsTreino, command.UsuarioTreinoId);
            treino.CreateTreino();
            _repository.Create(treino);

            if (Commit())
            {
                return treino;
            }

            return null;
        }

        public List<Treino> GetAll(string email)
        {
            return _repository.GetAll(email);
        }

        public Treino GetByEmail(string email)
        {
            return _repository.GetByEmail(email);
        }

        public Treino GetByTreino(string email, string dsTreino)
        {
            return _repository.GetByTreino(email, dsTreino);
        }

        public Treino GetTreino(string treino)
        {
            return _repository.GetTreino(treino);
        }

        public UsuarioTreino GetUsuario(string email)
        {
            return _repository.GetUsuario(email);
        }

        public Treino Update(UpdateTreinoCommand command)
        {
            var treino = _repository.GetId(command.TreinoId);
            treino.UpdateTreino(command.DsTreino);
            _repository.Update(treino);

            if (Commit())
            {
                return treino;
            }

            return null;
        }
    }
}
