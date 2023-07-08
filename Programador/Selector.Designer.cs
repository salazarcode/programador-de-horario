namespace Programador
{
	partial class Selector
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dateTimePicker1 = new DateTimePicker();
			rbFrecuenciaSemanal = new RadioButton();
			rbFrecuenciaMensual = new RadioButton();
			dataGridView1 = new DataGridView();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(10, 9);
			dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(219, 23);
			dateTimePicker1.TabIndex = 0;
			// 
			// rbFrecuenciaSemanal
			// 
			rbFrecuenciaSemanal.AutoSize = true;
			rbFrecuenciaSemanal.Checked = true;
			rbFrecuenciaSemanal.Location = new Point(261, 9);
			rbFrecuenciaSemanal.Margin = new Padding(3, 2, 3, 2);
			rbFrecuenciaSemanal.Name = "rbFrecuenciaSemanal";
			rbFrecuenciaSemanal.Size = new Size(70, 19);
			rbFrecuenciaSemanal.TabIndex = 1;
			rbFrecuenciaSemanal.TabStop = true;
			rbFrecuenciaSemanal.Text = "Semanal";
			rbFrecuenciaSemanal.UseVisualStyleBackColor = true;
			rbFrecuenciaSemanal.CheckedChanged += rbFrecuenciaSemanal_CheckedChanged;
			// 
			// rbFrecuenciaMensual
			// 
			rbFrecuenciaMensual.AutoSize = true;
			rbFrecuenciaMensual.Location = new Point(368, 9);
			rbFrecuenciaMensual.Margin = new Padding(3, 2, 3, 2);
			rbFrecuenciaMensual.Name = "rbFrecuenciaMensual";
			rbFrecuenciaMensual.Size = new Size(70, 19);
			rbFrecuenciaMensual.TabIndex = 2;
			rbFrecuenciaMensual.Text = "Mensual";
			rbFrecuenciaMensual.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Bottom;
			dataGridView1.Location = new Point(0, 49);
			dataGridView1.Margin = new Padding(3, 2, 3, 2);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(887, 340);
			dataGridView1.TabIndex = 3;
			// 
			// button1
			// 
			button1.Location = new Point(736, 8);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new Size(141, 25);
			button1.TabIndex = 4;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			// 
			// Selector
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(887, 389);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Controls.Add(rbFrecuenciaMensual);
			Controls.Add(rbFrecuenciaSemanal);
			Controls.Add(dateTimePicker1);
			Margin = new Padding(3, 2, 3, 2);
			Name = "Selector";
			Text = "Selector";
			Load += Selector_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dateTimePicker1;
		private RadioButton rbFrecuenciaSemanal;
		private RadioButton rbFrecuenciaMensual;
		private DataGridView dataGridView1;
		private Button button1;
	}
}