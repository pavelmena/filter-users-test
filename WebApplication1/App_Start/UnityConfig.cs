using Data;
using Data.Repositories;
using Data.Repositories.Implementations;
using Services;
using Services.Implementations;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace WebApplication1
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IClientService, ClientService>();
            container.RegisterType<IClientRepository, ClientRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}