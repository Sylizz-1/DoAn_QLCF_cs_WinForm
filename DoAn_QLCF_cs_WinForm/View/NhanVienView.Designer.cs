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
            detailTabPage = new TabPage();
            comboBox5 = new ComboBox();
            label8 = new Label();
            label12 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox4 = new ComboBox();
            label11 = new Label();
            comboBox3 = new ComboBox();
            label10 = new Label();
            HuyBtn = new CustomControl.CustomButton();
            xacNhanBtn = new CustomControl.CustomButton();
            label7 = new Label();
            btn_back = new CustomControl.CustomButton();
            customTextBox5 = new CustomControl.CustomTextBox();
            label6 = new Label();
            customTextBox4 = new CustomControl.CustomTextBox();
            label3 = new Label();
            customTextBox1 = new CustomControl.CustomTextBox();
            M = new Label();
            idTxt = new CustomControl.CustomTextBox();
            customTextBox3 = new CustomControl.CustomTextBox();
            customTextBox2 = new CustomControl.CustomTextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            listTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            detailTabPage.SuspendLayout();
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
            listTabPage.Controls.Add(dataGridView1);
            listTabPage.Location = new Point(4, 29);
            listTabPage.Name = "listTabPage";
            listTabPage.Padding = new Padding(3);
            listTabPage.Size = new Size(1222, 707);
            listTabPage.TabIndex = 0;
            listTabPage.Text = "Danh Sach";
            listTabPage.UseVisualStyleBackColor = true;
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
            searchTxt.Location = new Point(20, 10);
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
            delBtn.Location = new Point(1076, 12);
            delBtn.Margin = new Padding(3, 4, 3, 4);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(138, 51);
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
            dataGridView1.Location = new Point(3, 227);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.Size = new Size(1216, 477);
            dataGridView1.TabIndex = 22;
            // 
            // detailTabPage
            // 
            detailTabPage.Controls.Add(comboBox5);
            detailTabPage.Controls.Add(label8);
            detailTabPage.Controls.Add(label12);
            detailTabPage.Controls.Add(dateTimePicker1);
            detailTabPage.Controls.Add(comboBox4);
            detailTabPage.Controls.Add(label11);
            detailTabPage.Controls.Add(comboBox3);
            detailTabPage.Controls.Add(label10);
            detailTabPage.Controls.Add(HuyBtn);
            detailTabPage.Controls.Add(xacNhanBtn);
            detailTabPage.Controls.Add(label7);
            detailTabPage.Controls.Add(btn_back);
            detailTabPage.Controls.Add(customTextBox5);
            detailTabPage.Controls.Add(label6);
            detailTabPage.Controls.Add(customTextBox4);
            detailTabPage.Controls.Add(label3);
            detailTabPage.Controls.Add(customTextBox1);
            detailTabPage.Controls.Add(M);
            detailTabPage.Controls.Add(idTxt);
            detailTabPage.Controls.Add(customTextBox3);
            detailTabPage.Controls.Add(customTextBox2);
            detailTabPage.Controls.Add(label5);
            detailTabPage.Controls.Add(label4);
            detailTabPage.Controls.Add(label1);
            detailTabPage.Location = new Point(4, 29);
            detailTabPage.Name = "detailTabPage";
            detailTabPage.Padding = new Padding(3);
            detailTabPage.Size = new Size(1222, 707);
            detailTabPage.TabIndex = 1;
            detailTabPage.Text = "Chi Tiết";
            detailTabPage.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "True", "False" });
            comboBox5.Location = new Point(70, 469);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(279, 38);
            comboBox5.TabIndex = 55;
            comboBox5.Text = "False";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(53, 408);
            label8.Name = "label8";
            label8.Size = new Size(90, 68);
            label8.TabIndex = 54;
            label8.Text = "IsDelete";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(720, 306);
            label12.Name = "label12";
            label12.Size = new Size(103, 46);
            label12.TabIndex = 53;
            label12.Text = "Ngày Sinh";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(723, 358);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(368, 36);
            dateTimePicker1.TabIndex = 52;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox4.Location = new Point(410, 356);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(279, 38);
            comboBox4.TabIndex = 51;
            comboBox4.Text = "Nữ";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(393, 295);
            label11.Name = "label11";
            label11.Size = new Size(90, 68);
            label11.TabIndex = 50;
            label11.Text = "Giới Tính";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(70, 356);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(279, 38);
            comboBox3.TabIndex = 49;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(53, 295);
            label10.Name = "label10";
            label10.Size = new Size(90, 68);
            label10.TabIndex = 47;
            label10.Text = "Quyền";
            label10.TextAlign = ContentAlignment.MiddleCenter;
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
            HuyBtn.Location = new Point(1020, 617);
            HuyBtn.Margin = new Padding(3, 4, 3, 4);
            HuyBtn.Name = "HuyBtn";
            HuyBtn.Size = new Size(157, 71);
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
            xacNhanBtn.Location = new Point(845, 617);
            xacNhanBtn.Margin = new Padding(3, 4, 3, 4);
            xacNhanBtn.Name = "xacNhanBtn";
            xacNhanBtn.Size = new Size(157, 71);
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
            label7.Location = new Point(99, 3);
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
            // customTextBox5
            // 
            customTextBox5.BackColor = SystemColors.Window;
            customTextBox5.BorderColor = Color.Silver;
            customTextBox5.BorderFocusColor = Color.DarkCyan;
            customTextBox5.BorderRadius = 13;
            customTextBox5.BorderSize = 2;
            customTextBox5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox5.ForeColor = Color.DimGray;
            customTextBox5.Location = new Point(410, 239);
            customTextBox5.Margin = new Padding(3, 4, 3, 4);
            customTextBox5.Multiline = false;
            customTextBox5.Name = "customTextBox5";
            customTextBox5.Padding = new Padding(10, 12, 8, 9);
            customTextBox5.PasswordChar = false;
            customTextBox5.PlaceholderColor = Color.DarkGray;
            customTextBox5.PlaceholderText = "Nhập emai...";
            customTextBox5.Size = new Size(279, 52);
            customTextBox5.TabIndex = 36;
            customTextBox5.Texts = "";
            customTextBox5.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(390, 187);
            label6.Name = "label6";
            label6.Size = new Size(121, 68);
            label6.TabIndex = 35;
            label6.Text = "Email";
            label6.TextAlign = ContentAlignment.MiddleCenter;
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
            customTextBox4.Location = new Point(723, 129);
            customTextBox4.Margin = new Padding(3, 4, 3, 4);
            customTextBox4.Multiline = false;
            customTextBox4.Name = "customTextBox4";
            customTextBox4.Padding = new Padding(10, 12, 8, 9);
            customTextBox4.PasswordChar = false;
            customTextBox4.PlaceholderColor = Color.DarkGray;
            customTextBox4.PlaceholderText = "Nhập mật khẩu...";
            customTextBox4.Size = new Size(279, 52);
            customTextBox4.TabIndex = 34;
            customTextBox4.Texts = "";
            customTextBox4.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(720, 75);
            label3.Name = "label3";
            label3.Size = new Size(173, 68);
            label3.TabIndex = 33;
            label3.Text = "Mật Khẩu";
            label3.TextAlign = ContentAlignment.MiddleCenter;
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
            customTextBox1.Location = new Point(410, 129);
            customTextBox1.Margin = new Padding(3, 4, 3, 4);
            customTextBox1.Multiline = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 12, 8, 9);
            customTextBox1.PasswordChar = false;
            customTextBox1.PlaceholderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "Nhập tài khoản...";
            customTextBox1.Size = new Size(279, 52);
            customTextBox1.TabIndex = 32;
            customTextBox1.Texts = "";
            customTextBox1.UnderlinedStyle = false;
            // 
            // M
            // 
            M.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            M.Location = new Point(390, 77);
            M.Name = "M";
            M.Size = new Size(121, 68);
            M.TabIndex = 31;
            M.Text = "Tài Khoản";
            M.TextAlign = ContentAlignment.MiddleCenter;
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
            idTxt.Location = new Point(70, 129);
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
            // customTextBox3
            // 
            customTextBox3.BackColor = SystemColors.Window;
            customTextBox3.BorderColor = Color.Silver;
            customTextBox3.BorderFocusColor = Color.DarkCyan;
            customTextBox3.BorderRadius = 13;
            customTextBox3.BorderSize = 2;
            customTextBox3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox3.ForeColor = Color.DimGray;
            customTextBox3.Location = new Point(723, 239);
            customTextBox3.Margin = new Padding(3, 4, 3, 4);
            customTextBox3.Multiline = false;
            customTextBox3.Name = "customTextBox3";
            customTextBox3.Padding = new Padding(10, 12, 8, 9);
            customTextBox3.PasswordChar = false;
            customTextBox3.PlaceholderColor = Color.DarkGray;
            customTextBox3.PlaceholderText = "Nhập số điện thoại...";
            customTextBox3.Size = new Size(279, 52);
            customTextBox3.TabIndex = 29;
            customTextBox3.Texts = "";
            customTextBox3.UnderlinedStyle = false;
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
            customTextBox2.Location = new Point(70, 239);
            customTextBox2.Margin = new Padding(3, 4, 3, 4);
            customTextBox2.Multiline = false;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(10, 12, 8, 9);
            customTextBox2.PasswordChar = false;
            customTextBox2.PlaceholderColor = Color.DarkGray;
            customTextBox2.PlaceholderText = "Nhập tên nguyên liệu...";
            customTextBox2.Size = new Size(279, 52);
            customTextBox2.TabIndex = 28;
            customTextBox2.Texts = "";
            customTextBox2.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 186);
            label5.Name = "label5";
            label5.Size = new Size(90, 68);
            label5.TabIndex = 27;
            label5.Text = "Tên";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(703, 187);
            label4.Name = "label4";
            label4.Size = new Size(150, 68);
            label4.TabIndex = 26;
            label4.Text = "Số Điện Thoại";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 78);
            label1.Name = "label1";
            label1.Size = new Size(90, 68);
            label1.TabIndex = 25;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            detailTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage listTabPage;
        private DataGridView dataGridView1;
        private TabPage detailTabPage;
        private Label label7;
        private CustomControl.CustomButton btn_back;
        private CustomControl.CustomTextBox customTextBox5;
        private Label label6;
        private CustomControl.CustomTextBox customTextBox4;
        private Label label3;
        private CustomControl.CustomTextBox customTextBox1;
        private Label M;
        private CustomControl.CustomTextBox idTxt;
        private CustomControl.CustomTextBox customTextBox3;
        private CustomControl.CustomTextBox customTextBox2;
        private Label label5;
        private Label label4;
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
    }
}