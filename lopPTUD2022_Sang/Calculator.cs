using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lopPTUD2022_Sang
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        double res = 0;
        double t = 0;

        private void btnPercent_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            t = t*10 + 1;
            lblResult.Text = t.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            t = t * 10 + 2;
            lblResult.Text = t.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            t = t * 10 + 3;
            lblResult.Text = t.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            t = t * 10 + 4;
            lblResult.Text = t.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            t = t * 10 + 5;
            lblResult.Text = t.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            t = t * 10 + 6;
            lblResult.Text = t.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            t = t * 10 + 7;
            lblResult.Text = t.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            t = t * 10 + 8;
            lblResult.Text = t.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            t = t * 10 + 9;
            lblResult.Text = t.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            t = t * 10;
            lblResult.Text = t.ToString();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            lblView.Text = t.ToString() + " + ";
            res += t;
            lblResult.Text = res.ToString();
            t = 0;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            t = 0;
            res = 0;
            lblResult.Text = "0";
            lblView.Text = "0";
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            lblView.Text = res.ToString();
            lblResult.Text = res.ToString();
        }
    }
}
