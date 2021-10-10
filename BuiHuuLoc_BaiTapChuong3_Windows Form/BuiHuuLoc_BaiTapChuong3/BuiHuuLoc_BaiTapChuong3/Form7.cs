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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.Text = "Giải PTB1 OOP";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrEmpty(txtFirstNum.Text) && !string.IsNullOrEmpty(txtSecondNum.Text) )
            {
                if (double.Parse(txtFirstNum.Text) == 0)
                {
                    lblResult.Text = "Phương trình vô nghiệm";
                }
                else if (double.Parse(txtSecondNum.Text) == 0)
                {
                    lblResult.Text = "Phương trình vô số nghiệm";
                }
                else
                {
                    double result = -double.Parse((txtSecondNum.Text)) / double.Parse(txtFirstNum.Text);
                    lblResult.Text = result.ToString();
                }
            }
            else
            {
                lblResult.Text = "Chưa có giá trị ";
            }

            
        }
    }
}
