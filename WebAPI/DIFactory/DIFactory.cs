using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using WebAPI.Models.Attributes;
using WebAPI.Models.DAO;
using WebAPI.Models.Interfaces.DAO;

namespace WebAPI
{
    public static class DIFactory
    {
        public static IContainer Container { get; private set; }


        public static IServiceProvider AddAutofac(this IServiceCollection services, IHostingEnvironment env)
        {

            ContainerBuilder builder = new ContainerBuilder();//实例化 AutoFac  容器  

            builder.Populate(services);

            var assembly = AppDomain.CurrentDomain.GetAssemblies();


            //注册泛型
            //builder.RegisterGeneric(typeof(IMaintain<>))
            //       .As(typeof(IMaintain<>))
            //       .InstancePerLifetimeScope();

            //builder.RegisterType<Class_DAO>()
            //      .As<IClass_DAO>()
            //      .InstancePerLifetimeScope();


            builder.RegisterAssemblyTypes(assembly)
                   .Where(t => t.GetCustomAttribute<AutoInject>() != null)
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();




            Container = builder.Build();

            return new AutofacServiceProvider(Container);
        }


        public static void DisposeAutofac(this IApplicationLifetime appLifetime)
        {

            appLifetime.ApplicationStopped.Register(() => Container.Dispose());

        }


    }
}
