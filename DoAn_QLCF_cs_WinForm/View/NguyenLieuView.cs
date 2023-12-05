using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Presenter;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn_QLCF_cs_WinForm.View
{
    public partial class NguyenLieuView : Form, INguyenLieuView
    {

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private static NguyenLieuView instance;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private string id = "1";
        public event EventHandler btnAddClickEvent;
        public event EventHandler btnUpdateClickEvent;
        public event EventHandler btnFilterClickEvent;
        public event EventHandler AddEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SortEvent;
        public event EventHandler FilterEvent;
        public event EventHandler ResetEvent;
        public event EventHandler FindNglEvent;

        public bool checkIsAdd = false;
        public bool checkIsfilter = false;
        public bool checkIsUpdate = false;
        public bool isNeedTurn = false;
        private BindingSource templist = new BindingSource();

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public NguyenLieuView()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            SetUpView();

            xacNhanBtn.Click += delegate { AddEvent?.Invoke(this, EventArgs.Empty); };
            xacNhanBtn.Click += delegate { UpdateEvent?.Invoke(this, EventArgs.Empty); };
            xacNhanBtn.Click += delegate { FilterEvent?.Invoke(this, EventArgs.Empty); };

            addBtn.Click += delegate { btnAddClickEvent?.Invoke(this, EventArgs.Empty); };
            editBtn.Click += delegate { btnUpdateClickEvent?.Invoke(this, EventArgs.Empty); };
            filterBtn.Click += delegate { btnFilterClickEvent?.Invoke(this, EventArgs.Empty); };

            delBtn.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            sortBtn.Click += delegate { SortEvent?.Invoke(this, EventArgs.Empty); };
            resetBtn.Click += delegate { ResetEvent?.Invoke(this, EventArgs.Empty); };

            btnFindNgl.Click += delegate { FindNglEvent?.Invoke(this, EventArgs.Empty); };

            rbIDDec.CheckedChanged += SortRadioButton_CheckedChanged;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            rbIIDnc.CheckedChanged += SortRadioButton_CheckedChanged;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            rbNameDec.CheckedChanged += SortRadioButton_CheckedChanged;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            rbNameInc.CheckedChanged += SortRadioButton_CheckedChanged;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            rbKlgDec.CheckedChanged += SortRadioButton_CheckedChanged;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            rbKlgInc.CheckedChanged += SortRadioButton_CheckedChanged;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            rbInfoDec.CheckedChanged += SortRadioButton_CheckedChanged;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            rbInfoInc.CheckedChanged += SortRadioButton_CheckedChanged;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            rbPriceDec.CheckedChanged += SortRadioButton_CheckedChanged;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            rbPriceInc.CheckedChanged += SortRadioButton_CheckedChanged;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            rbIsDeleteDec.CheckedChanged += SortRadioButton_CheckedChanged;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            rbIsDeleteInc.CheckedChanged += SortRadioButton_CheckedChanged;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        }
        private void SetUpView()
        {
            tcNgl.Appearance = TabAppearance.FlatButtons;
            tcNgl.ItemSize = new System.Drawing.Size(0, 1);
            tcNgl.SizeMode = TabSizeMode.Fixed;
        }
        public static INguyenLieuView GetInstance(Form parentContainer)
        {
            instance = null;
            if (instance == null || instance.IsDisposed)
            {
                instance = new NguyenLieuView();
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
        public string NguyenLieuId
        {
            get => this.txtNglId.Texts;
            set => this.txtNglId.Texts = value;
        }
        public string TenNguyenLieu
        {
            get => this.txtNglName.Texts;
            set => this.txtNglName.Texts = value;
        }
        public string ThongTin
        {
            get => this.txtNglInfo.Texts;
            set => this.txtNglInfo.Texts = value;
        }
        public string KhoiLuong
        {
            get => this.txtNglWeigh.Texts;
            set => this.txtNglWeigh.Texts = value;
        }
        public string GiaTien_Kg
        {
            get => this.txtNglPrice.Texts;
            set => this.txtNglPrice.Texts = value;
        }
        public string IsDelete
        {
            get => (this.checkboxIsDelete.Checked).ToString();
            set => this.checkboxIsDelete.Checked = bool.Parse(value);
        }
        public string HinhAnh
        {
            get
            {
                string fullPath = this.caPhePic.ImageLocation;
                int lastIndexOfSlash = fullPath.LastIndexOf("\\");
                if (lastIndexOfSlash != -1)
                {
                    string croppedPath = fullPath.Substring(lastIndexOfSlash + 1);
                    return croppedPath;
                }
                return fullPath;
            }
            set
            {
                try
                {
                    this.caPhePic.ImageLocation = value;
                    this.caPhePic.Image = Image.FromFile(value);
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show("Ảnh quá bộ nhớ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                    HinhAnh = Path.Combine(path, "Resources\\defaultImage3.png");
                }
            }
        }

        public bool isAdd
        {
            get => checkIsAdd;
            set => checkIsAdd = value;
        }
        public bool isFilter
        {
            get => checkIsfilter;
            set => checkIsfilter = value;
        }
        public bool isUpdate
        {
            get => checkIsUpdate;
            set => checkIsUpdate = value;
        }
        public string selectedId { get => this.id; set => this.id = value; }

        public string Nglcount
        {
            get => dgvNgl.RowCount.ToString();
        }
        public string FindText
        {
            get => searchNglTxt.Texts;
            set => searchNglTxt.Texts = value;
        }
        public void LoadData(BindingSource list)
        {
            this.dgvNgl.DataSource = list;
            if (dgvNgl.Columns.Contains("HinhAnh"))
            {
                dgvNgl.Columns.Remove("HinhAnh");
            }

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "HinhAnh";
            imageColumn.HeaderText = "Hình Ảnh";
            imageColumn.DataPropertyName = "HinhAnh";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgvNgl.Columns.Insert(5, imageColumn);

            templist = list;
            dgvNgl.ClearSelection();
            selectedId = "0";
        }
        private void dgvNgl_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNgl.Columns[e.ColumnIndex].Name == "HinhAnh" && e.Value != null)
            {
                string imagePath = e.Value.ToString();
                Image image;
                try
                {
                    image = Image.FromFile(imagePath);
                }
                catch (OutOfMemoryException ex)
                {
                    image = null;
                }
                e.Value = image;
            }
        }
        public void GetIdNguyenLieuAdd(int id)
        {
            this.txtNglId.Enabled = true;
            this.txtNglId.Focus();
            this.txtNglId.Texts = id.ToString();
            this.txtNglName.Focus();
        }
        public void SetTextBoxFillData(NguyenLieuModel ngl)
        {
            this.txtNglId.Enabled = true;
            this.txtNglId.Focus();
            this.txtNglId.Texts = ngl.NguyenLieuId.ToString();
            this.txtNglId.Enabled = false;
            this.txtNglInfo.Focus();
            this.txtNglInfo.Texts = ngl.ThongTin;
            this.txtNglWeigh.Focus();
            this.txtNglWeigh.Texts = ngl.KhoiLuong.ToString();
            this.txtNglPrice.Focus();
            this.txtNglPrice.Texts = ngl.GiaTien_Kg.ToString();
            this.HinhAnh = ngl.HinhAnh;
            this.IsDelete = ngl.IsDelete.ToString();
            this.txtNglName.Focus();
            this.txtNglName.Texts = ngl.TenNguyenLieu;
        }

        public bool CheckInput()
        {
            string checkPath = "defaultImage3.png";
            string s = "Vui lòng nhập ";
            if (string.IsNullOrEmpty(txtNglName.Texts))
            {
                s += "Tên nguyên liệu";
                txtNglName.BorderColor = Color.Red;
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                txtNglName.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtNglInfo.Texts))
            {
                s += "Thông tin nguyên liệu";
                txtNglInfo.BorderColor = Color.Red;
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                txtNglInfo.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtNglWeigh.Texts) || !float.TryParse(txtNglWeigh.Texts, out _))
            {
                s += "Khối lượng nguyên liệu (số)";
                txtNglWeigh.BorderColor = Color.Red;
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                txtNglWeigh.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtNglPrice.Texts) || !float.TryParse(txtNglPrice.Texts, out _))
            {
                s += "Giá nguyên liệu (số)";
                txtNglPrice.BorderColor = Color.Red;
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                txtNglPrice.BorderColor = Color.DarkCyan;
            if (HinhAnh == checkPath)
            {
                s += "Hình ảnh";
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void setState(bool isAddState, bool isUpdateState, bool isFilterState, bool isNeedReturnState)
        {
            checkIsAdd = isAddState;
            checkIsUpdate = isUpdateState;
            checkIsfilter = isFilterState;
            isNeedTurn = isNeedReturnState;
        }
        public void SetNull()
        {
            if (isFilter)
            {
                txtNglId.Enabled = true;
                txtNglId.BackColor = Color.White;
                txtNglId.Texts = "";
                txtNglId.BorderColor = Color.DarkCyan;
                txtNglId.Focus();
            }
            if (isAdd)
            {
                lbIsDelete.Visible = false;
                checkboxIsDelete.Visible = false;
                txtNglName.PlaceholderText = string.Empty;
            }
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            HinhAnh = Path.Combine(path, "Resources\\defaultImage3.png");
            txtNglName.Texts = "";
            txtNglInfo.Texts = "";
            txtNglWeigh.Texts = "";
            txtNglPrice.Texts = "";
            checkboxIsDelete.Checked = false;
            txtNglName.BorderColor = Color.DarkCyan;
            txtNglInfo.BorderColor = Color.DarkCyan;
            txtNglWeigh.BorderColor = Color.DarkCyan;
            txtNglPrice.BorderColor = Color.DarkCyan;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            txtNglId.Enabled = false;
            txtNglId.BackColor = Color.LightGray;
            txtNglId.BorderColor = Color.Silver;
            tcNgl.SelectedTab = detailTabPage;
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dgvNgl.RowCount > 0 && selectedId != "0")
                tcNgl.SelectedTab = detailTabPage;
        }
        private void filterBtn_Click(object sender, EventArgs e)
        {
            isFilter = true;
            tcNgl.SelectedTab = detailTabPage;
            SetNull();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (isFilter)
            {
                txtNglId.Text = "";
                txtNglId.Enabled = false;
                txtNglId.BackColor = Color.LightGray;
                txtNglId.BorderColor = Color.Silver;
            }
            if (isAdd)
            {
                lbIsDelete.Visible = true;
                checkboxIsDelete.Visible = true;
            }
            setState(false, false, false, false);
            tcNgl.SelectedTab = listTabPage;
            SetNull();
            dgvNgl.ClearSelection();
            selectedId = "0";
        }
        private void HuyBtn_Click(object sender, EventArgs e)
        {
            if (isFilter)
            {
                txtNglId.Text = "";
                txtNglId.Enabled = false;
                txtNglId.BackColor = Color.LightGray;
                txtNglId.BorderColor = Color.Silver;
            }
            if (isAdd)
            {
                lbIsDelete.Visible = true;
                checkboxIsDelete.Visible = true;
            }
            setState(false, false, false, false);
            tcNgl.SelectedTab = listTabPage;
            SetNull();
            dgvNgl.ClearSelection();
            selectedId = "0";
        }
        private void sortBtn_Click(object sender, EventArgs e)
        {
            if (gbSort.Visible)
                gbSort.Visible = false;
            else
                gbSort.Visible = true;
        }
        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            if (isNeedTurn)
                tcNgl.SelectedTab = listTabPage;
            dgvNgl.ClearSelection();
            selectedId = "0";
        }
        private void SortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string sortType = radioButton.Tag.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
                SortListModels(sortType);
