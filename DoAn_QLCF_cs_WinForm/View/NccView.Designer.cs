namespace DoAn_QLCF_cs_WinForm.View
{
    partial class NccView
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            listTabPage = new TabPage();
            filterBtn = new CustomControl.CustomButton();
            sortBtn = new CustomControl.CustomButton();
            dgvNcc = new DataGridView();
            searchTxt = new CustomControl.CustomTextBox();
            delBtn = new CustomControl.CustomButton();
            editBtn = new CustomControl.CustomButton();
            addBtn = new CustomControl.CustomButton();
            detailTabPage = new TabPage();
            checkboxIsDelete = new CheckBox();
            label8 = new Label();
            HuyBtn = new CustomControl.CustomButton();
            xacNhanBtn = new CustomControl.CustomButton();
            customTextBox4 = new CustomControl.CustomTextBox();
            label3 = new Label();
            customTextBox1 = new CustomControl.CustomTextBox();
            M = new Label();
            label7 = new Label();
            btn_back = new CustomControl.CustomButton();
            idTxt = new CustomControl.CustomTextBox();
            customTextBox3 = new CustomControl.CustomTextBox();
            customTextBox2 = new CustomControl.CustomTextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            tcNCC.SuspendLayout();
            listTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            detailTabPage.SuspendLayout();
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
            tabControl1.Size = new Size(1212, 693);
            tabControl1.TabIndex = 0;
            // 
            // listTabPage
            // 
            listTabPage.Controls.Add(groupBox1);
            listTabPage.Controls.Add(filterBtn);
            listTabPage.Controls.Add(sortBtn);
            listTabPage.Controls.Add(dgvNcc);
            listTabPage.Controls.Add(searchTxt);
            listTabPage.Controls.Add(delBtn);
            listTabPage.Controls.Add(editBtn);
            listTabPage.Controls.Add(addBtn);
            listTabPage.Location = new Point(4, 29);
            listTabPage.Name = "listTabPage";
            listTabPage.Padding = new Padding(3);
            listTabPage.Size = new Size(1204, 660);
            listTabPage.TabIndex = 0;
            listTabPage.Text = "Danh Sách";
            listTabPage.UseVisualStyleBackColor = true;
            // 
            // filterBtn
            // 
            filterBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterBtn.BackColor = SystemColors.Control;
            filterBtn.BackgroundColor = SystemColors.Control;
            filterBtn.BorderColor = Color.Goldenrod;
            filterBtn.BorderRadius = 15;
            filterBtn.BorderSize = 2;
            filterBtn.Cursor = Cursors.Hand;
            filterBtn.EnabledTextHover = true;
            filterBtn.FlatAppearance.BorderSize = 0;
            filterBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            filterBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            filterBtn.FlatStyle = FlatStyle.Flat;
            filterBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            filterBtn.ForeColor = Color.Goldenrod;
            filterBtn.ImageAlign = ContentAlignment.MiddleRight;
            filterBtn.ImageHover = null;
            filterBtn.Location = new Point(545, 12);
            filterBtn.Margin = new Padding(4, 5, 4, 5);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(172, 64);
            filterBtn.TabIndex = 22;
            filterBtn.Text = "Lọc";
            filterBtn.TextColor = Color.Goldenrod;
            filterBtn.TextHover = Color.White;
            filterBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            filterBtn.UseVisualStyleBackColor = false;
            filterBtn.Click += filterBtn_Click;
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
            sortBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            sortBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            sortBtn.FlatStyle = FlatStyle.Flat;
            sortBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sortBtn.ForeColor = Color.DeepSkyBlue;
            sortBtn.ImageAlign = ContentAlignment.MiddleRight;
            sortBtn.ImageHover = null;
            sortBtn.Location = new Point(744, 9);
            sortBtn.Margin = new Padding(4, 5, 4, 5);
            sortBtn.Name = "sortBtn";
            sortBtn.Size = new Size(172, 64);
            sortBtn.TabIndex = 21;
            sortBtn.Text = "Sắp xếp";
            sortBtn.TextColor = Color.DeepSkyBlue;
            sortBtn.TextHover = Color.White;
            sortBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            sortBtn.UseVisualStyleBackColor = false;
            sortBtn.Click += sortBtn_Click;
            // 
            // dgvNcc
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.DarkCyan;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.DarkCyan;
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(3, 180);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.Size = new Size(1198, 477);
            dataGridView1.TabIndex = 20;
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
            searchTxt.Location = new Point(6, 10);
            searchTxt.Margin = new Padding(3, 4, 3, 4);
            searchTxt.Multiline = false;
            searchTxt.Name = "searchTxt";
            searchTxt.Padding = new Padding(10, 9, 46, 9);
            searchTxt.PasswordChar = false;
            searchTxt.PlaceholderColor = Color.DarkGray;
            searchTxt.PlaceholderText = "Tìm Kiếm ...";
            searchTxt.Size = new Size(304, 47);
            searchTxt.TabIndex = 19;
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
            delBtn.Location = new Point(1052, 7);
            delBtn.Margin = new Padding(3, 4, 3, 4);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(138, 51);
            delBtn.TabIndex = 13;
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
            editBtn.Location = new Point(907, 7);
            editBtn.Margin = new Padding(3, 4, 3, 4);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(138, 51);
            editBtn.TabIndex = 12;
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
            addBtn.Location = new Point(761, 7);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(138, 51);
            addBtn.TabIndex = 11;
            addBtn.Text = "  Thêm";
            addBtn.TextColor = Color.DarkCyan;
            addBtn.TextHover = Color.White;
            addBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // detailTabPage
            // 
            detailTabPage.Controls.Add(comboBox5);
            detailTabPage.Controls.Add(label8);
            detailTabPage.Controls.Add(HuyBtn);
            detailTabPage.Controls.Add(xacNhanBtn);
            detailTabPage.Controls.Add(customTextBox4);
            detailTabPage.Controls.Add(label3);
            detailTabPage.Controls.Add(customTextBox1);
            detailTabPage.Controls.Add(M);
            detailTabPage.Controls.Add(label7);
            detailTabPage.Controls.Add(btn_back);
            detailTabPage.Controls.Add(idTxt);
            detailTabPage.Controls.Add(customTextBox3);
            detailTabPage.Controls.Add(customTextBox2);
            detailTabPage.Controls.Add(label5);
            detailTabPage.Controls.Add(label4);
            detailTabPage.Controls.Add(label1);
            detailTabPage.Location = new Point(4, 29);
            detailTabPage.Name = "detailTabPage";
            detailTabPage.Padding = new Padding(3);
            detailTabPage.Size = new Size(1204, 660);
            detailTabPage.TabIndex = 1;
            detailTabPage.Text = "Chi Tiết";
            detailTabPage.UseVisualStyleBackColor = true;
            // 
            // checkboxIsDelete
            // 
            checkboxIsDelete.AutoSize = true;
            checkboxIsDelete.Location = new Point(1047, 304);
            checkboxIsDelete.Name = "checkboxIsDelete";
            checkboxIsDelete.Size = new Size(22, 21);
            checkboxIsDelete.TabIndex = 57;
            checkboxIsDelete.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(914, 273);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 85);
            label8.TabIndex = 56;
            label8.Text = "IsDelete";
            label8.TextAlign = ContentAlignment.MiddleCenter;
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
            HuyBtn.Location = new Point(1024, 551);
            HuyBtn.Margin = new Padding(3, 4, 3, 4);
            HuyBtn.Name = "HuyBtn";
            HuyBtn.Size = new Size(157, 71);
            HuyBtn.TabIndex = 42;
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
            xacNhanBtn.Location = new Point(849, 551);
            xacNhanBtn.Margin = new Padding(3, 4, 3, 4);
            xacNhanBtn.Name = "xacNhanBtn";
            xacNhanBtn.Size = new Size(157, 71);
            xacNhanBtn.TabIndex = 41;
            xacNhanBtn.Text = "  Xác Nhận";
            xacNhanBtn.TextColor = Color.DarkCyan;
            xacNhanBtn.TextHover = Color.White;
            xacNhanBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            xacNhanBtn.UseVisualStyleBackColor = false;
            // 
            // customTextBox4
            // 
            txtSDTNcc.BackColor = SystemColors.Window;
            txtSDTNcc.BorderColor = Color.Silver;
            txtSDTNcc.BorderFocusColor = Color.DeepSkyBlue;
            txtSDTNcc.BorderRadius = 13;
            txtSDTNcc.BorderSize = 2;
            txtSDTNcc.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDTNcc.ForeColor = Color.DimGray;
            txtSDTNcc.Location = new Point(894, 149);
            txtSDTNcc.Margin = new Padding(4, 5, 4, 5);
            txtSDTNcc.Multiline = false;
            txtSDTNcc.Name = "txtSDTNcc";
            txtSDTNcc.Padding = new Padding(12, 15, 10, 11);
            txtSDTNcc.PasswordChar = false;
            txtSDTNcc.PlaceholderColor = Color.DarkGray;
            txtSDTNcc.PlaceholderText = "Nhập số điện thoại";
            txtSDTNcc.Size = new Size(349, 63);
            txtSDTNcc.TabIndex = 36;
            txtSDTNcc.Texts = "";
            txtSDTNcc.UnderlinedStyle = false;
            txtSDTNcc._TextChanged += txtSDTNcc__TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(712, 65);
            label3.Name = "label3";
            label3.Size = new Size(151, 68);
            label3.TabIndex = 35;
            label3.Text = "Số Điện Thoại";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customTextBox1
            // 
            txtDiaChiNcc.BackColor = SystemColors.Window;
            txtDiaChiNcc.BorderColor = Color.Silver;
            txtDiaChiNcc.BorderFocusColor = Color.DeepSkyBlue;
            txtDiaChiNcc.BorderRadius = 13;
            txtDiaChiNcc.BorderSize = 2;
            txtDiaChiNcc.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChiNcc.ForeColor = Color.DimGray;
            txtDiaChiNcc.Location = new Point(502, 149);
            txtDiaChiNcc.Margin = new Padding(4, 5, 4, 5);
            txtDiaChiNcc.Multiline = false;
            txtDiaChiNcc.Name = "txtDiaChiNcc";
            txtDiaChiNcc.Padding = new Padding(12, 15, 10, 11);
            txtDiaChiNcc.PasswordChar = false;
            txtDiaChiNcc.PlaceholderColor = Color.DarkGray;
            txtDiaChiNcc.PlaceholderText = "Nhập địa chỉ";
            txtDiaChiNcc.Size = new Size(349, 63);
            txtDiaChiNcc.TabIndex = 34;
            txtDiaChiNcc.Texts = "";
            txtDiaChiNcc.UnderlinedStyle = false;
            txtDiaChiNcc._TextChanged += txtDiaChiNcc__TextChanged;
            // 
            // M
            // 
            M.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            M.Location = new Point(382, 67);
            M.Name = "M";
            M.Size = new Size(121, 68);
            M.TabIndex = 33;
            M.Text = "Địa Chỉ";
            M.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(112, 16);
            label7.Name = "label7";
            label7.Size = new Size(311, 57);
            label7.TabIndex = 32;
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
            btn_back.Location = new Point(22, 20);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(72, 55);
            btn_back.TabIndex = 31;
            btn_back.TextColor = Color.White;
            btn_back.TextHover = Color.White;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // idTxt
            // 
            txtIdNcc.BackColor = Color.LightGray;
            txtIdNcc.BorderColor = Color.Silver;
            txtIdNcc.BorderFocusColor = Color.DarkCyan;
            txtIdNcc.BorderRadius = 13;
            txtIdNcc.BorderSize = 2;
            txtIdNcc.Enabled = false;
            txtIdNcc.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdNcc.ForeColor = Color.DimGray;
            txtIdNcc.Location = new Point(78, 149);
            txtIdNcc.Margin = new Padding(4, 5, 4, 5);
            txtIdNcc.Multiline = false;
            txtIdNcc.Name = "txtIdNcc";
            txtIdNcc.Padding = new Padding(12, 15, 10, 11);
            txtIdNcc.PasswordChar = false;
            txtIdNcc.PlaceholderColor = Color.DarkGray;
            txtIdNcc.PlaceholderText = "Nhập ID";
            txtIdNcc.Size = new Size(349, 63);
            txtIdNcc.TabIndex = 30;
            txtIdNcc.Texts = "";
            txtIdNcc.UnderlinedStyle = false;
            // 
            // customTextBox3
            // 
            txtEmailNcc.BackColor = SystemColors.Window;
            txtEmailNcc.BorderColor = Color.Silver;
            txtEmailNcc.BorderFocusColor = Color.DeepSkyBlue;
            txtEmailNcc.BorderRadius = 13;
            txtEmailNcc.BorderSize = 2;
            txtEmailNcc.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailNcc.ForeColor = Color.DimGray;
            txtEmailNcc.Location = new Point(502, 286);
            txtEmailNcc.Margin = new Padding(4, 5, 4, 5);
            txtEmailNcc.Multiline = false;
            txtEmailNcc.Name = "txtEmailNcc";
            txtEmailNcc.Padding = new Padding(12, 15, 10, 11);
            txtEmailNcc.PasswordChar = false;
            txtEmailNcc.PlaceholderColor = Color.DarkGray;
            txtEmailNcc.PlaceholderText = "Nhập email";
            txtEmailNcc.Size = new Size(349, 63);
            txtEmailNcc.TabIndex = 29;
            txtEmailNcc.Texts = "";
            txtEmailNcc.UnderlinedStyle = false;
            txtEmailNcc._TextChanged += txtEmailNcc__TextChanged;
            // 
            // customTextBox2
            // 
            txtTenNcc.BackColor = SystemColors.Window;
            txtTenNcc.BorderColor = Color.Silver;
            txtTenNcc.BorderFocusColor = Color.DeepSkyBlue;
            txtTenNcc.BorderRadius = 13;
            txtTenNcc.BorderSize = 2;
            txtTenNcc.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNcc.ForeColor = Color.DimGray;
            txtTenNcc.Location = new Point(78, 286);
            txtTenNcc.Margin = new Padding(4, 5, 4, 5);
            txtTenNcc.Multiline = false;
            txtTenNcc.Name = "txtTenNcc";
            txtTenNcc.Padding = new Padding(12, 15, 10, 11);
            txtTenNcc.PasswordChar = false;
            txtTenNcc.PlaceholderColor = Color.DarkGray;
            txtTenNcc.PlaceholderText = "Nhập tên nhà cung cấp";
            txtTenNcc.Size = new Size(349, 63);
            txtTenNcc.TabIndex = 28;
            txtTenNcc.Texts = "";
            txtTenNcc.UnderlinedStyle = false;
            txtTenNcc._TextChanged += txtTenNcc__TextChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(40, 176);
            label5.Name = "label5";
            label5.Size = new Size(90, 68);
            label5.TabIndex = 27;
            label5.Text = "Tên";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(478, 220);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 68);
            label4.TabIndex = 26;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 68);
            label1.Name = "label1";
            label1.Size = new Size(90, 68);
            label1.TabIndex = 25;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(53, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(140, 108);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "ID";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(74, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tăng";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(17, 65);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Giảm";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // NccView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 693);
            Controls.Add(tabControl1);
            Name = "NccView";
            Text = "NccView";
            tabControl1.ResumeLayout(false);
            listTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            detailTabPage.ResumeLayout(false);
            detailTabPage.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage listTabPage;
        private TabPage detailTabPage;
        private CustomControl.CustomButton delBtn;
        private CustomControl.CustomButton editBtn;
        private CustomControl.CustomButton addBtn;
        private CustomControl.CustomTextBox searchTxt;
        private DataGridView dataGridView1;
        private CustomControl.CustomTextBox customTextBox4;
        private Label label3;
        private CustomControl.CustomTextBox customTextBox1;
        private Label M;
        private Label label7;
        private CustomControl.CustomButton btn_back;
        private CustomControl.CustomTextBox idTxt;
        private CustomControl.CustomTextBox customTextBox3;
        private CustomControl.CustomTextBox customTextBox2;
        private Label label5;
        private Label label4;
        private Label label1;
        private CustomControl.CustomButton HuyBtn;
        private CustomControl.CustomButton xacNhanBtn;
        private ComboBox comboBox5;
        private Label label8;
        private CheckBox checkboxIsDelete;
        private CustomControl.CustomButton filterBtn;
        private CustomControl.CustomButton sortBtn;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}