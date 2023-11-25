namespace DoAn_QLCF_cs_WinForm.CustomControl
{
	partial class CustomTextBox
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Dock = DockStyle.Fill;
			textBox1.Location = new Point(9, 7);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(234, 17);
			textBox1.TabIndex = 0;
			textBox1.Click += textBox1_Click;
			textBox1.TextChanged += textBox1_TextChanged;
			textBox1.Enter += textBox1_Enter;
			textBox1.KeyPress += textBox1_KeyPress;
			textBox1.Leave += textBox1_Leave;
			textBox1.MouseEnter += textBox1_MouseEnter;
			textBox1.MouseLeave += textBox1_MouseLeave;
			// 
			// CustomTextBox
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = SystemColors.Window;
			Controls.Add(textBox1);
			Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
			ForeColor = Color.DimGray;
			Name = "CustomTextBox";
			Padding = new Padding(9, 7, 7, 7);
			Size = new Size(250, 30);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
	}
}
