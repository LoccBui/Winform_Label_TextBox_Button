using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuiHuuLoc_BaiTapChuong3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "Bài tập Họ Tên";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát chương trình ?","Thoát chương trình",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (d == DialogResult.OK)
                this.Close();
        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = txtHo.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = txtTen.Text;
        }

        private void btnHoVaTen_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = txtHo.Text + " " + txtTen.Text;
        }
    }
}
