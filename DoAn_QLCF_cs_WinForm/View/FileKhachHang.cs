using ClosedXML.Excel;
using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Data.SqlClient;
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
    public partial class FileKhachHang : Form
    {
        private KhachHangBLL khachhangBLL;
        public FileKhachHang()
        {
            InitializeComponent();
            khachhangBLL = new KhachHangBLL();
            LoadData();
        }
        public void LoadData()
        {
            List<KhachHangModell> List = khachhangBLL.GetKhachHangList();
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
    public class KhachHangModell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public int IdTypeOfCustomer { get; set; }
        public DateTime TimeCreateAccount { get; set; }

        public DateTime NgaySinh { get; set; }

        public string Account { get; set; }
        public string Password { get; set; }
        public bool IsDelete { get; set; }

    }

    public class KhachHangBLL
    {
        private KhachHangDAL khachHangDAL;
        private string connectionString = "Data Source=DESKTOP-T3L3RE2\\MSSQLSERVER02;Initial Catalog=QLCF;Integrated Security=True";

        public KhachHangBLL()
        {
            khachHangDAL = new KhachHangDAL();
        }
        public int ThemDS()
        {
            return khachHangDAL.ThemDS();
        }

        public List<KhachHangModell> GetKhachHangList()
        {
            var List = new List<KhachHangModell>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "select * from KhachHang order by KhachHangId asc";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var khachhangModel = new KhachHangModell();

                        khachhangModel.Id = (int)reader["KhachHangId"];
                        khachhangModel.Name = reader["TenKhachHang"].ToString();
                        khachhangModel.Address = reader["DiaChi"].ToString();
                        khachhangModel.PhoneNumber = reader["SDT"].ToString();
                        khachhangModel.Email = reader["Email"].ToString();
                        khachhangModel.IsDelete = (bool)reader["IsDelete"];
                        khachhangModel.IdTypeOfCustomer = (int)reader["LoaiKhachHangId"];
                        khachhangModel.TimeCreateAccount = (DateTime)reader["ThoiGianTaoTk"];
                        khachhangModel.Account = reader["TaiKhoan"].ToString();
                        khachhangModel.Password = reader["MatKhau"].ToString();
                        khachhangModel.NgaySinh = (DateTime)reader["NgaySinh"];
                        List.Add(khachhangModel);
                    }
                }

                return List;
            }
        }

    }
    public class KhachHangDAL
    {
        private string connectionString = "Data Source=DESKTOP-T3L3RE2\\MSSQLSERVER02;Initial Catalog=QLCF;Integrated Security=True";

        public int ThemDS()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx; *.xls)|*.xlsx; *.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = openFileDialog.FileName;

                    // Load workbook from Excel file
                    using (var workbook = new XLWorkbook(fileName))
                    {
                        var worksheet = workbook.Worksheet(1); // Assuming data is in the first worksheet

                        using (var connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            // Assuming your columns in the Excel file are in a specific order
                            string sql = "INSERT INTO KhachHang (TenKhachHang, DiaChi, SDT, Email, LoaiKhachHangId, ThoiGianTaoTK, NgaySinh, TaiKhoan, MatKhau, IsDelete) " +
                                         "VALUES (@TenKhachHang, @DiaChi, @SDT, @Email, @LoaiKhachHangId, @ThoiGianTaoTK, @NgaySinh, @TaiKhoan, @MatKhau, @IsDelete);";

                            foreach (var row in worksheet.RowsUsed().Skip(1)) // Skip header row
                            {
                                using (var command = new SqlCommand(sql, connection))
                                {
                                    command.Parameters.AddWithValue("@TenKhachHang", row.Cell(1).Value.ToString());
                                    command.Parameters.AddWithValue("@DiaChi", row.Cell(2).Value.ToString());
                                    command.Parameters.AddWithValue("@SDT", row.Cell(3).Value.ToString());
                                    command.Parameters.AddWithValue("@Email", row.Cell(4).Value.ToString());
                                    command.Parameters.AddWithValue("@LoaiKhachHangId", Convert.ToInt32(row.Cell(5).Value));
                                    command.Parameters.AddWithValue("@ThoiGianTaoTK", DateTime.Now); // You may need to adjust this

                                    DateTime ngaySinh;
                                    if (DateTime.TryParse(row.Cell(6).Value.ToString(), out ngaySinh))
                                    {
                                        command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                                    }
                                    else
                                    {
                                        command.Parameters.AddWithValue("@NgaySinh", DBNull.Value);
                                    }

                                    command.Parameters.AddWithValue("@TaiKhoan", row.Cell(7).Value.ToString());
                                    command.Parameters.AddWithValue("@MatKhau", row.Cell(8).Value.ToString());
                                    command.Parameters.AddWithValue("@IsDelete", true);

                                    command.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return 0;
        }

    }
}
