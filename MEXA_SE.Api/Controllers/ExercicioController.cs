using MEXA_SE.ApplicationService;
using MEXA_SE.Domain.Commands.ExercicioCommands;
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
    public class ExercicioController : BaseController
    {
        private IExercicioApplicationService _service;
        private ExercicioRepository _repository;
        private UnitOfWork _unitOfWork;
        private DataContext _dataContext;
        public ExercicioController()
        {
            _dataContext = new DataContext();
            _repository = new ExercicioRepository(_dataContext);
            _unitOfWork = new UnitOfWork(_dataContext);

            this._service = new ExercicioApplicationService(_repository, _unitOfWork);


        }

        [HttpPost]
        [Route("api/exercicio/create/")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var response = new HttpResponseMessage();
            try
            {
                var command = new CreateExercicioCommand(
                    dsExercicio: (string)body.exercicio,
                    treinoId: (int)body.treinoid
                );

                var exercicio = _service.Create(command);

                return CreateResponse(HttpStatusCode.Created, exercicio);
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Exercicio não foi criado!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpGet]
        [Route("api/exercicio/email/{id},{email},{emails}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id, string email, string emails)
        {
            string teste = email + "." + emails;
            var response = new HttpResponseMessage();
            try
            {
                var exercicio = _service.GetOne(id, teste);
                response = Request.CreateResponse(HttpStatusCode.OK, exercicio);
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
        [Route("api/exercicio/update/{id}")]
        public Task<HttpResponseMessage> Put(int id, [FromBody]dynamic body)
        {

            var response = new HttpResponseMessage();
            try
            {
                var command = new UpdateExercicioCommand(
                    exercicioId: (int)body.id,
                    dsExercicio: (string)body.exercicio
                );

                var exercicio = _service.Update(command);
                response = Request.CreateResponse(HttpStatusCode.OK, "Atualizado com sucesso!");
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Não foi Atualizado o usuário!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }
    }
}