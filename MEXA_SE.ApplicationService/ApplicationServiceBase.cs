using MEXA_SE.Infra.Presistence;
using MEXA_SE.SharedKernel;
using MEXA_SE.SharedKernel.Events;

namespace MEXA_SE.ApplicationService
{
    public class ApplicationServiceBase
    {
        private IUnitOfWork _unitOfWork;
        private IHandler<DomainNotification> _notification;

        public ApplicationServiceBase(IUnitOfWork uof)
        {
            this._unitOfWork = uof;
            this._notification = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
        }

        public bool Commit()
        {
            if (_notification.HasNotifications())
            {
                return false;
            }

            _unitOfWork.Commit();
            return true;
        }
    }
}
