﻿using CWWebStore.ApplicationService;
using CWWebStore.Domain.Repositories;
using CWWebStore.Domain.Services;
using CWWebStore.Infra.Persistence;
using CWWebStore.Infra.Persistence.DataContext;
using CWWebStore.Infra.Repositories;
using CWWebStoreSharedKernel;
using CWWebStoreSharedKernel.Events;
using Microsoft.Practices.Unity;

namespace CWWebStore.CrossCutting
{
    public class DependencyRegister
    {
        /// <summary>
        /// TransientLifetimeManager - Cada Resolve gera uma nova instância.
        /// ContainerControlledLifetimeManager - Utiliza Singleton
        /// </summary>
        /// <param name="container"></param>
        public static void Register(UnityContainer container)
        {
            container.RegisterType<StoreDataContext, StoreDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ICategoryRepository, CategoryRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IProductRepository, ProductRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IOrderRepository, OrderRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<IUserApplicationService, UserApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<ICategoryApplicationService, CategoryApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IProductApplicationService, ProductApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IOrderApplicationService, OrderApplicationService>(new HierarchicalLifetimeManager());

            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());
        }
    }
}