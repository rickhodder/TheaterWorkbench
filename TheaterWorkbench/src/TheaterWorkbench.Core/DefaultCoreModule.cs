using Autofac;
using TheaterWorkbench.Core.Interfaces;
using TheaterWorkbench.Core.Services;

namespace TheaterWorkbench.Core
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