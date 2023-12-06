using DoAn_QLCF_cs_WinForm.Presenter;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCF_cs_WinForm.View
{
    public partial class NhanVienView : Form, INhanVienView
    {

        private static NhanVienView instance;

        public event EventHandler AddBtnEvent;
        public event EventHandler EditBtnEvent;
        public event EventHandler DeleteBtnEvent;
        public event EventHandler AcceptBtnEvent;
        public event EventHandler CancelBtnEvent;

        public NhanVienView()
        {
            InitializeComponent();
            //SetUpView();
            BindingEvents();


        }
        private void BindingEvents()
        {
            addBtn.Click += delegate { AddBtnEvent?.Invoke(this, EventArgs.Empty); };
            editBtn.Click += delegate { EditBtnEvent?.Invoke(this, EventArgs.Empty); };
            xacNhanBtn.Click += delegate { AcceptBtnEvent?.Invoke(this, EventArgs.Empty); };
        }
        private void SetUpView()
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        public string IdNhanVien { get => this.idTxt.Tag.ToString(); set { this.idTxt.Focus(); this.idTxt.Texts = value; this.idTxt.Tag = value; } }
        public string NameNhanVien { get => this.tenTxt.Texts; set { this.tenTxt.Focus(); this.tenTxt.Texts = value; } }
        public string Email { get => this.emailTxt.Texts; set { this.emailTxt.Focus(); this.emailTxt.Texts = value; } }
        public string PhoneNumber { get => this.sdtTxt.Texts; set { this.sdtTxt.Focus(); this.sdtTxt.Texts = value; } }
        public string GioiTinh
        {
            get
            {
                return (string)this.gioitinhcmb.SelectedItem;
            }
            set
            {
                gioitinhcmb.SelectedItem = value;
            }
        }
        public string NgaySinh
        {
            get
            {
                return dtp_ngaySinh.Value.ToString("MM/dd/yyyy");
            }
            set
            {
                // Chuyển đổi chuỗi thành đối tượng DateTime
                DateTime selectedDate = DateTime.ParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                // Đặt giá trị cho DateTimePicker
                dtp_ngaySinh.Value = selectedDate;
            }
        }
        public string Username { get => this.taikhoanTxt.Texts; set { this.taikhoanTxt.Focus(); this.taikhoanTxt.Texts = value; } }
        public string Password { get => this.matkhauTxt.Texts; set { this.matkhauTxt.Focus(); this.matkhauTxt.Texts = value; } }
        public string PasswordConfirm { get => this.txt_passwordConfirm.Texts; set { this.txt_passwordConfirm.Focus(); this.txt_passwordConfirm.Texts = value; } }
        public bool IsDeleted
        {
            get
            {
                if (cb_isDeleted.Checked)
                {
                    return true;
                }
                return false;
            }
            set
            {
                cb_isDeleted.Checked = value;
            }
        }
        public int Permission
        {
            get => (int)this.quyencmb.SelectedValue;
            set
            {
                quyencmb.SelectedValue = value;
            }
        }

        public DataGridView DataGridView
        {
            get
            {
                return this.dataGridView;
            }
            set
            {

                this.dataGridView = value;
            }
        }

        public void LoadData(BindingSource list)
        {
            this.dataGridView.DataSource = list;
        }

        public void LoadQuyen(BindingSource listQuyen)
        {
            quyencmb.DisplayMember = "NamePermission";
            quyencmb.ValueMember = "IdPermission";
            quyencmb.DataSource = listQuyen;
            quyencmb.SelectedIndex = 0;
        }


        public static INhanVienView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new NhanVienView();
                instance.TopLevel = false;
                parentContainer.Controls.Add(instance);
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;

            }
            instance.Show();
            return instance;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = detailTabPage;

            tenTxt.Texts = string.Empty;
            emailTxt.Texts = string.Empty;
            sdtTxt.Texts = string.Empty;
            taikhoanTxt.Texts = string.Empty;
            matkhauTxt.Texts = string.Empty;
            txt_passwordConfirm.Texts = string.Empty;
            dtp_ngaySinh.Value = DateTime.Now;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = detailTabPage;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = listTabPage;
        }

        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = listTabPage;
        }

        private void HuyBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = listTabPage;
        }

        private void listTabPage_Click(object sender, EventArgs e)
        {

        }

        private void detailTabPage_Click(object sender, EventArgs e)
        {

        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        
    }
}
