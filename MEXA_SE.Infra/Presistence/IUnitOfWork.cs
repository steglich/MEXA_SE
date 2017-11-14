using System;

namespace MEXA_SE.Infra.Presistence
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
