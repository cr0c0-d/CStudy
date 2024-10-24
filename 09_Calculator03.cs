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
    public partial class _09_Calculator03 : Form
    {
        public _09_Calculator03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, iSutja;
            Double dSum = 0;

            iSutja = int.Parse(textBox1.Text);

            textBox2.Text = "";

            for (i = iSutja; i >= 1; --i)
            {
                dSum = dSum + i;
                textBox2.Text = textBox2.Text + i + " + ";
            }
            textBox2.Text = dSum + " = " + textBox2.Text;
        }
    }
}
