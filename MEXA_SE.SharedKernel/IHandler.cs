using MEXA_SE.SharedKernel.Events.Contracts;
using System;
using System.Collections.Generic;

namespace MEXA_SE.SharedKernel
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handler(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}
