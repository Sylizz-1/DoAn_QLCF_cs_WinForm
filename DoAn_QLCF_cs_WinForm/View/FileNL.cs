using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCF_cs_WinForm.View
{
    public partial class FileNL : Form
    {
        NguyenLieuBLL nguyenLieuBLL;

        public FileNL()
        {
            InitializeComponent();
            nguyenLieuBLL = new NguyenLieuBLL();
            LoadData();
        }
        public void LoadData()
        {
            List<NguyenLieuModell> List = nguyenLieuBLL.GetNguyenLieuList();
            dataGridView1.DataSource = List;
        }
        public void ExportToExcel(DataGridView dataGridView)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Data");

                // Lấy tên cột từ DataGridView và thêm vào file Excel
                for (int i = 2; i <= dataGridView.Columns.Count; i++)
                {
                    worksheet.Cell(1, i).Value = dataGridView.Columns[i - 1].HeaderText;
                }

                // Thêm dữ liệu từ DataGridView vào file Excel
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 1; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Lưu file Excel
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.RestoreDirectory = true;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridView1);
        }
    }

    public class NguyenLieuModell
    {
        [DisplayName("ID")]
        public int NguyenLieuId { get; set; }

        [DisplayName("Tên")]
        public string TenNguyenLieu { get; set; }

        [DisplayName("Thông tin")]
        public string ThongTin { get; set; }

        [DisplayName("Khối lượng")]
        public float KhoiLuong { get; set; }

        [DisplayName("Giá tiền")]
        public float GiaTien_Kg { get; set; }

        [DisplayName("Hình ảnh")]
        public string HinhAnh { get; set; }

        [DisplayName("IsDelete")]
        public bool IsDelete { get; set; }

    }

    public class NguyenLieuBLL
    {
        private NguyenLieuDAL nguyenlieuDAL;
        private string connectionString = "Data Source=DESKTOP-T3L3RE2\\MSSQLSERVER02;Initial Catalog=QLCF;Integrated Security=True";

        public NguyenLieuBLL()
        {
            nguyenlieuDAL = new NguyenLieuDAL();
        }


        public List<NguyenLieuModell> GetNguyenLieuList()
        {
            var cpList = new List<NguyenLieuModell>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "select * from NguyenLieu";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var NguyenLieu = new NguyenLieuModell();
                        NguyenLieu.NguyenLieuId = (int)reader["NguyenLieuId"];
                        NguyenLieu.TenNguyenLieu = reader["TenNguyenLieu"].ToString();
                        NguyenLieu.ThongTin = reader["ThongTin"].ToString();
                        NguyenLieu.KhoiLuong = float.Parse(reader["KhoiLuong"].ToString());
                        NguyenLieu.GiaTien_Kg = float.Parse(reader["GiaTien_Kg"].ToString());
                        NguyenLieu.HinhAnh = reader["HinhAnh"].ToString();

                        NguyenLieu.IsDelete = (bool)reader["IsDelete"];

                        cpList.Add(NguyenLieu);
                    }
                }
                return cpList;
            }
        }

    }

    public class NguyenLieuDAL
    {
        private string connectionString = "Data Source=DESKTOP-T3L3RE2\\MSSQLSERVER02;Initial Catalog=QLCF;Integrated Security=True";

    }
}
