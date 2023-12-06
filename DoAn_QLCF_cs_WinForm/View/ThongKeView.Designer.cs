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
            groupBox1 = new GroupBox();
            tc_quyen = new TabControl();
            tp_quyenChiTiet = new TabPage();
            groupBox2 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tp_quyenDanhSach = new TabPage();
            groupBox1.SuspendLayout();
            tc_quyen.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tc_quyen);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 542);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống kê tiền nhập ";
            // 
            // tc_quyen
            // 
            tc_quyen.Controls.Add(tp_quyenDanhSach);
            tc_quyen.Controls.Add(tp_quyenChiTiet);
            tc_quyen.Dock = DockStyle.Fill;
            tc_quyen.Location = new Point(3, 25);
            tc_quyen.Margin = new Padding(3, 2, 3, 2);
            tc_quyen.Name = "tc_quyen";
            tc_quyen.SelectedIndex = 0;
            tc_quyen.Size = new Size(647, 514);
            tc_quyen.TabIndex = 1;
            // 
            // tp_quyenChiTiet
            // 
            tp_quyenChiTiet.BackColor = SystemColors.Window;
            tp_quyenChiTiet.Location = new Point(4, 30);
            tp_quyenChiTiet.Margin = new Padding(3, 2, 3, 2);
            tp_quyenChiTiet.Name = "tp_quyenChiTiet";
            tp_quyenChiTiet.Padding = new Padding(3, 2, 3, 2);
            tp_quyenChiTiet.Size = new Size(639, 480);
            tp_quyenChiTiet.TabIndex = 1;
            tp_quyenChiTiet.Text = "Chi Tiết";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tabControl1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(660, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(653, 542);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thống kê doanh thu";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 25);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(647, 514);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Window;
            tabPage1.Location = new Point(4, 30);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(639, 480);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Danh Sách";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Window;
            tabPage2.Location = new Point(4, 30);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(639, 480);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Chi Tiết";
            // 
            // tp_quyenDanhSach
            // 
            tp_quyenDanhSach.BackColor = SystemColors.Window;
            tp_quyenDanhSach.Location = new Point(4, 30);
            tp_quyenDanhSach.Margin = new Padding(3, 2, 3, 2);
            tp_quyenDanhSach.Name = "tp_quyenDanhSach";
            tp_quyenDanhSach.Padding = new Padding(3, 2, 3, 2);
            tp_quyenDanhSach.Size = new Size(639, 480);
            tp_quyenDanhSach.TabIndex = 0;
            tp_quyenDanhSach.Text = "Danh Sách";
            // 
            // ThongKeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 547);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThongKeView";
            Text = "ThongKeView";
            groupBox1.ResumeLayout(false);
            tc_quyen.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl tc_quyen;
        private TabPage tp_quyenDanhSach;
        private TabPage tp_quyenChiTiet;
        private GroupBox groupBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}