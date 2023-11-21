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
            tabControl1 = new TabControl();
            listTabPage = new TabPage();
            label9 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            delBtn = new CustomControl.CustomButton();
            editBtn = new CustomControl.CustomButton();
            addBtn = new CustomControl.CustomButton();
            dataGridView1 = new DataGridView();
            customButton2 = new CustomControl.CustomButton();
            searchTxt = new CustomControl.CustomTextBox();
            detailTabPage = new TabPage();
            label18 = new Label();
            HuyBtn = new CustomControl.CustomButton();
            xacNhanBtn = new CustomControl.CustomButton();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label8 = new Label();
            label10 = new Label();
            comboBox7 = new ComboBox();
            comboBox8 = new ComboBox();
            customButton1 = new CustomControl.CustomButton();
            customButton3 = new CustomControl.CustomButton();
            btn_add2 = new CustomControl.CustomButton();
            customButton5 = new CustomControl.CustomButton();
            customTextBox1 = new CustomControl.CustomTextBox();
            dataGridView2 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            comboBox6 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            btn_back = new CustomControl.CustomButton();
            label3 = new Label();
            M = new Label();
            idTxt = new CustomControl.CustomTextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            moreDetailTabPage = new TabPage();
            customTextBox4 = new CustomControl.CustomTextBox();
            label13 = new Label();
            customTextBox3 = new CustomControl.CustomTextBox();
            comboBox10 = new ComboBox();
            comboBox12 = new ComboBox();
            label12 = new Label();
            label14 = new Label();
            customTextBox2 = new CustomControl.CustomTextBox();
            label15 = new Label();
            label17 = new Label();
            label11 = new Label();
            btn_back2 = new CustomControl.CustomButton();
            customButton4 = new CustomControl.CustomButton();
            customButton6 = new CustomControl.CustomButton();
            tabControl1.SuspendLayout();
            listTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            detailTabPage.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            moreDetailTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(listTabPage);
            tabControl1.Controls.Add(detailTabPage);
            tabControl1.Controls.Add(moreDetailTabPage);
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
            listTabPage.Controls.Add(delBtn);
            listTabPage.Controls.Add(editBtn);
            listTabPage.Controls.Add(addBtn);
            listTabPage.Controls.Add(dataGridView1);
            listTabPage.Controls.Add(customButton2);
            listTabPage.Controls.Add(searchTxt);
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
            label9.Location = new Point(318, 8);
            label9.Name = "label9";
            label9.Size = new Size(46, 41);
            label9.TabIndex = 29;
            label9.Text = "Lọc:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(518, 9);
            label2.Name = "label2";
            label2.Size = new Size(83, 41);
            label2.TabIndex = 28;
            label2.Text = "Sắp xếp:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(370, 12);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(142, 38);
            comboBox2.TabIndex = 27;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(607, 12);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 38);
            comboBox1.TabIndex = 26;
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
            delBtn.Location = new Point(1069, 3);
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
            editBtn.Location = new Point(924, 3);
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
            addBtn.Location = new Point(778, 3);
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
            customButton2.Location = new Point(266, 12);
            customButton2.Margin = new Padding(3, 4, 3, 4);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(40, 37);
            customButton2.TabIndex = 15;
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
            searchTxt.Location = new Point(8, 7);
            searchTxt.Margin = new Padding(3, 4, 3, 4);
            searchTxt.Multiline = false;
            searchTxt.Name = "searchTxt";
            searchTxt.Padding = new Padding(10, 9, 46, 9);
            searchTxt.PasswordChar = false;
            searchTxt.PlaceholderColor = Color.DarkGray;
            searchTxt.PlaceholderText = "Tìm Kiếm ...";
            searchTxt.Size = new Size(304, 47);
            searchTxt.TabIndex = 11;
            searchTxt.Texts = "";
            searchTxt.UnderlinedStyle = false;
            // 
            // detailTabPage
            // 
            detailTabPage.Controls.Add(label18);
            detailTabPage.Controls.Add(HuyBtn);
            detailTabPage.Controls.Add(xacNhanBtn);
            detailTabPage.Controls.Add(groupBox1);
            detailTabPage.Controls.Add(dateTimePicker1);
            detailTabPage.Controls.Add(comboBox6);
            detailTabPage.Controls.Add(comboBox5);
            detailTabPage.Controls.Add(comboBox4);
            detailTabPage.Controls.Add(comboBox3);
            detailTabPage.Controls.Add(label6);
            detailTabPage.Controls.Add(label7);
            detailTabPage.Controls.Add(btn_back);
            detailTabPage.Controls.Add(label3);
            detailTabPage.Controls.Add(M);
            detailTabPage.Controls.Add(idTxt);
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
            // label18
            // 
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(799, 7);
            label18.Name = "label18";
            label18.Size = new Size(173, 68);
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
            HuyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HuyBtn.ForeColor = Color.Red;
            HuyBtn.Image = Properties.Resources.CANCELiconRed;
            HuyBtn.ImageAlign = ContentAlignment.MiddleRight;
            HuyBtn.ImageHover = Properties.Resources.CANCELiconWhite;
            HuyBtn.Location = new Point(1057, 153);
            HuyBtn.Margin = new Padding(3, 4, 3, 4);
            HuyBtn.Name = "HuyBtn";
            HuyBtn.Size = new Size(157, 71);
            HuyBtn.TabIndex = 63;
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
            xacNhanBtn.Location = new Point(1057, 232);
            xacNhanBtn.Margin = new Padding(3, 4, 3, 4);
            xacNhanBtn.Name = "xacNhanBtn";
            xacNhanBtn.Size = new Size(157, 71);
            xacNhanBtn.TabIndex = 62;
            xacNhanBtn.Text = "  Xác Nhận";
            xacNhanBtn.TextColor = Color.DarkCyan;
            xacNhanBtn.TextHover = Color.White;
            xacNhanBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            xacNhanBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 320);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1216, 384);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi Tiết Phiếu Nhập";
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(comboBox7);
            panel1.Controls.Add(comboBox8);
            panel1.Controls.Add(customButton1);
            panel1.Controls.Add(customButton3);
            panel1.Controls.Add(btn_add2);
            panel1.Controls.Add(customButton5);
            panel1.Controls.Add(customTextBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 86);
            panel1.TabIndex = 24;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(316, 20);
            label8.Name = "label8";
            label8.Size = new Size(46, 41);
            label8.TabIndex = 38;
            label8.Text = "Lọc:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(516, 21);
            label10.Name = "label10";
            label10.Size = new Size(83, 41);
            label10.TabIndex = 37;
            label10.Text = "Sắp xếp:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox7
            // 
            comboBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(368, 24);
            comboBox7.Margin = new Padding(3, 4, 3, 4);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(142, 38);
            comboBox7.TabIndex = 36;
            // 
            // comboBox8
            // 
            comboBox8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox8.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(605, 24);
            comboBox8.Margin = new Padding(3, 4, 3, 4);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(148, 38);
            comboBox8.TabIndex = 35;
            // 
            // customButton1
            // 
            customButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customButton1.BackColor = SystemColors.Control;
            customButton1.BackgroundColor = SystemColors.Control;
            customButton1.BorderColor = Color.Red;
            customButton1.BorderRadius = 15;
            customButton1.BorderSize = 2;
            customButton1.Cursor = Cursors.Hand;
            customButton1.EnabledTextHover = true;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            customButton1.FlatAppearance.MouseOverBackColor = Color.Red;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = Color.Red;
            customButton1.Image = Properties.Resources.deleteIconRed16px;
            customButton1.ImageAlign = ContentAlignment.MiddleRight;
            customButton1.ImageHover = Properties.Resources.deleteIconWhite16px;
            customButton1.Location = new Point(1067, 15);
            customButton1.Margin = new Padding(3, 4, 3, 4);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(138, 51);
            customButton1.TabIndex = 34;
            customButton1.Text = "  Xóa";
            customButton1.TextColor = Color.Red;
            customButton1.TextHover = Color.White;
            customButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            customButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customButton3.BackColor = SystemColors.Control;
            customButton3.BackgroundColor = SystemColors.Control;
            customButton3.BorderColor = Color.DarkCyan;
            customButton3.BorderRadius = 15;
            customButton3.BorderSize = 2;
            customButton3.Cursor = Cursors.Hand;
            customButton3.EnabledTextHover = true;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatAppearance.MouseDownBackColor = Color.Teal;
            customButton3.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton3.ForeColor = Color.DarkCyan;
            customButton3.Image = Properties.Resources.editIconTeal16px;
            customButton3.ImageAlign = ContentAlignment.MiddleRight;
            customButton3.ImageHover = Properties.Resources.editIconWhite16px;
            customButton3.Location = new Point(922, 15);
            customButton3.Margin = new Padding(3, 4, 3, 4);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(138, 51);
            customButton3.TabIndex = 33;
            customButton3.Text = "  Sửa";
            customButton3.TextColor = Color.DarkCyan;
            customButton3.TextHover = Color.White;
            customButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // btn_add2
            // 
            btn_add2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_add2.BackColor = SystemColors.Control;
            btn_add2.BackgroundColor = SystemColors.Control;
            btn_add2.BorderColor = Color.DarkCyan;
            btn_add2.BorderRadius = 15;
            btn_add2.BorderSize = 2;
            btn_add2.Cursor = Cursors.Hand;
            btn_add2.EnabledTextHover = true;
            btn_add2.FlatAppearance.BorderSize = 0;
            btn_add2.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_add2.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_add2.FlatStyle = FlatStyle.Flat;
            btn_add2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add2.ForeColor = Color.DarkCyan;
            btn_add2.Image = Properties.Resources.addIconTeal16px;
            btn_add2.ImageAlign = ContentAlignment.MiddleRight;
            btn_add2.ImageHover = Properties.Resources.addIconWhite16px;
            btn_add2.Location = new Point(776, 15);
            btn_add2.Margin = new Padding(3, 4, 3, 4);
            btn_add2.Name = "btn_add2";
            btn_add2.Size = new Size(138, 51);
            btn_add2.TabIndex = 32;
            btn_add2.Text = "  Thêm";
            btn_add2.TextColor = Color.DarkCyan;
            btn_add2.TextHover = Color.White;
            btn_add2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_add2.UseVisualStyleBackColor = false;
            btn_add2.Click += btn_add2_Click;
            // 
            // customButton5
            // 
            customButton5.BackColor = Color.Transparent;
            customButton5.BackgroundColor = Color.Transparent;
            customButton5.BorderColor = Color.PaleVioletRed;
            customButton5.BorderRadius = 15;
            customButton5.BorderSize = 0;
            customButton5.Cursor = Cursors.Hand;
            customButton5.EnabledTextHover = false;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 64, 64, 64);
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.ForeColor = Color.White;
            customButton5.ImageHover = null;
            customButton5.Location = new Point(264, 24);
            customButton5.Margin = new Padding(3, 4, 3, 4);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(40, 37);
            customButton5.TabIndex = 31;
            customButton5.TextColor = Color.White;
            customButton5.TextHover = Color.White;
            customButton5.UseVisualStyleBackColor = false;
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
            customTextBox1.Location = new Point(6, 19);
            customTextBox1.Margin = new Padding(3, 4, 3, 4);
            customTextBox1.Multiline = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 9, 46, 9);
            customTextBox1.PasswordChar = false;
            customTextBox1.PlaceholderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "Tìm Kiếm ...";
            customTextBox1.Size = new Size(304, 47);
            customTextBox1.TabIndex = 30;
            customTextBox1.Texts = "";
            customTextBox1.UnderlinedStyle = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.DarkCyan;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.ColumnHeadersHeight = 30;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.DarkCyan;
            dataGridView2.ImeMode = ImeMode.NoControl;
            dataGridView2.Location = new Point(3, 32);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.RowTemplate.ReadOnly = true;
            dataGridView2.Size = new Size(1210, 349);
            dataGridView2.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(38, 249);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(343, 36);
            dateTimePicker1.TabIndex = 60;
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(728, 249);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(279, 38);
            comboBox6.TabIndex = 59;
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(415, 139);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(279, 38);
            comboBox5.TabIndex = 58;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "False", "True" });
            comboBox4.Location = new Point(728, 139);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(279, 38);
            comboBox4.TabIndex = 57;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(415, 249);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(279, 38);
            comboBox3.TabIndex = 56;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(415, 183);
            label6.Name = "label6";
            label6.Size = new Size(153, 68);
            label6.TabIndex = 55;
            label6.Text = "Tên Nhân Viên";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(99, 3);
            label7.Name = "label7";
            label7.Size = new Size(313, 57);
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
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(725, 71);
            label3.Name = "label3";
            label3.Size = new Size(173, 68);
            label3.TabIndex = 33;
            label3.Text = "ID Nhà Cung Cấp";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // M
            // 
            M.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            M.Location = new Point(395, 73);
            M.Name = "M";
            M.Size = new Size(166, 68);
            M.TabIndex = 31;
            M.Text = "ID Nhân Viên";
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
            idTxt.Location = new Point(38, 125);
            idTxt.Margin = new Padding(3, 4, 3, 4);
            idTxt.Multiline = false;
            idTxt.Name = "idTxt";
            idTxt.Padding = new Padding(10, 12, 8, 9);
            idTxt.PasswordChar = false;
            idTxt.PlaceholderColor = Color.DarkGray;
            idTxt.PlaceholderText = "Nhập ID....";
            idTxt.Size = new Size(343, 52);
            idTxt.TabIndex = 30;
            idTxt.Texts = "";
            idTxt.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 194);
            label5.Name = "label5";
            label5.Size = new Size(126, 68);
            label5.TabIndex = 27;
            label5.Text = "Ngày Nhập";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(708, 183);
            label4.Name = "label4";
            label4.Size = new Size(190, 68);
            label4.TabIndex = 26;
            label4.Text = "Tên Nhà Cung Cấp";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 74);
            label1.Name = "label1";
            label1.Size = new Size(157, 68);
            label1.TabIndex = 25;
            label1.Text = "ID Phiếu Nhập";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // moreDetailTabPage
            // 
            moreDetailTabPage.Controls.Add(customButton4);
            moreDetailTabPage.Controls.Add(customButton6);
            moreDetailTabPage.Controls.Add(customTextBox4);
            moreDetailTabPage.Controls.Add(label13);
            moreDetailTabPage.Controls.Add(customTextBox3);
            moreDetailTabPage.Controls.Add(comboBox10);
            moreDetailTabPage.Controls.Add(comboBox12);
            moreDetailTabPage.Controls.Add(label12);
            moreDetailTabPage.Controls.Add(label14);
            moreDetailTabPage.Controls.Add(customTextBox2);
            moreDetailTabPage.Controls.Add(label15);
            moreDetailTabPage.Controls.Add(label17);
            moreDetailTabPage.Controls.Add(label11);
            moreDetailTabPage.Controls.Add(btn_back2);
            moreDetailTabPage.Location = new Point(4, 29);
            moreDetailTabPage.Name = "moreDetailTabPage";
            moreDetailTabPage.Padding = new Padding(3);
            moreDetailTabPage.Size = new Size(1222, 707);
            moreDetailTabPage.TabIndex = 2;
            moreDetailTabPage.Text = "Chi Tiết Phiếu Nhập";
            moreDetailTabPage.UseVisualStyleBackColor = true;
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
            customTextBox4.Location = new Point(754, 121);
            customTextBox4.Margin = new Padding(3, 4, 3, 4);
            customTextBox4.Multiline = false;
            customTextBox4.Name = "customTextBox4";
            customTextBox4.Padding = new Padding(10, 12, 8, 9);
            customTextBox4.PasswordChar = false;
            customTextBox4.PlaceholderColor = Color.DarkGray;
            customTextBox4.PlaceholderText = "Nhập ID....";
            customTextBox4.Size = new Size(343, 52);
            customTextBox4.TabIndex = 73;
            customTextBox4.Texts = "";
            customTextBox4.UnderlinedStyle = false;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(732, 66);
            label13.Name = "label13";
            label13.Size = new Size(126, 68);
            label13.TabIndex = 72;
            label13.Text = "Đơn Giá";
            label13.TextAlign = ContentAlignment.MiddleCenter;
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
            customTextBox3.Location = new Point(52, 231);
            customTextBox3.Margin = new Padding(3, 4, 3, 4);
            customTextBox3.Multiline = false;
            customTextBox3.Name = "customTextBox3";
            customTextBox3.Padding = new Padding(10, 12, 8, 9);
            customTextBox3.PasswordChar = false;
            customTextBox3.PlaceholderColor = Color.DarkGray;
            customTextBox3.PlaceholderText = "Nhập ID....";
            customTextBox3.Size = new Size(343, 52);
            customTextBox3.TabIndex = 71;
            customTextBox3.Texts = "";
            customTextBox3.UnderlinedStyle = false;
            // 
            // comboBox10
            // 
            comboBox10.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox10.FormattingEnabled = true;
            comboBox10.Location = new Point(429, 135);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(279, 38);
            comboBox10.TabIndex = 70;
            // 
            // comboBox12
            // 
            comboBox12.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox12.FormattingEnabled = true;
            comboBox12.Location = new Point(429, 245);
            comboBox12.Name = "comboBox12";
            comboBox12.Size = new Size(279, 38);
            comboBox12.TabIndex = 68;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(409, 179);
            label12.Name = "label12";
            label12.Size = new Size(171, 68);
            label12.TabIndex = 67;
            label12.Text = "Tên Nguyên Liệu";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(409, 69);
            label14.Name = "label14";
            label14.Size = new Size(166, 68);
            label14.TabIndex = 65;
            label14.Text = "ID Nguyên Liệu";
            label14.TextAlign = ContentAlignment.MiddleCenter;
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
            customTextBox2.Location = new Point(52, 121);
            customTextBox2.Margin = new Padding(3, 4, 3, 4);
            customTextBox2.Multiline = false;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(10, 12, 8, 9);
            customTextBox2.PasswordChar = false;
            customTextBox2.PlaceholderColor = Color.DarkGray;
            customTextBox2.PlaceholderText = "Nhập ID....";
            customTextBox2.Size = new Size(343, 52);
            customTextBox2.TabIndex = 64;
            customTextBox2.Texts = "";
            customTextBox2.UnderlinedStyle = false;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(30, 176);
            label15.Name = "label15";
            label15.Size = new Size(160, 68);
            label15.TabIndex = 63;
            label15.Text = "Khối Lượng (Kg)";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(33, 70);
            label17.Name = "label17";
            label17.Size = new Size(157, 68);
            label17.TabIndex = 61;
            label17.Text = "ID Phiếu Nhập";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(98, 12);
            label11.Name = "label11";
            label11.Size = new Size(417, 57);
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
            btn_back2.Location = new Point(8, 16);
            btn_back2.Margin = new Padding(3, 4, 3, 4);
            btn_back2.Name = "btn_back2";
            btn_back2.Size = new Size(72, 55);
            btn_back2.TabIndex = 41;
            btn_back2.TextColor = Color.White;
            btn_back2.TextHover = Color.White;
            btn_back2.UseVisualStyleBackColor = false;
            btn_back2.Click += btn_back2_Click;
            // 
            // customButton4
            // 
            customButton4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            customButton4.BackColor = SystemColors.Control;
            customButton4.BackgroundColor = SystemColors.Control;
            customButton4.BorderColor = Color.Red;
            customButton4.BorderRadius = 15;
            customButton4.BorderSize = 2;
            customButton4.Cursor = Cursors.Hand;
            customButton4.EnabledTextHover = true;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            customButton4.FlatAppearance.MouseOverBackColor = Color.Red;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton4.ForeColor = Color.Red;
            customButton4.Image = Properties.Resources.CANCELiconRed;
            customButton4.ImageAlign = ContentAlignment.MiddleRight;
            customButton4.ImageHover = Properties.Resources.CANCELiconWhite;
            customButton4.Location = new Point(1040, 607);
            customButton4.Margin = new Padding(3, 4, 3, 4);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(157, 71);
            customButton4.TabIndex = 75;
            customButton4.Text = "  Hủy";
            customButton4.TextColor = Color.Red;
            customButton4.TextHover = Color.White;
            customButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton6
            // 
            customButton6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            customButton6.BackColor = SystemColors.Control;
            customButton6.BackgroundColor = SystemColors.Control;
            customButton6.BorderColor = Color.DarkCyan;
            customButton6.BorderRadius = 15;
            customButton6.BorderSize = 2;
            customButton6.Cursor = Cursors.Hand;
            customButton6.EnabledTextHover = true;
            customButton6.FlatAppearance.BorderSize = 0;
            customButton6.FlatAppearance.MouseDownBackColor = Color.Teal;
            customButton6.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            customButton6.FlatStyle = FlatStyle.Flat;
            customButton6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton6.ForeColor = Color.DarkCyan;
            customButton6.Image = Properties.Resources.ConfirmIcondarkcyan1;
            customButton6.ImageAlign = ContentAlignment.MiddleRight;
            customButton6.ImageHover = Properties.Resources.ConfirmIconWhite1;
            customButton6.Location = new Point(865, 607);
            customButton6.Margin = new Padding(3, 4, 3, 4);
            customButton6.Name = "customButton6";
            customButton6.Size = new Size(157, 71);
            customButton6.TabIndex = 74;
            customButton6.Text = "  Xác Nhận";
            customButton6.TextColor = Color.DarkCyan;
            customButton6.TextHover = Color.White;
            customButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton6.UseVisualStyleBackColor = false;
            // 
            // NhapHangView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 740);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "NhapHangView";
            Text = "NhapHangView";
            tabControl1.ResumeLayout(false);
            listTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            detailTabPage.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            moreDetailTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage listTabPage;
        private DataGridView dataGridView1;
        private CustomControl.CustomButton customButton2;
        private CustomControl.CustomTextBox searchTxt;
        private TabPage detailTabPage;
        private ComboBox comboBox3;
        private Label label6;
        private Label label7;
        private CustomControl.CustomButton btn_back;
        private Label label3;
        private Label M;
        private CustomControl.CustomTextBox idTxt;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label9;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private CustomControl.CustomButton delBtn;
        private CustomControl.CustomButton editBtn;
        private CustomControl.CustomButton addBtn;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private CustomControl.CustomButton xacNhanBtn;
        private CustomControl.CustomButton HuyBtn;
        private Panel panel1;
        private Label label8;
        private Label label10;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private CustomControl.CustomButton customButton1;
        private CustomControl.CustomButton customButton3;
        private CustomControl.CustomButton btn_add2;
        private CustomControl.CustomButton customButton5;
        private CustomControl.CustomTextBox customTextBox1;
        private TabPage moreDetailTabPage;
        private Label label11;
        private CustomControl.CustomButton btn_back2;
        private ComboBox comboBox10;
        private ComboBox comboBox12;
        private Label label12;
        private Label label14;
        private CustomControl.CustomTextBox customTextBox2;
        private Label label15;
        private Label label17;
        private Label label18;
        private CustomControl.CustomTextBox customTextBox4;
        private Label label13;
        private CustomControl.CustomTextBox customTextBox3;
        private CustomControl.CustomButton customButton4;
        private CustomControl.CustomButton customButton6;
    }
}