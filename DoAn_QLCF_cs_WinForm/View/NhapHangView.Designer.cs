namespace DoAn_QLCF_cs_WinForm.View
{
    partial class NhapHangView
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
            tcNhapHang = new TabControl();
            listTabPage = new TabPage();
            btnXemPN = new CustomControl.CustomButton();
            btnFindPn = new CustomControl.CustomButton();
            resetBtn = new CustomControl.CustomButton();
            gbSort = new GroupBox();
            groupBox5 = new GroupBox();
            rbIDNccDec = new RadioButton();
            rbIDNccInc = new RadioButton();
            groupBox2 = new GroupBox();
            rbIDPnDec = new RadioButton();
            rbIDPnInc = new RadioButton();
            groupBox4 = new GroupBox();
            rbNNDec = new RadioButton();
            rbNNInc = new RadioButton();
            groupBox3 = new GroupBox();
            rbIDNvDec = new RadioButton();
            rbIDNvInc = new RadioButton();
            groupBox7 = new GroupBox();
            rbTTDec = new RadioButton();
            rbTTInc = new RadioButton();
            btnFilterPN = new CustomControl.CustomButton();
            sortBtn = new CustomControl.CustomButton();
            delBtn = new CustomControl.CustomButton();
            btnEditPN = new CustomControl.CustomButton();
            btnAddPN = new CustomControl.CustomButton();
            dgvDsNhapHang = new DataGridView();
            searchTxt = new CustomControl.CustomTextBox();
            detailTabPage = new TabPage();
            txtTongTien = new CustomControl.CustomTextBox();
            label18 = new Label();
            HuyBtn = new CustomControl.CustomButton();
            xacNhanBtn = new CustomControl.CustomButton();
            gbCTPN = new GroupBox();
            dgvCTPN = new DataGridView();
            pnCTPN = new Panel();
            btnSortCTPN = new CustomControl.CustomButton();
            gbCtpnSort = new GroupBox();
            groupBox6 = new GroupBox();
            rbIDNglDec = new RadioButton();
            rbIDNglInc = new RadioButton();
            groupBox9 = new GroupBox();
            rbKLNglDec = new RadioButton();
            rbKLNglInc = new RadioButton();
            groupBox11 = new GroupBox();
            rbDGNglDec = new RadioButton();
            rbDGNglInc = new RadioButton();
            resetCTPNBtn = new CustomControl.CustomButton();
            btnFilterCTPN = new CustomControl.CustomButton();
            btnDeleteCTPN = new CustomControl.CustomButton();
            btnEditCTPN = new CustomControl.CustomButton();
            btnAddCTPN = new CustomControl.CustomButton();
            dtpPN = new DateTimePicker();
            cbNccName = new ComboBox();
            cbNhanVienId = new ComboBox();
            cbNccId = new ComboBox();
            cbNhanVienName = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            btn_back = new CustomControl.CustomButton();
            label3 = new Label();
            M = new Label();
            txtPhieuNhapId = new CustomControl.CustomTextBox();
            label5 = new Label();
            label4 = new Label();
            lbPN = new Label();
            moreDetailTabPage = new TabPage();
            btnAddNgl = new CustomControl.CustomButton();
            btnHuyCTPN = new CustomControl.CustomButton();
            btnXacNhanCTPN = new CustomControl.CustomButton();
            txtCTPNDonGia = new CustomControl.CustomTextBox();
            label13 = new Label();
            txtCTPNKhoiLuong = new CustomControl.CustomTextBox();
            cbNglId = new ComboBox();
            cbNglName = new ComboBox();
            label12 = new Label();
            label14 = new Label();
            txtCTPNId = new CustomControl.CustomTextBox();
            label15 = new Label();
            lbCTPNId = new Label();
            label11 = new Label();
            btn_back2 = new CustomControl.CustomButton();
            addNgl = new TabPage();
            btnHuyAdd = new CustomControl.CustomButton();
            btnXacNhanAdd = new CustomControl.CustomButton();
            label2 = new Label();
            btnBackCTPN = new CustomControl.CustomButton();
            caPhePic = new PictureBox();
            label8 = new Label();
            txtNglPrice = new CustomControl.CustomTextBox();
            label9 = new Label();
            txtNglInfo = new CustomControl.CustomTextBox();
            label10 = new Label();
            txtNglWeigh = new CustomControl.CustomTextBox();
            txtNglName = new CustomControl.CustomTextBox();
            label16 = new Label();
            label19 = new Label();
            tcNhapHang.SuspendLayout();
            listTabPage.SuspendLayout();
            gbSort.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsNhapHang).BeginInit();
            detailTabPage.SuspendLayout();
            gbCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).BeginInit();
            pnCTPN.SuspendLayout();
            gbCtpnSort.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox11.SuspendLayout();
            moreDetailTabPage.SuspendLayout();
            addNgl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)caPhePic).BeginInit();
            SuspendLayout();
            // 
            // tcNhapHang
            // 
            tcNhapHang.Controls.Add(listTabPage);
            tcNhapHang.Controls.Add(detailTabPage);
            tcNhapHang.Controls.Add(moreDetailTabPage);
            tcNhapHang.Controls.Add(addNgl);
            tcNhapHang.Dock = DockStyle.Fill;
            tcNhapHang.Location = new Point(0, 0);
            tcNhapHang.Margin = new Padding(4);
            tcNhapHang.Name = "tcNhapHang";
            tcNhapHang.SelectedIndex = 0;
            tcNhapHang.Size = new Size(1538, 925);
            tcNhapHang.TabIndex = 0;
            // 
            // listTabPage
            // 
            listTabPage.Controls.Add(btnXemPN);
            listTabPage.Controls.Add(btnFindPn);
            listTabPage.Controls.Add(resetBtn);
            listTabPage.Controls.Add(gbSort);
            listTabPage.Controls.Add(btnFilterPN);
            listTabPage.Controls.Add(sortBtn);
            listTabPage.Controls.Add(delBtn);
            listTabPage.Controls.Add(btnEditPN);
            listTabPage.Controls.Add(btnAddPN);
            listTabPage.Controls.Add(dgvDsNhapHang);
            listTabPage.Controls.Add(searchTxt);
            listTabPage.Location = new Point(4, 34);
            listTabPage.Margin = new Padding(4);
            listTabPage.Name = "listTabPage";
            listTabPage.Padding = new Padding(4);
            listTabPage.Size = new Size(1530, 887);
            listTabPage.TabIndex = 0;
            listTabPage.Text = "Danh Sach";
            listTabPage.UseVisualStyleBackColor = true;
            // 
            // btnXemPN
            // 
            btnXemPN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXemPN.BackColor = SystemColors.Control;
            btnXemPN.BackgroundColor = SystemColors.Control;
            btnXemPN.BorderColor = Color.Goldenrod;
            btnXemPN.BorderRadius = 15;
            btnXemPN.BorderSize = 2;
            btnXemPN.Cursor = Cursors.Hand;
            btnXemPN.EnabledTextHover = true;
            btnXemPN.FlatAppearance.BorderSize = 0;
            btnXemPN.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            btnXemPN.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnXemPN.FlatStyle = FlatStyle.Flat;
            btnXemPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXemPN.ForeColor = Color.Goldenrod;
            btnXemPN.ImageAlign = ContentAlignment.MiddleRight;
            btnXemPN.ImageHover = null;
            btnXemPN.Location = new Point(1333, 266);
            btnXemPN.Margin = new Padding(4, 5, 4, 5);
            btnXemPN.Name = "btnXemPN";
            btnXemPN.Size = new Size(172, 64);
            btnXemPN.TabIndex = 32;
            btnXemPN.Text = "Xem";
            btnXemPN.TextColor = Color.Goldenrod;
            btnXemPN.TextHover = Color.White;
            btnXemPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXemPN.UseVisualStyleBackColor = false;
            btnXemPN.Click += btnXemPN_Click;
            // 
            // btnFindPn
            // 
            btnFindPn.BackColor = Color.Transparent;
            btnFindPn.BackgroundColor = Color.Transparent;
            btnFindPn.BorderColor = Color.PaleVioletRed;
            btnFindPn.BorderRadius = 15;
            btnFindPn.BorderSize = 0;
            btnFindPn.Cursor = Cursors.Hand;
            btnFindPn.EnabledTextHover = false;
            btnFindPn.FlatAppearance.BorderSize = 0;
            btnFindPn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 64, 64, 64);
            btnFindPn.FlatStyle = FlatStyle.Flat;
            btnFindPn.ForeColor = Color.White;
            btnFindPn.Image = Properties.Resources.findIcon16px;
            btnFindPn.ImageHover = null;
            btnFindPn.Location = new Point(335, 18);
            btnFindPn.Margin = new Padding(4, 5, 4, 5);
            btnFindPn.Name = "btnFindPn";
            btnFindPn.Size = new Size(40, 40);
            btnFindPn.TabIndex = 31;
            btnFindPn.TextColor = Color.White;
            btnFindPn.TextHover = Color.White;
            btnFindPn.UseVisualStyleBackColor = false;
            // 
            // resetBtn
            // 
            resetBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            resetBtn.BackColor = SystemColors.Control;
            resetBtn.BackgroundColor = SystemColors.Control;
            resetBtn.BorderColor = Color.Gray;
            resetBtn.BorderRadius = 15;
            resetBtn.BorderSize = 2;
            resetBtn.Cursor = Cursors.Hand;
            resetBtn.EnabledTextHover = true;
            resetBtn.FlatAppearance.BorderSize = 0;
            resetBtn.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            resetBtn.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            resetBtn.ForeColor = Color.DarkGray;
            resetBtn.ImageAlign = ContentAlignment.MiddleRight;
            resetBtn.ImageHover = null;
            resetBtn.Location = new Point(1333, 169);
            resetBtn.Margin = new Padding(4, 5, 4, 5);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(172, 64);
            resetBtn.TabIndex = 30;
            resetBtn.Text = "&Reset";
            resetBtn.TextColor = Color.DarkGray;
            resetBtn.TextHover = Color.White;
            resetBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // gbSort
            // 
            gbSort.Controls.Add(groupBox5);
            gbSort.Controls.Add(groupBox2);
            gbSort.Controls.Add(groupBox4);
            gbSort.Controls.Add(groupBox3);
            gbSort.Controls.Add(groupBox7);
            gbSort.Location = new Point(52, 115);
            gbSort.Name = "gbSort";
            gbSort.Size = new Size(969, 150);
            gbSort.TabIndex = 29;
            gbSort.TabStop = false;
            gbSort.Visible = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rbIDNccDec);
            groupBox5.Controls.Add(rbIDNccInc);
            groupBox5.Location = new Point(403, 24);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(159, 108);
            groupBox5.TabIndex = 24;
            groupBox5.TabStop = false;
            groupBox5.Text = "ID Nhà cung cấp";
            // 
            // rbIDNccDec
            // 
            rbIDNccDec.AutoSize = true;
            rbIDNccDec.Location = new Point(17, 65);
            rbIDNccDec.Name = "rbIDNccDec";
            rbIDNccDec.Size = new Size(78, 29);
            rbIDNccDec.TabIndex = 1;
            rbIDNccDec.TabStop = true;
            rbIDNccDec.Tag = "IDNccDec";
            rbIDNccDec.Text = "Giảm";
            rbIDNccDec.UseVisualStyleBackColor = true;
            rbIDNccDec.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // rbIDNccInc
            // 
            rbIDNccInc.AutoSize = true;
            rbIDNccInc.Location = new Point(17, 30);
            rbIDNccInc.Name = "rbIDNccInc";
            rbIDNccInc.Size = new Size(74, 29);
            rbIDNccInc.TabIndex = 0;
            rbIDNccInc.TabStop = true;
            rbIDNccInc.Tag = "IDNccInc";
            rbIDNccInc.Text = "Tăng";
            rbIDNccInc.UseVisualStyleBackColor = true;
            rbIDNccInc.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbIDPnDec);
            groupBox2.Controls.Add(rbIDPnInc);
            groupBox2.Location = new Point(11, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(159, 108);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "ID phiếu nhập";
            // 
            // rbIDPnDec
            // 
            rbIDPnDec.AutoSize = true;
            rbIDPnDec.Location = new Point(17, 65);
            rbIDPnDec.Name = "rbIDPnDec";
            rbIDPnDec.Size = new Size(78, 29);
            rbIDPnDec.TabIndex = 1;
            rbIDPnDec.TabStop = true;
            rbIDPnDec.Tag = "IDPnDec";
            rbIDPnDec.Text = "Giảm";
            rbIDPnDec.UseVisualStyleBackColor = true;
            rbIDPnDec.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // rbIDPnInc
            // 
            rbIDPnInc.AutoSize = true;
            rbIDPnInc.Location = new Point(17, 30);
            rbIDPnInc.Name = "rbIDPnInc";
            rbIDPnInc.Size = new Size(74, 29);
            rbIDPnInc.TabIndex = 0;
            rbIDPnInc.TabStop = true;
            rbIDPnInc.Tag = "IDPnInc";
            rbIDPnInc.Text = "Tăng";
            rbIDPnInc.UseVisualStyleBackColor = true;
            rbIDPnInc.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rbNNDec);
            groupBox4.Controls.Add(rbNNInc);
            groupBox4.Location = new Point(599, 24);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(159, 108);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ngày nhập";
            // 
            // rbNNDec
            // 
            rbNNDec.AutoSize = true;
            rbNNDec.Location = new Point(17, 65);
            rbNNDec.Name = "rbNNDec";
            rbNNDec.Size = new Size(78, 29);
            rbNNDec.TabIndex = 1;
            rbNNDec.TabStop = true;
            rbNNDec.Tag = "NgayNhapDec";
            rbNNDec.Text = "Giảm";
            rbNNDec.UseVisualStyleBackColor = true;
            rbNNDec.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // rbNNInc
            // 
            rbNNInc.AutoSize = true;
            rbNNInc.Location = new Point(17, 30);
            rbNNInc.Name = "rbNNInc";
            rbNNInc.Size = new Size(74, 29);
            rbNNInc.TabIndex = 0;
            rbNNInc.TabStop = true;
            rbNNInc.Tag = "NgayNhapInc";
            rbNNInc.Text = "Tăng";
            rbNNInc.UseVisualStyleBackColor = true;
            rbNNInc.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbIDNvDec);
            groupBox3.Controls.Add(rbIDNvInc);
            groupBox3.Location = new Point(207, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(159, 108);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "ID nhân viên";
            // 
            // rbIDNvDec
            // 
            rbIDNvDec.AutoSize = true;
            rbIDNvDec.Location = new Point(17, 65);
            rbIDNvDec.Name = "rbIDNvDec";
            rbIDNvDec.Size = new Size(78, 29);
            rbIDNvDec.TabIndex = 1;
            rbIDNvDec.TabStop = true;
            rbIDNvDec.Tag = "IDNvDec";
            rbIDNvDec.Text = "Giảm";
            rbIDNvDec.UseVisualStyleBackColor = true;
            rbIDNvDec.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // rbIDNvInc
            // 
            rbIDNvInc.AutoSize = true;
            rbIDNvInc.Location = new Point(17, 30);
            rbIDNvInc.Name = "rbIDNvInc";
            rbIDNvInc.Size = new Size(74, 29);
            rbIDNvInc.TabIndex = 0;
            rbIDNvInc.TabStop = true;
            rbIDNvInc.Tag = "IDNvInc";
            rbIDNvInc.Text = "Tăng";
            rbIDNvInc.UseVisualStyleBackColor = true;
            rbIDNvInc.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(rbTTDec);
            groupBox7.Controls.Add(rbTTInc);
            groupBox7.Location = new Point(795, 24);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(159, 108);
            groupBox7.TabIndex = 25;
            groupBox7.TabStop = false;
            groupBox7.Text = "Tổng tiền";
            // 
            // rbTTDec
            // 
            rbTTDec.AutoSize = true;
            rbTTDec.Location = new Point(17, 65);
            rbTTDec.Name = "rbTTDec";
            rbTTDec.Size = new Size(78, 29);
            rbTTDec.TabIndex = 1;
            rbTTDec.TabStop = true;
            rbTTDec.Tag = "TongTienDec";
            rbTTDec.Text = "Giảm";
            rbTTDec.UseVisualStyleBackColor = true;
            rbTTDec.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // rbTTInc
            // 
            rbTTInc.AutoSize = true;
            rbTTInc.Location = new Point(17, 30);
            rbTTInc.Name = "rbTTInc";
            rbTTInc.Size = new Size(74, 29);
            rbTTInc.TabIndex = 0;
            rbTTInc.TabStop = true;
            rbTTInc.Tag = "TongTienInc";
            rbTTInc.Text = "Tăng";
            rbTTInc.UseVisualStyleBackColor = true;
            rbTTInc.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // btnFilterPN
            // 
            btnFilterPN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFilterPN.BackColor = SystemColors.Control;
            btnFilterPN.BackgroundColor = SystemColors.Control;
            btnFilterPN.BorderColor = Color.Goldenrod;
            btnFilterPN.BorderRadius = 15;
            btnFilterPN.BorderSize = 2;
            btnFilterPN.Cursor = Cursors.Hand;
            btnFilterPN.EnabledTextHover = true;
            btnFilterPN.FlatAppearance.BorderSize = 0;
            btnFilterPN.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            btnFilterPN.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnFilterPN.FlatStyle = FlatStyle.Flat;
            btnFilterPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFilterPN.ForeColor = Color.Goldenrod;
            btnFilterPN.ImageAlign = ContentAlignment.MiddleRight;
            btnFilterPN.ImageHover = null;
            btnFilterPN.Location = new Point(589, 4);
            btnFilterPN.Margin = new Padding(4, 5, 4, 5);
            btnFilterPN.Name = "btnFilterPN";
            btnFilterPN.Size = new Size(172, 64);
            btnFilterPN.TabIndex = 27;
            btnFilterPN.Text = "&Lọc";
            btnFilterPN.TextColor = Color.Goldenrod;
            btnFilterPN.TextHover = Color.White;
            btnFilterPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFilterPN.UseVisualStyleBackColor = false;
            btnFilterPN.Click += filterBtn_Click;
            // 
            // sortBtn
            // 
            sortBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sortBtn.BackColor = SystemColors.Control;
            sortBtn.BackgroundColor = SystemColors.Control;
            sortBtn.BorderColor = Color.DeepSkyBlue;
            sortBtn.BorderRadius = 15;
            sortBtn.BorderSize = 2;
            sortBtn.Cursor = Cursors.Hand;
            sortBtn.EnabledTextHover = true;
            sortBtn.FlatAppearance.BorderSize = 0;
            sortBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            sortBtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            sortBtn.FlatStyle = FlatStyle.Flat;
            sortBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            sortBtn.ForeColor = Color.DeepSkyBlue;
            sortBtn.ImageAlign = ContentAlignment.MiddleRight;
            sortBtn.ImageHover = null;
            sortBtn.Location = new Point(775, 4);
            sortBtn.Margin = new Padding(4, 5, 4, 5);
            sortBtn.Name = "sortBtn";
            sortBtn.Size = new Size(172, 64);
            sortBtn.TabIndex = 26;
            sortBtn.Text = "&Sắp xếp";
            sortBtn.TextColor = Color.DeepSkyBlue;
            sortBtn.TextHover = Color.White;
            sortBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            sortBtn.UseVisualStyleBackColor = false;
            sortBtn.Click += sortBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            delBtn.BackColor = SystemColors.Control;
            delBtn.BackgroundColor = SystemColors.Control;
            delBtn.BorderColor = Color.Red;
            delBtn.BorderRadius = 15;
            delBtn.BorderSize = 2;
            delBtn.Cursor = Cursors.Hand;
            delBtn.EnabledTextHover = true;
            delBtn.FlatAppearance.BorderSize = 0;
            delBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            delBtn.FlatAppearance.MouseOverBackColor = Color.Red;
            delBtn.FlatStyle = FlatStyle.Flat;
            delBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            delBtn.ForeColor = Color.Red;
            delBtn.Image = Properties.Resources.deleteIconRed16px;
            delBtn.ImageAlign = ContentAlignment.MiddleRight;
            delBtn.ImageHover = Properties.Resources.deleteIconWhite16px;
            delBtn.Location = new Point(1333, 4);
            delBtn.Margin = new Padding(4, 5, 4, 5);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(172, 64);
            delBtn.TabIndex = 25;
            delBtn.Text = " &Xóa";
            delBtn.TextColor = Color.Red;
            delBtn.TextHover = Color.White;
            delBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            delBtn.UseVisualStyleBackColor = false;
            // 
            // btnEditPN
            // 
            btnEditPN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditPN.BackColor = SystemColors.Control;
            btnEditPN.BackgroundColor = SystemColors.Control;
            btnEditPN.BorderColor = Color.DarkCyan;
            btnEditPN.BorderRadius = 15;
            btnEditPN.BorderSize = 2;
            btnEditPN.Cursor = Cursors.Hand;
            btnEditPN.EnabledTextHover = true;
            btnEditPN.FlatAppearance.BorderSize = 0;
            btnEditPN.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnEditPN.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnEditPN.FlatStyle = FlatStyle.Flat;
            btnEditPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditPN.ForeColor = Color.DarkCyan;
            btnEditPN.Image = Properties.Resources.editIconTeal16px;
            btnEditPN.ImageAlign = ContentAlignment.MiddleRight;
            btnEditPN.ImageHover = Properties.Resources.editIconWhite16px;
            btnEditPN.Location = new Point(1147, 4);
            btnEditPN.Margin = new Padding(4, 5, 4, 5);
            btnEditPN.Name = "btnEditPN";
            btnEditPN.Size = new Size(172, 64);
            btnEditPN.TabIndex = 24;
            btnEditPN.Text = " Sửa";
            btnEditPN.TextColor = Color.DarkCyan;
            btnEditPN.TextHover = Color.White;
            btnEditPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditPN.UseVisualStyleBackColor = false;
            btnEditPN.Click += btnEditPN_Click;
            // 
            // btnAddPN
            // 
            btnAddPN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddPN.BackColor = SystemColors.Control;
            btnAddPN.BackgroundColor = SystemColors.Control;
            btnAddPN.BorderColor = Color.DarkCyan;
            btnAddPN.BorderRadius = 15;
            btnAddPN.BorderSize = 2;
            btnAddPN.Cursor = Cursors.Hand;
            btnAddPN.EnabledTextHover = true;
            btnAddPN.FlatAppearance.BorderSize = 0;
            btnAddPN.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnAddPN.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnAddPN.FlatStyle = FlatStyle.Flat;
            btnAddPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddPN.ForeColor = Color.DarkCyan;
            btnAddPN.Image = Properties.Resources.addIconTeal16px;
            btnAddPN.ImageAlign = ContentAlignment.MiddleRight;
            btnAddPN.ImageHover = Properties.Resources.addIconWhite16px;
            btnAddPN.Location = new Point(961, 4);
            btnAddPN.Margin = new Padding(4, 5, 4, 5);
            btnAddPN.Name = "btnAddPN";
            btnAddPN.Size = new Size(172, 64);
            btnAddPN.TabIndex = 23;
            btnAddPN.Text = " &Thêm";
            btnAddPN.TextColor = Color.DarkCyan;
            btnAddPN.TextHover = Color.White;
            btnAddPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddPN.UseVisualStyleBackColor = false;
            btnAddPN.Click += btnAddPN_Click;
            // 
            // dgvDsNhapHang
            // 
            dgvDsNhapHang.AllowUserToAddRows = false;
            dgvDsNhapHang.AllowUserToDeleteRows = false;
            dgvDsNhapHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDsNhapHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDsNhapHang.BorderStyle = BorderStyle.None;
            dgvDsNhapHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkCyan;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDsNhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDsNhapHang.ColumnHeadersHeight = 30;
            dgvDsNhapHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDsNhapHang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDsNhapHang.Dock = DockStyle.Bottom;
            dgvDsNhapHang.EnableHeadersVisualStyles = false;
            dgvDsNhapHang.GridColor = Color.DarkCyan;
            dgvDsNhapHang.ImeMode = ImeMode.NoControl;
            dgvDsNhapHang.Location = new Point(4, 340);
            dgvDsNhapHang.Margin = new Padding(4, 5, 4, 5);
            dgvDsNhapHang.Name = "dgvDsNhapHang";
            dgvDsNhapHang.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDsNhapHang.RowHeadersVisible = false;
            dgvDsNhapHang.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDsNhapHang.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDsNhapHang.RowTemplate.Height = 25;
            dgvDsNhapHang.RowTemplate.ReadOnly = true;
            dgvDsNhapHang.Size = new Size(1522, 543);
            dgvDsNhapHang.TabIndex = 22;
            dgvDsNhapHang.CellClick += dgvDsNhapHang_CellClick;
            // 
            // searchTxt
            // 
            searchTxt.BackColor = SystemColors.Window;
            searchTxt.BorderColor = Color.Silver;
            searchTxt.BorderFocusColor = Color.DarkCyan;
            searchTxt.BorderRadius = 15;
            searchTxt.BorderSize = 2;
            searchTxt.Font = new Font("Segoe UI", 12F);
            searchTxt.ForeColor = Color.DimGray;
            searchTxt.Location = new Point(10, 9);
            searchTxt.Margin = new Padding(4, 5, 4, 5);
            searchTxt.Multiline = false;
            searchTxt.Name = "searchTxt";
            searchTxt.Padding = new Padding(12, 11, 58, 11);
            searchTxt.PasswordChar = false;
            searchTxt.PlaceholderColor = Color.DarkGray;
            searchTxt.PlaceholderText = "Tìm Kiếm ...";
            searchTxt.Size = new Size(380, 55);
            searchTxt.TabIndex = 11;
            searchTxt.Texts = "";
            searchTxt.UnderlinedStyle = false;
            // 
            // detailTabPage
            // 
            detailTabPage.Controls.Add(txtTongTien);
            detailTabPage.Controls.Add(label18);
            detailTabPage.Controls.Add(HuyBtn);
            detailTabPage.Controls.Add(xacNhanBtn);
            detailTabPage.Controls.Add(gbCTPN);
            detailTabPage.Controls.Add(dtpPN);
            detailTabPage.Controls.Add(cbNccName);
            detailTabPage.Controls.Add(cbNhanVienId);
            detailTabPage.Controls.Add(cbNccId);
            detailTabPage.Controls.Add(cbNhanVienName);
            detailTabPage.Controls.Add(label6);
            detailTabPage.Controls.Add(label7);
            detailTabPage.Controls.Add(btn_back);
            detailTabPage.Controls.Add(label3);
            detailTabPage.Controls.Add(M);
            detailTabPage.Controls.Add(txtPhieuNhapId);
            detailTabPage.Controls.Add(label5);
            detailTabPage.Controls.Add(label4);
            detailTabPage.Controls.Add(lbPN);
            detailTabPage.Location = new Point(4, 34);
            detailTabPage.Margin = new Padding(4);
            detailTabPage.Name = "detailTabPage";
            detailTabPage.Padding = new Padding(4);
            detailTabPage.Size = new Size(1530, 887);
            detailTabPage.TabIndex = 1;
            detailTabPage.Text = "Chi Tiết";
            detailTabPage.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = Color.White;
            txtTongTien.BorderColor = Color.Silver;
            txtTongTien.BorderFocusColor = Color.Silver;
            txtTongTien.BorderRadius = 13;
            txtTongTien.BorderSize = 2;
            txtTongTien.Enabled = false;
            txtTongTien.Font = new Font("Segoe UI", 13F);
            txtTongTien.ForeColor = Color.DimGray;
            txtTongTien.Location = new Point(1179, 23);
            txtTongTien.Margin = new Padding(4, 5, 4, 5);
            txtTongTien.Multiline = false;
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Padding = new Padding(12, 15, 10, 11);
            txtTongTien.PasswordChar = false;
            txtTongTien.PlaceholderColor = Color.DarkGray;
            txtTongTien.PlaceholderText = "";
            txtTongTien.Size = new Size(217, 63);
            txtTongTien.TabIndex = 66;
            txtTongTien.Texts = "";
            txtTongTien.UnderlinedStyle = false;
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI", 12F);
            label18.Location = new Point(999, 9);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(216, 85);
            label18.TabIndex = 64;
            label18.Text = "Tổng Tiền: ";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HuyBtn
            // 
            HuyBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            HuyBtn.BackColor = SystemColors.Control;
            HuyBtn.BackgroundColor = SystemColors.Control;
            HuyBtn.BorderColor = Color.Red;
            HuyBtn.BorderRadius = 15;
            HuyBtn.BorderSize = 2;
            HuyBtn.Cursor = Cursors.Hand;
            HuyBtn.EnabledTextHover = true;
            HuyBtn.FlatAppearance.BorderSize = 0;
            HuyBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            HuyBtn.FlatAppearance.MouseOverBackColor = Color.Red;
            HuyBtn.FlatStyle = FlatStyle.Flat;
            HuyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            HuyBtn.ForeColor = Color.Red;
            HuyBtn.Image = Properties.Resources.CANCELiconRed;
            HuyBtn.ImageAlign = ContentAlignment.MiddleRight;
            HuyBtn.ImageHover = Properties.Resources.CANCELiconWhite;
            HuyBtn.Location = new Point(1325, 124);
            HuyBtn.Margin = new Padding(4, 5, 4, 5);
            HuyBtn.Name = "HuyBtn";
            HuyBtn.Size = new Size(196, 89);
            HuyBtn.TabIndex = 63;
            HuyBtn.Text = "  Hủy";
            HuyBtn.TextColor = Color.Red;
            HuyBtn.TextHover = Color.White;
            HuyBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            HuyBtn.UseVisualStyleBackColor = false;
            HuyBtn.Click += HuyBtn_Click;
            // 
            // xacNhanBtn
            // 
            xacNhanBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            xacNhanBtn.Location = new Point(1325, 223);
            xacNhanBtn.Margin = new Padding(4, 5, 4, 5);
            xacNhanBtn.Name = "xacNhanBtn";
            xacNhanBtn.Size = new Size(196, 89);
            xacNhanBtn.TabIndex = 62;
            xacNhanBtn.Text = "  Xác Nhận";
            xacNhanBtn.TextColor = Color.DarkCyan;
            xacNhanBtn.TextHover = Color.White;
            xacNhanBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            xacNhanBtn.UseVisualStyleBackColor = false;
            xacNhanBtn.Click += xacNhanBtn_Click;
            // 
            // gbCTPN
            // 
            gbCTPN.Controls.Add(dgvCTPN);
            gbCTPN.Controls.Add(pnCTPN);
            gbCTPN.Dock = DockStyle.Bottom;
            gbCTPN.Font = new Font("Segoe UI", 13F);
            gbCTPN.Location = new Point(4, 335);
            gbCTPN.Margin = new Padding(4);
            gbCTPN.Name = "gbCTPN";
            gbCTPN.Padding = new Padding(4);
            gbCTPN.Size = new Size(1522, 548);
            gbCTPN.TabIndex = 61;
            gbCTPN.TabStop = false;
            gbCTPN.Text = "Chi Tiết Phiếu Nhập";
            // 
            // dgvCTPN
            // 
            dgvCTPN.AllowUserToAddRows = false;
            dgvCTPN.AllowUserToDeleteRows = false;
            dgvCTPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTPN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCTPN.BorderStyle = BorderStyle.None;
            dgvCTPN.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.DarkCyan;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCTPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCTPN.ColumnHeadersHeight = 30;
            dgvCTPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvCTPN.DefaultCellStyle = dataGridViewCellStyle5;
            dgvCTPN.Dock = DockStyle.Bottom;
            dgvCTPN.EnableHeadersVisualStyles = false;
            dgvCTPN.GridColor = Color.DarkCyan;
            dgvCTPN.ImeMode = ImeMode.NoControl;
            dgvCTPN.Location = new Point(4, 208);
            dgvCTPN.Margin = new Padding(4, 5, 4, 5);
            dgvCTPN.Name = "dgvCTPN";
            dgvCTPN.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCTPN.RowHeadersVisible = false;
            dgvCTPN.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCTPN.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvCTPN.RowTemplate.Height = 25;
            dgvCTPN.RowTemplate.ReadOnly = true;
            dgvCTPN.Size = new Size(1514, 336);
            dgvCTPN.TabIndex = 23;
            dgvCTPN.CellClick += dgvNgl_CellClick;
            // 
            // pnCTPN
            // 
            pnCTPN.Controls.Add(btnSortCTPN);
            pnCTPN.Controls.Add(gbCtpnSort);
            pnCTPN.Controls.Add(resetCTPNBtn);
            pnCTPN.Controls.Add(btnFilterCTPN);
            pnCTPN.Controls.Add(btnDeleteCTPN);
            pnCTPN.Controls.Add(btnEditCTPN);
            pnCTPN.Controls.Add(btnAddCTPN);
            pnCTPN.Dock = DockStyle.Top;
            pnCTPN.Location = new Point(4, 39);
            pnCTPN.Margin = new Padding(4);
            pnCTPN.Name = "pnCTPN";
            pnCTPN.Size = new Size(1514, 169);
            pnCTPN.TabIndex = 24;
            // 
            // btnSortCTPN
            // 
            btnSortCTPN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSortCTPN.BackColor = SystemColors.Control;
            btnSortCTPN.BackgroundColor = SystemColors.Control;
            btnSortCTPN.BorderColor = Color.DeepSkyBlue;
            btnSortCTPN.BorderRadius = 15;
            btnSortCTPN.BorderSize = 2;
            btnSortCTPN.Cursor = Cursors.Hand;
            btnSortCTPN.EnabledTextHover = true;
            btnSortCTPN.FlatAppearance.BorderSize = 0;
            btnSortCTPN.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btnSortCTPN.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnSortCTPN.FlatStyle = FlatStyle.Flat;
            btnSortCTPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSortCTPN.ForeColor = Color.DeepSkyBlue;
            btnSortCTPN.ImageAlign = ContentAlignment.MiddleRight;
            btnSortCTPN.ImageHover = null;
            btnSortCTPN.Location = new Point(906, 90);
            btnSortCTPN.Margin = new Padding(4, 5, 4, 5);
            btnSortCTPN.Name = "btnSortCTPN";
            btnSortCTPN.Size = new Size(172, 64);
            btnSortCTPN.TabIndex = 38;
            btnSortCTPN.Text = "Sắp xếp";
            btnSortCTPN.TextColor = Color.DeepSkyBlue;
            btnSortCTPN.TextHover = Color.White;
            btnSortCTPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSortCTPN.UseVisualStyleBackColor = false;
            btnSortCTPN.Click += btnSortCTPN_Click;
            // 
            // gbCtpnSort
            // 
            gbCtpnSort.Controls.Add(groupBox6);
            gbCtpnSort.Controls.Add(groupBox9);
            gbCtpnSort.Controls.Add(groupBox11);
            gbCtpnSort.Font = new Font("Segoe UI", 9F);
            gbCtpnSort.Location = new Point(16, 7);
            gbCtpnSort.Name = "gbCtpnSort";
            gbCtpnSort.Size = new Size(531, 150);
            gbCtpnSort.TabIndex = 37;
            gbCtpnSort.TabStop = false;
            gbCtpnSort.Visible = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rbIDNglDec);
            groupBox6.Controls.Add(rbIDNglInc);
            groupBox6.Location = new Point(13, 30);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(159, 108);
            groupBox6.TabIndex = 24;
            groupBox6.TabStop = false;
            groupBox6.Text = "ID nguyên liệu";
            // 
            // rbIDNglDec
            // 
            rbIDNglDec.AutoSize = true;
            rbIDNglDec.Location = new Point(17, 65);
            rbIDNglDec.Name = "rbIDNglDec";
            rbIDNglDec.Size = new Size(78, 29);
            rbIDNglDec.TabIndex = 1;
            rbIDNglDec.TabStop = true;
            rbIDNglDec.Tag = "IDNglDec";
            rbIDNglDec.Text = "Giảm";
            rbIDNglDec.UseVisualStyleBackColor = true;
            rbIDNglDec.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // rbIDNglInc
            // 
            rbIDNglInc.AutoSize = true;
            rbIDNglInc.Location = new Point(17, 30);
            rbIDNglInc.Name = "rbIDNglInc";
            rbIDNglInc.Size = new Size(74, 29);
            rbIDNglInc.TabIndex = 0;
            rbIDNglInc.TabStop = true;
            rbIDNglInc.Tag = "IDNglInc";
            rbIDNglInc.Text = "Tăng";
            rbIDNglInc.UseVisualStyleBackColor = true;
            rbIDNglInc.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(rbKLNglDec);
            groupBox9.Controls.Add(rbKLNglInc);
            groupBox9.Location = new Point(178, 30);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(159, 108);
            groupBox9.TabIndex = 24;
            groupBox9.TabStop = false;
            groupBox9.Text = "Khối lượng";
            // 
            // rbKLNglDec
            // 
            rbKLNglDec.AutoSize = true;
            rbKLNglDec.Location = new Point(17, 65);
            rbKLNglDec.Name = "rbKLNglDec";
            rbKLNglDec.Size = new Size(78, 29);
            rbKLNglDec.TabIndex = 1;
            rbKLNglDec.TabStop = true;
            rbKLNglDec.Tag = "KhoiLuongDec";
            rbKLNglDec.Text = "Giảm";
            rbKLNglDec.UseVisualStyleBackColor = true;
            rbKLNglDec.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // rbKLNglInc
            // 
            rbKLNglInc.AutoSize = true;
            rbKLNglInc.Location = new Point(17, 30);
            rbKLNglInc.Name = "rbKLNglInc";
            rbKLNglInc.Size = new Size(74, 29);
            rbKLNglInc.TabIndex = 0;
            rbKLNglInc.TabStop = true;
            rbKLNglInc.Tag = "KhoiLuongInc";
            rbKLNglInc.Text = "Tăng";
            rbKLNglInc.UseVisualStyleBackColor = true;
            rbKLNglInc.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(rbDGNglDec);
            groupBox11.Controls.Add(rbDGNglInc);
            groupBox11.Location = new Point(343, 30);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(159, 108);
            groupBox11.TabIndex = 25;
            groupBox11.TabStop = false;
            groupBox11.Text = "Đơn giá";
            // 
            // rbDGNglDec
            // 
            rbDGNglDec.AutoSize = true;
            rbDGNglDec.Location = new Point(17, 65);
            rbDGNglDec.Name = "rbDGNglDec";
            rbDGNglDec.Size = new Size(78, 29);
            rbDGNglDec.TabIndex = 1;
            rbDGNglDec.TabStop = true;
            rbDGNglDec.Tag = "DonGiaDec";
            rbDGNglDec.Text = "Giảm";
            rbDGNglDec.UseVisualStyleBackColor = true;
            rbDGNglDec.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // rbDGNglInc
            // 
            rbDGNglInc.AutoSize = true;
            rbDGNglInc.Location = new Point(17, 30);
            rbDGNglInc.Name = "rbDGNglInc";
            rbDGNglInc.Size = new Size(74, 29);
            rbDGNglInc.TabIndex = 0;
            rbDGNglInc.TabStop = true;
            rbDGNglInc.Tag = "DonGiaInc";
            rbDGNglInc.Text = "Tăng";
            rbDGNglInc.UseVisualStyleBackColor = true;
            rbDGNglInc.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // resetCTPNBtn
            // 
            resetCTPNBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            resetCTPNBtn.BackColor = SystemColors.Control;
            resetCTPNBtn.BackgroundColor = SystemColors.Control;
            resetCTPNBtn.BorderColor = Color.Gray;
            resetCTPNBtn.BorderRadius = 15;
            resetCTPNBtn.BorderSize = 2;
            resetCTPNBtn.Cursor = Cursors.Hand;
            resetCTPNBtn.EnabledTextHover = true;
            resetCTPNBtn.FlatAppearance.BorderSize = 0;
            resetCTPNBtn.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            resetCTPNBtn.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            resetCTPNBtn.FlatStyle = FlatStyle.Flat;
            resetCTPNBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            resetCTPNBtn.ForeColor = Color.DarkGray;
            resetCTPNBtn.ImageAlign = ContentAlignment.MiddleRight;
            resetCTPNBtn.ImageHover = null;
            resetCTPNBtn.Location = new Point(1102, 90);
            resetCTPNBtn.Margin = new Padding(4, 5, 4, 5);
            resetCTPNBtn.Name = "resetCTPNBtn";
            resetCTPNBtn.Size = new Size(172, 64);
            resetCTPNBtn.TabIndex = 36;
            resetCTPNBtn.Text = "Reset";
            resetCTPNBtn.TextColor = Color.DarkGray;
            resetCTPNBtn.TextHover = Color.White;
            resetCTPNBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            resetCTPNBtn.UseVisualStyleBackColor = false;
            resetCTPNBtn.Click += resetCTPNBtn_Click;
            // 
            // btnFilterCTPN
            // 
            btnFilterCTPN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFilterCTPN.BackColor = SystemColors.Control;
            btnFilterCTPN.BackgroundColor = SystemColors.Control;
            btnFilterCTPN.BorderColor = Color.Goldenrod;
            btnFilterCTPN.BorderRadius = 15;
            btnFilterCTPN.BorderSize = 2;
            btnFilterCTPN.Cursor = Cursors.Hand;
            btnFilterCTPN.EnabledTextHover = true;
            btnFilterCTPN.FlatAppearance.BorderSize = 0;
            btnFilterCTPN.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            btnFilterCTPN.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnFilterCTPN.FlatStyle = FlatStyle.Flat;
            btnFilterCTPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFilterCTPN.ForeColor = Color.Goldenrod;
            btnFilterCTPN.ImageAlign = ContentAlignment.MiddleRight;
            btnFilterCTPN.ImageHover = null;
            btnFilterCTPN.Location = new Point(1299, 90);
            btnFilterCTPN.Margin = new Padding(4, 5, 4, 5);
            btnFilterCTPN.Name = "btnFilterCTPN";
            btnFilterCTPN.Size = new Size(172, 64);
            btnFilterCTPN.TabIndex = 35;
            btnFilterCTPN.Text = "Lọc";
            btnFilterCTPN.TextColor = Color.Goldenrod;
            btnFilterCTPN.TextHover = Color.White;
            btnFilterCTPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFilterCTPN.UseVisualStyleBackColor = false;
            btnFilterCTPN.Click += btnFilterCTPN_Click;
            // 
            // btnDeleteCTPN
            // 
            btnDeleteCTPN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteCTPN.BackColor = SystemColors.Control;
            btnDeleteCTPN.BackgroundColor = SystemColors.Control;
            btnDeleteCTPN.BorderColor = Color.Red;
            btnDeleteCTPN.BorderRadius = 15;
            btnDeleteCTPN.BorderSize = 2;
            btnDeleteCTPN.Cursor = Cursors.Hand;
            btnDeleteCTPN.EnabledTextHover = true;
            btnDeleteCTPN.FlatAppearance.BorderSize = 0;
            btnDeleteCTPN.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            btnDeleteCTPN.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDeleteCTPN.FlatStyle = FlatStyle.Flat;
            btnDeleteCTPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeleteCTPN.ForeColor = Color.Red;
            btnDeleteCTPN.Image = Properties.Resources.deleteIconRed16px;
            btnDeleteCTPN.ImageAlign = ContentAlignment.MiddleRight;
            btnDeleteCTPN.ImageHover = Properties.Resources.deleteIconWhite16px;
            btnDeleteCTPN.Location = new Point(1298, 16);
            btnDeleteCTPN.Margin = new Padding(4, 5, 4, 5);
            btnDeleteCTPN.Name = "btnDeleteCTPN";
            btnDeleteCTPN.Size = new Size(172, 64);
            btnDeleteCTPN.TabIndex = 34;
            btnDeleteCTPN.Text = "  Xóa";
            btnDeleteCTPN.TextColor = Color.Red;
            btnDeleteCTPN.TextHover = Color.White;
            btnDeleteCTPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteCTPN.UseVisualStyleBackColor = false;
            btnDeleteCTPN.Click += btnDeleteCTPN_Click;
            // 
            // btnEditCTPN
            // 
            btnEditCTPN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditCTPN.BackColor = SystemColors.Control;
            btnEditCTPN.BackgroundColor = SystemColors.Control;
            btnEditCTPN.BorderColor = Color.DarkCyan;
            btnEditCTPN.BorderRadius = 15;
            btnEditCTPN.BorderSize = 2;
            btnEditCTPN.Cursor = Cursors.Hand;
            btnEditCTPN.EnabledTextHover = true;
            btnEditCTPN.FlatAppearance.BorderSize = 0;
            btnEditCTPN.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnEditCTPN.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnEditCTPN.FlatStyle = FlatStyle.Flat;
            btnEditCTPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditCTPN.ForeColor = Color.DarkCyan;
            btnEditCTPN.Image = Properties.Resources.editIconTeal16px;
            btnEditCTPN.ImageAlign = ContentAlignment.MiddleRight;
            btnEditCTPN.ImageHover = Properties.Resources.editIconWhite16px;
            btnEditCTPN.Location = new Point(1101, 16);
            btnEditCTPN.Margin = new Padding(4, 5, 4, 5);
            btnEditCTPN.Name = "btnEditCTPN";
            btnEditCTPN.Size = new Size(172, 64);
            btnEditCTPN.TabIndex = 33;
            btnEditCTPN.Text = "  Sửa";
            btnEditCTPN.TextColor = Color.DarkCyan;
            btnEditCTPN.TextHover = Color.White;
            btnEditCTPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditCTPN.UseVisualStyleBackColor = false;
            btnEditCTPN.Click += btnEditCTPN_Click;
            // 
            // btnAddCTPN
            // 
            btnAddCTPN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddCTPN.BackColor = SystemColors.Control;
            btnAddCTPN.BackgroundColor = SystemColors.Control;
            btnAddCTPN.BorderColor = Color.DarkCyan;
            btnAddCTPN.BorderRadius = 15;
            btnAddCTPN.BorderSize = 2;
            btnAddCTPN.Cursor = Cursors.Hand;
            btnAddCTPN.EnabledTextHover = true;
            btnAddCTPN.FlatAppearance.BorderSize = 0;
            btnAddCTPN.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnAddCTPN.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnAddCTPN.FlatStyle = FlatStyle.Flat;
            btnAddCTPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddCTPN.ForeColor = Color.DarkCyan;
            btnAddCTPN.Image = Properties.Resources.addIconTeal16px;
            btnAddCTPN.ImageAlign = ContentAlignment.MiddleRight;
            btnAddCTPN.ImageHover = Properties.Resources.addIconWhite16px;
            btnAddCTPN.Location = new Point(904, 16);
            btnAddCTPN.Margin = new Padding(4, 5, 4, 5);
            btnAddCTPN.Name = "btnAddCTPN";
            btnAddCTPN.Size = new Size(172, 64);
            btnAddCTPN.TabIndex = 32;
            btnAddCTPN.Text = "  Thêm";
            btnAddCTPN.TextColor = Color.DarkCyan;
            btnAddCTPN.TextHover = Color.White;
            btnAddCTPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddCTPN.UseVisualStyleBackColor = false;
            btnAddCTPN.Click += btn_addCTPN_Click;
            // 
            // dtpPN
            // 
            dtpPN.Font = new Font("Segoe UI", 13F);
            dtpPN.Location = new Point(48, 275);
            dtpPN.Margin = new Padding(4);
            dtpPN.Name = "dtpPN";
            dtpPN.Size = new Size(428, 42);
            dtpPN.TabIndex = 60;
            // 
            // cbNccName
            // 
            cbNccName.Font = new Font("Segoe UI", 13F);
            cbNccName.FormattingEnabled = true;
            cbNccName.Location = new Point(910, 275);
            cbNccName.Margin = new Padding(4);
            cbNccName.Name = "cbNccName";
            cbNccName.Size = new Size(348, 44);
            cbNccName.TabIndex = 59;
            cbNccName.SelectedIndexChanged += cbNccName_SelectedIndexChanged;
            // 
            // cbNhanVienId
            // 
            cbNhanVienId.BackColor = Color.White;
            cbNhanVienId.Font = new Font("Segoe UI", 13F);
            cbNhanVienId.ForeColor = SystemColors.WindowText;
            cbNhanVienId.FormattingEnabled = true;
            cbNhanVienId.Location = new Point(519, 163);
            cbNhanVienId.Margin = new Padding(4);
            cbNhanVienId.Name = "cbNhanVienId";
            cbNhanVienId.Size = new Size(348, 44);
            cbNhanVienId.TabIndex = 58;
            cbNhanVienId.SelectedIndexChanged += cbNhanVienId_SelectedIndexChanged;
            // 
            // cbNccId
            // 
            cbNccId.Font = new Font("Segoe UI", 13F);
            cbNccId.FormattingEnabled = true;
            cbNccId.Items.AddRange(new object[] { "False", "True" });
            cbNccId.Location = new Point(910, 163);
            cbNccId.Margin = new Padding(4);
            cbNccId.Name = "cbNccId";
            cbNccId.Size = new Size(348, 44);
            cbNccId.TabIndex = 57;
            cbNccId.SelectedIndexChanged += cbNccId_SelectedIndexChanged;
            // 
            // cbNhanVienName
            // 
            cbNhanVienName.Font = new Font("Segoe UI", 13F);
            cbNhanVienName.FormattingEnabled = true;
            cbNhanVienName.Location = new Point(519, 275);
            cbNhanVienName.Margin = new Padding(4);
            cbNhanVienName.Name = "cbNhanVienName";
            cbNhanVienName.Size = new Size(348, 44);
            cbNhanVienName.TabIndex = 56;
            cbNhanVienName.SelectedIndexChanged += cbNhanVienName_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(511, 193);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(191, 85);
            label6.TabIndex = 55;
            label6.Text = "Tên Nhân Viên";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 17F);
            label7.Location = new Point(124, 4);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(391, 71);
            label7.TabIndex = 40;
            label7.Text = "Thông Tin Phiếu Nhập";
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
            btn_back.Location = new Point(11, 9);
            btn_back.Margin = new Padding(4, 5, 4, 5);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(90, 69);
            btn_back.TabIndex = 39;
            btn_back.TextColor = Color.White;
            btn_back.TextHover = Color.White;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(906, 78);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(216, 85);
            label3.TabIndex = 33;
            label3.Text = "ID Nhà Cung Cấp";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // M
            // 
            M.Font = new Font("Segoe UI", 12F);
            M.Location = new Point(494, 80);
            M.Margin = new Padding(4, 0, 4, 0);
            M.Name = "M";
            M.Size = new Size(208, 85);
            M.TabIndex = 31;
            M.Text = "ID Nhân Viên";
            M.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPhieuNhapId
            // 
            txtPhieuNhapId.BackColor = Color.LightGray;
            txtPhieuNhapId.BorderColor = Color.Silver;
            txtPhieuNhapId.BorderFocusColor = Color.Silver;
            txtPhieuNhapId.BorderRadius = 13;
            txtPhieuNhapId.BorderSize = 2;
            txtPhieuNhapId.Enabled = false;
            txtPhieuNhapId.Font = new Font("Segoe UI", 13F);
            txtPhieuNhapId.ForeColor = Color.DimGray;
            txtPhieuNhapId.Location = new Point(48, 145);
            txtPhieuNhapId.Margin = new Padding(4, 5, 4, 5);
            txtPhieuNhapId.Multiline = false;
            txtPhieuNhapId.Name = "txtPhieuNhapId";
            txtPhieuNhapId.Padding = new Padding(12, 15, 10, 11);
            txtPhieuNhapId.PasswordChar = false;
            txtPhieuNhapId.PlaceholderColor = Color.DarkGray;
            txtPhieuNhapId.PlaceholderText = "Nhập ID....";
            txtPhieuNhapId.Size = new Size(429, 63);
            txtPhieuNhapId.TabIndex = 30;
            txtPhieuNhapId.Texts = "";
            txtPhieuNhapId.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(20, 206);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(158, 85);
            label5.TabIndex = 27;
            label5.Text = "Ngày Nhập";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(906, 193);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(238, 85);
            label4.TabIndex = 26;
            label4.Text = "Tên Nhà Cung Cấp";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbPN
            // 
            lbPN.Font = new Font("Segoe UI", 12F);
            lbPN.Location = new Point(24, 81);
            lbPN.Margin = new Padding(4, 0, 4, 0);
            lbPN.Name = "lbPN";
            lbPN.Size = new Size(196, 85);
            lbPN.TabIndex = 25;
            lbPN.Text = "ID Phiếu Nhập";
            lbPN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // moreDetailTabPage
            // 
            moreDetailTabPage.Controls.Add(btnAddNgl);
            moreDetailTabPage.Controls.Add(btnHuyCTPN);
            moreDetailTabPage.Controls.Add(btnXacNhanCTPN);
            moreDetailTabPage.Controls.Add(txtCTPNDonGia);
            moreDetailTabPage.Controls.Add(label13);
            moreDetailTabPage.Controls.Add(txtCTPNKhoiLuong);
            moreDetailTabPage.Controls.Add(cbNglId);
            moreDetailTabPage.Controls.Add(cbNglName);
            moreDetailTabPage.Controls.Add(label12);
            moreDetailTabPage.Controls.Add(label14);
            moreDetailTabPage.Controls.Add(txtCTPNId);
            moreDetailTabPage.Controls.Add(label15);
            moreDetailTabPage.Controls.Add(lbCTPNId);
            moreDetailTabPage.Controls.Add(label11);
            moreDetailTabPage.Controls.Add(btn_back2);
            moreDetailTabPage.Location = new Point(4, 34);
            moreDetailTabPage.Margin = new Padding(4);
            moreDetailTabPage.Name = "moreDetailTabPage";
            moreDetailTabPage.Padding = new Padding(4);
            moreDetailTabPage.Size = new Size(1530, 887);
            moreDetailTabPage.TabIndex = 2;
            moreDetailTabPage.Text = "Chi Tiết Phiếu Nhập";
            moreDetailTabPage.UseVisualStyleBackColor = true;
            // 
            // btnAddNgl
            // 
            btnAddNgl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNgl.BackColor = SystemColors.Control;
            btnAddNgl.BackgroundColor = SystemColors.Control;
            btnAddNgl.BorderColor = Color.DarkCyan;
            btnAddNgl.BorderRadius = 15;
            btnAddNgl.BorderSize = 2;
            btnAddNgl.Cursor = Cursors.Hand;
            btnAddNgl.EnabledTextHover = true;
            btnAddNgl.FlatAppearance.BorderSize = 0;
            btnAddNgl.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnAddNgl.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnAddNgl.FlatStyle = FlatStyle.Flat;
            btnAddNgl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddNgl.ForeColor = Color.DarkCyan;
            btnAddNgl.Image = Properties.Resources.addIconTeal16px;
            btnAddNgl.ImageAlign = ContentAlignment.MiddleRight;
            btnAddNgl.ImageHover = Properties.Resources.addIconWhite16px;
            btnAddNgl.Location = new Point(1061, 296);
            btnAddNgl.Margin = new Padding(4, 5, 4, 5);
            btnAddNgl.Name = "btnAddNgl";
            btnAddNgl.Size = new Size(225, 89);
            btnAddNgl.TabIndex = 76;
            btnAddNgl.Text = " Thêm nguyên liệu mới";
            btnAddNgl.TextColor = Color.DarkCyan;
            btnAddNgl.TextHover = Color.White;
            btnAddNgl.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddNgl.UseVisualStyleBackColor = false;
            btnAddNgl.Click += btnAddNgl_Click;
            // 
            // btnHuyCTPN
            // 
            btnHuyCTPN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHuyCTPN.BackColor = SystemColors.Control;
            btnHuyCTPN.BackgroundColor = SystemColors.Control;
            btnHuyCTPN.BorderColor = Color.Red;
            btnHuyCTPN.BorderRadius = 15;
            btnHuyCTPN.BorderSize = 2;
            btnHuyCTPN.Cursor = Cursors.Hand;
            btnHuyCTPN.EnabledTextHover = true;
            btnHuyCTPN.FlatAppearance.BorderSize = 0;
            btnHuyCTPN.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            btnHuyCTPN.FlatAppearance.MouseOverBackColor = Color.Red;
            btnHuyCTPN.FlatStyle = FlatStyle.Flat;
            btnHuyCTPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuyCTPN.ForeColor = Color.Red;
            btnHuyCTPN.Image = Properties.Resources.CANCELiconRed;
            btnHuyCTPN.ImageAlign = ContentAlignment.MiddleRight;
            btnHuyCTPN.ImageHover = Properties.Resources.CANCELiconWhite;
            btnHuyCTPN.Location = new Point(1300, 759);
            btnHuyCTPN.Margin = new Padding(4, 5, 4, 5);
            btnHuyCTPN.Name = "btnHuyCTPN";
            btnHuyCTPN.Size = new Size(196, 89);
            btnHuyCTPN.TabIndex = 75;
            btnHuyCTPN.Text = "  &Hủy";
            btnHuyCTPN.TextColor = Color.Red;
            btnHuyCTPN.TextHover = Color.White;
            btnHuyCTPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHuyCTPN.UseVisualStyleBackColor = false;
            btnHuyCTPN.Click += btnHuyCTPN_Click;
            // 
            // btnXacNhanCTPN
            // 
            btnXacNhanCTPN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXacNhanCTPN.BackColor = SystemColors.Control;
            btnXacNhanCTPN.BackgroundColor = SystemColors.Control;
            btnXacNhanCTPN.BorderColor = Color.DarkCyan;
            btnXacNhanCTPN.BorderRadius = 15;
            btnXacNhanCTPN.BorderSize = 2;
            btnXacNhanCTPN.Cursor = Cursors.Hand;
            btnXacNhanCTPN.EnabledTextHover = true;
            btnXacNhanCTPN.FlatAppearance.BorderSize = 0;
            btnXacNhanCTPN.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnXacNhanCTPN.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnXacNhanCTPN.FlatStyle = FlatStyle.Flat;
            btnXacNhanCTPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXacNhanCTPN.ForeColor = Color.DarkCyan;
            btnXacNhanCTPN.Image = Properties.Resources.ConfirmIcondarkcyan1;
            btnXacNhanCTPN.ImageAlign = ContentAlignment.MiddleRight;
            btnXacNhanCTPN.ImageHover = Properties.Resources.ConfirmIconWhite1;
            btnXacNhanCTPN.Location = new Point(1081, 759);
            btnXacNhanCTPN.Margin = new Padding(4, 5, 4, 5);
            btnXacNhanCTPN.Name = "btnXacNhanCTPN";
            btnXacNhanCTPN.Size = new Size(196, 89);
            btnXacNhanCTPN.TabIndex = 74;
            btnXacNhanCTPN.Text = "  &Xác Nhận";
            btnXacNhanCTPN.TextColor = Color.DarkCyan;
            btnXacNhanCTPN.TextHover = Color.White;
            btnXacNhanCTPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXacNhanCTPN.UseVisualStyleBackColor = false;
            btnXacNhanCTPN.Click += btnXacNhanCTPN_Click;
            // 
            // txtCTPNDonGia
            // 
            txtCTPNDonGia.BackColor = SystemColors.Window;
            txtCTPNDonGia.BorderColor = Color.Silver;
            txtCTPNDonGia.BorderFocusColor = Color.DeepSkyBlue;
            txtCTPNDonGia.BorderRadius = 13;
            txtCTPNDonGia.BorderSize = 2;
            txtCTPNDonGia.Font = new Font("Segoe UI", 13F);
            txtCTPNDonGia.ForeColor = Color.DimGray;
            txtCTPNDonGia.Location = new Point(942, 151);
            txtCTPNDonGia.Margin = new Padding(4, 5, 4, 5);
            txtCTPNDonGia.Multiline = false;
            txtCTPNDonGia.Name = "txtCTPNDonGia";
            txtCTPNDonGia.Padding = new Padding(12, 15, 10, 11);
            txtCTPNDonGia.PasswordChar = false;
            txtCTPNDonGia.PlaceholderColor = Color.DarkGray;
            txtCTPNDonGia.PlaceholderText = "Nhập đơn giá";
            txtCTPNDonGia.Size = new Size(429, 63);
            txtCTPNDonGia.TabIndex = 2;
            txtCTPNDonGia.Texts = "";
            txtCTPNDonGia.UnderlinedStyle = false;
            txtCTPNDonGia._TextChanged += txtCTPNDonGia__TextChanged;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(915, 82);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(158, 85);
            label13.TabIndex = 72;
            label13.Text = "Đơn Giá";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCTPNKhoiLuong
            // 
            txtCTPNKhoiLuong.BackColor = SystemColors.Window;
            txtCTPNKhoiLuong.BorderColor = Color.Silver;
            txtCTPNKhoiLuong.BorderFocusColor = Color.DeepSkyBlue;
            txtCTPNKhoiLuong.BorderRadius = 13;
            txtCTPNKhoiLuong.BorderSize = 2;
            txtCTPNKhoiLuong.Font = new Font("Segoe UI", 13F);
            txtCTPNKhoiLuong.ForeColor = Color.DimGray;
            txtCTPNKhoiLuong.Location = new Point(65, 289);
            txtCTPNKhoiLuong.Margin = new Padding(4, 5, 4, 5);
            txtCTPNKhoiLuong.Multiline = false;
            txtCTPNKhoiLuong.Name = "txtCTPNKhoiLuong";
            txtCTPNKhoiLuong.Padding = new Padding(12, 15, 10, 11);
            txtCTPNKhoiLuong.PasswordChar = false;
            txtCTPNKhoiLuong.PlaceholderColor = Color.DarkGray;
            txtCTPNKhoiLuong.PlaceholderText = "Nhập khối lượng";
            txtCTPNKhoiLuong.Size = new Size(429, 63);
            txtCTPNKhoiLuong.TabIndex = 1;
            txtCTPNKhoiLuong.Texts = "";
            txtCTPNKhoiLuong.UnderlinedStyle = false;
            txtCTPNKhoiLuong._TextChanged += txtCTPNKhoiLuong__TextChanged;
            // 
            // cbNglId
            // 
            cbNglId.Font = new Font("Segoe UI", 13F);
            cbNglId.FormattingEnabled = true;
            cbNglId.Location = new Point(536, 169);
            cbNglId.Margin = new Padding(4);
            cbNglId.Name = "cbNglId";
            cbNglId.Size = new Size(348, 44);
            cbNglId.TabIndex = 9;
            cbNglId.SelectedIndexChanged += cbNglId_SelectedIndexChanged;
            // 
            // cbNglName
            // 
            cbNglName.Font = new Font("Segoe UI", 13F);
            cbNglName.FormattingEnabled = true;
            cbNglName.Location = new Point(536, 306);
            cbNglName.Margin = new Padding(4);
            cbNglName.Name = "cbNglName";
            cbNglName.Size = new Size(348, 44);
            cbNglName.TabIndex = 0;
            cbNglName.SelectedIndexChanged += cbNglName_SelectedIndexChanged;
            cbNglName.Click += cbNglName_Click;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(511, 224);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(214, 85);
            label12.TabIndex = 67;
            label12.Text = "Tên Nguyên Liệu";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(511, 86);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(208, 85);
            label14.TabIndex = 65;
            label14.Text = "ID Nguyên Liệu";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCTPNId
            // 
            txtCTPNId.BackColor = Color.LightGray;
            txtCTPNId.BorderColor = Color.Silver;
            txtCTPNId.BorderFocusColor = Color.DarkCyan;
            txtCTPNId.BorderRadius = 13;
            txtCTPNId.BorderSize = 2;
            txtCTPNId.Enabled = false;
            txtCTPNId.Font = new Font("Segoe UI", 13F);
            txtCTPNId.ForeColor = Color.DimGray;
            txtCTPNId.Location = new Point(65, 151);
            txtCTPNId.Margin = new Padding(4, 5, 4, 5);
            txtCTPNId.Multiline = false;
            txtCTPNId.Name = "txtCTPNId";
            txtCTPNId.Padding = new Padding(12, 15, 10, 11);
            txtCTPNId.PasswordChar = false;
            txtCTPNId.PlaceholderColor = Color.DarkGray;
            txtCTPNId.PlaceholderText = "Nhập ID";
            txtCTPNId.Size = new Size(429, 63);
            txtCTPNId.TabIndex = 0;
            txtCTPNId.Texts = "";
            txtCTPNId.UnderlinedStyle = false;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(38, 220);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(200, 85);
            label15.TabIndex = 63;
            label15.Text = "Khối Lượng (Kg)";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbCTPNId
            // 
            lbCTPNId.Font = new Font("Segoe UI", 12F);
            lbCTPNId.Location = new Point(41, 88);
            lbCTPNId.Margin = new Padding(4, 0, 4, 0);
            lbCTPNId.Name = "lbCTPNId";
            lbCTPNId.Size = new Size(196, 85);
            lbCTPNId.TabIndex = 61;
            lbCTPNId.Text = "ID Phiếu Nhập";
            lbCTPNId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 17F);
            label11.Location = new Point(122, 15);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(521, 71);
            label11.TabIndex = 42;
            label11.Text = "Thông Tin Chi Tiết Phiếu Nhập";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_back2
            // 
            btn_back2.BackColor = Color.Transparent;
            btn_back2.BackgroundColor = Color.Transparent;
            btn_back2.BorderColor = Color.PaleVioletRed;
            btn_back2.BorderRadius = 20;
            btn_back2.BorderSize = 0;
            btn_back2.Cursor = Cursors.Hand;
            btn_back2.EnabledTextHover = false;
            btn_back2.FlatAppearance.BorderSize = 0;
            btn_back2.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_back2.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_back2.FlatStyle = FlatStyle.Flat;
            btn_back2.ForeColor = Color.White;
            btn_back2.Image = Properties.Resources.arrowreturn32pxBlack1;
            btn_back2.ImageHover = Properties.Resources.arrowreturn32pxWhite1;
            btn_back2.Location = new Point(10, 20);
            btn_back2.Margin = new Padding(4, 5, 4, 5);
            btn_back2.Name = "btn_back2";
            btn_back2.Size = new Size(90, 69);
            btn_back2.TabIndex = 41;
            btn_back2.TextColor = Color.White;
            btn_back2.TextHover = Color.White;
            btn_back2.UseVisualStyleBackColor = false;
            btn_back2.Click += btn_back2_Click;
            // 
            // addNgl
            // 
            addNgl.Controls.Add(btnHuyAdd);
            addNgl.Controls.Add(btnXacNhanAdd);
            addNgl.Controls.Add(label2);
            addNgl.Controls.Add(btnBackCTPN);
            addNgl.Controls.Add(caPhePic);
            addNgl.Controls.Add(label8);
            addNgl.Controls.Add(txtNglPrice);
            addNgl.Controls.Add(label9);
            addNgl.Controls.Add(txtNglInfo);
            addNgl.Controls.Add(label10);
            addNgl.Controls.Add(txtNglWeigh);
            addNgl.Controls.Add(txtNglName);
            addNgl.Controls.Add(label16);
            addNgl.Controls.Add(label19);
            addNgl.Location = new Point(4, 34);
            addNgl.Name = "addNgl";
            addNgl.Size = new Size(1530, 887);
            addNgl.TabIndex = 3;
            addNgl.Text = "thêm ngl";
            addNgl.UseVisualStyleBackColor = true;
            // 
            // btnHuyAdd
            // 
            btnHuyAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHuyAdd.BackColor = SystemColors.Control;
            btnHuyAdd.BackgroundColor = SystemColors.Control;
            btnHuyAdd.BorderColor = Color.Red;
            btnHuyAdd.BorderRadius = 15;
            btnHuyAdd.BorderSize = 2;
            btnHuyAdd.Cursor = Cursors.Hand;
            btnHuyAdd.EnabledTextHover = true;
            btnHuyAdd.FlatAppearance.BorderSize = 0;
            btnHuyAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            btnHuyAdd.FlatAppearance.MouseOverBackColor = Color.Red;
            btnHuyAdd.FlatStyle = FlatStyle.Flat;
            btnHuyAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuyAdd.ForeColor = Color.Red;
            btnHuyAdd.Image = Properties.Resources.CANCELiconRed;
            btnHuyAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnHuyAdd.ImageHover = Properties.Resources.CANCELiconWhite;
            btnHuyAdd.Location = new Point(1322, 783);
            btnHuyAdd.Margin = new Padding(4, 5, 4, 5);
            btnHuyAdd.Name = "btnHuyAdd";
            btnHuyAdd.Size = new Size(196, 89);
            btnHuyAdd.TabIndex = 72;
            btnHuyAdd.Text = "  Hủy";
            btnHuyAdd.TextColor = Color.Red;
            btnHuyAdd.TextHover = Color.White;
            btnHuyAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHuyAdd.UseVisualStyleBackColor = false;
            btnHuyAdd.Click += btnHuyAdd_Click;
            // 
            // btnXacNhanAdd
            // 
            btnXacNhanAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXacNhanAdd.BackColor = SystemColors.Control;
            btnXacNhanAdd.BackgroundColor = SystemColors.Control;
            btnXacNhanAdd.BorderColor = Color.DarkCyan;
            btnXacNhanAdd.BorderRadius = 15;
            btnXacNhanAdd.BorderSize = 2;
            btnXacNhanAdd.Cursor = Cursors.Hand;
            btnXacNhanAdd.EnabledTextHover = true;
            btnXacNhanAdd.FlatAppearance.BorderSize = 0;
            btnXacNhanAdd.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnXacNhanAdd.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnXacNhanAdd.FlatStyle = FlatStyle.Flat;
            btnXacNhanAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXacNhanAdd.ForeColor = Color.DarkCyan;
            btnXacNhanAdd.Image = Properties.Resources.ConfirmIcondarkcyan1;
            btnXacNhanAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnXacNhanAdd.ImageHover = Properties.Resources.ConfirmIconWhite1;
            btnXacNhanAdd.Location = new Point(1103, 783);
            btnXacNhanAdd.Margin = new Padding(4, 5, 4, 5);
            btnXacNhanAdd.Name = "btnXacNhanAdd";
            btnXacNhanAdd.Size = new Size(196, 89);
            btnXacNhanAdd.TabIndex = 71;
            btnXacNhanAdd.Text = "  Xác Nhận";
            btnXacNhanAdd.TextColor = Color.DarkCyan;
            btnXacNhanAdd.TextHover = Color.White;
            btnXacNhanAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXacNhanAdd.UseVisualStyleBackColor = false;
            btnXacNhanAdd.Click += btnXacNhanAdd_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 17F);
            label2.Location = new Point(110, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(374, 71);
            label2.TabIndex = 70;
            label2.Text = "Thêm nguyên liệu mới";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBackCTPN
            // 
            btnBackCTPN.BackColor = Color.Transparent;
            btnBackCTPN.BackgroundColor = Color.Transparent;
            btnBackCTPN.BorderColor = Color.PaleVioletRed;
            btnBackCTPN.BorderRadius = 20;
            btnBackCTPN.BorderSize = 0;
            btnBackCTPN.Cursor = Cursors.Hand;
            btnBackCTPN.EnabledTextHover = false;
            btnBackCTPN.FlatAppearance.BorderSize = 0;
            btnBackCTPN.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnBackCTPN.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnBackCTPN.FlatStyle = FlatStyle.Flat;
            btnBackCTPN.ForeColor = Color.White;
            btnBackCTPN.Image = Properties.Resources.arrowreturn32pxBlack1;
            btnBackCTPN.ImageHover = Properties.Resources.arrowreturn32pxWhite1;
            btnBackCTPN.Location = new Point(12, 20);
            btnBackCTPN.Margin = new Padding(4, 5, 4, 5);
            btnBackCTPN.Name = "btnBackCTPN";
            btnBackCTPN.Size = new Size(90, 69);
            btnBackCTPN.TabIndex = 69;
            btnBackCTPN.TextColor = Color.White;
            btnBackCTPN.TextHover = Color.White;
            btnBackCTPN.UseVisualStyleBackColor = false;
            btnBackCTPN.Click += btnBackCTPN_Click;
            // 
            // caPhePic
            // 
            caPhePic.BackColor = SystemColors.ActiveBorder;
            caPhePic.BackgroundImageLayout = ImageLayout.None;
            caPhePic.Cursor = Cursors.Hand;
            caPhePic.Image = Properties.Resources.defaultImage3;
            caPhePic.Location = new Point(89, 439);
            caPhePic.Margin = new Padding(4, 5, 4, 5);
            caPhePic.Name = "caPhePic";
            caPhePic.Size = new Size(229, 240);
            caPhePic.SizeMode = PictureBoxSizeMode.StretchImage;
            caPhePic.TabIndex = 68;
            caPhePic.TabStop = false;
            caPhePic.Click += caPhePic_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(67, 395);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(151, 49);
            label8.TabIndex = 67;
            label8.Text = "Hình Ảnh";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNglPrice
            // 
            txtNglPrice.BackColor = SystemColors.Window;
            txtNglPrice.BorderColor = Color.Silver;
            txtNglPrice.BorderFocusColor = Color.DeepSkyBlue;
            txtNglPrice.BorderRadius = 13;
            txtNglPrice.BorderSize = 2;
            txtNglPrice.Font = new Font("Segoe UI", 13F);
            txtNglPrice.ForeColor = Color.DimGray;
            txtNglPrice.Location = new Point(905, 172);
            txtNglPrice.Margin = new Padding(4, 5, 4, 5);
            txtNglPrice.Multiline = false;
            txtNglPrice.Name = "txtNglPrice";
            txtNglPrice.Padding = new Padding(12, 15, 10, 11);
            txtNglPrice.PasswordChar = false;
            txtNglPrice.PlaceholderColor = Color.DarkGray;
            txtNglPrice.PlaceholderText = "Nhập giá tiền";
            txtNglPrice.Size = new Size(349, 63);
            txtNglPrice.TabIndex = 66;
            txtNglPrice.Texts = "";
            txtNglPrice.UnderlinedStyle = false;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(901, 105);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(216, 85);
            label9.TabIndex = 65;
            label9.Text = "Giá Tiền (Kg)";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNglInfo
            // 
            txtNglInfo.BackColor = SystemColors.Window;
            txtNglInfo.BorderColor = Color.Silver;
            txtNglInfo.BorderFocusColor = Color.DeepSkyBlue;
            txtNglInfo.BorderRadius = 13;
            txtNglInfo.BorderSize = 2;
            txtNglInfo.Font = new Font("Segoe UI", 13F);
            txtNglInfo.ForeColor = Color.DimGray;
            txtNglInfo.Location = new Point(513, 172);
            txtNglInfo.Margin = new Padding(4, 5, 4, 5);
            txtNglInfo.Multiline = false;
            txtNglInfo.Name = "txtNglInfo";
            txtNglInfo.Padding = new Padding(12, 15, 10, 11);
            txtNglInfo.PasswordChar = false;
            txtNglInfo.PlaceholderColor = Color.DarkGray;
            txtNglInfo.PlaceholderText = "Nhập thông tin";
            txtNglInfo.Size = new Size(349, 63);
            txtNglInfo.TabIndex = 64;
            txtNglInfo.Texts = "";
            txtNglInfo.UnderlinedStyle = false;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(489, 107);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(151, 85);
            label10.TabIndex = 63;
            label10.Text = "Thông Tin";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNglWeigh
            // 
            txtNglWeigh.BackColor = SystemColors.Window;
            txtNglWeigh.BorderColor = Color.Silver;
            txtNglWeigh.BorderFocusColor = Color.DeepSkyBlue;
            txtNglWeigh.BorderRadius = 13;
            txtNglWeigh.BorderSize = 2;
            txtNglWeigh.Font = new Font("Segoe UI", 13F);
            txtNglWeigh.ForeColor = Color.DimGray;
            txtNglWeigh.Location = new Point(89, 305);
            txtNglWeigh.Margin = new Padding(4, 5, 4, 5);
            txtNglWeigh.Multiline = false;
            txtNglWeigh.Name = "txtNglWeigh";
            txtNglWeigh.Padding = new Padding(12, 15, 10, 11);
            txtNglWeigh.PasswordChar = false;
            txtNglWeigh.PlaceholderColor = Color.DarkGray;
            txtNglWeigh.PlaceholderText = "Nhập khối lượng";
            txtNglWeigh.Size = new Size(349, 63);
            txtNglWeigh.TabIndex = 61;
            txtNglWeigh.Texts = "";
            txtNglWeigh.UnderlinedStyle = false;
            // 
            // txtNglName
            // 
            txtNglName.BackColor = SystemColors.Window;
            txtNglName.BorderColor = Color.Silver;
            txtNglName.BorderFocusColor = Color.DeepSkyBlue;
            txtNglName.BorderRadius = 13;
            txtNglName.BorderSize = 2;
            txtNglName.Font = new Font("Segoe UI", 13F);
            txtNglName.ForeColor = Color.DimGray;
            txtNglName.Location = new Point(89, 172);
            txtNglName.Margin = new Padding(4, 5, 4, 5);
            txtNglName.Multiline = false;
            txtNglName.Name = "txtNglName";
            txtNglName.Padding = new Padding(12, 15, 10, 11);
            txtNglName.PasswordChar = false;
            txtNglName.PlaceholderColor = Color.DarkGray;
            txtNglName.PlaceholderText = "Nhập tên nguyên liệu";
            txtNglName.Size = new Size(349, 63);
            txtNglName.TabIndex = 60;
            txtNglName.Texts = "";
            txtNglName.UnderlinedStyle = false;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(61, 105);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(112, 85);
            label16.TabIndex = 59;
            label16.Text = "Tên";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Font = new Font("Segoe UI", 12F);
            label19.Location = new Point(67, 230);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(151, 85);
            label19.TabIndex = 58;
            label19.Text = "Khối Lượng";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NhapHangView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1538, 925);
            Controls.Add(tcNhapHang);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "NhapHangView";
            Text = "NhapHangView";
            tcNhapHang.ResumeLayout(false);
            listTabPage.ResumeLayout(false);
            gbSort.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsNhapHang).EndInit();
            detailTabPage.ResumeLayout(false);
            gbCTPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).EndInit();
            pnCTPN.ResumeLayout(false);
            gbCtpnSort.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            moreDetailTabPage.ResumeLayout(false);
            addNgl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)caPhePic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcNhapHang;
        private TabPage listTabPage;
        private DataGridView dgvDsNhapHang;
        private CustomControl.CustomTextBox searchTxt;
        private TabPage detailTabPage;
        private ComboBox cbNhanVienName;
        private Label label6;
        private Label label7;
        private CustomControl.CustomButton btn_back;
        private Label label3;
        private Label M;
        private CustomControl.CustomTextBox txtPhieuNhapId;
        private Label label5;
        private Label label4;
        private Label lbPN;
        private CustomControl.CustomButton delBtn;
        private CustomControl.CustomButton btnEditPN;
        private CustomControl.CustomButton btnAddPN;
        private ComboBox cbNccName;
        private ComboBox cbNhanVienId;
        private ComboBox cbNccId;
        private DateTimePicker dtpPN;
        private GroupBox gbCTPN;
        private DataGridView dgvCTPN;
        private CustomControl.CustomButton xacNhanBtn;
        private CustomControl.CustomButton HuyBtn;
        private Panel pnCTPN;
        private CustomControl.CustomButton btnDeleteCTPN;
        private CustomControl.CustomButton btnEditCTPN;
        private CustomControl.CustomButton btnAddCTPN;
        private TabPage moreDetailTabPage;
        private Label label11;
        private CustomControl.CustomButton btn_back2;
        private ComboBox cbNglId;
        private ComboBox cbNglName;
        private Label label12;
        private Label label14;
        private CustomControl.CustomTextBox txtCTPNId;
        private Label label15;
        private Label lbCTPNId;
        private Label label18;
        private CustomControl.CustomTextBox txtCTPNDonGia;
        private Label label13;
        private CustomControl.CustomTextBox txtCTPNKhoiLuong;
        private CustomControl.CustomButton btnHuyCTPN;
        private CustomControl.CustomButton btnXacNhanCTPN;
        private CustomControl.CustomButton btnFilterPN;
        private CustomControl.CustomButton sortBtn;
        private CustomControl.CustomButton resetBtn;
        private GroupBox gbSort;
        private GroupBox groupBox5;
        private RadioButton rbIDNccDec;
        private RadioButton rbIDNccInc;
        private GroupBox groupBox2;
        private RadioButton rbIDPnDec;
        private RadioButton rbIDPnInc;
        private GroupBox groupBox4;
        private RadioButton rbNNDec;
        private RadioButton rbNNInc;
        private GroupBox groupBox3;
        private RadioButton rbIDNvDec;
        private RadioButton rbIDNvInc;
        private GroupBox groupBox7;
        private RadioButton rbTTDec;
        private RadioButton rbTTInc;
        private CustomControl.CustomTextBox txtTongTien;
        private CustomControl.CustomButton btnFilterCTPN;
        private CustomControl.CustomButton resetCTPNBtn;
        private GroupBox gbCtpnSort;
        private GroupBox groupBox6;
        private RadioButton rbIDNglDec;
        private RadioButton rbIDNglInc;
        private GroupBox groupBox9;
        private RadioButton rbKLNglDec;
        private RadioButton rbKLNglInc;
        private GroupBox groupBox11;
        private RadioButton rbDGNglDec;
        private RadioButton rbDGNglInc;
        private CustomControl.CustomButton btnSortCTPN;
        private TabPage addNgl;
        private CustomControl.CustomButton btnHuyAdd;
        private CustomControl.CustomButton btnXacNhanAdd;
        private Label label2;
        private CustomControl.CustomButton btnBackCTPN;
        private PictureBox caPhePic;
        private Label label8;
        private CustomControl.CustomTextBox txtNglPrice;
        private Label label9;
        private CustomControl.CustomTextBox txtNglInfo;
        private Label label10;
        private CustomControl.CustomTextBox txtNglWeigh;
        private CustomControl.CustomTextBox txtNglName;
        private Label label16;
        private Label label19;
        private CustomControl.CustomButton btnAddNgl;
        private CustomControl.CustomButton btnFindPn;
        private CustomControl.CustomButton btnXemPN;
    }
}