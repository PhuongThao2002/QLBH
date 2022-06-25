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
    public partial class Form2 : Form
    {
        int i, n, res;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtn.Text);
            res = 0;
            for (int i=1;i<=n;i++)
            {
                if (i%2==0)
                {
                    res += i;
                }
            }
            lblKQ.Text = "Ket qua tinh theo For la: " + Convert.ToString(res);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 1;
            n = Convert.ToInt16(txtn.Text);
            res = 0;
            do
            {
                if (i % 2 == 0)
                {
                    res += i;
                }
                i++;
            }
            while (i <= n);
            lblKQ.Text = "Ket qua tinh theo do - While la: " + Convert.ToString(res);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 1;
            n = Convert.ToInt16(txtn.Text);
            res = 0;
            while (i<=n)
            {
                if (i%2==0)
                {
                    res += i;
                }
                i++;
            }
            lblKQ.Text = "Ket qua tinh theo While la: " + Convert.ToString(res);
        }
    }
}
