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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Text = "Calculator";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int result = int.Parse(txtFirstNum.Text) + int.Parse(txtSecondNum.Text);
            lblResult.Text = result.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int result = int.Parse(txtFirstNum.Text) - int.Parse(txtSecondNum.Text);
            lblResult.Text = result.ToString();
        }

        private void btnMultifly_Click(object sender, EventArgs e)
        {
            
                int result = int.Parse(txtFirstNum.Text) * int.Parse(txtSecondNum.Text);
                lblResult.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtSecondNum.Text) == 0)
            {
                lblResult.Text = "Không thể chia cho 0";
            }
            else
            {
                int result = int.Parse(txtFirstNum.Text) / int.Parse(txtSecondNum.Text);
                lblResult.Text = result.ToString();
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtSecondNum.Text) == 0)
            {
                lblResult.Text = "Không thể chia cho 0";
            }
            else
            {
                int result = int.Parse(txtFirstNum.Text) % int.Parse(txtSecondNum.Text);
                lblResult.Text = result.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtFirstNum.Text = txtSecondNum.Text = null;
            lblResult.Text = null;
            txtFirstNum.Focus();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("“Do you want to exit the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void txtFirstNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void txtSecondNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)8))
                e.Handled = true;
        }
    }
}
