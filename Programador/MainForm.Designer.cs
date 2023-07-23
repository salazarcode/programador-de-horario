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
			txtConcepto = new TextBox();
			label1 = new Label();
			label2 = new Label();
			cbFrecuencia = new ComboBox();
			label3 = new Label();
			label4 = new Label();
			dtInicio = new DateTimePicker();
			dtFin = new DateTimePicker();
			ckDias = new CheckedListBox();
			label5 = new Label();
			label6 = new Label();
			btnSave = new Button();
			btnClear = new Button();
			textBox2 = new TextBox();
			dataGridView1 = new DataGridView();
			label7 = new Label();
			txtID = new TextBox();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// txtConcepto
			// 
			txtConcepto.Location = new Point(104, 95);
			txtConcepto.Margin = new Padding(3, 4, 3, 4);
			txtConcepto.Name = "txtConcepto";
			txtConcepto.Size = new Size(292, 27);
			txtConcepto.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 95);
			label1.Name = "label1";
			label1.Size = new Size(73, 20);
			label1.TabIndex = 1;
			label1.Text = "Concepto";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 130);
			label2.Name = "label2";
			label2.Size = new Size(79, 20);
			label2.TabIndex = 2;
			label2.Text = "Frecuencia";
			// 
			// cbFrecuencia
			// 
			cbFrecuencia.FormattingEnabled = true;
			cbFrecuencia.Items.AddRange(new object[] { "Semanal", "Quincenal", "Mensual" });
			cbFrecuencia.Location = new Point(105, 130);
			cbFrecuencia.Margin = new Padding(3, 4, 3, 4);
			cbFrecuencia.Name = "cbFrecuencia";
			cbFrecuencia.Size = new Size(292, 28);
			cbFrecuencia.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 166);
			label3.Name = "label3";
			label3.Size = new Size(45, 20);
			label3.TabIndex = 4;
			label3.Text = "Inicio";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 201);
			label4.Name = "label4";
			label4.Size = new Size(28, 20);
			label4.TabIndex = 5;
			label4.Text = "Fin";
			// 
			// dtInicio
			// 
			dtInicio.Location = new Point(105, 166);
			dtInicio.Margin = new Padding(3, 4, 3, 4);
			dtInicio.Name = "dtInicio";
			dtInicio.Size = new Size(292, 27);
			dtInicio.TabIndex = 6;
			// 
			// dtFin
			// 
			dtFin.Location = new Point(104, 201);
			dtFin.Margin = new Padding(3, 4, 3, 4);
			dtFin.Name = "dtFin";
			dtFin.Size = new Size(292, 27);
			dtFin.TabIndex = 7;
			// 
			// ckDias
			// 
			ckDias.FormattingEnabled = true;
			ckDias.Location = new Point(104, 236);
			ckDias.Margin = new Padding(3, 4, 3, 4);
			ckDias.Name = "ckDias";
			ckDias.Size = new Size(292, 158);
			ckDias.TabIndex = 8;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(13, 236);
			label5.Name = "label5";
			label5.Size = new Size(38, 20);
			label5.TabIndex = 9;
			label5.Text = "Días";
			label5.Click += label5_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(12, 15);
			label6.Name = "label6";
			label6.Size = new Size(97, 20);
			label6.TabIndex = 10;
			label6.Text = "Programador";
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.FromArgb(0, 192, 0);
			btnSave.Location = new Point(194, 402);
			btnSave.Margin = new Padding(3, 4, 3, 4);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(202, 38);
			btnSave.TabIndex = 13;
			btnSave.Text = "Guardar";
			btnSave.UseVisualStyleBackColor = false;
			btnSave.Click += button1_Click;
			// 
			// btnClear
			// 
			btnClear.BackColor = Color.FromArgb(255, 128, 0);
			btnClear.ForeColor = SystemColors.ActiveCaptionText;
			btnClear.Location = new Point(12, 402);
			btnClear.Margin = new Padding(3, 4, 3, 4);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(176, 38);
			btnClear.TabIndex = 14;
			btnClear.Text = "Limpiar";
			btnClear.UseVisualStyleBackColor = false;
			btnClear.Click += button2_Click;
			// 
			// textBox2
			// 
			textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox2.Location = new Point(403, 15);
			textBox2.Margin = new Padding(3, 4, 3, 4);
			textBox2.Name = "textBox2";
			textBox2.PlaceholderText = "Búsqueda...";
			textBox2.Size = new Size(687, 27);
			textBox2.TabIndex = 15;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(403, 60);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(687, 379);
			dataGridView1.TabIndex = 16;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(12, 60);
			label7.Name = "label7";
			label7.Size = new Size(24, 20);
			label7.TabIndex = 17;
			label7.Text = "ID";
			label7.Click += label7_Click_1;
			// 
			// txtID
			// 
			txtID.Enabled = false;
			txtID.Location = new Point(105, 60);
			txtID.Margin = new Padding(3, 4, 3, 4);
			txtID.Name = "txtID";
			txtID.Size = new Size(292, 27);
			txtID.TabIndex = 18;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1102, 452);
			Controls.Add(txtID);
			Controls.Add(label7);
			Controls.Add(dataGridView1);
			Controls.Add(textBox2);
			Controls.Add(btnClear);
			Controls.Add(btnSave);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(ckDias);
			Controls.Add(dtFin);
			Controls.Add(dtInicio);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(cbFrecuencia);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtConcepto);
			Margin = new Padding(3, 4, 3, 4);
			Name = "MainForm";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtConcepto;
		private Label label1;
		private Label label2;
		private ComboBox cbFrecuencia;
		private Label label3;
		private Label label4;
		private DateTimePicker dtInicio;
		private DateTimePicker dtFin;
		private CheckedListBox ckDias;
		private Label label5;
		private Label label6;
		private Button btnSave;
		private Button btnClear;
		private TextBox textBox2;
		private DataGridView dataGridView1;
		private Label label7;
		private TextBox txtID;
	}
}