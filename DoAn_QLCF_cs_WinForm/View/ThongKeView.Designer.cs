namespace DoAn_QLCF_cs_WinForm.View
{
    partial class ThongKeView
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
            grbTienNhap = new GroupBox();
            panel1 = new Panel();
            lbTongTienNhap = new Label();
            lb1 = new Label();
            resetBtnTn = new CustomControl.CustomButton();
            gbSapXepTienNhap = new GroupBox();
            rbTienNhapInc = new RadioButton();
            gbLocTienNhap = new GroupBox();
            dtpTgKetThucTn = new DateTimePicker();
            dtpTgBatDauTn = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            rbTienNhapDec = new RadioButton();
            SapXepTienNhapBtn = new CustomControl.CustomButton();
            LocTienNhapBtn = new CustomControl.CustomButton();
            grbDoanhThu = new GroupBox();
            panel2 = new Panel();
            gbSapXepDoanhThu = new GroupBox();
            gpLocDoanhThu = new GroupBox();
            dtpTgKetThucDt = new DateTimePicker();
            dtpTgBatDauDt = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            rbDoanhThuInc = new RadioButton();
            rbDoanhThuDec = new RadioButton();
            SapXepDoanhThuBtn = new CustomControl.CustomButton();
            LocDoanhThuBtn = new CustomControl.CustomButton();
            label5 = new Label();
            lbTongTienThu = new Label();
            resetBtnDt = new CustomControl.CustomButton();
            grbTienNhap.SuspendLayout();
            panel1.SuspendLayout();
            gbSapXepTienNhap.SuspendLayout();
            gbLocTienNhap.SuspendLayout();
            grbDoanhThu.SuspendLayout();
            panel2.SuspendLayout();
            gbSapXepDoanhThu.SuspendLayout();
            gpLocDoanhThu.SuspendLayout();
            SuspendLayout();
            // 
            // grbTienNhap
            // 
            grbTienNhap.Controls.Add(panel1);
            grbTienNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grbTienNhap.Location = new Point(1, 1);
            grbTienNhap.Name = "grbTienNhap";
            grbTienNhap.Size = new Size(653, 542);
            grbTienNhap.TabIndex = 1;
            grbTienNhap.TabStop = false;
            grbTienNhap.Text = "Thống kê tiền nhập ";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbTongTienNhap);
            panel1.Controls.Add(lb1);
            panel1.Controls.Add(resetBtnTn);
            panel1.Controls.Add(gbSapXepTienNhap);
            panel1.Controls.Add(SapXepTienNhapBtn);
            panel1.Controls.Add(LocTienNhapBtn);
            panel1.Location = new Point(6, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 656);
            panel1.TabIndex = 0;
            // 
            // lbTongTienNhap
            // 
            lbTongTienNhap.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongTienNhap.ForeColor = Color.DarkCyan;
            lbTongTienNhap.Location = new Point(210, 195);
            lbTongTienNhap.Name = "lbTongTienNhap";
            lbTongTienNhap.Size = new Size(356, 51);
            lbTongTienNhap.TabIndex = 69;
            lbTongTienNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb1
            // 
            lb1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lb1.ForeColor = Color.DarkCyan;
            lb1.Location = new Point(44, 195);
            lb1.Name = "lb1";
            lb1.Size = new Size(139, 51);
            lb1.TabIndex = 68;
            lb1.Text = "Tổng tiền: ";
            lb1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resetBtnTn
            // 
            resetBtnTn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            resetBtnTn.BackColor = SystemColors.Control;
            resetBtnTn.BackgroundColor = SystemColors.Control;
            resetBtnTn.BorderColor = Color.Gray;
            resetBtnTn.BorderRadius = 15;
            resetBtnTn.BorderSize = 2;
            resetBtnTn.EnabledTextHover = true;
            resetBtnTn.FlatAppearance.BorderSize = 0;
            resetBtnTn.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            resetBtnTn.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            resetBtnTn.FlatStyle = FlatStyle.Flat;
            resetBtnTn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtnTn.ForeColor = Color.DarkGray;
            resetBtnTn.ImageAlign = ContentAlignment.MiddleRight;
            resetBtnTn.ImageHover = null;
            resetBtnTn.Location = new Point(521, 3);
            resetBtnTn.Name = "resetBtnTn";
            resetBtnTn.Size = new Size(120, 38);
            resetBtnTn.TabIndex = 42;
            resetBtnTn.Text = "Reset";
            resetBtnTn.TextColor = Color.DarkGray;
            resetBtnTn.TextHover = Color.White;
            resetBtnTn.TextImageRelation = TextImageRelation.ImageBeforeText;
            resetBtnTn.UseVisualStyleBackColor = false;
            // 
            // gbSapXepTienNhap
            // 
            gbSapXepTienNhap.Controls.Add(rbTienNhapInc);
            gbSapXepTienNhap.Controls.Add(gbLocTienNhap);
            gbSapXepTienNhap.Controls.Add(rbTienNhapDec);
            gbSapXepTienNhap.Location = new Point(5, 64);
            gbSapXepTienNhap.Name = "gbSapXepTienNhap";
            gbSapXepTienNhap.Size = new Size(464, 101);
            gbSapXepTienNhap.TabIndex = 40;
            gbSapXepTienNhap.TabStop = false;
            gbSapXepTienNhap.Text = "Sắp xếp";
            // 
            // rbTienNhapInc
            // 
            rbTienNhapInc.AutoSize = true;
            rbTienNhapInc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbTienNhapInc.Location = new Point(78, 50);
            rbTienNhapInc.Margin = new Padding(2);
            rbTienNhapInc.Name = "rbTienNhapInc";
            rbTienNhapInc.Size = new Size(90, 25);
            rbTienNhapInc.TabIndex = 0;
            rbTienNhapInc.TabStop = true;
            rbTienNhapInc.Tag = "GiaHoaDonInc";
            rbTienNhapInc.Text = "Tăng dần";
            rbTienNhapInc.UseVisualStyleBackColor = true;
            // 
            // gbLocTienNhap
            // 
            gbLocTienNhap.Controls.Add(dtpTgKetThucTn);
            gbLocTienNhap.Controls.Add(dtpTgBatDauTn);
            gbLocTienNhap.Controls.Add(label3);
            gbLocTienNhap.Controls.Add(label4);
            gbLocTienNhap.Location = new Point(6, 0);
            gbLocTienNhap.Name = "gbLocTienNhap";
            gbLocTienNhap.Size = new Size(464, 128);
            gbLocTienNhap.TabIndex = 41;
            gbLocTienNhap.TabStop = false;
            gbLocTienNhap.Text = "Lọc";
            // 
            // dtpTgKetThucTn
            // 
            dtpTgKetThucTn.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTgKetThucTn.Location = new Point(63, 70);
            dtpTgKetThucTn.Name = "dtpTgKetThucTn";
            dtpTgKetThucTn.Size = new Size(275, 31);
            dtpTgKetThucTn.TabIndex = 83;
            // 
            // dtpTgBatDauTn
            // 
            dtpTgBatDauTn.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTgBatDauTn.Location = new Point(63, 22);
            dtpTgBatDauTn.Name = "dtpTgBatDauTn";
            dtpTgBatDauTn.Size = new Size(275, 31);
            dtpTgBatDauTn.TabIndex = 82;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 28);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 81;
            label3.Text = "Từ:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 56);
            label4.Name = "label4";
            label4.Size = new Size(48, 51);
            label4.TabIndex = 80;
            label4.Text = "Đến:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbTienNhapDec
            // 
            rbTienNhapDec.AutoSize = true;
            rbTienNhapDec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbTienNhapDec.Location = new Point(271, 50);
            rbTienNhapDec.Margin = new Padding(2);
            rbTienNhapDec.Name = "rbTienNhapDec";
            rbTienNhapDec.Size = new Size(95, 25);
            rbTienNhapDec.TabIndex = 1;
            rbTienNhapDec.TabStop = true;
            rbTienNhapDec.Tag = "GiaHoaDonDec";
            rbTienNhapDec.Text = "Giảm dần";
            rbTienNhapDec.UseVisualStyleBackColor = true;
            // 
            // SapXepTienNhapBtn
            // 
            SapXepTienNhapBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SapXepTienNhapBtn.BackColor = SystemColors.Control;
            SapXepTienNhapBtn.BackgroundColor = SystemColors.Control;
            SapXepTienNhapBtn.BorderColor = Color.Goldenrod;
            SapXepTienNhapBtn.BorderRadius = 15;
            SapXepTienNhapBtn.BorderSize = 2;
            SapXepTienNhapBtn.Cursor = Cursors.Hand;
            SapXepTienNhapBtn.EnabledTextHover = true;
            SapXepTienNhapBtn.FlatAppearance.BorderSize = 0;
            SapXepTienNhapBtn.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            SapXepTienNhapBtn.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            SapXepTienNhapBtn.FlatStyle = FlatStyle.Flat;
            SapXepTienNhapBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SapXepTienNhapBtn.ForeColor = Color.Goldenrod;
            SapXepTienNhapBtn.ImageAlign = ContentAlignment.MiddleRight;
            SapXepTienNhapBtn.ImageHover = null;
            SapXepTienNhapBtn.Location = new Point(131, 3);
            SapXepTienNhapBtn.Name = "SapXepTienNhapBtn";
            SapXepTienNhapBtn.Size = new Size(120, 38);
            SapXepTienNhapBtn.TabIndex = 39;
            SapXepTienNhapBtn.Text = "Sắp xếp";
            SapXepTienNhapBtn.TextColor = Color.Goldenrod;
            SapXepTienNhapBtn.TextHover = Color.White;
            SapXepTienNhapBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SapXepTienNhapBtn.UseVisualStyleBackColor = false;
            // 
            // LocTienNhapBtn
            // 
            LocTienNhapBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LocTienNhapBtn.BackColor = SystemColors.Control;
            LocTienNhapBtn.BackgroundColor = SystemColors.Control;
            LocTienNhapBtn.BorderColor = Color.DeepSkyBlue;
            LocTienNhapBtn.BorderRadius = 15;
            LocTienNhapBtn.BorderSize = 2;
            LocTienNhapBtn.EnabledTextHover = true;
            LocTienNhapBtn.FlatAppearance.BorderSize = 0;
            LocTienNhapBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            LocTienNhapBtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            LocTienNhapBtn.FlatStyle = FlatStyle.Flat;
            LocTienNhapBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LocTienNhapBtn.ForeColor = Color.DeepSkyBlue;
            LocTienNhapBtn.ImageAlign = ContentAlignment.MiddleRight;
            LocTienNhapBtn.ImageHover = null;
            LocTienNhapBtn.Location = new Point(5, 3);
            LocTienNhapBtn.Name = "LocTienNhapBtn";
            LocTienNhapBtn.Size = new Size(120, 38);
            LocTienNhapBtn.TabIndex = 38;
            LocTienNhapBtn.Text = "Lọc";
            LocTienNhapBtn.TextColor = Color.DeepSkyBlue;
            LocTienNhapBtn.TextHover = Color.White;
            LocTienNhapBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            LocTienNhapBtn.UseVisualStyleBackColor = false;
            // 
            // grbDoanhThu
            // 
            grbDoanhThu.Controls.Add(panel2);
            grbDoanhThu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grbDoanhThu.Location = new Point(660, 1);
            grbDoanhThu.Name = "grbDoanhThu";
            grbDoanhThu.Size = new Size(653, 542);
            grbDoanhThu.TabIndex = 2;
            grbDoanhThu.TabStop = false;
            grbDoanhThu.Text = "Thống kê doanh thu";
            // 
            // panel2
            // 
            panel2.Controls.Add(resetBtnDt);
            panel2.Controls.Add(lbTongTienThu);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(gbSapXepDoanhThu);
            panel2.Controls.Add(SapXepDoanhThuBtn);
            panel2.Controls.Add(LocDoanhThuBtn);
            panel2.Location = new Point(0, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 656);
            panel2.TabIndex = 1;
            // 
            // gbSapXepDoanhThu
            // 
            gbSapXepDoanhThu.Controls.Add(gpLocDoanhThu);
            gbSapXepDoanhThu.Controls.Add(rbDoanhThuInc);
            gbSapXepDoanhThu.Controls.Add(rbDoanhThuDec);
            gbSapXepDoanhThu.Location = new Point(6, 64);
            gbSapXepDoanhThu.Name = "gbSapXepDoanhThu";
            gbSapXepDoanhThu.Size = new Size(464, 101);
            gbSapXepDoanhThu.TabIndex = 41;
            gbSapXepDoanhThu.TabStop = false;
            gbSapXepDoanhThu.Text = "Sắp xếp";
            // 
            // gpLocDoanhThu
            // 
            gpLocDoanhThu.Controls.Add(dtpTgKetThucDt);
            gpLocDoanhThu.Controls.Add(dtpTgBatDauDt);
            gpLocDoanhThu.Controls.Add(label1);
            gpLocDoanhThu.Controls.Add(label2);
            gpLocDoanhThu.Location = new Point(0, 0);
            gpLocDoanhThu.Name = "gpLocDoanhThu";
            gpLocDoanhThu.Size = new Size(464, 128);
            gpLocDoanhThu.TabIndex = 42;
            gpLocDoanhThu.TabStop = false;
            gpLocDoanhThu.Text = "Lọc";
            // 
            // dtpTgKetThucDt
            // 
            dtpTgKetThucDt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTgKetThucDt.Location = new Point(64, 64);
            dtpTgKetThucDt.Name = "dtpTgKetThucDt";
            dtpTgKetThucDt.Size = new Size(275, 31);
            dtpTgKetThucDt.TabIndex = 87;
            // 
            // dtpTgBatDauDt
            // 
            dtpTgBatDauDt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTgBatDauDt.Location = new Point(64, 22);
            dtpTgBatDauDt.Name = "dtpTgBatDauDt";
            dtpTgBatDauDt.Size = new Size(275, 31);
            dtpTgBatDauDt.TabIndex = 86;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 28);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 85;
            label1.Text = "Từ:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 56);
            label2.Name = "label2";
            label2.Size = new Size(48, 51);
            label2.TabIndex = 84;
            label2.Text = "Đến:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbDoanhThuInc
            // 
            rbDoanhThuInc.AutoSize = true;
            rbDoanhThuInc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbDoanhThuInc.Location = new Point(64, 50);
            rbDoanhThuInc.Margin = new Padding(2);
            rbDoanhThuInc.Name = "rbDoanhThuInc";
            rbDoanhThuInc.Size = new Size(90, 25);
            rbDoanhThuInc.TabIndex = 2;
            rbDoanhThuInc.TabStop = true;
            rbDoanhThuInc.Tag = "GiaHoaDonInc";
            rbDoanhThuInc.Text = "Tăng dần";
            rbDoanhThuInc.UseVisualStyleBackColor = true;
            // 
            // rbDoanhThuDec
            // 
            rbDoanhThuDec.AutoSize = true;
            rbDoanhThuDec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbDoanhThuDec.Location = new Point(279, 50);
            rbDoanhThuDec.Margin = new Padding(2);
            rbDoanhThuDec.Name = "rbDoanhThuDec";
            rbDoanhThuDec.Size = new Size(95, 25);
            rbDoanhThuDec.TabIndex = 3;
            rbDoanhThuDec.TabStop = true;
            rbDoanhThuDec.Tag = "GiaHoaDonDec";
            rbDoanhThuDec.Text = "Giảm dần";
            rbDoanhThuDec.UseVisualStyleBackColor = true;
            // 
            // SapXepDoanhThuBtn
            // 
            SapXepDoanhThuBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SapXepDoanhThuBtn.BackColor = SystemColors.Control;
            SapXepDoanhThuBtn.BackgroundColor = SystemColors.Control;
            SapXepDoanhThuBtn.BorderColor = Color.Goldenrod;
            SapXepDoanhThuBtn.BorderRadius = 15;
            SapXepDoanhThuBtn.BorderSize = 2;
            SapXepDoanhThuBtn.Cursor = Cursors.Hand;
            SapXepDoanhThuBtn.EnabledTextHover = true;
            SapXepDoanhThuBtn.FlatAppearance.BorderSize = 0;
            SapXepDoanhThuBtn.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            SapXepDoanhThuBtn.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            SapXepDoanhThuBtn.FlatStyle = FlatStyle.Flat;
            SapXepDoanhThuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SapXepDoanhThuBtn.ForeColor = Color.Goldenrod;
            SapXepDoanhThuBtn.ImageAlign = ContentAlignment.MiddleRight;
            SapXepDoanhThuBtn.ImageHover = null;
            SapXepDoanhThuBtn.Location = new Point(129, 3);
            SapXepDoanhThuBtn.Name = "SapXepDoanhThuBtn";
            SapXepDoanhThuBtn.Size = new Size(120, 38);
            SapXepDoanhThuBtn.TabIndex = 41;
            SapXepDoanhThuBtn.Text = "Sắp xếp";
            SapXepDoanhThuBtn.TextColor = Color.Goldenrod;
            SapXepDoanhThuBtn.TextHover = Color.White;
            SapXepDoanhThuBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SapXepDoanhThuBtn.UseVisualStyleBackColor = false;
            // 
            // LocDoanhThuBtn
            // 
            LocDoanhThuBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LocDoanhThuBtn.BackColor = SystemColors.Control;
            LocDoanhThuBtn.BackgroundColor = SystemColors.Control;
            LocDoanhThuBtn.BorderColor = Color.DeepSkyBlue;
            LocDoanhThuBtn.BorderRadius = 15;
            LocDoanhThuBtn.BorderSize = 2;
            LocDoanhThuBtn.EnabledTextHover = true;
            LocDoanhThuBtn.FlatAppearance.BorderSize = 0;
            LocDoanhThuBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            LocDoanhThuBtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            LocDoanhThuBtn.FlatStyle = FlatStyle.Flat;
            LocDoanhThuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LocDoanhThuBtn.ForeColor = Color.DeepSkyBlue;
            LocDoanhThuBtn.ImageAlign = ContentAlignment.MiddleRight;
            LocDoanhThuBtn.ImageHover = null;
            LocDoanhThuBtn.Location = new Point(3, 3);
            LocDoanhThuBtn.Name = "LocDoanhThuBtn";
            LocDoanhThuBtn.Size = new Size(120, 38);
            LocDoanhThuBtn.TabIndex = 39;
            LocDoanhThuBtn.Text = "Lọc";
            LocDoanhThuBtn.TextColor = Color.DeepSkyBlue;
            LocDoanhThuBtn.TextHover = Color.White;
            LocDoanhThuBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            LocDoanhThuBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(42, 195);
            label5.Name = "label5";
            label5.Size = new Size(139, 51);
            label5.TabIndex = 70;
            label5.Text = "Tổng tiền: ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTongTienThu
            // 
            lbTongTienThu.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongTienThu.ForeColor = Color.DarkCyan;
            lbTongTienThu.Location = new Point(187, 195);
            lbTongTienThu.Name = "lbTongTienThu";
            lbTongTienThu.Size = new Size(337, 51);
            lbTongTienThu.TabIndex = 70;
            lbTongTienThu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resetBtnDt
            // 
            resetBtnDt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            resetBtnDt.BackColor = SystemColors.Control;
            resetBtnDt.BackgroundColor = SystemColors.Control;
            resetBtnDt.BorderColor = Color.Gray;
            resetBtnDt.BorderRadius = 15;
            resetBtnDt.BorderSize = 2;
            resetBtnDt.EnabledTextHover = true;
            resetBtnDt.FlatAppearance.BorderSize = 0;
            resetBtnDt.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            resetBtnDt.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            resetBtnDt.FlatStyle = FlatStyle.Flat;
            resetBtnDt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtnDt.ForeColor = Color.DarkGray;
            resetBtnDt.ImageAlign = ContentAlignment.MiddleRight;
            resetBtnDt.ImageHover = null;
            resetBtnDt.Location = new Point(527, 3);
            resetBtnDt.Name = "resetBtnDt";
            resetBtnDt.Size = new Size(120, 38);
            resetBtnDt.TabIndex = 70;
            resetBtnDt.Text = "Reset";
            resetBtnDt.TextColor = Color.DarkGray;
            resetBtnDt.TextHover = Color.White;
            resetBtnDt.TextImageRelation = TextImageRelation.ImageBeforeText;
            resetBtnDt.UseVisualStyleBackColor = false;
            // 
            // ThongKeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 694);
            Controls.Add(grbDoanhThu);
            Controls.Add(grbTienNhap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThongKeView";
            Text = "ThongKeView";
            grbTienNhap.ResumeLayout(false);
            panel1.ResumeLayout(false);
            gbSapXepTienNhap.ResumeLayout(false);
            gbSapXepTienNhap.PerformLayout();
            gbLocTienNhap.ResumeLayout(false);
            grbDoanhThu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            gbSapXepDoanhThu.ResumeLayout(false);
            gbSapXepDoanhThu.PerformLayout();
            gpLocDoanhThu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbTienNhap;
        private GroupBox grbDoanhThu;
        private Panel panel1;
        private Panel panel2;
        private CustomControl.CustomButton LocTienNhapBtn;
        private CustomControl.CustomButton LocDoanhThuBtn;
        private CustomControl.CustomButton SapXepTienNhapBtn;
        private CustomControl.CustomButton SapXepDoanhThuBtn;
        private GroupBox gbSapXepTienNhap;
        private GroupBox gbSapXepDoanhThu;
        private GroupBox gbLocTienNhap;
        private GroupBox gpLocDoanhThu;
        private RadioButton rbTienNhapInc;
        private RadioButton rbTienNhapDec;
        private DateTimePicker dtpTgKetThucTn;
        private DateTimePicker dtpTgBatDauTn;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpTgKetThucDt;
        private DateTimePicker dtpTgBatDauDt;
        private Label label1;
        private Label label2;
        private RadioButton rbDoanhThuInc;
        private RadioButton rbDoanhThuDec;
        private CustomControl.CustomButton resetBtnTn;
        private Label lb1;
        private Label lbTongTienNhap;
        private CustomControl.CustomButton resetBtnDt;
        private Label lbTongTienThu;
        private Label label5;
    }
}