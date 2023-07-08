using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programador
{
	public partial class Selector : Form
	{
		private readonly DataTable dt;
		private readonly bool semanal = true;
		private readonly IContainer _container;
		public Selector(IContainer container)
		{
			_container = container;
			InitializeComponent();

			dt = new DataTable();
			dt.DefaultView.AllowEdit = false;
		}

		private void Selector_Load(object sender, EventArgs e)
		{
			var hoy = dateTimePicker1.Value;

			var dias = semanal ? ObtenerDiasSemana(hoy) : ObtenerDiasMes(hoy);

			dt.Columns.Add("Concepto", typeof(string));

			for (int i = 1; i <= dias.Length; i++)
			{
				dt.Columns.Add(dias[i - 1].ToString("dddd").ToUpper().Substring(0, 3) + " " + dias[i - 1].ToString("dd"), typeof(bool));
			}

			dt.Rows.Add("Quirofano 1");
			dt.Rows.Add("Quirofano 2");

			dataGridView1.DataSource = dt;
		}

		private DataTable RenderDataTable(DateTime date, bool IsWeekly = true)
		{ 
			var res = new DataTable();

			var fecha = dateTimePicker1.Value;

			var dias = semanal ? ObtenerDiasSemana(fecha) : ObtenerDiasMes(fecha);

			dt.Columns.Add("Concepto", typeof(string));

			for (int i = 1; i <= dias.Length; i++)
			{
				var day = 
				res.Columns.Add(dias[i - 1].ToString("dddd").ToUpper().Substring(0, 3) + " " + dias[i - 1].ToString("dd"), typeof(bool));
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
