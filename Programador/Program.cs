using Programador.IOC;
using System.Globalization;

namespace Programador
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var container = ControlInversion.ConfigureContainer();

			ApplicationConfiguration.Initialize();
			var initialForm = new Selector(container);
			Application.Run(initialForm);
		}
	}
}