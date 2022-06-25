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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chao mung ban den voi lap trinh C#!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n,kq;
            n = Convert.ToInt32(value: textBox1.Text);
            int i = 1;
            kq = 0;
            while (i <= n)
            {
                if (i % 2 == 0) kq += i;
                i++;
            }
            MessageBox.Show("Kết quả là: "+kq);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n, kq;
            n = Convert.ToInt32(value: textBox1.Text);
            kq = 0;
            for (int i=1;i<=n;i++)
            {
                if (i % 2 == 1) kq += i;
                i++;
            }
            MessageBox.Show("Kết quả là: " + kq);
        }
    }
}
