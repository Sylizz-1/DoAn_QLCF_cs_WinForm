﻿namespace DoAn_QLCF_cs_WinForm.View
{
    partial class FormGridViewKhachHang
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column8, Column3, Column4, Column5, Column10, Column6, Column7, Column9 });
            dataGridView1.Location = new Point(-2, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1046, 327);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "STT";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên";
            Column2.Name = "Column2";
            // 
            // Column8
            // 
            Column8.HeaderText = "Loại KH";
            Column8.Name = "Column8";
            // 
            // Column3
            // 
            Column3.HeaderText = "Số điện thoại";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Địa chỉ";
            Column5.Name = "Column5";
            // 
            // Column10
            // 
            Column10.HeaderText = "Ngày tạo KH";
            Column10.Name = "Column10";
            // 
            // Column6
            // 
            Column6.HeaderText = "Tài khoản";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Mật khẩu";
            Column7.Name = "Column7";
            // 
            // Column9
            // 
            Column9.HeaderText = "IsDelete";
            Column9.Name = "Column9";
            // 
            // button1
            // 
            button1.Location = new Point(399, 391);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 1;
            button1.Text = "Export";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(572, 391);
            button2.Name = "button2";
            button2.Size = new Size(75, 37);
            button2.TabIndex = 2;
            button2.Text = "Import";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(371, 9);
            label1.Name = "label1";
            label1.Size = new Size(305, 32);
            label1.TabIndex = 3;
            label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // FormGridViewKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 434);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "FormGridViewKhachHang";
            Text = "FormGridViewKhachHang";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column9;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}