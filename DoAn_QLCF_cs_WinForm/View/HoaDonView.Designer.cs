namespace DoAn_QLCF_cs_WinForm.View
{
    partial class HoaDonView
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
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            tcDanhSach = new TabControl();
            tbDanhSach = new TabPage();
            resetBtn = new CustomControl.CustomButton();
            gbLoc = new GroupBox();
            rbFalse = new RadioButton();
            rbTrue = new RadioButton();
            gbSort = new GroupBox();
            grbIDPgg = new GroupBox();
            rbIDPggDec = new RadioButton();
            rbIDPggInc = new RadioButton();
            grbThanhTien = new GroupBox();
            rbThanhTienDec = new RadioButton();
            rbThanhTienInc = new RadioButton();
            grbGiamGia = new GroupBox();
            rbGiamGiaDec = new RadioButton();
            rbGiamGiaInc = new RadioButton();
            grbDonGia = new GroupBox();
            rbDonGiaDec = new RadioButton();
            rbDonGiaInc = new RadioButton();
            grbIDKH = new GroupBox();
            rbIDKHDec = new RadioButton();
            rbIDKHInc = new RadioButton();
            grbIDHD = new GroupBox();
            rbIDHDDec = new RadioButton();
            rbIDHDInc = new RadioButton();
            grbNgayBan = new GroupBox();
            rbNgayBanDec = new RadioButton();
            rbNgayBanInc = new RadioButton();
            grbIDNV = new GroupBox();
            rbIDNVDec = new RadioButton();
            rbIDNVInc = new RadioButton();
            btnSort = new CustomControl.CustomButton();
            btnLoc = new CustomControl.CustomButton();
            btnCT = new CustomControl.CustomButton();
            dgvHD = new DataGridView();
            tbChiTiet = new TabPage();
            dtpNgayBan = new DateTimePicker();
            checkboxIsAccepted = new CheckBox();
            dgvCTHD = new DataGridView();
            label13 = new Label();
            xacNhanBtn = new CustomControl.CustomButton();
            label10 = new Label();
            txtThanhTien = new CustomControl.CustomTextBox();
            label11 = new Label();
            txtGiamGia = new CustomControl.CustomTextBox();
            label12 = new Label();
            txtDonGia = new CustomControl.CustomTextBox();
            label8 = new Label();
            txtIDKhachHang = new CustomControl.CustomTextBox();
            label6 = new Label();
            label5 = new Label();
            txtIDPgg = new CustomControl.CustomTextBox();
            label3 = new Label();
            txtIDNhanVien = new CustomControl.CustomTextBox();
            label1 = new Label();
            txtIDHoaDon = new CustomControl.CustomTextBox();
            label4 = new Label();
            label7 = new Label();
            btn_back = new CustomControl.CustomButton();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            tcDanhSach.SuspendLayout();
            tbDanhSach.SuspendLayout();
            gbLoc.SuspendLayout();
            gbSort.SuspendLayout();
            grbIDPgg.SuspendLayout();
            grbThanhTien.SuspendLayout();
            grbGiamGia.SuspendLayout();
            grbDonGia.SuspendLayout();
            grbIDKH.SuspendLayout();
            grbIDHD.SuspendLayout();
            grbNgayBan.SuspendLayout();
            grbIDNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            tbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).BeginInit();
            SuspendLayout();
            // 
            // tcDanhSach
            // 
            tcDanhSach.Controls.Add(tbDanhSach);
            tcDanhSach.Controls.Add(tbChiTiet);
            tcDanhSach.Dock = DockStyle.Fill;
            tcDanhSach.Location = new Point(0, 0);
            tcDanhSach.Name = "tcDanhSach";
            tcDanhSach.SelectedIndex = 0;
            tcDanhSach.Size = new Size(969, 603);
            tcDanhSach.TabIndex = 0;
            // 
            // tbDanhSach
            // 
            tbDanhSach.BackColor = SystemColors.Control;
            tbDanhSach.Controls.Add(resetBtn);
            tbDanhSach.Controls.Add(gbLoc);
            tbDanhSach.Controls.Add(gbSort);
            tbDanhSach.Controls.Add(btnSort);
            tbDanhSach.Controls.Add(btnLoc);
            tbDanhSach.Controls.Add(btnCT);
            tbDanhSach.Controls.Add(dgvHD);
            tbDanhSach.Location = new Point(4, 24);
            tbDanhSach.Name = "tbDanhSach";
            tbDanhSach.Padding = new Padding(3);
            tbDanhSach.Size = new Size(961, 575);
            tbDanhSach.TabIndex = 0;
            tbDanhSach.Text = "Danh sách";
            // 
            // resetBtn
            // 
            resetBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            resetBtn.BackColor = SystemColors.Control;
            resetBtn.BackgroundColor = SystemColors.Control;
            resetBtn.BorderColor = Color.Gray;
            resetBtn.BorderRadius = 15;
            resetBtn.BorderSize = 2;
            resetBtn.EnabledTextHover = true;
            resetBtn.FlatAppearance.BorderSize = 0;
            resetBtn.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            resetBtn.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.ForeColor = Color.DarkGray;
            resetBtn.ImageAlign = ContentAlignment.MiddleRight;
            resetBtn.ImageHover = null;
            resetBtn.Location = new Point(813, 32);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(120, 38);
            resetBtn.TabIndex = 37;
            resetBtn.Text = "Reset";
            resetBtn.TextColor = Color.DarkGray;
            resetBtn.TextHover = Color.White;
            resetBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // gbLoc
            // 
            gbLoc.Controls.Add(rbFalse);
            gbLoc.Controls.Add(rbTrue);
            gbLoc.Location = new Point(245, 54);
            gbLoc.Name = "gbLoc";
            gbLoc.Size = new Size(441, 111);
            gbLoc.TabIndex = 29;
            gbLoc.TabStop = false;
            gbLoc.Visible = false;
            // 
            // rbFalse
            // 
            rbFalse.AutoSize = true;
            rbFalse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbFalse.Location = new Point(239, 47);
            rbFalse.Margin = new Padding(2);
            rbFalse.Name = "rbFalse";
            rbFalse.Size = new Size(156, 25);
            rbFalse.TabIndex = 2;
            rbFalse.TabStop = true;
            rbFalse.Tag = "NotAcp";
            rbFalse.Text = "Chưa thanh toán";
            rbFalse.UseVisualStyleBackColor = true;
            // 
            // rbTrue
            // 
            rbTrue.AutoSize = true;
            rbTrue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbTrue.Location = new Point(42, 46);
            rbTrue.Margin = new Padding(2);
            rbTrue.Name = "rbTrue";
            rbTrue.Size = new Size(137, 25);
            rbTrue.TabIndex = 1;
            rbTrue.TabStop = true;
            rbTrue.Tag = "IsAcp";
            rbTrue.Text = "Đã thanh toán";
            rbTrue.UseVisualStyleBackColor = true;
            // 
            // gbSort
            // 
            gbSort.Controls.Add(grbIDPgg);
            gbSort.Controls.Add(grbThanhTien);
            gbSort.Controls.Add(grbGiamGia);
            gbSort.Controls.Add(grbDonGia);
            gbSort.Controls.Add(grbIDKH);
            gbSort.Controls.Add(grbIDHD);
            gbSort.Controls.Add(grbNgayBan);
            gbSort.Controls.Add(grbIDNV);
            gbSort.Location = new Point(8, 75);
            gbSort.Margin = new Padding(2);
            gbSort.Name = "gbSort";
            gbSort.Padding = new Padding(2);
            gbSort.Size = new Size(925, 90);
            gbSort.TabIndex = 28;
            gbSort.TabStop = false;
            gbSort.Visible = false;
            // 
            // grbIDPgg
            // 
            grbIDPgg.Controls.Add(rbIDPggDec);
            grbIDPgg.Controls.Add(rbIDPggInc);
            grbIDPgg.Location = new Point(350, 14);
            grbIDPgg.Margin = new Padding(2);
            grbIDPgg.Name = "grbIDPgg";
            grbIDPgg.Padding = new Padding(2);
            grbIDPgg.Size = new Size(98, 65);
            grbIDPgg.TabIndex = 25;
            grbIDPgg.TabStop = false;
            grbIDPgg.Text = "ID Phiếu giảm giá";
            // 
            // rbIDPggDec
            // 
            rbIDPggDec.AutoSize = true;
            rbIDPggDec.Location = new Point(10, 37);
            rbIDPggDec.Margin = new Padding(2);
            rbIDPggDec.Name = "rbIDPggDec";
            rbIDPggDec.Size = new Size(53, 19);
            rbIDPggDec.TabIndex = 1;
            rbIDPggDec.TabStop = true;
            rbIDPggDec.Tag = "IDPggDec";
            rbIDPggDec.Text = "Giảm";
            rbIDPggDec.UseVisualStyleBackColor = true;
            // 
            // rbIDPggInc
            // 
            rbIDPggInc.AutoSize = true;
            rbIDPggInc.Location = new Point(10, 16);
            rbIDPggInc.Margin = new Padding(2);
            rbIDPggInc.Name = "rbIDPggInc";
            rbIDPggInc.Size = new Size(50, 19);
            rbIDPggInc.TabIndex = 0;
            rbIDPggInc.TabStop = true;
            rbIDPggInc.Tag = "IDPggInc";
            rbIDPggInc.Text = "Tăng";
            rbIDPggInc.UseVisualStyleBackColor = true;
            // 
            // grbThanhTien
            // 
            grbThanhTien.Controls.Add(rbThanhTienDec);
            grbThanhTien.Controls.Add(rbThanhTienInc);
            grbThanhTien.Location = new Point(807, 14);
            grbThanhTien.Margin = new Padding(2);
            grbThanhTien.Name = "grbThanhTien";
            grbThanhTien.Padding = new Padding(2);
            grbThanhTien.Size = new Size(98, 65);
            grbThanhTien.TabIndex = 27;
            grbThanhTien.TabStop = false;
            grbThanhTien.Text = "Thành tiền";
            // 
            // rbThanhTienDec
            // 
            rbThanhTienDec.AutoSize = true;
            rbThanhTienDec.Location = new Point(8, 35);
            rbThanhTienDec.Margin = new Padding(2);
            rbThanhTienDec.Name = "rbThanhTienDec";
            rbThanhTienDec.Size = new Size(53, 19);
            rbThanhTienDec.TabIndex = 1;
            rbThanhTienDec.TabStop = true;
            rbThanhTienDec.Tag = "ThanhTienDec";
            rbThanhTienDec.Text = "Giảm";
            rbThanhTienDec.UseVisualStyleBackColor = true;
            // 
            // rbThanhTienInc
            // 
            rbThanhTienInc.AutoSize = true;
            rbThanhTienInc.Location = new Point(8, 14);
            rbThanhTienInc.Margin = new Padding(2);
            rbThanhTienInc.Name = "rbThanhTienInc";
            rbThanhTienInc.Size = new Size(50, 19);
            rbThanhTienInc.TabIndex = 0;
            rbThanhTienInc.TabStop = true;
            rbThanhTienInc.Tag = "ThanhTienInc";
            rbThanhTienInc.Text = "Tăng";
            rbThanhTienInc.UseVisualStyleBackColor = true;
            // 
            // grbGiamGia
            // 
            grbGiamGia.Controls.Add(rbGiamGiaDec);
            grbGiamGia.Controls.Add(rbGiamGiaInc);
            grbGiamGia.Location = new Point(695, 14);
            grbGiamGia.Margin = new Padding(2);
            grbGiamGia.Name = "grbGiamGia";
            grbGiamGia.Padding = new Padding(2);
            grbGiamGia.Size = new Size(98, 65);
            grbGiamGia.TabIndex = 26;
            grbGiamGia.TabStop = false;
            grbGiamGia.Text = "Giảm giá";
            // 
            // rbGiamGiaDec
            // 
            rbGiamGiaDec.AutoSize = true;
            rbGiamGiaDec.Location = new Point(9, 36);
            rbGiamGiaDec.Margin = new Padding(2);
            rbGiamGiaDec.Name = "rbGiamGiaDec";
            rbGiamGiaDec.Size = new Size(53, 19);
            rbGiamGiaDec.TabIndex = 1;
            rbGiamGiaDec.TabStop = true;
            rbGiamGiaDec.Tag = "GiamGiaDec";
            rbGiamGiaDec.Text = "Giảm";
            rbGiamGiaDec.UseVisualStyleBackColor = true;
            // 
            // rbGiamGiaInc
            // 
            rbGiamGiaInc.AutoSize = true;
            rbGiamGiaInc.Location = new Point(9, 15);
            rbGiamGiaInc.Margin = new Padding(2);
            rbGiamGiaInc.Name = "rbGiamGiaInc";
            rbGiamGiaInc.Size = new Size(50, 19);
            rbGiamGiaInc.TabIndex = 0;
            rbGiamGiaInc.TabStop = true;
            rbGiamGiaInc.Tag = "GiamGiaInc";
            rbGiamGiaInc.Text = "Tăng";
            rbGiamGiaInc.UseVisualStyleBackColor = true;
            // 
            // grbDonGia
            // 
            grbDonGia.Controls.Add(rbDonGiaDec);
            grbDonGia.Controls.Add(rbDonGiaInc);
            grbDonGia.Location = new Point(580, 14);
            grbDonGia.Margin = new Padding(2);
            grbDonGia.Name = "grbDonGia";
            grbDonGia.Padding = new Padding(2);
            grbDonGia.Size = new Size(98, 65);
            grbDonGia.TabIndex = 25;
            grbDonGia.TabStop = false;
            grbDonGia.Text = "Đơn giá";
            // 
            // rbDonGiaDec
            // 
            rbDonGiaDec.AutoSize = true;
            rbDonGiaDec.Location = new Point(10, 37);
            rbDonGiaDec.Margin = new Padding(2);
            rbDonGiaDec.Name = "rbDonGiaDec";
            rbDonGiaDec.Size = new Size(53, 19);
            rbDonGiaDec.TabIndex = 1;
            rbDonGiaDec.TabStop = true;
            rbDonGiaDec.Tag = "DonGiaDec";
            rbDonGiaDec.Text = "Giảm";
            rbDonGiaDec.UseVisualStyleBackColor = true;
            // 
            // rbDonGiaInc
            // 
            rbDonGiaInc.AutoSize = true;
            rbDonGiaInc.Location = new Point(10, 16);
            rbDonGiaInc.Margin = new Padding(2);
            rbDonGiaInc.Name = "rbDonGiaInc";
            rbDonGiaInc.Size = new Size(50, 19);
            rbDonGiaInc.TabIndex = 0;
            rbDonGiaInc.TabStop = true;
            rbDonGiaInc.Tag = "DonGiaInc";
            rbDonGiaInc.Text = "Tăng";
            rbDonGiaInc.UseVisualStyleBackColor = true;
            // 
            // grbIDKH
            // 
            grbIDKH.Controls.Add(rbIDKHDec);
            grbIDKH.Controls.Add(rbIDKHInc);
            grbIDKH.Location = new Point(237, 14);
            grbIDKH.Margin = new Padding(2);
            grbIDKH.Name = "grbIDKH";
            grbIDKH.Padding = new Padding(2);
            grbIDKH.Size = new Size(98, 65);
            grbIDKH.TabIndex = 24;
            grbIDKH.TabStop = false;
            grbIDKH.Text = "ID Khách hàng";
            // 
            // rbIDKHDec
            // 
            rbIDKHDec.AutoSize = true;
            rbIDKHDec.Location = new Point(11, 38);
            rbIDKHDec.Margin = new Padding(2);
            rbIDKHDec.Name = "rbIDKHDec";
            rbIDKHDec.Size = new Size(53, 19);
            rbIDKHDec.TabIndex = 1;
            rbIDKHDec.TabStop = true;
            rbIDKHDec.Tag = "IDKHDec";
            rbIDKHDec.Text = "Giảm";
            rbIDKHDec.UseVisualStyleBackColor = true;
            // 
            // rbIDKHInc
            // 
            rbIDKHInc.AutoSize = true;
            rbIDKHInc.Location = new Point(11, 17);
            rbIDKHInc.Margin = new Padding(2);
            rbIDKHInc.Name = "rbIDKHInc";
            rbIDKHInc.Size = new Size(50, 19);
            rbIDKHInc.TabIndex = 0;
            rbIDKHInc.TabStop = true;
            rbIDKHInc.Tag = "IDKHInc";
            rbIDKHInc.Text = "Tăng";
            rbIDKHInc.UseVisualStyleBackColor = true;
            // 
            // grbIDHD
            // 
            grbIDHD.Controls.Add(rbIDHDDec);
            grbIDHD.Controls.Add(rbIDHDInc);
            grbIDHD.Location = new Point(4, 14);
            grbIDHD.Margin = new Padding(2);
            grbIDHD.Name = "grbIDHD";
            grbIDHD.Padding = new Padding(2);
            grbIDHD.Size = new Size(98, 65);
            grbIDHD.TabIndex = 23;
            grbIDHD.TabStop = false;
            grbIDHD.Text = "ID Hoá đơn";
            // 
            // rbIDHDDec
            // 
            rbIDHDDec.AutoSize = true;
            rbIDHDDec.Location = new Point(11, 38);
            rbIDHDDec.Margin = new Padding(2);
            rbIDHDDec.Name = "rbIDHDDec";
            rbIDHDDec.Size = new Size(53, 19);
            rbIDHDDec.TabIndex = 1;
            rbIDHDDec.TabStop = true;
            rbIDHDDec.Tag = "IDHDDec";
            rbIDHDDec.Text = "Giảm";
            rbIDHDDec.UseVisualStyleBackColor = true;
            // 
            // rbIDHDInc
            // 
            rbIDHDInc.AutoSize = true;
            rbIDHDInc.Location = new Point(11, 17);
            rbIDHDInc.Margin = new Padding(2);
            rbIDHDInc.Name = "rbIDHDInc";
            rbIDHDInc.Size = new Size(50, 19);
            rbIDHDInc.TabIndex = 0;
            rbIDHDInc.TabStop = true;
            rbIDHDInc.Tag = "IDHDInc";
            rbIDHDInc.Text = "Tăng";
            rbIDHDInc.UseVisualStyleBackColor = true;
            // 
            // grbNgayBan
            // 
            grbNgayBan.Controls.Add(rbNgayBanDec);
            grbNgayBan.Controls.Add(rbNgayBanInc);
            grbNgayBan.Location = new Point(466, 14);
            grbNgayBan.Margin = new Padding(2);
            grbNgayBan.Name = "grbNgayBan";
            grbNgayBan.Padding = new Padding(2);
            grbNgayBan.Size = new Size(98, 65);
            grbNgayBan.TabIndex = 24;
            grbNgayBan.TabStop = false;
            grbNgayBan.Text = "Ngày bán";
            // 
            // rbNgayBanDec
            // 
            rbNgayBanDec.AutoSize = true;
            rbNgayBanDec.Location = new Point(11, 38);
            rbNgayBanDec.Margin = new Padding(2);
            rbNgayBanDec.Name = "rbNgayBanDec";
            rbNgayBanDec.Size = new Size(53, 19);
            rbNgayBanDec.TabIndex = 1;
            rbNgayBanDec.TabStop = true;
            rbNgayBanDec.Tag = "NgayBanDec";
            rbNgayBanDec.Text = "Giảm";
            rbNgayBanDec.UseVisualStyleBackColor = true;
            // 
            // rbNgayBanInc
            // 
            rbNgayBanInc.AutoSize = true;
            rbNgayBanInc.Location = new Point(11, 17);
            rbNgayBanInc.Margin = new Padding(2);
            rbNgayBanInc.Name = "rbNgayBanInc";
            rbNgayBanInc.Size = new Size(50, 19);
            rbNgayBanInc.TabIndex = 0;
            rbNgayBanInc.TabStop = true;
            rbNgayBanInc.Tag = "NgayBanInc";
            rbNgayBanInc.Text = "Tăng";
            rbNgayBanInc.UseVisualStyleBackColor = true;
            // 
            // grbIDNV
            // 
            grbIDNV.Controls.Add(rbIDNVDec);
            grbIDNV.Controls.Add(rbIDNVInc);
            grbIDNV.Location = new Point(121, 14);
            grbIDNV.Margin = new Padding(2);
            grbIDNV.Name = "grbIDNV";
            grbIDNV.Padding = new Padding(2);
            grbIDNV.Size = new Size(98, 65);
            grbIDNV.TabIndex = 24;
            grbIDNV.TabStop = false;
            grbIDNV.Text = "ID Nhân viên";
            // 
            // rbIDNVDec
            // 
            rbIDNVDec.AutoSize = true;
            rbIDNVDec.Location = new Point(11, 38);
            rbIDNVDec.Margin = new Padding(2);
            rbIDNVDec.Name = "rbIDNVDec";
            rbIDNVDec.Size = new Size(53, 19);
            rbIDNVDec.TabIndex = 1;
            rbIDNVDec.TabStop = true;
            rbIDNVDec.Tag = "IDNVDec";
            rbIDNVDec.Text = "Giảm";
            rbIDNVDec.UseVisualStyleBackColor = true;
            // 
            // rbIDNVInc
            // 
            rbIDNVInc.AutoSize = true;
            rbIDNVInc.Location = new Point(11, 17);
            rbIDNVInc.Margin = new Padding(2);
            rbIDNVInc.Name = "rbIDNVInc";
            rbIDNVInc.Size = new Size(50, 19);
            rbIDNVInc.TabIndex = 0;
            rbIDNVInc.TabStop = true;
            rbIDNVInc.Tag = "IDNVInc";
            rbIDNVInc.Text = "Tăng";
            rbIDNVInc.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            btnSort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSort.BackColor = SystemColors.Control;
            btnSort.BackgroundColor = SystemColors.Control;
            btnSort.BorderColor = Color.DeepSkyBlue;
            btnSort.BorderRadius = 15;
            btnSort.BorderSize = 2;
            btnSort.Cursor = Cursors.Hand;
            btnSort.EnabledTextHover = true;
            btnSort.FlatAppearance.BorderSize = 0;
            btnSort.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btnSort.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnSort.FlatStyle = FlatStyle.Flat;
            btnSort.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSort.ForeColor = Color.DeepSkyBlue;
            btnSort.ImageAlign = ContentAlignment.MiddleRight;
            btnSort.ImageHover = null;
            btnSort.Location = new Point(129, 3);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(130, 43);
            btnSort.TabIndex = 24;
            btnSort.Text = "Sắp xếp";
            btnSort.TextColor = Color.DeepSkyBlue;
            btnSort.TextHover = Color.White;
            btnSort.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // btnLoc
            // 
            btnLoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoc.BackColor = SystemColors.Control;
            btnLoc.BackgroundColor = SystemColors.Control;
            btnLoc.BorderColor = Color.Goldenrod;
            btnLoc.BorderRadius = 15;
            btnLoc.BorderSize = 2;
            btnLoc.Cursor = Cursors.Hand;
            btnLoc.EnabledTextHover = true;
            btnLoc.FlatAppearance.BorderSize = 0;
            btnLoc.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            btnLoc.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnLoc.FlatStyle = FlatStyle.Flat;
            btnLoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoc.ForeColor = Color.Goldenrod;
            btnLoc.ImageAlign = ContentAlignment.MiddleRight;
            btnLoc.ImageHover = null;
            btnLoc.Location = new Point(8, 3);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(115, 43);
            btnLoc.TabIndex = 23;
            btnLoc.Text = "Lọc";
            btnLoc.TextColor = Color.Goldenrod;
            btnLoc.TextHover = Color.White;
            btnLoc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // btnCT
            // 
            btnCT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCT.BackColor = SystemColors.Control;
            btnCT.BackgroundColor = SystemColors.Control;
            btnCT.BorderColor = Color.DarkCyan;
            btnCT.BorderRadius = 15;
            btnCT.BorderSize = 2;
            btnCT.Cursor = Cursors.Hand;
            btnCT.EnabledTextHover = true;
            btnCT.FlatAppearance.BorderSize = 0;
            btnCT.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnCT.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnCT.FlatStyle = FlatStyle.Flat;
            btnCT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCT.ForeColor = Color.DarkCyan;
            btnCT.Image = Properties.Resources.detailsIcon16px;
            btnCT.ImageAlign = ContentAlignment.MiddleRight;
            btnCT.ImageHover = Properties.Resources.detailsIcon16pxWHITE;
            btnCT.Location = new Point(265, 3);
            btnCT.Name = "btnCT";
            btnCT.Size = new Size(124, 43);
            btnCT.TabIndex = 16;
            btnCT.Text = "  Chi Tiết";
            btnCT.TextColor = Color.DarkCyan;
            btnCT.TextHover = Color.White;
            btnCT.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCT.UseVisualStyleBackColor = false;
            btnCT.Click += btnCT_Click;
            // 
            // dgvHD
            // 
            dgvHD.AllowUserToAddRows = false;
            dgvHD.AllowUserToDeleteRows = false;
            dgvHD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHD.BorderStyle = BorderStyle.None;
            dgvHD.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = Color.DarkCyan;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = SystemColors.Control;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dgvHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dgvHD.ColumnHeadersHeight = 30;
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = SystemColors.Window;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            dgvHD.DefaultCellStyle = dataGridViewCellStyle20;
            dgvHD.EnableHeadersVisualStyles = false;
            dgvHD.GridColor = Color.DarkCyan;
            dgvHD.ImeMode = ImeMode.NoControl;
            dgvHD.Location = new Point(-4, 170);
            dgvHD.Name = "dgvHD";
            dgvHD.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvHD.RowHeadersVisible = false;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHD.RowsDefaultCellStyle = dataGridViewCellStyle21;
            dgvHD.RowTemplate.Height = 25;
            dgvHD.RowTemplate.ReadOnly = true;
            dgvHD.Size = new Size(982, 405);
            dgvHD.TabIndex = 2;
            dgvHD.CellClick += dgvHD_CellClick;
            // 
            // tbChiTiet
            // 
            tbChiTiet.BackColor = SystemColors.Control;
            tbChiTiet.Controls.Add(dtpNgayBan);
            tbChiTiet.Controls.Add(checkboxIsAccepted);
            tbChiTiet.Controls.Add(dgvCTHD);
            tbChiTiet.Controls.Add(label13);
            tbChiTiet.Controls.Add(xacNhanBtn);
            tbChiTiet.Controls.Add(label10);
            tbChiTiet.Controls.Add(txtThanhTien);
            tbChiTiet.Controls.Add(label11);
            tbChiTiet.Controls.Add(txtGiamGia);
            tbChiTiet.Controls.Add(label12);
            tbChiTiet.Controls.Add(txtDonGia);
            tbChiTiet.Controls.Add(label8);
            tbChiTiet.Controls.Add(txtIDKhachHang);
            tbChiTiet.Controls.Add(label6);
            tbChiTiet.Controls.Add(label5);
            tbChiTiet.Controls.Add(txtIDPgg);
            tbChiTiet.Controls.Add(label3);
            tbChiTiet.Controls.Add(txtIDNhanVien);
            tbChiTiet.Controls.Add(label1);
            tbChiTiet.Controls.Add(txtIDHoaDon);
            tbChiTiet.Controls.Add(label4);
            tbChiTiet.Controls.Add(label7);
            tbChiTiet.Controls.Add(btn_back);
            tbChiTiet.Location = new Point(4, 24);
            tbChiTiet.Name = "tbChiTiet";
            tbChiTiet.Padding = new Padding(3);
            tbChiTiet.Size = new Size(961, 575);
            tbChiTiet.TabIndex = 1;
            tbChiTiet.Text = "Chi tiết";
            // 
            // dtpNgayBan
            // 
            dtpNgayBan.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayBan.Location = new Point(317, 194);
            dtpNgayBan.Name = "dtpNgayBan";
            dtpNgayBan.Size = new Size(275, 31);
            dtpNgayBan.TabIndex = 79;
            // 
            // checkboxIsAccepted
            // 
            checkboxIsAccepted.AutoSize = true;
            checkboxIsAccepted.Location = new Point(721, 281);
            checkboxIsAccepted.Margin = new Padding(2);
            checkboxIsAccepted.Name = "checkboxIsAccepted";
            checkboxIsAccepted.Size = new Size(15, 14);
            checkboxIsAccepted.TabIndex = 78;
            checkboxIsAccepted.UseVisualStyleBackColor = true;
            // 
            // dgvCTHD
            // 
            dgvCTHD.AllowUserToAddRows = false;
            dgvCTHD.AllowUserToDeleteRows = false;
            dgvCTHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTHD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCTHD.BorderStyle = BorderStyle.None;
            dgvCTHD.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = Color.DarkCyan;
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = SystemColors.Control;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            dgvCTHD.ColumnHeadersHeight = 30;
            dgvCTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = SystemColors.Window;
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle23.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            dgvCTHD.DefaultCellStyle = dataGridViewCellStyle23;
            dgvCTHD.Dock = DockStyle.Bottom;
            dgvCTHD.EnableHeadersVisualStyles = false;
            dgvCTHD.GridColor = Color.DarkCyan;
            dgvCTHD.ImeMode = ImeMode.NoControl;
            dgvCTHD.Location = new Point(3, 343);
            dgvCTHD.Name = "dgvCTHD";
            dgvCTHD.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCTHD.RowHeadersVisible = false;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCTHD.RowsDefaultCellStyle = dataGridViewCellStyle24;
            dgvCTHD.RowTemplate.Height = 25;
            dgvCTHD.RowTemplate.ReadOnly = true;
            dgvCTHD.Size = new Size(955, 229);
            dgvCTHD.TabIndex = 40;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(8, 312);
            label13.Name = "label13";
            label13.Size = new Size(166, 35);
            label13.TabIndex = 39;
            label13.Text = "Danh sách cà phê";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // xacNhanBtn
            // 
            xacNhanBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            xacNhanBtn.BackColor = SystemColors.Control;
            xacNhanBtn.BackgroundColor = SystemColors.Control;
            xacNhanBtn.BorderColor = Color.DarkCyan;
            xacNhanBtn.BorderRadius = 15;
            xacNhanBtn.BorderSize = 2;
            xacNhanBtn.Cursor = Cursors.Hand;
            xacNhanBtn.EnabledTextHover = true;
            xacNhanBtn.FlatAppearance.BorderSize = 0;
            xacNhanBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            xacNhanBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            xacNhanBtn.FlatStyle = FlatStyle.Flat;
            xacNhanBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            xacNhanBtn.ForeColor = Color.DarkCyan;
            xacNhanBtn.Image = Properties.Resources.ConfirmIcondarkcyan1;
            xacNhanBtn.ImageAlign = ContentAlignment.MiddleRight;
            xacNhanBtn.ImageHover = Properties.Resources.ConfirmIconWhite1;
            xacNhanBtn.Location = new Point(836, 11);
            xacNhanBtn.Name = "xacNhanBtn";
            xacNhanBtn.Size = new Size(117, 40);
            xacNhanBtn.TabIndex = 37;
            xacNhanBtn.Text = "  Xác Nhận";
            xacNhanBtn.TextColor = Color.DarkCyan;
            xacNhanBtn.TextHover = Color.White;
            xacNhanBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            xacNhanBtn.UseVisualStyleBackColor = false;
            xacNhanBtn.Click += xacNhanBtn_Click;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(578, 267);
            label10.Name = "label10";
            label10.Size = new Size(158, 36);
            label10.TabIndex = 35;
            label10.Text = "Đã thanh toán:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtThanhTien
            // 
            txtThanhTien.BackColor = SystemColors.Window;
            txtThanhTien.BorderColor = Color.Silver;
            txtThanhTien.BorderFocusColor = Color.DarkCyan;
            txtThanhTien.BorderRadius = 13;
            txtThanhTien.BorderSize = 2;
            txtThanhTien.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtThanhTien.ForeColor = Color.DimGray;
            txtThanhTien.Location = new Point(317, 267);
            txtThanhTien.Multiline = false;
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Padding = new Padding(9, 9, 7, 7);
            txtThanhTien.PasswordChar = false;
            txtThanhTien.PlaceholderColor = Color.DarkGray;
            txtThanhTien.PlaceholderText = "--------------";
            txtThanhTien.Size = new Size(244, 42);
            txtThanhTien.TabIndex = 34;
            txtThanhTien.Texts = "";
            txtThanhTien.UnderlinedStyle = false;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(287, 228);
            label11.Name = "label11";
            label11.Size = new Size(145, 51);
            label11.TabIndex = 33;
            label11.Text = "Thành tiền";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGiamGia
            // 
            txtGiamGia.BackColor = SystemColors.Window;
            txtGiamGia.BorderColor = Color.Silver;
            txtGiamGia.BorderFocusColor = Color.DarkCyan;
            txtGiamGia.BorderRadius = 13;
            txtGiamGia.BorderSize = 2;
            txtGiamGia.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiamGia.ForeColor = Color.DimGray;
            txtGiamGia.Location = new Point(47, 267);
            txtGiamGia.Multiline = false;
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Padding = new Padding(9, 9, 7, 7);
            txtGiamGia.PasswordChar = false;
            txtGiamGia.PlaceholderColor = Color.DarkGray;
            txtGiamGia.PlaceholderText = "----------------";
            txtGiamGia.Size = new Size(244, 42);
            txtGiamGia.TabIndex = 32;
            txtGiamGia.Texts = "";
            txtGiamGia.UnderlinedStyle = false;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(30, 228);
            label12.Name = "label12";
            label12.Size = new Size(106, 51);
            label12.TabIndex = 31;
            label12.Text = "Giảm Giá";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDonGia
            // 
            txtDonGia.BackColor = SystemColors.Window;
            txtDonGia.BorderColor = Color.Silver;
            txtDonGia.BorderFocusColor = Color.DarkCyan;
            txtDonGia.BorderRadius = 13;
            txtDonGia.BorderSize = 2;
            txtDonGia.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonGia.ForeColor = Color.DimGray;
            txtDonGia.Location = new Point(611, 183);
            txtDonGia.Multiline = false;
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Padding = new Padding(9, 9, 7, 7);
            txtDonGia.PasswordChar = false;
            txtDonGia.PlaceholderColor = Color.DarkGray;
            txtDonGia.PlaceholderText = "---------------";
            txtDonGia.Size = new Size(244, 42);
            txtDonGia.TabIndex = 30;
            txtDonGia.Texts = "";
            txtDonGia.UnderlinedStyle = false;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(571, 150);
            label8.Name = "label8";
            label8.Size = new Size(165, 44);
            label8.TabIndex = 29;
            label8.Text = "Đơn giá";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIDKhachHang
            // 
            txtIDKhachHang.BackColor = SystemColors.Window;
            txtIDKhachHang.BorderColor = Color.Silver;
            txtIDKhachHang.BorderFocusColor = Color.DarkCyan;
            txtIDKhachHang.BorderRadius = 13;
            txtIDKhachHang.BorderSize = 2;
            txtIDKhachHang.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDKhachHang.ForeColor = Color.DimGray;
            txtIDKhachHang.Location = new Point(611, 100);
            txtIDKhachHang.Multiline = false;
            txtIDKhachHang.Name = "txtIDKhachHang";
            txtIDKhachHang.Padding = new Padding(9, 9, 7, 7);
            txtIDKhachHang.PasswordChar = false;
            txtIDKhachHang.PlaceholderColor = Color.DarkGray;
            txtIDKhachHang.PlaceholderText = "Nhập....";
            txtIDKhachHang.Size = new Size(244, 42);
            txtIDKhachHang.TabIndex = 28;
            txtIDKhachHang.Texts = "";
            txtIDKhachHang.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(611, 70);
            label6.Name = "label6";
            label6.Size = new Size(117, 36);
            label6.TabIndex = 27;
            label6.Text = "ID Khách Hàng";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(307, 154);
            label5.Name = "label5";
            label5.Size = new Size(106, 37);
            label5.TabIndex = 25;
            label5.Text = "Ngày bán";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIDPgg
            // 
            txtIDPgg.BackColor = SystemColors.Window;
            txtIDPgg.BorderColor = Color.Silver;
            txtIDPgg.BorderFocusColor = Color.DarkCyan;
            txtIDPgg.BorderRadius = 13;
            txtIDPgg.BorderSize = 2;
            txtIDPgg.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDPgg.ForeColor = Color.DimGray;
            txtIDPgg.Location = new Point(47, 186);
            txtIDPgg.Multiline = false;
            txtIDPgg.Name = "txtIDPgg";
            txtIDPgg.Padding = new Padding(9, 9, 7, 7);
            txtIDPgg.PasswordChar = false;
            txtIDPgg.PlaceholderColor = Color.DarkGray;
            txtIDPgg.PlaceholderText = "Nhập ID giảm giá....";
            txtIDPgg.Size = new Size(244, 42);
            txtIDPgg.TabIndex = 24;
            txtIDPgg.Texts = "";
            txtIDPgg.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 150);
            label3.Name = "label3";
            label3.Size = new Size(156, 44);
            label3.TabIndex = 23;
            label3.Text = "ID Phiếu Giảm Giá";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIDNhanVien
            // 
            txtIDNhanVien.BackColor = SystemColors.Window;
            txtIDNhanVien.BorderColor = Color.Silver;
            txtIDNhanVien.BorderFocusColor = Color.DarkCyan;
            txtIDNhanVien.BorderRadius = 13;
            txtIDNhanVien.BorderSize = 2;
            txtIDNhanVien.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDNhanVien.ForeColor = Color.DimGray;
            txtIDNhanVien.Location = new Point(317, 100);
            txtIDNhanVien.Multiline = false;
            txtIDNhanVien.Name = "txtIDNhanVien";
            txtIDNhanVien.Padding = new Padding(9, 9, 7, 7);
            txtIDNhanVien.PasswordChar = false;
            txtIDNhanVien.PlaceholderColor = Color.DarkGray;
            txtIDNhanVien.PlaceholderText = "Nhập....";
            txtIDNhanVien.Size = new Size(244, 42);
            txtIDNhanVien.TabIndex = 22;
            txtIDNhanVien.Texts = "";
            txtIDNhanVien.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(317, 61);
            label1.Name = "label1";
            label1.Size = new Size(106, 51);
            label1.TabIndex = 21;
            label1.Text = "ID Nhân Viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIDHoaDon
            // 
            txtIDHoaDon.BackColor = SystemColors.Window;
            txtIDHoaDon.BorderColor = Color.Silver;
            txtIDHoaDon.BorderFocusColor = Color.DarkCyan;
            txtIDHoaDon.BorderRadius = 13;
            txtIDHoaDon.BorderSize = 2;
            txtIDHoaDon.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDHoaDon.ForeColor = Color.DimGray;
            txtIDHoaDon.Location = new Point(47, 100);
            txtIDHoaDon.Multiline = false;
            txtIDHoaDon.Name = "txtIDHoaDon";
            txtIDHoaDon.Padding = new Padding(9, 9, 7, 7);
            txtIDHoaDon.PasswordChar = false;
            txtIDHoaDon.PlaceholderColor = Color.DarkGray;
            txtIDHoaDon.PlaceholderText = "Nhập ID....";
            txtIDHoaDon.Size = new Size(244, 42);
            txtIDHoaDon.TabIndex = 20;
            txtIDHoaDon.Texts = "";
            txtIDHoaDon.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 63);
            label4.Name = "label4";
            label4.Size = new Size(106, 51);
            label4.TabIndex = 19;
            label4.Text = "ID";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(81, 7);
            label7.Name = "label7";
            label7.Size = new Size(210, 43);
            label7.TabIndex = 18;
            label7.Text = "Thông Tin Chi Tiết";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.BackgroundColor = Color.Transparent;
            btn_back.BorderColor = Color.PaleVioletRed;
            btn_back.BorderRadius = 20;
            btn_back.BorderSize = 0;
            btn_back.Cursor = Cursors.Hand;
            btn_back.EnabledTextHover = false;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_back.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = Color.White;
            btn_back.Image = Properties.Resources.arrowreturn32pxBlack1;
            btn_back.ImageHover = Properties.Resources.arrowreturn32pxWhite1;
            btn_back.Location = new Point(8, 10);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(63, 41);
            btn_back.TabIndex = 17;
            btn_back.TextColor = Color.White;
            btn_back.TextHover = Color.White;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // HoaDonView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 603);
            Controls.Add(tcDanhSach);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HoaDonView";
            Text = "HoaDonView";
            tcDanhSach.ResumeLayout(false);
            tbDanhSach.ResumeLayout(false);
            gbLoc.ResumeLayout(false);
            gbLoc.PerformLayout();
            gbSort.ResumeLayout(false);
            grbIDPgg.ResumeLayout(false);
            grbIDPgg.PerformLayout();
            grbThanhTien.ResumeLayout(false);
            grbThanhTien.PerformLayout();
            grbGiamGia.ResumeLayout(false);
            grbGiamGia.PerformLayout();
            grbDonGia.ResumeLayout(false);
            grbDonGia.PerformLayout();
            grbIDKH.ResumeLayout(false);
            grbIDKH.PerformLayout();
            grbIDHD.ResumeLayout(false);
            grbIDHD.PerformLayout();
            grbNgayBan.ResumeLayout(false);
            grbNgayBan.PerformLayout();
            grbIDNV.ResumeLayout(false);
            grbIDNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            tbChiTiet.ResumeLayout(false);
            tbChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcDanhSach;
        private TabPage tbChiTiet;
        private Label label7;
        private CustomControl.CustomButton btn_back;
        private CustomControl.CustomTextBox txtIDPgg;
        private Label label3;
        private CustomControl.CustomTextBox txtIDNhanVien;
        private Label label1;
        private CustomControl.CustomTextBox txtIDHoaDon;
        private Label label4;
        private CustomControl.CustomTextBox txtDonGia;
        private Label label8;
        private CustomControl.CustomTextBox txtIDKhachHang;
        private Label label6;
        private Label label5;
        private Label label10;
        private CustomControl.CustomTextBox txtThanhTien;
        private Label label11;
        private CustomControl.CustomTextBox txtGiamGia;
        private Label label12;
        private Label label13;
        private CustomControl.CustomButton xacNhanBtn;
        private DataGridView dgvCTHD;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TabPage tbDanhSach;
        private CustomControl.CustomButton btnCT;
        private DataGridView dgvHD;
        private CustomControl.CustomButton btnLoc;
        private CustomControl.CustomButton btnSort;
        private GroupBox gbSort;
        private GroupBox grbIDKH;
        private RadioButton rbIDKHDec;
        private RadioButton rbIDKHInc;
        private GroupBox grbIDHD;
        private RadioButton rbIDHDDec;
        private RadioButton rbIDHDInc;
        private GroupBox grbNgayBan;
        private RadioButton rbNgayBanDec;
        private RadioButton rbNgayBanInc;
        private GroupBox grbIDNV;
        private RadioButton rbIDNVDec;
        private RadioButton rbIDNVInc;
        private GroupBox grbGiamGia;
        private RadioButton rbGiamGiaDec;
        private RadioButton rbGiamGiaInc;
        private GroupBox grbDonGia;
        private RadioButton rbDonGiaDec;
        private RadioButton rbDonGiaInc;
        private GroupBox grbThanhTien;
        private RadioButton rbThanhTienDec;
        private RadioButton rbThanhTienInc;
        private CheckBox checkboxIsAccepted;
        private GroupBox grbIDPgg;
        private RadioButton rbIDPggDec;
        private RadioButton rbIDPggInc;
        private DateTimePicker dtpNgayBan;
        private GroupBox gbLoc;
        private RadioButton rbFalse;
        private RadioButton rbTrue;
        private CustomControl.CustomButton resetBtn;
    }
}