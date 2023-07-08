using System;
using System.Globalization;
using System.Threading;

namespace Tools
{
	public class DateTools
	{
		public DateTools()
		{
			CultureInfo culture = new CultureInfo("es-ES");

			Thread.CurrentThread.CurrentCulture = culture;
			Thread.CurrentThread.CurrentUICulture = culture;
		}
		private static DateTime[] ObtenerDiasSemana(DateTime fecha)
		{
			DateTime[] diasSemana = new DateTime[7];
			int diaSemana = (int)fecha.DayOfWeek;

			DateTime lunes = fecha.AddDays(-(diaSemana - 1));

			for (int i = 0; i < 7; i++)
			{
				diasSemana[i] = lunes.AddDays(i);
			}

			return diasSemana;
		}

		private static DateTime[] ObtenerDiasMes(DateTime fecha)
		{
			int totalDiasMes = DateTime.DaysInMonth(fecha.Year, fecha.Month);
			DateTime[] diasMes = new DateTime[totalDiasMes];

			for (int i = 0; i < totalDiasMes; i++)
			{
				diasMes[i] = new DateTime(fecha.Year, fecha.Month, i + 1);
			}

			return diasMes;
		}
		public static DateTime[] GetDays(DateTime fecha, bool semanal)
		{
			if (semanal)
			{
				return ObtenerDiasSemana(fecha);
			}
			else
			{
				return ObtenerDiasMes(fecha);
			}
		}
	}
}
