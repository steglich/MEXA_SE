using MEXA_SE.ApplicationService;
using MEXA_SE.Domain.Commands.AtividadeDiacommands;
using MEXA_SE.Domain.Services;
using MEXA_SE.Infra.Presistence;
using MEXA_SE.Infra.Presistence.DataContexts;
using MEXA_SE.Infra.Repositories;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MEXA_SE.Api.Controllers
{
    public class AtividadeDiaController : BaseController
    {
        private IAtividadeDiaApplicationService _service;
        private AtividadeDiaRepository _repository;
        private UnitOfWork _unitOfWork;
        private DataContext _dataContext;
        public AtividadeDiaController()
        {
            _dataContext = new DataContext();
            _repository = new AtividadeDiaRepository(_dataContext);
            _unitOfWork = new UnitOfWork(_dataContext);

            this._service = new AtividadeDiaApplicationService(_repository, _unitOfWork);


        }

        [HttpPost]
        [Route("api/atividade/create/")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var response = new HttpResponseMessage();
            try
            {
                var command = new CreateAtividadeDiaCommand(
                    usuarioId: (int)body.usuarioid
                );

                var tividadeDia = _service.Create(command);

                return CreateResponse(HttpStatusCode.Created, tividadeDia);
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "A atividade do dia não foi criada!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpPost]
        [Route("api/atividade/email/")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> PostEmail([FromBody]dynamic body)
        {
            //string teste = email + "." + emails;

            string email = (string)body.email;
            var response = new HttpResponseMessage();
            try
            {
                var atividade = _service.GetOne(email);
                response = Request.CreateResponse(HttpStatusCode.OK, atividade);
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Procura por email não encontrada!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }
    }
}