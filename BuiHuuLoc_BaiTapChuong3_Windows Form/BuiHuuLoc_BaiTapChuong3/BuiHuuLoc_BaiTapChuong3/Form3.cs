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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Thông tin cá nhân";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtHoTen.Text + "\n" + txtNgaySinh.Text + "\n" + txtSoThich.Text);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thoát chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
