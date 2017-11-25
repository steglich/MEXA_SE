using MEXA_SE.ApplicationService;
using MEXA_SE.Domain.Commands.AvaiacaoCommands;
using MEXA_SE.Domain.Commands.FichaCommands;
using MEXA_SE.Domain.Services;
using MEXA_SE.Infra.Presistence;
using MEXA_SE.Infra.Presistence.DataContexts;
using MEXA_SE.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MEXA_SE.Api.Controllers
{
    public class FichaController : BaseController
    {

        //private IAvaliacaoApplicationService _serviceA;
        //private AvaliacaoRepository _repositoryA;

        private AvaliacaoController _avaliacaoController;

        private IFichaApplicationService _service;
        private FichaRepository _repository;
        private UnitOfWork _unitOfWork;
        private DataContext _dataContext;

        public FichaController()
        {
            _dataContext = new DataContext();
            _repository = new FichaRepository(_dataContext);

            //_repositoryA = new AvaliacaoRepository(_dataContext);
            _unitOfWork = new UnitOfWork(_dataContext);

            //this._serviceA = new AvaliacaoApplicationService(_repositoryA, _unitOfWork);

            this._service = new FichaApplicationService(_repository, _unitOfWork);
            this._avaliacaoController = new AvaliacaoController();

        }

        [HttpPost]
        [Route("api/ficha/create/")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var response = new HttpResponseMessage();
            try
            {
                var command = new CreateFichaCommand(
                    peso: (float)body.peso,
                    altura: (float)body.altura,
                    gordura: (float)body.gordura,
                    peito: (float)body.peito,
                    cintura: (float)body.cintura,
                    quadril: (float)body.quadril,
                    anteBracoDireito: (float)body.anteBracoDireito,
                    anteBracoEsquerdo: (float)body.anteBracoEsquerdo,
                    bracoDireito: (float)body.bracoDireito,
                    bracoEsquerdo: (float)body.bracoEsquerdo,
                    coxaDireita: (float)body.coxaDireita,
                    coxaEsquerda: (float)body.coxaEsquerda,
                    pantuDireita: (float)body.pantuDireita,
                    pantuEsquerda: (float)body.pantuEsquerda,
                    avaliacaoId: (int)body.avaliacaoId
                );

                var ficha = _service.Create(command);

                return CreateResponse(HttpStatusCode.Created, ficha);
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "A ficha de avaliação não foi criada!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }


        [HttpPost]
        [Route("api/ficha/create/avaliacao/")]
        public Task<HttpResponseMessage> PostAva([FromBody]dynamic body)
        {
            var response = new HttpResponseMessage();
            try
            {
                _avaliacaoController.Post(body); // metodo para cadastrar uma avaliação

                var fichas = _service.GetAvaliacao((string)body.email); // metodo para retornar o id da avaliação

                var command = new CreateFichaCommand(
                    peso: (float)body.peso,
                    altura: (float)body.altura,
                    gordura: (float)body.gordura,
                    peito: (float)body.peito,
                    cintura: (float)body.cintura,
                    quadril: (float)body.quadril,
                    anteBracoDireito: (float)body.anteBracoDireito,
                    anteBracoEsquerdo: (float)body.anteBracoEsquerdo,
                    bracoDireito: (float)body.bracoDireito,
                    bracoEsquerdo: (float)body.bracoEsquerdo,
                    coxaDireita: (float)body.coxaDireita,
                    coxaEsquerda: (float)body.coxaEsquerda,
                    pantuDireita: (float)body.pantuDireita,
                    pantuEsquerda: (float)body.pantuEsquerda,
                    avaliacaoId: fichas.AvaliacaoId
                    //avaliacaoId: (int)body.avaliacaoId
                );

                var ficha = _service.Create(command);

                return CreateResponse(HttpStatusCode.Created, ficha);
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "A ficha de avaliação não foi criada!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpPost]
        [Route("api/ficha/email/")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> postFicha([FromBody]dynamic body)
        {
            //_avaliacaoController.Get(body);

            var fichas = _service.GetAvaliacao((string)body.email);

            var response = new HttpResponseMessage();
            try
            {
                var ficha = _service.GetId(fichas.AvaliacaoId); // metodo para fazer a pesquisa da ficha pelo id da avaliação
                response = Request.CreateResponse(HttpStatusCode.OK, ficha);
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Procura por email não encontrada!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpPut]
        [Route("api/ficha/update/")]
        public Task<HttpResponseMessage> Put([FromBody]dynamic body)
        {

            var response = new HttpResponseMessage();
            try
            {
                _avaliacaoController.Put(body); // metodo para atualizar a avaliação

                var fichas = _service.GetAvaliacao((string)body.email); // metodo para retornar o id da avaliação

                var fichaGet = _service.GetId(fichas.AvaliacaoId); // metodo para recuperar o id da ficha de avaliação

                var command = new UpdateFichaCommand(
                    fichaId: fichaGet.FichaId,
                    peso: (float)body.peso,
                    altura: (float)body.altura,
                    gordura: (float)body.gordura,
                    peito: (float)body.peito,
                    cintura: (float)body.cintura,
                    quadril: (float)body.quadril,
                    anteBracoDireito: (float)body.anteBracoDireito,
                    anteBracoEsquerdo: (float)body.anteBracoEsquerdo,
                    bracoDireito: (float)body.bracoDireito,
                    bracoEsquerdo: (float)body.bracoEsquerdo,
                    coxaDireita: (float)body.coxaDireita,
                    coxaEsquerda: (float)body.coxaEsquerda,
                    pantuDireita: (float)body.pantuDireita,
                    pantuEsquerda: (float)body.pantuEsquerda
                );

                var ficha = _service.Update(command);
                response = Request.CreateResponse(HttpStatusCode.OK, "Atualizado com sucesso!");
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "A ficha de avaliação Não foi Atualizada!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }
    }
}