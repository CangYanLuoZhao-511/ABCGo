using ABCGo.Core.Interfaces;
using ABCGo.Core.Services;
using Autofac;

namespace ABCGo.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}
