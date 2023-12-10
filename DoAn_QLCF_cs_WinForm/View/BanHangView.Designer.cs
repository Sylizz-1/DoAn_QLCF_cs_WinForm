namespace DoAn_QLCF_cs_WinForm.View
{
	partial class BanHangView
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
			titleBar = new CustomControl.SidePanel();
			pggBtn = new CustomControl.CustomButton();
			customButton4 = new CustomControl.CustomButton();
			customButton3 = new CustomControl.CustomButton();
			customButton2 = new CustomControl.CustomButton();
			accountIcon = new CustomControl.CustomButton();
			panel1 = new Panel();
			tabControl1 = new TabControl();
			trangChuTab = new TabPage();
			sidePanel2 = new CustomControl.SidePanel();
			gioHangPanel = new FlowLayoutPanel();
			panel2 = new Panel();
			label5 = new Label();
			loaiKhTxt = new TextBox();
			giaGocTxt = new TextBox();
			datHangBtn = new CustomControl.CustomButton();
			label3 = new Label();
			label1 = new Label();
			sidePanel1 = new CustomControl.SidePanel();
			sanPhamPanel = new FlowLayoutPanel();
			pggTab = new TabPage();
			label7 = new Label();
			returnBtn = new CustomControl.CustomButton();
			pggDg = new DataGridView();
			hoaDonTab = new TabPage();
			label2 = new Label();
			customButton1 = new CustomControl.CustomButton();
			hoaDonDg = new DataGridView();
			hoaDonBtn = new CustomControl.CustomButton();
			titleBar.SuspendLayout();
			panel1.SuspendLayout();
			tabControl1.SuspendLayout();
			trangChuTab.SuspendLayout();
			sidePanel2.SuspendLayout();
			panel2.SuspendLayout();
			sidePanel1.SuspendLayout();
			pggTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pggDg).BeginInit();
			hoaDonTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)hoaDonDg).BeginInit();
			SuspendLayout();
			// 
			// titleBar
			// 
			titleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			titleBar.BackColor = Color.DarkSlateGray;
			titleBar.BorderRadius = 15;
			titleBar.Controls.Add(hoaDonBtn);
			titleBar.Controls.Add(pggBtn);
			titleBar.Controls.Add(customButton4);
			titleBar.Controls.Add(customButton3);
			titleBar.Controls.Add(customButton2);
			titleBar.Controls.Add(accountIcon);
			titleBar.EnabledGradient = false;
			titleBar.GradientAngle = 45F;
			titleBar.GradientBottomColor = Color.DarkSlateGray;
			titleBar.GradientTopColor = Color.Teal;
			titleBar.Location = new Point(12, 12);
			titleBar.Name = "titleBar";
			titleBar.Padding = new Padding(10, 5, 15, 5);
			titleBar.Size = new Size(931, 55);
			titleBar.TabIndex = 1;
			// 
			// pggBtn
			// 
			pggBtn.Anchor = AnchorStyles.Right;
			pggBtn.BackColor = Color.Transparent;
			pggBtn.BackgroundColor = Color.Transparent;
			pggBtn.BorderColor = Color.Teal;
			pggBtn.BorderRadius = 20;
			pggBtn.BorderSize = 0;
			pggBtn.Cursor = Cursors.Hand;
			pggBtn.EnabledTextHover = false;
			pggBtn.FlatAppearance.BorderSize = 0;
			pggBtn.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			pggBtn.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			pggBtn.FlatStyle = FlatStyle.Flat;
			pggBtn.ForeColor = Color.White;
			pggBtn.Image = Properties.Resources.DiscountIcon24px;
			pggBtn.ImageHover = null;
			pggBtn.Location = new Point(787, 8);
			pggBtn.Margin = new Padding(3, 3, 20, 3);
			pggBtn.Name = "pggBtn";
			pggBtn.Size = new Size(53, 40);
			pggBtn.TabIndex = 5;
			pggBtn.TextColor = Color.White;
			pggBtn.TextHover = Color.White;
			pggBtn.UseVisualStyleBackColor = false;
			pggBtn.Click += pggBtn_Click;
			// 
			// customButton4
			// 
			customButton4.Anchor = AnchorStyles.Right;
			customButton4.BackColor = Color.Transparent;
			customButton4.BackgroundColor = Color.Transparent;
			customButton4.BorderColor = Color.Teal;
			customButton4.BorderRadius = 20;
			customButton4.BorderSize = 0;
			customButton4.Cursor = Cursors.Hand;
			customButton4.EnabledTextHover = false;
			customButton4.FlatAppearance.BorderSize = 0;
			customButton4.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			customButton4.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			customButton4.FlatStyle = FlatStyle.Flat;
			customButton4.ForeColor = Color.White;
			customButton4.Image = Properties.Resources.TaskIcon;
			customButton4.ImageHover = null;
			customButton4.Location = new Point(1088, -18);
			customButton4.Margin = new Padding(3, 3, 20, 3);
			customButton4.Name = "customButton4";
			customButton4.Size = new Size(53, 40);
			customButton4.TabIndex = 4;
			customButton4.TextColor = Color.White;
			customButton4.TextHover = Color.White;
			customButton4.UseVisualStyleBackColor = false;
			// 
			// customButton3
			// 
			customButton3.Anchor = AnchorStyles.Right;
			customButton3.BackColor = Color.Transparent;
			customButton3.BackgroundColor = Color.Transparent;
			customButton3.BorderColor = Color.Teal;
			customButton3.BorderRadius = 20;
			customButton3.BorderSize = 0;
			customButton3.Cursor = Cursors.Hand;
			customButton3.EnabledTextHover = false;
			customButton3.FlatAppearance.BorderSize = 0;
			customButton3.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			customButton3.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			customButton3.FlatStyle = FlatStyle.Flat;
			customButton3.ForeColor = Color.White;
			customButton3.Image = Properties.Resources.emailIcon;
			customButton3.ImageHover = null;
			customButton3.Location = new Point(1162, -18);
			customButton3.Name = "customButton3";
			customButton3.Size = new Size(53, 40);
			customButton3.TabIndex = 3;
			customButton3.TextColor = Color.White;
			customButton3.TextHover = Color.White;
			customButton3.UseVisualStyleBackColor = false;
			// 
			// customButton2
			// 
			customButton2.Anchor = AnchorStyles.Right;
			customButton2.BackColor = Color.Transparent;
			customButton2.BackgroundColor = Color.Transparent;
			customButton2.BorderColor = Color.Teal;
			customButton2.BorderRadius = 20;
			customButton2.BorderSize = 0;
			customButton2.Cursor = Cursors.Hand;
			customButton2.EnabledTextHover = false;
			customButton2.FlatAppearance.BorderSize = 0;
			customButton2.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			customButton2.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			customButton2.FlatStyle = FlatStyle.Flat;
			customButton2.ForeColor = Color.White;
			customButton2.Image = Properties.Resources.notificationIcon;
			customButton2.ImageHover = null;
			customButton2.Location = new Point(1236, -18);
			customButton2.Name = "customButton2";
			customButton2.Size = new Size(53, 40);
			customButton2.TabIndex = 2;
			customButton2.TextColor = Color.White;
			customButton2.TextHover = Color.White;
			customButton2.UseVisualStyleBackColor = false;
			// 
			// accountIcon
			// 
			accountIcon.BackColor = Color.OrangeRed;
			accountIcon.BackgroundColor = Color.OrangeRed;
			accountIcon.BorderColor = Color.Teal;
			accountIcon.BorderRadius = 20;
			accountIcon.BorderSize = 0;
			accountIcon.Cursor = Cursors.Hand;
			accountIcon.Dock = DockStyle.Right;
			accountIcon.EnabledTextHover = false;
			accountIcon.FlatAppearance.BorderSize = 0;
			accountIcon.FlatAppearance.MouseDownBackColor = Color.OrangeRed;
			accountIcon.FlatAppearance.MouseOverBackColor = Color.Coral;
			accountIcon.FlatStyle = FlatStyle.Flat;
			accountIcon.ForeColor = Color.White;
			accountIcon.Image = Properties.Resources.usericon;
			accountIcon.ImageHover = null;
			accountIcon.Location = new Point(863, 5);
			accountIcon.Name = "accountIcon";
			accountIcon.Size = new Size(53, 45);
			accountIcon.TabIndex = 1;
			accountIcon.TextColor = Color.White;
			accountIcon.TextHover = Color.White;
			accountIcon.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel1.Controls.Add(tabControl1);
			panel1.Location = new Point(12, 73);
			panel1.Name = "panel1";
			panel1.Size = new Size(931, 554);
			panel1.TabIndex = 2;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(trangChuTab);
			tabControl1.Controls.Add(pggTab);
			tabControl1.Controls.Add(hoaDonTab);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(931, 554);
			tabControl1.TabIndex = 0;
			// 
			// trangChuTab
			// 
			trangChuTab.Controls.Add(sidePanel2);
			trangChuTab.Controls.Add(sidePanel1);
			trangChuTab.Location = new Point(4, 24);
			trangChuTab.Name = "trangChuTab";
			trangChuTab.Padding = new Padding(3);
			trangChuTab.Size = new Size(923, 526);
			trangChuTab.TabIndex = 0;
			trangChuTab.Text = "tabPage1";
			trangChuTab.UseVisualStyleBackColor = true;
			// 
			// sidePanel2
			// 
			sidePanel2.BackColor = SystemColors.ActiveCaption;
			sidePanel2.BorderRadius = 20;
			sidePanel2.Controls.Add(gioHangPanel);
			sidePanel2.Controls.Add(panel2);
			sidePanel2.Dock = DockStyle.Right;
			sidePanel2.EnabledGradient = false;
			sidePanel2.GradientAngle = 90F;
			sidePanel2.GradientBottomColor = Color.FromArgb(255, 51, 153);
			sidePanel2.GradientTopColor = Color.Teal;
			sidePanel2.Location = new Point(445, 3);
			sidePanel2.Name = "sidePanel2";
			sidePanel2.Size = new Size(475, 520);
			sidePanel2.TabIndex = 3;
			// 
			// gioHangPanel
			// 
			gioHangPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			gioHangPanel.AutoScroll = true;
			gioHangPanel.BackColor = SystemColors.ActiveBorder;
			gioHangPanel.FlowDirection = FlowDirection.TopDown;
			gioHangPanel.Location = new Point(0, 0);
			gioHangPanel.Name = "gioHangPanel";
			gioHangPanel.Padding = new Padding(0, 10, 0, 0);
			gioHangPanel.Size = new Size(1354, 348);
			gioHangPanel.TabIndex = 1;
			gioHangPanel.WrapContents = false;
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.GradientActiveCaption;
			panel2.Controls.Add(label5);
			panel2.Controls.Add(loaiKhTxt);
			panel2.Controls.Add(giaGocTxt);
			panel2.Controls.Add(datHangBtn);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(label1);
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 347);
			panel2.Name = "panel2";
			panel2.Size = new Size(475, 173);
			panel2.TabIndex = 0;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label5.ForeColor = Color.Red;
			label5.Location = new Point(205, 17);
			label5.Name = "label5";
			label5.Size = new Size(18, 20);
			label5.TabIndex = 3;
			label5.Text = "đ";
			// 
			// loaiKhTxt
			// 
			loaiKhTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			loaiKhTxt.BackColor = SystemColors.GradientActiveCaption;
			loaiKhTxt.BorderStyle = BorderStyle.None;
			loaiKhTxt.Enabled = false;
			loaiKhTxt.Font = new Font("Segoe UI", 13F);
			loaiKhTxt.ForeColor = Color.Red;
			loaiKhTxt.Location = new Point(141, 57);
			loaiKhTxt.Name = "loaiKhTxt";
			loaiKhTxt.ReadOnly = true;
			loaiKhTxt.Size = new Size(66, 24);
			loaiKhTxt.TabIndex = 2;
			loaiKhTxt.Text = "0%";
			// 
			// giaGocTxt
			// 
			giaGocTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			giaGocTxt.BackColor = SystemColors.GradientActiveCaption;
			giaGocTxt.BorderStyle = BorderStyle.None;
			giaGocTxt.Enabled = false;
			giaGocTxt.Font = new Font("Segoe UI", 13F);
			giaGocTxt.ForeColor = Color.Red;
			giaGocTxt.Location = new Point(141, 20);
			giaGocTxt.Name = "giaGocTxt";
			giaGocTxt.ReadOnly = true;
			giaGocTxt.Size = new Size(66, 24);
			giaGocTxt.TabIndex = 2;
			giaGocTxt.Text = "0";
			// 
			// datHangBtn
			// 
			datHangBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			datHangBtn.BackColor = Color.Crimson;
			datHangBtn.BackgroundColor = Color.Crimson;
			datHangBtn.BorderColor = Color.PaleVioletRed;
			datHangBtn.BorderRadius = 15;
			datHangBtn.BorderSize = 0;
			datHangBtn.Cursor = Cursors.Hand;
			datHangBtn.EnabledTextHover = false;
			datHangBtn.FlatAppearance.BorderSize = 0;
			datHangBtn.FlatStyle = FlatStyle.Flat;
			datHangBtn.Font = new Font("Segoe UI", 12F);
			datHangBtn.ForeColor = Color.White;
			datHangBtn.ImageHover = null;
			datHangBtn.Location = new Point(319, 118);
			datHangBtn.Name = "datHangBtn";
			datHangBtn.Size = new Size(148, 48);
			datHangBtn.TabIndex = 1;
			datHangBtn.Text = "Đặt Hàng";
			datHangBtn.TextColor = Color.White;
			datHangBtn.TextHover = Color.White;
			datHangBtn.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
			label3.Location = new Point(3, 56);
			label3.Name = "label3";
			label3.Size = new Size(110, 25);
			label3.TabIndex = 0;
			label3.Text = "Loại Khách:";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
			label1.Location = new Point(3, 18);
			label1.Name = "label1";
			label1.Size = new Size(83, 25);
			label1.TabIndex = 0;
			label1.Text = "Giá Gốc:";
			// 
			// sidePanel1
			// 
			sidePanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			sidePanel1.BackColor = SystemColors.ActiveCaption;
			sidePanel1.BorderRadius = 20;
			sidePanel1.Controls.Add(sanPhamPanel);
			sidePanel1.EnabledGradient = false;
			sidePanel1.GradientAngle = 90F;
			sidePanel1.GradientBottomColor = Color.FromArgb(255, 51, 153);
			sidePanel1.GradientTopColor = Color.Teal;
			sidePanel1.Location = new Point(1, 3);
			sidePanel1.Name = "sidePanel1";
			sidePanel1.Padding = new Padding(7);
			sidePanel1.Size = new Size(438, 520);
			sidePanel1.TabIndex = 2;
			// 
			// sanPhamPanel
			// 
			sanPhamPanel.AutoScroll = true;
			sanPhamPanel.BackColor = SystemColors.ActiveCaption;
			sanPhamPanel.Dock = DockStyle.Fill;
			sanPhamPanel.Location = new Point(7, 7);
			sanPhamPanel.Name = "sanPhamPanel";
			sanPhamPanel.Size = new Size(424, 506);
			sanPhamPanel.TabIndex = 0;
			// 
			// pggTab
			// 
			pggTab.BackColor = SystemColors.Control;
			pggTab.Controls.Add(label7);
			pggTab.Controls.Add(returnBtn);
			pggTab.Controls.Add(pggDg);
			pggTab.Location = new Point(4, 24);
			pggTab.Name = "pggTab";
			pggTab.Padding = new Padding(3);
			pggTab.Size = new Size(923, 526);
			pggTab.TabIndex = 1;
			pggTab.Text = "tabPage2";
			// 
			// label7
			// 
			label7.Font = new Font("Segoe UI", 17F);
			label7.Location = new Point(84, 15);
			label7.Name = "label7";
			label7.Size = new Size(407, 43);
			label7.TabIndex = 17;
			label7.Text = "Danh Sách Phiếu Giảm Giá Sẵn Có";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// returnBtn
			// 
			returnBtn.BackColor = Color.Transparent;
			returnBtn.BackgroundColor = Color.Transparent;
			returnBtn.BorderColor = Color.PaleVioletRed;
			returnBtn.BorderRadius = 20;
			returnBtn.BorderSize = 0;
			returnBtn.Cursor = Cursors.Hand;
			returnBtn.EnabledTextHover = false;
			returnBtn.FlatAppearance.BorderSize = 0;
			returnBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
			returnBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
			returnBtn.FlatStyle = FlatStyle.Flat;
			returnBtn.ForeColor = Color.White;
			returnBtn.Image = Properties.Resources.arrowreturn32pxBlack1;
			returnBtn.ImageHover = Properties.Resources.arrowreturn32pxWhite1;
			returnBtn.Location = new Point(15, 15);
			returnBtn.Name = "returnBtn";
			returnBtn.Size = new Size(63, 41);
			returnBtn.TabIndex = 16;
			returnBtn.TextColor = Color.White;
			returnBtn.TextHover = Color.White;
			returnBtn.UseVisualStyleBackColor = false;
			returnBtn.Click += returnBtn_Click;
			// 
			// pggDg
			// 
			pggDg.AllowUserToAddRows = false;
			pggDg.AllowUserToDeleteRows = false;
			pggDg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pggDg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			pggDg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			pggDg.BorderStyle = BorderStyle.None;
			pggDg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = Color.DarkCyan;
			dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			dataGridViewCellStyle7.ForeColor = SystemColors.Control;
			dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			pggDg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			pggDg.ColumnHeadersHeight = 30;
			pggDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = SystemColors.Window;
			dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
			pggDg.DefaultCellStyle = dataGridViewCellStyle8;
			pggDg.EnableHeadersVisualStyles = false;
			pggDg.GridColor = Color.DarkCyan;
			pggDg.ImeMode = ImeMode.NoControl;
			pggDg.Location = new Point(0, 120);
			pggDg.Name = "pggDg";
			pggDg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			pggDg.RowHeadersVisible = false;
			pggDg.RowHeadersWidth = 51;
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
			pggDg.RowsDefaultCellStyle = dataGridViewCellStyle9;
			pggDg.RowTemplate.ReadOnly = true;
			pggDg.Size = new Size(923, 406);
			pggDg.TabIndex = 2;
			// 
			// hoaDonTab
			// 
			hoaDonTab.BackColor = SystemColors.Control;
			hoaDonTab.Controls.Add(label2);
			hoaDonTab.Controls.Add(customButton1);
			hoaDonTab.Controls.Add(hoaDonDg);
			hoaDonTab.Location = new Point(4, 24);
			hoaDonTab.Name = "hoaDonTab";
			hoaDonTab.Size = new Size(923, 526);
			hoaDonTab.TabIndex = 2;
			hoaDonTab.Text = "tabPage3";
			// 
			// label2
			// 
			label2.Font = new Font("Segoe UI", 17F);
			label2.Location = new Point(84, 8);
			label2.Name = "label2";
			label2.Size = new Size(369, 43);
			label2.TabIndex = 20;
			label2.Text = "Danh Sách Hóa Đơn";
			label2.TextAlign = ContentAlignment.MiddleCenter;
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
			customButton1.Location = new Point(15, 8);
			customButton1.Name = "customButton1";
			customButton1.Size = new Size(63, 41);
			customButton1.TabIndex = 19;
			customButton1.TextColor = Color.White;
			customButton1.TextHover = Color.White;
			customButton1.UseVisualStyleBackColor = false;
			// 
			// hoaDonDg
			// 
			hoaDonDg.AllowUserToAddRows = false;
			hoaDonDg.AllowUserToDeleteRows = false;
			hoaDonDg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			hoaDonDg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			hoaDonDg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			hoaDonDg.BorderStyle = BorderStyle.None;
			hoaDonDg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = Color.DarkCyan;
			dataGridViewCellStyle10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			dataGridViewCellStyle10.ForeColor = SystemColors.Control;
			dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
			hoaDonDg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			hoaDonDg.ColumnHeadersHeight = 30;
			hoaDonDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.BackColor = SystemColors.Window;
			dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
			hoaDonDg.DefaultCellStyle = dataGridViewCellStyle11;
			hoaDonDg.EnableHeadersVisualStyles = false;
			hoaDonDg.GridColor = Color.DarkCyan;
			hoaDonDg.ImeMode = ImeMode.NoControl;
			hoaDonDg.Location = new Point(0, 113);
			hoaDonDg.Name = "hoaDonDg";
			hoaDonDg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			hoaDonDg.RowHeadersVisible = false;
			hoaDonDg.RowHeadersWidth = 51;
			dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
			hoaDonDg.RowsDefaultCellStyle = dataGridViewCellStyle12;
			hoaDonDg.RowTemplate.ReadOnly = true;
			hoaDonDg.Size = new Size(923, 406);
			hoaDonDg.TabIndex = 18;
			// 
			// hoaDonBtn
			// 
			hoaDonBtn.Anchor = AnchorStyles.Right;
			hoaDonBtn.BackColor = Color.Transparent;
			hoaDonBtn.BackgroundColor = Color.Transparent;
			hoaDonBtn.BorderColor = Color.Teal;
			hoaDonBtn.BorderRadius = 20;
			hoaDonBtn.BorderSize = 0;
			hoaDonBtn.Cursor = Cursors.Hand;
			hoaDonBtn.EnabledTextHover = false;
			hoaDonBtn.FlatAppearance.BorderSize = 0;
			hoaDonBtn.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
			hoaDonBtn.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
			hoaDonBtn.FlatStyle = FlatStyle.Flat;
			hoaDonBtn.ForeColor = Color.White;
			hoaDonBtn.Image = Properties.Resources.invoice_khachhang_24px;
			hoaDonBtn.ImageHover = null;
			hoaDonBtn.Location = new Point(711, 8);
			hoaDonBtn.Margin = new Padding(3, 3, 20, 3);
			hoaDonBtn.Name = "hoaDonBtn";
			hoaDonBtn.Size = new Size(53, 40);
			hoaDonBtn.TabIndex = 5;
			hoaDonBtn.TextColor = Color.White;
			hoaDonBtn.TextHover = Color.White;
			hoaDonBtn.UseVisualStyleBackColor = false;
			hoaDonBtn.Click += hoaDonBtn_Click;
			// 
			// BanHangView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(955, 639);
			Controls.Add(panel1);
			Controls.Add(titleBar);
			Name = "BanHangView";
			Text = "BanHangView";
			WindowState = FormWindowState.Maximized;
			titleBar.ResumeLayout(false);
			panel1.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			trangChuTab.ResumeLayout(false);
			sidePanel2.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			sidePanel1.ResumeLayout(false);
			pggTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pggDg).EndInit();
			hoaDonTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)hoaDonDg).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private CustomControl.SidePanel titleBar;
		private CustomControl.CustomButton customButton4;
		private CustomControl.CustomButton customButton3;
		private CustomControl.CustomButton customButton2;
		private CustomControl.CustomButton accountIcon;
		private Panel panel1;
		private TabControl tabControl1;
		private TabPage trangChuTab;
		private TabPage pggTab;
		private TabPage hoaDonTab;
		private CustomControl.SidePanel sidePanel2;
		private CustomControl.SidePanel sidePanel1;
		private FlowLayoutPanel sanPhamPanel;
		private Panel panel2;
		private Label label1;
		private Label label3;
		private CustomControl.CustomButton datHangBtn;
		private TextBox giaGocTxt;
		private TextBox loaiKhTxt;
		private FlowLayoutPanel gioHangPanel;
		private Label label5;
		private DataGridView pggDg;
		private CustomControl.CustomButton pggBtn;
		private CustomControl.CustomButton returnBtn;
		private Label label7;
		private Label label2;
		private CustomControl.CustomButton customButton1;
		private DataGridView hoaDonDg;
		private CustomControl.CustomButton hoaDonBtn;
	}
}