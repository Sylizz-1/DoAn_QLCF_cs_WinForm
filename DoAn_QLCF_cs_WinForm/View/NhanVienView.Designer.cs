﻿namespace DoAn_QLCF_cs_WinForm.View
{
    partial class NhanVienView
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            listTabPage = new TabPage();
            label9 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            customButton2 = new CustomControl.CustomButton();
            searchTxt = new CustomControl.CustomTextBox();
            delBtn = new CustomControl.CustomButton();
            editBtn = new CustomControl.CustomButton();
            addBtn = new CustomControl.CustomButton();
            dtgv_nhanVien = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            detailTabPage = new TabPage();
            groupBox2 = new GroupBox();
            cb_isDeleted = new CheckBox();
            matkhauTxt = new CustomControl.CustomTextBox();
            M = new Label();
            taikhoanTxt = new CustomControl.CustomTextBox();
            txt_passwordConfirm = new CustomControl.CustomTextBox();
            label10 = new Label();
            label13 = new Label();
            quyencmb = new ComboBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            dtp_ngaySinh = new CustomControl.CustomDateTimePicker();
            emailTxt = new CustomControl.CustomTextBox();
            sdtTxt = new CustomControl.CustomTextBox();
            idTxt = new CustomControl.CustomTextBox();
            label1 = new Label();
            label12 = new Label();
            gioitinhcmb = new ComboBox();
            tenTxt = new CustomControl.CustomTextBox();
            label11 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            HuyBtn = new CustomControl.CustomButton();
            xacNhanBtn = new CustomControl.CustomButton();
            label7 = new Label();
            btn_back = new CustomControl.CustomButton();
            tabControl1.SuspendLayout();
            listTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_nhanVien).BeginInit();
            detailTabPage.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(listTabPage);
            tabControl1.Controls.Add(detailTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1230, 740);
            tabControl1.TabIndex = 1;
            // 
            // listTabPage
            // 
            listTabPage.Controls.Add(label9);
            listTabPage.Controls.Add(label2);
            listTabPage.Controls.Add(comboBox2);
            listTabPage.Controls.Add(comboBox1);
            listTabPage.Controls.Add(customButton2);
            listTabPage.Controls.Add(searchTxt);
            listTabPage.Controls.Add(delBtn);
            listTabPage.Controls.Add(editBtn);
            listTabPage.Controls.Add(addBtn);
            listTabPage.Controls.Add(dtgv_nhanVien);
            listTabPage.Location = new Point(4, 29);
            listTabPage.Name = "listTabPage";
            listTabPage.Padding = new Padding(3);
            listTabPage.Size = new Size(1222, 707);
            listTabPage.TabIndex = 0;
            listTabPage.Text = "Danh Sach";
            listTabPage.UseVisualStyleBackColor = true;
            listTabPage.Click += listTabPage_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(338, 15);
            label9.Name = "label9";
            label9.Size = new Size(46, 41);
            label9.TabIndex = 31;
            label9.Text = "Lọc:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(538, 16);
            label2.Name = "label2";
            label2.Size = new Size(83, 41);
            label2.TabIndex = 30;
            label2.Text = "Sắp xếp:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(390, 19);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(142, 38);
            comboBox2.TabIndex = 29;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(627, 19);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 38);
            comboBox1.TabIndex = 28;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.Transparent;
            customButton2.BackgroundColor = Color.Transparent;
            customButton2.BorderColor = Color.PaleVioletRed;
            customButton2.BorderRadius = 15;
            customButton2.BorderSize = 0;
            customButton2.Cursor = Cursors.Hand;
            customButton2.EnabledTextHover = false;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 64, 64, 64);
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.ForeColor = Color.White;
            customButton2.ImageHover = null;
            customButton2.Location = new Point(278, 15);
            customButton2.Margin = new Padding(3, 4, 3, 4);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(40, 37);
            customButton2.TabIndex = 27;
            customButton2.TextColor = Color.White;
            customButton2.TextHover = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // searchTxt
            // 
            searchTxt.BackColor = SystemColors.Window;
            searchTxt.BorderColor = Color.Silver;
            searchTxt.BorderFocusColor = Color.DarkCyan;
            searchTxt.BorderRadius = 15;
            searchTxt.BorderSize = 2;
            searchTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchTxt.ForeColor = Color.DimGray;
            searchTxt.Location = new Point(21, 11);
            searchTxt.Margin = new Padding(3, 4, 3, 4);
            searchTxt.Multiline = false;
            searchTxt.Name = "searchTxt";
            searchTxt.Padding = new Padding(10, 9, 46, 9);
            searchTxt.PasswordChar = false;
            searchTxt.PlaceholderColor = Color.DarkGray;
            searchTxt.PlaceholderText = "Tìm Kiếm ...";
            searchTxt.Size = new Size(304, 47);
            searchTxt.TabIndex = 26;
            searchTxt.Texts = "";
            searchTxt.UnderlinedStyle = false;
            searchTxt._TextChanged += searchTxt__TextChanged;
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
            delBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delBtn.ForeColor = Color.Red;
            delBtn.Image = Properties.Resources.deleteIconRed16px;
            delBtn.ImageAlign = ContentAlignment.MiddleRight;
            delBtn.ImageHover = Properties.Resources.deleteIconWhite16px;
            delBtn.Location = new Point(1077, 12);
            delBtn.Margin = new Padding(3, 4, 3, 4);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(138, 51);
            delBtn.TabIndex = 25;
            delBtn.Text = "  Xóa";
            delBtn.TextColor = Color.Red;
            delBtn.TextHover = Color.White;
            delBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editBtn.BackColor = SystemColors.Control;
            editBtn.BackgroundColor = SystemColors.Control;
            editBtn.BorderColor = Color.DarkCyan;
            editBtn.BorderRadius = 15;
            editBtn.BorderSize = 2;
            editBtn.Cursor = Cursors.Hand;
            editBtn.EnabledTextHover = true;
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            editBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editBtn.ForeColor = Color.DarkCyan;
            editBtn.Image = Properties.Resources.editIconTeal16px;
            editBtn.ImageAlign = ContentAlignment.MiddleRight;
            editBtn.ImageHover = Properties.Resources.editIconWhite16px;
            editBtn.Location = new Point(931, 12);
            editBtn.Margin = new Padding(3, 4, 3, 4);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(138, 51);
            editBtn.TabIndex = 24;
            editBtn.Text = "  Sửa";
            editBtn.TextColor = Color.DarkCyan;
            editBtn.TextHover = Color.White;
            editBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addBtn.BackColor = SystemColors.Control;
            addBtn.BackgroundColor = SystemColors.Control;
            addBtn.BorderColor = Color.DarkCyan;
            addBtn.BorderRadius = 15;
            addBtn.BorderSize = 2;
            addBtn.Cursor = Cursors.Hand;
            addBtn.EnabledTextHover = true;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            addBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.DarkCyan;
            addBtn.Image = Properties.Resources.addIconTeal16px;
            addBtn.ImageAlign = ContentAlignment.MiddleRight;
            addBtn.ImageHover = Properties.Resources.addIconWhite16px;
            addBtn.Location = new Point(785, 12);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(138, 51);
            addBtn.TabIndex = 23;
            addBtn.Text = "  Thêm";
            addBtn.TextColor = Color.DarkCyan;
            addBtn.TextHover = Color.White;
            addBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // dtgv_nhanVien
            // 
            dtgv_nhanVien.AllowUserToAddRows = false;
            dtgv_nhanVien.AllowUserToDeleteRows = false;
            dtgv_nhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgv_nhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_nhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgv_nhanVien.BorderStyle = BorderStyle.None;
            dtgv_nhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.DarkCyan;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.Control;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dtgv_nhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dtgv_nhanVien.ColumnHeadersHeight = 30;
            dtgv_nhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv_nhanVien.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dtgv_nhanVien.DefaultCellStyle = dataGridViewCellStyle11;
            dtgv_nhanVien.EnableHeadersVisualStyles = false;
            dtgv_nhanVien.GridColor = Color.DarkCyan;
            dtgv_nhanVien.ImeMode = ImeMode.NoControl;
            dtgv_nhanVien.Location = new Point(3, 156);
            dtgv_nhanVien.Margin = new Padding(3, 4, 3, 4);
            dtgv_nhanVien.Name = "dtgv_nhanVien";
            dtgv_nhanVien.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgv_nhanVien.RowHeadersVisible = false;
            dtgv_nhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_nhanVien.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dtgv_nhanVien.RowTemplate.Height = 25;
            dtgv_nhanVien.RowTemplate.ReadOnly = true;
            dtgv_nhanVien.Size = new Size(1216, 548);
            dtgv_nhanVien.TabIndex = 22;
            dtgv_nhanVien.ColumnHeaderMouseClick += dtgv_nhanVien_ColumnHeaderMouseClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Visible = false;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số điện thoại";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Visible = false;
            // 
            // Column5
            // 
            Column5.HeaderText = "Giới tính";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Visible = false;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ngày sinh";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Visible = false;
            // 
            // Column7
            // 
            Column7.HeaderText = "Tài khoản";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Visible = false;
            // 
            // Column8
            // 
            Column8.HeaderText = "Mật khẩu";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Visible = false;
            // 
            // Column9
            // 
            Column9.HeaderText = "Chức vụ";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Visible = false;
            // 
            // Column10
            // 
            Column10.HeaderText = "Trạng thái";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Visible = false;
            // 
            // detailTabPage
            // 
            detailTabPage.Controls.Add(groupBox2);
            detailTabPage.Controls.Add(groupBox1);
            detailTabPage.Controls.Add(HuyBtn);
            detailTabPage.Controls.Add(xacNhanBtn);
            detailTabPage.Controls.Add(label7);
            detailTabPage.Controls.Add(btn_back);
            detailTabPage.Location = new Point(4, 29);
            detailTabPage.Name = "detailTabPage";
            detailTabPage.Padding = new Padding(3);
            detailTabPage.Size = new Size(1222, 707);
            detailTabPage.TabIndex = 1;
            detailTabPage.Text = "Chi Tiết";
            detailTabPage.UseVisualStyleBackColor = true;
            detailTabPage.Click += detailTabPage_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cb_isDeleted);
            groupBox2.Controls.Add(matkhauTxt);
            groupBox2.Controls.Add(M);
            groupBox2.Controls.Add(taikhoanTxt);
            groupBox2.Controls.Add(txt_passwordConfirm);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(quyencmb);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(621, 95);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(591, 337);
            groupBox2.TabIndex = 59;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin tài khoản";
            // 
            // cb_isDeleted
            // 
            cb_isDeleted.AutoSize = true;
            cb_isDeleted.Location = new Point(238, 258);
            cb_isDeleted.Name = "cb_isDeleted";
            cb_isDeleted.Size = new Size(136, 36);
            cb_isDeleted.TabIndex = 60;
            cb_isDeleted.Text = "IsDeleted";
            cb_isDeleted.UseVisualStyleBackColor = true;
            // 
            // matkhauTxt
            // 
            matkhauTxt.BackColor = SystemColors.Window;
            matkhauTxt.BorderColor = Color.Silver;
            matkhauTxt.BorderFocusColor = Color.DarkCyan;
            matkhauTxt.BorderRadius = 13;
            matkhauTxt.BorderSize = 2;
            matkhauTxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            matkhauTxt.ForeColor = Color.DimGray;
            matkhauTxt.Location = new Point(21, 184);
            matkhauTxt.Margin = new Padding(3, 4, 3, 4);
            matkhauTxt.Multiline = false;
            matkhauTxt.Name = "matkhauTxt";
            matkhauTxt.Padding = new Padding(10, 12, 8, 9);
            matkhauTxt.PasswordChar = false;
            matkhauTxt.PlaceholderColor = Color.DarkGray;
            matkhauTxt.PlaceholderText = "Nhập mật khẩu...";
            matkhauTxt.Size = new Size(279, 52);
            matkhauTxt.TabIndex = 58;
            matkhauTxt.Texts = "";
            matkhauTxt.UnderlinedStyle = false;
            matkhauTxt.KeyPress += matkhauTxt_KeyPress;
            // 
            // M
            // 
            M.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            M.Location = new Point(6, 38);
            M.Name = "M";
            M.Size = new Size(121, 34);
            M.TabIndex = 31;
            M.Text = "Tài Khoản";
            M.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // taikhoanTxt
            // 
            taikhoanTxt.BackColor = SystemColors.Window;
            taikhoanTxt.BorderColor = Color.Silver;
            taikhoanTxt.BorderFocusColor = Color.DarkCyan;
            taikhoanTxt.BorderRadius = 13;
            taikhoanTxt.BorderSize = 2;
            taikhoanTxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            taikhoanTxt.ForeColor = Color.DimGray;
            taikhoanTxt.Location = new Point(21, 76);
            taikhoanTxt.Margin = new Padding(3, 4, 3, 4);
            taikhoanTxt.Multiline = false;
            taikhoanTxt.Name = "taikhoanTxt";
            taikhoanTxt.Padding = new Padding(10, 12, 8, 9);
            taikhoanTxt.PasswordChar = false;
            taikhoanTxt.PlaceholderColor = Color.DarkGray;
            taikhoanTxt.PlaceholderText = "Nhập tài khoản...";
            taikhoanTxt.Size = new Size(279, 52);
            taikhoanTxt.TabIndex = 32;
            taikhoanTxt.Texts = "";
            taikhoanTxt.UnderlinedStyle = false;
            taikhoanTxt.KeyPress += taikhoanTxt_KeyPress;
            // 
            // txt_passwordConfirm
            // 
            txt_passwordConfirm.BackColor = SystemColors.Window;
            txt_passwordConfirm.BorderColor = Color.Silver;
            txt_passwordConfirm.BorderFocusColor = Color.DarkCyan;
            txt_passwordConfirm.BorderRadius = 13;
            txt_passwordConfirm.BorderSize = 2;
            txt_passwordConfirm.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_passwordConfirm.ForeColor = Color.DimGray;
            txt_passwordConfirm.Location = new Point(311, 184);
            txt_passwordConfirm.Margin = new Padding(3, 4, 3, 4);
            txt_passwordConfirm.Multiline = false;
            txt_passwordConfirm.Name = "txt_passwordConfirm";
            txt_passwordConfirm.Padding = new Padding(10, 12, 8, 9);
            txt_passwordConfirm.PasswordChar = false;
            txt_passwordConfirm.PlaceholderColor = Color.DarkGray;
            txt_passwordConfirm.PlaceholderText = "Nhập mật khẩu...";
            txt_passwordConfirm.Size = new Size(279, 52);
            txt_passwordConfirm.TabIndex = 57;
            txt_passwordConfirm.Texts = "";
            txt_passwordConfirm.UnderlinedStyle = false;
            txt_passwordConfirm.KeyPress += txt_passwordConfirm_KeyPress;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(311, 36);
            label10.Name = "label10";
            label10.Size = new Size(90, 36);
            label10.TabIndex = 47;
            label10.Text = "Quyền";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(306, 145);
            label13.Name = "label13";
            label13.Size = new Size(186, 43);
            label13.TabIndex = 56;
            label13.Text = "Nhập Lại Mật Khẩu";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quyencmb
            // 
            quyencmb.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            quyencmb.FormattingEnabled = true;
            quyencmb.Location = new Point(311, 76);
            quyencmb.Name = "quyencmb";
            quyencmb.Size = new Size(274, 44);
            quyencmb.TabIndex = 49;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 143);
            label3.Name = "label3";
            label3.Size = new Size(127, 37);
            label3.TabIndex = 33;
            label3.Text = "Mật Khẩu";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtp_ngaySinh);
            groupBox1.Controls.Add(emailTxt);
            groupBox1.Controls.Add(sdtTxt);
            groupBox1.Controls.Add(idTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(gioitinhcmb);
            groupBox1.Controls.Add(tenTxt);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(9, 95);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(605, 337);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // dtp_ngaySinh
            // 
            dtp_ngaySinh.BorderColor = Color.PaleVioletRed;
            dtp_ngaySinh.BorderSize = 0;
            dtp_ngaySinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_ngaySinh.Location = new Point(319, 286);
            dtp_ngaySinh.MinimumSize = new Size(4, 35);
            dtp_ngaySinh.Name = "dtp_ngaySinh";
            dtp_ngaySinh.Size = new Size(279, 35);
            dtp_ngaySinh.SkinColor = Color.MediumSlateBlue;
            dtp_ngaySinh.TabIndex = 60;
            dtp_ngaySinh.TextColor = Color.White;
            // 
            // emailTxt
            // 
            emailTxt.BackColor = SystemColors.Window;
            emailTxt.BorderColor = Color.Silver;
            emailTxt.BorderFocusColor = Color.DarkCyan;
            emailTxt.BorderRadius = 13;
            emailTxt.BorderSize = 2;
            emailTxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            emailTxt.ForeColor = Color.DimGray;
            emailTxt.Location = new Point(7, 184);
            emailTxt.Margin = new Padding(3, 4, 3, 4);
            emailTxt.Multiline = false;
            emailTxt.Name = "emailTxt";
            emailTxt.Padding = new Padding(10, 12, 8, 9);
            emailTxt.PasswordChar = false;
            emailTxt.PlaceholderColor = Color.DarkGray;
            emailTxt.PlaceholderText = "Nhập email...";
            emailTxt.Size = new Size(279, 52);
            emailTxt.TabIndex = 53;
            emailTxt.Texts = "";
            emailTxt.UnderlinedStyle = false;
            emailTxt.KeyPress += emailTxt_KeyPress;
            // 
            // sdtTxt
            // 
            sdtTxt.BackColor = SystemColors.Window;
            sdtTxt.BorderColor = Color.Silver;
            sdtTxt.BorderFocusColor = Color.DarkCyan;
            sdtTxt.BorderRadius = 13;
            sdtTxt.BorderSize = 2;
            sdtTxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            sdtTxt.ForeColor = Color.DimGray;
            sdtTxt.Location = new Point(319, 184);
            sdtTxt.Margin = new Padding(3, 4, 3, 4);
            sdtTxt.Multiline = false;
            sdtTxt.Name = "sdtTxt";
            sdtTxt.Padding = new Padding(10, 12, 8, 9);
            sdtTxt.PasswordChar = false;
            sdtTxt.PlaceholderColor = Color.DarkGray;
            sdtTxt.PlaceholderText = "Nhập số điện thoại...";
            sdtTxt.Size = new Size(279, 52);
            sdtTxt.TabIndex = 52;
            sdtTxt.Texts = "";
            sdtTxt.UnderlinedStyle = false;
            sdtTxt.KeyPress += sdtTxt_KeyPress;
            // 
            // idTxt
            // 
            idTxt.BackColor = SystemColors.Window;
            idTxt.BorderColor = Color.Silver;
            idTxt.BorderFocusColor = Color.DarkCyan;
            idTxt.BorderRadius = 13;
            idTxt.BorderSize = 2;
            idTxt.Enabled = false;
            idTxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            idTxt.ForeColor = Color.DimGray;
            idTxt.Location = new Point(7, 76);
            idTxt.Margin = new Padding(3, 4, 3, 4);
            idTxt.Multiline = false;
            idTxt.Name = "idTxt";
            idTxt.Padding = new Padding(10, 12, 8, 9);
            idTxt.PasswordChar = false;
            idTxt.PlaceholderColor = Color.DarkGray;
            idTxt.PlaceholderText = "Nhập ID....";
            idTxt.Size = new Size(279, 52);
            idTxt.TabIndex = 30;
            idTxt.Texts = "";
            idTxt.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-10, 25);
            label1.Name = "label1";
            label1.Size = new Size(90, 68);
            label1.TabIndex = 25;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(319, 238);
            label12.Name = "label12";
            label12.Size = new Size(103, 45);
            label12.TabIndex = 53;
            label12.Text = "Ngày Sinh";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gioitinhcmb
            // 
            gioitinhcmb.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            gioitinhcmb.FormattingEnabled = true;
            gioitinhcmb.Items.AddRange(new object[] { "Nam", "Nữ" });
            gioitinhcmb.Location = new Point(7, 286);
            gioitinhcmb.Name = "gioitinhcmb";
            gioitinhcmb.Size = new Size(279, 44);
            gioitinhcmb.TabIndex = 51;
            gioitinhcmb.Text = "Nữ";
            // 
            // tenTxt
            // 
            tenTxt.BackColor = SystemColors.Window;
            tenTxt.BorderColor = Color.Silver;
            tenTxt.BorderFocusColor = Color.DarkCyan;
            tenTxt.BorderRadius = 13;
            tenTxt.BorderSize = 2;
            tenTxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tenTxt.ForeColor = Color.DimGray;
            tenTxt.Location = new Point(319, 76);
            tenTxt.Margin = new Padding(3, 4, 3, 4);
            tenTxt.Multiline = false;
            tenTxt.Name = "tenTxt";
            tenTxt.Padding = new Padding(10, 12, 8, 9);
            tenTxt.PasswordChar = false;
            tenTxt.PlaceholderColor = Color.DarkGray;
            tenTxt.PlaceholderText = "Nhập tên nhân viên...";
            tenTxt.Size = new Size(279, 52);
            tenTxt.TabIndex = 28;
            tenTxt.Texts = "";
            tenTxt.UnderlinedStyle = false;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(7, 243);
            label11.Name = "label11";
            label11.Size = new Size(90, 35);
            label11.TabIndex = 50;
            label11.Text = "Giới Tính";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(319, 25);
            label5.Name = "label5";
            label5.Size = new Size(90, 68);
            label5.TabIndex = 27;
            label5.Text = "Họ Tên";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(305, 132);
            label4.Name = "label4";
            label4.Size = new Size(150, 68);
            label4.TabIndex = 26;
            label4.Text = "Số Điện Thoại";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(7, 132);
            label6.Name = "label6";
            label6.Size = new Size(85, 68);
            label6.TabIndex = 35;
            label6.Text = "Email";
            label6.TextAlign = ContentAlignment.MiddleCenter;
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
            HuyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HuyBtn.ForeColor = Color.Red;
            HuyBtn.Image = Properties.Resources.CANCELiconRed;
            HuyBtn.ImageAlign = ContentAlignment.MiddleRight;
            HuyBtn.ImageHover = Properties.Resources.CANCELiconWhite;
            HuyBtn.Location = new Point(641, 591);
            HuyBtn.Margin = new Padding(3, 4, 3, 4);
            HuyBtn.Name = "HuyBtn";
            HuyBtn.Size = new Size(157, 71);
            HuyBtn.TabIndex = 46;
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
            xacNhanBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            xacNhanBtn.ForeColor = Color.DarkCyan;
            xacNhanBtn.Image = Properties.Resources.ConfirmIcondarkcyan1;
            xacNhanBtn.ImageAlign = ContentAlignment.MiddleRight;
            xacNhanBtn.ImageHover = Properties.Resources.ConfirmIconWhite1;
            xacNhanBtn.Location = new Point(437, 591);
            xacNhanBtn.Margin = new Padding(3, 4, 3, 4);
            xacNhanBtn.Name = "xacNhanBtn";
            xacNhanBtn.Size = new Size(157, 71);
            xacNhanBtn.TabIndex = 45;
            xacNhanBtn.Text = "  Xác Nhận";
            xacNhanBtn.TextColor = Color.DarkCyan;
            xacNhanBtn.TextHover = Color.White;
            xacNhanBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            xacNhanBtn.UseVisualStyleBackColor = false;
            xacNhanBtn.Click += xacNhanBtn_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(437, 25);
            label7.Name = "label7";
            label7.Size = new Size(336, 57);
            label7.TabIndex = 40;
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
            btn_back.Location = new Point(9, 7);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(72, 55);
            btn_back.TabIndex = 39;
            btn_back.TextColor = Color.White;
            btn_back.TextHover = Color.White;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // NhanVienView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 740);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "NhanVienView";
            Text = "NhanVienView";
            tabControl1.ResumeLayout(false);
            listTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_nhanVien).EndInit();
            detailTabPage.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage listTabPage;
        private DataGridView dtgv_nhanVien;
        private TabPage detailTabPage;
        private Label label7;
        private CustomControl.CustomButton btn_back;
        private Label label6;
        private Label label3;
        private CustomControl.CustomTextBox taikhoanTxt;
        private Label M;
        private CustomControl.CustomTextBox idTxt;
        private CustomControl.CustomTextBox tenTxt;
        private Label label5;
        private Label label1;
        private CustomControl.CustomButton delBtn;
        private CustomControl.CustomButton editBtn;
        private CustomControl.CustomButton addBtn;
        private Label label9;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private CustomControl.CustomButton customButton2;
        private CustomControl.CustomTextBox searchTxt;
        private CustomControl.CustomButton HuyBtn;
        private CustomControl.CustomButton xacNhanBtn;
        private ComboBox quyencmb;
        private Label label10;
        private ComboBox gioitinhcmb;
        private Label label11;
        private Label label12;
        private CustomControl.CustomTextBox txt_passwordConfirm;
        private Label label13;
        private GroupBox groupBox1;
        private Label label4;
        private CustomControl.CustomTextBox emailTxt;
        private CustomControl.CustomTextBox sdtTxt;
        private GroupBox groupBox2;
        private CustomControl.CustomTextBox matkhauTxt;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private CheckBox cb_isDeleted;
        private CustomControl.CustomDateTimePicker dtp_ngaySinh;
    }
}