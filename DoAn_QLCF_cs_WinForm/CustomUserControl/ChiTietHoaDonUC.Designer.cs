namespace DoAn_QLCF_cs_WinForm.CustomUserControl
{
	partial class ChiTietHoaDonUC
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
			pictureBox1 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			customButton1 = new CustomControl.CustomButton();
			label3 = new Label();
			label4 = new Label();
			customButton2 = new CustomControl.CustomButton();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Dock = DockStyle.Left;
			pictureBox1.Image = Properties.Resources.CaPheEspresso;
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(129, 97);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(135, 10);
			label1.Name = "label1";
			label1.Size = new Size(195, 25);
			label1.TabIndex = 1;
			label1.Text = "Cà phê truyền thống";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.Red;
			label2.Location = new Point(135, 59);
			label2.Name = "label2";
			label2.Size = new Size(55, 21);
			label2.TabIndex = 2;
			label2.Text = "12000";
			// 
			// customButton1
			// 
			customButton1.BackColor = Color.MediumSlateBlue;
			customButton1.BackgroundColor = Color.MediumSlateBlue;
			customButton1.BorderColor = Color.PaleVioletRed;
			customButton1.BorderRadius = 15;
			customButton1.BorderSize = 0;
			customButton1.Cursor = Cursors.Hand;
			customButton1.EnabledTextHover = false;
			customButton1.FlatAppearance.BorderSize = 0;
			customButton1.FlatAppearance.MouseDownBackColor = Color.SlateBlue;
			customButton1.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
			customButton1.FlatStyle = FlatStyle.Flat;
			customButton1.ForeColor = Color.White;
			customButton1.Image = Properties.Resources.bin_24px;
			customButton1.ImageHover = null;
			customButton1.Location = new Point(405, 3);
			customButton1.Name = "customButton1";
			customButton1.Size = new Size(39, 32);
			customButton1.TabIndex = 3;
			customButton1.TextColor = Color.White;
			customButton1.TextHover = Color.White;
			customButton1.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.Red;
			label3.Location = new Point(190, 55);
			label3.Name = "label3";
			label3.Size = new Size(20, 21);
			label3.TabIndex = 2;
			label3.Text = "đ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = SystemColors.Control;
			label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.Red;
			label4.Location = new Point(376, 61);
			label4.Name = "label4";
			label4.Size = new Size(32, 25);
			label4.TabIndex = 2;
			label4.Text = "12";
			// 
			// customButton2
			// 
			customButton2.BackColor = SystemColors.GradientInactiveCaption;
			customButton2.BackgroundColor = SystemColors.GradientInactiveCaption;
			customButton2.BorderColor = Color.PaleVioletRed;
			customButton2.BorderRadius = 15;
			customButton2.BorderSize = 0;
			customButton2.Cursor = Cursors.Hand;
			customButton2.EnabledTextHover = false;
			customButton2.FlatAppearance.BorderSize = 0;
			customButton2.FlatAppearance.MouseDownBackColor = Color.SlateBlue;
			customButton2.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
			customButton2.FlatStyle = FlatStyle.Flat;
			customButton2.ForeColor = Color.White;
			customButton2.Image = Properties.Resources.bin_24px;
			customButton2.ImageHover = null;
			customButton2.Location = new Point(405, 55);
			customButton2.Name = "customButton2";
			customButton2.Size = new Size(39, 31);
			customButton2.TabIndex = 3;
			customButton2.TextColor = Color.White;
			customButton2.TextHover = Color.White;
			customButton2.UseVisualStyleBackColor = false;
			// 
			// ChiTietHoaDonUC
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			Controls.Add(customButton2);
			Controls.Add(customButton1);
			Controls.Add(label3);
			Controls.Add(label4);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Name = "ChiTietHoaDonUC";
			Size = new Size(447, 97);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private CustomControl.CustomButton customButton1;
		private Label label3;
		private Label label4;
		private CustomControl.CustomButton customButton2;
	}
}
