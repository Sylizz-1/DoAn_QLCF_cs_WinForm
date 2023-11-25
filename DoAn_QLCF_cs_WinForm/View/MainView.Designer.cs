using System.Windows.Forms;

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
            pn_loaiKhachHang = new Panel();
            navLkh = new CustomControl.CustomButton();
            pn_phieuGiamGia = new Panel();
            navPgg = new CustomControl.CustomButton();
            label3 = new Label();
            panel12 = new Panel();
            navLogOut = new CustomControl.CustomButton();
            pn_phanQuyen = new Panel();
            navPhanQuyen = new CustomControl.CustomButton();
            pn_nhaCungCap = new Panel();
            navNcc = new CustomControl.CustomButton();
            pn_thongKe = new Panel();
            navThongKe = new CustomControl.CustomButton();
            pn_file = new Panel();
            navFile = new CustomControl.CustomButton();
            pn_hoaDon = new Panel();
            navHoaDon = new CustomControl.CustomButton();
            pn_nhapHang = new Panel();
            navNhapHang = new CustomControl.CustomButton();
            pn_nguyenLieu = new Panel();
            navNguyenLieu = new CustomControl.CustomButton();
            pn_caPhe = new Panel();
            navCafe = new CustomControl.CustomButton();
            pn_khachHang = new Panel();
            navKhachHang = new CustomControl.CustomButton();
            pn_nhanVien = new Panel();
            navNhanVien = new CustomControl.CustomButton();
            label1 = new Label();
            sideNav = new Panel();
            sideNavBtn = new CustomControl.CustomButton();
            btnNavToolTip = new ToolTip(components);
            sideMinimizeTimer = new System.Windows.Forms.Timer(components);
            sideExpandTimer = new System.Windows.Forms.Timer(components);
            backgroundMainView = new CustomControl.SidePanel();
            mainPanelContainer = new CustomControl.SidePanel();
            titleBar = new CustomControl.SidePanel();
            timeLblTitle = new Label();
            textLblTitle = new Label();
            imageLblTitle = new Label();
            customButton4 = new CustomControl.CustomButton();
            customButton3 = new CustomControl.CustomButton();
            customButton2 = new CustomControl.CustomButton();
            accountIcon = new CustomControl.CustomButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            accMenuStrip = new ToolStripMenuItem();
            changePassMenuStrip = new ToolStripMenuItem();
            settingMenuStrip = new ToolStripMenuItem();
            logOutMenuStrip = new ToolStripMenuItem();
            timerLblTitle = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            sideBar.SuspendLayout();
            pn_loaiKhachHang.SuspendLayout();
            pn_phieuGiamGia.SuspendLayout();
            panel12.SuspendLayout();
            pn_phanQuyen.SuspendLayout();
            pn_nhaCungCap.SuspendLayout();
            pn_thongKe.SuspendLayout();
            pn_file.SuspendLayout();
            pn_hoaDon.SuspendLayout();
            pn_nhapHang.SuspendLayout();
            pn_nguyenLieu.SuspendLayout();
            pn_caPhe.SuspendLayout();
            pn_khachHang.SuspendLayout();
            pn_nhanVien.SuspendLayout();
            sideNav.SuspendLayout();
            backgroundMainView.SuspendLayout();
            titleBar.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.AutoScroll = true;
            sideBar.BackColor = Color.DarkSlateGray;
            sideBar.BorderRadius = 1;
            sideBar.Controls.Add(pn_loaiKhachHang);
            sideBar.Controls.Add(pn_phieuGiamGia);
            sideBar.Controls.Add(label3);
            sideBar.Controls.Add(panel12);
            sideBar.Controls.Add(pn_phanQuyen);
            sideBar.Controls.Add(pn_nhaCungCap);
            sideBar.Controls.Add(pn_thongKe);
            sideBar.Controls.Add(pn_file);
            sideBar.Controls.Add(pn_hoaDon);
            sideBar.Controls.Add(pn_nhapHang);
            sideBar.Controls.Add(pn_nguyenLieu);
            sideBar.Controls.Add(pn_caPhe);
            sideBar.Controls.Add(pn_khachHang);
            sideBar.Controls.Add(pn_nhanVien);
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
            sideBar.Size = new Size(258, 749);
            sideBar.TabIndex = 1;
            // 
            // pn_loaiKhachHang
            // 
            pn_loaiKhachHang.BackColor = Color.DarkSlateGray;
            pn_loaiKhachHang.Controls.Add(navLkh);
            pn_loaiKhachHang.Dock = DockStyle.Top;
            pn_loaiKhachHang.Location = new Point(0, 589);
            pn_loaiKhachHang.Name = "pn_loaiKhachHang";
            pn_loaiKhachHang.Padding = new Padding(5);
            pn_loaiKhachHang.Size = new Size(258, 49);
            pn_loaiKhachHang.TabIndex = 18;
            // 
            // navLkh
            // 
            navLkh.BackColor = Color.Transparent;
            navLkh.BackgroundColor = Color.Transparent;
            navLkh.BorderColor = Color.Transparent;
            navLkh.BorderRadius = 10;
            navLkh.BorderSize = 0;
            navLkh.Dock = DockStyle.Fill;
            navLkh.EnabledTextHover = false;
            navLkh.FlatAppearance.BorderSize = 0;
            navLkh.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            navLkh.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            navLkh.FlatStyle = FlatStyle.Flat;
            navLkh.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            navLkh.ForeColor = Color.White;
            navLkh.Image = Properties.Resources.LoaiKhachHangNAV;
            navLkh.ImageAlign = ContentAlignment.MiddleLeft;
            navLkh.ImageHover = null;
            navLkh.Location = new Point(5, 5);
            navLkh.Name = "navLkh";
            navLkh.Padding = new Padding(5);
            navLkh.Size = new Size(248, 39);
            navLkh.TabIndex = 2;
            navLkh.Tag = "Nhà Cung Cấp";
            navLkh.Text = "Loại Khách Hàng";
            navLkh.TextColor = Color.White;
            navLkh.TextHover = Color.White;
            btnNavToolTip.SetToolTip(navLkh, "Nhà Cung Cấp");
            navLkh.UseVisualStyleBackColor = false;
            // 
            // pn_phieuGiamGia
            // 
            pn_phieuGiamGia.BackColor = Color.DarkSlateGray;
            pn_phieuGiamGia.Controls.Add(navPgg);
            pn_phieuGiamGia.Dock = DockStyle.Top;
            pn_phieuGiamGia.Location = new Point(0, 540);
            pn_phieuGiamGia.Name = "pn_phieuGiamGia";
            pn_phieuGiamGia.Padding = new Padding(5);
            pn_phieuGiamGia.Size = new Size(258, 49);
            pn_phieuGiamGia.TabIndex = 17;
            // 
            // navPgg
            // 
            navPgg.BackColor = Color.Transparent;
            navPgg.BackgroundColor = Color.Transparent;
            navPgg.BorderColor = Color.DarkBlue;
            navPgg.BorderRadius = 10;
            navPgg.BorderSize = 0;
            navPgg.Dock = DockStyle.Fill;
            navPgg.EnabledTextHover = false;
            navPgg.FlatAppearance.BorderSize = 0;
            navPgg.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            navPgg.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            navPgg.FlatStyle = FlatStyle.Flat;
            navPgg.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            navPgg.ForeColor = Color.White;
            navPgg.Image = Properties.Resources.DiscountIcon24px;
            navPgg.ImageAlign = ContentAlignment.MiddleLeft;
            navPgg.ImageHover = null;
            navPgg.Location = new Point(5, 5);
            navPgg.Name = "navPgg";
            navPgg.Padding = new Padding(5);
            navPgg.Size = new Size(248, 39);
            navPgg.TabIndex = 2;
            navPgg.Tag = "Phiếu Giảm Giá";
            navPgg.Text = "Phiếu Giảm Giá";
            navPgg.TextColor = Color.White;
            navPgg.TextHover = Color.White;
            btnNavToolTip.SetToolTip(navPgg, "Phiếu Giảm Giá");
            navPgg.UseVisualStyleBackColor = false;
            navPgg.Click += ButtonNavClick;
            navPgg.MouseDown += navPgg_MouseDown;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Dock = DockStyle.Bottom;
            label3.Location = new Point(0, 699);
            label3.Name = "label3";
            label3.Size = new Size(258, 1);
            label3.TabIndex = 15;
            // 
            // panel12
            // 
            panel12.BackColor = Color.DarkSlateGray;
            panel12.Controls.Add(navLogOut);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(0, 700);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(5);
            panel12.Size = new Size(258, 49);
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
            navLogOut.ImageHover = null;
            navLogOut.Location = new Point(5, 5);
            navLogOut.Name = "navLogOut";
            navLogOut.Padding = new Padding(5);
            navLogOut.Size = new Size(248, 39);
            navLogOut.TabIndex = 2;
            navLogOut.Tag = "Đăng Xuất";
            navLogOut.Text = "Đăng Xuất";
            navLogOut.TextColor = Color.FromArgb(239, 65, 65);
            navLogOut.TextHover = Color.White;
            navLogOut.UseVisualStyleBackColor = false;
            navLogOut.MouseEnter += navLogOut_MouseEnter;
            navLogOut.MouseLeave += navLogOut_MouseLeave;
            // 
            // pn_phanQuyen
            // 
            pn_phanQuyen.BackColor = Color.DarkSlateGray;
            pn_phanQuyen.Controls.Add(navPhanQuyen);
            pn_phanQuyen.Dock = DockStyle.Top;
            pn_phanQuyen.Location = new Point(0, 491);
            pn_phanQuyen.Name = "pn_phanQuyen";
            pn_phanQuyen.Padding = new Padding(5);
            pn_phanQuyen.Size = new Size(258, 49);
            pn_phanQuyen.TabIndex = 12;
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
            navPhanQuyen.ImageHover = null;
            navPhanQuyen.Location = new Point(5, 5);
            navPhanQuyen.Name = "navPhanQuyen";
            navPhanQuyen.Padding = new Padding(5);
            navPhanQuyen.Size = new Size(248, 39);
            navPhanQuyen.TabIndex = 2;
            navPhanQuyen.Tag = "Phân Quyền";
            navPhanQuyen.Text = "Phân Quyền";
            navPhanQuyen.TextColor = Color.White;
            navPhanQuyen.TextHover = Color.White;
            btnNavToolTip.SetToolTip(navPhanQuyen, "Phân Quyền");
            navPhanQuyen.UseVisualStyleBackColor = false;
            navPhanQuyen.Click += ButtonNavClick;
            // 
            // pn_nhaCungCap
            // 
            pn_nhaCungCap.BackColor = Color.DarkSlateGray;
            pn_nhaCungCap.Controls.Add(navNcc);
            pn_nhaCungCap.Dock = DockStyle.Top;
            pn_nhaCungCap.Location = new Point(0, 442);
            pn_nhaCungCap.Name = "pn_nhaCungCap";
            pn_nhaCungCap.Padding = new Padding(5);
            pn_nhaCungCap.Size = new Size(258, 49);
            pn_nhaCungCap.TabIndex = 11;
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
            navNcc.ImageHover = null;
            navNcc.Location = new Point(5, 5);
            navNcc.Name = "navNcc";
            navNcc.Padding = new Padding(5);
            navNcc.Size = new Size(248, 39);
            navNcc.TabIndex = 2;
            navNcc.Tag = "Nhà Cung Cấp";
            navNcc.Text = "Nhà Cung Cấp";
            navNcc.TextColor = Color.White;
            navNcc.TextHover = Color.White;
            btnNavToolTip.SetToolTip(navNcc, "Nhà Cung Cấp");
            navNcc.UseVisualStyleBackColor = false;
            navNcc.Click += ButtonNavClick;
            // 
            // pn_thongKe
            // 
            pn_thongKe.BackColor = Color.DarkSlateGray;
            pn_thongKe.Controls.Add(navThongKe);
            pn_thongKe.Dock = DockStyle.Top;
            pn_thongKe.Location = new Point(0, 393);
            pn_thongKe.Name = "pn_thongKe";
            pn_thongKe.Padding = new Padding(5);
            pn_thongKe.Size = new Size(258, 49);
            pn_thongKe.TabIndex = 10;
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
            navThongKe.ImageHover = null;
            navThongKe.Location = new Point(5, 5);
            navThongKe.Name = "navThongKe";
            navThongKe.Padding = new Padding(5);
            navThongKe.Size = new Size(248, 39);
            navThongKe.TabIndex = 2;
            navThongKe.Tag = "Thống Kê";
            navThongKe.Text = "Thống Kê";
            navThongKe.TextColor = Color.White;
            navThongKe.TextHover = Color.White;
            btnNavToolTip.SetToolTip(navThongKe, "Thống Kê");
            navThongKe.UseVisualStyleBackColor = false;
            navThongKe.Click += ButtonNavClick;
            // 
            // pn_file
            // 
            pn_file.BackColor = Color.DarkSlateGray;
            pn_file.Controls.Add(navFile);
            pn_file.Dock = DockStyle.Top;
            pn_file.Location = new Point(0, 344);
            pn_file.Name = "pn_file";
            pn_file.Padding = new Padding(5);
            pn_file.Size = new Size(258, 49);
            pn_file.TabIndex = 9;
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
            navFile.ImageHover = null;
            navFile.Location = new Point(5, 5);
            navFile.Name = "navFile";
            navFile.Padding = new Padding(5);
            navFile.Size = new Size(248, 39);
            navFile.TabIndex = 2;
            navFile.Tag = "Nhập/Xuất File";
            navFile.Text = "Nhập/Xuất File";
            navFile.TextColor = Color.White;
            navFile.TextHover = Color.White;
            btnNavToolTip.SetToolTip(navFile, "Nhập/Xuất File");
            navFile.UseVisualStyleBackColor = false;
            navFile.Click += ButtonNavClick;
            navFile.MouseDown += navFile_MouseDown;
            // 
            // pn_hoaDon
            // 
            pn_hoaDon.BackColor = Color.DarkSlateGray;
            pn_hoaDon.Controls.Add(navHoaDon);
            pn_hoaDon.Dock = DockStyle.Top;
            pn_hoaDon.Location = new Point(0, 295);
            pn_hoaDon.Name = "pn_hoaDon";
            pn_hoaDon.Padding = new Padding(5);
            pn_hoaDon.Size = new Size(258, 49);
            pn_hoaDon.TabIndex = 8;
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
            navHoaDon.ImageHover = null;
            navHoaDon.Location = new Point(5, 5);
            navHoaDon.Name = "navHoaDon";
            navHoaDon.Padding = new Padding(5);
            navHoaDon.Size = new Size(248, 39);
            navHoaDon.TabIndex = 2;
            navHoaDon.Tag = "Hóa Đơn";
            navHoaDon.Text = "Hóa Đơn";
            navHoaDon.TextColor = Color.White;
            navHoaDon.TextHover = Color.White;
            btnNavToolTip.SetToolTip(navHoaDon, "Hóa Đơn");
            navHoaDon.UseVisualStyleBackColor = false;
            navHoaDon.Click += ButtonNavClick;
            navHoaDon.MouseDown += navHoaDon_MouseDown;
            // 
            // pn_nhapHang
            // 
            pn_nhapHang.BackColor = Color.DarkSlateGray;
            pn_nhapHang.Controls.Add(navNhapHang);
            pn_nhapHang.Dock = DockStyle.Top;
            pn_nhapHang.Location = new Point(0, 246);
            pn_nhapHang.Name = "pn_nhapHang";
            pn_nhapHang.Padding = new Padding(5);
            pn_nhapHang.Size = new Size(258, 49);
            pn_nhapHang.TabIndex = 7;
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
            navNhapHang.ImageHover = null;
            navNhapHang.Location = new Point(5, 5);
            navNhapHang.Name = "navNhapHang";
            navNhapHang.Padding = new Padding(5);
            navNhapHang.Size = new Size(248, 39);
            navNhapHang.TabIndex = 2;
            navNhapHang.Tag = "Nhập Hàng";
            navNhapHang.Text = "Nhập Hàng";
            navNhapHang.TextColor = Color.White;
            navNhapHang.TextHover = Color.White;
            btnNavToolTip.SetToolTip(navNhapHang, "Nhập Hàng");
            navNhapHang.UseVisualStyleBackColor = false;
            navNhapHang.Click += ButtonNavClick;
            navNhapHang.MouseDown += navNhapHang_MouseDown;
            // 
            // pn_nguyenLieu
            // 
            pn_nguyenLieu.BackColor = Color.DarkSlateGray;
            pn_nguyenLieu.Controls.Add(navNguyenLieu);
            pn_nguyenLieu.Dock = DockStyle.Top;
            pn_nguyenLieu.Location = new Point(0, 197);
            pn_nguyenLieu.Name = "pn_nguyenLieu";
            pn_nguyenLieu.Padding = new Padding(5);
            pn_nguyenLieu.Size = new Size(258, 49);
            pn_nguyenLieu.TabIndex = 6;
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
            navNguyenLieu.ImageHover = null;
            navNguyenLieu.Location = new Point(5, 5);
            navNguyenLieu.Name = "navNguyenLieu";
            navNguyenLieu.Padding = new Padding(5);
            navNguyenLieu.Size = new Size(248, 39);
            navNguyenLieu.TabIndex = 2;
            navNguyenLieu.Tag = "Nguyên Liệu";
            navNguyenLieu.Text = "Nguyên Liệu";
            navNguyenLieu.TextColor = Color.White;
            navNguyenLieu.TextHover = Color.White;
            btnNavToolTip.SetToolTip(navNguyenLieu, "Nguyên Liệu");
            navNguyenLieu.UseVisualStyleBackColor = false;
            navNguyenLieu.Click += ButtonNavClick;
            navNguyenLieu.MouseDown += navNguyenLieu_MouseDown;
            // 
            // pn_caPhe
            // 
            pn_caPhe.BackColor = Color.DarkSlateGray;
            pn_caPhe.Controls.Add(navCafe);
            pn_caPhe.Dock = DockStyle.Top;
            pn_caPhe.Location = new Point(0, 148);
            pn_caPhe.Name = "pn_caPhe";
            pn_caPhe.Padding = new Padding(5);
            pn_caPhe.Size = new Size(258, 49);
            pn_caPhe.TabIndex = 5;
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
            navCafe.ImageHover = null;
            navCafe.Location = new Point(5, 5);
            navCafe.Name = "navCafe";
            navCafe.Padding = new Padding(5);
            navCafe.Size = new Size(248, 39);
            navCafe.TabIndex = 2;
            navCafe.Tag = "Cà Phê";
            navCafe.Text = "Cà Phê";
            navCafe.TextColor = Color.White;
            navCafe.TextHover = Color.White;
            btnNavToolTip.SetToolTip(navCafe, "Cà Phê");
            navCafe.UseVisualStyleBackColor = false;
            navCafe.Click += ButtonNavClick;
            navCafe.MouseDown += navCafe_MouseDown;
            // 
            // pn_khachHang
            // 
            pn_khachHang.BackColor = Color.DarkSlateGray;
            pn_khachHang.Controls.Add(navKhachHang);
            pn_khachHang.Dock = DockStyle.Top;
            pn_khachHang.Location = new Point(0, 99);
            pn_khachHang.Name = "pn_khachHang";
            pn_khachHang.Padding = new Padding(5);
            pn_khachHang.Size = new Size(258, 49);
            pn_khachHang.TabIndex = 4;
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
            navKhachHang.ImageHover = null;
            navKhachHang.Location = new Point(5, 5);
            navKhachHang.Name = "navKhachHang";
            navKhachHang.Padding = new Padding(5);
            navKhachHang.Size = new Size(248, 39);
            navKhachHang.TabIndex = 2;
            navKhachHang.Tag = "Khách Hàng";
            navKhachHang.Text = "Khách Hàng";
            navKhachHang.TextColor = Color.White;
            navKhachHang.TextHover = Color.White;
            btnNavToolTip.SetToolTip(navKhachHang, "Khách Hàng");
            navKhachHang.UseVisualStyleBackColor = false;
            navKhachHang.Click += ButtonNavClick;
            navKhachHang.MouseDown += navKhachHang_MouseDown;
            // 
            // pn_nhanVien
            // 
            pn_nhanVien.BackColor = Color.DarkSlateGray;
            pn_nhanVien.Controls.Add(navNhanVien);
            pn_nhanVien.Dock = DockStyle.Top;
            pn_nhanVien.Location = new Point(0, 50);
            pn_nhanVien.Name = "pn_nhanVien";
            pn_nhanVien.Padding = new Padding(5);
            pn_nhanVien.Size = new Size(258, 49);
            pn_nhanVien.TabIndex = 2;
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
            navNhanVien.ImageHover = null;
            navNhanVien.Location = new Point(5, 5);
            navNhanVien.Name = "navNhanVien";
            navNhanVien.Padding = new Padding(5);
            navNhanVien.Size = new Size(248, 39);
            navNhanVien.TabIndex = 2;
            navNhanVien.Tag = "Nhân Viên";
            navNhanVien.Text = "Nhân Viên";
            navNhanVien.TextColor = Color.White;
            navNhanVien.TextHover = Color.White;
            btnNavToolTip.SetToolTip(navNhanVien, "Nhân Viên");
            navNhanVien.UseVisualStyleBackColor = false;
            navNhanVien.Click += ButtonNavClick;
            navNhanVien.MouseDown += navNhanVien_MouseDown;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 49);
            label1.Name = "label1";
            label1.Size = new Size(258, 1);
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
            sideNav.Size = new Size(258, 49);
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
            sideNavBtn.ImageHover = null;
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
            backgroundMainView.BackColor = Color.SkyBlue;
            backgroundMainView.BorderRadius = 1;
            backgroundMainView.Controls.Add(mainPanelContainer);
            backgroundMainView.Controls.Add(titleBar);
            backgroundMainView.Dock = DockStyle.Fill;
            backgroundMainView.EnabledGradient = false;
            backgroundMainView.GradientAngle = 45F;
            backgroundMainView.GradientBottomColor = Color.Teal;
            backgroundMainView.GradientTopColor = Color.SkyBlue;
            backgroundMainView.Location = new Point(258, 0);
            backgroundMainView.Name = "backgroundMainView";
            backgroundMainView.Size = new Size(725, 749);
            backgroundMainView.TabIndex = 2;
            // 
            // mainPanelContainer
            // 
            mainPanelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanelContainer.BackColor = SystemColors.Control;
            mainPanelContainer.BorderRadius = 25;
            mainPanelContainer.EnabledGradient = false;
            mainPanelContainer.GradientAngle = 90F;
            mainPanelContainer.GradientBottomColor = Color.FromArgb(255, 51, 153);
            mainPanelContainer.GradientTopColor = Color.Teal;
            mainPanelContainer.Location = new Point(19, 55);
            mainPanelContainer.Name = "mainPanelContainer";
            mainPanelContainer.Size = new Size(694, 688);
            mainPanelContainer.TabIndex = 1;
            mainPanelContainer.Click += ButtonNavClick;
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
            titleBar.Controls.Add(accountIcon);
            titleBar.EnabledGradient = false;
            titleBar.GradientAngle = 45F;
            titleBar.GradientBottomColor = Color.DarkSlateGray;
            titleBar.GradientTopColor = Color.Teal;
            titleBar.Location = new Point(19, 0);
            titleBar.Name = "titleBar";
            titleBar.Padding = new Padding(10, 5, 15, 5);
            titleBar.Size = new Size(694, 50);
            titleBar.TabIndex = 0;
            // 
            // timeLblTitle
            // 
            timeLblTitle.BackColor = Color.DarkSlateGray;
            timeLblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            timeLblTitle.ForeColor = SystemColors.Control;
            timeLblTitle.Location = new Point(194, 9);
            timeLblTitle.Name = "timeLblTitle";
            timeLblTitle.Size = new Size(179, 33);
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
            customButton4.ImageHover = null;
            customButton4.Location = new Point(372, 5);
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
            customButton3.Location = new Point(446, 5);
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
            customButton2.Location = new Point(520, 5);
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
            accountIcon.ContextMenuStrip = contextMenuStrip1;
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
            accountIcon.Location = new Point(626, 5);
            accountIcon.Name = "accountIcon";
            accountIcon.Size = new Size(53, 40);
            accountIcon.TabIndex = 1;
            accountIcon.TextColor = Color.White;
            accountIcon.TextHover = Color.White;
            accountIcon.UseVisualStyleBackColor = false;
            accountIcon.Click += accountIcon_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { accMenuStrip, changePassMenuStrip, settingMenuStrip, logOutMenuStrip });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(174, 108);
            // 
            // accMenuStrip
            // 
            accMenuStrip.Image = Properties.Resources.accIcon;
            accMenuStrip.Name = "accMenuStrip";
            accMenuStrip.Size = new Size(173, 26);
            accMenuStrip.Text = "Tài Khoản";
            // 
            // changePassMenuStrip
            // 
            changePassMenuStrip.Image = Properties.Resources.changepassicon4;
            changePassMenuStrip.Name = "changePassMenuStrip";
            changePassMenuStrip.Size = new Size(173, 26);
            changePassMenuStrip.Text = "Đổi Mật Khẩu";
            // 
            // settingMenuStrip
            // 
            settingMenuStrip.Image = Properties.Resources.settingIcon;
            settingMenuStrip.Name = "settingMenuStrip";
            settingMenuStrip.Size = new Size(173, 26);
            settingMenuStrip.Text = "Cài Đặt";
            // 
            // logOutMenuStrip
            // 
            logOutMenuStrip.ForeColor = Color.Red;
            logOutMenuStrip.Image = Properties.Resources.signOutMiniIconRed;
            logOutMenuStrip.Name = "logOutMenuStrip";
            logOutMenuStrip.Size = new Size(173, 26);
            logOutMenuStrip.Text = "Đăng xuất";
            // 
            // timerLblTitle
            // 
            timerLblTitle.Interval = 1000;
            timerLblTitle.Tick += timerLblTitle_Tick;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(983, 749);
            Controls.Add(backgroundMainView);
            Controls.Add(sideBar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(799, 682);
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainView";
            WindowState = FormWindowState.Maximized;
            Load += MainView_Load;
            SizeChanged += MainView_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            sideBar.ResumeLayout(false);
            pn_loaiKhachHang.ResumeLayout(false);
            pn_phieuGiamGia.ResumeLayout(false);
            panel12.ResumeLayout(false);
            pn_phanQuyen.ResumeLayout(false);
            pn_nhaCungCap.ResumeLayout(false);
            pn_thongKe.ResumeLayout(false);
            pn_file.ResumeLayout(false);
            pn_hoaDon.ResumeLayout(false);
            pn_nhapHang.ResumeLayout(false);
            pn_nguyenLieu.ResumeLayout(false);
            pn_caPhe.ResumeLayout(false);
            pn_khachHang.ResumeLayout(false);
            pn_nhanVien.ResumeLayout(false);
            sideNav.ResumeLayout(false);
            backgroundMainView.ResumeLayout(false);
            titleBar.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

		#endregion
		private BindingSource bindingSource1;
        private CustomControl.SidePanel sideBar;
        private Label label1;
        private Panel pn_phanQuyen;
        private CustomControl.CustomButton navNhanVien;
        private Panel pn_nhanVien;
        private CustomControl.CustomButton navPhanQuyen;
        private Panel pn_khachHang;
        private CustomControl.CustomButton navNcc;
        private Panel pn_caPhe;
        private CustomControl.CustomButton navThongKe;
        private Panel pn_nguyenLieu;
        private CustomControl.CustomButton navFile;
        private Panel pn_nhapHang;
        private CustomControl.CustomButton navHoaDon;
        private Panel pn_hoaDon;
        private CustomControl.CustomButton navNhapHang;
        private Panel pn_file;
        private CustomControl.CustomButton navNguyenLieu;
        private Panel pn_thongKe;
        private CustomControl.CustomButton navCafe;
        private Panel pn_nhaCungCap;
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
        private CustomControl.CustomButton accountIcon;
        private CustomControl.CustomButton customButton4;
        private CustomControl.CustomButton customButton3;
        private CustomControl.CustomButton customButton2;
        private Label imageLblTitle;
        private Label textLblTitle;
        private Label timeLblTitle;
        private System.Windows.Forms.Timer timerLblTitle;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem accMenuStrip;
        private ToolStripMenuItem changePassMenuStrip;
        private ToolStripMenuItem settingMenuStrip;
        private ToolStripMenuItem logOutMenuStrip;
        private CustomControl.SidePanel mainPanelContainer;
        private Panel pn_phieuGiamGia;
        private CustomControl.CustomButton navPgg;
		private Panel pn_loaiKhachHang;
		private CustomControl.CustomButton navLkh;
	}
}