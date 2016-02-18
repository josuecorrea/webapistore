using CWWebStoreSharedKernel.Events.Contracts;
using System;
using System.Collections.Generic;

namespace CWWebStoreSharedKernel
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);

        IEnumerable<T> Notify();

        bool HasNotifications();
    }
}