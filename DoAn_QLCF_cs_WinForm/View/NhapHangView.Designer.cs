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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tcNhapHang = new TabControl();
            listTabPage = new TabPage();
            resetBtn = new CustomControl.CustomButton();
            gbSort = new GroupBox();
            groupBox5 = new GroupBox();
            rbDcDec = new RadioButton();
            rbDcInc = new RadioButton();
            groupBox6 = new GroupBox();
            rbIsDeleteDec = new RadioButton();
            rbIsDeleteInc = new RadioButton();
            groupBox2 = new GroupBox();
            rbIDDec = new RadioButton();
            rbIIDnc = new RadioButton();
            groupBox4 = new GroupBox();
            rbSdtDec = new RadioButton();
            rbSdtInc = new RadioButton();
            groupBox3 = new GroupBox();
            rbNameDec = new RadioButton();
            rbNameInc = new RadioButton();
            groupBox7 = new GroupBox();
            rbEmailDec = new RadioButton();
            rbEmailInc = new RadioButton();
            filterBtn = new CustomControl.CustomButton();
            sortBtn = new CustomControl.CustomButton();
            delBtn = new CustomControl.CustomButton();
            btnEditPN = new CustomControl.CustomButton();
            btnAddPN = new CustomControl.CustomButton();
            dgvDsNhapHang = new DataGridView();
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
            btnEditCTPN = new CustomControl.CustomButton();
            btnAddCTPN = new CustomControl.CustomButton();
            customButton5 = new CustomControl.CustomButton();
            customTextBox1 = new CustomControl.CustomTextBox();
            dgvCTPN = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
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
            label1 = new Label();
            moreDetailTabPage = new TabPage();
            btnHuyCTPN = new CustomControl.CustomButton();
            btnXacNhanCTPN = new CustomControl.CustomButton();
            txtCTPNDonGia = new CustomControl.CustomTextBox();
            label13 = new Label();
            txtCTPNKhoiLuong = new CustomControl.CustomTextBox();
            comboBox10 = new ComboBox();
            comboBox12 = new ComboBox();
            label12 = new Label();
            label14 = new Label();
            txtCTPNId = new CustomControl.CustomTextBox();
            label15 = new Label();
            label17 = new Label();
            label11 = new Label();
            btn_back2 = new CustomControl.CustomButton();
            tcNhapHang.SuspendLayout();
            listTabPage.SuspendLayout();
            gbSort.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsNhapHang).BeginInit();
            detailTabPage.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).BeginInit();
            moreDetailTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tcNhapHang
            // 
            tcNhapHang.Controls.Add(listTabPage);
            tcNhapHang.Controls.Add(detailTabPage);
            tcNhapHang.Controls.Add(moreDetailTabPage);
            tcNhapHang.Dock = DockStyle.Fill;
            tcNhapHang.Location = new Point(0, 0);
            tcNhapHang.Margin = new Padding(4);
            tcNhapHang.Name = "tcNhapHang";
            tcNhapHang.SelectedIndex = 0;
            tcNhapHang.Size = new Size(1538, 925);
            tcNhapHang.TabIndex = 1;
            // 
            // listTabPage
            // 
            listTabPage.Controls.Add(resetBtn);
            listTabPage.Controls.Add(gbSort);
            listTabPage.Controls.Add(filterBtn);
            listTabPage.Controls.Add(sortBtn);
            listTabPage.Controls.Add(delBtn);
            listTabPage.Controls.Add(btnEditPN);
            listTabPage.Controls.Add(btnAddPN);
            listTabPage.Controls.Add(dgvDsNhapHang);
            listTabPage.Controls.Add(customButton2);
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
            resetBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.ForeColor = Color.DarkGray;
            resetBtn.ImageAlign = ContentAlignment.MiddleRight;
            resetBtn.ImageHover = null;
            resetBtn.Location = new Point(1333, 169);
            resetBtn.Margin = new Padding(4, 5, 4, 5);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(172, 64);
            resetBtn.TabIndex = 30;
            resetBtn.Text = "Reset";
            resetBtn.TextColor = Color.DarkGray;
            resetBtn.TextHover = Color.White;
            resetBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            resetBtn.UseVisualStyleBackColor = false;
            // 
            // gbSort
            // 
            gbSort.Controls.Add(groupBox5);
            gbSort.Controls.Add(groupBox6);
            gbSort.Controls.Add(groupBox2);
            gbSort.Controls.Add(groupBox4);
            gbSort.Controls.Add(groupBox3);
            gbSort.Controls.Add(groupBox7);
            gbSort.Location = new Point(52, 115);
            gbSort.Name = "gbSort";
            gbSort.Size = new Size(1148, 150);
            gbSort.TabIndex = 29;
            gbSort.TabStop = false;
            gbSort.Visible = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rbDcDec);
            groupBox5.Controls.Add(rbDcInc);
            groupBox5.Location = new Point(403, 24);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(140, 108);
            groupBox5.TabIndex = 24;
            groupBox5.TabStop = false;
            groupBox5.Text = "Địa chỉ";
            // 
            // rbDcDec
            // 
            rbDcDec.AutoSize = true;
            rbDcDec.Location = new Point(17, 65);
            rbDcDec.Name = "rbDcDec";
            rbDcDec.Size = new Size(78, 29);
            rbDcDec.TabIndex = 1;
            rbDcDec.TabStop = true;
            rbDcDec.Tag = "DcDec";
            rbDcDec.Text = "Giảm";
            rbDcDec.UseVisualStyleBackColor = true;
            // 
            // rbDcInc
            // 
            rbDcInc.AutoSize = true;
            rbDcInc.Location = new Point(17, 30);
            rbDcInc.Name = "rbDcInc";
            rbDcInc.Size = new Size(74, 29);
            rbDcInc.TabIndex = 0;
            rbDcInc.TabStop = true;
            rbDcInc.Tag = "DcInc";
            rbDcInc.Text = "Tăng";
            rbDcInc.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rbIsDeleteDec);
            groupBox6.Controls.Add(rbIsDeleteInc);
            groupBox6.Location = new Point(991, 24);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(140, 108);
            groupBox6.TabIndex = 26;
            groupBox6.TabStop = false;
            groupBox6.Text = "IsDelete";
            // 
            // rbIsDeleteDec
            // 
            rbIsDeleteDec.AutoSize = true;
            rbIsDeleteDec.Location = new Point(17, 65);
            rbIsDeleteDec.Name = "rbIsDeleteDec";
            rbIsDeleteDec.Size = new Size(78, 29);
            rbIsDeleteDec.TabIndex = 1;
            rbIsDeleteDec.TabStop = true;
            rbIsDeleteDec.Tag = "IsDeleteDec";
            rbIsDeleteDec.Text = "Giảm";
            rbIsDeleteDec.UseVisualStyleBackColor = true;
            // 
            // rbIsDeleteInc
            // 
            rbIsDeleteInc.AutoSize = true;
            rbIsDeleteInc.Location = new Point(17, 30);
            rbIsDeleteInc.Name = "rbIsDeleteInc";
            rbIsDeleteInc.Size = new Size(74, 29);
            rbIsDeleteInc.TabIndex = 0;
            rbIsDeleteInc.TabStop = true;
            rbIsDeleteInc.Tag = "IsDeleteInc";
            rbIsDeleteInc.Text = "Tăng";
            rbIsDeleteInc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbIDDec);
            groupBox2.Controls.Add(rbIIDnc);
            groupBox2.Location = new Point(11, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(140, 108);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "ID";
            // 
            // rbIDDec
            // 
            rbIDDec.AutoSize = true;
            rbIDDec.Location = new Point(17, 65);
            rbIDDec.Name = "rbIDDec";
            rbIDDec.Size = new Size(78, 29);
            rbIDDec.TabIndex = 1;
            rbIDDec.TabStop = true;
            rbIDDec.Tag = "IDDec";
            rbIDDec.Text = "Giảm";
            rbIDDec.UseVisualStyleBackColor = true;
            // 
            // rbIIDnc
            // 
            rbIIDnc.AutoSize = true;
            rbIIDnc.Location = new Point(17, 30);
            rbIIDnc.Name = "rbIIDnc";
            rbIIDnc.Size = new Size(74, 29);
            rbIIDnc.TabIndex = 0;
            rbIIDnc.TabStop = true;
            rbIIDnc.Tag = "IDInc";
            rbIIDnc.Text = "Tăng";
            rbIIDnc.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rbSdtDec);
            groupBox4.Controls.Add(rbSdtInc);
            groupBox4.Location = new Point(599, 24);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(140, 108);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "SĐT";
            // 
            // rbSdtDec
            // 
            rbSdtDec.AutoSize = true;
            rbSdtDec.Location = new Point(17, 65);
            rbSdtDec.Name = "rbSdtDec";
            rbSdtDec.Size = new Size(78, 29);
            rbSdtDec.TabIndex = 1;
            rbSdtDec.TabStop = true;
            rbSdtDec.Tag = "SdtDec";
            rbSdtDec.Text = "Giảm";
            rbSdtDec.UseVisualStyleBackColor = true;
            // 
            // rbSdtInc
            // 
            rbSdtInc.AutoSize = true;
            rbSdtInc.Location = new Point(17, 30);
            rbSdtInc.Name = "rbSdtInc";
            rbSdtInc.Size = new Size(74, 29);
            rbSdtInc.TabIndex = 0;
            rbSdtInc.TabStop = true;
            rbSdtInc.Tag = "SdtInc";
            rbSdtInc.Text = "Tăng";
            rbSdtInc.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbNameDec);
            groupBox3.Controls.Add(rbNameInc);
            groupBox3.Location = new Point(207, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(140, 108);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tên";
            // 
            // rbNameDec
            // 
            rbNameDec.AutoSize = true;
            rbNameDec.Location = new Point(17, 65);
            rbNameDec.Name = "rbNameDec";
            rbNameDec.Size = new Size(78, 29);
            rbNameDec.TabIndex = 1;
            rbNameDec.TabStop = true;
            rbNameDec.Tag = "NameDec";
            rbNameDec.Text = "Giảm";
            rbNameDec.UseVisualStyleBackColor = true;
            // 
            // rbNameInc
            // 
            rbNameInc.AutoSize = true;
            rbNameInc.Location = new Point(17, 30);
            rbNameInc.Name = "rbNameInc";
            rbNameInc.Size = new Size(74, 29);
            rbNameInc.TabIndex = 0;
            rbNameInc.TabStop = true;
            rbNameInc.Tag = "NameInc";
            rbNameInc.Text = "Tăng";
            rbNameInc.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(rbEmailDec);
            groupBox7.Controls.Add(rbEmailInc);
            groupBox7.Location = new Point(795, 24);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(140, 108);
            groupBox7.TabIndex = 25;
            groupBox7.TabStop = false;
            groupBox7.Text = "Email";
            // 
            // rbEmailDec
            // 
            rbEmailDec.AutoSize = true;
            rbEmailDec.Location = new Point(17, 65);
            rbEmailDec.Name = "rbEmailDec";
            rbEmailDec.Size = new Size(78, 29);
            rbEmailDec.TabIndex = 1;
            rbEmailDec.TabStop = true;
            rbEmailDec.Tag = "EmailDec";
            rbEmailDec.Text = "Giảm";
            rbEmailDec.UseVisualStyleBackColor = true;
            // 
            // rbEmailInc
            // 
            rbEmailInc.AutoSize = true;
            rbEmailInc.Location = new Point(17, 30);
            rbEmailInc.Name = "rbEmailInc";
            rbEmailInc.Size = new Size(74, 29);
            rbEmailInc.TabIndex = 0;
            rbEmailInc.TabStop = true;
            rbEmailInc.Tag = "EmailInc";
            rbEmailInc.Text = "Tăng";
            rbEmailInc.UseVisualStyleBackColor = true;
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
            filterBtn.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            filterBtn.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            filterBtn.FlatStyle = FlatStyle.Flat;
            filterBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            filterBtn.ForeColor = Color.Goldenrod;
            filterBtn.ImageAlign = ContentAlignment.MiddleRight;
            filterBtn.ImageHover = null;
            filterBtn.Location = new Point(589, 4);
            filterBtn.Margin = new Padding(4, 5, 4, 5);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(172, 64);
            filterBtn.TabIndex = 27;
            filterBtn.Text = "Lọc";
            filterBtn.TextColor = Color.Goldenrod;
            filterBtn.TextHover = Color.White;
            filterBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            filterBtn.UseVisualStyleBackColor = false;
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
            sortBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sortBtn.ForeColor = Color.DeepSkyBlue;
            sortBtn.ImageAlign = ContentAlignment.MiddleRight;
            sortBtn.ImageHover = null;
            sortBtn.Location = new Point(775, 4);
            sortBtn.Margin = new Padding(4, 5, 4, 5);
            sortBtn.Name = "sortBtn";
            sortBtn.Size = new Size(172, 64);
            sortBtn.TabIndex = 26;
            sortBtn.Text = "Sắp xếp";
            sortBtn.TextColor = Color.DeepSkyBlue;
            sortBtn.TextHover = Color.White;
            sortBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            sortBtn.UseVisualStyleBackColor = false;
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
            delBtn.Location = new Point(1333, 4);
            delBtn.Margin = new Padding(4, 5, 4, 5);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(172, 64);
            delBtn.TabIndex = 25;
            delBtn.Text = "  Xóa";
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
            btnEditPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditPN.ForeColor = Color.DarkCyan;
            btnEditPN.Image = Properties.Resources.editIconTeal16px;
            btnEditPN.ImageAlign = ContentAlignment.MiddleRight;
            btnEditPN.ImageHover = Properties.Resources.editIconWhite16px;
            btnEditPN.Location = new Point(1147, 4);
            btnEditPN.Margin = new Padding(4, 5, 4, 5);
            btnEditPN.Name = "btnEditPN";
            btnEditPN.Size = new Size(172, 64);
            btnEditPN.TabIndex = 24;
            btnEditPN.Text = "  Sửa";
            btnEditPN.TextColor = Color.DarkCyan;
            btnEditPN.TextHover = Color.White;
            btnEditPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditPN.UseVisualStyleBackColor = false;
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
            btnAddPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddPN.ForeColor = Color.DarkCyan;
            btnAddPN.Image = Properties.Resources.addIconTeal16px;
            btnAddPN.ImageAlign = ContentAlignment.MiddleRight;
            btnAddPN.ImageHover = Properties.Resources.addIconWhite16px;
            btnAddPN.Location = new Point(961, 4);
            btnAddPN.Margin = new Padding(4, 5, 4, 5);
            btnAddPN.Name = "btnAddPN";
            btnAddPN.Size = new Size(172, 64);
            btnAddPN.TabIndex = 23;
            btnAddPN.Text = "  Thêm";
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.DarkCyan;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvDsNhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvDsNhapHang.ColumnHeadersHeight = 30;
            dgvDsNhapHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvDsNhapHang.DefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDsNhapHang.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvDsNhapHang.RowTemplate.Height = 25;
            dgvDsNhapHang.RowTemplate.ReadOnly = true;
            dgvDsNhapHang.Size = new Size(1522, 543);
            dgvDsNhapHang.TabIndex = 22;
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
            customButton2.Location = new Point(332, 15);
            customButton2.Margin = new Padding(4, 5, 4, 5);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(50, 46);
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
            detailTabPage.Controls.Add(label18);
            detailTabPage.Controls.Add(HuyBtn);
            detailTabPage.Controls.Add(xacNhanBtn);
            detailTabPage.Controls.Add(groupBox1);
            detailTabPage.Controls.Add(dateTimePicker1);
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
            detailTabPage.Controls.Add(label1);
            detailTabPage.Location = new Point(4, 34);
            detailTabPage.Margin = new Padding(4);
            detailTabPage.Name = "detailTabPage";
            detailTabPage.Padding = new Padding(4);
            detailTabPage.Size = new Size(1530, 887);
            detailTabPage.TabIndex = 1;
            detailTabPage.Text = "Chi Tiết";
            detailTabPage.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            HuyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HuyBtn.ForeColor = Color.Red;
            HuyBtn.Image = Properties.Resources.CANCELiconRed;
            HuyBtn.ImageAlign = ContentAlignment.MiddleRight;
            HuyBtn.ImageHover = Properties.Resources.CANCELiconWhite;
            HuyBtn.Location = new Point(1321, 191);
            HuyBtn.Margin = new Padding(4, 5, 4, 5);
            HuyBtn.Name = "HuyBtn";
            HuyBtn.Size = new Size(196, 89);
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
            xacNhanBtn.Location = new Point(1321, 290);
            xacNhanBtn.Margin = new Padding(4, 5, 4, 5);
            xacNhanBtn.Name = "xacNhanBtn";
            xacNhanBtn.Size = new Size(196, 89);
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
            groupBox1.Controls.Add(dgvCTPN);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(4, 403);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1522, 480);
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
            panel1.Controls.Add(btnEditCTPN);
            panel1.Controls.Add(btnAddCTPN);
            panel1.Controls.Add(customButton5);
            panel1.Controls.Add(customTextBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(4, 39);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1514, 108);
            panel1.TabIndex = 24;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(397, 25);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(58, 51);
            label8.TabIndex = 38;
            label8.Text = "Lọc:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(647, 26);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(104, 51);
            label10.TabIndex = 37;
            label10.Text = "Sắp xếp:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox7
            // 
            comboBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(462, 30);
            comboBox7.Margin = new Padding(4, 5, 4, 5);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(176, 44);
            comboBox7.TabIndex = 36;
            // 
            // comboBox8
            // 
            comboBox8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox8.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(758, 30);
            comboBox8.Margin = new Padding(4, 5, 4, 5);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(184, 44);
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
            customButton1.Location = new Point(1336, 19);
            customButton1.Margin = new Padding(4, 5, 4, 5);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(172, 64);
            customButton1.TabIndex = 34;
            customButton1.Text = "  Xóa";
            customButton1.TextColor = Color.Red;
            customButton1.TextHover = Color.White;
            customButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton1.UseVisualStyleBackColor = false;
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
            btnEditCTPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditCTPN.ForeColor = Color.DarkCyan;
            btnEditCTPN.Image = Properties.Resources.editIconTeal16px;
            btnEditCTPN.ImageAlign = ContentAlignment.MiddleRight;
            btnEditCTPN.ImageHover = Properties.Resources.editIconWhite16px;
            btnEditCTPN.Location = new Point(1154, 19);
            btnEditCTPN.Margin = new Padding(4, 5, 4, 5);
            btnEditCTPN.Name = "btnEditCTPN";
            btnEditCTPN.Size = new Size(172, 64);
            btnEditCTPN.TabIndex = 33;
            btnEditCTPN.Text = "  Sửa";
            btnEditCTPN.TextColor = Color.DarkCyan;
            btnEditCTPN.TextHover = Color.White;
            btnEditCTPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditCTPN.UseVisualStyleBackColor = false;
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
            btnAddCTPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCTPN.ForeColor = Color.DarkCyan;
            btnAddCTPN.Image = Properties.Resources.addIconTeal16px;
            btnAddCTPN.ImageAlign = ContentAlignment.MiddleRight;
            btnAddCTPN.ImageHover = Properties.Resources.addIconWhite16px;
            btnAddCTPN.Location = new Point(972, 19);
            btnAddCTPN.Margin = new Padding(4, 5, 4, 5);
            btnAddCTPN.Name = "btnAddCTPN";
            btnAddCTPN.Size = new Size(172, 64);
            btnAddCTPN.TabIndex = 32;
            btnAddCTPN.Text = "  Thêm";
            btnAddCTPN.TextColor = Color.DarkCyan;
            btnAddCTPN.TextHover = Color.White;
            btnAddCTPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddCTPN.UseVisualStyleBackColor = false;
            btnAddCTPN.Click += btn_add2_Click;
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
            customButton5.Location = new Point(330, 30);
            customButton5.Margin = new Padding(4, 5, 4, 5);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(50, 46);
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
            customTextBox1.Location = new Point(8, 24);
            customTextBox1.Margin = new Padding(4, 5, 4, 5);
            customTextBox1.Multiline = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(12, 11, 58, 11);
            customTextBox1.PasswordChar = false;
            customTextBox1.PlaceholderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "Tìm Kiếm ...";
            customTextBox1.Size = new Size(380, 55);
            customTextBox1.TabIndex = 30;
            customTextBox1.Texts = "";
            customTextBox1.UnderlinedStyle = false;
            // 
            // dgvCTPN
            // 
            dgvCTPN.AllowUserToAddRows = false;
            dgvCTPN.AllowUserToDeleteRows = false;
            dgvCTPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTPN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCTPN.BorderStyle = BorderStyle.None;
            dgvCTPN.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.DarkCyan;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.Control;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvCTPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvCTPN.ColumnHeadersHeight = 30;
            dgvCTPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvCTPN.DefaultCellStyle = dataGridViewCellStyle11;
            dgvCTPN.Dock = DockStyle.Fill;
            dgvCTPN.EnableHeadersVisualStyles = false;
            dgvCTPN.GridColor = Color.DarkCyan;
            dgvCTPN.ImeMode = ImeMode.NoControl;
            dgvCTPN.Location = new Point(4, 39);
            dgvCTPN.Margin = new Padding(4, 5, 4, 5);
            dgvCTPN.Name = "dgvCTPN";
            dgvCTPN.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCTPN.RowHeadersVisible = false;
            dgvCTPN.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCTPN.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgvCTPN.RowTemplate.Height = 25;
            dgvCTPN.RowTemplate.ReadOnly = true;
            dgvCTPN.Size = new Size(1514, 437);
            dgvCTPN.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(48, 311);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(428, 42);
            dateTimePicker1.TabIndex = 60;
            // 
            // cbNccName
            // 
            cbNccName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cbNccName.FormattingEnabled = true;
            cbNccName.Location = new Point(910, 311);
            cbNccName.Margin = new Padding(4);
            cbNccName.Name = "cbNccName";
            cbNccName.Size = new Size(348, 44);
            cbNccName.TabIndex = 59;
            // 
            // cbNhanVienId
            // 
            cbNhanVienId.BackColor = Color.White;
            cbNhanVienId.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cbNhanVienId.ForeColor = SystemColors.WindowText;
            cbNhanVienId.FormattingEnabled = true;
            cbNhanVienId.Location = new Point(519, 174);
            cbNhanVienId.Margin = new Padding(4);
            cbNhanVienId.Name = "cbNhanVienId";
            cbNhanVienId.Size = new Size(348, 44);
            cbNhanVienId.TabIndex = 58;
            // 
            // cbNccId
            // 
            cbNccId.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cbNccId.FormattingEnabled = true;
            cbNccId.Items.AddRange(new object[] { "False", "True" });
            cbNccId.Location = new Point(910, 174);
            cbNccId.Margin = new Padding(4);
            cbNccId.Name = "cbNccId";
            cbNccId.Size = new Size(348, 44);
            cbNccId.TabIndex = 57;
            // 
            // cbNhanVienName
            // 
            cbNhanVienName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cbNhanVienName.FormattingEnabled = true;
            cbNhanVienName.Location = new Point(519, 311);
            cbNhanVienName.Margin = new Padding(4);
            cbNhanVienName.Name = "cbNhanVienName";
            cbNhanVienName.Size = new Size(348, 44);
            cbNhanVienName.TabIndex = 56;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(511, 229);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(191, 85);
            label6.TabIndex = 55;
            label6.Text = "Tên Nhân Viên";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
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
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(906, 89);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(216, 85);
            label3.TabIndex = 33;
            label3.Text = "ID Nhà Cung Cấp";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // M
            // 
            M.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            M.Location = new Point(494, 91);
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
            txtPhieuNhapId.BorderFocusColor = Color.DarkCyan;
            txtPhieuNhapId.BorderRadius = 13;
            txtPhieuNhapId.BorderSize = 2;
            txtPhieuNhapId.Enabled = false;
            txtPhieuNhapId.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhieuNhapId.ForeColor = Color.DimGray;
            txtPhieuNhapId.Location = new Point(48, 156);
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
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 242);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(158, 85);
            label5.TabIndex = 27;
            label5.Text = "Ngày Nhập";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(906, 229);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(238, 85);
            label4.TabIndex = 26;
            label4.Text = "Tên Nhà Cung Cấp";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 85);
            label1.TabIndex = 25;
            label1.Text = "ID Phiếu Nhập";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // moreDetailTabPage
            // 
            moreDetailTabPage.Controls.Add(btnHuyCTPN);
            moreDetailTabPage.Controls.Add(btnXacNhanCTPN);
            moreDetailTabPage.Controls.Add(txtCTPNDonGia);
            moreDetailTabPage.Controls.Add(label13);
            moreDetailTabPage.Controls.Add(txtCTPNKhoiLuong);
            moreDetailTabPage.Controls.Add(comboBox10);
            moreDetailTabPage.Controls.Add(comboBox12);
            moreDetailTabPage.Controls.Add(label12);
            moreDetailTabPage.Controls.Add(label14);
            moreDetailTabPage.Controls.Add(txtCTPNId);
            moreDetailTabPage.Controls.Add(label15);
            moreDetailTabPage.Controls.Add(label17);
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
            btnHuyCTPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuyCTPN.ForeColor = Color.Red;
            btnHuyCTPN.Image = Properties.Resources.CANCELiconRed;
            btnHuyCTPN.ImageAlign = ContentAlignment.MiddleRight;
            btnHuyCTPN.ImageHover = Properties.Resources.CANCELiconWhite;
            btnHuyCTPN.Location = new Point(1300, 759);
            btnHuyCTPN.Margin = new Padding(4, 5, 4, 5);
            btnHuyCTPN.Name = "btnHuyCTPN";
            btnHuyCTPN.Size = new Size(196, 89);
            btnHuyCTPN.TabIndex = 75;
            btnHuyCTPN.Text = "  Hủy";
            btnHuyCTPN.TextColor = Color.Red;
            btnHuyCTPN.TextHover = Color.White;
            btnHuyCTPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHuyCTPN.UseVisualStyleBackColor = false;
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
            btnXacNhanCTPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacNhanCTPN.ForeColor = Color.DarkCyan;
            btnXacNhanCTPN.Image = Properties.Resources.ConfirmIcondarkcyan1;
            btnXacNhanCTPN.ImageAlign = ContentAlignment.MiddleRight;
            btnXacNhanCTPN.ImageHover = Properties.Resources.ConfirmIconWhite1;
            btnXacNhanCTPN.Location = new Point(1081, 759);
            btnXacNhanCTPN.Margin = new Padding(4, 5, 4, 5);
            btnXacNhanCTPN.Name = "btnXacNhanCTPN";
            btnXacNhanCTPN.Size = new Size(196, 89);
            btnXacNhanCTPN.TabIndex = 74;
            btnXacNhanCTPN.Text = "  Xác Nhận";
            btnXacNhanCTPN.TextColor = Color.DarkCyan;
            btnXacNhanCTPN.TextHover = Color.White;
            btnXacNhanCTPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXacNhanCTPN.UseVisualStyleBackColor = false;
            // 
            // txtCTPNDonGia
            // 
            txtCTPNDonGia.BackColor = SystemColors.Window;
            txtCTPNDonGia.BorderColor = Color.Silver;
            txtCTPNDonGia.BorderFocusColor = Color.DarkCyan;
            txtCTPNDonGia.BorderRadius = 13;
            txtCTPNDonGia.BorderSize = 2;
            txtCTPNDonGia.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
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
            txtCTPNDonGia.TabIndex = 73;
            txtCTPNDonGia.Texts = "";
            txtCTPNDonGia.UnderlinedStyle = false;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            txtCTPNKhoiLuong.BorderFocusColor = Color.DarkCyan;
            txtCTPNKhoiLuong.BorderRadius = 13;
            txtCTPNKhoiLuong.BorderSize = 2;
            txtCTPNKhoiLuong.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
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
            txtCTPNKhoiLuong.TabIndex = 71;
            txtCTPNKhoiLuong.Texts = "";
            txtCTPNKhoiLuong.UnderlinedStyle = false;
            // 
            // comboBox10
            // 
            comboBox10.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox10.FormattingEnabled = true;
            comboBox10.Location = new Point(536, 169);
            comboBox10.Margin = new Padding(4);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(348, 44);
            comboBox10.TabIndex = 70;
            // 
            // comboBox12
            // 
            comboBox12.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox12.FormattingEnabled = true;
            comboBox12.Location = new Point(536, 306);
            comboBox12.Margin = new Padding(4);
            comboBox12.Name = "comboBox12";
            comboBox12.Size = new Size(348, 44);
            comboBox12.TabIndex = 68;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            txtCTPNId.BackColor = SystemColors.Window;
            txtCTPNId.BorderColor = Color.Silver;
            txtCTPNId.BorderFocusColor = Color.DarkCyan;
            txtCTPNId.BorderRadius = 13;
            txtCTPNId.BorderSize = 2;
            txtCTPNId.Enabled = false;
            txtCTPNId.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
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
            txtCTPNId.TabIndex = 64;
            txtCTPNId.Texts = "";
            txtCTPNId.UnderlinedStyle = false;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(38, 220);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(200, 85);
            label15.TabIndex = 63;
            label15.Text = "Khối Lượng (Kg)";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(41, 88);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(196, 85);
            label17.TabIndex = 61;
            label17.Text = "ID Phiếu Nhập";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
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
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
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
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).EndInit();
            moreDetailTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcNhapHang;
        private TabPage listTabPage;
        private DataGridView dgvDsNhapHang;
        private CustomControl.CustomButton customButton2;
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
        private Label label1;
        private CustomControl.CustomButton delBtn;
        private CustomControl.CustomButton btnEditPN;
        private CustomControl.CustomButton btnAddPN;
        private ComboBox cbNccName;
        private ComboBox cbNhanVienId;
        private ComboBox cbNccId;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private DataGridView dgvCTPN;
        private CustomControl.CustomButton xacNhanBtn;
        private CustomControl.CustomButton HuyBtn;
        private Panel panel1;
        private Label label8;
        private Label label10;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private CustomControl.CustomButton customButton1;
        private CustomControl.CustomButton btnEditCTPN;
        private CustomControl.CustomButton btnAddCTPN;
        private CustomControl.CustomButton customButton5;
        private CustomControl.CustomTextBox customTextBox1;
        private TabPage moreDetailTabPage;
        private Label label11;
        private CustomControl.CustomButton btn_back2;
        private ComboBox comboBox10;
        private ComboBox comboBox12;
        private Label label12;
        private Label label14;
        private CustomControl.CustomTextBox txtCTPNId;
        private Label label15;
        private Label label17;
        private Label label18;
        private CustomControl.CustomTextBox txtCTPNDonGia;
        private Label label13;
        private CustomControl.CustomTextBox txtCTPNKhoiLuong;
        private CustomControl.CustomButton btnHuyCTPN;
        private CustomControl.CustomButton btnXacNhanCTPN;
        private CustomControl.CustomButton filterBtn;
        private CustomControl.CustomButton sortBtn;
        private CustomControl.CustomButton resetBtn;
        private GroupBox gbSort;
        private GroupBox groupBox5;
        private RadioButton rbDcDec;
        private RadioButton rbDcInc;
        private GroupBox groupBox6;
        private RadioButton rbIsDeleteDec;
        private RadioButton rbIsDeleteInc;
        private GroupBox groupBox2;
        private RadioButton rbIDDec;
        private RadioButton rbIIDnc;
        private GroupBox groupBox4;
        private RadioButton rbSdtDec;
        private RadioButton rbSdtInc;
        private GroupBox groupBox3;
        private RadioButton rbNameDec;
        private RadioButton rbNameInc;
        private GroupBox groupBox7;
        private RadioButton rbEmailDec;
        private RadioButton rbEmailInc;
    }
}