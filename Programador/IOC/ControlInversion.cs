using Autofac;
namespace Programador.IOC
{
	public static class ControlInversion
	{
		public static IContainer ConfigureContainer()
		{
			var builder = new ContainerBuilder();

			// Registra tus clases e interfaces aquí
			//builder.RegisterType<YourRepository>().As<IYourRepository>();

			// Crea el contenedor
			var container = builder.Build();

			return container;
		}
	}
}
