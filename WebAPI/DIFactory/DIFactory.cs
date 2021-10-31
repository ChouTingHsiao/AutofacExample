﻿using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using WebAPI.Core.Attributes;

namespace WebAPI
{
    public static class DIFactory
    {
        public static IContainer Container { get; private set; }

        public static IServiceProvider AddAutofac(this IServiceCollection services, IHostingEnvironment env)
        {
            ContainerBuilder builder = new ContainerBuilder();//实例化 AutoFac  容器  

            builder.Populate(services);

            var assembly = new Assembly[] { Assembly.Load("WebAPI.Core") };

            builder.RegisterAssemblyTypes(assembly)
                   .Where(t => t.GetCustomAttribute<AutoInjectAttribute>() != null)
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
