using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Autofac;

namespace OpenCrm.Framework.Dependency
{
    public static class AutofacBuilderProvider
    {
        public static ContainerBuilder CreateBuilder(ContainerBuilder builder)
        {
            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
            var loadedPaths = loadedAssemblies.Where(n => !n.IsDynamic).Select(a => a.Location).ToArray();

            var referencedPaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll");
            var toLoad = referencedPaths.Where(r => !loadedPaths.Contains(r, StringComparer.InvariantCultureIgnoreCase)).ToList();
            toLoad.ForEach(path => loadedAssemblies.Add(AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(path))));

            Assembly.Load(Assembly.GetExecutingAssembly().FullName);

            var assembliesList = loadedAssemblies.ToArray();

            builder
                .RegisterAssemblyTypes(assembliesList)
                .AssignableTo<IDependency>()
                .AsImplementedInterfaces()
                .InstancePerDependency();

            builder
                .RegisterAssemblyTypes(assembliesList)
                .AssignableTo<ISingletonDependency>()
                .AsImplementedInterfaces()
                .SingleInstance();

            return builder;
        }
    }
}
