using MEXA_SE.ApplicationService;
using MEXA_SE.Domain.Commands.AvaiacaoCommands;
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
    public class AvaliacaoController : BaseController
    {

        private IUsuarioApplicationService _serviceUsuario;
        private UsuarioRepository _repositoryUsuario;

        private IAvaliacaoApplicationService _service;
        private AvaliacaoRepository _repository;
        private UnitOfWork _unitOfWork;
        private DataContext _dataContext;

        public AvaliacaoController()
        {
            _dataContext = new DataContext();
            _repository = new AvaliacaoRepository(_dataContext);
            _repositoryUsuario = new UsuarioRepository(_dataContext);
            _unitOfWork = new UnitOfWork(_dataContext);

            this._service = new AvaliacaoApplicationService(_repository, _unitOfWork);

            this._serviceUsuario = new UsuarioApplicationService(_repositoryUsuario, _unitOfWork);

        }

        [HttpPost]
        [Route("api/avaliacao/create/")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {

            var usuario = _serviceUsuario.GetByEmail((string)body.email);

            var response = new HttpResponseMessage();
            try
            {
                var command = new CreateAvaliacaoCommand(
                    reavaliacao: (DateTime)body.reavaliacao,
                    usuarioId: usuario.UsuarioId
                //usuarioId: (int)body.usuarioid
                );

                var avaliacao = _service.Create(command);

                //return CreateResponse(HttpStatusCode.Created, avaliacao);
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Não foi criada a avaliação!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpPost]
        [Route("api/avaliacao/data/")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get([FromBody]dynamic body)
        {
            var usuario = _serviceUsuario.GetByEmail((string)body.email);

            var response = new HttpResponseMessage();
            try
            {
                var avaliacao = _service.GetOne(usuario.Email);
                //response = Request.CreateResponse(HttpStatusCode.OK, avaliacao);
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
        [Route("api/avaliacao/update/")]
        public Task<HttpResponseMessage> Put([FromBody]dynamic body)
        {

            var usuario = _serviceUsuario.GetByEmail((string)body.email);

            var response = new HttpResponseMessage();
            try
            {
                var avaliacaoGet = _service.GetOne(usuario.Email);

                var command = new UpdateAvaliacaoCommand(
                    avaliacaoId: avaliacaoGet.AvaliacaoId,
                    reavaliacao: (DateTime)body.reavaliacao
                );

                var avaliacao = _service.Update(command);
                //response = Request.CreateResponse(HttpStatusCode.OK, "Atualizado com sucesso!");
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "A avaliação Não foi Atualizada!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }
    }
}