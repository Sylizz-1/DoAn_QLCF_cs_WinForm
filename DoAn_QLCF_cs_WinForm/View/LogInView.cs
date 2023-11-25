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

            //ẩn button new account
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

        public event EventHandler LoginEvent;
        public event EventHandler RegisterEvent;

        public void IsLoginFailure()
        {
            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            txt_username.Focus();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void IsEmptyUsername()            
        {
            tabControl1.SelectedTab = tb_registerEmployee;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            txt_password.Focus();
            MessageBox.Show("Password không được để trống!");
        }

        private void btn_newAccount_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tp_information;
        }
        private void btn_back1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tp_login;
        }

       
    }
}
