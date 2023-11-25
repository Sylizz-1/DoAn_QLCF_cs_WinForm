using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn_QLCF_cs_WinForm.View
{
    public partial class LogInView : Form, ILoginView
    {
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

        public event EventHandler LoginEvent;
        public event EventHandler RegisterEvent;

        public void IsFailure()
        {
            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            txt_username.Focus();
        }

        public void IsSuccess()
        {
            MessageBox.Show("Đăng nhập thành công!");
        }

        public void RegisterSuccess()
        {
            MessageBox.Show("Đăng kí thành công!");
        }

        public void RegisterFailure()
        {
            MessageBox.Show("Đăng kí thất bại!");
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

        public void IsEmptyRole()
        {
            MessageBox.Show("Vui lòng chọn vai trò!");
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
            tabControl1.SelectedTab = tp_register;
        }
    }
}
