namespace DoAn_QLCF_cs_WinForm.View
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            dataGridView1 = new DataGridView();
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
            customTextBox4 = new CustomControl.CustomTextBox();
            M = new Label();
            customTextBox1 = new CustomControl.CustomTextBox();
            customTextBox6 = new CustomControl.CustomTextBox();
            label10 = new Label();
            label13 = new Label();
            comboBox3 = new ComboBox();
            comboBox5 = new ComboBox();
            label8 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            customTextBox5 = new CustomControl.CustomTextBox();
            customTextBox3 = new CustomControl.CustomTextBox();
            idTxt = new CustomControl.CustomTextBox();
            label1 = new Label();
            label12 = new Label();
            dateTimePicker1 = new DateTimePicker();
            customTextBox2 = new CustomControl.CustomTextBox();
            label5 = new Label();
            comboBox4 = new ComboBox();
            label11 = new Label();
            label4 = new Label();
            label6 = new Label();
            HuyBtn = new CustomControl.CustomButton();
            xacNhanBtn = new CustomControl.CustomButton();
            label7 = new Label();
            btn_back = new CustomControl.CustomButton();
            tabControl1.SuspendLayout();
            listTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1076, 555);
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
            listTabPage.Controls.Add(dataGridView1);
            listTabPage.Location = new Point(4, 24);
            listTabPage.Margin = new Padding(3, 2, 3, 2);
            listTabPage.Name = "listTabPage";
            listTabPage.Padding = new Padding(3, 2, 3, 2);
            listTabPage.Size = new Size(1068, 527);
            listTabPage.TabIndex = 0;
            listTabPage.Text = "Danh Sach";
            listTabPage.UseVisualStyleBackColor = true;
            listTabPage.Click += listTabPage_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(296, 11);
            label9.Name = "label9";
            label9.Size = new Size(40, 31);
            label9.TabIndex = 31;
            label9.Text = "Lọc:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(471, 12);
            label2.Name = "label2";
            label2.Size = new Size(73, 31);
            label2.TabIndex = 30;
            label2.Text = "Sắp xếp:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(341, 14);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(125, 31);
            comboBox2.TabIndex = 29;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(549, 14);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 31);
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
            customButton2.Location = new Point(243, 11);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(35, 28);
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
            searchTxt.Location = new Point(18, 8);
            searchTxt.Multiline = false;
            searchTxt.Name = "searchTxt";
            searchTxt.Padding = new Padding(9, 7, 40, 7);
            searchTxt.PasswordChar = false;
            searchTxt.PlaceholderColor = Color.DarkGray;
            searchTxt.PlaceholderText = "Tìm Kiếm ...";
            searchTxt.Size = new Size(266, 36);
            searchTxt.TabIndex = 26;
            searchTxt.Texts = "";
            searchTxt.UnderlinedStyle = false;
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
            delBtn.Location = new Point(942, 9);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(121, 38);
            delBtn.TabIndex = 25;
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
            editBtn.Location = new Point(815, 9);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(121, 38);
            editBtn.TabIndex = 24;
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
            addBtn.Location = new Point(687, 9);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(121, 38);
            addBtn.TabIndex = 23;
            addBtn.Text = "  Thêm";
            addBtn.TextColor = Color.DarkCyan;
            addBtn.TextHover = Color.White;
            addBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkCyan;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.DarkCyan;
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(3, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.Size = new Size(1062, 374);
            dataGridView1.TabIndex = 22;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Visible = false;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số điện thoại";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Visible = false;
            // 
            // Column5
            // 
            Column5.HeaderText = "Giới tính";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Visible = false;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ngày sinh";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Visible = false;
            // 
            // Column7
            // 
            Column7.HeaderText = "Tài khoản";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Visible = false;
            // 
            // Column8
            // 
            Column8.HeaderText = "Mật khẩu";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Visible = false;
            // 
            // Column9
            // 
            Column9.HeaderText = "Chức vụ";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Visible = false;
            // 
            // Column10
            // 
            Column10.HeaderText = "Trạng thái";
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
            detailTabPage.Location = new Point(4, 24);
            detailTabPage.Margin = new Padding(3, 2, 3, 2);
            detailTabPage.Name = "detailTabPage";
            detailTabPage.Padding = new Padding(3, 2, 3, 2);
            detailTabPage.Size = new Size(1068, 527);
            detailTabPage.TabIndex = 1;
            detailTabPage.Text = "Chi Tiết";
            detailTabPage.UseVisualStyleBackColor = true;
            detailTabPage.Click += detailTabPage_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(customTextBox4);
            groupBox2.Controls.Add(M);
            groupBox2.Controls.Add(customTextBox1);
            groupBox2.Controls.Add(customTextBox6);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(comboBox5);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(543, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(517, 345);
            groupBox2.TabIndex = 59;
            groupBox2.TabStop = false;
            groupBox2.Text = "tài khoản nhân viên";
            // 
            // customTextBox4
            // 
            customTextBox4.BackColor = SystemColors.Window;
            customTextBox4.BorderColor = Color.Silver;
            customTextBox4.BorderFocusColor = Color.DarkCyan;
            customTextBox4.BorderRadius = 13;
            customTextBox4.BorderSize = 2;
            customTextBox4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox4.ForeColor = Color.DimGray;
            customTextBox4.Location = new Point(18, 165);
            customTextBox4.Multiline = false;
            customTextBox4.Name = "customTextBox4";
            customTextBox4.Padding = new Padding(9, 9, 7, 7);
            customTextBox4.PasswordChar = false;
            customTextBox4.PlaceholderColor = Color.DarkGray;
            customTextBox4.PlaceholderText = "Nhập mật khẩu...";
            customTextBox4.Size = new Size(244, 42);
            customTextBox4.TabIndex = 58;
            customTextBox4.Texts = "";
            customTextBox4.UnderlinedStyle = false;
            // 
            // M
            // 
            M.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            M.Location = new Point(18, 28);
            M.Name = "M";
            M.Size = new Size(106, 51);
            M.TabIndex = 31;
            M.Text = "Tài Khoản";
            M.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.BorderColor = Color.Silver;
            customTextBox1.BorderFocusColor = Color.DarkCyan;
            customTextBox1.BorderRadius = 13;
            customTextBox1.BorderSize = 2;
            customTextBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(18, 82);
            customTextBox1.Multiline = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(9, 9, 7, 7);
            customTextBox1.PasswordChar = false;
            customTextBox1.PlaceholderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "Nhập tài khoản...";
            customTextBox1.Size = new Size(244, 42);
            customTextBox1.TabIndex = 32;
            customTextBox1.Texts = "";
            customTextBox1.UnderlinedStyle = false;
            // 
            // customTextBox6
            // 
            customTextBox6.BackColor = SystemColors.Window;
            customTextBox6.BorderColor = Color.Silver;
            customTextBox6.BorderFocusColor = Color.DarkCyan;
            customTextBox6.BorderRadius = 13;
            customTextBox6.BorderSize = 2;
            customTextBox6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox6.ForeColor = Color.DimGray;
            customTextBox6.Location = new Point(18, 249);
            customTextBox6.Multiline = false;
            customTextBox6.Name = "customTextBox6";
            customTextBox6.Padding = new Padding(9, 9, 7, 7);
            customTextBox6.PasswordChar = false;
            customTextBox6.PlaceholderColor = Color.DarkGray;
            customTextBox6.PlaceholderText = "Nhập mật khẩu...";
            customTextBox6.Size = new Size(244, 42);
            customTextBox6.TabIndex = 57;
            customTextBox6.Texts = "";
            customTextBox6.UnderlinedStyle = false;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(272, 28);
            label10.Name = "label10";
            label10.Size = new Size(79, 51);
            label10.TabIndex = 47;
            label10.Text = "Quyền";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(18, 210);
            label13.Name = "label13";
            label13.Size = new Size(151, 51);
            label13.TabIndex = 56;
            label13.Text = "Nhập Lại Mật Khẩu";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(272, 81);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(245, 38);
            comboBox3.TabIndex = 49;
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Dừng hoạt dộng", "Đang hoạt động" });
            comboBox5.Location = new Point(272, 169);
            comboBox5.Margin = new Padding(3, 2, 3, 2);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(245, 38);
            comboBox5.TabIndex = 55;
            comboBox5.Text = "False";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(272, 126);
            label8.Name = "label8";
            label8.Size = new Size(79, 51);
            label8.TabIndex = 54;
            label8.Text = "Trạng thái";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 126);
            label3.Name = "label3";
            label3.Size = new Size(151, 51);
            label3.TabIndex = 33;
            label3.Text = "Mật Khẩu";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(customTextBox5);
            groupBox1.Controls.Add(customTextBox3);
            groupBox1.Controls.Add(idTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(customTextBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(8, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 345);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "thông tin nhân viên";
            // 
            // customTextBox5
            // 
            customTextBox5.BackColor = SystemColors.Window;
            customTextBox5.BorderColor = Color.Silver;
            customTextBox5.BorderFocusColor = Color.DarkCyan;
            customTextBox5.BorderRadius = 13;
            customTextBox5.BorderSize = 2;
            customTextBox5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox5.ForeColor = Color.DimGray;
            customTextBox5.Location = new Point(7, 269);
            customTextBox5.Multiline = false;
            customTextBox5.Name = "customTextBox5";
            customTextBox5.Padding = new Padding(9, 9, 7, 7);
            customTextBox5.PasswordChar = false;
            customTextBox5.PlaceholderColor = Color.DarkGray;
            customTextBox5.PlaceholderText = "Nhập email...";
            customTextBox5.Size = new Size(244, 42);
            customTextBox5.TabIndex = 53;
            customTextBox5.Texts = "";
            customTextBox5.UnderlinedStyle = false;
            // 
            // customTextBox3
            // 
            customTextBox3.BackColor = SystemColors.Window;
            customTextBox3.BorderColor = Color.Silver;
            customTextBox3.BorderFocusColor = Color.DarkCyan;
            customTextBox3.BorderRadius = 13;
            customTextBox3.BorderSize = 2;
            customTextBox3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox3.ForeColor = Color.DimGray;
            customTextBox3.Location = new Point(279, 169);
            customTextBox3.Multiline = false;
            customTextBox3.Name = "customTextBox3";
            customTextBox3.Padding = new Padding(9, 9, 7, 7);
            customTextBox3.PasswordChar = false;
            customTextBox3.PlaceholderColor = Color.DarkGray;
            customTextBox3.PlaceholderText = "Nhập số điện thoại...";
            customTextBox3.Size = new Size(244, 42);
            customTextBox3.TabIndex = 52;
            customTextBox3.Texts = "";
            customTextBox3.UnderlinedStyle = false;
            // 
            // idTxt
            // 
            idTxt.BackColor = SystemColors.Window;
            idTxt.BorderColor = Color.Silver;
            idTxt.BorderFocusColor = Color.DarkCyan;
            idTxt.BorderRadius = 13;
            idTxt.BorderSize = 2;
            idTxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            idTxt.ForeColor = Color.DimGray;
            idTxt.Location = new Point(6, 57);
            idTxt.Multiline = false;
            idTxt.Name = "idTxt";
            idTxt.Padding = new Padding(9, 9, 7, 7);
            idTxt.PasswordChar = false;
            idTxt.PlaceholderColor = Color.DarkGray;
            idTxt.PlaceholderText = "Nhập ID....";
            idTxt.Size = new Size(244, 42);
            idTxt.TabIndex = 30;
            idTxt.Texts = "";
            idTxt.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-9, 19);
            label1.Name = "label1";
            label1.Size = new Size(79, 51);
            label1.TabIndex = 25;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(279, 236);
            label12.Name = "label12";
            label12.Size = new Size(90, 34);
            label12.TabIndex = 53;
            label12.Text = "Ngày Sinh";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(279, 272);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.MaxDate = new DateTime(2025, 7, 5, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 33);
            dateTimePicker1.TabIndex = 52;
            dateTimePicker1.Value = new DateTime(2023, 11, 10, 0, 0, 0, 0);
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = SystemColors.Window;
            customTextBox2.BorderColor = Color.Silver;
            customTextBox2.BorderFocusColor = Color.DarkCyan;
            customTextBox2.BorderRadius = 13;
            customTextBox2.BorderSize = 2;
            customTextBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox2.ForeColor = Color.DimGray;
            customTextBox2.Location = new Point(279, 57);
            customTextBox2.Multiline = false;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(9, 9, 7, 7);
            customTextBox2.PasswordChar = false;
            customTextBox2.PlaceholderColor = Color.DarkGray;
            customTextBox2.PlaceholderText = "Nhập tên nhân viên...";
            customTextBox2.Size = new Size(244, 42);
            customTextBox2.TabIndex = 28;
            customTextBox2.Texts = "";
            customTextBox2.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(279, 19);
            label5.Name = "label5";
            label5.Size = new Size(79, 51);
            label5.TabIndex = 27;
            label5.Text = "Họ Tên";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox4.Location = new Point(6, 169);
            comboBox4.Margin = new Padding(3, 2, 3, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(245, 38);
            comboBox4.TabIndex = 51;
            comboBox4.Text = "Nữ";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 126);
            label11.Name = "label11";
            label11.Size = new Size(79, 51);
            label11.TabIndex = 50;
            label11.Text = "Giới Tính";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(267, 126);
            label4.Name = "label4";
            label4.Size = new Size(131, 51);
            label4.TabIndex = 26;
            label4.Text = "Số Điện Thoại";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(-16, 228);
            label6.Name = "label6";
            label6.Size = new Size(106, 51);
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
            HuyBtn.Location = new Point(561, 443);
            HuyBtn.Name = "HuyBtn";
            HuyBtn.Size = new Size(137, 53);
            HuyBtn.TabIndex = 46;
            HuyBtn.Text = "  Hủy";
            HuyBtn.TextColor = Color.Red;
            HuyBtn.TextHover = Color.White;
            HuyBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            HuyBtn.UseVisualStyleBackColor = false;
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
            xacNhanBtn.Location = new Point(382, 443);
            xacNhanBtn.Name = "xacNhanBtn";
            xacNhanBtn.Size = new Size(137, 53);
            xacNhanBtn.TabIndex = 45;
            xacNhanBtn.Text = "  Xác Nhận";
            xacNhanBtn.TextColor = Color.DarkCyan;
            xacNhanBtn.TextHover = Color.White;
            xacNhanBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            xacNhanBtn.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(382, 19);
            label7.Name = "label7";
            label7.Size = new Size(294, 43);
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
            btn_back.Location = new Point(8, 5);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(63, 41);
            btn_back.TabIndex = 39;
            btn_back.TextColor = Color.White;
            btn_back.TextHover = Color.White;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // NhanVienView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 555);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhanVienView";
            Text = "NhanVienView";
            tabControl1.ResumeLayout(false);
            listTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            detailTabPage.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage listTabPage;
        private DataGridView dataGridView1;
        private TabPage detailTabPage;
        private Label label7;
        private CustomControl.CustomButton btn_back;
        private Label label6;
        private Label label3;
        private CustomControl.CustomTextBox customTextBox1;
        private Label M;
        private CustomControl.CustomTextBox idTxt;
        private CustomControl.CustomTextBox customTextBox2;
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
        private ComboBox comboBox3;
        private Label label10;
        private ComboBox comboBox4;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private Label label12;
        private ComboBox comboBox5;
        private Label label8;
        private CustomControl.CustomTextBox customTextBox6;
        private Label label13;
        private GroupBox groupBox1;
        private Label label4;
        private CustomControl.CustomTextBox customTextBox5;
        private CustomControl.CustomTextBox customTextBox3;
        private GroupBox groupBox2;
        private CustomControl.CustomTextBox customTextBox4;
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
    }
}