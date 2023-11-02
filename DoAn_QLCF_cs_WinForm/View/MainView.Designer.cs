namespace DoAn_QLCF_cs_WinForm.View
{
	partial class MainView
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
			components = new System.ComponentModel.Container();
			sideBar = new Panel();
			panel11 = new Panel();
			button1 = new Button();
			label1 = new Label();
			panel10 = new Panel();
			btnNcc = new Button();
			panel9 = new Panel();
			btnThongKe = new Button();
			panel8 = new Panel();
			button8 = new Button();
			panel7 = new Panel();
			btnPhanQuyen = new Button();
			panel6 = new Panel();
			btnHoaDon = new Button();
			panel5 = new Panel();
			btnNhapHang = new Button();
			panel4 = new Panel();
			btnNguyenLieu = new Button();
			panel3 = new Panel();
			btnCaPhe = new Button();
			panel2 = new Panel();
			btnKhachHang = new Button();
			panel1 = new Panel();
			btnNhanVien = new Button();
			menuSlide = new Panel();
			btnMenuSideBar = new Button();
			sideMinimizeTimer = new System.Windows.Forms.Timer(components);
			sideExpandTimer = new System.Windows.Forms.Timer(components);
			sideBar.SuspendLayout();
			panel11.SuspendLayout();
			panel10.SuspendLayout();
			panel9.SuspendLayout();
			panel8.SuspendLayout();
			panel7.SuspendLayout();
			panel6.SuspendLayout();
			panel5.SuspendLayout();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			menuSlide.SuspendLayout();
			SuspendLayout();
			// 
			// sideBar
			// 
			sideBar.AutoScroll = true;
			sideBar.BackColor = Color.FromArgb(51, 51, 76);
			sideBar.Controls.Add(panel11);
			sideBar.Controls.Add(label1);
			sideBar.Controls.Add(panel10);
			sideBar.Controls.Add(panel9);
			sideBar.Controls.Add(panel8);
			sideBar.Controls.Add(panel7);
			sideBar.Controls.Add(panel6);
			sideBar.Controls.Add(panel5);
			sideBar.Controls.Add(panel4);
			sideBar.Controls.Add(panel3);
			sideBar.Controls.Add(panel2);
			sideBar.Controls.Add(panel1);
			sideBar.Controls.Add(menuSlide);
			sideBar.Dock = DockStyle.Left;
			sideBar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			sideBar.Location = new Point(0, 0);
			sideBar.MaximumSize = new Size(252, 1000);
			sideBar.MinimumSize = new Size(67, 300);
			sideBar.Name = "sideBar";
			sideBar.Size = new Size(252, 715);
			sideBar.TabIndex = 0;
			// 
			// panel11
			// 
			panel11.Controls.Add(button1);
			panel11.Dock = DockStyle.Top;
			panel11.Location = new Point(0, 632);
			panel11.Name = "panel11";
			panel11.Size = new Size(252, 59);
			panel11.TabIndex = 21;
			// 
			// button1
			// 
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.FromArgb(255, 26, 26);
			button1.Image = Properties.Resources.log_out;
			button1.ImageAlign = ContentAlignment.MiddleLeft;
			button1.Location = new Point(0, 0);
			button1.Name = "button1";
			button1.Padding = new Padding(12, 0, 0, 0);
			button1.Size = new Size(252, 59);
			button1.TabIndex = 10;
			button1.Text = "Đăng xuất";
			button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.BackColor = Color.White;
			label1.Dock = DockStyle.Top;
			label1.Location = new Point(0, 631);
			label1.Name = "label1";
			label1.Size = new Size(252, 1);
			label1.TabIndex = 1;
			// 
			// panel10
			// 
			panel10.Controls.Add(btnNcc);
			panel10.Dock = DockStyle.Top;
			panel10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			panel10.Location = new Point(0, 572);
			panel10.Name = "panel10";
			panel10.Size = new Size(252, 59);
			panel10.TabIndex = 20;
			// 
			// btnNcc
			// 
			btnNcc.FlatAppearance.BorderSize = 0;
			btnNcc.FlatStyle = FlatStyle.Flat;
			btnNcc.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			btnNcc.ForeColor = SystemColors.ButtonFace;
			btnNcc.Image = Properties.Resources.Supplier;
			btnNcc.ImageAlign = ContentAlignment.MiddleLeft;
			btnNcc.Location = new Point(0, 0);
			btnNcc.Name = "btnNcc";
			btnNcc.Padding = new Padding(12, 0, 0, 0);
			btnNcc.Size = new Size(252, 59);
			btnNcc.TabIndex = 10;
			btnNcc.Text = "Nhà cung cấp";
			btnNcc.UseVisualStyleBackColor = true;
			// 
			// panel9
			// 
			panel9.Controls.Add(btnThongKe);
			panel9.Dock = DockStyle.Top;
			panel9.Location = new Point(0, 513);
			panel9.Name = "panel9";
			panel9.Size = new Size(252, 59);
			panel9.TabIndex = 19;
			// 
			// btnThongKe
			// 
			btnThongKe.FlatAppearance.BorderSize = 0;
			btnThongKe.FlatStyle = FlatStyle.Flat;
			btnThongKe.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			btnThongKe.ForeColor = SystemColors.ButtonFace;
			btnThongKe.Image = Properties.Resources.statistic;
			btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
			btnThongKe.Location = new Point(0, 0);
			btnThongKe.Name = "btnThongKe";
			btnThongKe.Padding = new Padding(12, 0, 0, 0);
			btnThongKe.Size = new Size(252, 59);
			btnThongKe.TabIndex = 10;
			btnThongKe.Text = "Thống kê";
			btnThongKe.UseVisualStyleBackColor = true;
			// 
			// panel8
			// 
			panel8.Controls.Add(button8);
			panel8.Dock = DockStyle.Top;
			panel8.Location = new Point(0, 454);
			panel8.Name = "panel8";
			panel8.Size = new Size(252, 59);
			panel8.TabIndex = 18;
			// 
			// button8
			// 
			button8.FlatAppearance.BorderSize = 0;
			button8.FlatStyle = FlatStyle.Flat;
			button8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			button8.ForeColor = SystemColors.ButtonFace;
			button8.Image = Properties.Resources.open_folder;
			button8.ImageAlign = ContentAlignment.MiddleLeft;
			button8.Location = new Point(0, 0);
			button8.Name = "button8";
			button8.Padding = new Padding(12, 0, 0, 0);
			button8.Size = new Size(252, 59);
			button8.TabIndex = 10;
			button8.Text = "Nhập/Xuất file";
			button8.UseVisualStyleBackColor = true;
			// 
			// panel7
			// 
			panel7.Controls.Add(btnPhanQuyen);
			panel7.Dock = DockStyle.Top;
			panel7.Location = new Point(0, 395);
			panel7.Name = "panel7";
			panel7.Size = new Size(252, 59);
			panel7.TabIndex = 17;
			// 
			// btnPhanQuyen
			// 
			btnPhanQuyen.FlatAppearance.BorderSize = 0;
			btnPhanQuyen.FlatStyle = FlatStyle.Flat;
			btnPhanQuyen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			btnPhanQuyen.ForeColor = SystemColors.ButtonFace;
			btnPhanQuyen.Image = Properties.Resources.permissionIcon;
			btnPhanQuyen.ImageAlign = ContentAlignment.MiddleLeft;
			btnPhanQuyen.Location = new Point(0, 0);
			btnPhanQuyen.Name = "btnPhanQuyen";
			btnPhanQuyen.Padding = new Padding(12, 0, 0, 0);
			btnPhanQuyen.Size = new Size(252, 59);
			btnPhanQuyen.TabIndex = 10;
			btnPhanQuyen.Text = "Phân quyền";
			btnPhanQuyen.UseVisualStyleBackColor = true;
			// 
			// panel6
			// 
			panel6.Controls.Add(btnHoaDon);
			panel6.Dock = DockStyle.Top;
			panel6.Location = new Point(0, 336);
			panel6.Name = "panel6";
			panel6.Size = new Size(252, 59);
			panel6.TabIndex = 16;
			// 
			// btnHoaDon
			// 
			btnHoaDon.FlatAppearance.BorderSize = 0;
			btnHoaDon.FlatStyle = FlatStyle.Flat;
			btnHoaDon.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			btnHoaDon.ForeColor = SystemColors.ButtonFace;
			btnHoaDon.Image = Properties.Resources.invoiceIcon;
			btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
			btnHoaDon.Location = new Point(0, 0);
			btnHoaDon.Name = "btnHoaDon";
			btnHoaDon.Padding = new Padding(12, 0, 0, 0);
			btnHoaDon.Size = new Size(252, 59);
			btnHoaDon.TabIndex = 10;
			btnHoaDon.Text = "Hóa đơn";
			btnHoaDon.UseVisualStyleBackColor = true;
			// 
			// panel5
			// 
			panel5.Controls.Add(btnNhapHang);
			panel5.Dock = DockStyle.Top;
			panel5.Location = new Point(0, 277);
			panel5.Name = "panel5";
			panel5.Size = new Size(252, 59);
			panel5.TabIndex = 15;
			// 
			// btnNhapHang
			// 
			btnNhapHang.FlatAppearance.BorderSize = 0;
			btnNhapHang.FlatStyle = FlatStyle.Flat;
			btnNhapHang.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			btnNhapHang.ForeColor = SystemColors.ButtonFace;
			btnNhapHang.Image = Properties.Resources.importIcon;
			btnNhapHang.ImageAlign = ContentAlignment.MiddleLeft;
			btnNhapHang.Location = new Point(0, 0);
			btnNhapHang.Name = "btnNhapHang";
			btnNhapHang.Padding = new Padding(12, 0, 0, 0);
			btnNhapHang.Size = new Size(252, 59);
			btnNhapHang.TabIndex = 10;
			btnNhapHang.Text = "Nhập hàng";
			btnNhapHang.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			panel4.Controls.Add(btnNguyenLieu);
			panel4.Dock = DockStyle.Top;
			panel4.Location = new Point(0, 218);
			panel4.Name = "panel4";
			panel4.Size = new Size(252, 59);
			panel4.TabIndex = 14;
			// 
			// btnNguyenLieu
			// 
			btnNguyenLieu.FlatAppearance.BorderSize = 0;
			btnNguyenLieu.FlatStyle = FlatStyle.Flat;
			btnNguyenLieu.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			btnNguyenLieu.ForeColor = SystemColors.ButtonFace;
			btnNguyenLieu.Image = Properties.Resources.ingredientIcon;
			btnNguyenLieu.ImageAlign = ContentAlignment.MiddleLeft;
			btnNguyenLieu.Location = new Point(0, 0);
			btnNguyenLieu.Name = "btnNguyenLieu";
			btnNguyenLieu.Padding = new Padding(12, 0, 0, 0);
			btnNguyenLieu.Size = new Size(252, 59);
			btnNguyenLieu.TabIndex = 10;
			btnNguyenLieu.Text = "Nguyên liệu";
			btnNguyenLieu.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			panel3.Controls.Add(btnCaPhe);
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(0, 159);
			panel3.Name = "panel3";
			panel3.Size = new Size(252, 59);
			panel3.TabIndex = 13;
			// 
			// btnCaPhe
			// 
			btnCaPhe.FlatAppearance.BorderSize = 0;
			btnCaPhe.FlatStyle = FlatStyle.Flat;
			btnCaPhe.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			btnCaPhe.ForeColor = SystemColors.ButtonFace;
			btnCaPhe.Image = Properties.Resources.caphe;
			btnCaPhe.ImageAlign = ContentAlignment.MiddleLeft;
			btnCaPhe.Location = new Point(0, 0);
			btnCaPhe.Name = "btnCaPhe";
			btnCaPhe.Padding = new Padding(12, 0, 0, 0);
			btnCaPhe.Size = new Size(252, 59);
			btnCaPhe.TabIndex = 10;
			btnCaPhe.Text = "Cà phê";
			btnCaPhe.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			panel2.Controls.Add(btnKhachHang);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 100);
			panel2.Name = "panel2";
			panel2.Size = new Size(252, 59);
			panel2.TabIndex = 12;
			// 
			// btnKhachHang
			// 
			btnKhachHang.FlatAppearance.BorderSize = 0;
			btnKhachHang.FlatStyle = FlatStyle.Flat;
			btnKhachHang.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			btnKhachHang.ForeColor = SystemColors.ButtonFace;
			btnKhachHang.Image = Properties.Resources.customerIcon;
			btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
			btnKhachHang.Location = new Point(0, 0);
			btnKhachHang.Name = "btnKhachHang";
			btnKhachHang.Padding = new Padding(12, 0, 0, 0);
			btnKhachHang.Size = new Size(252, 59);
			btnKhachHang.TabIndex = 10;
			btnKhachHang.Text = "Khách hàng";
			btnKhachHang.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			panel1.Controls.Add(btnNhanVien);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 41);
			panel1.Name = "panel1";
			panel1.Size = new Size(252, 59);
			panel1.TabIndex = 11;
			// 
			// btnNhanVien
			// 
			btnNhanVien.FlatAppearance.BorderSize = 0;
			btnNhanVien.FlatStyle = FlatStyle.Flat;
			btnNhanVien.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			btnNhanVien.ForeColor = SystemColors.ButtonFace;
			btnNhanVien.Image = Properties.Resources.employees;
			btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
			btnNhanVien.Location = new Point(0, 0);
			btnNhanVien.Name = "btnNhanVien";
			btnNhanVien.Padding = new Padding(12, 0, 0, 0);
			btnNhanVien.Size = new Size(252, 59);
			btnNhanVien.TabIndex = 10;
			btnNhanVien.Text = "Nhân viên";
			btnNhanVien.UseVisualStyleBackColor = true;
			// 
			// menuSlide
			// 
			menuSlide.Controls.Add(btnMenuSideBar);
			menuSlide.Dock = DockStyle.Top;
			menuSlide.Location = new Point(0, 0);
			menuSlide.Name = "menuSlide";
			menuSlide.Size = new Size(252, 41);
			menuSlide.TabIndex = 1;
			// 
			// btnMenuSideBar
			// 
			btnMenuSideBar.Dock = DockStyle.Fill;
			btnMenuSideBar.FlatAppearance.BorderSize = 0;
			btnMenuSideBar.FlatStyle = FlatStyle.Flat;
			btnMenuSideBar.ForeColor = SystemColors.ButtonFace;
			btnMenuSideBar.Image = Properties.Resources.menuClick;
			btnMenuSideBar.ImageAlign = ContentAlignment.MiddleLeft;
			btnMenuSideBar.Location = new Point(0, 0);
			btnMenuSideBar.Name = "btnMenuSideBar";
			btnMenuSideBar.Padding = new Padding(12, 0, 0, 0);
			btnMenuSideBar.Size = new Size(252, 41);
			btnMenuSideBar.TabIndex = 1;
			btnMenuSideBar.UseVisualStyleBackColor = true;
			btnMenuSideBar.Click += btnMenuSideBar_Click;
			// 
			// sideMinimizeTimer
			// 
			sideMinimizeTimer.Interval = 10;
			sideMinimizeTimer.Tick += sideMinimizeTimer_Tick;
			// 
			// sideExpandTimer
			// 
			sideExpandTimer.Interval = 10;
			sideExpandTimer.Tick += sideExpandTimer_Tick;
			// 
			// MainView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(919, 715);
			Controls.Add(sideBar);
			IsMdiContainer = true;
			Name = "MainView";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "MainView";
			SizeChanged += MainView_SizeChanged;
			sideBar.ResumeLayout(false);
			panel11.ResumeLayout(false);
			panel10.ResumeLayout(false);
			panel9.ResumeLayout(false);
			panel8.ResumeLayout(false);
			panel7.ResumeLayout(false);
			panel6.ResumeLayout(false);
			panel5.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel1.ResumeLayout(false);
			menuSlide.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel sideBar;
		private Panel menuSlide;
		private Button btnMenuSideBar;
		private Button btnNhanVien;
		private Panel panel1;
		private Panel panel9;
		private Button btnThongKe;
		private Panel panel8;
		private Button button8;
		private Panel panel7;
		private Button btnPhanQuyen;
		private Panel panel6;
		private Button btnHoaDon;
		private Panel panel5;
		private Button btnNhapHang;
		private Panel panel4;
		private Button btnNguyenLieu;
		private Panel panel3;
		private Button btnCaPhe;
		private Panel panel2;
		private Button btnKhachHang;
		private Panel panel10;
		private Button btnNcc;
		private System.Windows.Forms.Timer sideMinimizeTimer;
		private System.Windows.Forms.Timer sideExpandTimer;
		private Label label1;
		private Panel panel11;
		private Button button1;
	}
}