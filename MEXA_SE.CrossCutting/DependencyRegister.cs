using MEXA_SE.Domain.Repositories;
using MEXA_SE.Domain.Services;
using MEXA_SE.Infra.Presistence;
using MEXA_SE.Infra.Presistence.DataContexts;
using MEXA_SE.SharedKernel;
using MEXA_SE.SharedKernel.Events;
using Unity;
using Unity.Lifetime;

namespace MEXA_SE.CrossCutting
{
    public static class DependencyRegister
    {
        /// <param name="conatiner"></param>
        public static void Register(UnityContainer container)
        {
            container.RegisterType<DataContext, DataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, IUnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<IAtividadeDiaRepository, IAtividadeDiaRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IAvaliacaoRepository, IAvaliacaoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IEvolucaoTreinoRepository, IEvolucaoTreinoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IExercicioRepository, IExercicioRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IFichaRepository, IFichaRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ITreinoRepository, ITreinoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IUsuarioRepository, IUsuarioRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IUsuarioTreinoRepository, IUsuarioTreinoRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<IUsuarioApplicationService, IUsuarioApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IAtividadeDiaApplicationService, IAtividadeDiaApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IAvaliacaoApplicationService, IAvaliacaoApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IEvolucaoTreinoApplicationService, IEvolucaoTreinoApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IExercicioApplicationService, IExercicioApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IFichaApplicationService, IFichaApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<ITreinoApplicationService, ITreinoApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IUsuarioTreinoApplicationService, IUsuarioTreinoApplicationService>(new HierarchicalLifetimeManager());

            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());

        }
    }
}
