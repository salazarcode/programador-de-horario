using Domain.Entities;

namespace Domain.DTO
{
	public class ScheduleRowDTO
	{
		public string Concepto { get; set; }
		public string Frecuencia { get; set; }

		public string FechaInicio { get; set; }

		public string FechaFin { get; set; }

	}
}
