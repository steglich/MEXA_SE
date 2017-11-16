using MEXA_SE.Domain.Commands.AtividadeDiacommands;
using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Services;
using MEXA_SE.Infra.Presistence;
using System.Collections.Generic;

namespace MEXA_SE.ApplicationService
{
    public class AtividadeDiaApplicationService : ApplicationServiceBase, IAtividadeDiaApplicationService
    {
        private IAtividadeDiaRepository _repository;

        public AtividadeDiaApplicationService(IAtividadeDiaRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public AtividadeDia Create(CreateAtividadeDiaCommand command)
        {
            var atividadeDia = new AtividadeDia(command.UsuarioId);
            atividadeDia.CreateAtividadeDia();
            _repository.Create(atividadeDia);

            if (Commit())
            {
                return atividadeDia;
            }

            return null;
        }

        public List<AtividadeDia> GetAll()
        {
            return _repository.GetAll();
        }

        public AtividadeDia GetOne(string email)
        {
            return _repository.GetOne(email);
        }

        //public AtividadeDia Update(UpdateAtividadeDiaCommand command)
        //{
        //    var atividadeDia = _repository.GetOne(command.Id);
        //    atividadeDia.UpdateAtividadeDia(command.AtividadeConcluida);
        //    _repository.Create(atividadeDia);

        //    if (Commit())
        //    {
        //        return atividadeDia;
        //    }

        //    return null;
        //}
    }
}
