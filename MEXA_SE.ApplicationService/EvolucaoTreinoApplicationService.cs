using MEXA_SE.Domain.Commands.EvolucaoTreinoCommands;
using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Services;
using MEXA_SE.Infra.Presistence;
using System.Collections.Generic;

namespace MEXA_SE.ApplicationService
{
    public class EvolucaoTreinoApplicationService : ApplicationServiceBase, IEvolucaoTreinoApplicationService
    {
        private IEvolucaoTreinoRepository _repository;

        public EvolucaoTreinoApplicationService(IEvolucaoTreinoRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public EvolucaoTreino Create(CreateEvolucaoTreinoCommand command)
        {
            var evolucaoTreino = new EvolucaoTreino(command.Repeticao, command.Carga, command.ExercicioId);
            evolucaoTreino.CreateEvolucaoTreino();
            _repository.Create(evolucaoTreino);

            if (Commit())
            {
                return evolucaoTreino;
            }

            return null;
        }

        public List<EvolucaoTreino> GetAll()
        {
            return _repository.GetAll();
        }

        public EvolucaoTreino GetOne(string email)
        {
            return _repository.GetOne(email);
        }

        public Exercicio GetUsuario(string email)
        {
            return _repository.GetUsuario(email);
        }

        public EvolucaoTreino Update(UpdateEvolucaoTreinoCommand command)
        {
            var evolucaoTreino = _repository.GetId(command.EvolucaoTreinoId);
            evolucaoTreino.UpdateEvolucaoTreino(command.Repeticao, command.Carga);
            _repository.Update(evolucaoTreino);

            if (Commit())
            {
                return evolucaoTreino;
            }

            return null;
        }
    }
}
