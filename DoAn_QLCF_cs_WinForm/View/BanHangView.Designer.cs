﻿namespace DoAn_QLCF_cs_WinForm.View
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
			hoaDonBtn = new CustomControl.CustomButton();
			customButton4 = new CustomControl.CustomButton();
			customButton3 = new CustomControl.CustomButton();
			customButton2 = new CustomControl.CustomButton();
			accountIcon = new CustomControl.CustomButton();
			panel1 = new Panel();
			tabControl1 = new TabControl();
			trangChuTab = new TabPage();
			sidePanel2 = new CustomControl.SidePanel();
			sidePanel1 = new CustomControl.SidePanel();
			flowLayoutPanel1 = new FlowLayoutPanel();
			hoaDonTab = new TabPage();
			taiKhoanTab = new TabPage();
			sanPhamCaPheuc1 = new CustomUserControl.SanPhamCaPheUC();
			sanPhamCaPheuc2 = new CustomUserControl.SanPhamCaPheUC();
			sanPhamCaPheuc3 = new CustomUserControl.SanPhamCaPheUC();
			sanPhamCaPheuc4 = new CustomUserControl.SanPhamCaPheUC();
			titleBar.SuspendLayout();
			panel1.SuspendLayout();
			tabControl1.SuspendLayout();
			trangChuTab.SuspendLayout();
			sidePanel1.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// titleBar
			// 
			titleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			titleBar.BackColor = Color.DarkSlateGray;
			titleBar.BorderRadius = 15;
			titleBar.Controls.Add(hoaDonBtn);
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
			titleBar.Size = new Size(931, 55);
			titleBar.TabIndex = 1;
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
			hoaDonBtn.Location = new Point(772, 7);
			hoaDonBtn.Name = "hoaDonBtn";
			hoaDonBtn.Size = new Size(53, 40);
			hoaDonBtn.TabIndex = 5;
			hoaDonBtn.TextColor = Color.White;
			hoaDonBtn.TextHover = Color.White;
			hoaDonBtn.UseVisualStyleBackColor = false;
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
			customButton4.Location = new Point(1088, -18);
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
			customButton3.Location = new Point(1162, -18);
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
			customButton2.Location = new Point(1236, -18);
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
			accountIcon.Location = new Point(863, 5);
			accountIcon.Name = "accountIcon";
			accountIcon.Size = new Size(53, 45);
			accountIcon.TabIndex = 1;
			accountIcon.TextColor = Color.White;
			accountIcon.TextHover = Color.White;
			accountIcon.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel1.Controls.Add(tabControl1);
			panel1.Location = new Point(12, 73);
			panel1.Name = "panel1";
			panel1.Size = new Size(931, 468);
			panel1.TabIndex = 2;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(trangChuTab);
			tabControl1.Controls.Add(hoaDonTab);
			tabControl1.Controls.Add(taiKhoanTab);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(931, 468);
			tabControl1.TabIndex = 0;
			// 
			// trangChuTab
			// 
			trangChuTab.Controls.Add(sidePanel2);
			trangChuTab.Controls.Add(sidePanel1);
			trangChuTab.Location = new Point(4, 24);
			trangChuTab.Name = "trangChuTab";
			trangChuTab.Padding = new Padding(3);
			trangChuTab.Size = new Size(923, 440);
			trangChuTab.TabIndex = 0;
			trangChuTab.Text = "tabPage1";
			trangChuTab.UseVisualStyleBackColor = true;
			// 
			// sidePanel2
			// 
			sidePanel2.BackColor = SystemColors.ActiveCaption;
			sidePanel2.BorderRadius = 20;
			sidePanel2.Dock = DockStyle.Right;
			sidePanel2.EnabledGradient = false;
			sidePanel2.GradientAngle = 90F;
			sidePanel2.GradientBottomColor = Color.FromArgb(255, 51, 153);
			sidePanel2.GradientTopColor = Color.Teal;
			sidePanel2.Location = new Point(529, 3);
			sidePanel2.Name = "sidePanel2";
			sidePanel2.Size = new Size(391, 434);
			sidePanel2.TabIndex = 3;
			// 
			// sidePanel1
			// 
			sidePanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			sidePanel1.BackColor = SystemColors.ActiveCaption;
			sidePanel1.BorderRadius = 20;
			sidePanel1.Controls.Add(flowLayoutPanel1);
			sidePanel1.EnabledGradient = false;
			sidePanel1.GradientAngle = 90F;
			sidePanel1.GradientBottomColor = Color.FromArgb(255, 51, 153);
			sidePanel1.GradientTopColor = Color.Teal;
			sidePanel1.Location = new Point(1, 3);
			sidePanel1.Name = "sidePanel1";
			sidePanel1.Padding = new Padding(7);
			sidePanel1.Size = new Size(519, 434);
			sidePanel1.TabIndex = 2;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.BackColor = Color.Transparent;
			flowLayoutPanel1.Controls.Add(sanPhamCaPheuc1);
			flowLayoutPanel1.Controls.Add(sanPhamCaPheuc2);
			flowLayoutPanel1.Controls.Add(sanPhamCaPheuc3);
			flowLayoutPanel1.Controls.Add(sanPhamCaPheuc4);
			flowLayoutPanel1.Dock = DockStyle.Fill;
			flowLayoutPanel1.Location = new Point(7, 7);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(505, 420);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// hoaDonTab
			// 
			hoaDonTab.Location = new Point(4, 24);
			hoaDonTab.Name = "hoaDonTab";
			hoaDonTab.Padding = new Padding(3);
			hoaDonTab.Size = new Size(923, 440);
			hoaDonTab.TabIndex = 1;
			hoaDonTab.Text = "tabPage2";
			hoaDonTab.UseVisualStyleBackColor = true;
			// 
			// taiKhoanTab
			// 
			taiKhoanTab.Location = new Point(4, 24);
			taiKhoanTab.Name = "taiKhoanTab";
			taiKhoanTab.Size = new Size(923, 440);
			taiKhoanTab.TabIndex = 2;
			taiKhoanTab.Text = "tabPage3";
			taiKhoanTab.UseVisualStyleBackColor = true;
			// 
			// sanPhamCaPheuc1
			// 
			sanPhamCaPheuc1.BackColor = SystemColors.GradientInactiveCaption;
			sanPhamCaPheuc1.cpModel = null;
			sanPhamCaPheuc1.Location = new Point(3, 3);
			sanPhamCaPheuc1.Name = "sanPhamCaPheuc1";
			sanPhamCaPheuc1.Size = new Size(201, 230);
			sanPhamCaPheuc1.TabIndex = 0;
			// 
			// sanPhamCaPheuc2
			// 
			sanPhamCaPheuc2.BackColor = SystemColors.GradientInactiveCaption;
			sanPhamCaPheuc2.cpModel = null;
			sanPhamCaPheuc2.Location = new Point(210, 3);
			sanPhamCaPheuc2.Name = "sanPhamCaPheuc2";
			sanPhamCaPheuc2.Size = new Size(201, 230);
			sanPhamCaPheuc2.TabIndex = 1;
			// 
			// sanPhamCaPheuc3
			// 
			sanPhamCaPheuc3.BackColor = SystemColors.GradientInactiveCaption;
			sanPhamCaPheuc3.cpModel = null;
			sanPhamCaPheuc3.Location = new Point(3, 239);
			sanPhamCaPheuc3.Name = "sanPhamCaPheuc3";
			sanPhamCaPheuc3.Size = new Size(201, 230);
			sanPhamCaPheuc3.TabIndex = 2;
			// 
			// sanPhamCaPheuc4
			// 
			sanPhamCaPheuc4.BackColor = SystemColors.GradientInactiveCaption;
			sanPhamCaPheuc4.cpModel = null;
			sanPhamCaPheuc4.Location = new Point(210, 239);
			sanPhamCaPheuc4.Name = "sanPhamCaPheuc4";
			sanPhamCaPheuc4.Size = new Size(201, 230);
			sanPhamCaPheuc4.TabIndex = 3;
			// 
			// BanHangView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(955, 553);
			Controls.Add(panel1);
			Controls.Add(titleBar);
			Name = "BanHangView";
			Text = "BanHangView";
			WindowState = FormWindowState.Maximized;
			titleBar.ResumeLayout(false);
			panel1.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			trangChuTab.ResumeLayout(false);
			sidePanel1.ResumeLayout(false);
			flowLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private CustomControl.SidePanel titleBar;
		private CustomControl.CustomButton customButton4;
		private CustomControl.CustomButton customButton3;
		private CustomControl.CustomButton customButton2;
		private CustomControl.CustomButton accountIcon;
		private CustomControl.CustomButton hoaDonBtn;
		private Panel panel1;
		private TabControl tabControl1;
		private TabPage trangChuTab;
		private TabPage hoaDonTab;
		private TabPage taiKhoanTab;
		private CustomControl.SidePanel sidePanel2;
		private CustomControl.SidePanel sidePanel1;
		private FlowLayoutPanel flowLayoutPanel1;
		private CustomUserControl.SanPhamCaPheUC sanPhamCaPheuc1;
		private CustomUserControl.SanPhamCaPheUC sanPhamCaPheuc2;
		private CustomUserControl.SanPhamCaPheUC sanPhamCaPheuc3;
		private CustomUserControl.SanPhamCaPheUC sanPhamCaPheuc4;
	}
}