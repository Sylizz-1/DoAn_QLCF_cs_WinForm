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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tcDanhSach = new TabControl();
            tbDanhSach = new TabPage();
            btn_xacNhan = new CustomControl.CustomButton();
            dgvHD = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
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
            tcDanhSach.Margin = new Padding(3, 4, 3, 4);
            tcDanhSach.Name = "tcDanhSach";
            tcDanhSach.SelectedIndex = 0;
            tcDanhSach.Size = new Size(1107, 804);
            tcDanhSach.TabIndex = 0;
            // 
            // tbDanhSach
            // 
            tbDanhSach.BackColor = SystemColors.Control;
            tbDanhSach.Controls.Add(btn_xacNhan);
            tbDanhSach.Controls.Add(dgvHD);
            tbDanhSach.Controls.Add(resetBtn);
            tbDanhSach.Controls.Add(gbLoc);
            tbDanhSach.Controls.Add(gbSort);
            tbDanhSach.Controls.Add(btnSort);
            tbDanhSach.Controls.Add(btnLoc);
            tbDanhSach.Controls.Add(btnCT);
            tbDanhSach.Location = new Point(4, 29);
            tbDanhSach.Margin = new Padding(3, 4, 3, 4);
            tbDanhSach.Name = "tbDanhSach";
            tbDanhSach.Padding = new Padding(3, 4, 3, 4);
            tbDanhSach.Size = new Size(1099, 771);
            tbDanhSach.TabIndex = 0;
            tbDanhSach.Text = "Danh sách";
            // 
            // btn_xacNhan
            // 
            btn_xacNhan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_xacNhan.BackColor = SystemColors.Control;
            btn_xacNhan.BackgroundColor = SystemColors.Control;
            btn_xacNhan.BorderColor = Color.DarkCyan;
            btn_xacNhan.BorderRadius = 15;
            btn_xacNhan.BorderSize = 2;
            btn_xacNhan.Cursor = Cursors.Hand;
            btn_xacNhan.EnabledTextHover = true;
            btn_xacNhan.FlatAppearance.BorderSize = 0;
            btn_xacNhan.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_xacNhan.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_xacNhan.FlatStyle = FlatStyle.Flat;
            btn_xacNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_xacNhan.ForeColor = Color.DarkCyan;
            btn_xacNhan.Image = Properties.Resources.ConfirmIcondarkcyan1;
            btn_xacNhan.ImageAlign = ContentAlignment.MiddleRight;
            btn_xacNhan.ImageHover = Properties.Resources.ConfirmIconWhite1;
            btn_xacNhan.Location = new Point(451, 6);
            btn_xacNhan.Margin = new Padding(3, 4, 3, 4);
            btn_xacNhan.Name = "btn_xacNhan";
            btn_xacNhan.Size = new Size(185, 53);
            btn_xacNhan.TabIndex = 39;
            btn_xacNhan.Text = "  Xác Nhận";
            btn_xacNhan.TextColor = Color.DarkCyan;
            btn_xacNhan.TextHover = Color.White;
            btn_xacNhan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_xacNhan.UseVisualStyleBackColor = false;
            btn_xacNhan.Click += btn_xacNhan_Click;
            // 
            // dgvHD
            // 
            dgvHD.AllowUserToAddRows = false;
            dgvHD.AllowUserToDeleteRows = false;
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHD.BorderStyle = BorderStyle.None;
            dgvHD.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkCyan;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHD.ColumnHeadersHeight = 30;
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHD.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHD.Dock = DockStyle.Bottom;
            dgvHD.EnableHeadersVisualStyles = false;
            dgvHD.GridColor = Color.DarkCyan;
            dgvHD.ImeMode = ImeMode.NoControl;
            dgvHD.Location = new Point(3, 240);
            dgvHD.Margin = new Padding(3, 4, 3, 4);
            dgvHD.Name = "dgvHD";
            dgvHD.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvHD.RowHeadersVisible = false;
            dgvHD.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHD.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvHD.RowTemplate.Height = 25;
            dgvHD.RowTemplate.ReadOnly = true;
            dgvHD.Size = new Size(1093, 527);
            dgvHD.TabIndex = 38;
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
            resetBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            resetBtn.ForeColor = Color.DarkGray;
            resetBtn.ImageAlign = ContentAlignment.MiddleRight;
            resetBtn.ImageHover = null;
            resetBtn.Location = new Point(929, 43);
            resetBtn.Margin = new Padding(3, 4, 3, 4);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(137, 51);
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
            gbLoc.Location = new Point(280, 72);
            gbLoc.Margin = new Padding(3, 4, 3, 4);
            gbLoc.Name = "gbLoc";
            gbLoc.Padding = new Padding(3, 4, 3, 4);
            gbLoc.Size = new Size(504, 148);
            gbLoc.TabIndex = 29;
            gbLoc.TabStop = false;
            gbLoc.Visible = false;
            // 
            // rbFalse
            // 
            rbFalse.AutoSize = true;
            rbFalse.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbFalse.Location = new Point(273, 63);
            rbFalse.Margin = new Padding(2, 3, 2, 3);
            rbFalse.Name = "rbFalse";
            rbFalse.Size = new Size(191, 32);
            rbFalse.TabIndex = 2;
            rbFalse.TabStop = true;
            rbFalse.Tag = "NotAcp";
            rbFalse.Text = "Chưa thanh toán";
            rbFalse.UseVisualStyleBackColor = true;
            // 
            // rbTrue
            // 
            rbTrue.AutoSize = true;
            rbTrue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbTrue.Location = new Point(48, 61);
            rbTrue.Margin = new Padding(2, 3, 2, 3);
            rbTrue.Name = "rbTrue";
            rbTrue.Size = new Size(169, 32);
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
            gbSort.Location = new Point(9, 100);
            gbSort.Margin = new Padding(2, 3, 2, 3);
            gbSort.Name = "gbSort";
            gbSort.Padding = new Padding(2, 3, 2, 3);
            gbSort.Size = new Size(1057, 120);
            gbSort.TabIndex = 28;
            gbSort.TabStop = false;
            gbSort.Visible = false;
            // 
            // grbIDPgg
            // 
            grbIDPgg.Controls.Add(rbIDPggDec);
            grbIDPgg.Controls.Add(rbIDPggInc);
            grbIDPgg.Location = new Point(400, 19);
            grbIDPgg.Margin = new Padding(2, 3, 2, 3);
            grbIDPgg.Name = "grbIDPgg";
            grbIDPgg.Padding = new Padding(2, 3, 2, 3);
            grbIDPgg.Size = new Size(112, 87);
            grbIDPgg.TabIndex = 25;
            grbIDPgg.TabStop = false;
            grbIDPgg.Text = "ID Phiếu giảm giá";
            // 
            // rbIDPggDec
            // 
            rbIDPggDec.AutoSize = true;
            rbIDPggDec.Location = new Point(11, 49);
            rbIDPggDec.Margin = new Padding(2, 3, 2, 3);
            rbIDPggDec.Name = "rbIDPggDec";
            rbIDPggDec.Size = new Size(65, 24);
            rbIDPggDec.TabIndex = 1;
            rbIDPggDec.TabStop = true;
            rbIDPggDec.Tag = "IDPggDec";
            rbIDPggDec.Text = "Giảm";
            rbIDPggDec.UseVisualStyleBackColor = true;
            // 
            // rbIDPggInc
            // 
            rbIDPggInc.AutoSize = true;
            rbIDPggInc.Location = new Point(11, 21);
            rbIDPggInc.Margin = new Padding(2, 3, 2, 3);
            rbIDPggInc.Name = "rbIDPggInc";
            rbIDPggInc.Size = new Size(62, 24);
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
            grbThanhTien.Location = new Point(922, 19);
            grbThanhTien.Margin = new Padding(2, 3, 2, 3);
            grbThanhTien.Name = "grbThanhTien";
            grbThanhTien.Padding = new Padding(2, 3, 2, 3);
            grbThanhTien.Size = new Size(112, 87);
            grbThanhTien.TabIndex = 27;
            grbThanhTien.TabStop = false;
            grbThanhTien.Text = "Thành tiền";
            // 
            // rbThanhTienDec
            // 
            rbThanhTienDec.AutoSize = true;
            rbThanhTienDec.Location = new Point(9, 47);
            rbThanhTienDec.Margin = new Padding(2, 3, 2, 3);
            rbThanhTienDec.Name = "rbThanhTienDec";
            rbThanhTienDec.Size = new Size(65, 24);
            rbThanhTienDec.TabIndex = 1;
            rbThanhTienDec.TabStop = true;
            rbThanhTienDec.Tag = "ThanhTienDec";
            rbThanhTienDec.Text = "Giảm";
            rbThanhTienDec.UseVisualStyleBackColor = true;
            // 
            // rbThanhTienInc
            // 
            rbThanhTienInc.AutoSize = true;
            rbThanhTienInc.Location = new Point(9, 19);
            rbThanhTienInc.Margin = new Padding(2, 3, 2, 3);
            rbThanhTienInc.Name = "rbThanhTienInc";
            rbThanhTienInc.Size = new Size(62, 24);
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
            grbGiamGia.Location = new Point(794, 19);
            grbGiamGia.Margin = new Padding(2, 3, 2, 3);
            grbGiamGia.Name = "grbGiamGia";
            grbGiamGia.Padding = new Padding(2, 3, 2, 3);
            grbGiamGia.Size = new Size(112, 87);
            grbGiamGia.TabIndex = 26;
            grbGiamGia.TabStop = false;
            grbGiamGia.Text = "Giảm giá";
            // 
            // rbGiamGiaDec
            // 
            rbGiamGiaDec.AutoSize = true;
            rbGiamGiaDec.Location = new Point(10, 48);
            rbGiamGiaDec.Margin = new Padding(2, 3, 2, 3);
            rbGiamGiaDec.Name = "rbGiamGiaDec";
            rbGiamGiaDec.Size = new Size(65, 24);
            rbGiamGiaDec.TabIndex = 1;
            rbGiamGiaDec.TabStop = true;
            rbGiamGiaDec.Tag = "GiamGiaDec";
            rbGiamGiaDec.Text = "Giảm";
            rbGiamGiaDec.UseVisualStyleBackColor = true;
            // 
            // rbGiamGiaInc
            // 
            rbGiamGiaInc.AutoSize = true;
            rbGiamGiaInc.Location = new Point(10, 20);
            rbGiamGiaInc.Margin = new Padding(2, 3, 2, 3);
            rbGiamGiaInc.Name = "rbGiamGiaInc";
            rbGiamGiaInc.Size = new Size(62, 24);
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
            grbDonGia.Location = new Point(663, 19);
            grbDonGia.Margin = new Padding(2, 3, 2, 3);
            grbDonGia.Name = "grbDonGia";
            grbDonGia.Padding = new Padding(2, 3, 2, 3);
            grbDonGia.Size = new Size(112, 87);
            grbDonGia.TabIndex = 25;
            grbDonGia.TabStop = false;
            grbDonGia.Text = "Đơn giá";
            // 
            // rbDonGiaDec
            // 
            rbDonGiaDec.AutoSize = true;
            rbDonGiaDec.Location = new Point(11, 49);
            rbDonGiaDec.Margin = new Padding(2, 3, 2, 3);
            rbDonGiaDec.Name = "rbDonGiaDec";
            rbDonGiaDec.Size = new Size(65, 24);
            rbDonGiaDec.TabIndex = 1;
            rbDonGiaDec.TabStop = true;
            rbDonGiaDec.Tag = "DonGiaDec";
            rbDonGiaDec.Text = "Giảm";
            rbDonGiaDec.UseVisualStyleBackColor = true;
            // 
            // rbDonGiaInc
            // 
            rbDonGiaInc.AutoSize = true;
            rbDonGiaInc.Location = new Point(11, 21);
            rbDonGiaInc.Margin = new Padding(2, 3, 2, 3);
            rbDonGiaInc.Name = "rbDonGiaInc";
            rbDonGiaInc.Size = new Size(62, 24);
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
            grbIDKH.Location = new Point(271, 19);
            grbIDKH.Margin = new Padding(2, 3, 2, 3);
            grbIDKH.Name = "grbIDKH";
            grbIDKH.Padding = new Padding(2, 3, 2, 3);
            grbIDKH.Size = new Size(112, 87);
            grbIDKH.TabIndex = 24;
            grbIDKH.TabStop = false;
            grbIDKH.Text = "ID Khách hàng";
            // 
            // rbIDKHDec
            // 
            rbIDKHDec.AutoSize = true;
            rbIDKHDec.Location = new Point(13, 51);
            rbIDKHDec.Margin = new Padding(2, 3, 2, 3);
            rbIDKHDec.Name = "rbIDKHDec";
            rbIDKHDec.Size = new Size(65, 24);
            rbIDKHDec.TabIndex = 1;
            rbIDKHDec.TabStop = true;
            rbIDKHDec.Tag = "IDKHDec";
            rbIDKHDec.Text = "Giảm";
            rbIDKHDec.UseVisualStyleBackColor = true;
            // 
            // rbIDKHInc
            // 
            rbIDKHInc.AutoSize = true;
            rbIDKHInc.Location = new Point(13, 23);
            rbIDKHInc.Margin = new Padding(2, 3, 2, 3);
            rbIDKHInc.Name = "rbIDKHInc";
            rbIDKHInc.Size = new Size(62, 24);
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
            grbIDHD.Location = new Point(5, 19);
            grbIDHD.Margin = new Padding(2, 3, 2, 3);
            grbIDHD.Name = "grbIDHD";
            grbIDHD.Padding = new Padding(2, 3, 2, 3);
            grbIDHD.Size = new Size(112, 87);
            grbIDHD.TabIndex = 23;
            grbIDHD.TabStop = false;
            grbIDHD.Text = "ID Hoá đơn";
            // 
            // rbIDHDDec
            // 
            rbIDHDDec.AutoSize = true;
            rbIDHDDec.Location = new Point(13, 51);
            rbIDHDDec.Margin = new Padding(2, 3, 2, 3);
            rbIDHDDec.Name = "rbIDHDDec";
            rbIDHDDec.Size = new Size(65, 24);
            rbIDHDDec.TabIndex = 1;
            rbIDHDDec.TabStop = true;
            rbIDHDDec.Tag = "IDHDDec";
            rbIDHDDec.Text = "Giảm";
            rbIDHDDec.UseVisualStyleBackColor = true;
            // 
            // rbIDHDInc
            // 
            rbIDHDInc.AutoSize = true;
            rbIDHDInc.Location = new Point(13, 23);
            rbIDHDInc.Margin = new Padding(2, 3, 2, 3);
            rbIDHDInc.Name = "rbIDHDInc";
            rbIDHDInc.Size = new Size(62, 24);
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
            grbNgayBan.Location = new Point(533, 19);
            grbNgayBan.Margin = new Padding(2, 3, 2, 3);
            grbNgayBan.Name = "grbNgayBan";
            grbNgayBan.Padding = new Padding(2, 3, 2, 3);
            grbNgayBan.Size = new Size(112, 87);
            grbNgayBan.TabIndex = 24;
            grbNgayBan.TabStop = false;
            grbNgayBan.Text = "Ngày bán";
            // 
            // rbNgayBanDec
            // 
            rbNgayBanDec.AutoSize = true;
            rbNgayBanDec.Location = new Point(13, 51);
            rbNgayBanDec.Margin = new Padding(2, 3, 2, 3);
            rbNgayBanDec.Name = "rbNgayBanDec";
            rbNgayBanDec.Size = new Size(65, 24);
            rbNgayBanDec.TabIndex = 1;
            rbNgayBanDec.TabStop = true;
            rbNgayBanDec.Tag = "NgayBanDec";
            rbNgayBanDec.Text = "Giảm";
            rbNgayBanDec.UseVisualStyleBackColor = true;
            // 
            // rbNgayBanInc
            // 
            rbNgayBanInc.AutoSize = true;
            rbNgayBanInc.Location = new Point(13, 23);
            rbNgayBanInc.Margin = new Padding(2, 3, 2, 3);
            rbNgayBanInc.Name = "rbNgayBanInc";
            rbNgayBanInc.Size = new Size(62, 24);
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
            grbIDNV.Location = new Point(138, 19);
            grbIDNV.Margin = new Padding(2, 3, 2, 3);
            grbIDNV.Name = "grbIDNV";
            grbIDNV.Padding = new Padding(2, 3, 2, 3);
            grbIDNV.Size = new Size(112, 87);
            grbIDNV.TabIndex = 24;
            grbIDNV.TabStop = false;
            grbIDNV.Text = "ID Nhân viên";
            // 
            // rbIDNVDec
            // 
            rbIDNVDec.AutoSize = true;
            rbIDNVDec.Location = new Point(13, 51);
            rbIDNVDec.Margin = new Padding(2, 3, 2, 3);
            rbIDNVDec.Name = "rbIDNVDec";
            rbIDNVDec.Size = new Size(65, 24);
            rbIDNVDec.TabIndex = 1;
            rbIDNVDec.TabStop = true;
            rbIDNVDec.Tag = "IDNVDec";
            rbIDNVDec.Text = "Giảm";
            rbIDNVDec.UseVisualStyleBackColor = true;
            // 
            // rbIDNVInc
            // 
            rbIDNVInc.AutoSize = true;
            rbIDNVInc.Location = new Point(13, 23);
            rbIDNVInc.Margin = new Padding(2, 3, 2, 3);
            rbIDNVInc.Name = "rbIDNVInc";
            rbIDNVInc.Size = new Size(62, 24);
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
            btnSort.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSort.ForeColor = Color.DeepSkyBlue;
            btnSort.ImageAlign = ContentAlignment.MiddleRight;
            btnSort.ImageHover = null;
            btnSort.Location = new Point(147, 4);
            btnSort.Margin = new Padding(3, 4, 3, 4);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(149, 57);
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
            btnLoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLoc.ForeColor = Color.Goldenrod;
            btnLoc.ImageAlign = ContentAlignment.MiddleRight;
            btnLoc.ImageHover = null;
            btnLoc.Location = new Point(9, 4);
            btnLoc.Margin = new Padding(3, 4, 3, 4);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(131, 57);
            btnLoc.TabIndex = 23;
            btnLoc.Text = "Lọc";
            btnLoc.TextColor = Color.Goldenrod;
            btnLoc.TextHover = Color.White;
            btnLoc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Visible = false;
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
            btnCT.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCT.ForeColor = Color.DarkCyan;
            btnCT.Image = Properties.Resources.detailsIcon16px;
            btnCT.ImageAlign = ContentAlignment.MiddleRight;
            btnCT.ImageHover = Properties.Resources.detailsIcon16pxWHITE;
            btnCT.Location = new Point(303, 4);
            btnCT.Margin = new Padding(3, 4, 3, 4);
            btnCT.Name = "btnCT";
            btnCT.Size = new Size(142, 57);
            btnCT.TabIndex = 16;
            btnCT.Text = "  Chi Tiết";
            btnCT.TextColor = Color.DarkCyan;
            btnCT.TextHover = Color.White;
            btnCT.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCT.UseVisualStyleBackColor = false;
            btnCT.Click += btnCT_Click;
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
            tbChiTiet.Location = new Point(4, 29);
            tbChiTiet.Margin = new Padding(3, 4, 3, 4);
            tbChiTiet.Name = "tbChiTiet";
            tbChiTiet.Padding = new Padding(3, 4, 3, 4);
            tbChiTiet.Size = new Size(1099, 771);
            tbChiTiet.TabIndex = 1;
            tbChiTiet.Text = "Chi tiết";
            // 
            // dtpNgayBan
            // 
            dtpNgayBan.Font = new Font("Segoe UI", 13F);
            dtpNgayBan.Location = new Point(362, 259);
            dtpNgayBan.Margin = new Padding(3, 4, 3, 4);
            dtpNgayBan.Name = "dtpNgayBan";
            dtpNgayBan.Size = new Size(314, 36);
            dtpNgayBan.TabIndex = 79;
            dtpNgayBan.Visible = false;
            // 
            // checkboxIsAccepted
            // 
            checkboxIsAccepted.AutoSize = true;
            checkboxIsAccepted.Location = new Point(824, 375);
            checkboxIsAccepted.Margin = new Padding(2, 3, 2, 3);
            checkboxIsAccepted.Name = "checkboxIsAccepted";
            checkboxIsAccepted.Size = new Size(18, 17);
            checkboxIsAccepted.TabIndex = 78;
            checkboxIsAccepted.UseVisualStyleBackColor = true;
            checkboxIsAccepted.Visible = false;
            // 
            // dgvCTHD
            // 
            dgvCTHD.AllowUserToAddRows = false;
            dgvCTHD.AllowUserToDeleteRows = false;
            dgvCTHD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCTHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTHD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCTHD.BorderStyle = BorderStyle.None;
            dgvCTHD.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.DarkCyan;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCTHD.ColumnHeadersHeight = 30;
            dgvCTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvCTHD.DefaultCellStyle = dataGridViewCellStyle5;
            dgvCTHD.EnableHeadersVisualStyles = false;
            dgvCTHD.GridColor = Color.DarkCyan;
            dgvCTHD.ImeMode = ImeMode.NoControl;
            dgvCTHD.Location = new Point(3, 462);
            dgvCTHD.Margin = new Padding(3, 4, 3, 4);
            dgvCTHD.Name = "dgvCTHD";
            dgvCTHD.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCTHD.RowHeadersVisible = false;
            dgvCTHD.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCTHD.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvCTHD.RowTemplate.Height = 25;
            dgvCTHD.RowTemplate.ReadOnly = true;
            dgvCTHD.Size = new Size(1093, 305);
            dgvCTHD.TabIndex = 40;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 14F);
            label13.Location = new Point(9, 416);
            label13.Name = "label13";
            label13.Size = new Size(244, 47);
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
            xacNhanBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            xacNhanBtn.ForeColor = Color.DarkCyan;
            xacNhanBtn.Image = Properties.Resources.ConfirmIcondarkcyan1;
            xacNhanBtn.ImageAlign = ContentAlignment.MiddleRight;
            xacNhanBtn.ImageHover = Properties.Resources.ConfirmIconWhite1;
            xacNhanBtn.Location = new Point(904, 15);
            xacNhanBtn.Margin = new Padding(3, 4, 3, 4);
            xacNhanBtn.Name = "xacNhanBtn";
            xacNhanBtn.Size = new Size(185, 53);
            xacNhanBtn.TabIndex = 37;
            xacNhanBtn.Text = "  Xác Nhận";
            xacNhanBtn.TextColor = Color.DarkCyan;
            xacNhanBtn.TextHover = Color.White;
            xacNhanBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            xacNhanBtn.UseVisualStyleBackColor = false;
            xacNhanBtn.Visible = false;
            xacNhanBtn.Click += xacNhanBtn_Click;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(661, 356);
            label10.Name = "label10";
            label10.Size = new Size(181, 48);
            label10.TabIndex = 35;
            label10.Text = "Đã thanh toán:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Visible = false;
            // 
            // txtThanhTien
            // 
            txtThanhTien.BackColor = SystemColors.Window;
            txtThanhTien.BorderColor = Color.Silver;
            txtThanhTien.BorderFocusColor = Color.DarkCyan;
            txtThanhTien.BorderRadius = 13;
            txtThanhTien.BorderSize = 2;
            txtThanhTien.Font = new Font("Segoe UI", 13F);
            txtThanhTien.ForeColor = Color.DimGray;
            txtThanhTien.Location = new Point(362, 356);
            txtThanhTien.Margin = new Padding(3, 4, 3, 4);
            txtThanhTien.Multiline = false;
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Padding = new Padding(10, 12, 8, 9);
            txtThanhTien.PasswordChar = false;
            txtThanhTien.PlaceholderColor = Color.DarkGray;
            txtThanhTien.PlaceholderText = "--------------";
            txtThanhTien.Size = new Size(279, 52);
            txtThanhTien.TabIndex = 34;
            txtThanhTien.Texts = "";
            txtThanhTien.UnderlinedStyle = false;
            txtThanhTien.Visible = false;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(328, 304);
            label11.Name = "label11";
            label11.Size = new Size(166, 68);
            label11.TabIndex = 33;
            label11.Text = "Thành tiền";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.Visible = false;
            // 
            // txtGiamGia
            // 
            txtGiamGia.BackColor = SystemColors.Window;
            txtGiamGia.BorderColor = Color.Silver;
            txtGiamGia.BorderFocusColor = Color.DarkCyan;
            txtGiamGia.BorderRadius = 13;
            txtGiamGia.BorderSize = 2;
            txtGiamGia.Font = new Font("Segoe UI", 13F);
            txtGiamGia.ForeColor = Color.DimGray;
            txtGiamGia.Location = new Point(54, 356);
            txtGiamGia.Margin = new Padding(3, 4, 3, 4);
            txtGiamGia.Multiline = false;
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Padding = new Padding(10, 12, 8, 9);
            txtGiamGia.PasswordChar = false;
            txtGiamGia.PlaceholderColor = Color.DarkGray;
            txtGiamGia.PlaceholderText = "----------------";
            txtGiamGia.Size = new Size(279, 52);
            txtGiamGia.TabIndex = 32;
            txtGiamGia.Texts = "";
            txtGiamGia.UnderlinedStyle = false;
            txtGiamGia.Visible = false;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(34, 304);
            label12.Name = "label12";
            label12.Size = new Size(121, 68);
            label12.TabIndex = 31;
            label12.Text = "Giảm Giá";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            label12.Visible = false;
            // 
            // txtDonGia
            // 
            txtDonGia.BackColor = SystemColors.Window;
            txtDonGia.BorderColor = Color.Silver;
            txtDonGia.BorderFocusColor = Color.DarkCyan;
            txtDonGia.BorderRadius = 13;
            txtDonGia.BorderSize = 2;
            txtDonGia.Font = new Font("Segoe UI", 13F);
            txtDonGia.ForeColor = Color.DimGray;
            txtDonGia.Location = new Point(698, 244);
            txtDonGia.Margin = new Padding(3, 4, 3, 4);
            txtDonGia.Multiline = false;
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Padding = new Padding(10, 12, 8, 9);
            txtDonGia.PasswordChar = false;
            txtDonGia.PlaceholderColor = Color.DarkGray;
            txtDonGia.PlaceholderText = "---------------";
            txtDonGia.Size = new Size(279, 52);
            txtDonGia.TabIndex = 30;
            txtDonGia.Texts = "";
            txtDonGia.UnderlinedStyle = false;
            txtDonGia.Visible = false;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(653, 200);
            label8.Name = "label8";
            label8.Size = new Size(189, 59);
            label8.TabIndex = 29;
            label8.Text = "Đơn giá";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Visible = false;
            // 
            // txtIDKhachHang
            // 
            txtIDKhachHang.BackColor = SystemColors.Window;
            txtIDKhachHang.BorderColor = Color.Silver;
            txtIDKhachHang.BorderFocusColor = Color.DarkCyan;
            txtIDKhachHang.BorderRadius = 13;
            txtIDKhachHang.BorderSize = 2;
            txtIDKhachHang.Font = new Font("Segoe UI", 13F);
            txtIDKhachHang.ForeColor = Color.DimGray;
            txtIDKhachHang.Location = new Point(698, 133);
            txtIDKhachHang.Margin = new Padding(3, 4, 3, 4);
            txtIDKhachHang.Multiline = false;
            txtIDKhachHang.Name = "txtIDKhachHang";
            txtIDKhachHang.Padding = new Padding(10, 12, 8, 9);
            txtIDKhachHang.PasswordChar = false;
            txtIDKhachHang.PlaceholderColor = Color.DarkGray;
            txtIDKhachHang.PlaceholderText = "Nhập....";
            txtIDKhachHang.Size = new Size(279, 52);
            txtIDKhachHang.TabIndex = 28;
            txtIDKhachHang.Texts = "";
            txtIDKhachHang.UnderlinedStyle = false;
            txtIDKhachHang.Visible = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(698, 93);
            label6.Name = "label6";
            label6.Size = new Size(134, 48);
            label6.TabIndex = 27;
            label6.Text = "ID Khách Hàng";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Visible = false;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(351, 205);
            label5.Name = "label5";
            label5.Size = new Size(121, 49);
            label5.TabIndex = 25;
            label5.Text = "Ngày bán";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Visible = false;
            // 
            // txtIDPgg
            // 
            txtIDPgg.BackColor = SystemColors.Window;
            txtIDPgg.BorderColor = Color.Silver;
            txtIDPgg.BorderFocusColor = Color.DarkCyan;
            txtIDPgg.BorderRadius = 13;
            txtIDPgg.BorderSize = 2;
            txtIDPgg.Font = new Font("Segoe UI", 13F);
            txtIDPgg.ForeColor = Color.DimGray;
            txtIDPgg.Location = new Point(54, 248);
            txtIDPgg.Margin = new Padding(3, 4, 3, 4);
            txtIDPgg.Multiline = false;
            txtIDPgg.Name = "txtIDPgg";
            txtIDPgg.Padding = new Padding(10, 12, 8, 9);
            txtIDPgg.PasswordChar = false;
            txtIDPgg.PlaceholderColor = Color.DarkGray;
            txtIDPgg.PlaceholderText = "Nhập ID giảm giá....";
            txtIDPgg.Size = new Size(279, 52);
            txtIDPgg.TabIndex = 24;
            txtIDPgg.Texts = "";
            txtIDPgg.UnderlinedStyle = false;
            txtIDPgg.Visible = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(54, 200);
            label3.Name = "label3";
            label3.Size = new Size(178, 59);
            label3.TabIndex = 23;
            label3.Text = "ID Phiếu Giảm Giá";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            // 
            // txtIDNhanVien
            // 
            txtIDNhanVien.BackColor = SystemColors.Window;
            txtIDNhanVien.BorderColor = Color.Silver;
            txtIDNhanVien.BorderFocusColor = Color.DarkCyan;
            txtIDNhanVien.BorderRadius = 13;
            txtIDNhanVien.BorderSize = 2;
            txtIDNhanVien.Font = new Font("Segoe UI", 13F);
            txtIDNhanVien.ForeColor = Color.DimGray;
            txtIDNhanVien.Location = new Point(362, 133);
            txtIDNhanVien.Margin = new Padding(3, 4, 3, 4);
            txtIDNhanVien.Multiline = false;
            txtIDNhanVien.Name = "txtIDNhanVien";
            txtIDNhanVien.Padding = new Padding(10, 12, 8, 9);
            txtIDNhanVien.PasswordChar = false;
            txtIDNhanVien.PlaceholderColor = Color.DarkGray;
            txtIDNhanVien.PlaceholderText = "Nhập....";
            txtIDNhanVien.Size = new Size(279, 52);
            txtIDNhanVien.TabIndex = 22;
            txtIDNhanVien.Texts = "";
            txtIDNhanVien.UnderlinedStyle = false;
            txtIDNhanVien.Visible = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(362, 81);
            label1.Name = "label1";
            label1.Size = new Size(121, 68);
            label1.TabIndex = 21;
            label1.Text = "ID Nhân Viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Visible = false;
            // 
            // txtIDHoaDon
            // 
            txtIDHoaDon.BackColor = SystemColors.Window;
            txtIDHoaDon.BorderColor = Color.Silver;
            txtIDHoaDon.BorderFocusColor = Color.DarkCyan;
            txtIDHoaDon.BorderRadius = 13;
            txtIDHoaDon.BorderSize = 2;
            txtIDHoaDon.Font = new Font("Segoe UI", 13F);
            txtIDHoaDon.ForeColor = Color.DimGray;
            txtIDHoaDon.Location = new Point(54, 133);
            txtIDHoaDon.Margin = new Padding(3, 4, 3, 4);
            txtIDHoaDon.Multiline = false;
            txtIDHoaDon.Name = "txtIDHoaDon";
            txtIDHoaDon.Padding = new Padding(10, 12, 8, 9);
            txtIDHoaDon.PasswordChar = false;
            txtIDHoaDon.PlaceholderColor = Color.DarkGray;
            txtIDHoaDon.PlaceholderText = "Nhập ID....";
            txtIDHoaDon.Size = new Size(279, 52);
            txtIDHoaDon.TabIndex = 20;
            txtIDHoaDon.Texts = "";
            txtIDHoaDon.UnderlinedStyle = false;
            txtIDHoaDon.Visible = false;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(23, 84);
            label4.Name = "label4";
            label4.Size = new Size(121, 68);
            label4.TabIndex = 19;
            label4.Text = "ID";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Visible = false;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 17F);
            label7.Location = new Point(93, 9);
            label7.Name = "label7";
            label7.Size = new Size(318, 57);
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
            btn_back.Location = new Point(9, 13);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(72, 55);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 804);
            Controls.Add(tcDanhSach);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HoaDonView";
            Text = "HoaDonView";
            tcDanhSach.ResumeLayout(false);
            tbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
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
        private DataGridView dgvHD;
        private CustomControl.CustomButton btn_xacNhan;
    }
}