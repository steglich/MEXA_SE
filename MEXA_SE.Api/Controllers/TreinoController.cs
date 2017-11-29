using MEXA_SE.ApplicationService;
using MEXA_SE.Domain.Commands.TreinoCommands;
using MEXA_SE.Domain.Services;
using MEXA_SE.Infra.Presistence;
using MEXA_SE.Infra.Presistence.DataContexts;
using MEXA_SE.Infra.Repositories;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MEXA_SE.Api.Controllers
{
    public class TreinoController : BaseController
    {
        private UsuarioTreinoController _usuarioTreinocontroller;

        private ITreinoApplicationService _service;
        private TreinoRepository _repository;
        private UnitOfWork _unitOfWork;
        private DataContext _dataContext;

        public TreinoController()
        {
            _dataContext = new DataContext();
            _repository = new TreinoRepository(_dataContext);
            _unitOfWork = new UnitOfWork(_dataContext);

            this._service = new TreinoApplicationService(_repository, _unitOfWork);

            this._usuarioTreinocontroller = new UsuarioTreinoController();
        }

        [HttpPost]
        [Route("api/treino/create/")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var response = new HttpResponseMessage();
            try
            {
                _usuarioTreinocontroller.Post(body);

                var treinos = _service.GetUsuario((string)body.email);


                try
                {
                    var trei = _service.GetByTreino((string)body.email, (string)body.treino);

                    if (trei.DsTreino.Equals((string)body.treino))
                    {
                        return CreateResponse(HttpStatusCode.Created, treinos);
                    }
                    else
                    {
                        var command = new CreateTreinoCommand(
                            dsTreino: (string)body.treino,
                            usuarioTreinoId: treinos.UsuarioTreinoId
                        );

                        var treino = _service.Create(command);

                        return CreateResponse(HttpStatusCode.Created, treino);
                    }
                }
                catch
                {
                    var command = new CreateTreinoCommand(
                        dsTreino: (string)body.treino,
                        usuarioTreinoId: treinos.UsuarioTreinoId
                    );

                    var treino = _service.Create(command);

                    return CreateResponse(HttpStatusCode.Created, treino);
                }
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "O treino não foi criado!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpGet]
        [Route("api/treino/data/{email},{emails}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(string email, string emails)
        {
            string teste = email + "." + emails;
            var response = new HttpResponseMessage();
            try
            {
                //var treino = _service.GetOne(teste, email);
                //response = Request.CreateResponse(HttpStatusCode.OK, treino);
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
        [Route("api/treino/update/{id}")]
        public Task<HttpResponseMessage> Put(int id, [FromBody]dynamic body)
        {

            var response = new HttpResponseMessage();
            try
            {
                var command = new UpdateTreinoCommand(
                    treinoId: (int)body.id,
                    dsTreino: (string)body.treino
                );

                var treino = _service.Update(command);
                response = Request.CreateResponse(HttpStatusCode.OK, "Atualizado com sucesso!");
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Treino não foi Atualizado!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }
    }
}