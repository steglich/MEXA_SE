using MEXA_SE.Domain.Commands.AvaiacaoCommands;
using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Services;
using MEXA_SE.Infra.Presistence;
using System.Collections.Generic;

namespace MEXA_SE.ApplicationService
{
    public class AvaliacaoApplicationService : ApplicationServiceBase, IAvaliacaoApplicationService
    {
        private IAvaliacaoRepository _repository;

        public AvaliacaoApplicationService(IAvaliacaoRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Avaliacao Create(CreateAvaliacaoCommand command)
        {
            var avaliacao = new Avaliacao(command.Reavaliacao, command.UsuarioId);
            avaliacao.CreateAvaliacao();
            _repository.Create(avaliacao);

            if (Commit())
            {
                return avaliacao;
            }

            return null;
        }

        public List<Avaliacao> GetAll()
        {
            return _repository.GetAll();
        }

        public Avaliacao GetOne(string email)
        {
            return _repository.GetOne(email);
        }

        public Avaliacao Update(UpdateAvaliacaoCommand command)
        {
            var avaliacao = _repository.GetId(command.AvaliacaoId);
            avaliacao.UpdateAvaliacao(command.Reavaliacao);
            _repository.Update(avaliacao);

            if (Commit())
            {
                return avaliacao;
            }

            return null;
        }
    }
}
