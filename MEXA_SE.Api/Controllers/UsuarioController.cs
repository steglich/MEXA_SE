using MEXA_SE.ApplicationService;
using MEXA_SE.Domain.Commands.UsuarioCommands;
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
    public class UsuarioController : BaseController
    {
        private IUsuarioApplicationService _service;
        private UsuarioRepository _repository;
        private UnitOfWork _unitOfWork;
        private DataContext _dataContext;
        public UsuarioController()
        {
            _dataContext = new DataContext();
            _repository = new UsuarioRepository(_dataContext);
            _unitOfWork = new UnitOfWork(_dataContext);

            this._service = new UsuarioApplicationService(_repository, _unitOfWork);


        }

        [HttpPost]
        [Route("api/usuarios/create/")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var response = new HttpResponseMessage();
            try
            {
                var command = new RegisterUsuarioCommand(
                    email: (string)body.email,
                    senha: (string)body.senha,
                    nome: (string)body.nome
                );

                var usuarios = _service.Create(command);

                return CreateResponse(HttpStatusCode.Created, usuarios);
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Não foi criado o usuário!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;

            //var command = new RegisterUsuarioCommand(
            //    email: (string)body.email,
            //    senha: (string)body.senha,
            //    nome: (string)body.nome,
            //    isAdmin: (bool)body.isAdmin
            //);

            //var usuarios = _service.Create(command);

            //return CreateResponse(HttpStatusCode.Created, usuarios);
        }

        //[HttpPost]
        //[Route("api/usuarios/autenticacao/{email},{emails},{senha}")]
        ////[Authorize(Roles = "admin")]
        //public Task<HttpResponseMessage> Post(string email, string emails, string senha)
        [HttpPost]
        [Route("api/usuarios/valida/{email},{senha}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Post(string email, string senha)
        {
            //string teste = email + "." + emails;
            var response = new HttpResponseMessage();
            try
            {
                var usuarios = _service.GetAuthenticateUsuario(email, senha);
                response = Request.CreateResponse(HttpStatusCode.OK, usuarios);
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Procura por email não encontrada!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;

            //var usuarios = _service.GetByEmail(email);
            //return CreateResponse(HttpStatusCode.OK, usuarios);
        }

        [HttpGet]
        [Route("api/usuarios/id/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var usuarios = _service.GetOne(id);
            return CreateResponse(HttpStatusCode.OK, usuarios);
        }

        [HttpGet]
        [Route("api/usuarios/email/{email},{emails}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(string email, string emails)
        {
            var response = new HttpResponseMessage();
            try
            {
                var usuarios = _service.GetByEmail(email + "." + emails);
                response = Request.CreateResponse(HttpStatusCode.OK, usuarios);
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Procura por email não encontrada!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;

            //var usuarios = _service.GetByEmail(email);
            //return CreateResponse(HttpStatusCode.OK, usuarios);
        }

        [HttpPut]
        [Route("api/usuarios/update/{id}")]
        public Task<HttpResponseMessage> Put(int id, [FromBody]dynamic body)
        {

            var response = new HttpResponseMessage();
            try
            {
                var command = new UpdateUsuarioCommand(
                    id: (int)body.id,
                    email: (string)body.email,
                    senha: (string)body.senha,
                    nome: (string)body.nome
                );

                var usuarios = _service.Update(command);
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