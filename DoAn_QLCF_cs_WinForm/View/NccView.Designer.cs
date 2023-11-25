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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tcNCC = new TabControl();
            listTabPage = new TabPage();
            dgvNcc = new DataGridView();
            searchTxt = new CustomControl.CustomTextBox();
            label9 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            delBtn = new CustomControl.CustomButton();
            editBtn = new CustomControl.CustomButton();
            addBtn = new CustomControl.CustomButton();
            detailTabPage = new TabPage();
            label8 = new Label();
            HuyBtn = new CustomControl.CustomButton();
            xacNhanBtn = new CustomControl.CustomButton();
            txtSDTNcc = new CustomControl.CustomTextBox();
            label3 = new Label();
            txtDiaChiNcc = new CustomControl.CustomTextBox();
            M = new Label();
            label7 = new Label();
            btn_back = new CustomControl.CustomButton();
            txtIdNcc = new CustomControl.CustomTextBox();
            txtEmailNcc = new CustomControl.CustomTextBox();
            txtTenNcc = new CustomControl.CustomTextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            checkboxIsDelete = new CheckBox();
            tcNCC.SuspendLayout();
            listTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNcc).BeginInit();
            detailTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tcNCC
            // 
            tcNCC.Controls.Add(listTabPage);
            tcNCC.Controls.Add(detailTabPage);
            tcNCC.Dock = DockStyle.Fill;
            tcNCC.Location = new Point(0, 0);
            tcNCC.Margin = new Padding(4);
            tcNCC.Name = "tcNCC";
            tcNCC.SelectedIndex = 0;
            tcNCC.Size = new Size(1515, 866);
            tcNCC.TabIndex = 0;
            // 
            // listTabPage
            // 
            listTabPage.Controls.Add(dgvNcc);
            listTabPage.Controls.Add(searchTxt);
            listTabPage.Controls.Add(label9);
            listTabPage.Controls.Add(label2);
            listTabPage.Controls.Add(comboBox2);
            listTabPage.Controls.Add(comboBox1);
            listTabPage.Controls.Add(delBtn);
            listTabPage.Controls.Add(editBtn);
            listTabPage.Controls.Add(addBtn);
            listTabPage.Location = new Point(4, 34);
            listTabPage.Margin = new Padding(4);
            listTabPage.Name = "listTabPage";
            listTabPage.Padding = new Padding(4);
            listTabPage.Size = new Size(1507, 828);
            listTabPage.TabIndex = 0;
            listTabPage.Text = "Danh Sách";
            listTabPage.UseVisualStyleBackColor = true;
            // 
            // dgvNcc
            // 
            dgvNcc.AllowUserToAddRows = false;
            dgvNcc.AllowUserToDeleteRows = false;
            dgvNcc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNcc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNcc.BorderStyle = BorderStyle.None;
            dgvNcc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkCyan;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNcc.ColumnHeadersHeight = 30;
            dgvNcc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNcc.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNcc.Dock = DockStyle.Bottom;
            dgvNcc.EnableHeadersVisualStyles = false;
            dgvNcc.GridColor = Color.DarkCyan;
            dgvNcc.ImeMode = ImeMode.NoControl;
            dgvNcc.Location = new Point(4, 228);
            dgvNcc.Margin = new Padding(4, 5, 4, 5);
            dgvNcc.Name = "dgvNcc";
            dgvNcc.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvNcc.RowHeadersVisible = false;
            dgvNcc.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNcc.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvNcc.RowTemplate.Height = 25;
            dgvNcc.RowTemplate.ReadOnly = true;
            dgvNcc.Size = new Size(1499, 596);
            dgvNcc.TabIndex = 20;
            dgvNcc.CellClick += dgvNcc_CellClick;
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
            searchTxt.Location = new Point(8, 12);
            searchTxt.Margin = new Padding(4, 5, 4, 5);
            searchTxt.Multiline = false;
            searchTxt.Name = "searchTxt";
            searchTxt.Padding = new Padding(12, 11, 58, 11);
            searchTxt.PasswordChar = false;
            searchTxt.PlaceholderColor = Color.DarkGray;
            searchTxt.PlaceholderText = "Tìm Kiếm ...";
            searchTxt.Size = new Size(380, 55);
            searchTxt.TabIndex = 19;
            searchTxt.Texts = "";
            searchTxt.UnderlinedStyle = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(398, 15);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(58, 51);
            label9.TabIndex = 17;
            label9.Text = "Lọc:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(648, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 51);
            label2.TabIndex = 16;
            label2.Text = "Sắp xếp:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(462, 20);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(176, 44);
            comboBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(759, 20);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 44);
            comboBox1.TabIndex = 14;
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
            delBtn.Location = new Point(1315, 9);
            delBtn.Margin = new Padding(4, 5, 4, 5);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(172, 64);
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
            editBtn.Location = new Point(1134, 9);
            editBtn.Margin = new Padding(4, 5, 4, 5);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(172, 64);
            editBtn.TabIndex = 12;
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
            addBtn.Location = new Point(951, 9);
            addBtn.Margin = new Padding(4, 5, 4, 5);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(172, 64);
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
            detailTabPage.Controls.Add(checkboxIsDelete);
            detailTabPage.Controls.Add(label8);
            detailTabPage.Controls.Add(HuyBtn);
            detailTabPage.Controls.Add(xacNhanBtn);
            detailTabPage.Controls.Add(txtSDTNcc);
            detailTabPage.Controls.Add(label3);
            detailTabPage.Controls.Add(txtDiaChiNcc);
            detailTabPage.Controls.Add(M);
            detailTabPage.Controls.Add(label7);
            detailTabPage.Controls.Add(btn_back);
            detailTabPage.Controls.Add(txtIdNcc);
            detailTabPage.Controls.Add(txtEmailNcc);
            detailTabPage.Controls.Add(txtTenNcc);
            detailTabPage.Controls.Add(label5);
            detailTabPage.Controls.Add(label4);
            detailTabPage.Controls.Add(label1);
            detailTabPage.Location = new Point(4, 34);
            detailTabPage.Margin = new Padding(4);
            detailTabPage.Name = "detailTabPage";
            detailTabPage.Padding = new Padding(4);
            detailTabPage.Size = new Size(1507, 828);
            detailTabPage.TabIndex = 1;
            detailTabPage.Text = "Chi Tiết";
            detailTabPage.UseVisualStyleBackColor = true;
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
            HuyBtn.Location = new Point(1280, 689);
            HuyBtn.Margin = new Padding(4, 5, 4, 5);
            HuyBtn.Name = "HuyBtn";
            HuyBtn.Size = new Size(196, 89);
            HuyBtn.TabIndex = 42;
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
            xacNhanBtn.Location = new Point(1061, 689);
            xacNhanBtn.Margin = new Padding(4, 5, 4, 5);
            xacNhanBtn.Name = "xacNhanBtn";
            xacNhanBtn.Size = new Size(196, 89);
            xacNhanBtn.TabIndex = 41;
            xacNhanBtn.Text = "  Xác Nhận";
            xacNhanBtn.TextColor = Color.DarkCyan;
            xacNhanBtn.TextHover = Color.White;
            xacNhanBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            xacNhanBtn.UseVisualStyleBackColor = false;
            // 
            // txtSDTNcc
            // 
            txtSDTNcc.BackColor = SystemColors.Window;
            txtSDTNcc.BorderColor = Color.Silver;
            txtSDTNcc.BorderFocusColor = Color.DarkCyan;
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
            txtSDTNcc.PlaceholderText = "Nhập số điện thoại....";
            txtSDTNcc.Size = new Size(349, 63);
            txtSDTNcc.TabIndex = 36;
            txtSDTNcc.Texts = "";
            txtSDTNcc.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(890, 81);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 85);
            label3.TabIndex = 35;
            label3.Text = "Số Điện Thoại";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDiaChiNcc
            // 
            txtDiaChiNcc.BackColor = SystemColors.Window;
            txtDiaChiNcc.BorderColor = Color.Silver;
            txtDiaChiNcc.BorderFocusColor = Color.DarkCyan;
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
            txtDiaChiNcc.PlaceholderText = "Nhập địa chỉ....";
            txtDiaChiNcc.Size = new Size(349, 63);
            txtDiaChiNcc.TabIndex = 34;
            txtDiaChiNcc.Texts = "";
            txtDiaChiNcc.UnderlinedStyle = false;
            // 
            // M
            // 
            M.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            M.Location = new Point(478, 84);
            M.Margin = new Padding(4, 0, 4, 0);
            M.Name = "M";
            M.Size = new Size(151, 85);
            M.TabIndex = 33;
            M.Text = "Địa Chỉ";
            M.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(140, 20);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(389, 71);
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
            btn_back.Location = new Point(28, 25);
            btn_back.Margin = new Padding(4, 5, 4, 5);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(90, 69);
            btn_back.TabIndex = 31;
            btn_back.TextColor = Color.White;
            btn_back.TextHover = Color.White;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // txtIdNcc
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
            txtIdNcc.PlaceholderText = "Nhập ID....";
            txtIdNcc.Size = new Size(349, 63);
            txtIdNcc.TabIndex = 30;
            txtIdNcc.Texts = "";
            txtIdNcc.UnderlinedStyle = false;
            // 
            // txtEmailNcc
            // 
            txtEmailNcc.BackColor = SystemColors.Window;
            txtEmailNcc.BorderColor = Color.Silver;
            txtEmailNcc.BorderFocusColor = Color.DarkCyan;
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
            txtEmailNcc.PlaceholderText = "Nhập email....";
            txtEmailNcc.Size = new Size(349, 63);
            txtEmailNcc.TabIndex = 29;
            txtEmailNcc.Texts = "";
            txtEmailNcc.UnderlinedStyle = false;
            // 
            // txtTenNcc
            // 
            txtTenNcc.BackColor = SystemColors.Window;
            txtTenNcc.BorderColor = Color.Silver;
            txtTenNcc.BorderFocusColor = Color.DarkCyan;
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
            txtTenNcc.PlaceholderText = "Nhập tên nhà cung cấp....";
            txtTenNcc.Size = new Size(349, 63);
            txtTenNcc.TabIndex = 28;
            txtTenNcc.Texts = "";
            txtTenNcc.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(50, 220);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 85);
            label5.TabIndex = 27;
            label5.Text = "Tên";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(502, 220);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(151, 85);
            label4.TabIndex = 26;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 85);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 85);
            label1.TabIndex = 25;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            // NccView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1515, 866);
            Controls.Add(tcNCC);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "NccView";
            Text = "NccView";
            tcNCC.ResumeLayout(false);
            listTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNcc).EndInit();
            detailTabPage.ResumeLayout(false);
            detailTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcNCC;
        private TabPage listTabPage;
        private TabPage detailTabPage;
        private Label label9;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private CustomControl.CustomButton delBtn;
        private CustomControl.CustomButton editBtn;
        private CustomControl.CustomButton addBtn;
        private CustomControl.CustomTextBox searchTxt;
        private DataGridView dgvNcc;
        private CustomControl.CustomTextBox txtSDTNcc;
        private Label label3;
        private CustomControl.CustomTextBox txtDiaChiNcc;
        private Label M;
        private Label label7;
        private CustomControl.CustomButton btn_back;
        private CustomControl.CustomTextBox txtIdNcc;
        private CustomControl.CustomTextBox txtEmailNcc;
        private CustomControl.CustomTextBox txtTenNcc;
        private Label label5;
        private Label label4;
        private Label label1;
        private CustomControl.CustomButton HuyBtn;
        private CustomControl.CustomButton xacNhanBtn;
        private Label label8;
        private CheckBox checkboxIsDelete;
    }
}