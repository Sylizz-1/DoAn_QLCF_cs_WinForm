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
            btn_login = new CustomControl.CustomButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.BackColor = SystemColors.Window;
            txt_username.BorderColor = Color.Silver;
            txt_username.BorderFocusColor = Color.HotPink;
            txt_username.BorderRadius = 12;
            txt_username.BorderSize = 3;
            txt_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.ForeColor = Color.DimGray;
            txt_username.Location = new Point(139, 190);
            txt_username.Margin = new Padding(3, 4, 3, 4);
            txt_username.Multiline = false;
            txt_username.Name = "txt_username";
            txt_username.Padding = new Padding(10, 9, 8, 9);
            txt_username.PasswordChar = false;
            txt_username.PlaceholderColor = Color.DarkGray;
            txt_username.PlaceholderText = "Username";
            txt_username.Size = new Size(271, 47);
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
            txt_password.BorderSize = 3;
            txt_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.ForeColor = Color.DimGray;
            txt_password.Location = new Point(139, 245);
            txt_password.Margin = new Padding(3, 4, 3, 4);
            txt_password.Multiline = false;
            txt_password.Name = "txt_password";
            txt_password.Padding = new Padding(10, 9, 8, 9);
            txt_password.PasswordChar = false;
            txt_password.PlaceholderColor = Color.DarkGray;
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(271, 47);
            txt_password.TabIndex = 4;
            txt_password.Texts = "";
            txt_password.UnderlinedStyle = false;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_login.BackColor = Color.Red;
            btn_login.BackgroundColor = Color.Red;
            btn_login.BorderColor = Color.PaleVioletRed;
            btn_login.BorderRadius = 15;
            btn_login.BorderSize = 0;
            btn_login.EnabledTextHover = false;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatAppearance.MouseDownBackColor = Color.Red;
            btn_login.FlatAppearance.MouseOverBackColor = Color.Crimson;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(139, 332);
            btn_login.Margin = new Padding(3, 4, 3, 4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(271, 48);
            btn_login.TabIndex = 6;
            btn_login.Text = "Đăng Nhập";
            btn_login.TextColor = Color.White;
            btn_login.TextHover = Color.White;
            btn_login.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_coffee_100_2;
            pictureBox1.Location = new Point(139, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // LogInView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(548, 553);
            Controls.Add(pictureBox1);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Name = "LogInView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControl.CustomTextBox txt_username;
        private CustomControl.CustomTextBox txt_password;
        private CustomControl.CustomButton btn_login;
        private PictureBox pictureBox1;
    }
}