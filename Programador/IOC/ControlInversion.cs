using Autofac;
using Domain.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using Repository;
using System.Configuration;

namespace Programador.IOC
{
    public static class ControlInversion
	{
		public static IContainer ConfigureContainer()
		{
			var builder = new ContainerBuilder();

			builder.RegisterType<ScheduleRepository>().As<IScheduleRepository>();

			var connectionString = ConfigurationManager.ConnectionStrings["sqlite"].ConnectionString;

			builder.Register(c => new DbContextOptionsBuilder<DatabaseContext>()
			    .UseSqlite(connectionString)
			    .Options)
			    .SingleInstance();

			builder.RegisterType<DatabaseContext>().InstancePerLifetimeScope();

			var container = builder.Build();

			return container;
		}
	}
}
