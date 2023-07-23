using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

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
		[EnumDataType(typeof(Frecuency))]
		public string Frecuency { get; set; }

		[NotMapped]
		public Frecuency FrecuencyEnum
		{
			get => Enum.Parse<Frecuency>(Frecuency);
			set => Frecuency = value.ToString();
		}

		[Column("dias")]
		public string Days { get; set; }

		[NotMapped]
		public List<Days> DaysList
		{
			get => string.IsNullOrEmpty(Days) ? new List<Days>() : Days.Split(",").Select(x => (Days)Enum.Parse(typeof(Days), x)).ToList();
			set => Days = value != null ? string.Join(",", value.Select(d => d.ToString())) : null;
		}

		[Column("fecha_inicio")]
		public DateTime StartDate { get; set; }

		[Column("fecha_fin")]
		public DateTime EndDate { get; set; }
	}
}
