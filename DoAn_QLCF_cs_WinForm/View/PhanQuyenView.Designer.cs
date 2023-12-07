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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            grb_quyen = new GroupBox();
            tc_quyen = new TabControl();
            tp_quyenDanhSach = new TabPage();
            btn_detailPermission = new CustomControl.CustomButton();
            dtgrv_quyen = new DataGridView();
            btn_deletePermission = new CustomControl.CustomButton();
            btn_editPermission = new CustomControl.CustomButton();
            btn_addPermission = new CustomControl.CustomButton();
            customButton2 = new CustomControl.CustomButton();
            txt_searchPermission = new CustomControl.CustomTextBox();
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
            tp_xemChiTiet = new TabPage();
            groupBox2 = new GroupBox();
            dtgv_permissionDetail = new DataGridView();
            txt_namePermissionDetail = new CustomControl.CustomTextBox();
            label10 = new Label();
            txt_contentPermissionDetail = new CustomControl.CustomTextBox();
            label9 = new Label();
            btn_back2 = new CustomControl.CustomButton();
            txt_idPermissionDetail = new CustomControl.CustomTextBox();
            label8 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            grb_nhanVien = new GroupBox();
            tc_nhanVien = new TabControl();
            tp_nhanVienDanhSach = new TabPage();
            dtgrv_nhanVien = new DataGridView();
            btn_deletePermissionEmployee = new CustomControl.CustomButton();
            btn_editPermissionEmployee = new CustomControl.CustomButton();
            customButton1 = new CustomControl.CustomButton();
            txt_searchPermissionEmployee = new CustomControl.CustomTextBox();
            tp_nhanVienChiTiet = new TabPage();
            btn_cancelPermissionEmployee = new CustomControl.CustomButton();
            btn_acceptPermissionEmployee = new CustomControl.CustomButton();
            cbb_namePermission = new ComboBox();
            cbb_idPermission = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txt_tenNhanVien = new CustomControl.CustomTextBox();
            label5 = new Label();
            txt_idNhanVien = new CustomControl.CustomTextBox();
            label4 = new Label();
            btn_backPermissionEmployee = new CustomControl.CustomButton();
            grb_quyen.SuspendLayout();
            tc_quyen.SuspendLayout();
            tp_quyenDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrv_quyen).BeginInit();
            tp_quyenChiTiet.SuspendLayout();
            groupBox1.SuspendLayout();
            tp_xemChiTiet.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_permissionDetail).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            grb_nhanVien.SuspendLayout();
            tc_nhanVien.SuspendLayout();
            tp_nhanVienDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrv_nhanVien).BeginInit();
            tp_nhanVienChiTiet.SuspendLayout();
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
            tc_quyen.Controls.Add(tp_xemChiTiet);
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
            tp_quyenDanhSach.Controls.Add(txt_searchPermission);
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
            // txt_searchPermission
            // 
            txt_searchPermission.BackColor = SystemColors.Window;
            txt_searchPermission.BorderColor = Color.Silver;
            txt_searchPermission.BorderFocusColor = Color.DarkCyan;
            txt_searchPermission.BorderRadius = 15;
            txt_searchPermission.BorderSize = 2;
            txt_searchPermission.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_searchPermission.ForeColor = Color.DimGray;
            txt_searchPermission.Location = new Point(6, 7);
            txt_searchPermission.Margin = new Padding(3, 4, 3, 4);
            txt_searchPermission.Multiline = false;
            txt_searchPermission.Name = "txt_searchPermission";
            txt_searchPermission.Padding = new Padding(10, 9, 46, 9);
            txt_searchPermission.PasswordChar = false;
            txt_searchPermission.PlaceholderColor = Color.DarkGray;
            txt_searchPermission.PlaceholderText = "Tìm Kiếm ...";
            txt_searchPermission.Size = new Size(249, 47);
            txt_searchPermission.TabIndex = 3;
            txt_searchPermission.Texts = "";
            txt_searchPermission.UnderlinedStyle = false;
            txt_searchPermission._TextChanged += txt_searchPermission__TextChanged;
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
            btn_cancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            btn_acceptPermission.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // tp_xemChiTiet
            // 
            tp_xemChiTiet.Controls.Add(groupBox2);
            tp_xemChiTiet.Controls.Add(txt_namePermissionDetail);
            tp_xemChiTiet.Controls.Add(label10);
            tp_xemChiTiet.Controls.Add(txt_contentPermissionDetail);
            tp_xemChiTiet.Controls.Add(label9);
            tp_xemChiTiet.Controls.Add(btn_back2);
            tp_xemChiTiet.Controls.Add(txt_idPermissionDetail);
            tp_xemChiTiet.Controls.Add(label8);
            tp_xemChiTiet.Location = new Point(4, 37);
            tp_xemChiTiet.Name = "tp_xemChiTiet";
            tp_xemChiTiet.Padding = new Padding(3);
            tp_xemChiTiet.Size = new Size(730, 660);
            tp_xemChiTiet.TabIndex = 2;
            tp_xemChiTiet.Text = "tp_xemChiTiet";
            tp_xemChiTiet.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dtgv_permissionDetail);
            groupBox2.Location = new Point(3, 280);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(724, 377);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // dtgv_permissionDetail
            // 
            dtgv_permissionDetail.AllowUserToAddRows = false;
            dtgv_permissionDetail.AllowUserToDeleteRows = false;
            dtgv_permissionDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_permissionDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgv_permissionDetail.BorderStyle = BorderStyle.None;
            dtgv_permissionDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.DarkCyan;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgv_permissionDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_permissionDetail.ColumnHeadersHeight = 30;
            dtgv_permissionDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtgv_permissionDetail.DefaultCellStyle = dataGridViewCellStyle5;
            dtgv_permissionDetail.Dock = DockStyle.Fill;
            dtgv_permissionDetail.EnableHeadersVisualStyles = false;
            dtgv_permissionDetail.GridColor = Color.DarkCyan;
            dtgv_permissionDetail.ImeMode = ImeMode.NoControl;
            dtgv_permissionDetail.Location = new Point(3, 30);
            dtgv_permissionDetail.Margin = new Padding(3, 4, 3, 4);
            dtgv_permissionDetail.Name = "dtgv_permissionDetail";
            dtgv_permissionDetail.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgv_permissionDetail.RowHeadersVisible = false;
            dtgv_permissionDetail.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_permissionDetail.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dtgv_permissionDetail.RowTemplate.Height = 25;
            dtgv_permissionDetail.RowTemplate.ReadOnly = true;
            dtgv_permissionDetail.Size = new Size(718, 344);
            dtgv_permissionDetail.TabIndex = 19;
            // 
            // txt_namePermissionDetail
            // 
            txt_namePermissionDetail.BackColor = SystemColors.Window;
            txt_namePermissionDetail.BorderColor = Color.Silver;
            txt_namePermissionDetail.BorderFocusColor = Color.DarkCyan;
            txt_namePermissionDetail.BorderRadius = 13;
            txt_namePermissionDetail.BorderSize = 2;
            txt_namePermissionDetail.Enabled = false;
            txt_namePermissionDetail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_namePermissionDetail.ForeColor = Color.DimGray;
            txt_namePermissionDetail.Location = new Point(371, 110);
            txt_namePermissionDetail.Margin = new Padding(3, 4, 3, 4);
            txt_namePermissionDetail.Multiline = false;
            txt_namePermissionDetail.Name = "txt_namePermissionDetail";
            txt_namePermissionDetail.Padding = new Padding(10, 12, 8, 9);
            txt_namePermissionDetail.PasswordChar = false;
            txt_namePermissionDetail.PlaceholderColor = Color.DarkGray;
            txt_namePermissionDetail.PlaceholderText = "Nhập ID....";
            txt_namePermissionDetail.Size = new Size(279, 52);
            txt_namePermissionDetail.TabIndex = 25;
            txt_namePermissionDetail.Texts = "";
            txt_namePermissionDetail.UnderlinedStyle = false;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(353, 72);
            label10.Name = "label10";
            label10.Size = new Size(130, 40);
            label10.TabIndex = 24;
            label10.Text = "Tên Quyền";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_contentPermissionDetail
            // 
            txt_contentPermissionDetail.BackColor = SystemColors.Window;
            txt_contentPermissionDetail.BorderColor = Color.Silver;
            txt_contentPermissionDetail.BorderFocusColor = Color.DarkCyan;
            txt_contentPermissionDetail.BorderRadius = 13;
            txt_contentPermissionDetail.BorderSize = 2;
            txt_contentPermissionDetail.Enabled = false;
            txt_contentPermissionDetail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_contentPermissionDetail.ForeColor = Color.DimGray;
            txt_contentPermissionDetail.Location = new Point(31, 210);
            txt_contentPermissionDetail.Margin = new Padding(3, 4, 3, 4);
            txt_contentPermissionDetail.Multiline = false;
            txt_contentPermissionDetail.Name = "txt_contentPermissionDetail";
            txt_contentPermissionDetail.Padding = new Padding(10, 12, 8, 9);
            txt_contentPermissionDetail.PasswordChar = false;
            txt_contentPermissionDetail.PlaceholderColor = Color.DarkGray;
            txt_contentPermissionDetail.PlaceholderText = "Nhập ID....";
            txt_contentPermissionDetail.Size = new Size(279, 52);
            txt_contentPermissionDetail.TabIndex = 23;
            txt_contentPermissionDetail.Texts = "";
            txt_contentPermissionDetail.UnderlinedStyle = false;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(13, 172);
            label9.Name = "label9";
            label9.Size = new Size(176, 40);
            label9.TabIndex = 22;
            label9.Text = "Nội Dung Quyền";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_back2
            // 
            btn_back2.BackColor = Color.Transparent;
            btn_back2.BackgroundColor = Color.Transparent;
            btn_back2.BorderColor = Color.PaleVioletRed;
            btn_back2.BorderRadius = 20;
            btn_back2.BorderSize = 0;
            btn_back2.Cursor = Cursors.Hand;
            btn_back2.EnabledTextHover = false;
            btn_back2.FlatAppearance.BorderSize = 0;
            btn_back2.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_back2.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_back2.FlatStyle = FlatStyle.Flat;
            btn_back2.ForeColor = Color.White;
            btn_back2.Image = Properties.Resources.arrowreturn32pxBlack1;
            btn_back2.ImageHover = Properties.Resources.arrowreturn32pxWhite1;
            btn_back2.Location = new Point(6, 7);
            btn_back2.Margin = new Padding(3, 4, 3, 4);
            btn_back2.Name = "btn_back2";
            btn_back2.Size = new Size(72, 55);
            btn_back2.TabIndex = 21;
            btn_back2.TextColor = Color.White;
            btn_back2.TextHover = Color.White;
            btn_back2.UseVisualStyleBackColor = false;
            btn_back2.Click += btn_back2_Click;
            // 
            // txt_idPermissionDetail
            // 
            txt_idPermissionDetail.BackColor = SystemColors.Window;
            txt_idPermissionDetail.BorderColor = Color.Silver;
            txt_idPermissionDetail.BorderFocusColor = Color.DarkCyan;
            txt_idPermissionDetail.BorderRadius = 13;
            txt_idPermissionDetail.BorderSize = 2;
            txt_idPermissionDetail.Enabled = false;
            txt_idPermissionDetail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_idPermissionDetail.ForeColor = Color.DimGray;
            txt_idPermissionDetail.Location = new Point(31, 110);
            txt_idPermissionDetail.Margin = new Padding(3, 4, 3, 4);
            txt_idPermissionDetail.Multiline = false;
            txt_idPermissionDetail.Name = "txt_idPermissionDetail";
            txt_idPermissionDetail.Padding = new Padding(10, 12, 8, 9);
            txt_idPermissionDetail.PasswordChar = false;
            txt_idPermissionDetail.PlaceholderColor = Color.DarkGray;
            txt_idPermissionDetail.PlaceholderText = "Nhập ID....";
            txt_idPermissionDetail.Size = new Size(279, 52);
            txt_idPermissionDetail.TabIndex = 20;
            txt_idPermissionDetail.Texts = "";
            txt_idPermissionDetail.UnderlinedStyle = false;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(13, 72);
            label8.Name = "label8";
            label8.Size = new Size(93, 40);
            label8.TabIndex = 19;
            label8.Text = "Quyền ID";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(grb_nhanVien, 0, 0);
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
            // grb_nhanVien
            // 
            grb_nhanVien.BackColor = SystemColors.Window;
            grb_nhanVien.Controls.Add(tc_nhanVien);
            grb_nhanVien.Dock = DockStyle.Fill;
            grb_nhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grb_nhanVien.Location = new Point(753, 3);
            grb_nhanVien.Name = "grb_nhanVien";
            grb_nhanVien.Size = new Size(744, 734);
            grb_nhanVien.TabIndex = 1;
            grb_nhanVien.TabStop = false;
            grb_nhanVien.Text = "Nhân Viên";
            // 
            // tc_nhanVien
            // 
            tc_nhanVien.Controls.Add(tp_nhanVienDanhSach);
            tc_nhanVien.Controls.Add(tp_nhanVienChiTiet);
            tc_nhanVien.Dock = DockStyle.Fill;
            tc_nhanVien.Location = new Point(3, 30);
            tc_nhanVien.Name = "tc_nhanVien";
            tc_nhanVien.SelectedIndex = 0;
            tc_nhanVien.Size = new Size(738, 701);
            tc_nhanVien.TabIndex = 0;
            // 
            // tp_nhanVienDanhSach
            // 
            tp_nhanVienDanhSach.BackColor = SystemColors.Window;
            tp_nhanVienDanhSach.Controls.Add(dtgrv_nhanVien);
            tp_nhanVienDanhSach.Controls.Add(btn_deletePermissionEmployee);
            tp_nhanVienDanhSach.Controls.Add(btn_editPermissionEmployee);
            tp_nhanVienDanhSach.Controls.Add(customButton1);
            tp_nhanVienDanhSach.Controls.Add(txt_searchPermissionEmployee);
            tp_nhanVienDanhSach.Location = new Point(4, 37);
            tp_nhanVienDanhSach.Name = "tp_nhanVienDanhSach";
            tp_nhanVienDanhSach.Padding = new Padding(3);
            tp_nhanVienDanhSach.Size = new Size(730, 660);
            tp_nhanVienDanhSach.TabIndex = 0;
            tp_nhanVienDanhSach.Text = "Danh Sách";
            // 
            // dtgrv_nhanVien
            // 
            dtgrv_nhanVien.AllowUserToAddRows = false;
            dtgrv_nhanVien.AllowUserToDeleteRows = false;
            dtgrv_nhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgrv_nhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrv_nhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgrv_nhanVien.BorderStyle = BorderStyle.None;
            dtgrv_nhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.DarkCyan;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgrv_nhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtgrv_nhanVien.ColumnHeadersHeight = 30;
            dtgrv_nhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dtgrv_nhanVien.DefaultCellStyle = dataGridViewCellStyle8;
            dtgrv_nhanVien.EnableHeadersVisualStyles = false;
            dtgrv_nhanVien.GridColor = Color.DarkCyan;
            dtgrv_nhanVien.ImeMode = ImeMode.NoControl;
            dtgrv_nhanVien.Location = new Point(3, 180);
            dtgrv_nhanVien.Margin = new Padding(3, 4, 3, 4);
            dtgrv_nhanVien.Name = "dtgrv_nhanVien";
            dtgrv_nhanVien.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgrv_nhanVien.RowHeadersVisible = false;
            dtgrv_nhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrv_nhanVien.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dtgrv_nhanVien.RowTemplate.Height = 25;
            dtgrv_nhanVien.RowTemplate.ReadOnly = true;
            dtgrv_nhanVien.Size = new Size(724, 477);
            dtgrv_nhanVien.TabIndex = 18;
            // 
            // btn_deletePermissionEmployee
            // 
            btn_deletePermissionEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_deletePermissionEmployee.BackColor = SystemColors.Control;
            btn_deletePermissionEmployee.BackgroundColor = SystemColors.Control;
            btn_deletePermissionEmployee.BorderColor = Color.Red;
            btn_deletePermissionEmployee.BorderRadius = 15;
            btn_deletePermissionEmployee.BorderSize = 2;
            btn_deletePermissionEmployee.Cursor = Cursors.Hand;
            btn_deletePermissionEmployee.EnabledTextHover = true;
            btn_deletePermissionEmployee.FlatAppearance.BorderSize = 0;
            btn_deletePermissionEmployee.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            btn_deletePermissionEmployee.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_deletePermissionEmployee.FlatStyle = FlatStyle.Flat;
            btn_deletePermissionEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_deletePermissionEmployee.ForeColor = Color.Red;
            btn_deletePermissionEmployee.Image = Properties.Resources.deleteIconRed16px;
            btn_deletePermissionEmployee.ImageAlign = ContentAlignment.MiddleRight;
            btn_deletePermissionEmployee.ImageHover = Properties.Resources.deleteIconWhite16px;
            btn_deletePermissionEmployee.Location = new Point(430, 3);
            btn_deletePermissionEmployee.Margin = new Padding(3, 4, 3, 4);
            btn_deletePermissionEmployee.Name = "btn_deletePermissionEmployee";
            btn_deletePermissionEmployee.Size = new Size(294, 51);
            btn_deletePermissionEmployee.TabIndex = 17;
            btn_deletePermissionEmployee.Text = "  Xóa Quyền Nhân Viên";
            btn_deletePermissionEmployee.TextColor = Color.Red;
            btn_deletePermissionEmployee.TextHover = Color.White;
            btn_deletePermissionEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_deletePermissionEmployee.UseVisualStyleBackColor = false;
            // 
            // btn_editPermissionEmployee
            // 
            btn_editPermissionEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editPermissionEmployee.BackColor = SystemColors.Control;
            btn_editPermissionEmployee.BackgroundColor = SystemColors.Control;
            btn_editPermissionEmployee.BorderColor = Color.DarkCyan;
            btn_editPermissionEmployee.BorderRadius = 15;
            btn_editPermissionEmployee.BorderSize = 2;
            btn_editPermissionEmployee.Cursor = Cursors.Hand;
            btn_editPermissionEmployee.EnabledTextHover = true;
            btn_editPermissionEmployee.FlatAppearance.BorderSize = 0;
            btn_editPermissionEmployee.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_editPermissionEmployee.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_editPermissionEmployee.FlatStyle = FlatStyle.Flat;
            btn_editPermissionEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editPermissionEmployee.ForeColor = Color.DarkCyan;
            btn_editPermissionEmployee.Image = Properties.Resources.editIconTeal16px;
            btn_editPermissionEmployee.ImageAlign = ContentAlignment.MiddleRight;
            btn_editPermissionEmployee.ImageHover = Properties.Resources.editIconWhite16px;
            btn_editPermissionEmployee.Location = new Point(430, 62);
            btn_editPermissionEmployee.Margin = new Padding(3, 4, 3, 4);
            btn_editPermissionEmployee.Name = "btn_editPermissionEmployee";
            btn_editPermissionEmployee.Size = new Size(294, 51);
            btn_editPermissionEmployee.TabIndex = 16;
            btn_editPermissionEmployee.Text = "  Sửa Quyền Nhân Viên";
            btn_editPermissionEmployee.TextColor = Color.DarkCyan;
            btn_editPermissionEmployee.TextHover = Color.White;
            btn_editPermissionEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editPermissionEmployee.UseVisualStyleBackColor = false;
            btn_editPermissionEmployee.Click += btn_editPermissionEmployee_Click;
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
            // txt_searchPermissionEmployee
            // 
            txt_searchPermissionEmployee.BackColor = SystemColors.Window;
            txt_searchPermissionEmployee.BorderColor = Color.Silver;
            txt_searchPermissionEmployee.BorderFocusColor = Color.DarkCyan;
            txt_searchPermissionEmployee.BorderRadius = 15;
            txt_searchPermissionEmployee.BorderSize = 2;
            txt_searchPermissionEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_searchPermissionEmployee.ForeColor = Color.DimGray;
            txt_searchPermissionEmployee.Location = new Point(6, 4);
            txt_searchPermissionEmployee.Margin = new Padding(3, 4, 3, 4);
            txt_searchPermissionEmployee.Multiline = false;
            txt_searchPermissionEmployee.Name = "txt_searchPermissionEmployee";
            txt_searchPermissionEmployee.Padding = new Padding(10, 9, 46, 9);
            txt_searchPermissionEmployee.PasswordChar = false;
            txt_searchPermissionEmployee.PlaceholderColor = Color.DarkGray;
            txt_searchPermissionEmployee.PlaceholderText = "Tìm Kiếm ...";
            txt_searchPermissionEmployee.Size = new Size(249, 47);
            txt_searchPermissionEmployee.TabIndex = 8;
            txt_searchPermissionEmployee.Texts = "";
            txt_searchPermissionEmployee.UnderlinedStyle = false;
            txt_searchPermissionEmployee._TextChanged += txt_searchPermissionEmployee__TextChanged;
            // 
            // tp_nhanVienChiTiet
            // 
            tp_nhanVienChiTiet.BackColor = SystemColors.Window;
            tp_nhanVienChiTiet.Controls.Add(btn_cancelPermissionEmployee);
            tp_nhanVienChiTiet.Controls.Add(btn_acceptPermissionEmployee);
            tp_nhanVienChiTiet.Controls.Add(cbb_namePermission);
            tp_nhanVienChiTiet.Controls.Add(cbb_idPermission);
            tp_nhanVienChiTiet.Controls.Add(label7);
            tp_nhanVienChiTiet.Controls.Add(label6);
            tp_nhanVienChiTiet.Controls.Add(txt_tenNhanVien);
            tp_nhanVienChiTiet.Controls.Add(label5);
            tp_nhanVienChiTiet.Controls.Add(txt_idNhanVien);
            tp_nhanVienChiTiet.Controls.Add(label4);
            tp_nhanVienChiTiet.Controls.Add(btn_backPermissionEmployee);
            tp_nhanVienChiTiet.Location = new Point(4, 37);
            tp_nhanVienChiTiet.Name = "tp_nhanVienChiTiet";
            tp_nhanVienChiTiet.Padding = new Padding(3);
            tp_nhanVienChiTiet.Size = new Size(730, 660);
            tp_nhanVienChiTiet.TabIndex = 1;
            tp_nhanVienChiTiet.Text = "Chi Tiết";
            // 
            // btn_cancelPermissionEmployee
            // 
            btn_cancelPermissionEmployee.Anchor = AnchorStyles.None;
            btn_cancelPermissionEmployee.BackColor = SystemColors.Control;
            btn_cancelPermissionEmployee.BackgroundColor = SystemColors.Control;
            btn_cancelPermissionEmployee.BorderColor = Color.Red;
            btn_cancelPermissionEmployee.BorderRadius = 15;
            btn_cancelPermissionEmployee.BorderSize = 2;
            btn_cancelPermissionEmployee.Cursor = Cursors.Hand;
            btn_cancelPermissionEmployee.EnabledTextHover = true;
            btn_cancelPermissionEmployee.FlatAppearance.BorderSize = 0;
            btn_cancelPermissionEmployee.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            btn_cancelPermissionEmployee.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_cancelPermissionEmployee.FlatStyle = FlatStyle.Flat;
            btn_cancelPermissionEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelPermissionEmployee.ForeColor = Color.Red;
            btn_cancelPermissionEmployee.Image = Properties.Resources.CANCELiconRed;
            btn_cancelPermissionEmployee.ImageAlign = ContentAlignment.MiddleRight;
            btn_cancelPermissionEmployee.ImageHover = Properties.Resources.CANCELiconWhite;
            btn_cancelPermissionEmployee.Location = new Point(567, 429);
            btn_cancelPermissionEmployee.Margin = new Padding(3, 4, 3, 4);
            btn_cancelPermissionEmployee.Name = "btn_cancelPermissionEmployee";
            btn_cancelPermissionEmployee.Size = new Size(157, 71);
            btn_cancelPermissionEmployee.TabIndex = 53;
            btn_cancelPermissionEmployee.Text = "  Hủy";
            btn_cancelPermissionEmployee.TextColor = Color.Red;
            btn_cancelPermissionEmployee.TextHover = Color.White;
            btn_cancelPermissionEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cancelPermissionEmployee.UseVisualStyleBackColor = false;
            btn_cancelPermissionEmployee.Click += btn_cancelPermissionEmployee_Click;
            // 
            // btn_acceptPermissionEmployee
            // 
            btn_acceptPermissionEmployee.Anchor = AnchorStyles.None;
            btn_acceptPermissionEmployee.BackColor = SystemColors.Control;
            btn_acceptPermissionEmployee.BackgroundColor = SystemColors.Control;
            btn_acceptPermissionEmployee.BorderColor = Color.DarkCyan;
            btn_acceptPermissionEmployee.BorderRadius = 15;
            btn_acceptPermissionEmployee.BorderSize = 2;
            btn_acceptPermissionEmployee.Cursor = Cursors.Hand;
            btn_acceptPermissionEmployee.EnabledTextHover = true;
            btn_acceptPermissionEmployee.FlatAppearance.BorderSize = 0;
            btn_acceptPermissionEmployee.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_acceptPermissionEmployee.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_acceptPermissionEmployee.FlatStyle = FlatStyle.Flat;
            btn_acceptPermissionEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_acceptPermissionEmployee.ForeColor = Color.DarkCyan;
            btn_acceptPermissionEmployee.Image = Properties.Resources.ConfirmIcondarkcyan1;
            btn_acceptPermissionEmployee.ImageAlign = ContentAlignment.MiddleRight;
            btn_acceptPermissionEmployee.ImageHover = Properties.Resources.ConfirmIconWhite1;
            btn_acceptPermissionEmployee.Location = new Point(404, 429);
            btn_acceptPermissionEmployee.Margin = new Padding(3, 4, 3, 4);
            btn_acceptPermissionEmployee.Name = "btn_acceptPermissionEmployee";
            btn_acceptPermissionEmployee.Size = new Size(157, 71);
            btn_acceptPermissionEmployee.TabIndex = 52;
            btn_acceptPermissionEmployee.Text = "  Xác Nhận";
            btn_acceptPermissionEmployee.TextColor = Color.DarkCyan;
            btn_acceptPermissionEmployee.TextHover = Color.White;
            btn_acceptPermissionEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_acceptPermissionEmployee.UseVisualStyleBackColor = false;
            btn_acceptPermissionEmployee.Click += btn_confirmPermissionEmployee_Click;
            // 
            // cbb_namePermission
            // 
            cbb_namePermission.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_namePermission.FormattingEnabled = true;
            cbb_namePermission.Location = new Point(363, 214);
            cbb_namePermission.Name = "cbb_namePermission";
            cbb_namePermission.Size = new Size(274, 44);
            cbb_namePermission.TabIndex = 51;
            // 
            // cbb_idPermission
            // 
            cbb_idPermission.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_idPermission.FormattingEnabled = true;
            cbb_idPermission.Location = new Point(24, 214);
            cbb_idPermission.Name = "cbb_idPermission";
            cbb_idPermission.Size = new Size(274, 44);
            cbb_idPermission.TabIndex = 50;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(345, 171);
            label7.Name = "label7";
            label7.Size = new Size(144, 40);
            label7.TabIndex = 24;
            label7.Text = "Tên Quyền";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 171);
            label6.Name = "label6";
            label6.Size = new Size(144, 40);
            label6.TabIndex = 23;
            label6.Text = "ID Quyền";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_tenNhanVien
            // 
            txt_tenNhanVien.BackColor = SystemColors.Window;
            txt_tenNhanVien.BorderColor = Color.Silver;
            txt_tenNhanVien.BorderFocusColor = Color.DarkCyan;
            txt_tenNhanVien.BorderRadius = 13;
            txt_tenNhanVien.BorderSize = 2;
            txt_tenNhanVien.Enabled = false;
            txt_tenNhanVien.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tenNhanVien.ForeColor = Color.DimGray;
            txt_tenNhanVien.Location = new Point(358, 101);
            txt_tenNhanVien.Margin = new Padding(3, 4, 3, 4);
            txt_tenNhanVien.Multiline = false;
            txt_tenNhanVien.Name = "txt_tenNhanVien";
            txt_tenNhanVien.Padding = new Padding(10, 12, 8, 9);
            txt_tenNhanVien.PasswordChar = false;
            txt_tenNhanVien.PlaceholderColor = Color.DarkGray;
            txt_tenNhanVien.PlaceholderText = "Nhập ID....";
            txt_tenNhanVien.Size = new Size(279, 52);
            txt_tenNhanVien.TabIndex = 22;
            txt_tenNhanVien.Texts = "";
            txt_tenNhanVien.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(345, 63);
            label5.Name = "label5";
            label5.Size = new Size(144, 40);
            label5.TabIndex = 21;
            label5.Text = "Tên Nhân Viên";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_idNhanVien
            // 
            txt_idNhanVien.BackColor = SystemColors.Window;
            txt_idNhanVien.BorderColor = Color.Silver;
            txt_idNhanVien.BorderFocusColor = Color.DarkCyan;
            txt_idNhanVien.BorderRadius = 13;
            txt_idNhanVien.BorderSize = 2;
            txt_idNhanVien.Enabled = false;
            txt_idNhanVien.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_idNhanVien.ForeColor = Color.DimGray;
            txt_idNhanVien.Location = new Point(24, 101);
            txt_idNhanVien.Margin = new Padding(3, 4, 3, 4);
            txt_idNhanVien.Multiline = false;
            txt_idNhanVien.Name = "txt_idNhanVien";
            txt_idNhanVien.Padding = new Padding(10, 12, 8, 9);
            txt_idNhanVien.PasswordChar = false;
            txt_idNhanVien.PlaceholderColor = Color.DarkGray;
            txt_idNhanVien.PlaceholderText = "Nhập ID....";
            txt_idNhanVien.Size = new Size(279, 52);
            txt_idNhanVien.TabIndex = 20;
            txt_idNhanVien.Texts = "";
            txt_idNhanVien.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 63);
            label4.Name = "label4";
            label4.Size = new Size(144, 40);
            label4.TabIndex = 19;
            label4.Text = "ID Nhân Viên";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_backPermissionEmployee
            // 
            btn_backPermissionEmployee.BackColor = Color.Transparent;
            btn_backPermissionEmployee.BackgroundColor = Color.Transparent;
            btn_backPermissionEmployee.BorderColor = Color.PaleVioletRed;
            btn_backPermissionEmployee.BorderRadius = 20;
            btn_backPermissionEmployee.BorderSize = 0;
            btn_backPermissionEmployee.Cursor = Cursors.Hand;
            btn_backPermissionEmployee.EnabledTextHover = false;
            btn_backPermissionEmployee.FlatAppearance.BorderSize = 0;
            btn_backPermissionEmployee.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_backPermissionEmployee.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_backPermissionEmployee.FlatStyle = FlatStyle.Flat;
            btn_backPermissionEmployee.ForeColor = Color.White;
            btn_backPermissionEmployee.Image = Properties.Resources.arrowreturn32pxBlack1;
            btn_backPermissionEmployee.ImageHover = Properties.Resources.arrowreturn32pxWhite1;
            btn_backPermissionEmployee.Location = new Point(3, 7);
            btn_backPermissionEmployee.Margin = new Padding(3, 4, 3, 4);
            btn_backPermissionEmployee.Name = "btn_backPermissionEmployee";
            btn_backPermissionEmployee.Size = new Size(72, 55);
            btn_backPermissionEmployee.TabIndex = 17;
            btn_backPermissionEmployee.TextColor = Color.White;
            btn_backPermissionEmployee.TextHover = Color.White;
            btn_backPermissionEmployee.UseVisualStyleBackColor = false;
            btn_backPermissionEmployee.Click += btn_backPermissionEmployee_Click;
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
            tp_xemChiTiet.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_permissionDetail).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            grb_nhanVien.ResumeLayout(false);
            tc_nhanVien.ResumeLayout(false);
            tp_nhanVienDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgrv_nhanVien).EndInit();
            tp_nhanVienChiTiet.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_quyen;
        private TabControl tc_quyen;
        private TabPage tp_quyenDanhSach;
        private TabPage tp_quyenChiTiet;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grb_nhanVien;
        private TabControl tc_nhanVien;
        private TabPage tp_nhanVienDanhSach;
        private TabPage tp_nhanVienChiTiet;
        private CustomControl.CustomTextBox txt_searchPermission;
        private CustomControl.CustomButton customButton2;
        private CustomControl.CustomButton customButton1;
        private CustomControl.CustomTextBox txt_searchPermissionEmployee;
        private CustomControl.CustomButton btn_addPermission;
        private CustomControl.CustomButton btn_editPermission;
        private CustomControl.CustomButton btn_deletePermission;
        private CustomControl.CustomButton btn_deletePermissionEmployee;
        private CustomControl.CustomButton btn_editPermissionEmployee;
        private DataGridView dtgrv_quyen;
        private DataGridView dtgrv_nhanVien;
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
        private CustomControl.CustomTextBox txt_tenNhanVien;
        private Label label5;
        private CustomControl.CustomTextBox txt_idNhanVien;
        private Label label4;
        private CustomControl.CustomButton btn_backPermissionEmployee;
        private Label label7;
        private Label label6;
        private CustomControl.CustomButton btn_cancelPermissionEmployee;
        private CustomControl.CustomButton btn_acceptPermissionEmployee;
        private ComboBox cbb_namePermission;
        private ComboBox cbb_idPermission;
        private TabPage tp_xemChiTiet;
        private CustomControl.CustomTextBox txt_namePermissionDetail;
        private Label label10;
        private CustomControl.CustomTextBox txt_contentPermissionDetail;
        private Label label9;
        private CustomControl.CustomButton btn_back2;
        private CustomControl.CustomTextBox txt_idPermissionDetail;
        private Label label8;
        private GroupBox groupBox2;
        private DataGridView dtgv_permissionDetail;
    }
}