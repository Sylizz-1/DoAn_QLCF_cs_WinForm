using DoAn_QLCF_cs_WinForm.Presenter;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCF_cs_WinForm.View
{
    public partial class NhanVienView : Form, INhanVienView
    {
        public NhanVienView()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }
        public string nhanvienId
        {
            get => this.idTxt.Texts;
            set => this.idTxt.Texts = value;
        }

        public string nhanvienTen
        {
            get => this.tenTxt.Texts;
            set => this.tenTxt.Texts = value;
        }

        public string nhanvienSdt
        {
            get => this.sdtTxt.Texts;
            set => this.sdtTxt.Texts = value;
        }

        public string nhanvienEmail
        {
            get => this.emailTxt.Texts;
            set => this.emailTxt.Texts = value;
        }

        public string nhanvienGioitinh
        {
            get => this.gioitinhcmb.SelectedItem.ToString();
            set => this.gioitinhcmb.SelectedItem = value;
        }

        public string nhanvienTaikhoan
        {
            get => this.taikhoanTxt.Texts;
            set => this.taikhoanTxt.Texts = value;
        }

        public string nhanvienMatkhau
        {
            get => this.matkhauTxt.Texts;
            set => this.matkhauTxt.Texts = value;
        }

        public string nhanvienReturn
        {
            get => this.returnTxt.Texts;
            set => this.returnTxt.Texts = value;
        }

        public string nhanvienQuyen
        {
            get => this.quyencmb.SelectedItem.ToString();
            set => this.quyencmb.SelectedItem = value;
        }

        public string nhanvienDel
        {
            get => this.trangthaicmb.SelectedItem.ToString();
            set => this.trangthaicmb.SelectedItem = value;
        }

        private static NhanVienView instance;

        public NhanVienPresenter Presenter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = listTabPage;
        }

        private void listTabPage_Click(object sender, EventArgs e)
        {

        }

        private void detailTabPage_Click(object sender, EventArgs e)
        {

        }

        public void LoadData(BindingSource list)
        {
            this.dataGridView1.DataSource = list;
        }

        public void GetIdNhanVien(int id)
        {
            this.idTxt.Texts = id.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
