using DoAn_QLCF_cs_WinForm.Model;
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
using static System.Net.Mime.MediaTypeNames;

namespace DoAn_QLCF_cs_WinForm.View
{
    public partial class NccView : Form, INccView
    {
        private static NccView instance;
        private string id = "1";
        public event EventHandler btnAddClickEvent;
        public event EventHandler btnUpdateClickEvent;
        public event EventHandler AddEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SortEvent;
        public event EventHandler FilterEvent;
        public bool checkIsAdd = false;
        public NccView()
        {
            InitializeComponent();
            SetUpView();

            xacNhanBtn.Click += delegate { AddEvent?.Invoke(this, EventArgs.Empty); };
            xacNhanBtn.Click += delegate { UpdateEvent?.Invoke(this, EventArgs.Empty); };
            delBtn.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            editBtn.Click += delegate { btnUpdateClickEvent?.Invoke(this, EventArgs.Empty); };
            addBtn.Click += delegate { btnAddClickEvent?.Invoke(this, EventArgs.Empty); };
            filterBtn.Click += delegate { FilterEvent?.Invoke(this, EventArgs.Empty); };
            sortBtn.Click += delegate { SortEvent?.Invoke(this, EventArgs.Empty); };
        }
        public string SearchValue
        {
            get => this.searchTxt.Text;
            set => this.searchTxt.Text = value;
        }
        public string NhaCungCapId
        {
            get => this.txtIdNcc.Texts;
            set => this.txtIdNcc.Texts = value;
        }
        public string TenNhaCungCap
        {
            get => this.txtTenNcc.Texts;
            set => this.txtTenNcc.Texts = value;
        }
        public string DiaChi
        {
            get => this.txtDiaChiNcc.Texts;
            set => this.txtDiaChiNcc.Texts = value;
        }
        public string SDT
        {
            get => this.txtSDTNcc.Texts;
            set => this.txtSDTNcc.Texts = value;
        }
        public string Email
        {
            get => this.txtEmailNcc.Texts;
            set => this.txtEmailNcc.Texts = value;
        }
        public string IsDelete
        {
            get => (this.checkboxIsDelete.Checked).ToString();
            set => this.checkboxIsDelete.Checked = bool.Parse(value);
        }
        public bool isAdd
        {
            get => checkIsAdd;
            set => checkIsAdd = value;
        }
        public string selectedId { get => this.id; set => this.id = value; }


        public static INccView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new NccView();
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

        public void LoadData(BindingSource list)
        {
            this.dgvNcc.DataSource = list;
        }
        public void GetIdNccAdd(int id)
        {
            this.txtIdNcc.Texts = id.ToString();
        }
        private void SetUpView()
        {
            tcNCC.Appearance = TabAppearance.FlatButtons;
            tcNCC.ItemSize = new System.Drawing.Size(0, 1);
            tcNCC.SizeMode = TabSizeMode.Fixed;
        }

        public bool CheckInput()
        {
            string s = "Vui lòng nhập ";
            if (string.IsNullOrEmpty(txtTenNcc.Texts))
            {
                s += "\n + Tên nhà cung cấp";
                txtTenNcc.BorderColor = Color.Red;
            }
            else
                txtTenNcc.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtDiaChiNcc.Texts))
            {
                s += "\n + Địa chỉ nhà cung cấp";
                txtDiaChiNcc.BorderColor = Color.Red;
            }
            else
                txtDiaChiNcc.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtSDTNcc.Texts) || !float.TryParse(txtSDTNcc.Texts, out _))
            {
                s += "\n + Số điện thoại nhà cung cấp (số)";
                txtSDTNcc.BorderColor = Color.Red;
            }
            else
                txtSDTNcc.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtEmailNcc.Texts))
            {
                s += "\n + Email nhà cung cấp";
                txtEmailNcc.BorderColor = Color.Red;
            }
            else
                txtEmailNcc.BorderColor = Color.DarkCyan;
            if (s != "Vui lòng nhập ")
            {
                MessageBox.Show(s);
                return false;
            }
            return true;
        }

        public void SetNull()
        {
            txtTenNcc.Texts = "";
            txtSDTNcc.Texts = "";
            txtEmailNcc.Texts = "";
            txtDiaChiNcc.Texts = "";
            checkboxIsDelete.Checked = false;
            txtTenNcc.BorderColor = Color.DarkCyan;
            txtDiaChiNcc.BorderColor = Color.DarkCyan;
            txtEmailNcc.BorderColor = Color.DarkCyan;
            txtSDTNcc.BorderColor = Color.DarkCyan;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            tcNCC.SelectedTab = detailTabPage;
            isAdd = true;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            tcNCC.SelectedTab = detailTabPage;
            isAdd = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            tcNCC.SelectedTab = listTabPage;
            SetNull();
        }

        private void HuyBtn_Click(object sender, EventArgs e)
        {
            tcNCC.SelectedTab = listTabPage;
            SetNull();
        }
        private void dgvNcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvNcc.Rows[e.RowIndex];
                string firstCellData = selectedRow.Cells[0].Value.ToString();
                id = firstCellData;
            }
        }

        private void txtTenNcc__TextChanged(object sender, EventArgs e)
        {
            if (txtTenNcc.Texts.Length > 0)
                txtTenNcc.BorderColor = Color.DarkCyan;
            else
                txtTenNcc.BorderColor = Color.Red;
        }

        private void txtDiaChiNcc__TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChiNcc.Texts.Length > 0)
                txtDiaChiNcc.BorderColor = Color.DarkCyan;
            else
                txtDiaChiNcc.BorderColor = Color.Red;
        }

        private void txtEmailNcc__TextChanged(object sender, EventArgs e)
        {
            if (txtEmailNcc.Texts.Length > 0)
                txtEmailNcc.BorderColor = Color.DarkCyan;
            else
                txtEmailNcc.BorderColor = Color.Red;
        }

        private void txtSDTNcc__TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(txtSDTNcc.Texts, out result))
                txtSDTNcc.BorderColor = Color.Red;
            else
                txtSDTNcc.BorderColor = Color.DarkCyan;
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {

        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            gbSort.Visible = true;
        }
    }
}