namespace DoAn_QLCF_cs_WinForm.View
{
    partial class PhanQuyenView
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
            grb_quyen = new GroupBox();
            tc_quyen = new TabControl();
            tp_quyenDanhSach = new TabPage();
            btn_detailPermission = new CustomControl.CustomButton();
            dtgrv_quyen = new DataGridView();
            btn_deletePermission = new CustomControl.CustomButton();
            btn_editPermission = new CustomControl.CustomButton();
            btn_addPermission = new CustomControl.CustomButton();
            customButton2 = new CustomControl.CustomButton();
            searchTxt = new CustomControl.CustomTextBox();
            tp_quyenChiTiet = new TabPage();
            btn_cancel = new CustomControl.CustomButton();
            btn_acceptPermission = new CustomControl.CustomButton();
            txt_contentPermission = new CustomControl.CustomTextBox();
            txt_namePermission = new CustomControl.CustomTextBox();
            groupBox1 = new GroupBox();
            clb_chucNang = new CheckedListBox();
            label3 = new Label();
            label2 = new Label();
            txt_idPermission = new CustomControl.CustomTextBox();
            label1 = new Label();
            btn_backPermission = new CustomControl.CustomButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            grb_chucNang = new GroupBox();
            tc_chucNang = new TabControl();
            tp_chucNangDanhSach = new TabPage();
            dtgrv_chucNang = new DataGridView();
            customButton3 = new CustomControl.CustomButton();
            customButton4 = new CustomControl.CustomButton();
            customButton5 = new CustomControl.CustomButton();
            customButton1 = new CustomControl.CustomButton();
            customTextBox1 = new CustomControl.CustomTextBox();
            tp_chucNangChiTiet = new TabPage();
            grb_quyen.SuspendLayout();
            tc_quyen.SuspendLayout();
            tp_quyenDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrv_quyen).BeginInit();
            tp_quyenChiTiet.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            grb_chucNang.SuspendLayout();
            tc_chucNang.SuspendLayout();
            tp_chucNangDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrv_chucNang).BeginInit();
            SuspendLayout();
            // 
            // grb_quyen
            // 
            grb_quyen.BackColor = SystemColors.Window;
            grb_quyen.Controls.Add(tc_quyen);
            grb_quyen.Dock = DockStyle.Fill;
            grb_quyen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grb_quyen.Location = new Point(3, 3);
            grb_quyen.Name = "grb_quyen";
            grb_quyen.Size = new Size(744, 734);
            grb_quyen.TabIndex = 0;
            grb_quyen.TabStop = false;
            grb_quyen.Text = "Quyền";
            // 
            // tc_quyen
            // 
            tc_quyen.Controls.Add(tp_quyenDanhSach);
            tc_quyen.Controls.Add(tp_quyenChiTiet);
            tc_quyen.Dock = DockStyle.Fill;
            tc_quyen.Location = new Point(3, 30);
            tc_quyen.Name = "tc_quyen";
            tc_quyen.SelectedIndex = 0;
            tc_quyen.Size = new Size(738, 701);
            tc_quyen.TabIndex = 0;
            // 
            // tp_quyenDanhSach
            // 
            tp_quyenDanhSach.BackColor = SystemColors.Window;
            tp_quyenDanhSach.Controls.Add(btn_detailPermission);
            tp_quyenDanhSach.Controls.Add(dtgrv_quyen);
            tp_quyenDanhSach.Controls.Add(btn_deletePermission);
            tp_quyenDanhSach.Controls.Add(btn_editPermission);
            tp_quyenDanhSach.Controls.Add(btn_addPermission);
            tp_quyenDanhSach.Controls.Add(customButton2);
            tp_quyenDanhSach.Controls.Add(searchTxt);
            tp_quyenDanhSach.Location = new Point(4, 37);
            tp_quyenDanhSach.Name = "tp_quyenDanhSach";
            tp_quyenDanhSach.Padding = new Padding(3);
            tp_quyenDanhSach.Size = new Size(730, 660);
            tp_quyenDanhSach.TabIndex = 0;
            tp_quyenDanhSach.Text = "Danh Sách";
            // 
            // btn_detailPermission
            // 
            btn_detailPermission.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_detailPermission.BackColor = SystemColors.Control;
            btn_detailPermission.BackgroundColor = SystemColors.Control;
            btn_detailPermission.BorderColor = Color.DarkCyan;
            btn_detailPermission.BorderRadius = 15;
            btn_detailPermission.BorderSize = 2;
            btn_detailPermission.Cursor = Cursors.Hand;
            btn_detailPermission.EnabledTextHover = true;
            btn_detailPermission.FlatAppearance.BorderSize = 0;
            btn_detailPermission.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_detailPermission.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_detailPermission.FlatStyle = FlatStyle.Flat;
            btn_detailPermission.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_detailPermission.ForeColor = Color.DarkCyan;
            btn_detailPermission.Image = Properties.Resources.detailsIcon16px;
            btn_detailPermission.ImageAlign = ContentAlignment.MiddleRight;
            btn_detailPermission.ImageHover = Properties.Resources.detailsIcon16pxWHITE;
            btn_detailPermission.Location = new Point(586, 63);
            btn_detailPermission.Margin = new Padding(3, 4, 3, 4);
            btn_detailPermission.Name = "btn_detailPermission";
            btn_detailPermission.Size = new Size(138, 51);
            btn_detailPermission.TabIndex = 17;
            btn_detailPermission.Text = "  Chi Tiết";
            btn_detailPermission.TextColor = Color.DarkCyan;
            btn_detailPermission.TextHover = Color.White;
            btn_detailPermission.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_detailPermission.UseVisualStyleBackColor = false;
            btn_detailPermission.Click += btn_detailPermission_Click;
            // 
            // dtgrv_quyen
            // 
            dtgrv_quyen.AllowUserToAddRows = false;
            dtgrv_quyen.AllowUserToDeleteRows = false;
            dtgrv_quyen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgrv_quyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrv_quyen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgrv_quyen.BorderStyle = BorderStyle.None;
            dtgrv_quyen.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkCyan;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgrv_quyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgrv_quyen.ColumnHeadersHeight = 30;
            dtgrv_quyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgrv_quyen.DefaultCellStyle = dataGridViewCellStyle2;
            dtgrv_quyen.EnableHeadersVisualStyles = false;
            dtgrv_quyen.GridColor = Color.DarkCyan;
            dtgrv_quyen.ImeMode = ImeMode.NoControl;
            dtgrv_quyen.Location = new Point(3, 180);
            dtgrv_quyen.Margin = new Padding(3, 4, 3, 4);
            dtgrv_quyen.Name = "dtgrv_quyen";
            dtgrv_quyen.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgrv_quyen.RowHeadersVisible = false;
            dtgrv_quyen.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrv_quyen.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtgrv_quyen.RowTemplate.Height = 25;
            dtgrv_quyen.RowTemplate.ReadOnly = true;
            dtgrv_quyen.Size = new Size(724, 477);
            dtgrv_quyen.TabIndex = 15;
            // 
            // btn_deletePermission
            // 
            btn_deletePermission.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_deletePermission.BackColor = SystemColors.Control;
            btn_deletePermission.BackgroundColor = SystemColors.Control;
            btn_deletePermission.BorderColor = Color.Red;
            btn_deletePermission.BorderRadius = 15;
            btn_deletePermission.BorderSize = 2;
            btn_deletePermission.Cursor = Cursors.Hand;
            btn_deletePermission.EnabledTextHover = true;
            btn_deletePermission.FlatAppearance.BorderSize = 0;
            btn_deletePermission.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            btn_deletePermission.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_deletePermission.FlatStyle = FlatStyle.Flat;
            btn_deletePermission.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_deletePermission.ForeColor = Color.Red;
            btn_deletePermission.Image = Properties.Resources.deleteIconRed16px;
            btn_deletePermission.ImageAlign = ContentAlignment.MiddleRight;
            btn_deletePermission.ImageHover = Properties.Resources.deleteIconWhite16px;
            btn_deletePermission.Location = new Point(586, 4);
            btn_deletePermission.Margin = new Padding(3, 4, 3, 4);
            btn_deletePermission.Name = "btn_deletePermission";
            btn_deletePermission.Size = new Size(138, 51);
            btn_deletePermission.TabIndex = 14;
            btn_deletePermission.Text = "  Xóa";
            btn_deletePermission.TextColor = Color.Red;
            btn_deletePermission.TextHover = Color.White;
            btn_deletePermission.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_deletePermission.UseVisualStyleBackColor = false;
            // 
            // btn_editPermission
            // 
            btn_editPermission.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editPermission.BackColor = SystemColors.Control;
            btn_editPermission.BackgroundColor = SystemColors.Control;
            btn_editPermission.BorderColor = Color.DarkCyan;
            btn_editPermission.BorderRadius = 15;
            btn_editPermission.BorderSize = 2;
            btn_editPermission.Cursor = Cursors.Hand;
            btn_editPermission.EnabledTextHover = true;
            btn_editPermission.FlatAppearance.BorderSize = 0;
            btn_editPermission.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_editPermission.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_editPermission.FlatStyle = FlatStyle.Flat;
            btn_editPermission.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editPermission.ForeColor = Color.DarkCyan;
            btn_editPermission.Image = Properties.Resources.editIconTeal16px;
            btn_editPermission.ImageAlign = ContentAlignment.MiddleRight;
            btn_editPermission.ImageHover = Properties.Resources.editIconWhite16px;
            btn_editPermission.Location = new Point(442, 4);
            btn_editPermission.Margin = new Padding(3, 4, 3, 4);
            btn_editPermission.Name = "btn_editPermission";
            btn_editPermission.Size = new Size(138, 51);
            btn_editPermission.TabIndex = 13;
            btn_editPermission.Text = "  Sửa";
            btn_editPermission.TextColor = Color.DarkCyan;
            btn_editPermission.TextHover = Color.White;
            btn_editPermission.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editPermission.UseVisualStyleBackColor = false;
            btn_editPermission.Click += btn_editPermission_Click;
            // 
            // btn_addPermission
            // 
            btn_addPermission.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_addPermission.BackColor = SystemColors.Control;
            btn_addPermission.BackgroundColor = SystemColors.Control;
            btn_addPermission.BorderColor = Color.DarkCyan;
            btn_addPermission.BorderRadius = 15;
            btn_addPermission.BorderSize = 2;
            btn_addPermission.Cursor = Cursors.Hand;
            btn_addPermission.EnabledTextHover = true;
            btn_addPermission.FlatAppearance.BorderSize = 0;
            btn_addPermission.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_addPermission.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_addPermission.FlatStyle = FlatStyle.Flat;
            btn_addPermission.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addPermission.ForeColor = Color.DarkCyan;
            btn_addPermission.Image = Properties.Resources.addIconTeal16px;
            btn_addPermission.ImageAlign = ContentAlignment.MiddleRight;
            btn_addPermission.ImageHover = Properties.Resources.addIconWhite16px;
            btn_addPermission.Location = new Point(442, 63);
            btn_addPermission.Margin = new Padding(3, 4, 3, 4);
            btn_addPermission.Name = "btn_addPermission";
            btn_addPermission.Size = new Size(138, 51);
            btn_addPermission.TabIndex = 12;
            btn_addPermission.Text = "  Thêm";
            btn_addPermission.TextColor = Color.DarkCyan;
            btn_addPermission.TextHover = Color.White;
            btn_addPermission.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_addPermission.UseVisualStyleBackColor = false;
            btn_addPermission.Click += addBtn_Click;
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
            customButton2.Location = new Point(206, 12);
            customButton2.Margin = new Padding(3, 4, 3, 4);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(40, 37);
            customButton2.TabIndex = 7;
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
            searchTxt.Location = new Point(6, 7);
            searchTxt.Margin = new Padding(3, 4, 3, 4);
            searchTxt.Multiline = false;
            searchTxt.Name = "searchTxt";
            searchTxt.Padding = new Padding(10, 9, 46, 9);
            searchTxt.PasswordChar = false;
            searchTxt.PlaceholderColor = Color.DarkGray;
            searchTxt.PlaceholderText = "Tìm Kiếm ...";
            searchTxt.Size = new Size(249, 47);
            searchTxt.TabIndex = 3;
            searchTxt.Texts = "";
            searchTxt.UnderlinedStyle = false;
            // 
            // tp_quyenChiTiet
            // 
            tp_quyenChiTiet.BackColor = SystemColors.Window;
            tp_quyenChiTiet.Controls.Add(btn_cancel);
            tp_quyenChiTiet.Controls.Add(btn_acceptPermission);
            tp_quyenChiTiet.Controls.Add(txt_contentPermission);
            tp_quyenChiTiet.Controls.Add(txt_namePermission);
            tp_quyenChiTiet.Controls.Add(groupBox1);
            tp_quyenChiTiet.Controls.Add(label3);
            tp_quyenChiTiet.Controls.Add(label2);
            tp_quyenChiTiet.Controls.Add(txt_idPermission);
            tp_quyenChiTiet.Controls.Add(label1);
            tp_quyenChiTiet.Controls.Add(btn_backPermission);
            tp_quyenChiTiet.Location = new Point(4, 37);
            tp_quyenChiTiet.Name = "tp_quyenChiTiet";
            tp_quyenChiTiet.Padding = new Padding(3);
            tp_quyenChiTiet.Size = new Size(730, 660);
            tp_quyenChiTiet.TabIndex = 1;
            tp_quyenChiTiet.Text = "Chi Tiết";
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancel.BackColor = SystemColors.Control;
            btn_cancel.BackgroundColor = SystemColors.Control;
            btn_cancel.BorderColor = Color.Red;
            btn_cancel.BorderRadius = 15;
            btn_cancel.BorderSize = 2;
            btn_cancel.Cursor = Cursors.Hand;
            btn_cancel.EnabledTextHover = true;
            btn_cancel.FlatAppearance.BorderSize = 0;
            btn_cancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            btn_cancel.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancel.ForeColor = Color.Red;
            btn_cancel.Image = Properties.Resources.CANCELiconRed;
            btn_cancel.ImageAlign = ContentAlignment.MiddleRight;
            btn_cancel.ImageHover = Properties.Resources.CANCELiconWhite;
            btn_cancel.Location = new Point(553, 202);
            btn_cancel.Margin = new Padding(3, 4, 3, 4);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(157, 71);
            btn_cancel.TabIndex = 48;
            btn_cancel.Text = "  Hủy";
            btn_cancel.TextColor = Color.Red;
            btn_cancel.TextHover = Color.White;
            btn_cancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_acceptPermission
            // 
            btn_acceptPermission.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_acceptPermission.BackColor = SystemColors.Control;
            btn_acceptPermission.BackgroundColor = SystemColors.Control;
            btn_acceptPermission.BorderColor = Color.DarkCyan;
            btn_acceptPermission.BorderRadius = 15;
            btn_acceptPermission.BorderSize = 2;
            btn_acceptPermission.Cursor = Cursors.Hand;
            btn_acceptPermission.EnabledTextHover = true;
            btn_acceptPermission.FlatAppearance.BorderSize = 0;
            btn_acceptPermission.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_acceptPermission.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_acceptPermission.FlatStyle = FlatStyle.Flat;
            btn_acceptPermission.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_acceptPermission.ForeColor = Color.DarkCyan;
            btn_acceptPermission.Image = Properties.Resources.ConfirmIcondarkcyan1;
            btn_acceptPermission.ImageAlign = ContentAlignment.MiddleRight;
            btn_acceptPermission.ImageHover = Properties.Resources.ConfirmIconWhite1;
            btn_acceptPermission.Location = new Point(390, 202);
            btn_acceptPermission.Margin = new Padding(3, 4, 3, 4);
            btn_acceptPermission.Name = "btn_acceptPermission";
            btn_acceptPermission.Size = new Size(157, 71);
            btn_acceptPermission.TabIndex = 47;
            btn_acceptPermission.Text = "  Xác Nhận";
            btn_acceptPermission.TextColor = Color.DarkCyan;
            btn_acceptPermission.TextHover = Color.White;
            btn_acceptPermission.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_acceptPermission.UseVisualStyleBackColor = false;
            btn_acceptPermission.Click += btn_acceptPermission_Click;
            // 
            // txt_contentPermission
            // 
            txt_contentPermission.BackColor = SystemColors.Window;
            txt_contentPermission.BorderColor = Color.Silver;
            txt_contentPermission.BorderFocusColor = Color.DarkCyan;
            txt_contentPermission.BorderRadius = 13;
            txt_contentPermission.BorderSize = 2;
            txt_contentPermission.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_contentPermission.ForeColor = Color.DimGray;
            txt_contentPermission.Location = new Point(27, 209);
            txt_contentPermission.Margin = new Padding(3, 4, 3, 4);
            txt_contentPermission.Multiline = false;
            txt_contentPermission.Name = "txt_contentPermission";
            txt_contentPermission.Padding = new Padding(10, 12, 8, 9);
            txt_contentPermission.PasswordChar = false;
            txt_contentPermission.PlaceholderColor = Color.DarkGray;
            txt_contentPermission.PlaceholderText = "Nhập nội dung...";
            txt_contentPermission.Size = new Size(279, 52);
            txt_contentPermission.TabIndex = 25;
            txt_contentPermission.Texts = "";
            txt_contentPermission.UnderlinedStyle = false;
            // 
            // txt_namePermission
            // 
            txt_namePermission.BackColor = SystemColors.Window;
            txt_namePermission.BorderColor = Color.Silver;
            txt_namePermission.BorderFocusColor = Color.DarkCyan;
            txt_namePermission.BorderRadius = 13;
            txt_namePermission.BorderSize = 2;
            txt_namePermission.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_namePermission.ForeColor = Color.DimGray;
            txt_namePermission.Location = new Point(342, 101);
            txt_namePermission.Margin = new Padding(3, 4, 3, 4);
            txt_namePermission.Multiline = false;
            txt_namePermission.Name = "txt_namePermission";
            txt_namePermission.Padding = new Padding(10, 12, 8, 9);
            txt_namePermission.PasswordChar = false;
            txt_namePermission.PlaceholderColor = Color.DarkGray;
            txt_namePermission.PlaceholderText = "Nhập tên quyền...";
            txt_namePermission.Size = new Size(279, 52);
            txt_namePermission.TabIndex = 24;
            txt_namePermission.Texts = "";
            txt_namePermission.UnderlinedStyle = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(clb_chucNang);
            groupBox1.Location = new Point(6, 280);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 377);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // clb_chucNang
            // 
            clb_chucNang.CheckOnClick = true;
            clb_chucNang.Cursor = Cursors.Hand;
            clb_chucNang.Dock = DockStyle.Fill;
            clb_chucNang.FormattingEnabled = true;
            clb_chucNang.IntegralHeight = false;
            clb_chucNang.Location = new Point(3, 30);
            clb_chucNang.Name = "clb_chucNang";
            clb_chucNang.Size = new Size(715, 344);
            clb_chucNang.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(312, 52);
            label3.Name = "label3";
            label3.Size = new Size(155, 68);
            label3.TabIndex = 21;
            label3.Text = "Tên Quyền";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 157);
            label2.Name = "label2";
            label2.Size = new Size(175, 68);
            label2.TabIndex = 19;
            label2.Text = "Nội Dung Quyền";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_idPermission
            // 
            txt_idPermission.BackColor = SystemColors.Window;
            txt_idPermission.BorderColor = Color.Silver;
            txt_idPermission.BorderFocusColor = Color.DarkCyan;
            txt_idPermission.BorderRadius = 13;
            txt_idPermission.BorderSize = 2;
            txt_idPermission.Enabled = false;
            txt_idPermission.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_idPermission.ForeColor = Color.DimGray;
            txt_idPermission.Location = new Point(27, 101);
            txt_idPermission.Margin = new Padding(3, 4, 3, 4);
            txt_idPermission.Multiline = false;
            txt_idPermission.Name = "txt_idPermission";
            txt_idPermission.Padding = new Padding(10, 12, 8, 9);
            txt_idPermission.PasswordChar = false;
            txt_idPermission.PlaceholderColor = Color.DarkGray;
            txt_idPermission.PlaceholderText = "Nhập ID....";
            txt_idPermission.Size = new Size(279, 52);
            txt_idPermission.TabIndex = 18;
            txt_idPermission.Texts = "";
            txt_idPermission.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 63);
            label1.Name = "label1";
            label1.Size = new Size(93, 40);
            label1.TabIndex = 17;
            label1.Text = "Quyền ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_backPermission
            // 
            btn_backPermission.BackColor = Color.Transparent;
            btn_backPermission.BackgroundColor = Color.Transparent;
            btn_backPermission.BorderColor = Color.PaleVioletRed;
            btn_backPermission.BorderRadius = 20;
            btn_backPermission.BorderSize = 0;
            btn_backPermission.Cursor = Cursors.Hand;
            btn_backPermission.EnabledTextHover = false;
            btn_backPermission.FlatAppearance.BorderSize = 0;
            btn_backPermission.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_backPermission.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_backPermission.FlatStyle = FlatStyle.Flat;
            btn_backPermission.ForeColor = Color.White;
            btn_backPermission.Image = Properties.Resources.arrowreturn32pxBlack1;
            btn_backPermission.ImageHover = Properties.Resources.arrowreturn32pxWhite1;
            btn_backPermission.Location = new Point(6, 4);
            btn_backPermission.Margin = new Padding(3, 4, 3, 4);
            btn_backPermission.Name = "btn_backPermission";
            btn_backPermission.Size = new Size(72, 55);
            btn_backPermission.TabIndex = 16;
            btn_backPermission.TextColor = Color.White;
            btn_backPermission.TextHover = Color.White;
            btn_backPermission.UseVisualStyleBackColor = false;
            btn_backPermission.Click += btn_backPermission_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(grb_chucNang, 0, 0);
            tableLayoutPanel1.Controls.Add(grb_quyen, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1500, 740);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // grb_chucNang
            // 
            grb_chucNang.BackColor = SystemColors.Window;
            grb_chucNang.Controls.Add(tc_chucNang);
            grb_chucNang.Dock = DockStyle.Fill;
            grb_chucNang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grb_chucNang.Location = new Point(753, 3);
            grb_chucNang.Name = "grb_chucNang";
            grb_chucNang.Size = new Size(744, 734);
            grb_chucNang.TabIndex = 1;
            grb_chucNang.TabStop = false;
            grb_chucNang.Text = "Chức Năng";
            // 
            // tc_chucNang
            // 
            tc_chucNang.Controls.Add(tp_chucNangDanhSach);
            tc_chucNang.Controls.Add(tp_chucNangChiTiet);
            tc_chucNang.Dock = DockStyle.Fill;
            tc_chucNang.Location = new Point(3, 30);
            tc_chucNang.Name = "tc_chucNang";
            tc_chucNang.SelectedIndex = 0;
            tc_chucNang.Size = new Size(738, 701);
            tc_chucNang.TabIndex = 0;
            // 
            // tp_chucNangDanhSach
            // 
            tp_chucNangDanhSach.BackColor = SystemColors.Window;
            tp_chucNangDanhSach.Controls.Add(dtgrv_chucNang);
            tp_chucNangDanhSach.Controls.Add(customButton3);
            tp_chucNangDanhSach.Controls.Add(customButton4);
            tp_chucNangDanhSach.Controls.Add(customButton5);
            tp_chucNangDanhSach.Controls.Add(customButton1);
            tp_chucNangDanhSach.Controls.Add(customTextBox1);
            tp_chucNangDanhSach.Location = new Point(4, 37);
            tp_chucNangDanhSach.Name = "tp_chucNangDanhSach";
            tp_chucNangDanhSach.Padding = new Padding(3);
            tp_chucNangDanhSach.Size = new Size(730, 660);
            tp_chucNangDanhSach.TabIndex = 0;
            tp_chucNangDanhSach.Text = "Danh Sách";
            // 
            // dtgrv_chucNang
            // 
            dtgrv_chucNang.AllowUserToAddRows = false;
            dtgrv_chucNang.AllowUserToDeleteRows = false;
            dtgrv_chucNang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgrv_chucNang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrv_chucNang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgrv_chucNang.BorderStyle = BorderStyle.None;
            dtgrv_chucNang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.DarkCyan;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgrv_chucNang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgrv_chucNang.ColumnHeadersHeight = 30;
            dtgrv_chucNang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtgrv_chucNang.DefaultCellStyle = dataGridViewCellStyle5;
            dtgrv_chucNang.EnableHeadersVisualStyles = false;
            dtgrv_chucNang.GridColor = Color.DarkCyan;
            dtgrv_chucNang.ImeMode = ImeMode.NoControl;
            dtgrv_chucNang.Location = new Point(3, 180);
            dtgrv_chucNang.Margin = new Padding(3, 4, 3, 4);
            dtgrv_chucNang.Name = "dtgrv_chucNang";
            dtgrv_chucNang.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgrv_chucNang.RowHeadersVisible = false;
            dtgrv_chucNang.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrv_chucNang.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dtgrv_chucNang.RowTemplate.Height = 25;
            dtgrv_chucNang.RowTemplate.ReadOnly = true;
            dtgrv_chucNang.Size = new Size(724, 477);
            dtgrv_chucNang.TabIndex = 18;
            // 
            // customButton3
            // 
            customButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customButton3.BackColor = SystemColors.Control;
            customButton3.BackgroundColor = SystemColors.Control;
            customButton3.BorderColor = Color.Red;
            customButton3.BorderRadius = 15;
            customButton3.BorderSize = 2;
            customButton3.Cursor = Cursors.Hand;
            customButton3.EnabledTextHover = true;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            customButton3.FlatAppearance.MouseOverBackColor = Color.Red;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton3.ForeColor = Color.Red;
            customButton3.Image = Properties.Resources.deleteIconRed16px;
            customButton3.ImageAlign = ContentAlignment.MiddleRight;
            customButton3.ImageHover = Properties.Resources.deleteIconWhite16px;
            customButton3.Location = new Point(586, 3);
            customButton3.Margin = new Padding(3, 4, 3, 4);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(138, 51);
            customButton3.TabIndex = 17;
            customButton3.Text = "  Xóa";
            customButton3.TextColor = Color.Red;
            customButton3.TextHover = Color.White;
            customButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton4
            // 
            customButton4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customButton4.BackColor = SystemColors.Control;
            customButton4.BackgroundColor = SystemColors.Control;
            customButton4.BorderColor = Color.DarkCyan;
            customButton4.BorderRadius = 15;
            customButton4.BorderSize = 2;
            customButton4.Cursor = Cursors.Hand;
            customButton4.EnabledTextHover = true;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatAppearance.MouseDownBackColor = Color.Teal;
            customButton4.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton4.ForeColor = Color.DarkCyan;
            customButton4.Image = Properties.Resources.editIconTeal16px;
            customButton4.ImageAlign = ContentAlignment.MiddleRight;
            customButton4.ImageHover = Properties.Resources.editIconWhite16px;
            customButton4.Location = new Point(442, 3);
            customButton4.Margin = new Padding(3, 4, 3, 4);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(138, 51);
            customButton4.TabIndex = 16;
            customButton4.Text = "  Sửa";
            customButton4.TextColor = Color.DarkCyan;
            customButton4.TextHover = Color.White;
            customButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton5
            // 
            customButton5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customButton5.BackColor = SystemColors.Control;
            customButton5.BackgroundColor = SystemColors.Control;
            customButton5.BorderColor = Color.DarkCyan;
            customButton5.BorderRadius = 15;
            customButton5.BorderSize = 2;
            customButton5.Cursor = Cursors.Hand;
            customButton5.EnabledTextHover = true;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatAppearance.MouseDownBackColor = Color.Teal;
            customButton5.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton5.ForeColor = Color.DarkCyan;
            customButton5.Image = Properties.Resources.addIconTeal16px;
            customButton5.ImageAlign = ContentAlignment.MiddleRight;
            customButton5.ImageHover = Properties.Resources.addIconWhite16px;
            customButton5.Location = new Point(298, 3);
            customButton5.Margin = new Padding(3, 4, 3, 4);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(138, 51);
            customButton5.TabIndex = 15;
            customButton5.Text = "  Thêm";
            customButton5.TextColor = Color.DarkCyan;
            customButton5.TextHover = Color.White;
            customButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton5.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Transparent;
            customButton1.BackgroundColor = Color.Transparent;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 15;
            customButton1.BorderSize = 0;
            customButton1.Cursor = Cursors.Hand;
            customButton1.EnabledTextHover = false;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 64, 64, 64);
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Image = Properties.Resources.findIcon16px;
            customButton1.ImageHover = null;
            customButton1.Location = new Point(206, 9);
            customButton1.Margin = new Padding(3, 4, 3, 4);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(40, 37);
            customButton1.TabIndex = 9;
            customButton1.TextColor = Color.White;
            customButton1.TextHover = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.BorderColor = Color.Silver;
            customTextBox1.BorderFocusColor = Color.DarkCyan;
            customTextBox1.BorderRadius = 15;
            customTextBox1.BorderSize = 2;
            customTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(6, 4);
            customTextBox1.Margin = new Padding(3, 4, 3, 4);
            customTextBox1.Multiline = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 9, 46, 9);
            customTextBox1.PasswordChar = false;
            customTextBox1.PlaceholderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "Tìm Kiếm ...";
            customTextBox1.Size = new Size(249, 47);
            customTextBox1.TabIndex = 8;
            customTextBox1.Texts = "";
            customTextBox1.UnderlinedStyle = false;
            // 
            // tp_chucNangChiTiet
            // 
            tp_chucNangChiTiet.BackColor = SystemColors.Window;
            tp_chucNangChiTiet.Location = new Point(4, 37);
            tp_chucNangChiTiet.Name = "tp_chucNangChiTiet";
            tp_chucNangChiTiet.Padding = new Padding(3);
            tp_chucNangChiTiet.Size = new Size(730, 660);
            tp_chucNangChiTiet.TabIndex = 1;
            tp_chucNangChiTiet.Text = "Chi Tiết";
            // 
            // PhanQuyenView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 740);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PhanQuyenView";
            Text = "PhanQuyenView";
            grb_quyen.ResumeLayout(false);
            tc_quyen.ResumeLayout(false);
            tp_quyenDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgrv_quyen).EndInit();
            tp_quyenChiTiet.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            grb_chucNang.ResumeLayout(false);
            tc_chucNang.ResumeLayout(false);
            tp_chucNangDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgrv_chucNang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_quyen;
        private TabControl tc_quyen;
        private TabPage tp_quyenDanhSach;
        private TabPage tp_quyenChiTiet;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grb_chucNang;
        private TabControl tc_chucNang;
        private TabPage tp_chucNangDanhSach;
        private TabPage tp_chucNangChiTiet;
        private CustomControl.CustomTextBox searchTxt;
        private CustomControl.CustomButton customButton2;
        private CustomControl.CustomButton customButton1;
        private CustomControl.CustomTextBox customTextBox1;
        private CustomControl.CustomButton btn_addPermission;
        private CustomControl.CustomButton btn_editPermission;
        private CustomControl.CustomButton btn_deletePermission;
        private CustomControl.CustomButton customButton3;
        private CustomControl.CustomButton customButton4;
        private CustomControl.CustomButton customButton5;
        private DataGridView dtgrv_quyen;
        private DataGridView dtgrv_chucNang;
        private CustomControl.CustomButton btn_detailPermission;
        private CustomControl.CustomButton btn_backPermission;
        private Label label3;
        private Label label2;
        private CustomControl.CustomTextBox txt_idPermission;
        private Label label1;
        private GroupBox groupBox1;
        private CheckedListBox clb_chucNang;
        private CustomControl.CustomTextBox txt_contentPermission;
        private CustomControl.CustomTextBox txt_namePermission;
        private CustomControl.CustomButton btn_cancel;
        private CustomControl.CustomButton btn_acceptPermission;
    }
}