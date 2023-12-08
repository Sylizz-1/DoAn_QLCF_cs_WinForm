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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            taiKhoanTab = new TabPage();
            titleBar.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            trangChuTab.SuspendLayout();
            sidePanel2.SuspendLayout();
            panel2.SuspendLayout();
            sidePanel1.SuspendLayout();
            pggTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pggDg).BeginInit();
            SuspendLayout();
            // 
            // titleBar
            // 
            titleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleBar.BackColor = Color.DarkSlateGray;
            titleBar.BorderRadius = 15;
            titleBar.Controls.Add(pggBtn);
            titleBar.Controls.Add(customButton4);
            titleBar.Controls.Add(customButton3);
            titleBar.Controls.Add(customButton2);
            titleBar.Controls.Add(accountIcon);
            titleBar.EnabledGradient = false;
            titleBar.GradientAngle = 45F;
            titleBar.GradientBottomColor = Color.DarkSlateGray;
            titleBar.GradientTopColor = Color.Teal;
            titleBar.Location = new Point(14, 16);
            titleBar.Margin = new Padding(3, 4, 3, 4);
            titleBar.Name = "titleBar";
            titleBar.Padding = new Padding(11, 7, 17, 7);
            titleBar.Size = new Size(1064, 73);
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
            pggBtn.Location = new Point(899, 11);
            pggBtn.Margin = new Padding(3, 4, 23, 4);
            pggBtn.Name = "pggBtn";
            pggBtn.Size = new Size(61, 53);
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
            customButton4.Location = new Point(1243, -24);
            customButton4.Margin = new Padding(3, 4, 23, 4);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(61, 53);
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
            customButton3.Location = new Point(1328, -24);
            customButton3.Margin = new Padding(3, 4, 3, 4);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(61, 53);
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
            customButton2.Location = new Point(1413, -24);
            customButton2.Margin = new Padding(3, 4, 3, 4);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(61, 53);
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
            accountIcon.Location = new Point(986, 7);
            accountIcon.Margin = new Padding(3, 4, 3, 4);
            accountIcon.Name = "accountIcon";
            accountIcon.Size = new Size(61, 59);
            accountIcon.TabIndex = 1;
            accountIcon.TextColor = Color.White;
            accountIcon.TextHover = Color.White;
            accountIcon.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(14, 97);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 739);
            panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(trangChuTab);
            tabControl1.Controls.Add(pggTab);
            tabControl1.Controls.Add(taiKhoanTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1064, 739);
            tabControl1.TabIndex = 0;
            // 
            // trangChuTab
            // 
            trangChuTab.Controls.Add(sidePanel2);
            trangChuTab.Controls.Add(sidePanel1);
            trangChuTab.Location = new Point(4, 29);
            trangChuTab.Margin = new Padding(3, 4, 3, 4);
            trangChuTab.Name = "trangChuTab";
            trangChuTab.Padding = new Padding(3, 4, 3, 4);
            trangChuTab.Size = new Size(1056, 706);
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
            sidePanel2.Location = new Point(510, 4);
            sidePanel2.Margin = new Padding(3, 4, 3, 4);
            sidePanel2.Name = "sidePanel2";
            sidePanel2.Size = new Size(543, 698);
            sidePanel2.TabIndex = 3;
            // 
            // gioHangPanel
            // 
            gioHangPanel.AutoScroll = true;
            gioHangPanel.BackColor = SystemColors.ActiveBorder;
            gioHangPanel.Dock = DockStyle.Fill;
            gioHangPanel.FlowDirection = FlowDirection.TopDown;
            gioHangPanel.Location = new Point(0, 0);
            gioHangPanel.Margin = new Padding(3, 4, 3, 4);
            gioHangPanel.Name = "gioHangPanel";
            gioHangPanel.Padding = new Padding(0, 13, 0, 0);
            gioHangPanel.Size = new Size(543, 467);
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
            panel2.Location = new Point(0, 467);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 231);
            panel2.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(234, 23);
            label5.Name = "label5";
            label5.Size = new Size(24, 25);
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
            loaiKhTxt.Location = new Point(161, 76);
            loaiKhTxt.Margin = new Padding(3, 4, 3, 4);
            loaiKhTxt.Name = "loaiKhTxt";
            loaiKhTxt.ReadOnly = true;
            loaiKhTxt.Size = new Size(75, 29);
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
            giaGocTxt.Location = new Point(161, 27);
            giaGocTxt.Margin = new Padding(3, 4, 3, 4);
            giaGocTxt.Name = "giaGocTxt";
            giaGocTxt.ReadOnly = true;
            giaGocTxt.Size = new Size(75, 29);
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
            datHangBtn.Location = new Point(365, 157);
            datHangBtn.Margin = new Padding(3, 4, 3, 4);
            datHangBtn.Name = "datHangBtn";
            datHangBtn.Size = new Size(169, 64);
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
            label3.Location = new Point(3, 75);
            label3.Name = "label3";
            label3.Size = new Size(130, 30);
            label3.TabIndex = 0;
            label3.Text = "Loại Khách:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
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
            sidePanel1.Location = new Point(1, 4);
            sidePanel1.Margin = new Padding(3, 4, 3, 4);
            sidePanel1.Name = "sidePanel1";
            sidePanel1.Padding = new Padding(8, 9, 8, 9);
            sidePanel1.Size = new Size(501, 693);
            sidePanel1.TabIndex = 2;
            // 
            // sanPhamPanel
            // 
            sanPhamPanel.AutoScroll = true;
            sanPhamPanel.BackColor = SystemColors.ActiveCaption;
            sanPhamPanel.Dock = DockStyle.Fill;
            sanPhamPanel.Location = new Point(8, 9);
            sanPhamPanel.Margin = new Padding(3, 4, 3, 4);
            sanPhamPanel.Name = "sanPhamPanel";
            sanPhamPanel.Size = new Size(485, 675);
            sanPhamPanel.TabIndex = 0;
            // 
            // pggTab
            // 
            pggTab.BackColor = SystemColors.Control;
            pggTab.Controls.Add(label7);
            pggTab.Controls.Add(returnBtn);
            pggTab.Controls.Add(pggDg);
            pggTab.Location = new Point(4, 29);
            pggTab.Margin = new Padding(3, 4, 3, 4);
            pggTab.Name = "pggTab";
            pggTab.Padding = new Padding(3, 4, 3, 4);
            pggTab.Size = new Size(1056, 706);
            pggTab.TabIndex = 1;
            pggTab.Text = "tabPage2";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 17F);
            label7.Location = new Point(96, 20);
            label7.Name = "label7";
            label7.Size = new Size(465, 57);
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
            returnBtn.Location = new Point(17, 20);
            returnBtn.Margin = new Padding(3, 4, 3, 4);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(72, 55);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkCyan;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            pggDg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            pggDg.ColumnHeadersHeight = 30;
            pggDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            pggDg.DefaultCellStyle = dataGridViewCellStyle2;
            pggDg.EnableHeadersVisualStyles = false;
            pggDg.GridColor = Color.DarkCyan;
            pggDg.ImeMode = ImeMode.NoControl;
            pggDg.Location = new Point(0, 160);
            pggDg.Margin = new Padding(3, 4, 3, 4);
            pggDg.Name = "pggDg";
            pggDg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            pggDg.RowHeadersVisible = false;
            pggDg.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            pggDg.RowsDefaultCellStyle = dataGridViewCellStyle3;
            pggDg.RowTemplate.Height = 25;
            pggDg.RowTemplate.ReadOnly = true;
            pggDg.Size = new Size(1055, 541);
            pggDg.TabIndex = 2;
            // 
            // taiKhoanTab
            // 
            taiKhoanTab.Location = new Point(4, 29);
            taiKhoanTab.Margin = new Padding(3, 4, 3, 4);
            taiKhoanTab.Name = "taiKhoanTab";
            taiKhoanTab.Size = new Size(1056, 706);
            taiKhoanTab.TabIndex = 2;
            taiKhoanTab.Text = "tabPage3";
            taiKhoanTab.UseVisualStyleBackColor = true;
            // 
            // BanHangView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 852);
            Controls.Add(panel1);
            Controls.Add(titleBar);
            Margin = new Padding(3, 4, 3, 4);
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
		private TabPage taiKhoanTab;
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
	}
}