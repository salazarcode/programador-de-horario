using Autofac;
using Domain.Contracts.Repositories;
using Domain.Entities;
using Domain.Enums;
using System.Linq;

namespace Programador
{
	public partial class MainForm : Form
	{
		private readonly IScheduleRepository scheduleRepository;
		private Schedule SelectedSchedule = new Schedule();
		private List<Schedule> LoadedSchedules;
		public MainForm(IContainer _container)
		{
			InitializeComponent();
			scheduleRepository = _container.Resolve<IScheduleRepository>();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			RenderCheckBoxFromEnum<Days>(ckDias);

			LoadedSchedules = scheduleRepository.Get().ToList();

			RenderDataGridFromList<Schedule>(dataGridView1, LoadedSchedules);
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (SaveValidation() == false)
				return;

			LoadScheduleFromForm();
		}

		private bool SaveValidation()
		{
			List<string> missing = new List<string>();

			if (txtConcepto.Text == "")
				missing.Add("Concepto");

			if (cbFrecuencia.SelectedIndex == -1)
				missing.Add("Frecuencia");

			if (ckDias.CheckedItems.Count == 0)
				missing.Add("Días");

			if (missing.Count != 0)
			{
				MessageBox.Show($"Campos vacíos ({string.Join(", ", missing)})", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			else
			{
				return true;
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

			if (int.Parse(id) != SelectedSchedule.Id)
			{
				SelectedSchedule = LoadedSchedules.FirstOrDefault(x => x.Id == int.Parse(id));

				RenderFormFromSelectedSchedule();
			}
		}

		private void RenderFormFromSelectedSchedule()
		{
			txtID.Text = SelectedSchedule.Id.ToString();

			txtConcepto.Text = SelectedSchedule.Concept;

			cbFrecuencia.SelectedItem = char.ToUpper(SelectedSchedule.Frecuency.ToString()[0]) + SelectedSchedule.Frecuency.ToString().Substring(1).ToLower();

			dtInicio.Text = SelectedSchedule.StartDate.ToString();

			dtFin.Text = SelectedSchedule.EndDate.ToString();

			RenderCheckBoxFromStringArray(ckDias, SelectedSchedule.DaysList.Select(x => x.ToString()).ToArray());
		}

		private void LoadScheduleFromForm()
		{
			SelectedSchedule.Id = txtID.Text != "" ? int.Parse(txtID.Text) : 0;

			SelectedSchedule.Concept = txtConcepto.Text;

			SelectedSchedule.FrecuencyEnum = (Frecuency)cbFrecuencia.SelectedIndex;

			SelectedSchedule.StartDate = dtInicio.Value;

			SelectedSchedule.EndDate = dtFin.Value;

			var list = new List<Days>();

			foreach (var item in ckDias.CheckedIndices)
				list.Add((Days)item);

			SelectedSchedule.DaysList = list;
		}


		private void ClearCheckList(CheckedListBox checkedListBox)
		{
			for (int i = 0; i < checkedListBox.Items.Count; i++)
			{
				checkedListBox.SetItemChecked(i, false);
			}
		}

		private void RenderCheckBoxFromStringArray(CheckedListBox checkedListBox, string[] stringArr)
		{
			ClearCheckList(checkedListBox);

			foreach (var day in stringArr)
			{
				int index = checkedListBox.FindStringExact(day.ToString());
				if (index != ListBox.NoMatches)
				{
					checkedListBox.SetItemChecked(index, true);
				}
			}
		}


		private void RenderCheckBoxFromEnum<EnumType>(CheckedListBox checkedListBox)
		{
			EnumType[] enumValues = (EnumType[])Enum.GetValues(typeof(EnumType));

			foreach (var item in enumValues)
			{
				checkedListBox.Items.Add(item);
			}
		}
		private void RenderDataGridFromList<T>(DataGridView dtView, List<T> list)
		{
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = list;

			dtView.AutoGenerateColumns = true;
			dtView.DataSource = bindingSource;
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void label7_Click_1(object sender, EventArgs e)
		{

		}
	}
}