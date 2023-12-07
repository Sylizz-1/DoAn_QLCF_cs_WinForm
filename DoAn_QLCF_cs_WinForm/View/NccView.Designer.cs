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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            tcNCC = new TabControl();
            listTabPage = new TabPage();
            btnFindNcc = new CustomControl.CustomButton();
            resetBtn = new CustomControl.CustomButton();
            gbSort = new GroupBox();
            groupBox5 = new GroupBox();
            rbDcDec = new RadioButton();
            rbDcInc = new RadioButton();
            groupBox6 = new GroupBox();
            rbIsDeleteDec = new RadioButton();
            rbIsDeleteInc = new RadioButton();
            groupBox1 = new GroupBox();
            rbIDDec = new RadioButton();
            rbIIDnc = new RadioButton();
            groupBox4 = new GroupBox();
            rbSdtDec = new RadioButton();
            rbSdtInc = new RadioButton();
            groupBox2 = new GroupBox();
            rbNameDec = new RadioButton();
            rbNameInc = new RadioButton();
            groupBox3 = new GroupBox();
            rbEmailDec = new RadioButton();
            rbEmailInc = new RadioButton();
            filterNccBtn = new CustomControl.CustomButton();
            sortNccBtn = new CustomControl.CustomButton();
            dgvNcc = new DataGridView();
            searchTxt = new CustomControl.CustomTextBox();
            delNccBtn = new CustomControl.CustomButton();
            editNccBtn = new CustomControl.CustomButton();
            addNccBtn = new CustomControl.CustomButton();
            detailTabPage = new TabPage();
            checkboxIsDelete = new CheckBox();
            lbIsDelete = new Label();
            HuyNccBtn = new CustomControl.CustomButton();
            xacNhanNccBtn = new CustomControl.CustomButton();
            txtSDTNcc = new CustomControl.CustomTextBox();
            label3 = new Label();
            txtDiaChiNcc = new CustomControl.CustomTextBox();
            M = new Label();
            label7 = new Label();
            btnNcc_back = new CustomControl.CustomButton();
            txtIdNcc = new CustomControl.CustomTextBox();
            txtEmailNcc = new CustomControl.CustomTextBox();
            txtTenNcc = new CustomControl.CustomTextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            tcNCC.SuspendLayout();
            listTabPage.SuspendLayout();
            gbSort.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            listTabPage.Controls.Add(btnFindNcc);
            listTabPage.Controls.Add(resetBtn);
            listTabPage.Controls.Add(gbSort);
            listTabPage.Controls.Add(filterNccBtn);
            listTabPage.Controls.Add(sortNccBtn);
            listTabPage.Controls.Add(dgvNcc);
            listTabPage.Controls.Add(searchTxt);
            listTabPage.Controls.Add(delNccBtn);
            listTabPage.Controls.Add(editNccBtn);
            listTabPage.Controls.Add(addNccBtn);
            listTabPage.Location = new Point(4, 34);
            listTabPage.Margin = new Padding(4);
            listTabPage.Name = "listTabPage";
            listTabPage.Padding = new Padding(4);
            listTabPage.Size = new Size(1507, 828);
            listTabPage.TabIndex = 0;
            listTabPage.Text = "Danh Sách";
            listTabPage.UseVisualStyleBackColor = true;
            // 
            // btnFindNcc
            // 
            btnFindNcc.BackColor = Color.Transparent;
            btnFindNcc.BackgroundColor = Color.Transparent;
            btnFindNcc.BorderColor = Color.PaleVioletRed;
            btnFindNcc.BorderRadius = 15;
            btnFindNcc.BorderSize = 0;
            btnFindNcc.Cursor = Cursors.Hand;
            btnFindNcc.EnabledTextHover = false;
            btnFindNcc.FlatAppearance.BorderSize = 0;
            btnFindNcc.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 64, 64, 64);
            btnFindNcc.FlatStyle = FlatStyle.Flat;
            btnFindNcc.ForeColor = Color.White;
            btnFindNcc.Image = Properties.Resources.findIcon16px;
            btnFindNcc.ImageHover = null;
            btnFindNcc.Location = new Point(331, 20);
            btnFindNcc.Margin = new Padding(4, 5, 4, 5);
            btnFindNcc.Name = "btnFindNcc";
            btnFindNcc.Size = new Size(40, 40);
            btnFindNcc.TabIndex = 29;
            btnFindNcc.TextColor = Color.White;
            btnFindNcc.TextHover = Color.White;
            btnFindNcc.UseVisualStyleBackColor = false;
            btnFindNcc.Click += btnFindNcc_Click;
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
            resetBtn.Location = new Point(1315, 174);
            resetBtn.Margin = new Padding(4, 5, 4, 5);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(172, 64);
            resetBtn.TabIndex = 28;
            resetBtn.Text = "Reset";
            resetBtn.TextColor = Color.DarkGray;
            resetBtn.TextHover = Color.White;
            resetBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // gbSort
            // 
            gbSort.Controls.Add(groupBox5);
            gbSort.Controls.Add(groupBox6);
            gbSort.Controls.Add(groupBox1);
            gbSort.Controls.Add(groupBox4);
            gbSort.Controls.Add(groupBox2);
            gbSort.Controls.Add(groupBox3);
            gbSort.Location = new Point(34, 120);
            gbSort.Name = "gbSort";
            gbSort.Size = new Size(1148, 150);
            gbSort.TabIndex = 27;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(rbIDDec);
            groupBox1.Controls.Add(rbIIDnc);
            groupBox1.Location = new Point(11, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(140, 108);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "ID";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(rbNameDec);
            groupBox2.Controls.Add(rbNameInc);
            groupBox2.Location = new Point(207, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(140, 108);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tên";
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
            // groupBox3
            // 
            groupBox3.Controls.Add(rbEmailDec);
            groupBox3.Controls.Add(rbEmailInc);
            groupBox3.Location = new Point(795, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(140, 108);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Email";
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
            // filterNccBtn
            // 
            filterNccBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterNccBtn.BackColor = SystemColors.Control;
            filterNccBtn.BackgroundColor = SystemColors.Control;
            filterNccBtn.BorderColor = Color.Goldenrod;
            filterNccBtn.BorderRadius = 15;
            filterNccBtn.BorderSize = 2;
            filterNccBtn.Cursor = Cursors.Hand;
            filterNccBtn.EnabledTextHover = true;
            filterNccBtn.FlatAppearance.BorderSize = 0;
            filterNccBtn.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            filterNccBtn.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            filterNccBtn.FlatStyle = FlatStyle.Flat;
            filterNccBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            filterNccBtn.ForeColor = Color.Goldenrod;
            filterNccBtn.ImageAlign = ContentAlignment.MiddleRight;
            filterNccBtn.ImageHover = null;
            filterNccBtn.Location = new Point(552, 9);
            filterNccBtn.Margin = new Padding(4, 5, 4, 5);
            filterNccBtn.Name = "filterNccBtn";
            filterNccBtn.Size = new Size(172, 64);
            filterNccBtn.TabIndex = 22;
            filterNccBtn.Text = "Lọc";
            filterNccBtn.TextColor = Color.Goldenrod;
            filterNccBtn.TextHover = Color.White;
            filterNccBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            filterNccBtn.UseVisualStyleBackColor = false;
            filterNccBtn.Click += filterNccBtn_Click;
            // 
            // sortNccBtn
            // 
            sortNccBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sortNccBtn.BackColor = SystemColors.Control;
            sortNccBtn.BackgroundColor = SystemColors.Control;
            sortNccBtn.BorderColor = Color.DeepSkyBlue;
            sortNccBtn.BorderRadius = 15;
            sortNccBtn.BorderSize = 2;
            sortNccBtn.Cursor = Cursors.Hand;
            sortNccBtn.EnabledTextHover = true;
            sortNccBtn.FlatAppearance.BorderSize = 0;
            sortNccBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            sortNccBtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            sortNccBtn.FlatStyle = FlatStyle.Flat;
            sortNccBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sortNccBtn.ForeColor = Color.DeepSkyBlue;
            sortNccBtn.ImageAlign = ContentAlignment.MiddleRight;
            sortNccBtn.ImageHover = null;
            sortNccBtn.Location = new Point(742, 9);
            sortNccBtn.Margin = new Padding(4, 5, 4, 5);
            sortNccBtn.Name = "sortNccBtn";
            sortNccBtn.Size = new Size(172, 64);
            sortNccBtn.TabIndex = 21;
            sortNccBtn.Text = "Sắp xếp";
            sortNccBtn.TextColor = Color.DeepSkyBlue;
            sortNccBtn.TextHover = Color.White;
            sortNccBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            sortNccBtn.UseVisualStyleBackColor = false;
            sortNccBtn.Click += sortNccBtn_Click;
            // 
            // dgvNcc
            // 
            dgvNcc.AllowUserToAddRows = false;
            dgvNcc.AllowUserToDeleteRows = false;
            dgvNcc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNcc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNcc.BorderStyle = BorderStyle.None;
            dgvNcc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.DarkCyan;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvNcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvNcc.ColumnHeadersHeight = 30;
            dgvNcc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvNcc.DefaultCellStyle = dataGridViewCellStyle8;
            dgvNcc.Dock = DockStyle.Bottom;
            dgvNcc.EnableHeadersVisualStyles = false;
            dgvNcc.GridColor = Color.DarkCyan;
            dgvNcc.ImeMode = ImeMode.NoControl;
            dgvNcc.Location = new Point(4, 326);
            dgvNcc.Margin = new Padding(4, 5, 4, 5);
            dgvNcc.Name = "dgvNcc";
            dgvNcc.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvNcc.RowHeadersVisible = false;
            dgvNcc.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNcc.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvNcc.RowTemplate.Height = 25;
            dgvNcc.RowTemplate.ReadOnly = true;
            dgvNcc.Size = new Size(1499, 498);
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
            // delNccBtn
            // 
            delNccBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            delNccBtn.BackColor = SystemColors.Control;
            delNccBtn.BackgroundColor = SystemColors.Control;
            delNccBtn.BorderColor = Color.Red;
            delNccBtn.BorderRadius = 15;
            delNccBtn.BorderSize = 2;
            delNccBtn.Cursor = Cursors.Hand;
            delNccBtn.EnabledTextHover = true;
            delNccBtn.FlatAppearance.BorderSize = 0;
            delNccBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            delNccBtn.FlatAppearance.MouseOverBackColor = Color.Red;
            delNccBtn.FlatStyle = FlatStyle.Flat;
            delNccBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delNccBtn.ForeColor = Color.Red;
            delNccBtn.Image = Properties.Resources.deleteIconRed16px;
            delNccBtn.ImageAlign = ContentAlignment.MiddleRight;
            delNccBtn.ImageHover = Properties.Resources.deleteIconWhite16px;
            delNccBtn.Location = new Point(1312, 9);
            delNccBtn.Margin = new Padding(4, 5, 4, 5);
            delNccBtn.Name = "delNccBtn";
            delNccBtn.Size = new Size(172, 64);
            delNccBtn.TabIndex = 13;
            delNccBtn.Text = "  Xóa";
            delNccBtn.TextColor = Color.Red;
            delNccBtn.TextHover = Color.White;
            delNccBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            delNccBtn.UseVisualStyleBackColor = false;
            // 
            // editNccBtn
            // 
            editNccBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editNccBtn.BackColor = SystemColors.Control;
            editNccBtn.BackgroundColor = SystemColors.Control;
            editNccBtn.BorderColor = Color.DarkCyan;
            editNccBtn.BorderRadius = 15;
            editNccBtn.BorderSize = 2;
            editNccBtn.Cursor = Cursors.Hand;
            editNccBtn.EnabledTextHover = true;
            editNccBtn.FlatAppearance.BorderSize = 0;
            editNccBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            editNccBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            editNccBtn.FlatStyle = FlatStyle.Flat;
            editNccBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editNccBtn.ForeColor = Color.DarkCyan;
            editNccBtn.Image = Properties.Resources.editIconTeal16px;
            editNccBtn.ImageAlign = ContentAlignment.MiddleRight;
            editNccBtn.ImageHover = Properties.Resources.editIconWhite16px;
            editNccBtn.Location = new Point(1122, 9);
            editNccBtn.Margin = new Padding(4, 5, 4, 5);
            editNccBtn.Name = "editNccBtn";
            editNccBtn.Size = new Size(172, 64);
            editNccBtn.TabIndex = 12;
            editNccBtn.Text = "  Sửa";
            editNccBtn.TextColor = Color.DarkCyan;
            editNccBtn.TextHover = Color.White;
            editNccBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            editNccBtn.UseVisualStyleBackColor = false;
            editNccBtn.Click += editNccBtn_Click;
            // 
            // addNccBtn
            // 
            addNccBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addNccBtn.BackColor = SystemColors.Control;
            addNccBtn.BackgroundColor = SystemColors.Control;
            addNccBtn.BorderColor = Color.DarkCyan;
            addNccBtn.BorderRadius = 15;
            addNccBtn.BorderSize = 2;
            addNccBtn.Cursor = Cursors.Hand;
            addNccBtn.EnabledTextHover = true;
            addNccBtn.FlatAppearance.BorderSize = 0;
            addNccBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            addNccBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            addNccBtn.FlatStyle = FlatStyle.Flat;
            addNccBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addNccBtn.ForeColor = Color.DarkCyan;
            addNccBtn.Image = Properties.Resources.addIconTeal16px;
            addNccBtn.ImageAlign = ContentAlignment.MiddleRight;
            addNccBtn.ImageHover = Properties.Resources.addIconWhite16px;
            addNccBtn.Location = new Point(932, 9);
            addNccBtn.Margin = new Padding(4, 5, 4, 5);
            addNccBtn.Name = "addNccBtn";
            addNccBtn.Size = new Size(172, 64);
            addNccBtn.TabIndex = 11;
            addNccBtn.Text = "  Thêm";
            addNccBtn.TextColor = Color.DarkCyan;
            addNccBtn.TextHover = Color.White;
            addNccBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addNccBtn.UseVisualStyleBackColor = false;
            addNccBtn.Click += addNccBtn_Click;
            // 
            // detailTabPage
            // 
            detailTabPage.Controls.Add(checkboxIsDelete);
            detailTabPage.Controls.Add(lbIsDelete);
            detailTabPage.Controls.Add(HuyNccBtn);
            detailTabPage.Controls.Add(xacNhanNccBtn);
            detailTabPage.Controls.Add(txtSDTNcc);
            detailTabPage.Controls.Add(label3);
            detailTabPage.Controls.Add(txtDiaChiNcc);
            detailTabPage.Controls.Add(M);
            detailTabPage.Controls.Add(label7);
            detailTabPage.Controls.Add(btnNcc_back);
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
            // checkboxIsDelete
            // 
            checkboxIsDelete.AutoSize = true;
            checkboxIsDelete.Location = new Point(1047, 304);
            checkboxIsDelete.Name = "checkboxIsDelete";
            checkboxIsDelete.Size = new Size(22, 21);
            checkboxIsDelete.TabIndex = 57;
            checkboxIsDelete.UseVisualStyleBackColor = true;
            // 
            // lbIsDelete
            // 
            lbIsDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbIsDelete.Location = new Point(914, 273);
            lbIsDelete.Margin = new Padding(4, 0, 4, 0);
            lbIsDelete.Name = "lbIsDelete";
            lbIsDelete.Size = new Size(112, 85);
            lbIsDelete.TabIndex = 56;
            lbIsDelete.Text = "IsDelete";
            lbIsDelete.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HuyNccBtn
            // 
            HuyNccBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            HuyNccBtn.BackColor = SystemColors.Control;
            HuyNccBtn.BackgroundColor = SystemColors.Control;
            HuyNccBtn.BorderColor = Color.Red;
            HuyNccBtn.BorderRadius = 15;
            HuyNccBtn.BorderSize = 2;
            HuyNccBtn.Cursor = Cursors.Hand;
            HuyNccBtn.EnabledTextHover = true;
            HuyNccBtn.FlatAppearance.BorderSize = 0;
            HuyNccBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            HuyNccBtn.FlatAppearance.MouseOverBackColor = Color.Red;
            HuyNccBtn.FlatStyle = FlatStyle.Flat;
            HuyNccBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HuyNccBtn.ForeColor = Color.Red;
            HuyNccBtn.Image = Properties.Resources.CANCELiconRed;
            HuyNccBtn.ImageAlign = ContentAlignment.MiddleRight;
            HuyNccBtn.ImageHover = Properties.Resources.CANCELiconWhite;
            HuyNccBtn.Location = new Point(1280, 689);
            HuyNccBtn.Margin = new Padding(4, 5, 4, 5);
            HuyNccBtn.Name = "HuyNccBtn";
            HuyNccBtn.Size = new Size(196, 89);
            HuyNccBtn.TabIndex = 42;
            HuyNccBtn.Text = "  Hủy";
            HuyNccBtn.TextColor = Color.Red;
            HuyNccBtn.TextHover = Color.White;
            HuyNccBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            HuyNccBtn.UseVisualStyleBackColor = false;
            HuyNccBtn.Click += HuyNccBtn_Click;
            // 
            // xacNhanNccBtn
            // 
            xacNhanNccBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            xacNhanNccBtn.BackColor = SystemColors.Control;
            xacNhanNccBtn.BackgroundColor = SystemColors.Control;
            xacNhanNccBtn.BorderColor = Color.DarkCyan;
            xacNhanNccBtn.BorderRadius = 15;
            xacNhanNccBtn.BorderSize = 2;
            xacNhanNccBtn.Cursor = Cursors.Hand;
            xacNhanNccBtn.EnabledTextHover = true;
            xacNhanNccBtn.FlatAppearance.BorderSize = 0;
            xacNhanNccBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            xacNhanNccBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            xacNhanNccBtn.FlatStyle = FlatStyle.Flat;
            xacNhanNccBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            xacNhanNccBtn.ForeColor = Color.DarkCyan;
            xacNhanNccBtn.Image = Properties.Resources.ConfirmIcondarkcyan1;
            xacNhanNccBtn.ImageAlign = ContentAlignment.MiddleRight;
            xacNhanNccBtn.ImageHover = Properties.Resources.ConfirmIconWhite1;
            xacNhanNccBtn.Location = new Point(1061, 689);
            xacNhanNccBtn.Margin = new Padding(4, 5, 4, 5);
            xacNhanNccBtn.Name = "xacNhanNccBtn";
            xacNhanNccBtn.Size = new Size(196, 89);
            xacNhanNccBtn.TabIndex = 41;
            xacNhanNccBtn.Text = "  Xác Nhận";
            xacNhanNccBtn.TextColor = Color.DarkCyan;
            xacNhanNccBtn.TextHover = Color.White;
            xacNhanNccBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            xacNhanNccBtn.UseVisualStyleBackColor = false;
            xacNhanNccBtn.Click += xacNhanNccBtn_Click;
            // 
            // txtSDTNcc
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
            txtSDTNcc.TabIndex = 3;
            txtSDTNcc.Texts = "";
            txtSDTNcc.UnderlinedStyle = false;
            txtSDTNcc._TextChanged += txtSDTNcc__TextChanged;
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
            txtDiaChiNcc.TabIndex = 1;
            txtDiaChiNcc.Texts = "";
            txtDiaChiNcc.UnderlinedStyle = false;
            txtDiaChiNcc._TextChanged += txtDiaChiNcc__TextChanged;
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
            // btnNcc_back
            // 
            btnNcc_back.BackColor = Color.Transparent;
            btnNcc_back.BackgroundColor = Color.Transparent;
            btnNcc_back.BorderColor = Color.PaleVioletRed;
            btnNcc_back.BorderRadius = 20;
            btnNcc_back.BorderSize = 0;
            btnNcc_back.Cursor = Cursors.Hand;
            btnNcc_back.EnabledTextHover = false;
            btnNcc_back.FlatAppearance.BorderSize = 0;
            btnNcc_back.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnNcc_back.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnNcc_back.FlatStyle = FlatStyle.Flat;
            btnNcc_back.ForeColor = Color.White;
            btnNcc_back.Image = Properties.Resources.arrowreturn32pxBlack1;
            btnNcc_back.ImageHover = Properties.Resources.arrowreturn32pxWhite1;
            btnNcc_back.Location = new Point(28, 25);
            btnNcc_back.Margin = new Padding(4, 5, 4, 5);
            btnNcc_back.Name = "btnNcc_back";
            btnNcc_back.Size = new Size(90, 69);
            btnNcc_back.TabIndex = 31;
            btnNcc_back.TextColor = Color.White;
            btnNcc_back.TextHover = Color.White;
            btnNcc_back.UseVisualStyleBackColor = false;
            btnNcc_back.Click += btnNcc_back_Click;
            // 
            // txtIdNcc
            // 
            txtIdNcc.BackColor = Color.White;
            txtIdNcc.BorderColor = Color.Silver;
            txtIdNcc.BorderFocusColor = Color.DeepSkyBlue;
            txtIdNcc.BorderRadius = 13;
            txtIdNcc.BorderSize = 2;
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
            // txtEmailNcc
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
            txtEmailNcc.TabIndex = 2;
            txtEmailNcc.Texts = "";
            txtEmailNcc.UnderlinedStyle = false;
            txtEmailNcc._TextChanged += txtEmailNcc__TextChanged;
            // 
            // txtTenNcc
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
            txtTenNcc.TabIndex = 0;
            txtTenNcc.Texts = "";
            txtTenNcc.UnderlinedStyle = false;
            txtTenNcc._TextChanged += txtTenNcc__TextChanged;
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
            label4.Location = new Point(478, 220);
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
            gbSort.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNcc).EndInit();
            detailTabPage.ResumeLayout(false);
            detailTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcNCC;
        private TabPage listTabPage;
        private TabPage detailTabPage;
        private CustomControl.CustomButton delNccBtn;
        private CustomControl.CustomButton editNccBtn;
        private CustomControl.CustomButton addNccBtn;
        private CustomControl.CustomTextBox searchTxt;
        private DataGridView dgvNcc;
        private CustomControl.CustomTextBox txtSDTNcc;
        private Label label3;
        private CustomControl.CustomTextBox txtDiaChiNcc;
        private Label M;
        private Label label7;
        private CustomControl.CustomButton btnNcc_back;
        private CustomControl.CustomTextBox txtIdNcc;
        private CustomControl.CustomTextBox txtEmailNcc;
        private CustomControl.CustomTextBox txtTenNcc;
        private Label label5;
        private Label label4;
        private Label label1;
        private CustomControl.CustomButton HuyNccBtn;
        private CustomControl.CustomButton xacNhanNccBtn;
        private Label lbIsDelete;
        private CheckBox checkboxIsDelete;
        private CustomControl.CustomButton filterNccBtn;
        private CustomControl.CustomButton sortNccBtn;
        private GroupBox groupBox1;
        private RadioButton rbIDDec;
        private RadioButton rbIIDnc;
        private GroupBox groupBox2;
        private RadioButton rbNameDec;
        private RadioButton rbNameInc;
        private GroupBox groupBox4;
        private RadioButton rbSdtDec;
        private RadioButton rbSdtInc;
        private GroupBox groupBox5;
        private RadioButton rbDcDec;
        private RadioButton rbDcInc;
        private GroupBox groupBox3;
        private RadioButton rbEmailDec;
        private RadioButton rbEmailInc;
        private GroupBox groupBox6;
        private RadioButton rbIsDeleteDec;
        private RadioButton rbIsDeleteInc;
        private GroupBox gbSort;
        private CustomControl.CustomButton resetBtn;
        private CustomControl.CustomButton btnFindNcc;
    }
}