﻿using DoAn_QLCF_cs_WinForm.View.ViewInterface;
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
