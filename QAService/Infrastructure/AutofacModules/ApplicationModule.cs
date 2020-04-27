using Autofac;
using iPas.Infrastructure.EventBus.Abstractions;
using QAService.Grpc;
using QAService.Infrastructure.Repositories;
using QAService.IntegrationEvents.EventHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace QAService.Infrastructure.AutofacModules
{
    public class ApplicationModule : Autofac.Module
    {
        public string QueriesConnectionString { get; }
        public string GRPCClientURL { get;}
        public string GRPCRegistrationURL { get; }
        public string ModuleName { get; }

        public ApplicationModule(string qconstr, string clientURL, string registrationURL, string moduleName)
        {
            QueriesConnectionString = qconstr;
            GRPCClientURL = clientURL;
            GRPCRegistrationURL = registrationURL;
            ModuleName = moduleName;
        }

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<RuleExecutionRepository>()
                .As<IRuleExecutionRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(RegistrationReceivedIntegrationEventHandler).GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(IIntegrationEventHandler<>));

            builder.Register(c => new ClientGRPCClientService(GRPCClientURL,ModuleName))
                .As<IClientGRPCClientService>()
                .InstancePerLifetimeScope();

            builder.Register(c => new RegistrationGRPCClientService(GRPCRegistrationURL))
                .As<IRegistrationGRPCClientService>()
                .InstancePerLifetimeScope();

        }
    }
}
