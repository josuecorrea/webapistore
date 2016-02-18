using System;

namespace CWWebStore.Infra.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}