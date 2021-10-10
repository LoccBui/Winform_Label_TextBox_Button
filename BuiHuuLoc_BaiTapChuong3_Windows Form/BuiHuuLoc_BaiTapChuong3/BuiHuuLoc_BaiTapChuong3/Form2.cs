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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Giao diện Form 2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNoiDung.Text = "Xin Chào";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát chương trình", "Thoát chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (d == DialogResult.OK)
                this.Close();
                
                
        }

    }
}
