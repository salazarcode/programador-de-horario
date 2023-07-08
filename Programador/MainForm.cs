using System.Windows.Forms;

namespace Programador
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			List<Persona> listaPersonas = new List<Persona>();
			listaPersonas.Add(new Persona { Nombre = "John Doe", Edad = 30, CorreoElectronico = "john.doe@example.com" });
			listaPersonas.Add(new Persona { Nombre = "Jane Smith", Edad = 25, CorreoElectronico = "jane.smith@example.com" });
			
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = listaPersonas;

			dataGridView1.AutoGenerateColumns = true;
			dataGridView1.DataSource = bindingSource;
		}

		//genera la clase publica persona
		public class Persona
		{
			public string Nombre { get; set; }
			public int Edad { get; set; }
			public string CorreoElectronico { get; set; }
		}
	}
}