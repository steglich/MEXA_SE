using MEXA_SE.ApplicationService;
using MEXA_SE.Domain.Commands.FichaCommands;
using MEXA_SE.Domain.Services;
using MEXA_SE.Infra.Presistence;
using MEXA_SE.Infra.Presistence.DataContexts;
using MEXA_SE.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace MEXA_SE.Api.Controllers
{
    public class FichaController : BaseController
    {
        private IFichaApplicationService _service;
        private FichaRepository _repository;
        private UnitOfWork _unitOfWork;
        private DataContext _dataContext;

        public FichaController()
        {
            _dataContext = new DataContext();
            _repository = new FichaRepository(_dataContext);
            _unitOfWork = new UnitOfWork(_dataContext);

            this._service = new FichaApplicationService(_repository, _unitOfWork);

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

        [HttpGet]
        [Route("api/ficha/email/{id},{email},{emails}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id, string email, string emails)
        {
            string teste = email + "." + emails;
            var response = new HttpResponseMessage();
            try
            {
                var ficha = _service.GetOne(id, teste);
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
        [Route("api/ficha/update/{id}")]
        public Task<HttpResponseMessage> Put(int id, [FromBody]dynamic body)
        {

            var response = new HttpResponseMessage();
            try
            {
                var command = new UpdateFichaCommand(
                    fichaId: (int)body.id,
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

                var avaliacao = _service.Update(command);
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