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

namespace DoAn_QLCF_cs_WinForm.View
{
    public partial class LogInView : Form, ILoginView
    {
        public LogInView()
        {
            InitializeComponent();
            btn_login.Click += delegate { LoginEvent?.Invoke(this, EventArgs.Empty); };
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

        public event EventHandler LoginEvent;

        public void IsFailure()
        {
            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            txt_username.Focus();
        }

        public void IsSuccess()
        {
            MessageBox.Show("Đăng nhập thành công!");
        }
    }
}
