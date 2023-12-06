namespace DoAn_QLCF_cs_WinForm.View
{
	partial class BanHangView
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
			titleBar = new CustomControl.SidePanel();
			customButton4 = new CustomControl.CustomButton();
			customButton3 = new CustomControl.CustomButton();
			customButton2 = new CustomControl.CustomButton();
			accountIcon = new CustomControl.CustomButton();
			gioHangBtn = new CustomControl.CustomButton();
			hoaDonBtn = new CustomControl.CustomButton();
			titleBar.SuspendLayout();
			SuspendLayout();
			// 
			// titleBar
			// 
			titleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			titleBar.BackColor = Color.DarkSlateGray;
			titleBar.BorderRadius = 15;
			titleBar.Controls.Add(hoaDonBtn);
			titleBar.Controls.Add(gioHangBtn);
			titleBar.Controls.Add(customButton4);
			titleBar.Controls.Add(customButton3);
			titleBar.Controls.Add(customButton2);
			titleBar.Controls.Add(accountIcon);
			titleBar.EnabledGradient = false;
			titleBar.GradientAngle = 45F;
			titleBar.GradientBottomColor = Color.DarkSlateGray;
			titleBar.GradientTopColor = Color.Teal;
			titleBar.Location = new Point(12, 12);
			titleBar.Name = "titleBar";
			titleBar.Padding = new Padding(10, 5, 15, 5);
			titleBar.Size = new Size(847, 50);
			titleBar.TabIndex = 1;
			// 
			// customButton4
			// 
			customButton4.Anchor = AnchorStyles.Right;
			customButton4.BackColor = Color.Transparent;
			customButton4.BackgroundColor = Color.Transparent;
			customButton4.BorderColor = Color.Teal;
			customButton4.BorderRadius = 20;
			customButton4.BorderSize = 0;
			customButton4.Cursor = Cursors.Hand;
			customButton4.EnabledTextHover = false;
			customButton4.FlatAppearance.BorderSize = 0;
			customButton4.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			customButton4.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			customButton4.FlatStyle = FlatStyle.Flat;
			customButton4.ForeColor = Color.White;
			customButton4.Image = Properties.Resources.TaskIcon;
			customButton4.ImageHover = null;
			customButton4.Location = new Point(1004, -20);
			customButton4.Margin = new Padding(3, 3, 20, 3);
			customButton4.Name = "customButton4";
			customButton4.Size = new Size(53, 40);
			customButton4.TabIndex = 4;
			customButton4.TextColor = Color.White;
			customButton4.TextHover = Color.White;
			customButton4.UseVisualStyleBackColor = false;
			// 
			// customButton3
			// 
			customButton3.Anchor = AnchorStyles.Right;
			customButton3.BackColor = Color.Transparent;
			customButton3.BackgroundColor = Color.Transparent;
			customButton3.BorderColor = Color.Teal;
			customButton3.BorderRadius = 20;
			customButton3.BorderSize = 0;
			customButton3.Cursor = Cursors.Hand;
			customButton3.EnabledTextHover = false;
			customButton3.FlatAppearance.BorderSize = 0;
			customButton3.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			customButton3.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			customButton3.FlatStyle = FlatStyle.Flat;
			customButton3.ForeColor = Color.White;
			customButton3.Image = Properties.Resources.emailIcon;
			customButton3.ImageHover = null;
			customButton3.Location = new Point(1078, -20);
			customButton3.Name = "customButton3";
			customButton3.Size = new Size(53, 40);
			customButton3.TabIndex = 3;
			customButton3.TextColor = Color.White;
			customButton3.TextHover = Color.White;
			customButton3.UseVisualStyleBackColor = false;
			// 
			// customButton2
			// 
			customButton2.Anchor = AnchorStyles.Right;
			customButton2.BackColor = Color.Transparent;
			customButton2.BackgroundColor = Color.Transparent;
			customButton2.BorderColor = Color.Teal;
			customButton2.BorderRadius = 20;
			customButton2.BorderSize = 0;
			customButton2.Cursor = Cursors.Hand;
			customButton2.EnabledTextHover = false;
			customButton2.FlatAppearance.BorderSize = 0;
			customButton2.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			customButton2.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			customButton2.FlatStyle = FlatStyle.Flat;
			customButton2.ForeColor = Color.White;
			customButton2.Image = Properties.Resources.notificationIcon;
			customButton2.ImageHover = null;
			customButton2.Location = new Point(1152, -20);
			customButton2.Name = "customButton2";
			customButton2.Size = new Size(53, 40);
			customButton2.TabIndex = 2;
			customButton2.TextColor = Color.White;
			customButton2.TextHover = Color.White;
			customButton2.UseVisualStyleBackColor = false;
			// 
			// accountIcon
			// 
			accountIcon.BackColor = Color.OrangeRed;
			accountIcon.BackgroundColor = Color.OrangeRed;
			accountIcon.BorderColor = Color.Teal;
			accountIcon.BorderRadius = 20;
			accountIcon.BorderSize = 0;
			accountIcon.Cursor = Cursors.Hand;
			accountIcon.Dock = DockStyle.Right;
			accountIcon.EnabledTextHover = false;
			accountIcon.FlatAppearance.BorderSize = 0;
			accountIcon.FlatAppearance.MouseDownBackColor = Color.OrangeRed;
			accountIcon.FlatAppearance.MouseOverBackColor = Color.Coral;
			accountIcon.FlatStyle = FlatStyle.Flat;
			accountIcon.ForeColor = Color.White;
			accountIcon.Image = Properties.Resources.usericon;
			accountIcon.ImageHover = null;
			accountIcon.Location = new Point(779, 5);
			accountIcon.Name = "accountIcon";
			accountIcon.Size = new Size(53, 40);
			accountIcon.TabIndex = 1;
			accountIcon.TextColor = Color.White;
			accountIcon.TextHover = Color.White;
			accountIcon.UseVisualStyleBackColor = false;
			// 
			// gioHangBtn
			// 
			gioHangBtn.Anchor = AnchorStyles.Right;
			gioHangBtn.BackColor = Color.Transparent;
			gioHangBtn.BackgroundColor = Color.Transparent;
			gioHangBtn.BorderColor = Color.Teal;
			gioHangBtn.BorderRadius = 20;
			gioHangBtn.BorderSize = 0;
			gioHangBtn.Cursor = Cursors.Hand;
			gioHangBtn.EnabledTextHover = false;
			gioHangBtn.FlatAppearance.BorderSize = 0;
			gioHangBtn.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			gioHangBtn.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			gioHangBtn.FlatStyle = FlatStyle.Flat;
			gioHangBtn.ForeColor = Color.White;
			gioHangBtn.Image = Properties.Resources.shopping_cart;
			gioHangBtn.ImageHover = null;
			gioHangBtn.Location = new Point(692, 5);
			gioHangBtn.Name = "gioHangBtn";
			gioHangBtn.Size = new Size(53, 40);
			gioHangBtn.TabIndex = 5;
			gioHangBtn.TextColor = Color.White;
			gioHangBtn.TextHover = Color.White;
			gioHangBtn.UseVisualStyleBackColor = false;
			// 
			// hoaDonBtn
			// 
			hoaDonBtn.Anchor = AnchorStyles.Right;
			hoaDonBtn.BackColor = Color.Transparent;
			hoaDonBtn.BackgroundColor = Color.Transparent;
			hoaDonBtn.BorderColor = Color.Teal;
			hoaDonBtn.BorderRadius = 20;
			hoaDonBtn.BorderSize = 0;
			hoaDonBtn.Cursor = Cursors.Hand;
			hoaDonBtn.EnabledTextHover = false;
			hoaDonBtn.FlatAppearance.BorderSize = 0;
			hoaDonBtn.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			hoaDonBtn.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			hoaDonBtn.FlatStyle = FlatStyle.Flat;
			hoaDonBtn.ForeColor = Color.White;
			hoaDonBtn.Image = Properties.Resources.invoice_khachhang;
			hoaDonBtn.ImageHover = null;
			hoaDonBtn.Location = new Point(605, 5);
			hoaDonBtn.Name = "hoaDonBtn";
			hoaDonBtn.Size = new Size(53, 40);
			hoaDonBtn.TabIndex = 5;
			hoaDonBtn.TextColor = Color.White;
			hoaDonBtn.TextHover = Color.White;
			hoaDonBtn.UseVisualStyleBackColor = false;
			// 
			// BanHangView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(871, 509);
			Controls.Add(titleBar);
			Name = "BanHangView";
			Text = "BanHangView";
			titleBar.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private CustomControl.SidePanel titleBar;
		private CustomControl.CustomButton customButton4;
		private CustomControl.CustomButton customButton3;
		private CustomControl.CustomButton customButton2;
		private CustomControl.CustomButton accountIcon;
		private CustomControl.CustomButton gioHangBtn;
		private CustomControl.CustomButton hoaDonBtn;
	}
}