#pragma warning restore CS8604 // Possible null reference argument.
            }
        }
        private void SortListModels(string sortType)
        {
            List<NguyenLieuModel> myList = templist.List.OfType<NguyenLieuModel>().ToList();
            switch (sortType)
            {
                case "IDInc":
                    myList.Sort((x, y) => x.NguyenLieuId.CompareTo(y.NguyenLieuId));
                    break;
                case "IDDec":
                    myList.Sort((x, y) => y.NguyenLieuId.CompareTo(x.NguyenLieuId));
                    break;
                case "NameInc":
                    myList.Sort((x, y) => x.TenNguyenLieu.CompareTo(y.TenNguyenLieu));
                    break;
                case "NameDec":
                    myList.Sort((x, y) => y.TenNguyenLieu.CompareTo(x.TenNguyenLieu));
                    break;
                case "InfoInc":
                    myList.Sort((x, y) => x.ThongTin.CompareTo(y.ThongTin));
                    break;
                case "InfoDec":
                    myList.Sort((x, y) => y.ThongTin.CompareTo(x.ThongTin));
                    break;
                case "KlgInc":
                    myList.Sort((x, y) => x.KhoiLuong.CompareTo(y.KhoiLuong));
                    break;
                case "KlgDec":
                    myList.Sort((x, y) => y.KhoiLuong.CompareTo(x.KhoiLuong));
                    break;
                case "PriceInc":
                    myList.Sort((x, y) => x.GiaTien_Kg.CompareTo(y.GiaTien_Kg));
                    break;
                case "PriceDec":
                    myList.Sort((x, y) => y.GiaTien_Kg.CompareTo(x.GiaTien_Kg));
                    break;
                case "IsDeleteInc":
                    myList.Sort((x, y) => x.IsDelete.CompareTo(y.IsDelete));
                    break;
                case "IsDeleteDec":
                    myList.Sort((x, y) => y.IsDelete.CompareTo(x.IsDelete));
                    break;
            }
            BindingSource myBindingSource = new BindingSource();
            myBindingSource.DataSource = myList;
            LoadData(myBindingSource);
        }

        private void dgvNgl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvNgl.Rows[e.RowIndex];
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string firstCellData = selectedRow.Cells[0].Value.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
                id = firstCellData;
