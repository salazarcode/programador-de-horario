using Programador.IOC;

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
			var initialForm = new MainForm(container);
			Application.Run(initialForm);
		}
	}
}