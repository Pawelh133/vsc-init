using Autofac;
using Autofac.Extensions.DependencyInjection;
using OpenCrm.Framework.Dependency;

public static class AutofacConfig {
  public static ContainerBuilder Register(ContainerBuilder containerBuilder) {
    //register all classes which inherited by IDependency & ISingletonDependency
    containerBuilder = AutofacBuilderProvider.CreateBuilder(containerBuilder);

    return containerBuilder;
  }
}
