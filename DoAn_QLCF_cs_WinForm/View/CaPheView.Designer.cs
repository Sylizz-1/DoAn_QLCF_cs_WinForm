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
			tabControl1 = new TabControl();
			listTabPage = new TabPage();
			comboBox2 = new ComboBox();
			comboBox1 = new ComboBox();
			customButton2 = new CustomControl.CustomButton();
			delBtn = new CustomControl.CustomButton();
			editBtn = new CustomControl.CustomButton();
			addBtn = new CustomControl.CustomButton();
			searchTxt = new CustomControl.CustomTextBox();
			dataGridView1 = new DataGridView();
			DetailsTabPage = new TabPage();
			caPhePic = new PictureBox();
			label8 = new Label();
			customTextBox5 = new CustomControl.CustomTextBox();
			label6 = new Label();
			customTextBox4 = new CustomControl.CustomTextBox();
			label3 = new Label();
			customTextBox1 = new CustomControl.CustomTextBox();
			M = new Label();
			label7 = new Label();
			customButton4 = new CustomControl.CustomButton();
			idTxt = new CustomControl.CustomTextBox();
			customTextBox3 = new CustomControl.CustomTextBox();
			customTextBox2 = new CustomControl.CustomTextBox();
			label5 = new Label();
			label4 = new Label();
			label1 = new Label();
			xacNhanBtn = new CustomControl.CustomButton();
			HuyBtn = new CustomControl.CustomButton();
			tabControl1.SuspendLayout();
			listTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			DetailsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)caPhePic).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(listTabPage);
			tabControl1.Controls.Add(DetailsTabPage);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1077, 554);
			tabControl1.TabIndex = 2;
			// 
			// listTabPage
			// 
			listTabPage.BackColor = SystemColors.Control;
			listTabPage.Controls.Add(comboBox2);
			listTabPage.Controls.Add(comboBox1);
			listTabPage.Controls.Add(customButton2);
			listTabPage.Controls.Add(delBtn);
			listTabPage.Controls.Add(editBtn);
			listTabPage.Controls.Add(addBtn);
			listTabPage.Controls.Add(searchTxt);
			listTabPage.Controls.Add(dataGridView1);
			listTabPage.Location = new Point(4, 24);
			listTabPage.Name = "listTabPage";
			listTabPage.Padding = new Padding(3);
			listTabPage.Size = new Size(1069, 526);
			listTabPage.TabIndex = 0;
			listTabPage.Text = "Danh Sách";
			// 
			// comboBox2
			// 
			comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			comboBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(322, 10);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(164, 31);
			comboBox2.TabIndex = 8;
			// 
			// comboBox1
			// 
			comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			comboBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(492, 10);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(164, 31);
			comboBox1.TabIndex = 7;
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
			// dataGridView1
			// 
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(3, 81);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(1063, 442);
			dataGridView1.TabIndex = 1;
			// 
			// DetailsTabPage
			// 
			DetailsTabPage.BackColor = SystemColors.Control;
			DetailsTabPage.Controls.Add(HuyBtn);
			DetailsTabPage.Controls.Add(xacNhanBtn);
			DetailsTabPage.Controls.Add(caPhePic);
			DetailsTabPage.Controls.Add(label8);
			DetailsTabPage.Controls.Add(customTextBox5);
			DetailsTabPage.Controls.Add(label6);
			DetailsTabPage.Controls.Add(customTextBox4);
			DetailsTabPage.Controls.Add(label3);
			DetailsTabPage.Controls.Add(customTextBox1);
			DetailsTabPage.Controls.Add(M);
			DetailsTabPage.Controls.Add(label7);
			DetailsTabPage.Controls.Add(customButton4);
			DetailsTabPage.Controls.Add(idTxt);
			DetailsTabPage.Controls.Add(customTextBox3);
			DetailsTabPage.Controls.Add(customTextBox2);
			DetailsTabPage.Controls.Add(label5);
			DetailsTabPage.Controls.Add(label4);
			DetailsTabPage.Controls.Add(label1);
			DetailsTabPage.Location = new Point(4, 24);
			DetailsTabPage.Name = "DetailsTabPage";
			DetailsTabPage.Padding = new Padding(3);
			DetailsTabPage.Size = new Size(1069, 526);
			DetailsTabPage.TabIndex = 1;
			DetailsTabPage.Text = "Chi Tiết";
			// 
			// caPhePic
			// 
			caPhePic.BackColor = SystemColors.ActiveBorder;
			caPhePic.BackgroundImageLayout = ImageLayout.None;
			caPhePic.Cursor = Cursors.Hand;
			caPhePic.Image = Properties.Resources.defaultImage3;
			caPhePic.Location = new Point(660, 83);
			caPhePic.Name = "caPhePic";
			caPhePic.Size = new Size(147, 125);
			caPhePic.SizeMode = PictureBoxSizeMode.Zoom;
			caPhePic.TabIndex = 24;
			caPhePic.TabStop = false;
			caPhePic.Click += caPhePic_Click;
			// 
			// label8
			// 
			label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(642, 56);
			label8.Name = "label8";
			label8.Size = new Size(106, 29);
			label8.TabIndex = 23;
			label8.Text = "Hình Ảnh";
			label8.TextAlign = ContentAlignment.MiddleCenter;
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
			customTextBox5.Location = new Point(347, 255);
			customTextBox5.Multiline = false;
			customTextBox5.Name = "customTextBox5";
			customTextBox5.Padding = new Padding(9, 9, 7, 7);
			customTextBox5.PasswordChar = false;
			customTextBox5.PlaceholderColor = Color.DarkGray;
			customTextBox5.PlaceholderText = "Tìm Kiếm ...";
			customTextBox5.Size = new Size(244, 42);
			customTextBox5.TabIndex = 22;
			customTextBox5.Texts = "";
			customTextBox5.UnderlinedStyle = false;
			// 
			// label6
			// 
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(330, 216);
			label6.Name = "label6";
			label6.Size = new Size(106, 51);
			label6.TabIndex = 21;
			label6.Text = "IsDelete";
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
			customTextBox4.Location = new Point(347, 166);
			customTextBox4.Multiline = false;
			customTextBox4.Name = "customTextBox4";
			customTextBox4.Padding = new Padding(9, 9, 7, 7);
			customTextBox4.PasswordChar = false;
			customTextBox4.PlaceholderColor = Color.DarkGray;
			customTextBox4.PlaceholderText = "Nhập giá tiền....";
			customTextBox4.Size = new Size(244, 42);
			customTextBox4.TabIndex = 20;
			customTextBox4.Texts = "";
			customTextBox4.UnderlinedStyle = false;
			// 
			// label3
			// 
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(345, 126);
			label3.Name = "label3";
			label3.Size = new Size(106, 51);
			label3.TabIndex = 19;
			label3.Text = "Giá Tiền (Kg)";
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
			customTextBox1.Location = new Point(347, 83);
			customTextBox1.Multiline = false;
			customTextBox1.Name = "customTextBox1";
			customTextBox1.Padding = new Padding(9, 9, 7, 7);
			customTextBox1.PasswordChar = false;
			customTextBox1.PlaceholderColor = Color.DarkGray;
			customTextBox1.PlaceholderText = "Nhập miêu tả....";
			customTextBox1.Size = new Size(244, 42);
			customTextBox1.TabIndex = 18;
			customTextBox1.Texts = "";
			customTextBox1.UnderlinedStyle = false;
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
			label7.Size = new Size(210, 43);
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
			// customTextBox3
			// 
			customTextBox3.BackColor = SystemColors.Window;
			customTextBox3.BorderColor = Color.Silver;
			customTextBox3.BorderFocusColor = Color.DarkCyan;
			customTextBox3.BorderRadius = 13;
			customTextBox3.BorderSize = 2;
			customTextBox3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			customTextBox3.ForeColor = Color.DimGray;
			customTextBox3.Location = new Point(50, 255);
			customTextBox3.Multiline = false;
			customTextBox3.Name = "customTextBox3";
			customTextBox3.Padding = new Padding(9, 9, 7, 7);
			customTextBox3.PasswordChar = false;
			customTextBox3.PlaceholderColor = Color.DarkGray;
			customTextBox3.PlaceholderText = "Nhập xuất xứ....";
			customTextBox3.Size = new Size(244, 42);
			customTextBox3.TabIndex = 8;
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
			customTextBox2.Location = new Point(50, 166);
			customTextBox2.Multiline = false;
			customTextBox2.Name = "customTextBox2";
			customTextBox2.Padding = new Padding(9, 9, 7, 7);
			customTextBox2.PasswordChar = false;
			customTextBox2.PlaceholderColor = Color.DarkGray;
			customTextBox2.PlaceholderText = "Nhập tên cà phê....";
			customTextBox2.Size = new Size(244, 42);
			customTextBox2.TabIndex = 7;
			customTextBox2.Texts = "";
			customTextBox2.UnderlinedStyle = false;
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
			label4.Location = new Point(33, 216);
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
			// xacNhanBtn
			// 
			xacNhanBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
			xacNhanBtn.Location = new Point(560, 390);
			xacNhanBtn.Name = "xacNhanBtn";
			xacNhanBtn.Size = new Size(137, 53);
			xacNhanBtn.TabIndex = 25;
			xacNhanBtn.Text = "  Xác Nhận";
			xacNhanBtn.TextColor = Color.DarkCyan;
			xacNhanBtn.TextHover = Color.White;
			xacNhanBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			xacNhanBtn.UseVisualStyleBackColor = false;
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
			HuyBtn.Location = new Point(703, 390);
			HuyBtn.Name = "HuyBtn";
			HuyBtn.Size = new Size(137, 53);
			HuyBtn.TabIndex = 26;
			HuyBtn.Text = "  Hủy";
			HuyBtn.TextColor = Color.Red;
			HuyBtn.TextHover = Color.White;
			HuyBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			HuyBtn.UseVisualStyleBackColor = false;
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
			listTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			DetailsTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)caPhePic).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private TabControl tabControl1;
		private TabPage listTabPage;
		private DataGridView dataGridView1;
		private CustomControl.CustomButton addBtn;
		private CustomControl.CustomTextBox searchTxt;
		private TabPage DetailsTabPage;
		private Label label5;
		private Label label4;
		private Label label1;
		private CustomControl.CustomTextBox customTextBox3;
		private CustomControl.CustomTextBox customTextBox2;
		private CustomControl.CustomTextBox idTxt;
		private CustomControl.CustomButton editBtn;
		private CustomControl.CustomButton delBtn;
		private CustomControl.CustomButton customButton2;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private CustomControl.CustomButton customButton4;
		private Label label7;
		private CustomControl.CustomTextBox customTextBox5;
		private Label label6;
		private CustomControl.CustomTextBox customTextBox4;
		private Label label3;
		private CustomControl.CustomTextBox customTextBox1;
		private Label M;
		private Label label8;
		private PictureBox caPhePic;
		private CustomControl.CustomButton xacNhanBtn;
		private CustomControl.CustomButton HuyBtn;
	}
}