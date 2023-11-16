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
			customButton2 = new CustomControl.CustomButton();
			editBtn = new CustomControl.CustomButton();
			addBtn = new CustomControl.CustomButton();
			searchTxt = new CustomControl.CustomTextBox();
			dataGridView1 = new DataGridView();
			DetailsTabPage = new TabPage();
			idTxt = new CustomControl.CustomTextBox();
			customButton1 = new CustomControl.CustomButton();
			customButton3 = new CustomControl.CustomButton();
			customTextBox4 = new CustomControl.CustomTextBox();
			customTextBox5 = new CustomControl.CustomTextBox();
			customTextBox6 = new CustomControl.CustomTextBox();
			customTextBox3 = new CustomControl.CustomTextBox();
			customTextBox2 = new CustomControl.CustomTextBox();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			tabControl1.SuspendLayout();
			listTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			DetailsTabPage.SuspendLayout();
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
			tabControl1.Size = new Size(929, 554);
			tabControl1.TabIndex = 2;
			// 
			// listTabPage
			// 
			listTabPage.BackColor = SystemColors.Control;
			listTabPage.Controls.Add(customButton2);
			listTabPage.Controls.Add(editBtn);
			listTabPage.Controls.Add(addBtn);
			listTabPage.Controls.Add(searchTxt);
			listTabPage.Controls.Add(dataGridView1);
			listTabPage.Location = new Point(4, 24);
			listTabPage.Name = "listTabPage";
			listTabPage.Padding = new Padding(3);
			listTabPage.Size = new Size(921, 526);
			listTabPage.TabIndex = 0;
			listTabPage.Text = "Danh Sách";
			// 
			// customButton2
			// 
			customButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			customButton2.BackColor = Color.Red;
			customButton2.BackgroundColor = Color.Red;
			customButton2.BorderColor = Color.PaleVioletRed;
			customButton2.BorderRadius = 15;
			customButton2.BorderSize = 0;
			customButton2.EnabledTextHover = false;
			customButton2.FlatAppearance.BorderSize = 0;
			customButton2.FlatAppearance.MouseDownBackColor = Color.Red;
			customButton2.FlatAppearance.MouseOverBackColor = Color.Crimson;
			customButton2.FlatStyle = FlatStyle.Flat;
			customButton2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			customButton2.ForeColor = Color.White;
			customButton2.Location = new Point(794, 6);
			customButton2.Name = "customButton2";
			customButton2.Size = new Size(94, 36);
			customButton2.TabIndex = 5;
			customButton2.Text = "Xóa";
			customButton2.TextColor = Color.White;
			customButton2.TextHover = Color.White;
			customButton2.UseVisualStyleBackColor = false;
			// 
			// editBtn
			// 
			editBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			editBtn.BackColor = Color.Teal;
			editBtn.BackgroundColor = Color.Teal;
			editBtn.BorderColor = Color.PaleVioletRed;
			editBtn.BorderRadius = 15;
			editBtn.BorderSize = 0;
			editBtn.EnabledTextHover = false;
			editBtn.FlatAppearance.BorderSize = 0;
			editBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
			editBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
			editBtn.FlatStyle = FlatStyle.Flat;
			editBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			editBtn.ForeColor = Color.White;
			editBtn.Location = new Point(687, 6);
			editBtn.Name = "editBtn";
			editBtn.Size = new Size(94, 36);
			editBtn.TabIndex = 4;
			editBtn.Text = "Sửa";
			editBtn.TextColor = Color.White;
			editBtn.TextHover = Color.White;
			editBtn.UseVisualStyleBackColor = false;
			// 
			// addBtn
			// 
			addBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			addBtn.BackColor = Color.Teal;
			addBtn.BackgroundColor = Color.Teal;
			addBtn.BorderColor = Color.PaleVioletRed;
			addBtn.BorderRadius = 15;
			addBtn.BorderSize = 0;
			addBtn.EnabledTextHover = false;
			addBtn.FlatAppearance.BorderSize = 0;
			addBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
			addBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
			addBtn.FlatStyle = FlatStyle.Flat;
			addBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			addBtn.ForeColor = Color.White;
			addBtn.Location = new Point(567, 6);
			addBtn.Name = "addBtn";
			addBtn.Size = new Size(107, 36);
			addBtn.TabIndex = 3;
			addBtn.Text = "Thêm";
			addBtn.TextColor = Color.White;
			addBtn.TextHover = Color.White;
			addBtn.UseVisualStyleBackColor = false;
			addBtn.Click += addBtn_Click;
			// 
			// searchTxt
			// 
			searchTxt.BackColor = SystemColors.Window;
			searchTxt.BorderColor = Color.Silver;
			searchTxt.BorderFocusColor = Color.HotPink;
			searchTxt.BorderRadius = 12;
			searchTxt.BorderSize = 3;
			searchTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			searchTxt.ForeColor = Color.DimGray;
			searchTxt.Location = new Point(6, 6);
			searchTxt.Multiline = false;
			searchTxt.Name = "searchTxt";
			searchTxt.Padding = new Padding(9, 7, 7, 7);
			searchTxt.PasswordChar = false;
			searchTxt.PlaceholderColor = Color.DarkGray;
			searchTxt.PlaceholderText = "Tìm Kiếm ...";
			searchTxt.Size = new Size(237, 36);
			searchTxt.TabIndex = 2;
			searchTxt.Texts = "";
			searchTxt.UnderlinedStyle = false;
			// 
			// dataGridView1
			// 
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(3, 81);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(915, 442);
			dataGridView1.TabIndex = 1;
			// 
			// DetailsTabPage
			// 
			DetailsTabPage.BackColor = SystemColors.Control;
			DetailsTabPage.Controls.Add(idTxt);
			DetailsTabPage.Controls.Add(customButton1);
			DetailsTabPage.Controls.Add(customButton3);
			DetailsTabPage.Controls.Add(customTextBox4);
			DetailsTabPage.Controls.Add(customTextBox5);
			DetailsTabPage.Controls.Add(customTextBox6);
			DetailsTabPage.Controls.Add(customTextBox3);
			DetailsTabPage.Controls.Add(customTextBox2);
			DetailsTabPage.Controls.Add(label6);
			DetailsTabPage.Controls.Add(label5);
			DetailsTabPage.Controls.Add(label4);
			DetailsTabPage.Controls.Add(label3);
			DetailsTabPage.Controls.Add(label2);
			DetailsTabPage.Controls.Add(label1);
			DetailsTabPage.Location = new Point(4, 24);
			DetailsTabPage.Name = "DetailsTabPage";
			DetailsTabPage.Padding = new Padding(3);
			DetailsTabPage.Size = new Size(921, 526);
			DetailsTabPage.TabIndex = 1;
			DetailsTabPage.Text = "Chi Tiết";
			// 
			// idTxt
			// 
			idTxt.BackColor = SystemColors.Window;
			idTxt.BorderColor = Color.Silver;
			idTxt.BorderFocusColor = Color.HotPink;
			idTxt.BorderRadius = 13;
			idTxt.BorderSize = 3;
			idTxt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			idTxt.ForeColor = Color.DimGray;
			idTxt.Location = new Point(111, 43);
			idTxt.Multiline = false;
			idTxt.Name = "idTxt";
			idTxt.Padding = new Padding(9, 7, 7, 7);
			idTxt.PasswordChar = false;
			idTxt.PlaceholderColor = Color.DarkGray;
			idTxt.PlaceholderText = "Tìm Kiếm ...";
			idTxt.Size = new Size(244, 40);
			idTxt.TabIndex = 14;
			idTxt.Texts = "";
			idTxt.UnderlinedStyle = false;
			// 
			// customButton1
			// 
			customButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			customButton1.BackColor = Color.Red;
			customButton1.BackgroundColor = Color.Red;
			customButton1.BorderColor = Color.PaleVioletRed;
			customButton1.BorderRadius = 15;
			customButton1.BorderSize = 0;
			customButton1.EnabledTextHover = false;
			customButton1.FlatAppearance.BorderSize = 0;
			customButton1.FlatAppearance.MouseDownBackColor = Color.Red;
			customButton1.FlatAppearance.MouseOverBackColor = Color.Crimson;
			customButton1.FlatStyle = FlatStyle.Flat;
			customButton1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			customButton1.ForeColor = Color.White;
			customButton1.Location = new Point(703, 399);
			customButton1.Name = "customButton1";
			customButton1.Size = new Size(122, 48);
			customButton1.TabIndex = 13;
			customButton1.Text = "Hủy";
			customButton1.TextColor = Color.White;
			customButton1.TextHover = Color.White;
			customButton1.UseVisualStyleBackColor = false;
			// 
			// customButton3
			// 
			customButton3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			customButton3.BackColor = Color.Teal;
			customButton3.BackgroundColor = Color.Teal;
			customButton3.BorderColor = Color.PaleVioletRed;
			customButton3.BorderRadius = 15;
			customButton3.BorderSize = 0;
			customButton3.EnabledTextHover = false;
			customButton3.FlatAppearance.BorderSize = 0;
			customButton3.FlatAppearance.MouseDownBackColor = Color.Teal;
			customButton3.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
			customButton3.FlatStyle = FlatStyle.Flat;
			customButton3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			customButton3.ForeColor = Color.White;
			customButton3.Location = new Point(560, 399);
			customButton3.Name = "customButton3";
			customButton3.Size = new Size(122, 48);
			customButton3.TabIndex = 12;
			customButton3.Text = "Xác Nhận";
			customButton3.TextColor = Color.White;
			customButton3.TextHover = Color.White;
			customButton3.UseVisualStyleBackColor = false;
			// 
			// customTextBox4
			// 
			customTextBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			customTextBox4.BackColor = SystemColors.Window;
			customTextBox4.BorderColor = Color.Silver;
			customTextBox4.BorderFocusColor = Color.HotPink;
			customTextBox4.BorderRadius = 13;
			customTextBox4.BorderSize = 3;
			customTextBox4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			customTextBox4.ForeColor = Color.DimGray;
			customTextBox4.Location = new Point(596, 234);
			customTextBox4.Multiline = false;
			customTextBox4.Name = "customTextBox4";
			customTextBox4.Padding = new Padding(9, 7, 7, 7);
			customTextBox4.PasswordChar = false;
			customTextBox4.PlaceholderColor = Color.DarkGray;
			customTextBox4.PlaceholderText = "Tìm Kiếm ...";
			customTextBox4.Size = new Size(244, 40);
			customTextBox4.TabIndex = 11;
			customTextBox4.Texts = "";
			customTextBox4.UnderlinedStyle = false;
			// 
			// customTextBox5
			// 
			customTextBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			customTextBox5.BackColor = SystemColors.Window;
			customTextBox5.BorderColor = Color.Silver;
			customTextBox5.BorderFocusColor = Color.HotPink;
			customTextBox5.BorderRadius = 13;
			customTextBox5.BorderSize = 3;
			customTextBox5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			customTextBox5.ForeColor = Color.DimGray;
			customTextBox5.Location = new Point(596, 137);
			customTextBox5.Multiline = false;
			customTextBox5.Name = "customTextBox5";
			customTextBox5.Padding = new Padding(9, 7, 7, 7);
			customTextBox5.PasswordChar = false;
			customTextBox5.PlaceholderColor = Color.DarkGray;
			customTextBox5.PlaceholderText = "Tìm Kiếm ...";
			customTextBox5.Size = new Size(244, 40);
			customTextBox5.TabIndex = 10;
			customTextBox5.Texts = "";
			customTextBox5.UnderlinedStyle = false;
			// 
			// customTextBox6
			// 
			customTextBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			customTextBox6.BackColor = SystemColors.Window;
			customTextBox6.BorderColor = Color.Silver;
			customTextBox6.BorderFocusColor = Color.HotPink;
			customTextBox6.BorderRadius = 13;
			customTextBox6.BorderSize = 3;
			customTextBox6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			customTextBox6.ForeColor = Color.DimGray;
			customTextBox6.Location = new Point(596, 43);
			customTextBox6.Multiline = false;
			customTextBox6.Name = "customTextBox6";
			customTextBox6.Padding = new Padding(9, 7, 7, 7);
			customTextBox6.PasswordChar = false;
			customTextBox6.PlaceholderColor = Color.DarkGray;
			customTextBox6.PlaceholderText = "Tìm Kiếm ...";
			customTextBox6.Size = new Size(244, 40);
			customTextBox6.TabIndex = 9;
			customTextBox6.Texts = "";
			customTextBox6.UnderlinedStyle = false;
			// 
			// customTextBox3
			// 
			customTextBox3.BackColor = SystemColors.Window;
			customTextBox3.BorderColor = Color.Silver;
			customTextBox3.BorderFocusColor = Color.HotPink;
			customTextBox3.BorderRadius = 13;
			customTextBox3.BorderSize = 3;
			customTextBox3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			customTextBox3.ForeColor = Color.DimGray;
			customTextBox3.Location = new Point(111, 234);
			customTextBox3.Multiline = false;
			customTextBox3.Name = "customTextBox3";
			customTextBox3.Padding = new Padding(9, 7, 7, 7);
			customTextBox3.PasswordChar = false;
			customTextBox3.PlaceholderColor = Color.DarkGray;
			customTextBox3.PlaceholderText = "Tìm Kiếm ...";
			customTextBox3.Size = new Size(244, 40);
			customTextBox3.TabIndex = 8;
			customTextBox3.Texts = "";
			customTextBox3.UnderlinedStyle = false;
			// 
			// customTextBox2
			// 
			customTextBox2.BackColor = SystemColors.Window;
			customTextBox2.BorderColor = Color.Silver;
			customTextBox2.BorderFocusColor = Color.HotPink;
			customTextBox2.BorderRadius = 13;
			customTextBox2.BorderSize = 3;
			customTextBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			customTextBox2.ForeColor = Color.DimGray;
			customTextBox2.Location = new Point(111, 137);
			customTextBox2.Multiline = false;
			customTextBox2.Name = "customTextBox2";
			customTextBox2.Padding = new Padding(9, 7, 7, 7);
			customTextBox2.PasswordChar = false;
			customTextBox2.PlaceholderColor = Color.DarkGray;
			customTextBox2.PlaceholderText = "Tìm Kiếm ...";
			customTextBox2.Size = new Size(244, 40);
			customTextBox2.TabIndex = 7;
			customTextBox2.Texts = "";
			customTextBox2.UnderlinedStyle = false;
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
			label6.Location = new Point(468, 227);
			label6.Name = "label6";
			label6.Size = new Size(79, 51);
			label6.TabIndex = 5;
			label6.Text = "Loại";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(26, 132);
			label5.Name = "label5";
			label5.Size = new Size(79, 51);
			label5.TabIndex = 4;
			label5.Text = "Tên";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(8, 227);
			label4.Name = "label4";
			label4.Size = new Size(106, 51);
			label4.TabIndex = 3;
			label4.Text = "Xuất Xứ";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(447, 37);
			label3.Name = "label3";
			label3.Size = new Size(132, 51);
			label3.TabIndex = 2;
			label3.Text = "Nội Dung";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(468, 132);
			label2.Name = "label2";
			label2.Size = new Size(79, 51);
			label2.TabIndex = 1;
			label2.Text = "Công Thức";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(26, 37);
			label1.Name = "label1";
			label1.Size = new Size(79, 51);
			label1.TabIndex = 0;
			label1.Text = "ID";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// CaPheView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(929, 554);
			Controls.Add(tabControl1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "CaPheView";
			Text = "CaPheView";
			tabControl1.ResumeLayout(false);
			listTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			DetailsTabPage.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private TabControl tabControl1;
		private TabPage listTabPage;
		private DataGridView dataGridView1;
		private CustomControl.CustomButton addBtn;
		private CustomControl.CustomTextBox searchTxt;
		private CustomControl.CustomButton customButton2;
		private CustomControl.CustomButton editBtn;
		private TabPage DetailsTabPage;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private CustomControl.CustomTextBox customTextBox3;
		private CustomControl.CustomTextBox customTextBox2;
		private CustomControl.CustomButton customButton1;
		private CustomControl.CustomButton customButton3;
		private CustomControl.CustomTextBox customTextBox4;
		private CustomControl.CustomTextBox customTextBox5;
		private CustomControl.CustomTextBox customTextBox6;
		private CustomControl.CustomTextBox idTxt;
	}
}