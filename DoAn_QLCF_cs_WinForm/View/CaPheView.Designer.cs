namespace DoAn_QLCF_cs_WinForm.View
{
	partial class CaPheView
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
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			tabControl1 = new TabControl();
			listTab = new TabPage();
			label2 = new Label();
			sxCbx = new ComboBox();
			customButton2 = new CustomControl.CustomButton();
			delBtn = new CustomControl.CustomButton();
			editBtn = new CustomControl.CustomButton();
			addBtn = new CustomControl.CustomButton();
			searchTxt = new CustomControl.CustomTextBox();
			caPheDg = new DataGridView();
			detailsTab = new TabPage();
			label11 = new Label();
			isDeletedCb = new CheckBox();
			cpnlList = new DataGridView();
			HuyBtn = new CustomControl.CustomButton();
			customButton3 = new CustomControl.CustomButton();
			acceptCfBtn = new CustomControl.CustomButton();
			caPhePic = new PictureBox();
			label8 = new Label();
			label6 = new Label();
			giaTienTxt = new CustomControl.CustomTextBox();
			label3 = new Label();
			mieuTaTxt = new CustomControl.CustomTextBox();
			M = new Label();
			label7 = new Label();
			customButton4 = new CustomControl.CustomButton();
			idTxt = new CustomControl.CustomTextBox();
			xuatXuTxt = new CustomControl.CustomTextBox();
			tenTxt = new CustomControl.CustomTextBox();
			label5 = new Label();
			label4 = new Label();
			label1 = new Label();
			cpnlTab = new TabPage();
			label14 = new Label();
			label13 = new Label();
			label12 = new Label();
			khoiLuongTxt = new CustomControl.CustomTextBox();
			delCpnlBtn = new CustomControl.CustomButton();
			editCpnlBtn = new CustomControl.CustomButton();
			addCpnlBtn = new CustomControl.CustomButton();
			anhNguyenLieuPbx = new PictureBox();
			nguyenLieuCbx = new ComboBox();
			cpnlList2 = new DataGridView();
			label10 = new Label();
			customButton1 = new CustomControl.CustomButton();
			tabControl1.SuspendLayout();
			listTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)caPheDg).BeginInit();
			detailsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)cpnlList).BeginInit();
			((System.ComponentModel.ISupportInitialize)caPhePic).BeginInit();
			cpnlTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)anhNguyenLieuPbx).BeginInit();
			((System.ComponentModel.ISupportInitialize)cpnlList2).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(listTab);
			tabControl1.Controls.Add(detailsTab);
			tabControl1.Controls.Add(cpnlTab);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1077, 554);
			tabControl1.TabIndex = 2;
			// 
			// listTab
			// 
			listTab.BackColor = SystemColors.Control;
			listTab.Controls.Add(label2);
			listTab.Controls.Add(sxCbx);
			listTab.Controls.Add(customButton2);
			listTab.Controls.Add(delBtn);
			listTab.Controls.Add(editBtn);
			listTab.Controls.Add(addBtn);
			listTab.Controls.Add(searchTxt);
			listTab.Controls.Add(caPheDg);
			listTab.Location = new Point(4, 24);
			listTab.Name = "listTab";
			listTab.Padding = new Padding(3);
			listTab.Size = new Size(1069, 526);
			listTab.TabIndex = 0;
			listTab.Text = "Danh Sách";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(428, 11);
			label2.Name = "label2";
			label2.Size = new Size(73, 31);
			label2.TabIndex = 9;
			label2.Text = "Sắp xếp:";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// sxCbx
			// 
			sxCbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			sxCbx.DropDownStyle = ComboBoxStyle.DropDownList;
			sxCbx.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			sxCbx.FormattingEnabled = true;
			sxCbx.Items.AddRange(new object[] { "Id Tăng Dần", "Id Giảm Dần", "Giá Tăng Dần", "Giá Giảm Dần" });
			sxCbx.Location = new Point(516, 10);
			sxCbx.Name = "sxCbx";
			sxCbx.Size = new Size(121, 31);
			sxCbx.TabIndex = 7;
			sxCbx.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
			customButton2.Image = Properties.Resources.findIcon16px;
			customButton2.ImageHover = null;
			customButton2.Location = new Point(234, 10);
			customButton2.Name = "customButton2";
			customButton2.Size = new Size(35, 28);
			customButton2.TabIndex = 6;
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
			delBtn.Location = new Point(943, 6);
			delBtn.Name = "delBtn";
			delBtn.Size = new Size(121, 38);
			delBtn.TabIndex = 5;
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
			editBtn.Location = new Point(816, 6);
			editBtn.Name = "editBtn";
			editBtn.Size = new Size(121, 38);
			editBtn.TabIndex = 4;
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
			addBtn.Location = new Point(689, 6);
			addBtn.Name = "addBtn";
			addBtn.Size = new Size(121, 38);
			addBtn.TabIndex = 3;
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
			searchTxt.Location = new Point(8, 6);
			searchTxt.Multiline = false;
			searchTxt.Name = "searchTxt";
			searchTxt.Padding = new Padding(9, 7, 40, 7);
			searchTxt.PasswordChar = false;
			searchTxt.PlaceholderColor = Color.DarkGray;
			searchTxt.PlaceholderText = "Tìm Kiếm ...";
			searchTxt.Size = new Size(266, 36);
			searchTxt.TabIndex = 2;
			searchTxt.Texts = "";
			searchTxt.UnderlinedStyle = false;
			// 
			// caPheDg
			// 
			caPheDg.AllowUserToAddRows = false;
			caPheDg.AllowUserToDeleteRows = false;
			caPheDg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			caPheDg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			caPheDg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			caPheDg.BorderStyle = BorderStyle.None;
			caPheDg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.DarkCyan;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.Control;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			caPheDg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			caPheDg.ColumnHeadersHeight = 30;
			caPheDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			caPheDg.DefaultCellStyle = dataGridViewCellStyle2;
			caPheDg.EnableHeadersVisualStyles = false;
			caPheDg.GridColor = Color.DarkCyan;
			caPheDg.ImeMode = ImeMode.NoControl;
			caPheDg.Location = new Point(3, 128);
			caPheDg.Name = "caPheDg";
			caPheDg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			caPheDg.RowHeadersVisible = false;
			caPheDg.RowHeadersWidth = 51;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			caPheDg.RowsDefaultCellStyle = dataGridViewCellStyle3;
			caPheDg.RowTemplate.Height = 25;
			caPheDg.RowTemplate.ReadOnly = true;
			caPheDg.Size = new Size(1063, 395);
			caPheDg.TabIndex = 1;
			caPheDg.ColumnHeaderMouseClick += caPheDg_ColumnHeaderMouseClick;
			// 
			// detailsTab
			// 
			detailsTab.BackColor = SystemColors.Control;
			detailsTab.Controls.Add(label11);
			detailsTab.Controls.Add(isDeletedCb);
			detailsTab.Controls.Add(cpnlList);
			detailsTab.Controls.Add(HuyBtn);
			detailsTab.Controls.Add(customButton3);
			detailsTab.Controls.Add(acceptCfBtn);
			detailsTab.Controls.Add(caPhePic);
			detailsTab.Controls.Add(label8);
			detailsTab.Controls.Add(label6);
			detailsTab.Controls.Add(giaTienTxt);
			detailsTab.Controls.Add(label3);
			detailsTab.Controls.Add(mieuTaTxt);
			detailsTab.Controls.Add(M);
			detailsTab.Controls.Add(label7);
			detailsTab.Controls.Add(customButton4);
			detailsTab.Controls.Add(idTxt);
			detailsTab.Controls.Add(xuatXuTxt);
			detailsTab.Controls.Add(tenTxt);
			detailsTab.Controls.Add(label5);
			detailsTab.Controls.Add(label4);
			detailsTab.Controls.Add(label1);
			detailsTab.Location = new Point(4, 24);
			detailsTab.Name = "detailsTab";
			detailsTab.Padding = new Padding(3);
			detailsTab.Size = new Size(1069, 526);
			detailsTab.TabIndex = 1;
			detailsTab.Text = "Chi Tiết";
			// 
			// label11
			// 
			label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label11.Location = new Point(6, 258);
			label11.Name = "label11";
			label11.Size = new Size(116, 32);
			label11.TabIndex = 55;
			label11.Text = "Nguyên Liệu";
			label11.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// isDeletedCb
			// 
			isDeletedCb.Location = new Point(659, 181);
			isDeletedCb.Name = "isDeletedCb";
			isDeletedCb.Size = new Size(49, 27);
			isDeletedCb.TabIndex = 54;
			isDeletedCb.UseVisualStyleBackColor = true;
			// 
			// cpnlList
			// 
			cpnlList.AllowUserToAddRows = false;
			cpnlList.AllowUserToDeleteRows = false;
			cpnlList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			cpnlList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			cpnlList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			cpnlList.BorderStyle = BorderStyle.None;
			cpnlList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = Color.DarkCyan;
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = SystemColors.Control;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			cpnlList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			cpnlList.ColumnHeadersHeight = 30;
			cpnlList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = SystemColors.Window;
			dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
			cpnlList.DefaultCellStyle = dataGridViewCellStyle5;
			cpnlList.EnableHeadersVisualStyles = false;
			cpnlList.GridColor = Color.DarkCyan;
			cpnlList.ImeMode = ImeMode.NoControl;
			cpnlList.Location = new Point(3, 315);
			cpnlList.Name = "cpnlList";
			cpnlList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			cpnlList.RowHeadersVisible = false;
			cpnlList.RowHeadersWidth = 51;
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
			cpnlList.RowsDefaultCellStyle = dataGridViewCellStyle6;
			cpnlList.RowTemplate.Height = 25;
			cpnlList.RowTemplate.ReadOnly = true;
			cpnlList.Size = new Size(1063, 215);
			cpnlList.TabIndex = 53;
			// 
			// HuyBtn
			// 
			HuyBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
			HuyBtn.Location = new Point(942, 10);
			HuyBtn.Name = "HuyBtn";
			HuyBtn.Size = new Size(117, 40);
			HuyBtn.TabIndex = 26;
			HuyBtn.Text = "  Hủy";
			HuyBtn.TextColor = Color.Red;
			HuyBtn.TextHover = Color.White;
			HuyBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			HuyBtn.UseVisualStyleBackColor = false;
			HuyBtn.Click += HuyBtn_Click;
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
			customButton3.ImageAlign = ContentAlignment.MiddleRight;
			customButton3.ImageHover = null;
			customButton3.Location = new Point(836, 258);
			customButton3.Name = "customButton3";
			customButton3.Size = new Size(230, 40);
			customButton3.TabIndex = 25;
			customButton3.Text = "  Điều Chỉnh Nguyên Liệu";
			customButton3.TextColor = Color.DarkCyan;
			customButton3.TextHover = Color.White;
			customButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
			customButton3.UseVisualStyleBackColor = false;
			customButton3.Click += customButton3_Click;
			// 
			// acceptCfBtn
			// 
			acceptCfBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			acceptCfBtn.BackColor = SystemColors.Control;
			acceptCfBtn.BackgroundColor = SystemColors.Control;
			acceptCfBtn.BorderColor = Color.DarkCyan;
			acceptCfBtn.BorderRadius = 15;
			acceptCfBtn.BorderSize = 2;
			acceptCfBtn.Cursor = Cursors.Hand;
			acceptCfBtn.EnabledTextHover = true;
			acceptCfBtn.FlatAppearance.BorderSize = 0;
			acceptCfBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
			acceptCfBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
			acceptCfBtn.FlatStyle = FlatStyle.Flat;
			acceptCfBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			acceptCfBtn.ForeColor = Color.DarkCyan;
			acceptCfBtn.Image = Properties.Resources.ConfirmIcondarkcyan1;
			acceptCfBtn.ImageAlign = ContentAlignment.MiddleRight;
			acceptCfBtn.ImageHover = Properties.Resources.ConfirmIconWhite1;
			acceptCfBtn.Location = new Point(805, 9);
			acceptCfBtn.Name = "acceptCfBtn";
			acceptCfBtn.Size = new Size(131, 40);
			acceptCfBtn.TabIndex = 25;
			acceptCfBtn.Text = "  Xác Nhận";
			acceptCfBtn.TextColor = Color.DarkCyan;
			acceptCfBtn.TextHover = Color.White;
			acceptCfBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			acceptCfBtn.UseVisualStyleBackColor = false;
			// 
			// caPhePic
			// 
			caPhePic.BackColor = SystemColors.ActiveBorder;
			caPhePic.BackgroundImageLayout = ImageLayout.None;
			caPhePic.Cursor = Cursors.Hand;
			caPhePic.Image = Properties.Resources.defaultImage3;
			caPhePic.Location = new Point(888, 83);
			caPhePic.Name = "caPhePic";
			caPhePic.Size = new Size(150, 125);
			caPhePic.SizeMode = PictureBoxSizeMode.StretchImage;
			caPhePic.TabIndex = 24;
			caPhePic.TabStop = false;
			caPhePic.Click += caPhePic_Click;
			// 
			// label8
			// 
			label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(871, 56);
			label8.Name = "label8";
			label8.Size = new Size(106, 29);
			label8.TabIndex = 23;
			label8.Text = "Hình Ảnh";
			label8.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(619, 127);
			label6.Name = "label6";
			label6.Size = new Size(106, 51);
			label6.TabIndex = 21;
			label6.Text = "IsDeleted";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// giaTienTxt
			// 
			giaTienTxt.BackColor = SystemColors.Window;
			giaTienTxt.BorderColor = Color.Silver;
			giaTienTxt.BorderFocusColor = Color.DarkCyan;
			giaTienTxt.BorderRadius = 13;
			giaTienTxt.BorderSize = 2;
			giaTienTxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			giaTienTxt.ForeColor = Color.DimGray;
			giaTienTxt.Location = new Point(621, 83);
			giaTienTxt.Multiline = false;
			giaTienTxt.Name = "giaTienTxt";
			giaTienTxt.Padding = new Padding(9, 9, 7, 7);
			giaTienTxt.PasswordChar = false;
			giaTienTxt.PlaceholderColor = Color.DarkGray;
			giaTienTxt.PlaceholderText = "Nhập giá tiền....";
			giaTienTxt.Size = new Size(244, 42);
			giaTienTxt.TabIndex = 20;
			giaTienTxt.Texts = "";
			giaTienTxt.UnderlinedStyle = false;
			giaTienTxt.KeyPress += khoiLuongTxt_KeyPress;
			// 
			// label3
			// 
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(619, 43);
			label3.Name = "label3";
			label3.Size = new Size(123, 51);
			label3.TabIndex = 19;
			label3.Text = "Giá Tiền (Kg)";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// mieuTaTxt
			// 
			mieuTaTxt.BackColor = SystemColors.Window;
			mieuTaTxt.BorderColor = Color.Silver;
			mieuTaTxt.BorderFocusColor = Color.DarkCyan;
			mieuTaTxt.BorderRadius = 13;
			mieuTaTxt.BorderSize = 2;
			mieuTaTxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			mieuTaTxt.ForeColor = Color.DimGray;
			mieuTaTxt.Location = new Point(347, 83);
			mieuTaTxt.Multiline = false;
			mieuTaTxt.Name = "mieuTaTxt";
			mieuTaTxt.Padding = new Padding(9, 9, 7, 7);
			mieuTaTxt.PasswordChar = false;
			mieuTaTxt.PlaceholderColor = Color.DarkGray;
			mieuTaTxt.PlaceholderText = "Nhập miêu tả....";
			mieuTaTxt.Size = new Size(244, 42);
			mieuTaTxt.TabIndex = 18;
			mieuTaTxt.Texts = "";
			mieuTaTxt.UnderlinedStyle = false;
			// 
			// M
			// 
			M.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			M.Location = new Point(330, 44);
			M.Name = "M";
			M.Size = new Size(106, 51);
			M.TabIndex = 17;
			M.Text = "Miêu Tả";
			M.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(94, 6);
			label7.Name = "label7";
			label7.Size = new Size(268, 43);
			label7.TabIndex = 16;
			label7.Text = "Thông Tin Chi Tiết";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// customButton4
			// 
			customButton4.BackColor = Color.Transparent;
			customButton4.BackgroundColor = Color.Transparent;
			customButton4.BorderColor = Color.PaleVioletRed;
			customButton4.BorderRadius = 20;
			customButton4.BorderSize = 0;
			customButton4.Cursor = Cursors.Hand;
			customButton4.EnabledTextHover = false;
			customButton4.FlatAppearance.BorderSize = 0;
			customButton4.FlatAppearance.MouseDownBackColor = Color.Teal;
			customButton4.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
			customButton4.FlatStyle = FlatStyle.Flat;
			customButton4.ForeColor = Color.White;
			customButton4.Image = Properties.Resources.arrowreturn32pxBlack1;
			customButton4.ImageHover = Properties.Resources.arrowreturn32pxWhite1;
			customButton4.Location = new Point(15, 9);
			customButton4.Name = "customButton4";
			customButton4.Size = new Size(63, 41);
			customButton4.TabIndex = 15;
			customButton4.TextColor = Color.White;
			customButton4.TextHover = Color.White;
			customButton4.UseVisualStyleBackColor = false;
			customButton4.Click += customButton4_Click;
			// 
			// idTxt
			// 
			idTxt.BackColor = SystemColors.Window;
			idTxt.BorderColor = Color.Silver;
			idTxt.BorderFocusColor = Color.DarkCyan;
			idTxt.BorderRadius = 13;
			idTxt.BorderSize = 2;
			idTxt.Enabled = false;
			idTxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			idTxt.ForeColor = Color.DimGray;
			idTxt.Location = new Point(50, 83);
			idTxt.Multiline = false;
			idTxt.Name = "idTxt";
			idTxt.Padding = new Padding(9, 9, 7, 7);
			idTxt.PasswordChar = false;
			idTxt.PlaceholderColor = Color.DarkGray;
			idTxt.PlaceholderText = "Nhập ID....";
			idTxt.Size = new Size(244, 42);
			idTxt.TabIndex = 14;
			idTxt.Texts = "";
			idTxt.UnderlinedStyle = false;
			// 
			// xuatXuTxt
			// 
			xuatXuTxt.BackColor = SystemColors.Window;
			xuatXuTxt.BorderColor = Color.Silver;
			xuatXuTxt.BorderFocusColor = Color.DarkCyan;
			xuatXuTxt.BorderRadius = 13;
			xuatXuTxt.BorderSize = 2;
			xuatXuTxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			xuatXuTxt.ForeColor = Color.DimGray;
			xuatXuTxt.Location = new Point(347, 166);
			xuatXuTxt.Multiline = false;
			xuatXuTxt.Name = "xuatXuTxt";
			xuatXuTxt.Padding = new Padding(9, 9, 7, 7);
			xuatXuTxt.PasswordChar = false;
			xuatXuTxt.PlaceholderColor = Color.DarkGray;
			xuatXuTxt.PlaceholderText = "Nhập xuất xứ....";
			xuatXuTxt.Size = new Size(244, 42);
			xuatXuTxt.TabIndex = 8;
			xuatXuTxt.Texts = "";
			xuatXuTxt.UnderlinedStyle = false;
			// 
			// tenTxt
			// 
			tenTxt.BackColor = SystemColors.Window;
			tenTxt.BorderColor = Color.Silver;
			tenTxt.BorderFocusColor = Color.DarkCyan;
			tenTxt.BorderRadius = 13;
			tenTxt.BorderSize = 2;
			tenTxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			tenTxt.ForeColor = Color.DimGray;
			tenTxt.Location = new Point(50, 166);
			tenTxt.Multiline = false;
			tenTxt.Name = "tenTxt";
			tenTxt.Padding = new Padding(9, 9, 7, 7);
			tenTxt.PasswordChar = false;
			tenTxt.PlaceholderColor = Color.DarkGray;
			tenTxt.PlaceholderText = "Nhập tên cà phê....";
			tenTxt.Size = new Size(244, 42);
			tenTxt.TabIndex = 7;
			tenTxt.Texts = "";
			tenTxt.UnderlinedStyle = false;
			// 
			// label5
			// 
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(31, 126);
			label5.Name = "label5";
			label5.Size = new Size(79, 51);
			label5.TabIndex = 4;
			label5.Text = "Tên";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(330, 127);
			label4.Name = "label4";
			label4.Size = new Size(106, 51);
			label4.TabIndex = 3;
			label4.Text = "Xuất Xứ";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(33, 45);
			label1.Name = "label1";
			label1.Size = new Size(79, 51);
			label1.TabIndex = 0;
			label1.Text = "ID";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// cpnlTab
			// 
			cpnlTab.BackColor = SystemColors.Control;
			cpnlTab.Controls.Add(label14);
			cpnlTab.Controls.Add(label13);
			cpnlTab.Controls.Add(label12);
			cpnlTab.Controls.Add(khoiLuongTxt);
			cpnlTab.Controls.Add(delCpnlBtn);
			cpnlTab.Controls.Add(editCpnlBtn);
			cpnlTab.Controls.Add(addCpnlBtn);
			cpnlTab.Controls.Add(anhNguyenLieuPbx);
			cpnlTab.Controls.Add(nguyenLieuCbx);
			cpnlTab.Controls.Add(cpnlList2);
			cpnlTab.Controls.Add(label10);
			cpnlTab.Controls.Add(customButton1);
			cpnlTab.Location = new Point(4, 24);
			cpnlTab.Name = "cpnlTab";
			cpnlTab.Size = new Size(1069, 526);
			cpnlTab.TabIndex = 2;
			cpnlTab.Text = "Chi Tiết Nguyên Liệu";
			// 
			// label14
			// 
			label14.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label14.Location = new Point(561, 123);
			label14.Name = "label14";
			label14.Size = new Size(46, 31);
			label14.TabIndex = 62;
			label14.Text = "Kg";
			label14.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label13.Location = new Point(405, 84);
			label13.Name = "label13";
			label13.Size = new Size(113, 31);
			label13.TabIndex = 61;
			label13.Text = "Khối Lượng";
			label13.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label12.Location = new Point(-5, 84);
			label12.Name = "label12";
			label12.Size = new Size(129, 31);
			label12.TabIndex = 61;
			label12.Text = "Nguyên Liệu";
			label12.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// khoiLuongTxt
			// 
			khoiLuongTxt.BackColor = SystemColors.Window;
			khoiLuongTxt.BorderColor = Color.Silver;
			khoiLuongTxt.BorderFocusColor = Color.DarkCyan;
			khoiLuongTxt.BorderRadius = 13;
			khoiLuongTxt.BorderSize = 2;
			khoiLuongTxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			khoiLuongTxt.ForeColor = Color.DimGray;
			khoiLuongTxt.Location = new Point(409, 118);
			khoiLuongTxt.Multiline = false;
			khoiLuongTxt.Name = "khoiLuongTxt";
			khoiLuongTxt.Padding = new Padding(9, 9, 7, 7);
			khoiLuongTxt.PasswordChar = false;
			khoiLuongTxt.PlaceholderColor = Color.DarkGray;
			khoiLuongTxt.PlaceholderText = "Khối Lượng...";
			khoiLuongTxt.Size = new Size(150, 42);
			khoiLuongTxt.TabIndex = 60;
			khoiLuongTxt.Texts = "";
			khoiLuongTxt.UnderlinedStyle = false;
			khoiLuongTxt.KeyPress += khoiLuongTxt_KeyPress;
			// 
			// delCpnlBtn
			// 
			delCpnlBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			delCpnlBtn.BackColor = SystemColors.Control;
			delCpnlBtn.BackgroundColor = SystemColors.Control;
			delCpnlBtn.BorderColor = Color.Red;
			delCpnlBtn.BorderRadius = 15;
			delCpnlBtn.BorderSize = 2;
			delCpnlBtn.Cursor = Cursors.Hand;
			delCpnlBtn.EnabledTextHover = true;
			delCpnlBtn.FlatAppearance.BorderSize = 0;
			delCpnlBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
			delCpnlBtn.FlatAppearance.MouseOverBackColor = Color.Red;
			delCpnlBtn.FlatStyle = FlatStyle.Flat;
			delCpnlBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			delCpnlBtn.ForeColor = Color.Red;
			delCpnlBtn.Image = Properties.Resources.deleteIconRed16px;
			delCpnlBtn.ImageHover = Properties.Resources.deleteIconWhite16px;
			delCpnlBtn.Location = new Point(920, 178);
			delCpnlBtn.Name = "delCpnlBtn";
			delCpnlBtn.Size = new Size(58, 38);
			delCpnlBtn.TabIndex = 59;
			delCpnlBtn.TextColor = Color.Red;
			delCpnlBtn.TextHover = Color.White;
			delCpnlBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			delCpnlBtn.UseVisualStyleBackColor = false;
			// 
			// editCpnlBtn
			// 
			editCpnlBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			editCpnlBtn.BackColor = SystemColors.Control;
			editCpnlBtn.BackgroundColor = SystemColors.Control;
			editCpnlBtn.BorderColor = Color.DarkCyan;
			editCpnlBtn.BorderRadius = 15;
			editCpnlBtn.BorderSize = 2;
			editCpnlBtn.Cursor = Cursors.Hand;
			editCpnlBtn.EnabledTextHover = true;
			editCpnlBtn.FlatAppearance.BorderSize = 0;
			editCpnlBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
			editCpnlBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
			editCpnlBtn.FlatStyle = FlatStyle.Flat;
			editCpnlBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			editCpnlBtn.ForeColor = Color.DarkCyan;
			editCpnlBtn.Image = Properties.Resources.fixNLdarkcyan;
			editCpnlBtn.ImageHover = Properties.Resources.fixNLWHITE;
			editCpnlBtn.Location = new Point(920, 122);
			editCpnlBtn.Name = "editCpnlBtn";
			editCpnlBtn.Size = new Size(58, 38);
			editCpnlBtn.TabIndex = 58;
			editCpnlBtn.TextColor = Color.DarkCyan;
			editCpnlBtn.TextHover = Color.White;
			editCpnlBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			editCpnlBtn.UseVisualStyleBackColor = false;
			// 
			// addCpnlBtn
			// 
			addCpnlBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			addCpnlBtn.BackColor = SystemColors.Control;
			addCpnlBtn.BackgroundColor = SystemColors.Control;
			addCpnlBtn.BorderColor = Color.DarkCyan;
			addCpnlBtn.BorderRadius = 15;
			addCpnlBtn.BorderSize = 2;
			addCpnlBtn.Cursor = Cursors.Hand;
			addCpnlBtn.EnabledTextHover = true;
			addCpnlBtn.FlatAppearance.BorderSize = 0;
			addCpnlBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
			addCpnlBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
			addCpnlBtn.FlatStyle = FlatStyle.Flat;
			addCpnlBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			addCpnlBtn.ForeColor = Color.DarkCyan;
			addCpnlBtn.Image = Properties.Resources.addIconTeal16px;
			addCpnlBtn.ImageHover = Properties.Resources.addIconWhite16px;
			addCpnlBtn.Location = new Point(920, 64);
			addCpnlBtn.Name = "addCpnlBtn";
			addCpnlBtn.Size = new Size(58, 38);
			addCpnlBtn.TabIndex = 57;
			addCpnlBtn.TextColor = Color.DarkCyan;
			addCpnlBtn.TextHover = Color.White;
			addCpnlBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			addCpnlBtn.UseVisualStyleBackColor = false;
			// 
			// anhNguyenLieuPbx
			// 
			anhNguyenLieuPbx.Location = new Point(272, 102);
			anhNguyenLieuPbx.Name = "anhNguyenLieuPbx";
			anhNguyenLieuPbx.Size = new Size(114, 87);
			anhNguyenLieuPbx.SizeMode = PictureBoxSizeMode.StretchImage;
			anhNguyenLieuPbx.TabIndex = 56;
			anhNguyenLieuPbx.TabStop = false;
			// 
			// nguyenLieuCbx
			// 
			nguyenLieuCbx.DropDownStyle = ComboBoxStyle.DropDownList;
			nguyenLieuCbx.FormattingEnabled = true;
			nguyenLieuCbx.Location = new Point(10, 119);
			nguyenLieuCbx.Name = "nguyenLieuCbx";
			nguyenLieuCbx.Size = new Size(220, 23);
			nguyenLieuCbx.TabIndex = 55;
			nguyenLieuCbx.SelectedIndexChanged += NguyenLieuCbx_SelectedIndexChanged;
			// 
			// cpnlList2
			// 
			cpnlList2.AllowUserToAddRows = false;
			cpnlList2.AllowUserToDeleteRows = false;
			cpnlList2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			cpnlList2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			cpnlList2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			cpnlList2.BorderStyle = BorderStyle.None;
			cpnlList2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = Color.DarkCyan;
			dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle7.ForeColor = SystemColors.Control;
			dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			cpnlList2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			cpnlList2.ColumnHeadersHeight = 30;
			cpnlList2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = SystemColors.Window;
			dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
			cpnlList2.DefaultCellStyle = dataGridViewCellStyle8;
			cpnlList2.EnableHeadersVisualStyles = false;
			cpnlList2.GridColor = Color.DarkCyan;
			cpnlList2.ImeMode = ImeMode.NoControl;
			cpnlList2.Location = new Point(3, 246);
			cpnlList2.Name = "cpnlList2";
			cpnlList2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			cpnlList2.RowHeadersVisible = false;
			cpnlList2.RowHeadersWidth = 51;
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
			cpnlList2.RowsDefaultCellStyle = dataGridViewCellStyle9;
			cpnlList2.RowTemplate.Height = 25;
			cpnlList2.RowTemplate.ReadOnly = true;
			cpnlList2.Size = new Size(1063, 284);
			cpnlList2.TabIndex = 54;
			cpnlList2.SelectionChanged += cpnlList2_SelectionChanged;
			// 
			// label10
			// 
			label10.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
			label10.Location = new Point(84, 9);
			label10.Name = "label10";
			label10.Size = new Size(302, 43);
			label10.TabIndex = 18;
			label10.Text = "Điều Chỉnh Nguyên Liệu";
			label10.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// customButton1
			// 
			customButton1.BackColor = Color.Transparent;
			customButton1.BackgroundColor = Color.Transparent;
			customButton1.BorderColor = Color.PaleVioletRed;
			customButton1.BorderRadius = 20;
			customButton1.BorderSize = 0;
			customButton1.Cursor = Cursors.Hand;
			customButton1.EnabledTextHover = false;
			customButton1.FlatAppearance.BorderSize = 0;
			customButton1.FlatAppearance.MouseDownBackColor = Color.Teal;
			customButton1.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
			customButton1.FlatStyle = FlatStyle.Flat;
			customButton1.ForeColor = Color.White;
			customButton1.Image = Properties.Resources.arrowreturn32pxBlack1;
			customButton1.ImageHover = Properties.Resources.arrowreturn32pxWhite1;
			customButton1.Location = new Point(15, 9);
			customButton1.Name = "customButton1";
			customButton1.Size = new Size(63, 41);
			customButton1.TabIndex = 17;
			customButton1.TextColor = Color.White;
			customButton1.TextHover = Color.White;
			customButton1.UseVisualStyleBackColor = false;
			customButton1.Click += customButton1_Click;
			// 
			// CaPheView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1077, 554);
			Controls.Add(tabControl1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "CaPheView";
			Text = "CaPheView";
			tabControl1.ResumeLayout(false);
			listTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)caPheDg).EndInit();
			detailsTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)cpnlList).EndInit();
			((System.ComponentModel.ISupportInitialize)caPhePic).EndInit();
			cpnlTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)anhNguyenLieuPbx).EndInit();
			((System.ComponentModel.ISupportInitialize)cpnlList2).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private TabControl tabControl1;
		private TabPage listTab;
		private DataGridView caPheDg;
		private CustomControl.CustomButton addBtn;
		private CustomControl.CustomTextBox searchTxt;
		private TabPage detailsTab;
		private Label label5;
		private Label label4;
		private Label label1;
		private CustomControl.CustomTextBox xuatXuTxt;
		private CustomControl.CustomTextBox tenTxt;
		private CustomControl.CustomTextBox idTxt;
		private CustomControl.CustomButton editBtn;
		private CustomControl.CustomButton delBtn;
		private CustomControl.CustomButton customButton2;
		private ComboBox sxCbx;
		private CustomControl.CustomButton customButton4;
		private Label label7;
		private Label label6;
		private CustomControl.CustomTextBox giaTienTxt;
		private Label label3;
		private CustomControl.CustomTextBox mieuTaTxt;
		private Label M;
		private Label label8;
		private PictureBox caPhePic;
		private CustomControl.CustomButton acceptCfBtn;
		private CustomControl.CustomButton HuyBtn;
		private Label label2;
		private TabPage cpnlTab;
		private DataGridView cpnlList;
		private Label label10;
		private CustomControl.CustomButton customButton1;
		private Label label11;
		private CheckBox isDeletedCb;
		private DataGridView cpnlList2;
		private CustomControl.CustomButton customButton3;
		private PictureBox anhNguyenLieuPbx;
		private ComboBox nguyenLieuCbx;
		private CustomControl.CustomButton delCpnlBtn;
		private CustomControl.CustomButton editCpnlBtn;
		private CustomControl.CustomButton addCpnlBtn;
		private CustomControl.CustomTextBox khoiLuongTxt;
		private Label label13;
		private Label label12;
		private Label label14;

		
	}
}