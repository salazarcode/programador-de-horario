using Autofac;
using Domain.Contracts.Repositories;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Programador
{
	public partial class Selector : Form
	{
		private readonly DataTable dt;
		private readonly bool semanal = true;
		private readonly IContainer _container;
		private readonly IScheduleRepository scheduleRepository;
		public Selector(IContainer container)
		{
			_container = container;
			scheduleRepository = _container.Resolve<IScheduleRepository>();
			var schedues = scheduleRepository.Get().ToList();
			InitializeComponent();

			dt = new DataTable();
			dt.DefaultView.AllowEdit = false;
		}

		private void Selector_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = RenderDataTable(dateTimePicker1.Value, semanal);
		}

		private DataTable RenderDataTable(DateTime date, bool IsWeekly = true)
		{ 
			var res = new DataTable();

			var fecha = dateTimePicker1.Value;

			var dias = semanal ? ObtenerDiasSemana(fecha) : ObtenerDiasMes(fecha);

			dt.Columns.Add("Concepto", typeof(string));

			for (int i = 1; i <= dias.Length; i++)
			{
				var dayString = dias[i - 1].ToString("dddd").ToUpper().Substring(0, 3);
				var dayDigits = dias[i - 1].ToString("dd");
				res.Columns.Add($"{dayString}  {dayDigits}");
			}

			return res;
		}
		public static DateTime[] ObtenerDiasSemana(DateTime fecha)
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

		public static DateTime[] ObtenerDiasMes(DateTime fecha)
		{
			int totalDiasMes = DateTime.DaysInMonth(fecha.Year, fecha.Month);
			DateTime[] diasMes = new DateTime[totalDiasMes];

			for (int i = 0; i < totalDiasMes; i++)
			{
				diasMes[i] = new DateTime(fecha.Year, fecha.Month, i + 1);
			}

			return diasMes;
		}

		private void rbFrecuenciaSemanal_CheckedChanged(object sender, EventArgs e)
		{
			if (rbFrecuenciaSemanal.Checked)
			{
				rbFrecuenciaMensual.Checked = false;
			}
			else
			{
				rbFrecuenciaMensual.Checked = true;
			}
		}
	}
}