#pragma warning restore CS8601 // Possible null reference assignment.
            }
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            rbIDDec.Checked = false;
            rbIIDnc.Checked = false;
            rbNameDec.Checked = false;
            rbNameInc.Checked = false;
            rbInfoDec.Checked = false;
            rbInfoInc.Checked = false;
            rbKlgDec.Checked = false;
            rbKlgInc.Checked = false;
            rbPriceDec.Checked = false;
            rbPriceInc.Checked = false;
            rbIsDeleteDec.Checked = false;
            rbIsDeleteInc.Checked = false;

            dgvNgl.ClearSelection();
            selectedId = "0";
        }

        private void txtNglName__TextChanged(object sender, EventArgs e)
        {
            if (txtNglName.Texts.Length > 0 || isFilter)
                txtNglName.BorderColor = Color.DarkCyan;
            else
                txtNglName.BorderColor = Color.Red;
        }

        private void txtNglInfo__TextChanged(object sender, EventArgs e)
        {
            if (txtNglInfo.Texts.Length > 0 || isFilter)
                txtNglInfo.BorderColor = Color.DarkCyan;
            else
                txtNglInfo.BorderColor = Color.Red;
        }

        private void txtNglWeigh__TextChanged(object sender, EventArgs e)
        {
            int result;
            if ((int.TryParse(txtNglWeigh.Texts, out result) && txtNglWeigh.Texts.Length > 0) && (isFilter || int.TryParse(txtNglWeigh.Texts, out result)))
                txtNglWeigh.BorderColor = Color.DarkCyan;
            else
                txtNglWeigh.BorderColor = Color.Red;
        }
        private void txtNglPrice__TextChanged(object sender, EventArgs e)
        {
            int result;
            if ((int.TryParse(txtNglPrice.Texts, out result) && txtNglPrice.Texts.Length > 0) && (isFilter || int.TryParse(txtNglPrice.Texts, out result)))
                txtNglPrice.BorderColor = Color.DarkCyan;
            else
                txtNglPrice.BorderColor = Color.Red;
        }

        private void caPhePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                HinhAnh = open.FileName;
            }
        }

        private void btnFindNgl_Click(object sender, EventArgs e)
        {
            
        }
    }
}
