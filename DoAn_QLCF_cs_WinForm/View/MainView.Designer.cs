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
			bindingSource1 = new BindingSource(components);
			sideBar = new CustomControl.SidePanel();
			label3 = new Label();
			panel12 = new Panel();
			navLogOut = new CustomControl.CustomButton();
			panel11 = new Panel();
			navPhanQuyen = new CustomControl.CustomButton();
			panel10 = new Panel();
			navNcc = new CustomControl.CustomButton();
			panel9 = new Panel();
			navThongKe = new CustomControl.CustomButton();
			panel8 = new Panel();
			navFile = new CustomControl.CustomButton();
			panel7 = new Panel();
			navHoaDon = new CustomControl.CustomButton();
			panel6 = new Panel();
			navNhapHang = new CustomControl.CustomButton();
			panel5 = new Panel();
			navNguyenLieu = new CustomControl.CustomButton();
			panel4 = new Panel();
			navCafe = new CustomControl.CustomButton();
			panel3 = new Panel();
			navKhachHang = new CustomControl.CustomButton();
			panel2 = new Panel();
			navNhanVien = new CustomControl.CustomButton();
			label1 = new Label();
			sideNav = new Panel();
			sideNavBtn = new CustomControl.CustomButton();
			btnNavToolTip = new ToolTip(components);
			sideMinimizeTimer = new System.Windows.Forms.Timer(components);
			sideExpandTimer = new System.Windows.Forms.Timer(components);
			backgroundMainView = new CustomControl.SidePanel();
			mainContainer = new CustomControl.SidePanel();
			titleBar = new CustomControl.SidePanel();
			timeLblTitle = new Label();
			textLblTitle = new Label();
			imageLblTitle = new Label();
			customButton4 = new CustomControl.CustomButton();
			customButton3 = new CustomControl.CustomButton();
			customButton2 = new CustomControl.CustomButton();
			customButton1 = new CustomControl.CustomButton();
			timerLblTitle = new System.Windows.Forms.Timer(components);
			((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
			sideBar.SuspendLayout();
			panel12.SuspendLayout();
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
			sideNav.SuspendLayout();
			backgroundMainView.SuspendLayout();
			titleBar.SuspendLayout();
			SuspendLayout();
			// 
			// sideBar
			// 
			sideBar.AutoScroll = true;
			sideBar.BackColor = Color.DarkSlateGray;
			sideBar.BorderRadius = 1;
			sideBar.Controls.Add(label3);
			sideBar.Controls.Add(panel12);
			sideBar.Controls.Add(panel11);
			sideBar.Controls.Add(panel10);
			sideBar.Controls.Add(panel9);
			sideBar.Controls.Add(panel8);
			sideBar.Controls.Add(panel7);
			sideBar.Controls.Add(panel6);
			sideBar.Controls.Add(panel5);
			sideBar.Controls.Add(panel4);
			sideBar.Controls.Add(panel3);
			sideBar.Controls.Add(panel2);
			sideBar.Controls.Add(label1);
			sideBar.Controls.Add(sideNav);
			sideBar.Dock = DockStyle.Left;
			sideBar.EnabledGradient = false;
			sideBar.GradientAngle = 45F;
			sideBar.GradientBottomColor = Color.DarkSlateGray;
			sideBar.GradientTopColor = Color.Teal;
			sideBar.Location = new Point(0, 0);
			sideBar.Margin = new Padding(0);
			sideBar.MaximumSize = new Size(258, 2000);
			sideBar.MinimumSize = new Size(54, 100);
			sideBar.Name = "sideBar";
			sideBar.Size = new Size(54, 743);
			sideBar.TabIndex = 1;
			// 
			// label3
			// 
			label3.BackColor = Color.White;
			label3.Dock = DockStyle.Bottom;
			label3.Location = new Point(0, 693);
			label3.Name = "label3";
			label3.Size = new Size(54, 1);
			label3.TabIndex = 15;
			// 
			// panel12
			// 
			panel12.BackColor = Color.DarkSlateGray;
			panel12.Controls.Add(navLogOut);
			panel12.Dock = DockStyle.Bottom;
			panel12.Location = new Point(0, 694);
			panel12.Name = "panel12";
			panel12.Padding = new Padding(5);
			panel12.Size = new Size(54, 49);
			panel12.TabIndex = 14;
			// 
			// navLogOut
			// 
			navLogOut.BackColor = Color.Transparent;
			navLogOut.BackgroundColor = Color.Transparent;
			navLogOut.BorderColor = Color.PaleVioletRed;
			navLogOut.BorderRadius = 10;
			navLogOut.BorderSize = 0;
			navLogOut.Dock = DockStyle.Fill;
			navLogOut.EnabledTextHover = true;
			navLogOut.FlatAppearance.BorderSize = 0;
			navLogOut.FlatAppearance.MouseDownBackColor = Color.Red;
			navLogOut.FlatAppearance.MouseOverBackColor = Color.Crimson;
			navLogOut.FlatStyle = FlatStyle.Flat;
			navLogOut.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			navLogOut.ForeColor = Color.FromArgb(239, 65, 65);
			navLogOut.Image = Properties.Resources.logoutflatred2;
			navLogOut.ImageAlign = ContentAlignment.MiddleLeft;
			navLogOut.Location = new Point(5, 5);
			navLogOut.Name = "navLogOut";
			navLogOut.Padding = new Padding(5);
			navLogOut.Size = new Size(44, 39);
			navLogOut.TabIndex = 2;
			navLogOut.Tag = "Đăng Xuất";
			navLogOut.Text = "Đăng Xuất";
			navLogOut.TextColor = Color.FromArgb(239, 65, 65);
			navLogOut.TextHover = Color.White;
			navLogOut.UseVisualStyleBackColor = false;
			navLogOut.MouseEnter += navLogOut_MouseEnter;
			navLogOut.MouseLeave += navLogOut_MouseLeave;
			// 
			// panel11
			// 
			panel11.BackColor = Color.DarkSlateGray;
			panel11.Controls.Add(navPhanQuyen);
			panel11.Dock = DockStyle.Top;
			panel11.Location = new Point(0, 491);
			panel11.Name = "panel11";
			panel11.Padding = new Padding(5);
			panel11.Size = new Size(54, 49);
			panel11.TabIndex = 12;
			// 
			// navPhanQuyen
			// 
			navPhanQuyen.BackColor = Color.Transparent;
			navPhanQuyen.BackgroundColor = Color.Transparent;
			navPhanQuyen.BorderColor = Color.DarkBlue;
			navPhanQuyen.BorderRadius = 10;
			navPhanQuyen.BorderSize = 0;
			navPhanQuyen.Dock = DockStyle.Fill;
			navPhanQuyen.EnabledTextHover = false;
			navPhanQuyen.FlatAppearance.BorderSize = 0;
			navPhanQuyen.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			navPhanQuyen.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			navPhanQuyen.FlatStyle = FlatStyle.Flat;
			navPhanQuyen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			navPhanQuyen.ForeColor = Color.White;
			navPhanQuyen.Image = Properties.Resources.PERflat;
			navPhanQuyen.ImageAlign = ContentAlignment.MiddleLeft;
			navPhanQuyen.Location = new Point(5, 5);
			navPhanQuyen.Name = "navPhanQuyen";
			navPhanQuyen.Padding = new Padding(5);
			navPhanQuyen.Size = new Size(44, 39);
			navPhanQuyen.TabIndex = 2;
			navPhanQuyen.Tag = "Phân Quyền";
			navPhanQuyen.Text = "Phân Quyền";
			navPhanQuyen.TextColor = Color.White;
			navPhanQuyen.TextHover = Color.White;
			btnNavToolTip.SetToolTip(navPhanQuyen, "Phân Quyền");
			navPhanQuyen.UseVisualStyleBackColor = false;
			navPhanQuyen.Click += ButtonNavClick;
			// 
			// panel10
			// 
			panel10.BackColor = Color.DarkSlateGray;
			panel10.Controls.Add(navNcc);
			panel10.Dock = DockStyle.Top;
			panel10.Location = new Point(0, 442);
			panel10.Name = "panel10";
			panel10.Padding = new Padding(5);
			panel10.Size = new Size(54, 49);
			panel10.TabIndex = 11;
			// 
			// navNcc
			// 
			navNcc.BackColor = Color.Transparent;
			navNcc.BackgroundColor = Color.Transparent;
			navNcc.BorderColor = Color.Transparent;
			navNcc.BorderRadius = 10;
			navNcc.BorderSize = 0;
			navNcc.Dock = DockStyle.Fill;
			navNcc.EnabledTextHover = false;
			navNcc.FlatAppearance.BorderSize = 0;
			navNcc.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			navNcc.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			navNcc.FlatStyle = FlatStyle.Flat;
			navNcc.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			navNcc.ForeColor = Color.White;
			navNcc.Image = Properties.Resources.supplierflat;
			navNcc.ImageAlign = ContentAlignment.MiddleLeft;
			navNcc.Location = new Point(5, 5);
			navNcc.Name = "navNcc";
			navNcc.Padding = new Padding(5);
			navNcc.Size = new Size(44, 39);
			navNcc.TabIndex = 2;
			navNcc.Tag = "Nhà Cung Cấp";
			navNcc.Text = "Nhà Cung Cấp";
			navNcc.TextColor = Color.White;
			navNcc.TextHover = Color.White;
			btnNavToolTip.SetToolTip(navNcc, "Nhà Cung Cấp");
			navNcc.UseVisualStyleBackColor = false;
			navNcc.Click += ButtonNavClick;
			// 
			// panel9
			// 
			panel9.BackColor = Color.DarkSlateGray;
			panel9.Controls.Add(navThongKe);
			panel9.Dock = DockStyle.Top;
			panel9.Location = new Point(0, 393);
			panel9.Name = "panel9";
			panel9.Padding = new Padding(5);
			panel9.Size = new Size(54, 49);
			panel9.TabIndex = 10;
			// 
			// navThongKe
			// 
			navThongKe.BackColor = Color.Transparent;
			navThongKe.BackgroundColor = Color.Transparent;
			navThongKe.BorderColor = Color.PaleVioletRed;
			navThongKe.BorderRadius = 10;
			navThongKe.BorderSize = 0;
			navThongKe.Dock = DockStyle.Fill;
			navThongKe.EnabledTextHover = false;
			navThongKe.FlatAppearance.BorderSize = 0;
			navThongKe.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			navThongKe.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			navThongKe.FlatStyle = FlatStyle.Flat;
			navThongKe.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			navThongKe.ForeColor = Color.White;
			navThongKe.Image = Properties.Resources.statisticflat;
			navThongKe.ImageAlign = ContentAlignment.MiddleLeft;
			navThongKe.Location = new Point(5, 5);
			navThongKe.Name = "navThongKe";
			navThongKe.Padding = new Padding(5);
			navThongKe.Size = new Size(44, 39);
			navThongKe.TabIndex = 2;
			navThongKe.Tag = "Thống Kê";
			navThongKe.Text = "Thống Kê";
			navThongKe.TextColor = Color.White;
			navThongKe.TextHover = Color.White;
			btnNavToolTip.SetToolTip(navThongKe, "Thống Kê");
			navThongKe.UseVisualStyleBackColor = false;
			navThongKe.Click += ButtonNavClick;
			// 
			// panel8
			// 
			panel8.BackColor = Color.DarkSlateGray;
			panel8.Controls.Add(navFile);
			panel8.Dock = DockStyle.Top;
			panel8.Location = new Point(0, 344);
			panel8.Name = "panel8";
			panel8.Padding = new Padding(5);
			panel8.Size = new Size(54, 49);
			panel8.TabIndex = 9;
			// 
			// navFile
			// 
			navFile.BackColor = Color.Transparent;
			navFile.BackgroundColor = Color.Transparent;
			navFile.BorderColor = Color.Turquoise;
			navFile.BorderRadius = 10;
			navFile.BorderSize = 0;
			navFile.Dock = DockStyle.Fill;
			navFile.EnabledTextHover = false;
			navFile.FlatAppearance.BorderSize = 0;
			navFile.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			navFile.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			navFile.FlatStyle = FlatStyle.Flat;
			navFile.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			navFile.ForeColor = Color.White;
			navFile.Image = Properties.Resources.fileFla;
			navFile.ImageAlign = ContentAlignment.MiddleLeft;
			navFile.Location = new Point(5, 5);
			navFile.Name = "navFile";
			navFile.Padding = new Padding(5);
			navFile.Size = new Size(44, 39);
			navFile.TabIndex = 2;
			navFile.Tag = "Nhập/Xuất File";
			navFile.Text = "Nhập/Xuất File";
			navFile.TextColor = Color.White;
			navFile.TextHover = Color.White;
			btnNavToolTip.SetToolTip(navFile, "Nhập/Xuất File");
			navFile.UseVisualStyleBackColor = false;
			navFile.Click += ButtonNavClick;
			// 
			// panel7
			// 
			panel7.BackColor = Color.DarkSlateGray;
			panel7.Controls.Add(navHoaDon);
			panel7.Dock = DockStyle.Top;
			panel7.Location = new Point(0, 295);
			panel7.Name = "panel7";
			panel7.Padding = new Padding(5);
			panel7.Size = new Size(54, 49);
			panel7.TabIndex = 8;
			// 
			// navHoaDon
			// 
			navHoaDon.BackColor = Color.Transparent;
			navHoaDon.BackgroundColor = Color.Transparent;
			navHoaDon.BorderColor = Color.PaleVioletRed;
			navHoaDon.BorderRadius = 10;
			navHoaDon.BorderSize = 0;
			navHoaDon.Dock = DockStyle.Fill;
			navHoaDon.EnabledTextHover = false;
			navHoaDon.FlatAppearance.BorderSize = 0;
			navHoaDon.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			navHoaDon.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			navHoaDon.FlatStyle = FlatStyle.Flat;
			navHoaDon.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			navHoaDon.ForeColor = Color.White;
			navHoaDon.Image = Properties.Resources.invoiceFlat;
			navHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
			navHoaDon.Location = new Point(5, 5);
			navHoaDon.Name = "navHoaDon";
			navHoaDon.Padding = new Padding(5);
			navHoaDon.Size = new Size(44, 39);
			navHoaDon.TabIndex = 2;
			navHoaDon.Tag = "Hóa Đơn";
			navHoaDon.Text = "Hóa Đơn";
			navHoaDon.TextColor = Color.White;
			navHoaDon.TextHover = Color.White;
			btnNavToolTip.SetToolTip(navHoaDon, "Hóa Đơn");
			navHoaDon.UseVisualStyleBackColor = false;
			navHoaDon.Click += ButtonNavClick;
			// 
			// panel6
			// 
			panel6.BackColor = Color.DarkSlateGray;
			panel6.Controls.Add(navNhapHang);
			panel6.Dock = DockStyle.Top;
			panel6.Location = new Point(0, 246);
			panel6.Name = "panel6";
			panel6.Padding = new Padding(5);
			panel6.Size = new Size(54, 49);
			panel6.TabIndex = 7;
			// 
			// navNhapHang
			// 
			navNhapHang.BackColor = Color.Transparent;
			navNhapHang.BackgroundColor = Color.Transparent;
			navNhapHang.BorderColor = Color.PaleVioletRed;
			navNhapHang.BorderRadius = 10;
			navNhapHang.BorderSize = 0;
			navNhapHang.Dock = DockStyle.Fill;
			navNhapHang.EnabledTextHover = false;
			navNhapHang.FlatAppearance.BorderSize = 0;
			navNhapHang.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			navNhapHang.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			navNhapHang.FlatStyle = FlatStyle.Flat;
			navNhapHang.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			navNhapHang.ForeColor = Color.White;
			navNhapHang.Image = Properties.Resources.importFlat;
			navNhapHang.ImageAlign = ContentAlignment.MiddleLeft;
			navNhapHang.Location = new Point(5, 5);
			navNhapHang.Name = "navNhapHang";
			navNhapHang.Padding = new Padding(5);
			navNhapHang.Size = new Size(44, 39);
			navNhapHang.TabIndex = 2;
			navNhapHang.Tag = "Nhập Hàng";
			navNhapHang.Text = "Nhập Hàng";
			navNhapHang.TextColor = Color.White;
			navNhapHang.TextHover = Color.White;
			btnNavToolTip.SetToolTip(navNhapHang, "Nhập Hàng");
			navNhapHang.UseVisualStyleBackColor = false;
			navNhapHang.Click += ButtonNavClick;
			// 
			// panel5
			// 
			panel5.BackColor = Color.DarkSlateGray;
			panel5.Controls.Add(navNguyenLieu);
			panel5.Dock = DockStyle.Top;
			panel5.Location = new Point(0, 197);
			panel5.Name = "panel5";
			panel5.Padding = new Padding(5);
			panel5.Size = new Size(54, 49);
			panel5.TabIndex = 6;
			// 
			// navNguyenLieu
			// 
			navNguyenLieu.BackColor = Color.Transparent;
			navNguyenLieu.BackgroundColor = Color.Transparent;
			navNguyenLieu.BorderColor = Color.PaleVioletRed;
			navNguyenLieu.BorderRadius = 10;
			navNguyenLieu.BorderSize = 0;
			navNguyenLieu.Dock = DockStyle.Fill;
			navNguyenLieu.EnabledTextHover = false;
			navNguyenLieu.FlatAppearance.BorderSize = 0;
			navNguyenLieu.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			navNguyenLieu.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			navNguyenLieu.FlatStyle = FlatStyle.Flat;
			navNguyenLieu.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			navNguyenLieu.ForeColor = Color.White;
			navNguyenLieu.Image = Properties.Resources.ingreFlat;
			navNguyenLieu.ImageAlign = ContentAlignment.MiddleLeft;
			navNguyenLieu.Location = new Point(5, 5);
			navNguyenLieu.Name = "navNguyenLieu";
			navNguyenLieu.Padding = new Padding(5);
			navNguyenLieu.Size = new Size(44, 39);
			navNguyenLieu.TabIndex = 2;
			navNguyenLieu.Tag = "Nguyên Liệu";
			navNguyenLieu.Text = "Nguyên Liệu";
			navNguyenLieu.TextColor = Color.White;
			navNguyenLieu.TextHover = Color.White;
			btnNavToolTip.SetToolTip(navNguyenLieu, "Nguyên Liệu");
			navNguyenLieu.UseVisualStyleBackColor = false;
			navNguyenLieu.Click += ButtonNavClick;
			// 
			// panel4
			// 
			panel4.BackColor = Color.DarkSlateGray;
			panel4.Controls.Add(navCafe);
			panel4.Dock = DockStyle.Top;
			panel4.Location = new Point(0, 148);
			panel4.Name = "panel4";
			panel4.Padding = new Padding(5);
			panel4.Size = new Size(54, 49);
			panel4.TabIndex = 5;
			// 
			// navCafe
			// 
			navCafe.BackColor = Color.Transparent;
			navCafe.BackgroundColor = Color.Transparent;
			navCafe.BorderColor = Color.PaleVioletRed;
			navCafe.BorderRadius = 10;
			navCafe.BorderSize = 0;
			navCafe.Dock = DockStyle.Fill;
			navCafe.EnabledTextHover = false;
			navCafe.FlatAppearance.BorderSize = 0;
			navCafe.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			navCafe.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			navCafe.FlatStyle = FlatStyle.Flat;
			navCafe.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			navCafe.ForeColor = Color.White;
			navCafe.Image = Properties.Resources.CoffeeFlat;
			navCafe.ImageAlign = ContentAlignment.MiddleLeft;
			navCafe.Location = new Point(5, 5);
			navCafe.Name = "navCafe";
			navCafe.Padding = new Padding(5);
			navCafe.Size = new Size(44, 39);
			navCafe.TabIndex = 2;
			navCafe.Tag = "Cà Phê";
			navCafe.Text = "Cà Phê";
			navCafe.TextColor = Color.White;
			navCafe.TextHover = Color.White;
			btnNavToolTip.SetToolTip(navCafe, "Cà Phê");
			navCafe.UseVisualStyleBackColor = false;
			navCafe.Click += ButtonNavClick;
			// 
			// panel3
			// 
			panel3.BackColor = Color.DarkSlateGray;
			panel3.Controls.Add(navKhachHang);
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(0, 99);
			panel3.Name = "panel3";
			panel3.Padding = new Padding(5);
			panel3.Size = new Size(54, 49);
			panel3.TabIndex = 4;
			// 
			// navKhachHang
			// 
			navKhachHang.BackColor = Color.Transparent;
			navKhachHang.BackgroundColor = Color.Transparent;
			navKhachHang.BorderColor = Color.PaleVioletRed;
			navKhachHang.BorderRadius = 10;
			navKhachHang.BorderSize = 0;
			navKhachHang.Dock = DockStyle.Fill;
			navKhachHang.EnabledTextHover = false;
			navKhachHang.FlatAppearance.BorderSize = 0;
			navKhachHang.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			navKhachHang.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			navKhachHang.FlatStyle = FlatStyle.Flat;
			navKhachHang.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			navKhachHang.ForeColor = Color.White;
			navKhachHang.Image = Properties.Resources.EmployeeFlat;
			navKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
			navKhachHang.Location = new Point(5, 5);
			navKhachHang.Name = "navKhachHang";
			navKhachHang.Padding = new Padding(5);
			navKhachHang.Size = new Size(44, 39);
			navKhachHang.TabIndex = 2;
			navKhachHang.Tag = "Khách Hàng";
			navKhachHang.Text = "Khách Hàng";
			navKhachHang.TextColor = Color.White;
			navKhachHang.TextHover = Color.White;
			btnNavToolTip.SetToolTip(navKhachHang, "Khách Hàng");
			navKhachHang.UseVisualStyleBackColor = false;
			navKhachHang.Click += ButtonNavClick;
			// 
			// panel2
			// 
			panel2.BackColor = Color.DarkSlateGray;
			panel2.Controls.Add(navNhanVien);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 50);
			panel2.Name = "panel2";
			panel2.Padding = new Padding(5);
			panel2.Size = new Size(54, 49);
			panel2.TabIndex = 2;
			// 
			// navNhanVien
			// 
			navNhanVien.BackColor = Color.Transparent;
			navNhanVien.BackgroundColor = Color.Transparent;
			navNhanVien.BorderColor = Color.PaleVioletRed;
			navNhanVien.BorderRadius = 10;
			navNhanVien.BorderSize = 0;
			navNhanVien.Dock = DockStyle.Fill;
			navNhanVien.EnabledTextHover = false;
			navNhanVien.FlatAppearance.BorderSize = 0;
			navNhanVien.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			navNhanVien.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			navNhanVien.FlatStyle = FlatStyle.Flat;
			navNhanVien.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			navNhanVien.ForeColor = Color.White;
			navNhanVien.Image = Properties.Resources.manIcontest;
			navNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
			navNhanVien.Location = new Point(5, 5);
			navNhanVien.Name = "navNhanVien";
			navNhanVien.Padding = new Padding(5);
			navNhanVien.Size = new Size(44, 39);
			navNhanVien.TabIndex = 2;
			navNhanVien.Tag = "Nhân Viên";
			navNhanVien.Text = "Nhân Viên";
			navNhanVien.TextColor = Color.White;
			navNhanVien.TextHover = Color.White;
			btnNavToolTip.SetToolTip(navNhanVien, "Nhân Viên");
			navNhanVien.UseVisualStyleBackColor = false;
			navNhanVien.Click += ButtonNavClick;
			// 
			// label1
			// 
			label1.BackColor = Color.White;
			label1.Dock = DockStyle.Top;
			label1.Location = new Point(0, 49);
			label1.Name = "label1";
			label1.Size = new Size(54, 1);
			label1.TabIndex = 3;
			// 
			// sideNav
			// 
			sideNav.BackColor = Color.DarkSlateGray;
			sideNav.Controls.Add(sideNavBtn);
			sideNav.Dock = DockStyle.Top;
			sideNav.Location = new Point(0, 0);
			sideNav.Name = "sideNav";
			sideNav.Padding = new Padding(5);
			sideNav.Size = new Size(54, 49);
			sideNav.TabIndex = 16;
			// 
			// sideNavBtn
			// 
			sideNavBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			sideNavBtn.BackColor = Color.Transparent;
			sideNavBtn.BackgroundColor = Color.Transparent;
			sideNavBtn.BorderColor = Color.PaleVioletRed;
			sideNavBtn.BorderRadius = 10;
			sideNavBtn.BorderSize = 0;
			sideNavBtn.EnabledTextHover = false;
			sideNavBtn.FlatAppearance.BorderSize = 0;
			sideNavBtn.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			sideNavBtn.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			sideNavBtn.FlatStyle = FlatStyle.Flat;
			sideNavBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			sideNavBtn.ForeColor = Color.White;
			sideNavBtn.Image = Properties.Resources.navCloseflat;
			sideNavBtn.ImageAlign = ContentAlignment.MiddleLeft;
			sideNavBtn.Location = new Point(5, 5);
			sideNavBtn.Name = "sideNavBtn";
			sideNavBtn.Padding = new Padding(5);
			sideNavBtn.Size = new Size(44, 39);
			sideNavBtn.TabIndex = 2;
			sideNavBtn.TextColor = Color.White;
			sideNavBtn.TextHover = Color.White;
			sideNavBtn.UseVisualStyleBackColor = false;
			sideNavBtn.Click += btnMenuSideNav_Click;
			// 
			// btnNavToolTip
			// 
			btnNavToolTip.AutoPopDelay = 5000;
			btnNavToolTip.InitialDelay = 1;
			btnNavToolTip.ReshowDelay = 1;
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
			// backgroundMainView
			// 
			backgroundMainView.BackColor = SystemColors.ActiveCaption;
			backgroundMainView.BorderRadius = 1;
			backgroundMainView.Controls.Add(mainContainer);
			backgroundMainView.Controls.Add(titleBar);
			backgroundMainView.Dock = DockStyle.Fill;
			backgroundMainView.EnabledGradient = true;
			backgroundMainView.GradientAngle = 45F;
			backgroundMainView.GradientBottomColor = Color.Teal;
			backgroundMainView.GradientTopColor = Color.SkyBlue;
			backgroundMainView.Location = new Point(54, 0);
			backgroundMainView.Name = "backgroundMainView";
			backgroundMainView.Size = new Size(891, 743);
			backgroundMainView.TabIndex = 2;
			// 
			// mainContainer
			// 
			mainContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			mainContainer.BackColor = SystemColors.Control;
			mainContainer.BorderRadius = 25;
			mainContainer.EnabledGradient = false;
			mainContainer.GradientAngle = 90F;
			mainContainer.GradientBottomColor = Color.FromArgb(255, 51, 153);
			mainContainer.GradientTopColor = Color.Teal;
			mainContainer.Location = new Point(19, 56);
			mainContainer.Name = "mainContainer";
			mainContainer.Size = new Size(860, 682);
			mainContainer.TabIndex = 1;
			// 
			// titleBar
			// 
			titleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			titleBar.BackColor = Color.DarkSlateGray;
			titleBar.BorderRadius = 15;
			titleBar.Controls.Add(timeLblTitle);
			titleBar.Controls.Add(textLblTitle);
			titleBar.Controls.Add(imageLblTitle);
			titleBar.Controls.Add(customButton4);
			titleBar.Controls.Add(customButton3);
			titleBar.Controls.Add(customButton2);
			titleBar.Controls.Add(customButton1);
			titleBar.EnabledGradient = false;
			titleBar.GradientAngle = 45F;
			titleBar.GradientBottomColor = Color.DarkSlateGray;
			titleBar.GradientTopColor = Color.Teal;
			titleBar.Location = new Point(19, 0);
			titleBar.Name = "titleBar";
			titleBar.Padding = new Padding(10, 5, 15, 5);
			titleBar.Size = new Size(860, 50);
			titleBar.TabIndex = 0;
			// 
			// timeLblTitle
			// 
			timeLblTitle.BackColor = Color.DarkSlateGray;
			timeLblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			timeLblTitle.ForeColor = SystemColors.Control;
			timeLblTitle.Location = new Point(213, 9);
			timeLblTitle.Name = "timeLblTitle";
			timeLblTitle.Size = new Size(214, 33);
			timeLblTitle.TabIndex = 7;
			timeLblTitle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// textLblTitle
			// 
			textLblTitle.BackColor = Color.DarkSlateGray;
			textLblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			textLblTitle.ForeColor = SystemColors.Control;
			textLblTitle.Location = new Point(61, 9);
			textLblTitle.Name = "textLblTitle";
			textLblTitle.Size = new Size(128, 33);
			textLblTitle.TabIndex = 6;
			textLblTitle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// imageLblTitle
			// 
			imageLblTitle.BackColor = Color.DarkSlateGray;
			imageLblTitle.Location = new Point(27, 9);
			imageLblTitle.Name = "imageLblTitle";
			imageLblTitle.Size = new Size(43, 33);
			imageLblTitle.TabIndex = 5;
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
			customButton4.Location = new Point(538, 5);
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
			customButton3.Location = new Point(612, 5);
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
			customButton2.Location = new Point(686, 5);
			customButton2.Name = "customButton2";
			customButton2.Size = new Size(53, 40);
			customButton2.TabIndex = 2;
			customButton2.TextColor = Color.White;
			customButton2.TextHover = Color.White;
			customButton2.UseVisualStyleBackColor = false;
			// 
			// customButton1
			// 
			customButton1.BackColor = Color.OrangeRed;
			customButton1.BackgroundColor = Color.OrangeRed;
			customButton1.BorderColor = Color.Teal;
			customButton1.BorderRadius = 20;
			customButton1.BorderSize = 0;
			customButton1.Cursor = Cursors.Hand;
			customButton1.Dock = DockStyle.Right;
			customButton1.EnabledTextHover = false;
			customButton1.FlatAppearance.BorderSize = 0;
			customButton1.FlatAppearance.MouseDownBackColor = Color.OrangeRed;
			customButton1.FlatAppearance.MouseOverBackColor = Color.Coral;
			customButton1.FlatStyle = FlatStyle.Flat;
			customButton1.ForeColor = Color.White;
			customButton1.Image = Properties.Resources.usericon;
			customButton1.Location = new Point(792, 5);
			customButton1.Name = "customButton1";
			customButton1.Size = new Size(53, 40);
			customButton1.TabIndex = 1;
			customButton1.TextColor = Color.White;
			customButton1.TextHover = Color.White;
			customButton1.UseVisualStyleBackColor = false;
			// 
			// timerLblTitle
			// 
			timerLblTitle.Interval = 1000;
			timerLblTitle.Tick += timerLblTitle_Tick;
			// 
			// MainView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(945, 743);
			Controls.Add(backgroundMainView);
			Controls.Add(sideBar);
			Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			Name = "MainView";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "MainView";
			Load += MainView_Load;
			SizeChanged += MainView_SizeChanged;
			((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
			sideBar.ResumeLayout(false);
			panel12.ResumeLayout(false);
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
			sideNav.ResumeLayout(false);
			backgroundMainView.ResumeLayout(false);
			titleBar.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private BindingSource bindingSource1;
		private CustomControl.SidePanel sideBar;
		private Label label1;
		private Panel panel2;
		private CustomControl.CustomButton navNhanVien;
		private Panel panel11;
		private CustomControl.CustomButton navPhanQuyen;
		private Panel panel10;
		private CustomControl.CustomButton navNcc;
		private Panel panel9;
		private CustomControl.CustomButton navThongKe;
		private Panel panel8;
		private CustomControl.CustomButton navFile;
		private Panel panel7;
		private CustomControl.CustomButton navHoaDon;
		private Panel panel6;
		private CustomControl.CustomButton navNhapHang;
		private Panel panel5;
		private CustomControl.CustomButton navNguyenLieu;
		private Panel panel4;
		private CustomControl.CustomButton navCafe;
		private Panel panel3;
		private CustomControl.CustomButton navKhachHang;
		private ToolTip btnNavToolTip;
		private Label label3;
		private Panel panel12;
		private CustomControl.CustomButton navLogOut;
		private Panel sideNav;
		private CustomControl.CustomButton sideNavBtn;
		private System.Windows.Forms.Timer sideMinimizeTimer;
		private System.Windows.Forms.Timer sideExpandTimer;
		private CustomControl.SidePanel backgroundMainView;
		private CustomControl.SidePanel titleBar;
		private CustomControl.CustomButton customButton1;
		private CustomControl.SidePanel mainContainer;
		private CustomControl.CustomButton customButton4;
		private CustomControl.CustomButton customButton3;
		private CustomControl.CustomButton customButton2;
		private Label imageLblTitle;
		private Label textLblTitle;
		private Label timeLblTitle;
		private System.Windows.Forms.Timer timerLblTitle;
	}
}