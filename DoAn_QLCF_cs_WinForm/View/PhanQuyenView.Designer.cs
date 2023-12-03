namespace DoAn_QLCF_cs_WinForm.View
{
    partial class PhanQuyenView
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
            grb_quyen = new GroupBox();
            tc_quyen = new TabControl();
            tp_quyenDanhSach = new TabPage();
            dtgrv_quyen = new DataGridView();
            delBtn = new CustomControl.CustomButton();
            editBtn = new CustomControl.CustomButton();
            addBtn = new CustomControl.CustomButton();
            customButton2 = new CustomControl.CustomButton();
            searchTxt = new CustomControl.CustomTextBox();
            tp_quyenChiTiet = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            grb_chucNang = new GroupBox();
            tc_chucNang = new TabControl();
            tp_chucNangDanhSach = new TabPage();
            dtgrv_chucNang = new DataGridView();
            customButton3 = new CustomControl.CustomButton();
            customButton4 = new CustomControl.CustomButton();
            customButton5 = new CustomControl.CustomButton();
            customButton1 = new CustomControl.CustomButton();
            customTextBox1 = new CustomControl.CustomTextBox();
            tp_chucNangChiTiet = new TabPage();
            button = new CustomControl.CustomButton();
            grb_quyen.SuspendLayout();
            tc_quyen.SuspendLayout();
            tp_quyenDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrv_quyen).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            grb_chucNang.SuspendLayout();
            tc_chucNang.SuspendLayout();
            tp_chucNangDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrv_chucNang).BeginInit();
            SuspendLayout();
            // 
            // grb_quyen
            // 
            grb_quyen.BackColor = SystemColors.Window;
            grb_quyen.Controls.Add(tc_quyen);
            grb_quyen.Dock = DockStyle.Fill;
            grb_quyen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grb_quyen.Location = new Point(3, 3);
            grb_quyen.Name = "grb_quyen";
            grb_quyen.Size = new Size(744, 734);
            grb_quyen.TabIndex = 0;
            grb_quyen.TabStop = false;
            grb_quyen.Text = "Quyền";
            // 
            // tc_quyen
            // 
            tc_quyen.Controls.Add(tp_quyenDanhSach);
            tc_quyen.Controls.Add(tp_quyenChiTiet);
            tc_quyen.Dock = DockStyle.Fill;
            tc_quyen.Location = new Point(3, 30);
            tc_quyen.Name = "tc_quyen";
            tc_quyen.SelectedIndex = 0;
            tc_quyen.Size = new Size(738, 701);
            tc_quyen.TabIndex = 0;
            // 
            // tp_quyenDanhSach
            // 
            tp_quyenDanhSach.BackColor = SystemColors.Window;
            tp_quyenDanhSach.Controls.Add(button);
            tp_quyenDanhSach.Controls.Add(dtgrv_quyen);
            tp_quyenDanhSach.Controls.Add(delBtn);
            tp_quyenDanhSach.Controls.Add(editBtn);
            tp_quyenDanhSach.Controls.Add(addBtn);
            tp_quyenDanhSach.Controls.Add(customButton2);
            tp_quyenDanhSach.Controls.Add(searchTxt);
            tp_quyenDanhSach.Location = new Point(4, 37);
            tp_quyenDanhSach.Name = "tp_quyenDanhSach";
            tp_quyenDanhSach.Padding = new Padding(3);
            tp_quyenDanhSach.Size = new Size(730, 660);
            tp_quyenDanhSach.TabIndex = 0;
            tp_quyenDanhSach.Text = "Danh Sách";
            // 
            // dtgrv_quyen
            // 
            dtgrv_quyen.AllowUserToAddRows = false;
            dtgrv_quyen.AllowUserToDeleteRows = false;
            dtgrv_quyen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgrv_quyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrv_quyen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgrv_quyen.BorderStyle = BorderStyle.None;
            dtgrv_quyen.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkCyan;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgrv_quyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgrv_quyen.ColumnHeadersHeight = 30;
            dtgrv_quyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgrv_quyen.DefaultCellStyle = dataGridViewCellStyle2;
            dtgrv_quyen.EnableHeadersVisualStyles = false;
            dtgrv_quyen.GridColor = Color.DarkCyan;
            dtgrv_quyen.ImeMode = ImeMode.NoControl;
            dtgrv_quyen.Location = new Point(3, 180);
            dtgrv_quyen.Margin = new Padding(3, 4, 3, 4);
            dtgrv_quyen.Name = "dtgrv_quyen";
            dtgrv_quyen.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgrv_quyen.RowHeadersVisible = false;
            dtgrv_quyen.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrv_quyen.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtgrv_quyen.RowTemplate.Height = 25;
            dtgrv_quyen.RowTemplate.ReadOnly = true;
            dtgrv_quyen.Size = new Size(724, 477);
            dtgrv_quyen.TabIndex = 15;
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
            delBtn.Location = new Point(586, 4);
            delBtn.Margin = new Padding(3, 4, 3, 4);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(138, 51);
            delBtn.TabIndex = 14;
            delBtn.Text = "  Xóa";
            delBtn.TextColor = Color.Red;
            delBtn.TextHover = Color.White;
            delBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            delBtn.UseVisualStyleBackColor = false;
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
            editBtn.Location = new Point(442, 4);
            editBtn.Margin = new Padding(3, 4, 3, 4);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(138, 51);
            editBtn.TabIndex = 13;
            editBtn.Text = "  Sửa";
            editBtn.TextColor = Color.DarkCyan;
            editBtn.TextHover = Color.White;
            editBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            editBtn.UseVisualStyleBackColor = false;
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
            addBtn.Location = new Point(442, 63);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(138, 51);
            addBtn.TabIndex = 12;
            addBtn.Text = "  Thêm";
            addBtn.TextColor = Color.DarkCyan;
            addBtn.TextHover = Color.White;
            addBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addBtn.UseVisualStyleBackColor = false;
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
            customButton2.Image = Properties.Resources.findIcon16px;
            customButton2.ImageHover = null;
            customButton2.Location = new Point(206, 12);
            customButton2.Margin = new Padding(3, 4, 3, 4);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(40, 37);
            customButton2.TabIndex = 7;
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
            searchTxt.Location = new Point(6, 7);
            searchTxt.Margin = new Padding(3, 4, 3, 4);
            searchTxt.Multiline = false;
            searchTxt.Name = "searchTxt";
            searchTxt.Padding = new Padding(10, 9, 46, 9);
            searchTxt.PasswordChar = false;
            searchTxt.PlaceholderColor = Color.DarkGray;
            searchTxt.PlaceholderText = "Tìm Kiếm ...";
            searchTxt.Size = new Size(249, 47);
            searchTxt.TabIndex = 3;
            searchTxt.Texts = "";
            searchTxt.UnderlinedStyle = false;
            // 
            // tp_quyenChiTiet
            // 
            tp_quyenChiTiet.BackColor = SystemColors.Window;
            tp_quyenChiTiet.Location = new Point(4, 37);
            tp_quyenChiTiet.Name = "tp_quyenChiTiet";
            tp_quyenChiTiet.Padding = new Padding(3);
            tp_quyenChiTiet.Size = new Size(730, 660);
            tp_quyenChiTiet.TabIndex = 1;
            tp_quyenChiTiet.Text = "Chi Tiết";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(grb_chucNang, 0, 0);
            tableLayoutPanel1.Controls.Add(grb_quyen, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1500, 740);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // grb_chucNang
            // 
            grb_chucNang.BackColor = SystemColors.Window;
            grb_chucNang.Controls.Add(tc_chucNang);
            grb_chucNang.Dock = DockStyle.Fill;
            grb_chucNang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grb_chucNang.Location = new Point(753, 3);
            grb_chucNang.Name = "grb_chucNang";
            grb_chucNang.Size = new Size(744, 734);
            grb_chucNang.TabIndex = 1;
            grb_chucNang.TabStop = false;
            grb_chucNang.Text = "Chức Năng";
            // 
            // tc_chucNang
            // 
            tc_chucNang.Controls.Add(tp_chucNangDanhSach);
            tc_chucNang.Controls.Add(tp_chucNangChiTiet);
            tc_chucNang.Dock = DockStyle.Fill;
            tc_chucNang.Location = new Point(3, 30);
            tc_chucNang.Name = "tc_chucNang";
            tc_chucNang.SelectedIndex = 0;
            tc_chucNang.Size = new Size(738, 701);
            tc_chucNang.TabIndex = 0;
            // 
            // tp_chucNangDanhSach
            // 
            tp_chucNangDanhSach.BackColor = SystemColors.Window;
            tp_chucNangDanhSach.Controls.Add(dtgrv_chucNang);
            tp_chucNangDanhSach.Controls.Add(customButton3);
            tp_chucNangDanhSach.Controls.Add(customButton4);
            tp_chucNangDanhSach.Controls.Add(customButton5);
            tp_chucNangDanhSach.Controls.Add(customButton1);
            tp_chucNangDanhSach.Controls.Add(customTextBox1);
            tp_chucNangDanhSach.Location = new Point(4, 37);
            tp_chucNangDanhSach.Name = "tp_chucNangDanhSach";
            tp_chucNangDanhSach.Padding = new Padding(3);
            tp_chucNangDanhSach.Size = new Size(730, 660);
            tp_chucNangDanhSach.TabIndex = 0;
            tp_chucNangDanhSach.Text = "Danh Sách";
            // 
            // dtgrv_chucNang
            // 
            dtgrv_chucNang.AllowUserToAddRows = false;
            dtgrv_chucNang.AllowUserToDeleteRows = false;
            dtgrv_chucNang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgrv_chucNang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrv_chucNang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgrv_chucNang.BorderStyle = BorderStyle.None;
            dtgrv_chucNang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.DarkCyan;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgrv_chucNang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgrv_chucNang.ColumnHeadersHeight = 30;
            dtgrv_chucNang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtgrv_chucNang.DefaultCellStyle = dataGridViewCellStyle5;
            dtgrv_chucNang.EnableHeadersVisualStyles = false;
            dtgrv_chucNang.GridColor = Color.DarkCyan;
            dtgrv_chucNang.ImeMode = ImeMode.NoControl;
            dtgrv_chucNang.Location = new Point(3, 180);
            dtgrv_chucNang.Margin = new Padding(3, 4, 3, 4);
            dtgrv_chucNang.Name = "dtgrv_chucNang";
            dtgrv_chucNang.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgrv_chucNang.RowHeadersVisible = false;
            dtgrv_chucNang.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrv_chucNang.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dtgrv_chucNang.RowTemplate.Height = 25;
            dtgrv_chucNang.RowTemplate.ReadOnly = true;
            dtgrv_chucNang.Size = new Size(724, 477);
            dtgrv_chucNang.TabIndex = 18;
            // 
            // customButton3
            // 
            customButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customButton3.BackColor = SystemColors.Control;
            customButton3.BackgroundColor = SystemColors.Control;
            customButton3.BorderColor = Color.Red;
            customButton3.BorderRadius = 15;
            customButton3.BorderSize = 2;
            customButton3.Cursor = Cursors.Hand;
            customButton3.EnabledTextHover = true;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            customButton3.FlatAppearance.MouseOverBackColor = Color.Red;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton3.ForeColor = Color.Red;
            customButton3.Image = Properties.Resources.deleteIconRed16px;
            customButton3.ImageAlign = ContentAlignment.MiddleRight;
            customButton3.ImageHover = Properties.Resources.deleteIconWhite16px;
            customButton3.Location = new Point(586, 3);
            customButton3.Margin = new Padding(3, 4, 3, 4);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(138, 51);
            customButton3.TabIndex = 17;
            customButton3.Text = "  Xóa";
            customButton3.TextColor = Color.Red;
            customButton3.TextHover = Color.White;
            customButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton4
            // 
            customButton4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customButton4.BackColor = SystemColors.Control;
            customButton4.BackgroundColor = SystemColors.Control;
            customButton4.BorderColor = Color.DarkCyan;
            customButton4.BorderRadius = 15;
            customButton4.BorderSize = 2;
            customButton4.Cursor = Cursors.Hand;
            customButton4.EnabledTextHover = true;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatAppearance.MouseDownBackColor = Color.Teal;
            customButton4.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton4.ForeColor = Color.DarkCyan;
            customButton4.Image = Properties.Resources.editIconTeal16px;
            customButton4.ImageAlign = ContentAlignment.MiddleRight;
            customButton4.ImageHover = Properties.Resources.editIconWhite16px;
            customButton4.Location = new Point(442, 3);
            customButton4.Margin = new Padding(3, 4, 3, 4);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(138, 51);
            customButton4.TabIndex = 16;
            customButton4.Text = "  Sửa";
            customButton4.TextColor = Color.DarkCyan;
            customButton4.TextHover = Color.White;
            customButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton5
            // 
            customButton5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customButton5.BackColor = SystemColors.Control;
            customButton5.BackgroundColor = SystemColors.Control;
            customButton5.BorderColor = Color.DarkCyan;
            customButton5.BorderRadius = 15;
            customButton5.BorderSize = 2;
            customButton5.Cursor = Cursors.Hand;
            customButton5.EnabledTextHover = true;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatAppearance.MouseDownBackColor = Color.Teal;
            customButton5.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton5.ForeColor = Color.DarkCyan;
            customButton5.Image = Properties.Resources.addIconTeal16px;
            customButton5.ImageAlign = ContentAlignment.MiddleRight;
            customButton5.ImageHover = Properties.Resources.addIconWhite16px;
            customButton5.Location = new Point(298, 3);
            customButton5.Margin = new Padding(3, 4, 3, 4);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(138, 51);
            customButton5.TabIndex = 15;
            customButton5.Text = "  Thêm";
            customButton5.TextColor = Color.DarkCyan;
            customButton5.TextHover = Color.White;
            customButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton5.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Transparent;
            customButton1.BackgroundColor = Color.Transparent;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 15;
            customButton1.BorderSize = 0;
            customButton1.Cursor = Cursors.Hand;
            customButton1.EnabledTextHover = false;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 64, 64, 64);
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Image = Properties.Resources.findIcon16px;
            customButton1.ImageHover = null;
            customButton1.Location = new Point(206, 9);
            customButton1.Margin = new Padding(3, 4, 3, 4);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(40, 37);
            customButton1.TabIndex = 9;
            customButton1.TextColor = Color.White;
            customButton1.TextHover = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.BorderColor = Color.Silver;
            customTextBox1.BorderFocusColor = Color.DarkCyan;
            customTextBox1.BorderRadius = 15;
            customTextBox1.BorderSize = 2;
            customTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(6, 4);
            customTextBox1.Margin = new Padding(3, 4, 3, 4);
            customTextBox1.Multiline = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 9, 46, 9);
            customTextBox1.PasswordChar = false;
            customTextBox1.PlaceholderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "Tìm Kiếm ...";
            customTextBox1.Size = new Size(249, 47);
            customTextBox1.TabIndex = 8;
            customTextBox1.Texts = "";
            customTextBox1.UnderlinedStyle = false;
            // 
            // tp_chucNangChiTiet
            // 
            tp_chucNangChiTiet.BackColor = SystemColors.Window;
            tp_chucNangChiTiet.Location = new Point(4, 37);
            tp_chucNangChiTiet.Name = "tp_chucNangChiTiet";
            tp_chucNangChiTiet.Padding = new Padding(3);
            tp_chucNangChiTiet.Size = new Size(730, 660);
            tp_chucNangChiTiet.TabIndex = 1;
            tp_chucNangChiTiet.Text = "Chi Tiết";
            // 
            // button
            // 
            button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button.BackColor = SystemColors.Control;
            button.BackgroundColor = SystemColors.Control;
            button.BorderColor = Color.DarkCyan;
            button.BorderRadius = 15;
            button.BorderSize = 2;
            button.Cursor = Cursors.Hand;
            button.EnabledTextHover = true;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.Teal;
            button.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button.ForeColor = Color.DarkCyan;
            button.Image = Properties.Resources.detailsIcon16px;
            button.ImageAlign = ContentAlignment.MiddleRight;
            button.ImageHover = Properties.Resources.detailsIcon16pxWHITE;
            button.Location = new Point(586, 63);
            button.Margin = new Padding(3, 4, 3, 4);
            button.Name = "button";
            button.Size = new Size(138, 51);
            button.TabIndex = 17;
            button.Text = "  Chi Tiết";
            button.TextColor = Color.DarkCyan;
            button.TextHover = Color.White;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.UseVisualStyleBackColor = false;
            // 
            // PhanQuyenView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 740);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PhanQuyenView";
            Text = "PhanQuyenView";
            grb_quyen.ResumeLayout(false);
            tc_quyen.ResumeLayout(false);
            tp_quyenDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgrv_quyen).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            grb_chucNang.ResumeLayout(false);
            tc_chucNang.ResumeLayout(false);
            tp_chucNangDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgrv_chucNang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_quyen;
        private TabControl tc_quyen;
        private TabPage tp_quyenDanhSach;
        private TabPage tp_quyenChiTiet;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grb_chucNang;
        private TabControl tc_chucNang;
        private TabPage tp_chucNangDanhSach;
        private TabPage tp_chucNangChiTiet;
        private CustomControl.CustomTextBox searchTxt;
        private CustomControl.CustomButton customButton2;
        private CustomControl.CustomButton customButton1;
        private CustomControl.CustomTextBox customTextBox1;
        private CustomControl.CustomButton addBtn;
        private CustomControl.CustomButton editBtn;
        private CustomControl.CustomButton delBtn;
        private CustomControl.CustomButton customButton3;
        private CustomControl.CustomButton customButton4;
        private CustomControl.CustomButton customButton5;
        private DataGridView dtgrv_quyen;
        private DataGridView dtgrv_chucNang;
        private CustomControl.CustomButton button;
    }
}