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
    public partial class ImExFileView : Form, IImExFileView
    {
        public ImExFileView()
        {
            InitializeComponent();
        }

        private static ImExFileView instance;
        public static IImExFileView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new ImExFileView();
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

        private void customButton5_Click(object sender, EventArgs e)
        {

        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            FileGiamGia formGG = new FileGiamGia();
            formGG.Show();

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            FileKhachHang form = new FileKhachHang();
            form.Show();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            //FileNhanVien form = new FileNhanVien();
            //form.Show();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            FileNL formNL = new FileNL();
            formNL.Show();
        }
    }
}
