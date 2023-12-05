namespace DoAn_QLCF_cs_WinForm.View
{
    partial class NguyenLieuView
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
            tcNgl = new TabControl();
            listTabPage = new TabPage();
            gbSort = new GroupBox();
            groupBox5 = new GroupBox();
            rbInfoDec = new RadioButton();
            rbInfoInc = new RadioButton();
            groupBox6 = new GroupBox();
            rbIsDeleteDec = new RadioButton();
            rbIsDeleteInc = new RadioButton();
            groupBox1 = new GroupBox();
            rbIDDec = new RadioButton();
            rbIIDnc = new RadioButton();
            groupBox4 = new GroupBox();
            rbKlgDec = new RadioButton();
            rbKlgInc = new RadioButton();
            groupBox2 = new GroupBox();
            rbNameDec = new RadioButton();
            rbNameInc = new RadioButton();
            groupBox3 = new GroupBox();
            rbPriceDec = new RadioButton();
            rbPriceInc = new RadioButton();
            resetBtn = new CustomControl.CustomButton();
            filterBtn = new CustomControl.CustomButton();
            sortBtn = new CustomControl.CustomButton();
            dgvNgl = new DataGridView();
            customButton2 = new CustomControl.CustomButton();
            delBtn = new CustomControl.CustomButton();
            editBtn = new CustomControl.CustomButton();
            addBtn = new CustomControl.CustomButton();
            searchTxt = new CustomControl.CustomTextBox();
            detailTabPage = new TabPage();
            checkboxIsDelete = new CheckBox();
            label6 = new Label();
            HuyBtn = new CustomControl.CustomButton();
            xacNhanBtn = new CustomControl.CustomButton();
            label7 = new Label();
            btn_back = new CustomControl.CustomButton();
            caPhePic = new PictureBox();
            label8 = new Label();
            txtNglPrice = new CustomControl.CustomTextBox();
            label3 = new Label();
            txtNglInfo = new CustomControl.CustomTextBox();
            M = new Label();
            txtNglId = new CustomControl.CustomTextBox();
            txtNglWeigh = new CustomControl.CustomTextBox();
            txtNglName = new CustomControl.CustomTextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            tcNgl.SuspendLayout();
            listTabPage.SuspendLayout();
            gbSort.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNgl).BeginInit();
            detailTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)caPhePic).BeginInit();
            SuspendLayout();
            // 
            // tcNgl
            // 
            tcNgl.Controls.Add(listTabPage);
            tcNgl.Controls.Add(detailTabPage);
            tcNgl.Dock = DockStyle.Fill;
            tcNgl.Location = new Point(0, 0);
            tcNgl.Margin = new Padding(4);
            tcNgl.Name = "tcNgl";
            tcNgl.SelectedIndex = 0;
            tcNgl.Size = new Size(1538, 925);
            tcNgl.TabIndex = 0;
            // 
            // listTabPage
            // 
            listTabPage.Controls.Add(gbSort);
            listTabPage.Controls.Add(resetBtn);
            listTabPage.Controls.Add(filterBtn);
            listTabPage.Controls.Add(sortBtn);
            listTabPage.Controls.Add(dgvNgl);
            listTabPage.Controls.Add(customButton2);
            listTabPage.Controls.Add(delBtn);
            listTabPage.Controls.Add(editBtn);
            listTabPage.Controls.Add(addBtn);
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
            gbSort.TabIndex = 30;
            gbSort.TabStop = false;
            gbSort.Visible = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rbInfoDec);
            groupBox5.Controls.Add(rbInfoInc);
            groupBox5.Location = new Point(403, 24);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(140, 108);
            groupBox5.TabIndex = 24;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông tin";
            // 
            // rbInfoDec
            // 
            rbInfoDec.AutoSize = true;
            rbInfoDec.Location = new Point(17, 65);
            rbInfoDec.Name = "rbInfoDec";
            rbInfoDec.Size = new Size(78, 29);
            rbInfoDec.TabIndex = 1;
            rbInfoDec.TabStop = true;
            rbInfoDec.Tag = "InfoDec";
            rbInfoDec.Text = "Giảm";
            rbInfoDec.UseVisualStyleBackColor = true;
            // 
            // rbInfoInc
            // 
            rbInfoInc.AutoSize = true;
            rbInfoInc.Location = new Point(17, 30);
            rbInfoInc.Name = "rbInfoInc";
            rbInfoInc.Size = new Size(74, 29);
            rbInfoInc.TabIndex = 0;
            rbInfoInc.TabStop = true;
            rbInfoInc.Tag = "InfoInc";
            rbInfoInc.Text = "Tăng";
            rbInfoInc.UseVisualStyleBackColor = true;
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
            groupBox4.Controls.Add(rbKlgDec);
            groupBox4.Controls.Add(rbKlgInc);
            groupBox4.Location = new Point(599, 24);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(140, 108);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Khối lượng";
            // 
            // rbKlgDec
            // 
            rbKlgDec.AutoSize = true;
            rbKlgDec.Location = new Point(17, 65);
            rbKlgDec.Name = "rbKlgDec";
            rbKlgDec.Size = new Size(78, 29);
            rbKlgDec.TabIndex = 1;
            rbKlgDec.TabStop = true;
            rbKlgDec.Tag = "KlgDec";
            rbKlgDec.Text = "Giảm";
            rbKlgDec.UseVisualStyleBackColor = true;
            // 
            // rbKlgInc
            // 
            rbKlgInc.AutoSize = true;
            rbKlgInc.Location = new Point(17, 30);
            rbKlgInc.Name = "rbKlgInc";
            rbKlgInc.Size = new Size(74, 29);
            rbKlgInc.TabIndex = 0;
            rbKlgInc.TabStop = true;
            rbKlgInc.Tag = "KlgInc";
            rbKlgInc.Text = "Tăng";
            rbKlgInc.UseVisualStyleBackColor = true;
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
            groupBox3.Controls.Add(rbPriceDec);
            groupBox3.Controls.Add(rbPriceInc);
            groupBox3.Location = new Point(795, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(140, 108);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Giá tiền";
            // 
            // rbPriceDec
            // 
            rbPriceDec.AutoSize = true;
            rbPriceDec.Location = new Point(17, 65);
            rbPriceDec.Name = "rbPriceDec";
            rbPriceDec.Size = new Size(78, 29);
            rbPriceDec.TabIndex = 1;
            rbPriceDec.TabStop = true;
            rbPriceDec.Tag = "PriceDec";
            rbPriceDec.Text = "Giảm";
            rbPriceDec.UseVisualStyleBackColor = true;
            // 
            // rbPriceInc
            // 
            rbPriceInc.AutoSize = true;
            rbPriceInc.Location = new Point(17, 30);
            rbPriceInc.Name = "rbPriceInc";
            rbPriceInc.Size = new Size(74, 29);
            rbPriceInc.TabIndex = 0;
            rbPriceInc.TabStop = true;
            rbPriceInc.Tag = "PriceInc";
            rbPriceInc.Text = "Tăng";
            rbPriceInc.UseVisualStyleBackColor = true;
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
            resetBtn.Location = new Point(1346, 141);
            resetBtn.Margin = new Padding(4, 5, 4, 5);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(172, 64);
            resetBtn.TabIndex = 29;
            resetBtn.Text = "Reset";
            resetBtn.TextColor = Color.DarkGray;
            resetBtn.TextHover = Color.White;
            resetBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
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
            filterBtn.Location = new Point(580, 9);
            filterBtn.Margin = new Padding(4, 5, 4, 5);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(172, 64);
            filterBtn.TabIndex = 24;
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
            sortBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            sortBtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            sortBtn.FlatStyle = FlatStyle.Flat;
            sortBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sortBtn.ForeColor = Color.DeepSkyBlue;
            sortBtn.ImageAlign = ContentAlignment.MiddleRight;
            sortBtn.ImageHover = null;
            sortBtn.Location = new Point(771, 9);
            sortBtn.Margin = new Padding(4, 5, 4, 5);
            sortBtn.Name = "sortBtn";
            sortBtn.Size = new Size(172, 64);
            sortBtn.TabIndex = 23;
            sortBtn.Text = "Sắp xếp";
            sortBtn.TextColor = Color.DeepSkyBlue;
            sortBtn.TextHover = Color.White;
            sortBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            sortBtn.UseVisualStyleBackColor = false;
            sortBtn.Click += sortBtn_Click;
            // 
            // dgvNgl
            // 
            dgvNgl.AllowUserToAddRows = false;
            dgvNgl.AllowUserToDeleteRows = false;
            dgvNgl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNgl.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNgl.BorderStyle = BorderStyle.None;
            dgvNgl.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.DarkCyan;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvNgl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvNgl.ColumnHeadersHeight = 30;
            dgvNgl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvNgl.DefaultCellStyle = dataGridViewCellStyle5;
            dgvNgl.Dock = DockStyle.Bottom;
            dgvNgl.EnableHeadersVisualStyles = false;
            dgvNgl.GridColor = Color.DarkCyan;
            dgvNgl.ImeMode = ImeMode.NoControl;
            dgvNgl.Location = new Point(4, 346);
            dgvNgl.Margin = new Padding(4, 5, 4, 5);
            dgvNgl.Name = "dgvNgl";
            dgvNgl.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvNgl.RowHeadersVisible = false;
            dgvNgl.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNgl.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvNgl.RowTemplate.Height = 25;
            dgvNgl.RowTemplate.ReadOnly = true;
            dgvNgl.Size = new Size(1522, 537);
            dgvNgl.TabIndex = 22;
            dgvNgl.CellClick += dgvNgl_CellClick;
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
            delBtn.Location = new Point(1344, 9);
            delBtn.Margin = new Padding(4, 5, 4, 5);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(172, 64);
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
            editBtn.Location = new Point(1153, 9);
            editBtn.Margin = new Padding(4, 5, 4, 5);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(172, 64);
            editBtn.TabIndex = 13;
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
            addBtn.Location = new Point(962, 9);
            addBtn.Margin = new Padding(4, 5, 4, 5);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(172, 64);
            addBtn.TabIndex = 12;
            addBtn.Text = "  Thêm";
            addBtn.TextColor = Color.DarkCyan;
            addBtn.TextHover = Color.White;
            addBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
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
            detailTabPage.Controls.Add(checkboxIsDelete);
            detailTabPage.Controls.Add(label6);
            detailTabPage.Controls.Add(HuyBtn);
            detailTabPage.Controls.Add(xacNhanBtn);
            detailTabPage.Controls.Add(label7);
            detailTabPage.Controls.Add(btn_back);
            detailTabPage.Controls.Add(caPhePic);
            detailTabPage.Controls.Add(label8);
            detailTabPage.Controls.Add(txtNglPrice);
            detailTabPage.Controls.Add(label3);
            detailTabPage.Controls.Add(txtNglInfo);
            detailTabPage.Controls.Add(M);
            detailTabPage.Controls.Add(txtNglId);
            detailTabPage.Controls.Add(txtNglWeigh);
            detailTabPage.Controls.Add(txtNglName);
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
            // checkboxIsDelete
            // 
            checkboxIsDelete.AutoSize = true;
            checkboxIsDelete.Location = new Point(1051, 324);
            checkboxIsDelete.Name = "checkboxIsDelete";
            checkboxIsDelete.Size = new Size(22, 21);
            checkboxIsDelete.TabIndex = 56;
            checkboxIsDelete.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(923, 288);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 85);
            label6.TabIndex = 55;
            label6.Text = "IsDelete";
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
            HuyBtn.Location = new Point(1321, 772);
            HuyBtn.Margin = new Padding(4, 5, 4, 5);
            HuyBtn.Name = "HuyBtn";
            HuyBtn.Size = new Size(196, 89);
            HuyBtn.TabIndex = 44;
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
            xacNhanBtn.Location = new Point(1102, 772);
            xacNhanBtn.Margin = new Padding(4, 5, 4, 5);
            xacNhanBtn.Name = "xacNhanBtn";
            xacNhanBtn.Size = new Size(196, 89);
            xacNhanBtn.TabIndex = 43;
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
            label7.Location = new Point(124, 4);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(330, 71);
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
            // caPhePic
            // 
            caPhePic.BackColor = SystemColors.ActiveBorder;
            caPhePic.BackgroundImageLayout = ImageLayout.None;
            caPhePic.Cursor = Cursors.Hand;
            caPhePic.Image = Properties.Resources.defaultImage3;
            caPhePic.Location = new Point(88, 428);
            caPhePic.Margin = new Padding(4, 5, 4, 5);
            caPhePic.Name = "caPhePic";
            caPhePic.Size = new Size(229, 240);
            caPhePic.SizeMode = PictureBoxSizeMode.StretchImage;
            caPhePic.TabIndex = 38;
            caPhePic.TabStop = false;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(66, 384);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(151, 49);
            label8.TabIndex = 37;
            label8.Text = "Hình Ảnh";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNglPrice
            // 
            txtNglPrice.BackColor = SystemColors.Window;
            txtNglPrice.BorderColor = Color.Silver;
            txtNglPrice.BorderFocusColor = Color.DarkCyan;
            txtNglPrice.BorderRadius = 13;
            txtNglPrice.BorderSize = 2;
            txtNglPrice.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNglPrice.ForeColor = Color.DimGray;
            txtNglPrice.Location = new Point(904, 161);
            txtNglPrice.Margin = new Padding(4, 5, 4, 5);
            txtNglPrice.Multiline = false;
            txtNglPrice.Name = "txtNglPrice";
            txtNglPrice.Padding = new Padding(12, 15, 10, 11);
            txtNglPrice.PasswordChar = false;
            txtNglPrice.PlaceholderColor = Color.DarkGray;
            txtNglPrice.PlaceholderText = "Nhập giá tiền";
            txtNglPrice.Size = new Size(349, 63);
            txtNglPrice.TabIndex = 34;
            txtNglPrice.Texts = "";
            txtNglPrice.UnderlinedStyle = false;
            txtNglPrice._TextChanged += txtNglPrice__TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(900, 94);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(216, 85);
            label3.TabIndex = 33;
            label3.Text = "Giá Tiền (Kg)";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNglInfo
            // 
            txtNglInfo.BackColor = SystemColors.Window;
            txtNglInfo.BorderColor = Color.Silver;
            txtNglInfo.BorderFocusColor = Color.DarkCyan;
            txtNglInfo.BorderRadius = 13;
            txtNglInfo.BorderSize = 2;
            txtNglInfo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNglInfo.ForeColor = Color.DimGray;
            txtNglInfo.Location = new Point(512, 161);
            txtNglInfo.Margin = new Padding(4, 5, 4, 5);
            txtNglInfo.Multiline = false;
            txtNglInfo.Name = "txtNglInfo";
            txtNglInfo.Padding = new Padding(12, 15, 10, 11);
            txtNglInfo.PasswordChar = false;
            txtNglInfo.PlaceholderColor = Color.DarkGray;
            txtNglInfo.PlaceholderText = "Nhập thông tin";
            txtNglInfo.Size = new Size(349, 63);
            txtNglInfo.TabIndex = 32;
            txtNglInfo.Texts = "";
            txtNglInfo.UnderlinedStyle = false;
            txtNglInfo._TextChanged += txtNglInfo__TextChanged;
            // 
            // M
            // 
            M.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            M.Location = new Point(488, 96);
            M.Margin = new Padding(4, 0, 4, 0);
            M.Name = "M";
            M.Size = new Size(151, 85);
            M.TabIndex = 31;
            M.Text = "Thông Tin";
            M.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNglId
            // 
            txtNglId.BackColor = SystemColors.Window;
            txtNglId.BorderColor = Color.Silver;
            txtNglId.BorderFocusColor = Color.DarkCyan;
            txtNglId.BorderRadius = 13;
            txtNglId.BorderSize = 2;
            txtNglId.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNglId.ForeColor = Color.DimGray;
            txtNglId.Location = new Point(88, 161);
            txtNglId.Margin = new Padding(4, 5, 4, 5);
            txtNglId.Multiline = false;
            txtNglId.Name = "txtNglId";
            txtNglId.Padding = new Padding(12, 15, 10, 11);
            txtNglId.PasswordChar = false;
            txtNglId.PlaceholderColor = Color.DarkGray;
            txtNglId.PlaceholderText = "Nhập ID";
            txtNglId.Size = new Size(349, 63);
            txtNglId.TabIndex = 30;
            txtNglId.Texts = "";
            txtNglId.UnderlinedStyle = false;
            // 
            // txtNglWeigh
            // 
            txtNglWeigh.BackColor = SystemColors.Window;
            txtNglWeigh.BorderColor = Color.Silver;
            txtNglWeigh.BorderFocusColor = Color.DarkCyan;
            txtNglWeigh.BorderRadius = 13;
            txtNglWeigh.BorderSize = 2;
            txtNglWeigh.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNglWeigh.ForeColor = Color.DimGray;
            txtNglWeigh.Location = new Point(512, 299);
            txtNglWeigh.Margin = new Padding(4, 5, 4, 5);
            txtNglWeigh.Multiline = false;
            txtNglWeigh.Name = "txtNglWeigh";
            txtNglWeigh.Padding = new Padding(12, 15, 10, 11);
            txtNglWeigh.PasswordChar = false;
            txtNglWeigh.PlaceholderColor = Color.DarkGray;
            txtNglWeigh.PlaceholderText = "Nhập khối lượng";
            txtNglWeigh.Size = new Size(349, 63);
            txtNglWeigh.TabIndex = 29;
            txtNglWeigh.Texts = "";
            txtNglWeigh.UnderlinedStyle = false;
            txtNglWeigh._TextChanged += txtNglWeigh__TextChanged;
            // 
            // txtNglName
            // 
            txtNglName.BackColor = SystemColors.Window;
            txtNglName.BorderColor = Color.Silver;
            txtNglName.BorderFocusColor = Color.DarkCyan;
            txtNglName.BorderRadius = 13;
            txtNglName.BorderSize = 2;
            txtNglName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNglName.ForeColor = Color.DimGray;
            txtNglName.Location = new Point(88, 299);
            txtNglName.Margin = new Padding(4, 5, 4, 5);
            txtNglName.Multiline = false;
            txtNglName.Name = "txtNglName";
            txtNglName.Padding = new Padding(12, 15, 10, 11);
            txtNglName.PasswordChar = false;
            txtNglName.PlaceholderColor = Color.DarkGray;
            txtNglName.PlaceholderText = "Nhập tên nguyên liệu";
            txtNglName.Size = new Size(349, 63);
            txtNglName.TabIndex = 28;
            txtNglName.Texts = "";
            txtNglName.UnderlinedStyle = false;
            txtNglName._TextChanged += txtNglName__TextChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(60, 232);
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
            label4.Location = new Point(487, 234);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(151, 85);
            label4.TabIndex = 26;
            label4.Text = "Khối Lượng";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 98);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 85);
            label1.TabIndex = 25;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NguyenLieuView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1538, 925);
            Controls.Add(tcNgl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "NguyenLieuView";
            Text = "NguyenLieuView";
            tcNgl.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)dgvNgl).EndInit();
            detailTabPage.ResumeLayout(false);
            detailTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)caPhePic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcNgl;
        private TabPage listTabPage;
        private TabPage detailTabPage;
        private CustomControl.CustomButton customButton2;
        private CustomControl.CustomButton delBtn;
        private CustomControl.CustomButton editBtn;
        private CustomControl.CustomButton addBtn;
        private CustomControl.CustomTextBox searchTxt;
        private DataGridView dgvNgl;
        private PictureBox caPhePic;
        private Label label8;
        private CustomControl.CustomTextBox txtNglPrice;
        private Label label3;
        private CustomControl.CustomTextBox txtNglInfo;
        private Label M;
        private CustomControl.CustomTextBox txtNglId;
        private CustomControl.CustomTextBox txtNglWeigh;
        private CustomControl.CustomTextBox txtNglName;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label7;
        private CustomControl.CustomButton btn_back;
        private CustomControl.CustomButton HuyBtn;
        private CustomControl.CustomButton xacNhanBtn;
        private Label label6;
        private CustomControl.CustomButton sortBtn;
        private CustomControl.CustomButton filterBtn;
        private CustomControl.CustomButton resetBtn;
        private GroupBox gbSort;
        private GroupBox groupBox5;
        private RadioButton rbInfoDec;
        private RadioButton rbInfoInc;
        private GroupBox groupBox6;
        private RadioButton rbIsDeleteDec;
        private RadioButton rbIsDeleteInc;
        private GroupBox groupBox1;
        private RadioButton rbIDDec;
        private RadioButton rbIIDnc;
        private GroupBox groupBox4;
        private RadioButton rbKlgDec;
        private RadioButton rbKlgInc;
        private GroupBox groupBox2;
        private RadioButton rbNameDec;
        private RadioButton rbNameInc;
        private GroupBox groupBox3;
        private RadioButton rbPriceDec;
        private RadioButton rbPriceInc;
        private CheckBox checkboxIsDelete;
    }
}