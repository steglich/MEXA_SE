using MEXA_SE.Domain.Commands.ExercicioCommands;
using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Services;
using MEXA_SE.Infra.Presistence;
using System.Collections.Generic;

namespace MEXA_SE.ApplicationService
{
    public class ExercicioApplicationService : ApplicationServiceBase, IExercicioApplicationService
    {
        private IExercicioRepository _repository;

        public ExercicioApplicationService(IExercicioRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Exercicio Create(CreateExercicioCommand command)
        {
            var exercicio = new Exercicio(command.DsExercicio, command.TreinoId);
            exercicio.CreateExercicio();
            _repository.Create(exercicio);

            if (Commit())
            {
                return exercicio;
            }

            return null;
        }

        public List<Exercicio> GetAll()
        {
            return _repository.GetAll();
        }

        public Exercicio GetExercicio(string exercicio)
        {
            return _repository.GetExercicio(exercicio);
        }

        public Exercicio GetByEmail(string email)
        {
            return _repository.GetByEmail(email);
        }

        public Exercicio GetByExercicio(string email, string exercicio)
        {
            return _repository.GetByExercicio(email, exercicio);
        }

        public Treino GetUsuario(string email, string treino)
        {
            return _repository.getUsuario(email, treino);
        }

        public Exercicio Update(UpdateExercicioCommand command)
        {
            var exercicio = _repository.GetId(command.ExercicioId);
            exercicio.UpdateExercicio(command.DsExercicio);
            _repository.Update(exercicio);

            if (Commit())
            {
                return exercicio;
            }

            return null;
        }
    }
}
