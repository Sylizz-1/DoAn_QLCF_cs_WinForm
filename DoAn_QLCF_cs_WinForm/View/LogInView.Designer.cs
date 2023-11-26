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
            tp_login = new TabPage();
            btn_newAccount = new Button();
            groupBox1 = new GroupBox();
            rdb_customerLogin = new RadioButton();
            rdb_employeeLogin = new RadioButton();
            btn_login = new CustomControl.CustomButton();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tp_information = new TabPage();
            pn_birthday = new Panel();
            dtp_birthdayRegister = new CustomControl.CustomDateTimePicker();
            pictureBox12 = new PictureBox();
            btn_continue = new CustomControl.CustomButton();
            groupBox3 = new GroupBox();
            rdb_femaleRegister = new RadioButton();
            rdb_maleRegister = new RadioButton();
            groupBox2 = new GroupBox();
            rdb_customerRegister = new RadioButton();
            rdb_employeeRegister = new RadioButton();
            panel6 = new Panel();
            pictureBox9 = new PictureBox();
            txt_emailRegister = new CustomControl.CustomTextBox();
            panel7 = new Panel();
            pictureBox10 = new PictureBox();
            txt_phoneNumberRegister = new CustomControl.CustomTextBox();
            panel8 = new Panel();
            pictureBox11 = new PictureBox();
            txt_nameRegister = new CustomControl.CustomTextBox();
            btn_back1 = new CustomControl.CustomButton();
            pictureBox8 = new PictureBox();
            tp_register = new TabPage();
            btn_register = new CustomControl.CustomButton();
            panel5 = new Panel();
            pictureBox7 = new PictureBox();
            txt_registerPasswordConfirm = new CustomControl.CustomTextBox();
            pictureBox6 = new PictureBox();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            txt_registerPassword = new CustomControl.CustomTextBox();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            txt_registerUsername = new CustomControl.CustomTextBox();
            btn_back2 = new CustomControl.CustomButton();
            tabControl1.SuspendLayout();
            tp_login.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tp_information.SuspendLayout();
            pn_birthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            tp_register.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
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
            tabControl1.Controls.Add(tp_login);
            tabControl1.Controls.Add(tp_information);
            tabControl1.Controls.Add(tp_register);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(548, 553);
            tabControl1.TabIndex = 8;
            // 
            // tp_login
            // 
            tp_login.BackColor = SystemColors.Window;
            tp_login.Controls.Add(btn_newAccount);
            tp_login.Controls.Add(groupBox1);
            tp_login.Controls.Add(btn_login);
            tp_login.Controls.Add(panel2);
            tp_login.Controls.Add(pictureBox2);
            tp_login.Controls.Add(panel1);
            tp_login.Location = new Point(4, 29);
            tp_login.Name = "tp_login";
            tp_login.Padding = new Padding(3);
            tp_login.Size = new Size(540, 520);
            tp_login.TabIndex = 0;
            tp_login.Text = "Login";
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
            groupBox1.Controls.Add(rdb_customerLogin);
            groupBox1.Controls.Add(rdb_employeeLogin);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(70, 289);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 84);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn Vai Trò";
            // 
            // rdb_customerLogin
            // 
            rdb_customerLogin.AutoSize = true;
            rdb_customerLogin.Location = new Point(257, 33);
            rdb_customerLogin.Name = "rdb_customerLogin";
            rdb_customerLogin.Size = new Size(138, 32);
            rdb_customerLogin.TabIndex = 1;
            rdb_customerLogin.TabStop = true;
            rdb_customerLogin.Text = "Khách Hàng";
            rdb_customerLogin.UseVisualStyleBackColor = true;
            // 
            // rdb_employeeLogin
            // 
            rdb_employeeLogin.AutoSize = true;
            rdb_employeeLogin.Location = new Point(6, 33);
            rdb_employeeLogin.Name = "rdb_employeeLogin";
            rdb_employeeLogin.Size = new Size(123, 32);
            rdb_employeeLogin.TabIndex = 0;
            rdb_employeeLogin.TabStop = true;
            rdb_employeeLogin.Text = "Nhân Viên";
            rdb_employeeLogin.UseVisualStyleBackColor = true;
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
            // tp_information
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
            pn_birthday.Controls.Add(dtp_birthdayRegister);
            pn_birthday.Controls.Add(pictureBox12);
            pn_birthday.Location = new Point(70, 397);
            pn_birthday.Name = "pn_birthday";
            pn_birthday.Size = new Size(400, 47);
            pn_birthday.TabIndex = 47;
            // 
            // dtp_birthdayRegister
            // 
            dtp_birthdayRegister.BorderColor = Color.PaleVioletRed;
            dtp_birthdayRegister.BorderSize = 0;
            dtp_birthdayRegister.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_birthdayRegister.Location = new Point(56, 4);
            dtp_birthdayRegister.MinimumSize = new Size(0, 35);
            dtp_birthdayRegister.Name = "dtp_birthdayRegister";
            dtp_birthdayRegister.Size = new Size(338, 36);
            dtp_birthdayRegister.SkinColor = Color.MediumSlateBlue;
            dtp_birthdayRegister.TabIndex = 9;
            dtp_birthdayRegister.TextColor = Color.White;
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
            groupBox3.Controls.Add(rdb_femaleRegister);
            groupBox3.Controls.Add(rdb_maleRegister);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(274, 88);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(198, 110);
            groupBox3.TabIndex = 43;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chọn Giới Tính";
            // 
            // rdb_femaleRegister
            // 
            rdb_femaleRegister.AutoSize = true;
            rdb_femaleRegister.Location = new Point(6, 71);
            rdb_femaleRegister.Name = "rdb_femaleRegister";
            rdb_femaleRegister.Size = new Size(60, 32);
            rdb_femaleRegister.TabIndex = 1;
            rdb_femaleRegister.TabStop = true;
            rdb_femaleRegister.Text = "Nữ";
            rdb_femaleRegister.UseVisualStyleBackColor = true;
            // 
            // rdb_maleRegister
            // 
            rdb_maleRegister.AutoSize = true;
            rdb_maleRegister.Location = new Point(6, 33);
            rdb_maleRegister.Name = "rdb_maleRegister";
            rdb_maleRegister.Size = new Size(75, 32);
            rdb_maleRegister.TabIndex = 0;
            rdb_maleRegister.TabStop = true;
            rdb_maleRegister.Text = "Nam";
            rdb_maleRegister.UseVisualStyleBackColor = true;
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
            panel6.Controls.Add(txt_emailRegister);
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
            // txt_emailRegister
            // 
            txt_emailRegister.BackColor = SystemColors.Window;
            txt_emailRegister.BorderColor = Color.Silver;
            txt_emailRegister.BorderFocusColor = Color.HotPink;
            txt_emailRegister.BorderRadius = 12;
            txt_emailRegister.BorderSize = 1;
            txt_emailRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_emailRegister.ForeColor = Color.DimGray;
            txt_emailRegister.Location = new Point(56, 6);
            txt_emailRegister.Margin = new Padding(3, 4, 3, 4);
            txt_emailRegister.Multiline = false;
            txt_emailRegister.Name = "txt_emailRegister";
            txt_emailRegister.Padding = new Padding(10, 9, 8, 9);
            txt_emailRegister.PasswordChar = false;
            txt_emailRegister.PlaceholderColor = Color.DarkGray;
            txt_emailRegister.PlaceholderText = "Nhập Email";
            txt_emailRegister.Size = new Size(338, 47);
            txt_emailRegister.TabIndex = 4;
            txt_emailRegister.Texts = "";
            txt_emailRegister.UnderlinedStyle = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox10);
            panel7.Controls.Add(txt_phoneNumberRegister);
            panel7.Location = new Point(70, 269);
            panel7.Name = "panel7";
            panel7.Size = new Size(400, 57);
            panel7.TabIndex = 40;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.icons8_phone_47_2;
            pictureBox10.Location = new Point(3, 4);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(47, 47);
            pictureBox10.TabIndex = 8;
            pictureBox10.TabStop = false;
            // 
            // txt_phoneNumberRegister
            // 
            txt_phoneNumberRegister.BackColor = SystemColors.Window;
            txt_phoneNumberRegister.BorderColor = Color.Silver;
            txt_phoneNumberRegister.BorderFocusColor = Color.HotPink;
            txt_phoneNumberRegister.BorderRadius = 12;
            txt_phoneNumberRegister.BorderSize = 1;
            txt_phoneNumberRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phoneNumberRegister.ForeColor = Color.DimGray;
            txt_phoneNumberRegister.Location = new Point(56, 6);
            txt_phoneNumberRegister.Margin = new Padding(3, 4, 3, 4);
            txt_phoneNumberRegister.Multiline = false;
            txt_phoneNumberRegister.Name = "txt_phoneNumberRegister";
            txt_phoneNumberRegister.Padding = new Padding(10, 9, 8, 9);
            txt_phoneNumberRegister.PasswordChar = false;
            txt_phoneNumberRegister.PlaceholderColor = Color.DarkGray;
            txt_phoneNumberRegister.PlaceholderText = "Nhập Số Điện Thoại";
            txt_phoneNumberRegister.Size = new Size(338, 47);
            txt_phoneNumberRegister.TabIndex = 4;
            txt_phoneNumberRegister.Texts = "";
            txt_phoneNumberRegister.UnderlinedStyle = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox11);
            panel8.Controls.Add(txt_nameRegister);
            panel8.Location = new Point(70, 204);
            panel8.Name = "panel8";
            panel8.Size = new Size(400, 57);
            panel8.TabIndex = 39;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.icons8_name_47;
            pictureBox11.Location = new Point(3, 4);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(47, 47);
            pictureBox11.TabIndex = 8;
            pictureBox11.TabStop = false;
            // 
            // txt_nameRegister
            // 
            txt_nameRegister.BackColor = SystemColors.Window;
            txt_nameRegister.BorderColor = Color.Silver;
            txt_nameRegister.BorderFocusColor = Color.HotPink;
            txt_nameRegister.BorderRadius = 12;
            txt_nameRegister.BorderSize = 1;
            txt_nameRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nameRegister.ForeColor = Color.DimGray;
            txt_nameRegister.Location = new Point(56, 4);
            txt_nameRegister.Margin = new Padding(3, 4, 3, 4);
            txt_nameRegister.Multiline = false;
            txt_nameRegister.Name = "txt_nameRegister";
            txt_nameRegister.Padding = new Padding(10, 9, 8, 9);
            txt_nameRegister.PasswordChar = false;
            txt_nameRegister.PlaceholderColor = Color.DarkGray;
            txt_nameRegister.PlaceholderText = "Nhập Họ Tên";
            txt_nameRegister.Size = new Size(338, 47);
            txt_nameRegister.TabIndex = 3;
            txt_nameRegister.Texts = "";
            txt_nameRegister.UnderlinedStyle = false;
            // 
            // btn_back1
            // 
            btn_back1.BackColor = Color.Transparent;
            btn_back1.BackgroundColor = Color.Transparent;
            btn_back1.BorderColor = Color.PaleVioletRed;
            btn_back1.BorderRadius = 20;
            btn_back1.BorderSize = 0;
            btn_back1.Cursor = Cursors.Hand;
            btn_back1.EnabledTextHover = false;
            btn_back1.FlatAppearance.BorderSize = 0;
            btn_back1.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_back1.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_back1.FlatStyle = FlatStyle.Flat;
            btn_back1.ForeColor = Color.White;
            btn_back1.Image = Properties.Resources.arrowreturn32pxBlack1;
            btn_back1.ImageHover = Properties.Resources.arrowreturn32pxWhite1;
            btn_back1.Location = new Point(3, 4);
            btn_back1.Margin = new Padding(3, 4, 3, 4);
            btn_back1.Name = "btn_back1";
            btn_back1.Size = new Size(72, 55);
            btn_back1.TabIndex = 38;
            btn_back1.TextColor = Color.White;
            btn_back1.TextHover = Color.White;
            btn_back1.UseVisualStyleBackColor = false;
            btn_back1.Click += btn_back1_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.icons8_contacts_70;
            pictureBox8.Location = new Point(229, 9);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(70, 70);
            pictureBox8.TabIndex = 37;
            pictureBox8.TabStop = false;
            // 
            // tp_register
            // 
            tp_register.Controls.Add(btn_register);
            tp_register.Controls.Add(panel5);
            tp_register.Controls.Add(pictureBox6);
            tp_register.Controls.Add(panel3);
            tp_register.Controls.Add(panel4);
            tp_register.Controls.Add(btn_back2);
            tp_register.Location = new Point(4, 29);
            tp_register.Name = "tp_register";
            tp_register.Padding = new Padding(3);
            tp_register.Size = new Size(540, 520);
            tp_register.TabIndex = 1;
            tp_register.Text = "Register";
            tp_register.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            btn_register.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_register.BackColor = SystemColors.Control;
            btn_register.BackgroundColor = SystemColors.Control;
            btn_register.BorderColor = Color.DarkCyan;
            btn_register.BorderRadius = 15;
            btn_register.BorderSize = 2;
            btn_register.Cursor = Cursors.Hand;
            btn_register.EnabledTextHover = true;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_register.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_register.ForeColor = Color.DarkCyan;
            btn_register.ImageAlign = ContentAlignment.MiddleRight;
            btn_register.ImageHover = null;
            btn_register.Location = new Point(70, 425);
            btn_register.Margin = new Padding(3, 4, 3, 4);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(400, 51);
            btn_register.TabIndex = 37;
            btn_register.Text = "Đăng Ký";
            btn_register.TextColor = Color.DarkCyan;
            btn_register.TextHover = Color.White;
            btn_register.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_register.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox7);
            panel5.Controls.Add(txt_registerPasswordConfirm);
            panel5.Location = new Point(70, 343);
            panel5.Name = "panel5";
            panel5.Size = new Size(400, 57);
            panel5.TabIndex = 35;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.icons8_check_lock_47;
            pictureBox7.Location = new Point(3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(47, 47);
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            // 
            // txt_registerPasswordConfirm
            // 
            txt_registerPasswordConfirm.BackColor = SystemColors.Window;
            txt_registerPasswordConfirm.BorderColor = Color.Silver;
            txt_registerPasswordConfirm.BorderFocusColor = Color.HotPink;
            txt_registerPasswordConfirm.BorderRadius = 12;
            txt_registerPasswordConfirm.BorderSize = 1;
            txt_registerPasswordConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_registerPasswordConfirm.ForeColor = Color.DimGray;
            txt_registerPasswordConfirm.Location = new Point(56, 6);
            txt_registerPasswordConfirm.Margin = new Padding(3, 4, 3, 4);
            txt_registerPasswordConfirm.Multiline = false;
            txt_registerPasswordConfirm.Name = "txt_registerPasswordConfirm";
            txt_registerPasswordConfirm.Padding = new Padding(10, 9, 8, 9);
            txt_registerPasswordConfirm.PasswordChar = false;
            txt_registerPasswordConfirm.PlaceholderColor = Color.DarkGray;
            txt_registerPasswordConfirm.PlaceholderText = "Confirm Password";
            txt_registerPasswordConfirm.Size = new Size(338, 47);
            txt_registerPasswordConfirm.TabIndex = 4;
            txt_registerPasswordConfirm.Texts = "";
            txt_registerPasswordConfirm.UnderlinedStyle = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.icons8_register_100;
            pictureBox6.Location = new Point(220, 31);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 100);
            pictureBox6.TabIndex = 36;
            pictureBox6.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(txt_registerPassword);
            panel3.Location = new Point(70, 261);
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
            panel4.Location = new Point(70, 179);
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
            btn_back2.Location = new Point(8, 7);
            btn_back2.Margin = new Padding(3, 4, 3, 4);
            btn_back2.Name = "btn_back2";
            btn_back2.Size = new Size(72, 55);
            btn_back2.TabIndex = 32;
            btn_back2.TextColor = Color.White;
            btn_back2.TextHover = Color.White;
            btn_back2.UseVisualStyleBackColor = false;
            btn_back2.Click += btn_back2_Click;
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
            tp_login.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tp_information.ResumeLayout(false);
            pn_birthday.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            tp_register.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private TabPage tp_login;
        private TabPage tp_register;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private CustomControl.CustomButton btn_login;
        private GroupBox groupBox1;
        private RadioButton rdb_customerLogin;
        private RadioButton rdb_employeeLogin;
        private Button btn_newAccount;
        private CustomControl.CustomButton btn_back2;
        private Panel panel3;
        private PictureBox pictureBox4;
        private CustomControl.CustomTextBox txt_registerPassword;
        private Panel panel4;
        private PictureBox pictureBox5;
        private CustomControl.CustomTextBox txt_registerUsername;
        private TabPage tp_information;
        private PictureBox pictureBox6;
        private Panel panel5;
        private PictureBox pictureBox7;
        private CustomControl.CustomTextBox txt_registerPasswordConfirm;
        private CustomControl.CustomButton btn_register;
        private PictureBox pictureBox8;
        private CustomControl.CustomButton btn_back1;
        private GroupBox groupBox2;
        private RadioButton rdb_customerRegister;
        private RadioButton rdb_employeeRegister;
        private Panel panel6;
        private PictureBox pictureBox9;
        private CustomControl.CustomTextBox txt_emailRegister;
        private Panel panel7;
        private PictureBox pictureBox10;
        private CustomControl.CustomTextBox txt_phoneNumberRegister;
        private Panel panel8;
        private PictureBox pictureBox11;
        private CustomControl.CustomTextBox txt_nameRegister;
        private GroupBox groupBox3;
        private RadioButton rdb_femaleRegister;
        private RadioButton rdb_maleRegister;
        private CustomControl.CustomButton btn_continue;
        private Panel pn_birthday;
        private CustomControl.CustomDateTimePicker dtp_birthdayRegister;
        private PictureBox pictureBox12;
    }
}