namespace DoAn_QLCF_cs_WinForm.View
{
	partial class HoaDonView
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
			tabPage1 = new TabPage();
			delBtn = new CustomControl.CustomButton();
			button = new CustomControl.CustomButton();
			label9 = new Label();
			label2 = new Label();
			comboBox2 = new ComboBox();
			comboBox1 = new ComboBox();
			customButton2 = new CustomControl.CustomButton();
			searchTxt = new CustomControl.CustomTextBox();
			dataGridView1 = new DataGridView();
			tabPage2 = new TabPage();
			dataGridView2 = new DataGridView();
			label13 = new Label();
			HuyBtn = new CustomControl.CustomButton();
			xacNhanBtn = new CustomControl.CustomButton();
			customTextBox7 = new CustomControl.CustomTextBox();
			label10 = new Label();
			customTextBox8 = new CustomControl.CustomTextBox();
			label11 = new Label();
			customTextBox9 = new CustomControl.CustomTextBox();
			label12 = new Label();
			customTextBox6 = new CustomControl.CustomTextBox();
			label8 = new Label();
			customTextBox5 = new CustomControl.CustomTextBox();
			label6 = new Label();
			customTextBox4 = new CustomControl.CustomTextBox();
			label5 = new Label();
			customTextBox2 = new CustomControl.CustomTextBox();
			label3 = new Label();
			customTextBox1 = new CustomControl.CustomTextBox();
			label1 = new Label();
			customTextBox3 = new CustomControl.CustomTextBox();
			label4 = new Label();
			label7 = new Label();
			customButton4 = new CustomControl.CustomButton();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(969, 603);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.BackColor = SystemColors.Control;
			tabPage1.Controls.Add(delBtn);
			tabPage1.Controls.Add(button);
			tabPage1.Controls.Add(label9);
			tabPage1.Controls.Add(label2);
			tabPage1.Controls.Add(comboBox2);
			tabPage1.Controls.Add(comboBox1);
			tabPage1.Controls.Add(customButton2);
			tabPage1.Controls.Add(searchTxt);
			tabPage1.Controls.Add(dataGridView1);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(961, 575);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "tabPage1";
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
			delBtn.Location = new Point(828, 4);
			delBtn.Name = "delBtn";
			delBtn.Size = new Size(124, 42);
			delBtn.TabIndex = 17;
			delBtn.Text = "  Xóa";
			delBtn.TextColor = Color.Red;
			delBtn.TextHover = Color.White;
			delBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			delBtn.UseVisualStyleBackColor = false;
			// 
			// button
			// 
			button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button.BackColor = SystemColors.Control;
			button.BackgroundColor = SystemColors.Control;
			button.BorderColor = Color.DarkCyan;
			button.BorderRadius = 15;
			button.BorderSize = 2;
			button.Cursor = Cursors.Hand;
			button.EnabledTextHover = true;
			button.FlatAppearance.BorderSize = 0;
			button.FlatAppearance.MouseDownBackColor = Color.Teal;
			button.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
			button.FlatStyle = FlatStyle.Flat;
			button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			button.ForeColor = Color.DarkCyan;
			button.Image = Properties.Resources.detailsIcon16px;
			button.ImageAlign = ContentAlignment.MiddleRight;
			button.ImageHover = Properties.Resources.detailsIcon16pxWHITE;
			button.Location = new Point(698, 4);
			button.Name = "button";
			button.Size = new Size(124, 43);
			button.TabIndex = 16;
			button.Text = "  Chi Tiết";
			button.TextColor = Color.DarkCyan;
			button.TextHover = Color.White;
			button.TextImageRelation = TextImageRelation.ImageBeforeText;
			button.UseVisualStyleBackColor = false;
			// 
			// label9
			// 
			label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label9.Location = new Point(306, 11);
			label9.Name = "label9";
			label9.Size = new Size(52, 31);
			label9.TabIndex = 14;
			label9.Text = "Lọc:";
			label9.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(456, 11);
			label2.Name = "label2";
			label2.Size = new Size(73, 31);
			label2.TabIndex = 13;
			label2.Text = "Sắp xếp:";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// comboBox2
			// 
			comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			comboBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(360, 11);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(92, 31);
			comboBox2.TabIndex = 12;
			// 
			// comboBox1
			// 
			comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			comboBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(532, 11);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(92, 31);
			comboBox1.TabIndex = 11;
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
			customButton2.TabIndex = 8;
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
			searchTxt.Location = new Point(8, 6);
			searchTxt.Multiline = false;
			searchTxt.Name = "searchTxt";
			searchTxt.Padding = new Padding(9, 7, 40, 7);
			searchTxt.PasswordChar = false;
			searchTxt.PlaceholderColor = Color.DarkGray;
			searchTxt.PlaceholderText = "Tìm Kiếm ...";
			searchTxt.Size = new Size(266, 36);
			searchTxt.TabIndex = 7;
			searchTxt.Texts = "";
			searchTxt.UnderlinedStyle = false;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
			dataGridView1.EnableHeadersVisualStyles = false;
			dataGridView1.GridColor = Color.DarkCyan;
			dataGridView1.ImeMode = ImeMode.NoControl;
			dataGridView1.Location = new Point(-4, 170);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridView1.RowHeadersVisible = false;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.RowTemplate.ReadOnly = true;
			dataGridView1.Size = new Size(982, 405);
			dataGridView1.TabIndex = 2;
			// 
			// tabPage2
			// 
			tabPage2.BackColor = SystemColors.Control;
			tabPage2.Controls.Add(dataGridView2);
			tabPage2.Controls.Add(label13);
			tabPage2.Controls.Add(HuyBtn);
			tabPage2.Controls.Add(xacNhanBtn);
			tabPage2.Controls.Add(customTextBox7);
			tabPage2.Controls.Add(label10);
			tabPage2.Controls.Add(customTextBox8);
			tabPage2.Controls.Add(label11);
			tabPage2.Controls.Add(customTextBox9);
			tabPage2.Controls.Add(label12);
			tabPage2.Controls.Add(customTextBox6);
			tabPage2.Controls.Add(label8);
			tabPage2.Controls.Add(customTextBox5);
			tabPage2.Controls.Add(label6);
			tabPage2.Controls.Add(customTextBox4);
			tabPage2.Controls.Add(label5);
			tabPage2.Controls.Add(customTextBox2);
			tabPage2.Controls.Add(label3);
			tabPage2.Controls.Add(customTextBox1);
			tabPage2.Controls.Add(label1);
			tabPage2.Controls.Add(customTextBox3);
			tabPage2.Controls.Add(label4);
			tabPage2.Controls.Add(label7);
			tabPage2.Controls.Add(customButton4);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(961, 575);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "tabPage2";
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
			dataGridView2.Dock = DockStyle.Bottom;
			dataGridView2.EnableHeadersVisualStyles = false;
			dataGridView2.GridColor = Color.DarkCyan;
			dataGridView2.ImeMode = ImeMode.NoControl;
			dataGridView2.Location = new Point(3, 380);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridView2.RowHeadersVisible = false;
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle6;
			dataGridView2.RowTemplate.Height = 25;
			dataGridView2.RowTemplate.ReadOnly = true;
			dataGridView2.Size = new Size(955, 192);
			dataGridView2.TabIndex = 40;
			// 
			// label13
			// 
			label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label13.Location = new Point(8, 342);
			label13.Name = "label13";
			label13.Size = new Size(166, 35);
			label13.TabIndex = 39;
			label13.Text = "Danh sách cà phê";
			label13.TextAlign = ContentAlignment.MiddleCenter;
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
			HuyBtn.Location = new Point(838, 12);
			HuyBtn.Name = "HuyBtn";
			HuyBtn.Size = new Size(117, 40);
			HuyBtn.TabIndex = 38;
			HuyBtn.Text = "  Hủy";
			HuyBtn.TextColor = Color.Red;
			HuyBtn.TextHover = Color.White;
			HuyBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			HuyBtn.UseVisualStyleBackColor = false;
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
			xacNhanBtn.Location = new Point(715, 11);
			xacNhanBtn.Name = "xacNhanBtn";
			xacNhanBtn.Size = new Size(117, 40);
			xacNhanBtn.TabIndex = 37;
			xacNhanBtn.Text = "  Xác Nhận";
			xacNhanBtn.TextColor = Color.DarkCyan;
			xacNhanBtn.TextHover = Color.White;
			xacNhanBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			xacNhanBtn.UseVisualStyleBackColor = false;
			// 
			// customTextBox7
			// 
			customTextBox7.BackColor = SystemColors.Window;
			customTextBox7.BorderColor = Color.Silver;
			customTextBox7.BorderFocusColor = Color.DarkCyan;
			customTextBox7.BorderRadius = 13;
			customTextBox7.BorderSize = 2;
			customTextBox7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			customTextBox7.ForeColor = Color.DimGray;
			customTextBox7.Location = new Point(585, 267);
			customTextBox7.Multiline = false;
			customTextBox7.Name = "customTextBox7";
			customTextBox7.Padding = new Padding(9, 9, 7, 7);
			customTextBox7.PasswordChar = false;
			customTextBox7.PlaceholderColor = Color.DarkGray;
			customTextBox7.PlaceholderText = "--------------";
			customTextBox7.Size = new Size(244, 42);
			customTextBox7.TabIndex = 36;
			customTextBox7.Texts = "";
			customTextBox7.UnderlinedStyle = false;
			// 
			// label10
			// 
			label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label10.Location = new Point(569, 228);
			label10.Name = "label10";
			label10.Size = new Size(106, 51);
			label10.TabIndex = 35;
			label10.Text = "IsDelete";
			label10.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// customTextBox8
			// 
			customTextBox8.BackColor = SystemColors.Window;
			customTextBox8.BorderColor = Color.Silver;
			customTextBox8.BorderFocusColor = Color.DarkCyan;
			customTextBox8.BorderRadius = 13;
			customTextBox8.BorderSize = 2;
			customTextBox8.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			customTextBox8.ForeColor = Color.DimGray;
			customTextBox8.Location = new Point(317, 267);
			customTextBox8.Multiline = false;
			customTextBox8.Name = "customTextBox8";
			customTextBox8.Padding = new Padding(9, 9, 7, 7);
			customTextBox8.PasswordChar = false;
			customTextBox8.PlaceholderColor = Color.DarkGray;
			customTextBox8.PlaceholderText = "--------------";
			customTextBox8.Size = new Size(244, 42);
			customTextBox8.TabIndex = 34;
			customTextBox8.Texts = "";
			customTextBox8.UnderlinedStyle = false;
			// 
			// label11
			// 
			label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label11.Location = new Point(317, 228);
			label11.Name = "label11";
			label11.Size = new Size(145, 51);
			label11.TabIndex = 33;
			label11.Text = "Phí Sau Giảm Giá";
			label11.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// customTextBox9
			// 
			customTextBox9.BackColor = SystemColors.Window;
			customTextBox9.BorderColor = Color.Silver;
			customTextBox9.BorderFocusColor = Color.DarkCyan;
			customTextBox9.BorderRadius = 13;
			customTextBox9.BorderSize = 2;
			customTextBox9.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			customTextBox9.ForeColor = Color.DimGray;
			customTextBox9.Location = new Point(47, 267);
			customTextBox9.Multiline = false;
			customTextBox9.Name = "customTextBox9";
			customTextBox9.Padding = new Padding(9, 9, 7, 7);
			customTextBox9.PasswordChar = false;
			customTextBox9.PlaceholderColor = Color.DarkGray;
			customTextBox9.PlaceholderText = "----------------";
			customTextBox9.Size = new Size(244, 42);
			customTextBox9.TabIndex = 32;
			customTextBox9.Texts = "";
			customTextBox9.UnderlinedStyle = false;
			// 
			// label12
			// 
			label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label12.Location = new Point(30, 228);
			label12.Name = "label12";
			label12.Size = new Size(106, 51);
			label12.TabIndex = 31;
			label12.Text = "Giảm Giá";
			label12.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// customTextBox6
			// 
			customTextBox6.BackColor = SystemColors.Window;
			customTextBox6.BorderColor = Color.Silver;
			customTextBox6.BorderFocusColor = Color.DarkCyan;
			customTextBox6.BorderRadius = 13;
			customTextBox6.BorderSize = 2;
			customTextBox6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			customTextBox6.ForeColor = Color.DimGray;
			customTextBox6.Location = new Point(585, 186);
			customTextBox6.Multiline = false;
			customTextBox6.Name = "customTextBox6";
			customTextBox6.Padding = new Padding(9, 9, 7, 7);
			customTextBox6.PasswordChar = false;
			customTextBox6.PlaceholderColor = Color.DarkGray;
			customTextBox6.PlaceholderText = "---------------";
			customTextBox6.Size = new Size(244, 42);
			customTextBox6.TabIndex = 30;
			customTextBox6.Texts = "";
			customTextBox6.UnderlinedStyle = false;
			// 
			// label8
			// 
			label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(578, 150);
			label8.Name = "label8";
			label8.Size = new Size(165, 44);
			label8.TabIndex = 29;
			label8.Text = "Phí Trước Giảm Giá";
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
			customTextBox5.Location = new Point(585, 100);
			customTextBox5.Multiline = false;
			customTextBox5.Name = "customTextBox5";
			customTextBox5.Padding = new Padding(9, 9, 7, 7);
			customTextBox5.PasswordChar = false;
			customTextBox5.PlaceholderColor = Color.DarkGray;
			customTextBox5.PlaceholderText = "Nhập....";
			customTextBox5.Size = new Size(244, 42);
			customTextBox5.TabIndex = 28;
			customTextBox5.Texts = "";
			customTextBox5.UnderlinedStyle = false;
			// 
			// label6
			// 
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(585, 68);
			label6.Name = "label6";
			label6.Size = new Size(117, 36);
			label6.TabIndex = 27;
			label6.Text = "ID Khách Hàng";
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
			customTextBox4.Location = new Point(317, 186);
			customTextBox4.Multiline = false;
			customTextBox4.Name = "customTextBox4";
			customTextBox4.Padding = new Padding(9, 9, 7, 7);
			customTextBox4.PasswordChar = false;
			customTextBox4.PlaceholderColor = Color.DarkGray;
			customTextBox4.PlaceholderText = "-------------";
			customTextBox4.Size = new Size(244, 42);
			customTextBox4.TabIndex = 26;
			customTextBox4.Texts = "";
			customTextBox4.UnderlinedStyle = false;
			// 
			// label5
			// 
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(317, 154);
			label5.Name = "label5";
			label5.Size = new Size(106, 37);
			label5.TabIndex = 25;
			label5.Text = "Ngày Nhập";
			label5.TextAlign = ContentAlignment.MiddleCenter;
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
			customTextBox2.Location = new Point(47, 186);
			customTextBox2.Multiline = false;
			customTextBox2.Name = "customTextBox2";
			customTextBox2.Padding = new Padding(9, 9, 7, 7);
			customTextBox2.PasswordChar = false;
			customTextBox2.PlaceholderColor = Color.DarkGray;
			customTextBox2.PlaceholderText = "Nhập ID giảm giá....";
			customTextBox2.Size = new Size(244, 42);
			customTextBox2.TabIndex = 24;
			customTextBox2.Texts = "";
			customTextBox2.UnderlinedStyle = false;
			// 
			// label3
			// 
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(46, 150);
			label3.Name = "label3";
			label3.Size = new Size(156, 44);
			label3.TabIndex = 23;
			label3.Text = "ID Phiếu Giảm Giá";
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
			customTextBox1.Location = new Point(317, 100);
			customTextBox1.Multiline = false;
			customTextBox1.Name = "customTextBox1";
			customTextBox1.Padding = new Padding(9, 9, 7, 7);
			customTextBox1.PasswordChar = false;
			customTextBox1.PlaceholderColor = Color.DarkGray;
			customTextBox1.PlaceholderText = "Nhập....";
			customTextBox1.Size = new Size(244, 42);
			customTextBox1.TabIndex = 22;
			customTextBox1.Texts = "";
			customTextBox1.UnderlinedStyle = false;
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(317, 61);
			label1.Name = "label1";
			label1.Size = new Size(106, 51);
			label1.TabIndex = 21;
			label1.Text = "ID Nhân Viên";
			label1.TextAlign = ContentAlignment.MiddleCenter;
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
			customTextBox3.Location = new Point(47, 100);
			customTextBox3.Multiline = false;
			customTextBox3.Name = "customTextBox3";
			customTextBox3.Padding = new Padding(9, 9, 7, 7);
			customTextBox3.PasswordChar = false;
			customTextBox3.PlaceholderColor = Color.DarkGray;
			customTextBox3.PlaceholderText = "Nhập ID....";
			customTextBox3.Size = new Size(244, 42);
			customTextBox3.TabIndex = 20;
			customTextBox3.Texts = "";
			customTextBox3.UnderlinedStyle = false;
			// 
			// label4
			// 
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(20, 63);
			label4.Name = "label4";
			label4.Size = new Size(106, 51);
			label4.TabIndex = 19;
			label4.Text = "ID";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(81, 7);
			label7.Name = "label7";
			label7.Size = new Size(210, 43);
			label7.TabIndex = 18;
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
			customButton4.Location = new Point(8, 10);
			customButton4.Name = "customButton4";
			customButton4.Size = new Size(63, 41);
			customButton4.TabIndex = 17;
			customButton4.TextColor = Color.White;
			customButton4.TextHover = Color.White;
			customButton4.UseVisualStyleBackColor = false;
			// 
			// HoaDonView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(969, 603);
			Controls.Add(tabControl1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "HoaDonView";
			Text = "HoaDonView";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private DataGridView dataGridView1;
		private CustomControl.CustomButton customButton2;
		private CustomControl.CustomTextBox searchTxt;
		private Label label9;
		private Label label2;
		private ComboBox comboBox2;
		private ComboBox comboBox1;
		private CustomControl.CustomButton delBtn;
		private CustomControl.CustomButton button;
		private Label label7;
		private CustomControl.CustomButton customButton4;
		private CustomControl.CustomTextBox customTextBox2;
		private Label label3;
		private CustomControl.CustomTextBox customTextBox1;
		private Label label1;
		private CustomControl.CustomTextBox customTextBox3;
		private Label label4;
		private CustomControl.CustomTextBox customTextBox6;
		private Label label8;
		private CustomControl.CustomTextBox customTextBox5;
		private Label label6;
		private CustomControl.CustomTextBox customTextBox4;
		private Label label5;
		private CustomControl.CustomTextBox customTextBox7;
		private Label label10;
		private CustomControl.CustomTextBox customTextBox8;
		private Label label11;
		private CustomControl.CustomTextBox customTextBox9;
		private Label label12;
		private Label label13;
		private CustomControl.CustomButton HuyBtn;
		private CustomControl.CustomButton xacNhanBtn;
		private DataGridView dataGridView2;
	}
}