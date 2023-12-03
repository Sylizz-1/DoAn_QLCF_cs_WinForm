﻿namespace DoAn_QLCF_cs_WinForm.View
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
			tcNCC.Margin = new Padding(3, 2, 3, 2);
			tcNCC.Name = "tcNCC";
			tcNCC.SelectedIndex = 0;
			tcNCC.Size = new Size(970, 473);
			tcNCC.TabIndex = 0;
			// 
			// listTabPage
			// 
			listTabPage.Controls.Add(resetBtn);
			listTabPage.Controls.Add(gbSort);
			listTabPage.Controls.Add(filterBtn);
			listTabPage.Controls.Add(sortBtn);
			listTabPage.Controls.Add(dgvNcc);
			listTabPage.Controls.Add(searchTxt);
			listTabPage.Controls.Add(delBtn);
			listTabPage.Controls.Add(editBtn);
			listTabPage.Controls.Add(addBtn);
			listTabPage.Location = new Point(4, 24);
			listTabPage.Margin = new Padding(3, 2, 3, 2);
			listTabPage.Name = "listTabPage";
			listTabPage.Padding = new Padding(3, 2, 3, 2);
			listTabPage.Size = new Size(962, 445);
			listTabPage.TabIndex = 0;
			listTabPage.Text = "Danh Sách";
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
			resetBtn.Location = new Point(830, 104);
			resetBtn.Name = "resetBtn";
			resetBtn.Size = new Size(120, 38);
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
			gbSort.Location = new Point(24, 72);
			gbSort.Margin = new Padding(2, 2, 2, 2);
			gbSort.Name = "gbSort";
			gbSort.Padding = new Padding(2, 2, 2, 2);
			gbSort.Size = new Size(804, 90);
			gbSort.TabIndex = 27;
			gbSort.TabStop = false;
			gbSort.Visible = false;
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(rbDcDec);
			groupBox5.Controls.Add(rbDcInc);
			groupBox5.Location = new Point(282, 14);
			groupBox5.Margin = new Padding(2, 2, 2, 2);
			groupBox5.Name = "groupBox5";
			groupBox5.Padding = new Padding(2, 2, 2, 2);
			groupBox5.Size = new Size(98, 65);
			groupBox5.TabIndex = 24;
			groupBox5.TabStop = false;
			groupBox5.Text = "Địa chỉ";
			// 
			// rbDcDec
			// 
			rbDcDec.AutoSize = true;
			rbDcDec.Location = new Point(12, 39);
			rbDcDec.Margin = new Padding(2, 2, 2, 2);
			rbDcDec.Name = "rbDcDec";
			rbDcDec.Size = new Size(53, 19);
			rbDcDec.TabIndex = 1;
			rbDcDec.TabStop = true;
			rbDcDec.Tag = "DcDec";
			rbDcDec.Text = "Giảm";
			rbDcDec.UseVisualStyleBackColor = true;
			// 
			// rbDcInc
			// 
			rbDcInc.AutoSize = true;
			rbDcInc.Location = new Point(12, 18);
			rbDcInc.Margin = new Padding(2, 2, 2, 2);
			rbDcInc.Name = "rbDcInc";
			rbDcInc.Size = new Size(50, 19);
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
			groupBox6.Location = new Point(694, 14);
			groupBox6.Margin = new Padding(2, 2, 2, 2);
			groupBox6.Name = "groupBox6";
			groupBox6.Padding = new Padding(2, 2, 2, 2);
			groupBox6.Size = new Size(98, 65);
			groupBox6.TabIndex = 26;
			groupBox6.TabStop = false;
			groupBox6.Text = "IsDelete";
			// 
			// rbIsDeleteDec
			// 
			rbIsDeleteDec.AutoSize = true;
			rbIsDeleteDec.Location = new Point(12, 39);
			rbIsDeleteDec.Margin = new Padding(2, 2, 2, 2);
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
			rbIsDeleteInc.Location = new Point(12, 18);
			rbIsDeleteInc.Margin = new Padding(2, 2, 2, 2);
			rbIsDeleteInc.Name = "rbIsDeleteInc";
			rbIsDeleteInc.Size = new Size(50, 19);
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
			groupBox1.Location = new Point(8, 14);
			groupBox1.Margin = new Padding(2, 2, 2, 2);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(2, 2, 2, 2);
			groupBox1.Size = new Size(98, 65);
			groupBox1.TabIndex = 23;
			groupBox1.TabStop = false;
			groupBox1.Text = "ID";
			// 
			// rbIDDec
			// 
			rbIDDec.AutoSize = true;
			rbIDDec.Location = new Point(12, 39);
			rbIDDec.Margin = new Padding(2, 2, 2, 2);
			rbIDDec.Name = "rbIDDec";
			rbIDDec.Size = new Size(53, 19);
			rbIDDec.TabIndex = 1;
			rbIDDec.TabStop = true;
			rbIDDec.Tag = "IDDec";
			rbIDDec.Text = "Giảm";
			rbIDDec.UseVisualStyleBackColor = true;
			// 
			// rbIIDnc
			// 
			rbIIDnc.AutoSize = true;
			rbIIDnc.Location = new Point(12, 18);
			rbIIDnc.Margin = new Padding(2, 2, 2, 2);
			rbIIDnc.Name = "rbIIDnc";
			rbIIDnc.Size = new Size(50, 19);
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
			groupBox4.Location = new Point(419, 14);
			groupBox4.Margin = new Padding(2, 2, 2, 2);
			groupBox4.Name = "groupBox4";
			groupBox4.Padding = new Padding(2, 2, 2, 2);
			groupBox4.Size = new Size(98, 65);
			groupBox4.TabIndex = 24;
			groupBox4.TabStop = false;
			groupBox4.Text = "SĐT";
			// 
			// rbSdtDec
			// 
			rbSdtDec.AutoSize = true;
			rbSdtDec.Location = new Point(12, 39);
			rbSdtDec.Margin = new Padding(2, 2, 2, 2);
			rbSdtDec.Name = "rbSdtDec";
			rbSdtDec.Size = new Size(53, 19);
			rbSdtDec.TabIndex = 1;
			rbSdtDec.TabStop = true;
			rbSdtDec.Tag = "SdtDec";
			rbSdtDec.Text = "Giảm";
			rbSdtDec.UseVisualStyleBackColor = true;
			// 
			// rbSdtInc
			// 
			rbSdtInc.AutoSize = true;
			rbSdtInc.Location = new Point(12, 18);
			rbSdtInc.Margin = new Padding(2, 2, 2, 2);
			rbSdtInc.Name = "rbSdtInc";
			rbSdtInc.Size = new Size(50, 19);
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
			groupBox2.Location = new Point(145, 14);
			groupBox2.Margin = new Padding(2, 2, 2, 2);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(2, 2, 2, 2);
			groupBox2.Size = new Size(98, 65);
			groupBox2.TabIndex = 24;
			groupBox2.TabStop = false;
			groupBox2.Text = "Tên";
			// 
			// rbNameDec
			// 
			rbNameDec.AutoSize = true;
			rbNameDec.Location = new Point(12, 39);
			rbNameDec.Margin = new Padding(2, 2, 2, 2);
			rbNameDec.Name = "rbNameDec";
			rbNameDec.Size = new Size(53, 19);
			rbNameDec.TabIndex = 1;
			rbNameDec.TabStop = true;
			rbNameDec.Tag = "NameDec";
			rbNameDec.Text = "Giảm";
			rbNameDec.UseVisualStyleBackColor = true;
			// 
			// rbNameInc
			// 
			rbNameInc.AutoSize = true;
			rbNameInc.Location = new Point(12, 18);
			rbNameInc.Margin = new Padding(2, 2, 2, 2);
			rbNameInc.Name = "rbNameInc";
			rbNameInc.Size = new Size(50, 19);
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
			groupBox3.Location = new Point(556, 14);
			groupBox3.Margin = new Padding(2, 2, 2, 2);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(2, 2, 2, 2);
			groupBox3.Size = new Size(98, 65);
			groupBox3.TabIndex = 25;
			groupBox3.TabStop = false;
			groupBox3.Text = "Email";
			// 
			// rbEmailDec
			// 
			rbEmailDec.AutoSize = true;
			rbEmailDec.Location = new Point(12, 39);
			rbEmailDec.Margin = new Padding(2, 2, 2, 2);
			rbEmailDec.Name = "rbEmailDec";
			rbEmailDec.Size = new Size(53, 19);
			rbEmailDec.TabIndex = 1;
			rbEmailDec.TabStop = true;
			rbEmailDec.Tag = "EmailDec";
			rbEmailDec.Text = "Giảm";
			rbEmailDec.UseVisualStyleBackColor = true;
			// 
			// rbEmailInc
			// 
			rbEmailInc.AutoSize = true;
			rbEmailInc.Location = new Point(12, 18);
			rbEmailInc.Margin = new Padding(2, 2, 2, 2);
			rbEmailInc.Name = "rbEmailInc";
			rbEmailInc.Size = new Size(50, 19);
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
			filterBtn.Location = new Point(296, 5);
			filterBtn.Name = "filterBtn";
			filterBtn.Size = new Size(120, 38);
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
			sortBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
			sortBtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
			sortBtn.FlatStyle = FlatStyle.Flat;
			sortBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			sortBtn.ForeColor = Color.DeepSkyBlue;
			sortBtn.ImageAlign = ContentAlignment.MiddleRight;
			sortBtn.ImageHover = null;
			sortBtn.Location = new Point(429, 5);
			sortBtn.Name = "sortBtn";
			sortBtn.Size = new Size(120, 38);
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
			dgvNcc.Location = new Point(3, 144);
			dgvNcc.Name = "dgvNcc";
			dgvNcc.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dgvNcc.RowHeadersVisible = false;
			dgvNcc.RowHeadersWidth = 51;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvNcc.RowsDefaultCellStyle = dataGridViewCellStyle3;
			dgvNcc.RowTemplate.Height = 25;
			dgvNcc.RowTemplate.ReadOnly = true;
			dgvNcc.Size = new Size(956, 299);
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
			searchTxt.Location = new Point(6, 7);
			searchTxt.Multiline = false;
			searchTxt.Name = "searchTxt";
			searchTxt.Padding = new Padding(8, 7, 41, 7);
			searchTxt.PasswordChar = false;
			searchTxt.PlaceholderColor = Color.DarkGray;
			searchTxt.PlaceholderText = "Tìm Kiếm ...";
			searchTxt.Size = new Size(266, 36);
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
			delBtn.Location = new Point(828, 5);
			delBtn.Name = "delBtn";
			delBtn.Size = new Size(120, 38);
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
			editBtn.Location = new Point(695, 5);
			editBtn.Name = "editBtn";
			editBtn.Size = new Size(120, 38);
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
			addBtn.Location = new Point(562, 5);
			addBtn.Name = "addBtn";
			addBtn.Size = new Size(120, 38);
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
			detailTabPage.Location = new Point(4, 24);
			detailTabPage.Margin = new Padding(3, 2, 3, 2);
			detailTabPage.Name = "detailTabPage";
			detailTabPage.Padding = new Padding(3, 2, 3, 2);
			detailTabPage.Size = new Size(1052, 492);
			detailTabPage.TabIndex = 1;
			detailTabPage.Text = "Chi Tiết";
			detailTabPage.UseVisualStyleBackColor = true;
			// 
			// checkboxIsDelete
			// 
			checkboxIsDelete.AutoSize = true;
			checkboxIsDelete.Location = new Point(733, 182);
			checkboxIsDelete.Margin = new Padding(2, 2, 2, 2);
			checkboxIsDelete.Name = "checkboxIsDelete";
			checkboxIsDelete.Size = new Size(15, 14);
			checkboxIsDelete.TabIndex = 57;
			checkboxIsDelete.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(640, 164);
			label8.Name = "label8";
			label8.Size = new Size(78, 51);
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
			HuyBtn.Location = new Point(896, 413);
			HuyBtn.Name = "HuyBtn";
			HuyBtn.Size = new Size(137, 53);
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
			xacNhanBtn.Location = new Point(743, 413);
			xacNhanBtn.Name = "xacNhanBtn";
			xacNhanBtn.Size = new Size(137, 53);
			xacNhanBtn.TabIndex = 41;
			xacNhanBtn.Text = "  Xác Nhận";
			xacNhanBtn.TextColor = Color.DarkCyan;
			xacNhanBtn.TextHover = Color.White;
			xacNhanBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			xacNhanBtn.UseVisualStyleBackColor = false;
			xacNhanBtn.Click += xacNhanBtn_Click;
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
			txtSDTNcc.Location = new Point(626, 89);
			txtSDTNcc.Multiline = false;
			txtSDTNcc.Name = "txtSDTNcc";
			txtSDTNcc.Padding = new Padding(8, 9, 7, 7);
			txtSDTNcc.PasswordChar = false;
			txtSDTNcc.PlaceholderColor = Color.DarkGray;
			txtSDTNcc.PlaceholderText = "Nhập số điện thoại";
			txtSDTNcc.Size = new Size(244, 42);
			txtSDTNcc.TabIndex = 36;
			txtSDTNcc.Texts = "";
			txtSDTNcc.UnderlinedStyle = false;
			txtSDTNcc._TextChanged += txtSDTNcc__TextChanged;
			// 
			// label3
			// 
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(623, 49);
			label3.Name = "label3";
			label3.Size = new Size(132, 51);
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
			txtDiaChiNcc.Location = new Point(351, 89);
			txtDiaChiNcc.Multiline = false;
			txtDiaChiNcc.Name = "txtDiaChiNcc";
			txtDiaChiNcc.Padding = new Padding(8, 9, 7, 7);
			txtDiaChiNcc.PasswordChar = false;
			txtDiaChiNcc.PlaceholderColor = Color.DarkGray;
			txtDiaChiNcc.PlaceholderText = "Nhập địa chỉ";
			txtDiaChiNcc.Size = new Size(244, 42);
			txtDiaChiNcc.TabIndex = 34;
			txtDiaChiNcc.Texts = "";
			txtDiaChiNcc.UnderlinedStyle = false;
			txtDiaChiNcc._TextChanged += txtDiaChiNcc__TextChanged;
			// 
			// M
			// 
			M.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			M.Location = new Point(335, 50);
			M.Name = "M";
			M.Size = new Size(106, 51);
			M.TabIndex = 33;
			M.Text = "Địa Chỉ";
			M.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(98, 12);
			label7.Name = "label7";
			label7.Size = new Size(272, 43);
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
			btn_back.Location = new Point(20, 15);
			btn_back.Name = "btn_back";
			btn_back.Size = new Size(63, 41);
			btn_back.TabIndex = 31;
			btn_back.TextColor = Color.White;
			btn_back.TextHover = Color.White;
			btn_back.UseVisualStyleBackColor = false;
			btn_back.Click += btn_back_Click;
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
			txtIdNcc.Location = new Point(55, 89);
			txtIdNcc.Multiline = false;
			txtIdNcc.Name = "txtIdNcc";
			txtIdNcc.Padding = new Padding(8, 9, 7, 7);
			txtIdNcc.PasswordChar = false;
			txtIdNcc.PlaceholderColor = Color.DarkGray;
			txtIdNcc.PlaceholderText = "Nhập ID";
			txtIdNcc.Size = new Size(244, 42);
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
			txtEmailNcc.Location = new Point(351, 172);
			txtEmailNcc.Multiline = false;
			txtEmailNcc.Name = "txtEmailNcc";
			txtEmailNcc.Padding = new Padding(8, 9, 7, 7);
			txtEmailNcc.PasswordChar = false;
			txtEmailNcc.PlaceholderColor = Color.DarkGray;
			txtEmailNcc.PlaceholderText = "Nhập email";
			txtEmailNcc.Size = new Size(244, 42);
			txtEmailNcc.TabIndex = 29;
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
			txtTenNcc.Location = new Point(55, 172);
			txtTenNcc.Multiline = false;
			txtTenNcc.Name = "txtTenNcc";
			txtTenNcc.Padding = new Padding(8, 9, 7, 7);
			txtTenNcc.PasswordChar = false;
			txtTenNcc.PlaceholderColor = Color.DarkGray;
			txtTenNcc.PlaceholderText = "Nhập tên nhà cung cấp";
			txtTenNcc.Size = new Size(244, 42);
			txtTenNcc.TabIndex = 28;
			txtTenNcc.Texts = "";
			txtTenNcc.UnderlinedStyle = false;
			txtTenNcc._TextChanged += txtTenNcc__TextChanged;
			// 
			// label5
			// 
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(35, 132);
			label5.Name = "label5";
			label5.Size = new Size(78, 51);
			label5.TabIndex = 27;
			label5.Text = "Tên";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(335, 132);
			label4.Name = "label4";
			label4.Size = new Size(106, 51);
			label4.TabIndex = 26;
			label4.Text = "Email";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(38, 51);
			label1.Name = "label1";
			label1.Size = new Size(78, 51);
			label1.TabIndex = 25;
			label1.Text = "ID";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// NccView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(970, 473);
			Controls.Add(tcNCC);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
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
        private CustomControl.CustomButton filterBtn;
        private CustomControl.CustomButton sortBtn;
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
    }
}