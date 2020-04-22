using Autofac;
using iPas.Infrastructure.EventBus.Abstractions;
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

        public ApplicationModule(string qconstr)
        {
            QueriesConnectionString = qconstr;

        }

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<RuleExecutionRepository>()
                .As<IRuleExecutionRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(RegistrationReceivedIntegrationEventHandler).GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(IIntegrationEventHandler<>));

        }
    }
}
