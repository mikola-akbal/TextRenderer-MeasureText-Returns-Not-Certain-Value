namespace TextRenderer_MeasureText_Returns_Not_Certain_Value
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();




			var
			Row =
			dataGridView1.Rows[dataGridView1.Rows.Add()];




			var
			Cell =
			Row.Cells[0];




			const
			string
			Text =
			"01234567890123456789012345678901234567890123456789";




			Cell.Value = Text;

			textBox1.Text += $"Text = {Text}\r\n";
			textBox1.Text += $"Text.Length = {Text.Length}\r\n";




			var
			Text_Size =
			TextRenderer.MeasureText
			(
				text: Text,
				font: Cell.Style.Font
			);

			textBox1.Text += $"Text_Size = {Text_Size}\r\n";




			dataGridView1.Columns[0].Width =
			Text_Size.Width;
		}
	}
}
