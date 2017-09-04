using Autofac;
using Autofac.Extensions.DependencyInjection;
using Core.DI;

namespace store.API.App_Start.autofac.config
{
  public static class AutofacConfig
  {
    public static ContainerBuilder Register(ContainerBuilder containerBuilder)
    {
      //register all classes which inherited by IDependency & ISingletonDependency
      containerBuilder = AutofacBuilderProvider.CreateBuilder(containerBuilder);

      return containerBuilder;
    }
  }
}
