﻿using MEXA_SE.ApplicationService;
using MEXA_SE.Domain.Commands.EvolucaoTreinoCommands;
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
    public class EvolucaoTreinoController : BaseController
    {
        private ExercicioController _exercicioController;

        private IExercicioApplicationService _serviceExercicio;
        private ExercicioRepository _repositoryExercicio;

        private IEvolucaoTreinoApplicationService _service;
        private EvolucaoTreinoRepository _repository;
        private UnitOfWork _unitOfWork;
        private DataContext _dataContext;

        public EvolucaoTreinoController()
        {
            _dataContext = new DataContext();
            _repository = new EvolucaoTreinoRepository(_dataContext);
            _repositoryExercicio = new ExercicioRepository(_dataContext);
            _unitOfWork = new UnitOfWork(_dataContext);

            this._service = new EvolucaoTreinoApplicationService(_repository, _unitOfWork);
            this._serviceExercicio = new ExercicioApplicationService(_repositoryExercicio, _unitOfWork);

            this._exercicioController = new ExercicioController();

        }

        [HttpPost]
        [Route("api/evolucaoTreino/create/")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var response = new HttpResponseMessage();
            try
            {
                _exercicioController.Post(body);

                //var evolucaoTreinos = _service.GetUsuario((string)body.email);
                var evolucaoTreinos = _serviceExercicio.GetByExercicio((string)body.email, (string)body.exercicio);

                var command = new CreateEvolucaoTreinoCommand(
                    repeticao: (int)body.repeticao,
                    carga: (int)body.carga,
                    //aumentoTreino: (DateTime)body.aumento,
                    exercicioId: evolucaoTreinos.ExercicioId
                );

                var evolucao = _service.Create(command);

                return CreateResponse(HttpStatusCode.Created, evolucao);
            }
            catch
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "O Evolucao do treino não foi criado!");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpPost]
        [Route("api/evolucao/data/")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get([FromBody]dynamic body)
        {
            var response = new HttpResponseMessage();
            try
            {
                var evolucao = _service.GetOne((string)body.email, (string)body.exercicio);
                response = Request.CreateResponse(HttpStatusCode.OK, evolucao);
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
        [Route("api/evolucao/update/{id}")]
        public Task<HttpResponseMessage> Put(int id, [FromBody]dynamic body)
        {

            var response = new HttpResponseMessage();
            try
            {
                var command = new UpdateEvolucaoTreinoCommand(
                    evolucaoTreinoId: (int)body.id,
                    repeticao: (int)body.repeticao,
                    carga: (int)body.carga
                    //aumentoTreino: (DateTime)body.aumento
                );

                var evolucao = _service.Update(command);
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