using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn_QLCF_cs_WinForm.View
{
    public partial class LogInView : Form, ILoginView
    {
        private bool isHidePassword = true;
        public LogInView()
        {
            InitializeComponent();
            setUpView();

            btn_login.Click += delegate { LoginEvent?.Invoke(this, EventArgs.Empty); };
            btn_register.Click += delegate { RegisterEvent?.Invoke(this, EventArgs.Empty); };
        }

        private void setUpView()
        {
            //ẩn tab view
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            //ẩn style button new account
            btn_newAccount.FlatStyle = FlatStyle.Flat;
            btn_newAccount.FlatAppearance.BorderSize = 0;

            //gán giá trị max cho birthday là ngày hôm nay
            dtp_birthdayRegister.MaxDate = DateTime.Today;

            grb_role.BackColor = Color.FromArgb(100, Color.White); // Màu nền với độ mờ 100
            grb_role.ForeColor = Color.Black;
            btn_login.BackColor = Color.FromArgb(100, Color.White); // Màu nền với độ mờ 100
            btn_login.ForeColor = Color.Black;
            ptb_header.BackColor = Color.FromArgb(100, Color.White); // Màu nền với độ mờ 100           
            btn_newAccount.BackColor = Color.FromArgb(100, Color.White); // Màu nền với độ mờ 100
            pn_username.BackColor = Color.FromArgb(100, Color.White); // Màu nền với độ mờ 100
            pn_username.ForeColor = Color.Black;
            pn_password.BackColor = Color.FromArgb(100, Color.White); // Màu nền với độ mờ 100
            pn_password.ForeColor = Color.Black;
        }

        public string UserName
        {
            get { return txt_username.Texts; }
            set { txt_username.Texts = value; }
        }
        public string Password
        {
            get { return txt_password.Texts; }
            set { txt_password.Texts = value; }
        }
        public string RegisterUserName
        {
            get { return txt_registerUsername.Texts; }
            set { txt_registerUsername.Texts = value; }
        }
        public string RegisterPassword
        {
            get { return txt_registerPassword.Texts; }
            set { txt_registerPassword.Texts = value; }
        }

        public string Role
        {
            get
            {
                if (rdb_customerLogin.Checked)
                    return "customer";
                if (rdb_employeeLogin.Checked)
                    return "employee";
                return null;
            }
        }

        public string RegisterPasswordConfirm
        {
            get { return txt_registerPasswordConfirm.Texts; }
        }

        public string RegisterName
        {
            get { return txt_nameRegister.Texts; }
        }

        public string RegisterPhoneNumber
        {
            get { return txt_phoneNumberRegister.Texts; }
        }

        public string RegisterEmail
        {
            get { return txt_emailRegister.Texts; }
        }

        public string RegisterSex
        {
            get
            {
                if (rdb_maleRegister.Checked)
                    return "male";
                if (rdb_femaleRegister.Checked)
                    return "female";
                return null;
            }
        }

        public string RegisterRole
        {
            get
            {
                if (rdb_employeeRegister.Checked)
                    return "employee";
                if (rdb_customerRegister.Checked)
                    return "customer";
                return null;
            }
        }

        public string RegisterBirthday
        {
            get
            {
                return dtp_birthdayRegister.Value.ToString("MM/dd/yyyy");
            }
        }

        public event EventHandler LoginEvent;
        public event EventHandler RegisterEvent;
        public event EventHandler InformationEvent;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void LoginFailure()
        {
            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            txt_username.Focus();
        }

        public void IsEmptyUsername()
        {
            txt_username.Focus();
            MessageBox.Show("Username không được để trống!");
        }

        public void IsEmptyPassword()
        {
            txt_password.Focus();
            MessageBox.Show("Password không được để trống!");
        }
        private bool IsEmailValid(string email)
        {
            // Biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            // Sử dụng Regex.IsMatch để kiểm tra
            return Regex.IsMatch(email, pattern);
        }
        private bool CheckInputInformation()
        {
            if (RegisterRole == null)
            {
                ShowMessage("Vui lòng chọn vai trò!");
                return false;
            }
            else if (RegisterSex == null)
            {
                ShowMessage("Vui lòng chọn giới tính!");
                return false;
            }
            else if (RegisterName == "")
            {
                txt_nameRegister.Focus();
                ShowMessage("Họ tên không được để trống!");
                return false;
            }
            else if (RegisterPhoneNumber == "")
            {
                txt_phoneNumberRegister.Focus();
                ShowMessage("Số điện thoại không được để trống!");
                return false;
            }
            else if (RegisterEmail == "")
            {
                txt_emailRegister.Focus();
                ShowMessage("Email không được để trống!");
                return false;
            }
            else if (!IsEmailValid(RegisterEmail))
            {
                txt_emailRegister.Focus();
                ShowMessage("Email không đúng định dạng!");
                return false;
            }
            else if (RegisterBirthday == DateTime.Today.ToString("MM/dd/yyyy"))
            {
                ShowMessage("Vui lòng chọn ngày sinh!");
                return false;
            }
            return true;
        }

        private void btn_newAccount_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tp_information;
        }
        private void btn_back1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tp_login;
        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tp_information;
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            if (CheckInputInformation())
            {
                tabControl1.SelectedTab = tp_register;
            }
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true; // Hủy bỏ sự kiện nếu ký tự là khoảng trắng
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true; // Hủy bỏ sự kiện nếu ký tự là khoảng trắng
            }
        }

        private void txt_nameRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ sự kiện nếu ký tự không phải là chữ cái hoặc ký tự điều khiển
            }

        }

        private void txt_phoneNumberRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và không phản ứng với các phím điều hướng
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txt_phoneNumberRegister.Texts.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void pn_hidePassword_Click(object sender, EventArgs e)
        {
            if (isHidePassword)
            {
                txt_password.PasswordChar = false;
                pn_hidePassword.BackgroundImage = Properties.Resources.icons8_hide_57;
                isHidePassword = false;
            }
            else
            {
                txt_password.PasswordChar = true;
                pn_hidePassword.BackgroundImage = Properties.Resources.icons8_eye_57;
                isHidePassword = true;
            }
        }
    }
}
