namespace DoAn_QLCF_cs_WinForm.CustomUserControl
{
	partial class SanPhamCaPheUC
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPhamCaPheUC));
			giaTienLbl = new Label();
			tenLbl = new Label();
			hinhAnhPbx = new PictureBox();
			addToCartBtn = new CustomControl.CustomButton();
			((System.ComponentModel.ISupportInitialize)hinhAnhPbx).BeginInit();
			SuspendLayout();
			// 
			// giaTienLbl
			// 
			giaTienLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			giaTienLbl.AutoEllipsis = true;
			giaTienLbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			giaTienLbl.ForeColor = Color.Red;
			giaTienLbl.Location = new Point(1, 154);
			giaTienLbl.Name = "giaTienLbl";
			giaTienLbl.Size = new Size(116, 36);
			giaTienLbl.TabIndex = 2;
			giaTienLbl.Text = "12000 VND";
			giaTienLbl.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// tenLbl
			// 
			tenLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tenLbl.AutoEllipsis = true;
			tenLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			tenLbl.Location = new Point(0, 105);
			tenLbl.Name = "tenLbl";
			tenLbl.Size = new Size(192, 41);
			tenLbl.TabIndex = 1;
			tenLbl.Text = "Cà phê truyền thống";
			// 
			// hinhAnhPbx
			// 
			hinhAnhPbx.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			hinhAnhPbx.Image = Properties.Resources.CaPheEspresso;
			hinhAnhPbx.Location = new Point(0, 0);
			hinhAnhPbx.Name = "hinhAnhPbx";
			hinhAnhPbx.Size = new Size(192, 102);
			hinhAnhPbx.SizeMode = PictureBoxSizeMode.StretchImage;
			hinhAnhPbx.TabIndex = 0;
			hinhAnhPbx.TabStop = false;
			// 
			// addToCartBtn
			// 
			addToCartBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			addToCartBtn.BackColor = SystemColors.GradientInactiveCaption;
			addToCartBtn.BackgroundColor = SystemColors.GradientInactiveCaption;
			addToCartBtn.BorderColor = Color.Crimson;
			addToCartBtn.BorderRadius = 15;
			addToCartBtn.BorderSize = 2;
			addToCartBtn.Cursor = Cursors.Hand;
			addToCartBtn.EnabledTextHover = true;
			addToCartBtn.FlatAppearance.BorderSize = 0;
			addToCartBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(205, 24, 60);
			addToCartBtn.FlatAppearance.MouseOverBackColor = Color.Crimson;
			addToCartBtn.FlatStyle = FlatStyle.Flat;
			addToCartBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			addToCartBtn.ForeColor = Color.Crimson;
			addToCartBtn.Image = (Image)resources.GetObject("addToCartBtn.Image");
			addToCartBtn.ImageHover = (Image)resources.GetObject("addToCartBtn.ImageHover");
			addToCartBtn.Location = new Point(120, 185);
			addToCartBtn.Name = "addToCartBtn";
			addToCartBtn.Size = new Size(72, 38);
			addToCartBtn.TabIndex = 4;
			addToCartBtn.TextColor = Color.Crimson;
			addToCartBtn.TextHover = Color.White;
			addToCartBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			addToCartBtn.UseVisualStyleBackColor = false;
			addToCartBtn.Click += addToCartBtn_Click;
			// 
			// btnNavToolTip
			// 
			btnNavToolTip.AutoPopDelay = 5000;
			btnNavToolTip.InitialDelay = 1;
			btnNavToolTip.ReshowDelay = 1;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.AutoEllipsis = true;
			label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Red;
			label1.Location = new Point(50, 142);
			label1.Name = "label1";
			label1.Size = new Size(20, 30);
			label1.TabIndex = 2;
			label1.Text = "đ";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// SanPhamCaPheUC
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			Controls.Add(addToCartBtn);
			Controls.Add(label1);
			Controls.Add(giaTienLbl);
			Controls.Add(tenLbl);
			Controls.Add(hinhAnhPbx);
			Name = "SanPhamCaPheUC";
			Size = new Size(192, 223);
			((System.ComponentModel.ISupportInitialize)hinhAnhPbx).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Label giaTienLbl;
		private Label tenLbl;
		private PictureBox hinhAnhPbx;
		private CustomControl.CustomButton addToCartBtn;
	}
}
