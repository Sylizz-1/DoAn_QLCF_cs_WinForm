using ClosedXML.Excel;
using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCF_cs_WinForm.View
{
    public partial class FileGiamGia : Form
    {
        GiamGiaBLL giamgiaBLL;
        public FileGiamGia()
        {
            InitializeComponent();
            giamgiaBLL = new GiamGiaBLL();
            LoadData();
        }
        public void LoadData()
        {
            List<GiamGiaModell> List = giamgiaBLL.GetGiamGiaList();
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

    public class GiamGiaModell
    {
        [DisplayName("ID")]
        public int PggId { get; set; }

        [DisplayName("Thời gian bắt đầu")]

        public DateTime? TgBatDau { get; set; }


        [DisplayName("Thời gian kết thúc")]

        public DateTime? TgKetThuc { get; set; }


        [DisplayName("Giá hoá đơn")]

        public double GiaHoaDon { get; set; }


        [DisplayName("Phần trăm giảm giá")]

        public byte PhanTramGiamGia { get; set; }


        [DisplayName("IsDelete")]
        public bool IsDelete { get; set; }
    }

    public class GiamGiaDAL
    {

    }

    public class GiamGiaBLL
    {
        private GiamGiaDAL giamGiaDAL;
        string connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;

        public GiamGiaBLL()
        {
            giamGiaDAL = new GiamGiaDAL();
        }


        public List<GiamGiaModell> GetGiamGiaList()
        {
            var cpList = new List<GiamGiaModell>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "select * from PhieuGiamGia";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pgg = new GiamGiaModell();
                        pgg.PggId = (int)reader["PggId"];
                        pgg.TgBatDau = reader["TgBatDau"] as DateTime?;
                        pgg.TgKetThuc = reader["TgKetThuc"] as DateTime?;
                        pgg.GiaHoaDon = (double)reader["GiaHoaDon"];
                        pgg.PhanTramGiamGia = (byte)reader["PhanTramGiamGia"];
                        pgg.IsDelete = (bool)reader["IsDelete"];
                        cpList.Add(pgg);
                    }
                }

                return cpList;
            }
        }
    }

}
