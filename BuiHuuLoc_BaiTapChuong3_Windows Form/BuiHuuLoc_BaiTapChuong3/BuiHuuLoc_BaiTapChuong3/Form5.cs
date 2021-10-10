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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Text = "Lập trình C#";
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = "TÔI YÊU CNTT";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = null;
            txtHienThi.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thoát chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
                this.Close();
        }


        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.H)
                btnThoat_Click(sender, e);        
        }
    }
}
