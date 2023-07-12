using Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	[Table("schedules")]
	public class Schedule
	{
		[Key]
		public int Id { get; set; }

		[Column("concepto")]
		public string Concept { get; set; }

		[Column("frecuencia")]
		public Frecuency Frecuency { get; set; }

		[Column("fecha_inicio")]
		public DateTime StartDate { get; set; }

		[Column("fecha_fin")]
		public DateTime EndDate { get; set; }
	}
}
