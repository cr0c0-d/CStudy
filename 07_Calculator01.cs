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
    public partial class _07_Calculator01 : Form
    {
        public _07_Calculator01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iDigit1, iDigit2;
            iDigit1 = int.Parse(textBox1.Text);
            iDigit2 = int.Parse(textBox2.Text);
            textBox3.Text = (iDigit1 + iDigit2).ToString();
            label4.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iDigit1, iDigit2;
            iDigit1 = int.Parse(textBox1.Text);
            iDigit2 = int.Parse(textBox2.Text);
            textBox3.Text = (iDigit1 - iDigit2).ToString();
            label4.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iDigit1, iDigit2;
            iDigit1 = int.Parse(textBox1.Text);
            iDigit2 = int.Parse(textBox2.Text);
            textBox3.Text = (iDigit1 * iDigit2).ToString();
            label4.Text = "x";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int iDigit1, iDigit2;
            iDigit1 = int.Parse(textBox1.Text);
            iDigit2 = int.Parse(textBox2.Text);
            textBox3.Text = (iDigit1 / iDigit2).ToString();
            label4.Text = "÷";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int iDigit1, iDigit2;
            iDigit1 = int.Parse(textBox1.Text);
            iDigit2 = int.Parse(textBox2.Text);
            textBox3.Text = Math.Pow(iDigit1, iDigit2).ToString();
            label4.Text = "승";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int iDigit1, iDigit2;
            iDigit1 = int.Parse(textBox1.Text);
            iDigit2 = int.Parse(textBox2.Text);
            textBox3.Text = (iDigit1 % iDigit2).ToString();
            label4.Text = "Mod"; 
        }
    }
}

