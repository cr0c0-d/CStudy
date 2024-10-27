using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0_C샵시작하기_악어
{
    public partial class _12_Multiplication02 : Form
    {
        public _12_Multiplication02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            for (int i = 1; i <= 9; i+=3)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 0; k <= 2; k++)
                    {
                        textBox1.Text += (i + k) + " x " + j + " = " + ((i + k) * j).ToString() + "\t\t";
                    }
                    textBox1.Text += "\r\n";
                }
                textBox1.Text += Environment.NewLine;
            }
        }
    }
}
