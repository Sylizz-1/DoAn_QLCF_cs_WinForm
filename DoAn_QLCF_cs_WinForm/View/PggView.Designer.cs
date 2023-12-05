namespace DoAn_QLCF_cs_WinForm.View
{
    partial class PggView
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
            tcPgg = new TabControl();
            listTabPage = new TabPage();
            dgvPgg = new DataGridView();
            resetBtn = new CustomControl.CustomButton();
            sortBtn = new CustomControl.CustomButton();
            gbSort = new GroupBox();
            groupBox1 = new GroupBox();
            rbTgKetThucDec = new RadioButton();
            rbTgKetThucInc = new RadioButton();
            groupBox2 = new GroupBox();
            rbIsDeleteDec = new RadioButton();
            rbIsDeleteInc = new RadioButton();
            groupBox3 = new GroupBox();
            rbIDDec = new RadioButton();
            rbIDInc = new RadioButton();
            groupBox4 = new GroupBox();
            rbGiaHoaDonDec = new RadioButton();
            rbGiaHoaDonInc = new RadioButton();
            groupBox5 = new GroupBox();
            rbTgBatDauDec = new RadioButton();
            rbTgBatDauInc = new RadioButton();
            groupBox6 = new GroupBox();
            rbPhanTramGiamGiaDec = new RadioButton();
            rbPhanTramGiamGiaInc = new RadioButton();
            delBtn = new CustomControl.CustomButton();
            editBtn = new CustomControl.CustomButton();
            addBtn = new CustomControl.CustomButton();
            customButton2 = new CustomControl.CustomButton();
            detailTabPage = new TabPage();
            dtpTgKetThucPgg = new DateTimePicker();
            dtpTgBatDauPgg = new DateTimePicker();
            checkboxIsDelete = new CheckBox();
            HuyBtn = new CustomControl.CustomButton();
            xacNhanBtn = new CustomControl.CustomButton();
            label6 = new Label();
            label7 = new Label();
            btn_back = new CustomControl.CustomButton();
            label3 = new Label();
            txtPhanTramGiamGiaPgg = new CustomControl.CustomTextBox();
            M = new Label();
            txtIdPgg = new CustomControl.CustomTextBox();
            txtGiaHoaDonPgg = new CustomControl.CustomTextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            tcPgg.SuspendLayout();
            listTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPgg).BeginInit();
            gbSort.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            detailTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tcPgg
            // 
            tcPgg.Controls.Add(listTabPage);
            tcPgg.Controls.Add(detailTabPage);
            tcPgg.Location = new Point(-1, 0);
            tcPgg.Name = "tcPgg";
            tcPgg.SelectedIndex = 0;
            tcPgg.Size = new Size(1079, 555);
            tcPgg.TabIndex = 0;
            // 
            // listTabPage
            // 
            listTabPage.Controls.Add(dgvPgg);
            listTabPage.Controls.Add(resetBtn);
            listTabPage.Controls.Add(sortBtn);
            listTabPage.Controls.Add(gbSort);
            listTabPage.Controls.Add(delBtn);
            listTabPage.Controls.Add(editBtn);
            listTabPage.Controls.Add(addBtn);
            listTabPage.Controls.Add(customButton2);
            listTabPage.Location = new Point(4, 24);
            listTabPage.Name = "listTabPage";
            listTabPage.Padding = new Padding(3);
            listTabPage.Size = new Size(1071, 527);
            listTabPage.TabIndex = 1;
            listTabPage.Text = "Danh Sách";
            listTabPage.UseVisualStyleBackColor = true;
            // 
            // dgvPgg
            // 
            dgvPgg.AllowUserToAddRows = false;
            dgvPgg.AllowUserToDeleteRows = false;
            dgvPgg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPgg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPgg.BorderStyle = BorderStyle.None;
            dgvPgg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkCyan;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPgg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPgg.ColumnHeadersHeight = 30;
            dgvPgg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPgg.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPgg.Dock = DockStyle.Bottom;
            dgvPgg.EnableHeadersVisualStyles = false;
            dgvPgg.GridColor = Color.DarkCyan;
            dgvPgg.ImeMode = ImeMode.NoControl;
            dgvPgg.Location = new Point(3, 166);
            dgvPgg.Name = "dgvPgg";
            dgvPgg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPgg.RowHeadersVisible = false;
            dgvPgg.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPgg.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvPgg.RowTemplate.Height = 25;
            dgvPgg.RowTemplate.ReadOnly = true;
            dgvPgg.Size = new Size(1065, 358);
            dgvPgg.TabIndex = 40;
            dgvPgg.CellClick += dgvPgg_CellClick;
            // 
            // resetBtn
            // 
            resetBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            resetBtn.BackColor = SystemColors.Control;
            resetBtn.BackgroundColor = SystemColors.Control;
            resetBtn.BorderColor = Color.Gray;
            resetBtn.BorderRadius = 15;
            resetBtn.BorderSize = 2;
            resetBtn.EnabledTextHover = true;
            resetBtn.FlatAppearance.BorderSize = 0;
            resetBtn.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            resetBtn.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.ForeColor = Color.DarkGray;
            resetBtn.ImageAlign = ContentAlignment.MiddleRight;
            resetBtn.ImageHover = null;
            resetBtn.Location = new Point(927, 94);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(120, 38);
            resetBtn.TabIndex = 36;
            resetBtn.Text = "Reset";
            resetBtn.TextColor = Color.DarkGray;
            resetBtn.TextHover = Color.White;
            resetBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // sortBtn
            // 
            sortBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sortBtn.BackColor = SystemColors.Control;
            sortBtn.BackgroundColor = SystemColors.Control;
            sortBtn.BorderColor = Color.DeepSkyBlue;
            sortBtn.BorderRadius = 15;
            sortBtn.BorderSize = 2;
            sortBtn.EnabledTextHover = true;
            sortBtn.FlatAppearance.BorderSize = 0;
            sortBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            sortBtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            sortBtn.FlatStyle = FlatStyle.Flat;
            sortBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sortBtn.ForeColor = Color.DeepSkyBlue;
            sortBtn.ImageAlign = ContentAlignment.MiddleRight;
            sortBtn.ImageHover = null;
            sortBtn.Location = new Point(9, 8);
            sortBtn.Name = "sortBtn";
            sortBtn.Size = new Size(120, 38);
            sortBtn.TabIndex = 37;
            sortBtn.Text = "Sắp xếp";
            sortBtn.TextColor = Color.DeepSkyBlue;
            sortBtn.TextHover = Color.White;
            sortBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            sortBtn.UseVisualStyleBackColor = false;
            sortBtn.Click += sortBtn_Click;
            // 
            // gbSort
            // 
            gbSort.Controls.Add(groupBox1);
            gbSort.Controls.Add(groupBox2);
            gbSort.Controls.Add(groupBox3);
            gbSort.Controls.Add(groupBox4);
            gbSort.Controls.Add(groupBox5);
            gbSort.Controls.Add(groupBox6);
            gbSort.Location = new Point(9, 61);
            gbSort.Margin = new Padding(2);
            gbSort.Name = "gbSort";
            gbSort.Padding = new Padding(2);
            gbSort.Size = new Size(804, 90);
            gbSort.TabIndex = 35;
            gbSort.TabStop = false;
            gbSort.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbTgKetThucDec);
            groupBox1.Controls.Add(rbTgKetThucInc);
            groupBox1.Location = new Point(282, 14);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(98, 65);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ngày KT";
            // 
            // rbTgKetThucDec
            // 
            rbTgKetThucDec.AutoSize = true;
            rbTgKetThucDec.Location = new Point(10, 37);
            rbTgKetThucDec.Margin = new Padding(2);
            rbTgKetThucDec.Name = "rbTgKetThucDec";
            rbTgKetThucDec.Size = new Size(53, 19);
            rbTgKetThucDec.TabIndex = 1;
            rbTgKetThucDec.TabStop = true;
            rbTgKetThucDec.Tag = "TgKetThucDec";
            rbTgKetThucDec.Text = "Giảm";
            rbTgKetThucDec.UseVisualStyleBackColor = true;
            // 
            // rbTgKetThucInc
            // 
            rbTgKetThucInc.AutoSize = true;
            rbTgKetThucInc.Location = new Point(10, 16);
            rbTgKetThucInc.Margin = new Padding(2);
            rbTgKetThucInc.Name = "rbTgKetThucInc";
            rbTgKetThucInc.Size = new Size(50, 19);
            rbTgKetThucInc.TabIndex = 0;
            rbTgKetThucInc.TabStop = true;
            rbTgKetThucInc.Tag = "TgKetThucInc";
            rbTgKetThucInc.Text = "Tăng";
            rbTgKetThucInc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbIsDeleteDec);
            groupBox2.Controls.Add(rbIsDeleteInc);
            groupBox2.Location = new Point(694, 14);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(98, 65);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "IsDelete";
            // 
            // rbIsDeleteDec
            // 
            rbIsDeleteDec.AutoSize = true;
            rbIsDeleteDec.Location = new Point(10, 37);
            rbIsDeleteDec.Margin = new Padding(2);
            rbIsDeleteDec.Name = "rbIsDeleteDec";
            rbIsDeleteDec.Size = new Size(53, 19);
            rbIsDeleteDec.TabIndex = 1;
            rbIsDeleteDec.TabStop = true;
            rbIsDeleteDec.Tag = "IsDeleteDec";
            rbIsDeleteDec.Text = "Giảm";
            rbIsDeleteDec.UseVisualStyleBackColor = true;
            // 
            // rbIsDeleteInc
            // 
            rbIsDeleteInc.AutoSize = true;
            rbIsDeleteInc.Location = new Point(10, 16);
            rbIsDeleteInc.Margin = new Padding(2);
            rbIsDeleteInc.Name = "rbIsDeleteInc";
            rbIsDeleteInc.Size = new Size(50, 19);
            rbIsDeleteInc.TabIndex = 0;
            rbIsDeleteInc.TabStop = true;
            rbIsDeleteInc.Tag = "IsDeleteInc";
            rbIsDeleteInc.Text = "Tăng";
            rbIsDeleteInc.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbIDDec);
            groupBox3.Controls.Add(rbIDInc);
            groupBox3.Location = new Point(8, 14);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(98, 65);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "ID";
            // 
            // rbIDDec
            // 
            rbIDDec.AutoSize = true;
            rbIDDec.Location = new Point(10, 37);
            rbIDDec.Margin = new Padding(2);
            rbIDDec.Name = "rbIDDec";
            rbIDDec.Size = new Size(53, 19);
            rbIDDec.TabIndex = 1;
            rbIDDec.TabStop = true;
            rbIDDec.Tag = "IDDec";
            rbIDDec.Text = "Giảm";
            rbIDDec.UseVisualStyleBackColor = true;
            // 
            // rbIDInc
            // 
            rbIDInc.AutoSize = true;
            rbIDInc.Location = new Point(10, 16);
            rbIDInc.Margin = new Padding(2);
            rbIDInc.Name = "rbIDInc";
            rbIDInc.Size = new Size(50, 19);
            rbIDInc.TabIndex = 0;
            rbIDInc.TabStop = true;
            rbIDInc.Tag = "IDInc";
            rbIDInc.Text = "Tăng";
            rbIDInc.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rbGiaHoaDonDec);
            groupBox4.Controls.Add(rbGiaHoaDonInc);
            groupBox4.Location = new Point(411, 14);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(98, 65);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Giá hoá đơn ";
            // 
            // rbGiaHoaDonDec
            // 
            rbGiaHoaDonDec.AutoSize = true;
            rbGiaHoaDonDec.Location = new Point(10, 37);
            rbGiaHoaDonDec.Margin = new Padding(2);
            rbGiaHoaDonDec.Name = "rbGiaHoaDonDec";
            rbGiaHoaDonDec.Size = new Size(53, 19);
            rbGiaHoaDonDec.TabIndex = 1;
            rbGiaHoaDonDec.TabStop = true;
            rbGiaHoaDonDec.Tag = "GiaHoaDonDec";
            rbGiaHoaDonDec.Text = "Giảm";
            rbGiaHoaDonDec.UseVisualStyleBackColor = true;
            // 
            // rbGiaHoaDonInc
            // 
            rbGiaHoaDonInc.AutoSize = true;
            rbGiaHoaDonInc.Location = new Point(10, 16);
            rbGiaHoaDonInc.Margin = new Padding(2);
            rbGiaHoaDonInc.Name = "rbGiaHoaDonInc";
            rbGiaHoaDonInc.Size = new Size(50, 19);
            rbGiaHoaDonInc.TabIndex = 0;
            rbGiaHoaDonInc.TabStop = true;
            rbGiaHoaDonInc.Tag = "GiaHoaDonInc";
            rbGiaHoaDonInc.Text = "Tăng";
            rbGiaHoaDonInc.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rbTgBatDauDec);
            groupBox5.Controls.Add(rbTgBatDauInc);
            groupBox5.Location = new Point(145, 14);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(98, 65);
            groupBox5.TabIndex = 24;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ngày BD";
            // 
            // rbTgBatDauDec
            // 
            rbTgBatDauDec.AutoSize = true;
            rbTgBatDauDec.Location = new Point(10, 37);
            rbTgBatDauDec.Margin = new Padding(2);
            rbTgBatDauDec.Name = "rbTgBatDauDec";
            rbTgBatDauDec.Size = new Size(53, 19);
            rbTgBatDauDec.TabIndex = 1;
            rbTgBatDauDec.TabStop = true;
            rbTgBatDauDec.Tag = "TgBatDauDec";
            rbTgBatDauDec.Text = "Giảm";
            rbTgBatDauDec.UseVisualStyleBackColor = true;
            // 
            // rbTgBatDauInc
            // 
            rbTgBatDauInc.AutoSize = true;
            rbTgBatDauInc.Location = new Point(10, 16);
            rbTgBatDauInc.Margin = new Padding(2);
            rbTgBatDauInc.Name = "rbTgBatDauInc";
            rbTgBatDauInc.Size = new Size(50, 19);
            rbTgBatDauInc.TabIndex = 0;
            rbTgBatDauInc.TabStop = true;
            rbTgBatDauInc.Tag = "TgBatDauInc";
            rbTgBatDauInc.Text = "Tăng";
            rbTgBatDauInc.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rbPhanTramGiamGiaDec);
            groupBox6.Controls.Add(rbPhanTramGiamGiaInc);
            groupBox6.Location = new Point(528, 14);
            groupBox6.Margin = new Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2);
            groupBox6.Size = new Size(139, 65);
            groupBox6.TabIndex = 25;
            groupBox6.TabStop = false;
            groupBox6.Text = "Phần trăm giảm giá";
            // 
            // rbPhanTramGiamGiaDec
            // 
            rbPhanTramGiamGiaDec.AutoSize = true;
            rbPhanTramGiamGiaDec.Location = new Point(10, 37);
            rbPhanTramGiamGiaDec.Margin = new Padding(2);
            rbPhanTramGiamGiaDec.Name = "rbPhanTramGiamGiaDec";
            rbPhanTramGiamGiaDec.Size = new Size(53, 19);
            rbPhanTramGiamGiaDec.TabIndex = 1;
            rbPhanTramGiamGiaDec.TabStop = true;
            rbPhanTramGiamGiaDec.Tag = "PhanTramGiamGiaDec";
            rbPhanTramGiamGiaDec.Text = "Giảm";
            rbPhanTramGiamGiaDec.UseVisualStyleBackColor = true;
            // 
            // rbPhanTramGiamGiaInc
            // 
            rbPhanTramGiamGiaInc.AutoSize = true;
            rbPhanTramGiamGiaInc.Location = new Point(10, 16);
            rbPhanTramGiamGiaInc.Margin = new Padding(2);
            rbPhanTramGiamGiaInc.Name = "rbPhanTramGiamGiaInc";
            rbPhanTramGiamGiaInc.Size = new Size(50, 19);
            rbPhanTramGiamGiaInc.TabIndex = 0;
            rbPhanTramGiamGiaInc.TabStop = true;
            rbPhanTramGiamGiaInc.Tag = "PhanTramGiamGiaInc";
            rbPhanTramGiamGiaInc.Text = "Tăng";
            rbPhanTramGiamGiaInc.UseVisualStyleBackColor = true;
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
            delBtn.Location = new Point(940, 8);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(121, 38);
            delBtn.TabIndex = 34;
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
            editBtn.Location = new Point(813, 8);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(121, 38);
            editBtn.TabIndex = 33;
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
            addBtn.Location = new Point(686, 8);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(121, 38);
            addBtn.TabIndex = 32;
            addBtn.Text = "  Thêm";
            addBtn.TextColor = Color.DarkCyan;
            addBtn.TextHover = Color.White;
            addBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
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
            customButton2.Location = new Point(222, 8);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(35, 28);
            customButton2.TabIndex = 31;
            customButton2.TextColor = Color.White;
            customButton2.TextHover = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // detailTabPage
            // 
            detailTabPage.Controls.Add(dtpTgKetThucPgg);
            detailTabPage.Controls.Add(dtpTgBatDauPgg);
            detailTabPage.Controls.Add(checkboxIsDelete);
            detailTabPage.Controls.Add(HuyBtn);
            detailTabPage.Controls.Add(xacNhanBtn);
            detailTabPage.Controls.Add(label6);
            detailTabPage.Controls.Add(label7);
            detailTabPage.Controls.Add(btn_back);
            detailTabPage.Controls.Add(label3);
            detailTabPage.Controls.Add(txtPhanTramGiamGiaPgg);
            detailTabPage.Controls.Add(M);
            detailTabPage.Controls.Add(txtIdPgg);
            detailTabPage.Controls.Add(txtGiaHoaDonPgg);
            detailTabPage.Controls.Add(label5);
            detailTabPage.Controls.Add(label4);
            detailTabPage.Controls.Add(label1);
            detailTabPage.Location = new Point(4, 24);
            detailTabPage.Name = "detailTabPage";
            detailTabPage.Padding = new Padding(3);
            detailTabPage.Size = new Size(1071, 527);
            detailTabPage.TabIndex = 2;
            detailTabPage.Text = "Chi Tiết";
            detailTabPage.UseVisualStyleBackColor = true;
            // 
            // dtpTgKetThucPgg
            // 
            dtpTgKetThucPgg.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTgKetThucPgg.Location = new Point(350, 197);
            dtpTgKetThucPgg.Name = "dtpTgKetThucPgg";
            dtpTgKetThucPgg.Size = new Size(275, 31);
            dtpTgKetThucPgg.TabIndex = 79;
            // 
            // dtpTgBatDauPgg
            // 
            dtpTgBatDauPgg.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTgBatDauPgg.Location = new Point(350, 104);
            dtpTgBatDauPgg.Name = "dtpTgBatDauPgg";
            dtpTgBatDauPgg.Size = new Size(275, 31);
            dtpTgBatDauPgg.TabIndex = 78;
            // 
            // checkboxIsDelete
            // 
            checkboxIsDelete.AutoSize = true;
            checkboxIsDelete.Location = new Point(490, 287);
            checkboxIsDelete.Margin = new Padding(2);
            checkboxIsDelete.Name = "checkboxIsDelete";
            checkboxIsDelete.Size = new Size(15, 14);
            checkboxIsDelete.TabIndex = 77;
            checkboxIsDelete.UseVisualStyleBackColor = true;
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
            HuyBtn.Location = new Point(914, 465);
            HuyBtn.Name = "HuyBtn";
            HuyBtn.Size = new Size(137, 53);
            HuyBtn.TabIndex = 74;
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
            xacNhanBtn.Location = new Point(761, 465);
            xacNhanBtn.Name = "xacNhanBtn";
            xacNhanBtn.Size = new Size(137, 53);
            xacNhanBtn.TabIndex = 73;
            xacNhanBtn.Text = "  Xác Nhận";
            xacNhanBtn.TextColor = Color.DarkCyan;
            xacNhanBtn.TextHover = Color.White;
            xacNhanBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            xacNhanBtn.UseVisualStyleBackColor = false;
            xacNhanBtn.Click += xacNhanBtn_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(369, 266);
            label6.Name = "label6";
            label6.Size = new Size(116, 51);
            label6.TabIndex = 72;
            label6.Text = "IsDelete";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(99, 9);
            label7.Name = "label7";
            label7.Size = new Size(232, 43);
            label7.TabIndex = 71;
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
            btn_back.Location = new Point(20, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(63, 41);
            btn_back.TabIndex = 70;
            btn_back.TextColor = Color.White;
            btn_back.TextHover = Color.White;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(334, 65);
            label3.Name = "label3";
            label3.Size = new Size(151, 51);
            label3.TabIndex = 69;
            label3.Text = "Thời Gian Bắt Đầu";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPhanTramGiamGiaPgg
            // 
            txtPhanTramGiamGiaPgg.BackColor = SystemColors.Window;
            txtPhanTramGiamGiaPgg.BorderColor = Color.Silver;
            txtPhanTramGiamGiaPgg.BorderFocusColor = Color.DarkCyan;
            txtPhanTramGiamGiaPgg.BorderRadius = 13;
            txtPhanTramGiamGiaPgg.BorderSize = 2;
            txtPhanTramGiamGiaPgg.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhanTramGiamGiaPgg.ForeColor = Color.DimGray;
            txtPhanTramGiamGiaPgg.Location = new Point(73, 275);
            txtPhanTramGiamGiaPgg.Multiline = false;
            txtPhanTramGiamGiaPgg.Name = "txtPhanTramGiamGiaPgg";
            txtPhanTramGiamGiaPgg.Padding = new Padding(9, 9, 7, 7);
            txtPhanTramGiamGiaPgg.PasswordChar = false;
            txtPhanTramGiamGiaPgg.PlaceholderColor = Color.DarkGray;
            txtPhanTramGiamGiaPgg.PlaceholderText = "Nhập phần trăm giảm giá";
            txtPhanTramGiamGiaPgg.Size = new Size(244, 42);
            txtPhanTramGiamGiaPgg.TabIndex = 68;
            txtPhanTramGiamGiaPgg.Texts = "";
            txtPhanTramGiamGiaPgg.UnderlinedStyle = false;
            txtPhanTramGiamGiaPgg._TextChanged += txtPhanTramGiamGiaPgg__TextChanged;
            // 
            // M
            // 
            M.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            M.Location = new Point(73, 231);
            M.Name = "M";
            M.Size = new Size(185, 51);
            M.TabIndex = 67;
            M.Text = "Phần Trăm Giảm Giá";
            M.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIdPgg
            // 
            txtIdPgg.BackColor = SystemColors.Window;
            txtIdPgg.BorderColor = Color.Silver;
            txtIdPgg.BorderFocusColor = Color.DarkCyan;
            txtIdPgg.BorderRadius = 13;
            txtIdPgg.BorderSize = 2;
            txtIdPgg.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdPgg.ForeColor = Color.DimGray;
            txtIdPgg.Location = new Point(73, 104);
            txtIdPgg.Multiline = false;
            txtIdPgg.Name = "txtIdPgg";
            txtIdPgg.Padding = new Padding(9, 9, 7, 7);
            txtIdPgg.PasswordChar = false;
            txtIdPgg.PlaceholderColor = Color.DarkGray;
            txtIdPgg.PlaceholderText = "Nhập ID....";
            txtIdPgg.Size = new Size(244, 42);
            txtIdPgg.TabIndex = 66;
            txtIdPgg.Texts = "";
            txtIdPgg.UnderlinedStyle = false;
            // 
            // txtGiaHoaDonPgg
            // 
            txtGiaHoaDonPgg.BackColor = SystemColors.Window;
            txtGiaHoaDonPgg.BorderColor = Color.Silver;
            txtGiaHoaDonPgg.BorderFocusColor = Color.DarkCyan;
            txtGiaHoaDonPgg.BorderRadius = 13;
            txtGiaHoaDonPgg.BorderSize = 2;
            txtGiaHoaDonPgg.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiaHoaDonPgg.ForeColor = Color.DimGray;
            txtGiaHoaDonPgg.Location = new Point(73, 186);
            txtGiaHoaDonPgg.Multiline = false;
            txtGiaHoaDonPgg.Name = "txtGiaHoaDonPgg";
            txtGiaHoaDonPgg.Padding = new Padding(9, 9, 7, 7);
            txtGiaHoaDonPgg.PasswordChar = false;
            txtGiaHoaDonPgg.PlaceholderColor = Color.DarkGray;
            txtGiaHoaDonPgg.PlaceholderText = "Nhập giá hóa đơn";
            txtGiaHoaDonPgg.Size = new Size(244, 42);
            txtGiaHoaDonPgg.TabIndex = 65;
            txtGiaHoaDonPgg.Texts = "";
            txtGiaHoaDonPgg.UnderlinedStyle = false;
            txtGiaHoaDonPgg._TextChanged += txtGiaHoaDonPgg__TextChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(73, 147);
            label5.Name = "label5";
            label5.Size = new Size(227, 51);
            label5.TabIndex = 64;
            label5.Text = "Giá Tối Thiểu Của Hóa Đơn";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(334, 147);
            label4.Name = "label4";
            label4.Size = new Size(166, 51);
            label4.TabIndex = 63;
            label4.Text = "Thời Gian Kết Thúc";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 65);
            label1.Name = "label1";
            label1.Size = new Size(79, 51);
            label1.TabIndex = 62;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PggView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 555);
            Controls.Add(tcPgg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PggView";
            Text = "PggView";
            tcPgg.ResumeLayout(false);
            listTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPgg).EndInit();
            gbSort.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            detailTabPage.ResumeLayout(false);
            detailTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcPgg;
        private TabPage listTabPage;
        private TabPage detailTabPage;
        private DataGridView dgvPgg;
        private CustomControl.CustomButton resetBtn;
        private CustomControl.CustomButton sortBtn;
        private GroupBox gbSort;
        private GroupBox groupBox1;
        private RadioButton rbTgKetThucDec;
        private RadioButton rbTgKetThucInc;
        private GroupBox groupBox2;
        private RadioButton rbIsDeleteDec;
        private RadioButton rbIsDeleteInc;
        private GroupBox groupBox3;
        private RadioButton rbIDDec;
        private RadioButton rbIDInc;
        private GroupBox groupBox4;
        private RadioButton rbGiaHoaDonDec;
        private RadioButton rbGiaHoaDonInc;
        private GroupBox groupBox5;
        private RadioButton rbTgBatDauDec;
        private RadioButton rbTgBatDauInc;
        private GroupBox groupBox6;
        private RadioButton rbPhanTramGiamGiaDec;
        private RadioButton rbPhanTramGiamGiaInc;
        private CustomControl.CustomButton delBtn;
        private CustomControl.CustomButton editBtn;
        private CustomControl.CustomButton addBtn;
        private CustomControl.CustomButton customButton2;
        private CheckBox checkboxIsDelete;
        private CustomControl.CustomButton HuyBtn;
        private CustomControl.CustomButton xacNhanBtn;
        private Label label6;
        private Label label7;
        private CustomControl.CustomButton btn_back;
        private Label label3;
        private CustomControl.CustomTextBox txtPhanTramGiamGiaPgg;
        private Label M;
        private CustomControl.CustomTextBox txtIdPgg;
        private CustomControl.CustomTextBox txtGiaHoaDonPgg;
        private Label label5;
        private Label label4;
        private Label label1;
        private DateTimePicker dtpTgBatDauPgg;
        private DateTimePicker dtpTgKetThucPgg;
    }
}