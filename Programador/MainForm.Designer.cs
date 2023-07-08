namespace Programador
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			comboBox1 = new ComboBox();
			label3 = new Label();
			label4 = new Label();
			dateTimePicker1 = new DateTimePicker();
			dateTimePicker2 = new DateTimePicker();
			checkedListBox1 = new CheckedListBox();
			label5 = new Label();
			label6 = new Label();
			button1 = new Button();
			button2 = new Button();
			textBox2 = new TextBox();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(135, 125);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(192, 23);
			textBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(53, 125);
			label1.Name = "label1";
			label1.Size = new Size(51, 15);
			label1.TabIndex = 1;
			label1.Text = "Nombre";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(53, 165);
			label2.Name = "label2";
			label2.Size = new Size(64, 15);
			label2.TabIndex = 2;
			label2.Text = "Frecuencia";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Semanal", "Quincenal", "Mensual" });
			comboBox1.Location = new Point(135, 165);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(192, 23);
			comboBox1.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(53, 221);
			label3.Name = "label3";
			label3.Size = new Size(36, 15);
			label3.TabIndex = 4;
			label3.Text = "Inicio";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(53, 263);
			label4.Name = "label4";
			label4.Size = new Size(23, 15);
			label4.TabIndex = 5;
			label4.Text = "Fin";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(135, 221);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(192, 23);
			dateTimePicker1.TabIndex = 6;
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Location = new Point(135, 263);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(192, 23);
			dateTimePicker2.TabIndex = 7;
			// 
			// checkedListBox1
			// 
			checkedListBox1.FormattingEnabled = true;
			checkedListBox1.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" });
			checkedListBox1.Location = new Point(135, 309);
			checkedListBox1.Name = "checkedListBox1";
			checkedListBox1.Size = new Size(192, 130);
			checkedListBox1.TabIndex = 8;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(53, 309);
			label5.Name = "label5";
			label5.Size = new Size(29, 15);
			label5.TabIndex = 9;
			label5.Text = "Días";
			label5.Click += label5_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(53, 62);
			label6.Name = "label6";
			label6.Size = new Size(77, 15);
			label6.TabIndex = 10;
			label6.Text = "Programador";
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(0, 192, 0);
			button1.Location = new Point(252, 463);
			button1.Name = "button1";
			button1.Size = new Size(75, 45);
			button1.TabIndex = 13;
			button1.Text = "Guardar";
			button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(255, 128, 0);
			button2.ForeColor = SystemColors.ActiveCaptionText;
			button2.Location = new Point(171, 463);
			button2.Name = "button2";
			button2.Size = new Size(75, 45);
			button2.TabIndex = 14;
			button2.Text = "Limpiar";
			button2.UseVisualStyleBackColor = false;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(375, 125);
			textBox2.Name = "textBox2";
			textBox2.PlaceholderText = "Búsqueda...";
			textBox2.Size = new Size(420, 23);
			textBox2.TabIndex = 15;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(375, 165);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(420, 274);
			dataGridView1.TabIndex = 16;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(870, 530);
			Controls.Add(dataGridView1);
			Controls.Add(textBox2);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(checkedListBox1);
			Controls.Add(dateTimePicker2);
			Controls.Add(dateTimePicker1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(comboBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label label1;
		private Label label2;
		private ComboBox comboBox1;
		private Label label3;
		private Label label4;
		private DateTimePicker dateTimePicker1;
		private DateTimePicker dateTimePicker2;
		private CheckedListBox checkedListBox1;
		private Label label5;
		private Label label6;
		private Button button1;
		private Button button2;
		private TextBox textBox2;
		private DataGridView dataGridView1;
	}
}