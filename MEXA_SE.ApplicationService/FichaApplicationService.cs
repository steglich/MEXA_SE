using System.Collections.Generic;
using MEXA_SE.Domain.Commands.FichaCommands;
using MEXA_SE.Domain.Entities;
using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Services;
using MEXA_SE.Infra.Presistence;

namespace MEXA_SE.ApplicationService
{
    public class FichaApplicationService : ApplicationServiceBase, IFichaApplicationService
    {
        private IFichaRepository _repository;

        public FichaApplicationService(IFichaRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Ficha Create(CreateFichaCommand command)
        {
            var ficha = new Ficha(command.Peso, command.Altura, command.Gordura, command.Peito, command.Cintura, command.Quadril,
                command.AnteBracoDireito, command.AnteBracoEsquerdo, command.BracoDireito, command.BracoEsquerdo, command.CoxaDireita,
                command.CoxaEsquerda, command.PantuDireita, command.PantuEsquerda, command.AvaliacaoId);
            ficha.CreateFicha();
            _repository.Create(ficha);

            if (Commit())
            {
                return ficha;
            }

            return null;
        }

        public List<Ficha> GetAll()
        {
            return _repository.GetAll();
        }

        public Ficha GetOne(string email)
        {
            return _repository.GetOne(email);
        }

        public Ficha Update(UpdateFichaCommand command)
        {
            var ficha = _repository.GetId(command.FichaId);
            ficha.UpdateFicha(command.Peso, command.Altura, command.Gordura, command.Peito, command.Cintura, command.Quadril,
                command.AnteBracoDireito, command.AnteBracoEsquerdo, command.BracoDireito, command.BracoEsquerdo, command.CoxaDireita,
                command.CoxaEsquerda, command.PantuDireita, command.PantuEsquerda);
            _repository.Update(ficha);

            if (Commit())
            {
                return ficha;
            }

            return null;
        }
    }
}
