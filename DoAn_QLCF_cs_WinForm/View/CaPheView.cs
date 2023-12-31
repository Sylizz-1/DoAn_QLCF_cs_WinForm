﻿using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Presenter;
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
	public partial class CaPheView : Form, ICaPheView
	{

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public CaPheView()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		{
			InitializeComponent();
			SetUpView();
			BindingEvents();
		}

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		private static CaPheView instance;

		public event EventHandler AcceptBtnEvent;
		public event EventHandler SearchTxtEvent;
		public event EventHandler DeleteBtnEvent;
		public event EventHandler AddBtnEvent;
		public event EventHandler EditBtnEvent;
		public event EventHandler AddNlBtnEvent;
		public event EventHandler EditNlBtnEvent;
		public event EventHandler DeleteNlBtnEvent;
		public event EventHandler FilterEvent;

		public string CapheId { get => this.idTxt.Texts; set { this.idTxt.Focus(); this.idTxt.Texts = value; } }

		public string MieuTaTxt { get => this.mieuTaTxt.Texts; set { this.mieuTaTxt.Focus(); this.mieuTaTxt.Texts = value; } }
		public string GiaTienTxt { get => this.giaTienTxt.Texts; set { this.giaTienTxt.Focus(); this.giaTienTxt.Texts = value; } }
		public string TenTxt { get => this.tenTxt.Texts; set { this.tenTxt.Focus(); this.tenTxt.Texts = value; } }
		public string XuatXuTxt { get => this.xuatXuTxt.Texts; set { this.xuatXuTxt.Focus(); this.xuatXuTxt.Texts = value; } }
		public bool IsDeleted { get => this.isDeletedCb.Checked; set => this.isDeletedCb.Checked = value; }
		public string SearchValue { get => this.searchTxt.Texts; set { this.searchTxt.Focus(); this.searchTxt.Texts = value; } }
		public bool IsEdited { get; set; }
		public Image CaPheImage { get => this.caPhePic.Image; set => this.caPhePic.Image = value; }
		public DataGridView CaPheDg { get => this.caPheDg; set => this.caPheDg = value; }
		public ComboBox NguyenLieuCbx { get => this.nguyenLieuCbx; set => this.nguyenLieuCbx = value; }
		public string KhoiLuongTxt { get => this.khoiLuongTxt.Texts; set { this.khoiLuongTxt.Focus(); this.khoiLuongTxt.Texts = value; } }

		DataGridView ICaPheView.CpnlList2 { get => this.cpnlList2; set => this.cpnlList2 = value; }

		private BindingSource templist = new BindingSource();

		// UI Code
		private void BindingEvents()
		{
			addBtn.Click += delegate { AddBtnEvent?.Invoke(this, EventArgs.Empty); };
			editBtn.Click += delegate { EditBtnEvent?.Invoke(this, EventArgs.Empty); };
			acceptCfBtn.Click += delegate { AcceptBtnEvent?.Invoke(this, EventArgs.Empty); };
			delBtn.Click += delegate { DeleteBtnEvent?.Invoke(this, EventArgs.Empty); };
			searchTxt._TextChanged += delegate { SearchTxtEvent?.Invoke(this, EventArgs.Empty); };
			addCpnlBtn.Click += delegate { AddNlBtnEvent?.Invoke(this, EventArgs.Empty); };
			editCpnlBtn.Click += delegate { EditNlBtnEvent?.Invoke(this, EventArgs.Empty); };
			delCpnlBtn.Click += delegate { DeleteNlBtnEvent?.Invoke(this, EventArgs.Empty); };
		}

		private void SetUpView()
		{
			// setup Tabcontrol
			tabControl1.Appearance = TabAppearance.FlatButtons;
			tabControl1.ItemSize = new System.Drawing.Size(0, 1);
			tabControl1.SizeMode = TabSizeMode.Fixed;

			// NguyenLieuCbx
			this.nguyenLieuCbx.ValueMember = null;
			this.nguyenLieuCbx.DisplayMember = "TenNguyenLieu";
		}


		public void LoadData(BindingSource list)
		{
			this.caPheDg.DataSource = list;
			templist = list;
			((DataGridViewImageColumn)caPheDg.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Zoom;
		}


		public static ICaPheView GetInstance(Form parentContainer)
		{
			if (instance == null || instance.IsDisposed)
			{
				instance = new CaPheView();
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

		private void caPhePic_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "image files|*.jpg;*.png;*.gif";
			DialogResult dr = ofd.ShowDialog();

			if (dr == DialogResult.Cancel)
				return;

			caPhePic.Image = Image.FromFile(ofd.FileName);
			caPhePic.Image.Tag = ofd.SafeFileName;
		}


		private void addBtn_Click(object sender, EventArgs e)
		{
			this.IsEdited = false;
			this.tabControl1.SelectedTab = this.detailsTab;
		}

		private void editBtn_Click(object sender, EventArgs e)
		{
			this.IsEdited = true;
			this.tabControl1.SelectedTab = this.detailsTab;
		}

		public void LoadCpnlList(BindingSource list)
		{
			this.cpnlList.DataSource = list;
			this.cpnlList2.DataSource = list;
			((DataGridViewImageColumn)cpnlList.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Zoom;
			((DataGridViewImageColumn)cpnlList2.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Zoom;
		}
		public void LoadNguyenLieuCbx(BindingSource list)
		{

			this.nguyenLieuCbx.DataSource = list;
		}

		private void customButton1_Click(object sender, EventArgs e)
		{
			this.tabControl1.SelectedTab = this.detailsTab;
		}

		private void HuyBtn_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Bạn thật sự muốn hủy?", "Quay trở lại", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				this.tabControl1.SelectedTab = this.listTab;
			}
			else if (dialogResult == DialogResult.No)
			{
				return;
			}
		}

		private void customButton3_Click(object sender, EventArgs e)
		{
			this.tabControl1.SelectedTab = this.cpnlTab;
		}


		private void customButton4_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Bạn có muốn quay lại không?", "Quay trở lại", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				this.tabControl1.SelectedTab = this.listTab;
			}
			else if (dialogResult == DialogResult.No)
			{
				return;
			}
		}

		private void NguyenLieuCbx_SelectedIndexChanged(object sender, EventArgs e)
		{
			string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
			var logoimage = Path.Combine(path, "image\\nguyenLieu");
			Image img;
			if (nguyenLieuCbx.SelectedValue != null)
			{
				/*NguyenLieuModel nlModel = (NguyenLieuModel)nguyenLieuCbx.SelectedValue;
				using (var stream = new FileStream(Path.Combine(logoimage, nlModel.HinhAnh), FileMode.Open))
				{
					var image = Image.FromStream(stream);
					this.anhNguyenLieuPbx.Image = image;
				}*/

				try
				{
					NguyenLieuModel nlModel = (NguyenLieuModel)nguyenLieuCbx.SelectedValue;
					this.anhNguyenLieuPbx.Image = Image.FromFile(Path.Combine(logoimage, nlModel.HinhAnh));
				}
				catch (OutOfMemoryException ex)
				{
					ex.ToString();
					this.anhNguyenLieuPbx.Image = null;
				}

				/*using (Image temp = Image.FromFile(logoimage))
				{
					img = new Bitmap(temp);
					this.anhNguyenLieuPbx.Image = img;
				}*/
			}
		}


		private void khoiLuongTxt_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
			 (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if ((e.KeyChar == '.') && (this.khoiLuongTxt.Texts.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}

		private void cpnlList2_SelectionChanged(object sender, EventArgs e)
		{
			CaPheNguyenLieuModel cpnlModel = (CaPheNguyenLieuModel)this.cpnlList2.CurrentRow?.DataBoundItem;
			if (cpnlModel != null)
			{
				this.NguyenLieuCbx.SelectedIndex = cpnlModel.NguyenLieuId - 1;
				this.KhoiLuongTxt = cpnlModel.KhoiLuong.ToString();
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string value = sxCbx.SelectedItem.ToString();
			List<CaPheModel> myList = templist.List.OfType<CaPheModel>().ToList();

			switch (value)
			{
				case "Id Tăng Dần":
					myList.Sort((x, y) => x.Id.CompareTo(y.Id));
					break;
				case "Id Giảm Dần":
					myList.Sort((x, y) => y.Id.CompareTo(x.Id));
					break;
				case "Giá Tăng Dần":
					myList.Sort((x, y) => x.Gia.CompareTo(y.Gia));
					break;
				case "Giá Giảm Dần":
					myList.Sort((x, y) => y.Gia.CompareTo(x.Gia));
					break;
				default: break;
			}

			BindingSource myBindingSource = new BindingSource();
			myBindingSource.DataSource = myList;
			LoadData(myBindingSource);
		}

		private void caPheDg_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			
		}
	}
}
