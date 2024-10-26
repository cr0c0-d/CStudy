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
    public partial class _11_Multiplication : Form
    {
        public _11_Multiplication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, iDan;
            iDan = int.Parse(textBox1.Text);
            textBox2.Text = "";
            for (i = 1; i <= 9; i++)
            {
                textBox2.Text = textBox2.Text + iDan + " X " + i + " = " + (iDan * i).ToString() + "\r\n";
            }
        }
    }
}
