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
        }
        
        [HttpPost]
        [Route("api/usuarios/valida/")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> PostAutentica([FromBody]dynamic body)
        {
            string email= (string)body.email;
            string senha = (string)body.senha;
            var response = new HttpResponseMessage();

            var usuarios = _service.GetAuthenticateUsuario(email, senha);

            if (usuarios == null)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Email ou Senha inválido!");
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK, usuarios);
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpGet]
        [Route("api/usuarios/id/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var usuarios = _service.GetOne(id);
            return CreateResponse(HttpStatusCode.OK, usuarios);
        }
        
        [HttpPost]
        [Route("api/usuarios/getEmail/")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> GetEmail([FromBody]dynamic body)
        {
            string email = (string)body.email;
            
            var response = new HttpResponseMessage();
            try
            {
                var usuarios = _service.GetByEmail(email);
                response = Request.CreateResponse(HttpStatusCode.OK, usuarios);
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
        [Route("api/usuarios/update/")]
        public Task<HttpResponseMessage> Put([FromBody]dynamic body)
        {


            var usuariosUpdate = _service.GetByEmail((string)body.emailOld);

            var response = new HttpResponseMessage();
            try
            {
                var command = new UpdateUsuarioCommand(
                    id: usuariosUpdate.UsuarioId,
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