namespace DoAn_QLCF_cs_WinForm.CustomUserControl
{
	partial class ChiTietHoaDonUC
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietHoaDonUC));
			hinhAnhPbx = new PictureBox();
			tenLbl = new Label();
			giaTienLbl = new Label();
			xoaBtn = new CustomControl.CustomButton();
			label3 = new Label();
			soLuongLbl = new Label();
			addBtn = new CustomControl.CustomButton();
			minusBtn = new CustomControl.CustomButton();
			((System.ComponentModel.ISupportInitialize)hinhAnhPbx).BeginInit();
			SuspendLayout();
			// 
			// hinhAnhPbx
			// 
			hinhAnhPbx.Dock = DockStyle.Left;
			hinhAnhPbx.Image = Properties.Resources.CaPheEspresso;
			hinhAnhPbx.Location = new Point(0, 0);
			hinhAnhPbx.Name = "hinhAnhPbx";
			hinhAnhPbx.Size = new Size(129, 97);
			hinhAnhPbx.SizeMode = PictureBoxSizeMode.StretchImage;
			hinhAnhPbx.TabIndex = 0;
			hinhAnhPbx.TabStop = false;
			// 
			// tenLbl
			// 
			tenLbl.AutoSize = true;
			tenLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			tenLbl.Location = new Point(135, 10);
			tenLbl.Name = "tenLbl";
			tenLbl.Size = new Size(166, 21);
			tenLbl.TabIndex = 1;
			tenLbl.Text = "Cà phê truyền thống";
			// 
			// giaTienLbl
			// 
			giaTienLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			giaTienLbl.AutoSize = true;
			giaTienLbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			giaTienLbl.ForeColor = Color.Red;
			giaTienLbl.Location = new Point(135, 59);
			giaTienLbl.Name = "giaTienLbl";
			giaTienLbl.Size = new Size(49, 19);
			giaTienLbl.TabIndex = 2;
			giaTienLbl.Text = "12000";
			// 
			// xoaBtn
			// 
			xoaBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			xoaBtn.BackColor = Color.MediumSlateBlue;
			xoaBtn.BackgroundColor = Color.MediumSlateBlue;
			xoaBtn.BorderColor = Color.PaleVioletRed;
			xoaBtn.BorderRadius = 10;
			xoaBtn.BorderSize = 0;
			xoaBtn.Cursor = Cursors.Hand;
			xoaBtn.EnabledTextHover = false;
			xoaBtn.FlatAppearance.BorderSize = 0;
			xoaBtn.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
			xoaBtn.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
			xoaBtn.FlatStyle = FlatStyle.Flat;
			xoaBtn.ForeColor = Color.White;
			xoaBtn.Image = (Image)resources.GetObject("xoaBtn.Image");
			xoaBtn.ImageHover = null;
			xoaBtn.Location = new Point(405, 3);
			xoaBtn.Name = "xoaBtn";
			xoaBtn.Size = new Size(39, 32);
			xoaBtn.TabIndex = 3;
			xoaBtn.TextColor = Color.White;
			xoaBtn.TextHover = Color.White;
			xoaBtn.UseVisualStyleBackColor = false;
			xoaBtn.Click += xoaBtn_Click;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.Red;
			label3.Location = new Point(185, 55);
			label3.Name = "label3";
			label3.Size = new Size(18, 20);
			label3.TabIndex = 2;
			label3.Text = "đ";
			// 
			// soLuongLbl
			// 
			soLuongLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			soLuongLbl.BackColor = SystemColors.Control;
			soLuongLbl.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			soLuongLbl.ForeColor = Color.Black;
			soLuongLbl.Location = new Point(373, 57);
			soLuongLbl.Name = "soLuongLbl";
			soLuongLbl.Size = new Size(32, 29);
			soLuongLbl.TabIndex = 2;
			soLuongLbl.Text = "1";
			soLuongLbl.TextAlign = ContentAlignment.MiddleCenter;
			soLuongLbl.TextChanged += soLuongLbl_TextChanged;
			// 
			// addBtn
			// 
			addBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			addBtn.BackColor = Color.MediumSlateBlue;
			addBtn.BackgroundColor = Color.MediumSlateBlue;
			addBtn.BorderColor = Color.PaleVioletRed;
			addBtn.BorderRadius = 3;
			addBtn.BorderSize = 0;
			addBtn.Cursor = Cursors.Hand;
			addBtn.EnabledTextHover = false;
			addBtn.FlatAppearance.BorderSize = 0;
			addBtn.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
			addBtn.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
			addBtn.FlatStyle = FlatStyle.Flat;
			addBtn.ForeColor = Color.White;
			addBtn.Image = (Image)resources.GetObject("addBtn.Image");
			addBtn.ImageHover = null;
			addBtn.Location = new Point(405, 57);
			addBtn.Name = "addBtn";
			addBtn.Size = new Size(39, 29);
			addBtn.TabIndex = 3;
			addBtn.TextColor = Color.White;
			addBtn.TextHover = Color.White;
			addBtn.UseVisualStyleBackColor = false;
			addBtn.Click += addBtn_Click;
			// 
			// minusBtn
			// 
			minusBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			minusBtn.BackColor = Color.MediumSlateBlue;
			minusBtn.BackgroundColor = Color.MediumSlateBlue;
			minusBtn.BorderColor = Color.PaleVioletRed;
			minusBtn.BorderRadius = 3;
			minusBtn.BorderSize = 0;
			minusBtn.Cursor = Cursors.Hand;
			minusBtn.EnabledTextHover = false;
			minusBtn.FlatAppearance.BorderSize = 0;
			minusBtn.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
			minusBtn.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
			minusBtn.FlatStyle = FlatStyle.Flat;
			minusBtn.ForeColor = Color.White;
			minusBtn.Image = (Image)resources.GetObject("minusBtn.Image");
			minusBtn.ImageHover = null;
			minusBtn.Location = new Point(332, 57);
			minusBtn.Name = "minusBtn";
			minusBtn.Size = new Size(39, 29);
			minusBtn.TabIndex = 3;
			minusBtn.TextColor = Color.White;
			minusBtn.TextHover = Color.White;
			minusBtn.UseVisualStyleBackColor = false;
			minusBtn.Click += minusBtn_Click;
			// 
			// ChiTietHoaDonUC
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			Controls.Add(minusBtn);
			Controls.Add(addBtn);
			Controls.Add(xoaBtn);
			Controls.Add(label3);
			Controls.Add(soLuongLbl);
			Controls.Add(giaTienLbl);
			Controls.Add(tenLbl);
			Controls.Add(hinhAnhPbx);
			Name = "ChiTietHoaDonUC";
			Size = new Size(447, 97);
			((System.ComponentModel.ISupportInitialize)hinhAnhPbx).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox hinhAnhPbx;
		private Label tenLbl;
		private Label giaTienLbl;
		private CustomControl.CustomButton xoaBtn;
		private Label label3;
		private Label soLuongLbl;
		private CustomControl.CustomButton addBtn;
		private CustomControl.CustomButton minusBtn;
	}
}
