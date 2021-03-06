﻿using MEXA_SE.ApplicationService;
using MEXA_SE.Domain.Commands.UsuarioTreinoCommands;
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
    public class UsuarioTreinoController : BaseController
    {

        private IUsuarioApplicationService _serviceUsuario;
        private UsuarioRepository _repositoryUsuario;

        private IUsuarioTreinoApplicationService _service;
        private UsuarioTreinoRepository _repository;
        private UnitOfWork _unitOfWork;
        private DataContext _dataContext;

        public UsuarioTreinoController()
        {
            _dataContext = new DataContext();
            _repository = new UsuarioTreinoRepository(_dataContext);
            _repositoryUsuario = new UsuarioRepository(_dataContext);
            _unitOfWork = new UnitOfWork(_dataContext);

            this._service = new UsuarioTreinoApplicationService(_repository, _unitOfWork);

            this._serviceUsuario = new UsuarioApplicationService(_repositoryUsuario, _unitOfWork);

        }

        [HttpPost]
        [Route("api/usuariotreino/create/")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var response = new HttpResponseMessage();
            try
            {

                try
                {
                    DateTime dataTeste = DateTime.Now.Date;
                    var data = _service.GetOne((string)body.email);

                    if (data.DtTreino != dataTeste)
                    {
                        var usuario = _serviceUsuario.GetByEmail((string)body.email);

                        var command = new CreateUsuarioTreinoCommand(
                            usuarioId: usuario.UsuarioId
                        );

                        var usuarioTreino = _service.Create(command);
                    }

                }
                catch
                {
                    var usuario = _serviceUsuario.GetByEmail((string)body.email);

                    var command = new CreateUsuarioTreinoCommand(
                        usuarioId: usuario.UsuarioId
                    );

                    var usuarioTreino = _service.Create(command);

                }
                //}

                //return CreateResponse(HttpStatusCode.Created, usuarioTreino);
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "A a data do treino não foi criada!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpGet]
        [Route("api/usuariotreino/data/{email},{emails}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(string email, string emails)
        {
            string teste = email + "." + emails;
            var response = new HttpResponseMessage();
            try
            {
                var usuarioTreino = _service.GetOne(teste);
                response = Request.CreateResponse(HttpStatusCode.OK, usuarioTreino);
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