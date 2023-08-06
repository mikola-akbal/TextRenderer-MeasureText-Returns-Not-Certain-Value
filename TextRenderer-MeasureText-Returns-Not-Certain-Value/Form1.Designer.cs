namespace TextRenderer_MeasureText_Returns_Not_Certain_Value
{
	partial class Form1
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
			dataGridView1 = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			textBox1 = new TextBox();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = SystemColors.Window;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
			dataGridView1.Location = new Point(12, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(809, 100);
			dataGridView1.TabIndex = 2;
			// 
			// Column1
			// 
			Column1.HeaderText = "Column1";
			Column1.Name = "Column1";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 179);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.ReadOnly = true;
			textBox1.Size = new Size(809, 129);
			textBox1.TabIndex = 3;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(9F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(833, 322);
			Controls.Add(textBox1);
			Controls.Add(dataGridView1);
			Font = new Font("Courier New", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			Margin = new Padding(4, 3, 4, 3);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Column1;
		private TextBox textBox1;
	}
}