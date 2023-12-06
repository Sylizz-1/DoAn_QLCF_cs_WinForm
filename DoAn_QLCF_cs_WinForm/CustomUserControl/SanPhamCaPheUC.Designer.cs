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
			detailsBtn = new CustomControl.CustomButton();
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
			giaTienLbl.Location = new Point(0, 158);
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
			tenLbl.Location = new Point(0, 117);
			tenLbl.Name = "tenLbl";
			tenLbl.Size = new Size(201, 41);
			tenLbl.TabIndex = 1;
			tenLbl.Text = "Cà phê truyền thống";
			// 
			// detailsBtn
			// 
			detailsBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			detailsBtn.BackColor = SystemColors.Control;
			detailsBtn.BackgroundColor = SystemColors.Control;
			detailsBtn.BorderColor = Color.Blue;
			detailsBtn.BorderRadius = 15;
			detailsBtn.BorderSize = 2;
			detailsBtn.Cursor = Cursors.Hand;
			detailsBtn.EnabledTextHover = true;
			detailsBtn.FlatAppearance.BorderSize = 0;
			detailsBtn.FlatAppearance.MouseDownBackColor = Color.MediumBlue;
			detailsBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
			detailsBtn.FlatStyle = FlatStyle.Flat;
			detailsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			detailsBtn.ForeColor = Color.Blue;
			detailsBtn.Image = (Image)resources.GetObject("detailsBtn.Image");
			detailsBtn.ImageHover = (Image)resources.GetObject("detailsBtn.ImageHover");
			detailsBtn.Location = new Point(36, 206);
			detailsBtn.Name = "detailsBtn";
			detailsBtn.Size = new Size(78, 38);
			detailsBtn.TabIndex = 4;
			detailsBtn.TextColor = Color.Blue;
			detailsBtn.TextHover = Color.White;
			detailsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			detailsBtn.UseVisualStyleBackColor = false;
			// 
			// hinhAnhPbx
			// 
			hinhAnhPbx.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			hinhAnhPbx.Location = new Point(0, 0);
			hinhAnhPbx.Name = "hinhAnhPbx";
			hinhAnhPbx.Size = new Size(201, 114);
			hinhAnhPbx.TabIndex = 0;
			hinhAnhPbx.TabStop = false;
			// 
			// addToCartBtn
			// 
			addToCartBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			addToCartBtn.BackColor = SystemColors.Control;
			addToCartBtn.BackgroundColor = SystemColors.Control;
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
			addToCartBtn.Location = new Point(120, 206);
			addToCartBtn.Name = "addToCartBtn";
			addToCartBtn.Size = new Size(78, 38);
			addToCartBtn.TabIndex = 4;
			addToCartBtn.TextColor = Color.Crimson;
			addToCartBtn.TextHover = Color.White;
			addToCartBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
			addToCartBtn.UseVisualStyleBackColor = false;
			// 
			// SanPhamCaPheUC
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(addToCartBtn);
			Controls.Add(detailsBtn);
			Controls.Add(giaTienLbl);
			Controls.Add(tenLbl);
			Controls.Add(hinhAnhPbx);
			Name = "SanPhamCaPheUC";
			Size = new Size(201, 244);
			((System.ComponentModel.ISupportInitialize)hinhAnhPbx).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Label giaTienLbl;
		private Label tenLbl;
		private CustomControl.CustomButton detailsBtn;
		private PictureBox hinhAnhPbx;
		private CustomControl.CustomButton addToCartBtn;
	}
}
