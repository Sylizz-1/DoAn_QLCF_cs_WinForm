namespace DoAn_QLCF_cs_WinForm.View
{
    partial class LogInView
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
            txt_username = new CustomControl.CustomTextBox();
            txt_password = new CustomControl.CustomTextBox();
            tabControl1 = new TabControl();
            tb_login = new TabPage();
            btn_newAccount = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btn_login = new CustomControl.CustomButton();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tb_registerEmployee = new TabPage();
            btn_register = new Button();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            txt_registerPassword = new CustomControl.CustomTextBox();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            txt_registerUsername = new CustomControl.CustomTextBox();
            btn_back = new CustomControl.CustomButton();
            tabControl1.SuspendLayout();
            tb_login.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tb_registerEmployee.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.BackColor = SystemColors.Window;
            txt_username.BorderColor = Color.Silver;
            txt_username.BorderFocusColor = Color.HotPink;
            txt_username.BorderRadius = 12;
            txt_username.BorderSize = 1;
            txt_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.ForeColor = Color.DimGray;
            txt_username.Location = new Point(56, 4);
            txt_username.Margin = new Padding(3, 4, 3, 4);
            txt_username.Multiline = false;
            txt_username.Name = "txt_username";
            txt_username.Padding = new Padding(10, 9, 8, 9);
            txt_username.PasswordChar = false;
            txt_username.PlaceholderColor = Color.DarkGray;
            txt_username.PlaceholderText = "Username";
            txt_username.Size = new Size(338, 47);
            txt_username.TabIndex = 3;
            txt_username.Texts = "";
            txt_username.UnderlinedStyle = false;
            // 
            // txt_password
            // 
            txt_password.BackColor = SystemColors.Window;
            txt_password.BorderColor = Color.Silver;
            txt_password.BorderFocusColor = Color.HotPink;
            txt_password.BorderRadius = 12;
            txt_password.BorderSize = 1;
            txt_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.ForeColor = Color.DimGray;
            txt_password.Location = new Point(56, 6);
            txt_password.Margin = new Padding(3, 4, 3, 4);
            txt_password.Multiline = false;
            txt_password.Name = "txt_password";
            txt_password.Padding = new Padding(10, 9, 8, 9);
            txt_password.PasswordChar = false;
            txt_password.PlaceholderColor = Color.DarkGray;
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(338, 47);
            txt_password.TabIndex = 4;
            txt_password.Texts = "";
            txt_password.UnderlinedStyle = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tb_login);
            tabControl1.Controls.Add(tb_registerEmployee);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(548, 553);
            tabControl1.TabIndex = 8;
            // 
            // tb_login
            // 
            tb_login.BackColor = SystemColors.Window;
            tb_login.Controls.Add(btn_newAccount);
            tb_login.Controls.Add(groupBox1);
            tb_login.Controls.Add(btn_login);
            tb_login.Controls.Add(panel2);
            tb_login.Controls.Add(pictureBox2);
            tb_login.Controls.Add(panel1);
            tb_login.Location = new Point(4, 29);
            tb_login.Name = "tb_login";
            tb_login.Padding = new Padding(3);
            tb_login.Size = new Size(540, 520);
            tb_login.TabIndex = 0;
            tb_login.Text = "Login";
            // 
            // btn_newAccount
            // 
            btn_newAccount.Cursor = Cursors.Hand;
            btn_newAccount.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_newAccount.ForeColor = SystemColors.Highlight;
            btn_newAccount.Location = new Point(70, 459);
            btn_newAccount.Name = "btn_newAccount";
            btn_newAccount.Size = new Size(400, 29);
            btn_newAccount.TabIndex = 18;
            btn_newAccount.Text = "Không có tài khoản? Tạo tài khoản mới!";
            btn_newAccount.UseVisualStyleBackColor = true;
            btn_newAccount.Click += btn_newAccount_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(70, 289);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 84);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn Vai Trò";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(257, 33);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(138, 32);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Khách Hàng";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 33);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(123, 32);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nhân Viên";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_login.BackColor = SystemColors.Control;
            btn_login.BackgroundColor = SystemColors.Control;
            btn_login.BorderColor = Color.Red;
            btn_login.BorderRadius = 15;
            btn_login.BorderSize = 2;
            btn_login.Cursor = Cursors.Hand;
            btn_login.EnabledTextHover = true;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(187, 10, 10);
            btn_login.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.Red;
            btn_login.ImageAlign = ContentAlignment.MiddleRight;
            btn_login.ImageHover = null;
            btn_login.Location = new Point(70, 396);
            btn_login.Margin = new Padding(3, 4, 3, 4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(400, 51);
            btn_login.TabIndex = 15;
            btn_login.Text = "Đăng Nhập";
            btn_login.TextColor = Color.Red;
            btn_login.TextHover = Color.White;
            btn_login.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_login.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(txt_password);
            panel2.Location = new Point(70, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 57);
            panel2.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_password_47;
            pictureBox3.Location = new Point(3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 47);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_user_100_header;
            pictureBox2.Location = new Point(220, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txt_username);
            panel1.Location = new Point(70, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 57);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_username_47;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 47);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // tb_registerEmployee
            // 
            tp_information.Controls.Add(pn_birthday);
            tp_information.Controls.Add(btn_continue);
            tp_information.Controls.Add(groupBox3);
            tp_information.Controls.Add(groupBox2);
            tp_information.Controls.Add(panel6);
            tp_information.Controls.Add(panel7);
            tp_information.Controls.Add(panel8);
            tp_information.Controls.Add(btn_back1);
            tp_information.Controls.Add(pictureBox8);
            tp_information.Location = new Point(4, 29);
            tp_information.Name = "tp_information";
            tp_information.Padding = new Padding(3);
            tp_information.Size = new Size(540, 520);
            tp_information.TabIndex = 2;
            tp_information.Text = "Information";
            tp_information.UseVisualStyleBackColor = true;
            // 
            // pn_birthday
            // 
            pn_birthday.Controls.Add(customDateTimePicker1);
            pn_birthday.Controls.Add(pictureBox12);
            pn_birthday.Location = new Point(70, 397);
            pn_birthday.Name = "pn_birthday";
            pn_birthday.Size = new Size(400, 47);
            pn_birthday.TabIndex = 47;
            // 
            // customDateTimePicker1
            // 
            customDateTimePicker1.BorderColor = Color.PaleVioletRed;
            customDateTimePicker1.BorderSize = 0;
            customDateTimePicker1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            customDateTimePicker1.Location = new Point(56, 4);
            customDateTimePicker1.MinimumSize = new Size(0, 35);
            customDateTimePicker1.Name = "customDateTimePicker1";
            customDateTimePicker1.Size = new Size(338, 36);
            customDateTimePicker1.SkinColor = Color.MediumSlateBlue;
            customDateTimePicker1.TabIndex = 9;
            customDateTimePicker1.TextColor = Color.White;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.icons8_birthday_39;
            pictureBox12.Location = new Point(7, 4);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(39, 39);
            pictureBox12.TabIndex = 8;
            pictureBox12.TabStop = false;
            // 
            // btn_continue
            // 
            btn_continue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_continue.BackColor = SystemColors.Control;
            btn_continue.BackgroundColor = SystemColors.Control;
            btn_continue.BorderColor = Color.DarkCyan;
            btn_continue.BorderRadius = 15;
            btn_continue.BorderSize = 2;
            btn_continue.Cursor = Cursors.Hand;
            btn_continue.EnabledTextHover = true;
            btn_continue.FlatAppearance.BorderSize = 0;
            btn_continue.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_continue.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_continue.FlatStyle = FlatStyle.Flat;
            btn_continue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_continue.ForeColor = Color.DarkCyan;
            btn_continue.ImageAlign = ContentAlignment.MiddleRight;
            btn_continue.ImageHover = null;
            btn_continue.Location = new Point(70, 456);
            btn_continue.Margin = new Padding(3, 4, 3, 4);
            btn_continue.Name = "btn_continue";
            btn_continue.Size = new Size(400, 51);
            btn_continue.TabIndex = 46;
            btn_continue.Text = "Tiếp Theo";
            btn_continue.TextColor = Color.DarkCyan;
            btn_continue.TextHover = Color.White;
            btn_continue.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_continue.UseVisualStyleBackColor = false;
            btn_continue.Click += btn_continue_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton5);
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(274, 88);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(198, 110);
            groupBox3.TabIndex = 43;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chọn Giới Tính";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 71);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(60, 32);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "Nữ";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 33);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(75, 32);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "Nam";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdb_customerRegister);
            groupBox2.Controls.Add(rdb_employeeRegister);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(70, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(198, 110);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn Vai Trò";
            // 
            // rdb_customerRegister
            // 
            rdb_customerRegister.AutoSize = true;
            rdb_customerRegister.Location = new Point(6, 71);
            rdb_customerRegister.Name = "rdb_customerRegister";
            rdb_customerRegister.Size = new Size(138, 32);
            rdb_customerRegister.TabIndex = 1;
            rdb_customerRegister.Text = "Khách Hàng";
            rdb_customerRegister.UseVisualStyleBackColor = true;
            // 
            // rdb_employeeRegister
            // 
            rdb_employeeRegister.AutoSize = true;
            rdb_employeeRegister.Checked = true;
            rdb_employeeRegister.Location = new Point(6, 33);
            rdb_employeeRegister.Name = "rdb_employeeRegister";
            rdb_employeeRegister.Size = new Size(123, 32);
            rdb_employeeRegister.TabIndex = 0;
            rdb_employeeRegister.TabStop = true;
            rdb_employeeRegister.Text = "Nhân Viên";
            rdb_employeeRegister.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox9);
            panel6.Controls.Add(customTextBox2);
            panel6.Location = new Point(70, 334);
            panel6.Name = "panel6";
            panel6.Size = new Size(400, 57);
            panel6.TabIndex = 41;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.icons8_email_47;
            pictureBox9.Location = new Point(3, 4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(47, 47);
            pictureBox9.TabIndex = 8;
            pictureBox9.TabStop = false;
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = SystemColors.Window;
            customTextBox2.BorderColor = Color.Silver;
            customTextBox2.BorderFocusColor = Color.HotPink;
            customTextBox2.BorderRadius = 12;
            customTextBox2.BorderSize = 1;
            customTextBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox2.ForeColor = Color.DimGray;
            customTextBox2.Location = new Point(56, 6);
            customTextBox2.Margin = new Padding(3, 4, 3, 4);
            customTextBox2.Multiline = false;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(10, 9, 8, 9);
            customTextBox2.PasswordChar = false;
            customTextBox2.PlaceholderColor = Color.DarkGray;
            customTextBox2.PlaceholderText = "Nhập Email";
            customTextBox2.Size = new Size(338, 47);
            customTextBox2.TabIndex = 4;
            customTextBox2.Texts = "";
            customTextBox2.UnderlinedStyle = false;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(149, 318);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(174, 29);
            btn_register.TabIndex = 35;
            btn_register.Text = "Dang Ky";
            btn_register.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(txt_registerPassword);
            panel3.Location = new Point(54, 221);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 57);
            panel3.TabIndex = 34;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_password_47;
            pictureBox4.Location = new Point(3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 47);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // txt_registerPassword
            // 
            txt_registerPassword.BackColor = SystemColors.Window;
            txt_registerPassword.BorderColor = Color.Silver;
            txt_registerPassword.BorderFocusColor = Color.HotPink;
            txt_registerPassword.BorderRadius = 12;
            txt_registerPassword.BorderSize = 1;
            txt_registerPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_registerPassword.ForeColor = Color.DimGray;
            txt_registerPassword.Location = new Point(56, 6);
            txt_registerPassword.Margin = new Padding(3, 4, 3, 4);
            txt_registerPassword.Multiline = false;
            txt_registerPassword.Name = "txt_registerPassword";
            txt_registerPassword.Padding = new Padding(10, 9, 8, 9);
            txt_registerPassword.PasswordChar = false;
            txt_registerPassword.PlaceholderColor = Color.DarkGray;
            txt_registerPassword.PlaceholderText = "Password";
            txt_registerPassword.Size = new Size(338, 47);
            txt_registerPassword.TabIndex = 4;
            txt_registerPassword.Texts = "";
            txt_registerPassword.UnderlinedStyle = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(txt_registerUsername);
            panel4.Location = new Point(54, 146);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 57);
            panel4.TabIndex = 33;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_username_47;
            pictureBox5.Location = new Point(3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 47);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // txt_registerUsername
            // 
            txt_registerUsername.BackColor = SystemColors.Window;
            txt_registerUsername.BorderColor = Color.Silver;
            txt_registerUsername.BorderFocusColor = Color.HotPink;
            txt_registerUsername.BorderRadius = 12;
            txt_registerUsername.BorderSize = 1;
            txt_registerUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_registerUsername.ForeColor = Color.DimGray;
            txt_registerUsername.Location = new Point(56, 4);
            txt_registerUsername.Margin = new Padding(3, 4, 3, 4);
            txt_registerUsername.Multiline = false;
            txt_registerUsername.Name = "txt_registerUsername";
            txt_registerUsername.Padding = new Padding(10, 9, 8, 9);
            txt_registerUsername.PasswordChar = false;
            txt_registerUsername.PlaceholderColor = Color.DarkGray;
            txt_registerUsername.PlaceholderText = "Username";
            txt_registerUsername.Size = new Size(338, 47);
            txt_registerUsername.TabIndex = 3;
            txt_registerUsername.Texts = "";
            txt_registerUsername.UnderlinedStyle = false;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.BackgroundColor = Color.Transparent;
            btn_back.BorderColor = Color.PaleVioletRed;
            btn_back.BorderRadius = 20;
            btn_back.BorderSize = 0;
            btn_back.Cursor = Cursors.Hand;
            btn_back.EnabledTextHover = false;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_back.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = Color.White;
            btn_back.Image = Properties.Resources.arrowreturn32pxBlack1;
            btn_back.ImageHover = Properties.Resources.arrowreturn32pxWhite1;
            btn_back.Location = new Point(8, 7);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(72, 55);
            btn_back.TabIndex = 32;
            btn_back.TextColor = Color.White;
            btn_back.TextHover = Color.White;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // LogInView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(548, 553);
            Controls.Add(tabControl1);
            Name = "LogInView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInView";
            tabControl1.ResumeLayout(false);
            tb_login.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tb_registerEmployee.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControl.CustomTextBox txt_username;
        private CustomControl.CustomTextBox txt_password;        
        private TabControl tabControl1;
        private TabPage tb_login;
        private TabPage tb_registerEmployee;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private CustomControl.CustomButton btn_login;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btn_newAccount;
        private CustomControl.CustomButton btn_back;
        private CustomControl.CustomTextBox customTextBox3;
        private Panel panel3;
        private PictureBox pictureBox4;
        private CustomControl.CustomTextBox txt_registerPassword;
        private Panel panel4;
        private PictureBox pictureBox5;
        private CustomControl.CustomTextBox txt_registerUsername;
        private Button btn_register;
    }
}