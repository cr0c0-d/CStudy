using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0_C샵시작하기_악어
{
    public partial class _10_Calculator04 : Form
    {
        public _10_Calculator04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dSum_odd = 0, dSum_even = 0;

            for (int i = 1; i <= int.Parse(textBox1.Text); i++)
            {
                if (i % 2 == 0)
                {
                    dSum_even += i;
                    textBox3.Text = textBox3.Text + i + " + ";
                }
                else
                {
                    dSum_odd += i;
                    textBox2.Text = textBox2.Text + i + " + ";
                }    
            }
            textBox3.Text = textBox3.Text + " = " + dSum_even;
            textBox2.Text = textBox2.Text + " = " + dSum_odd;

        }
    }
}
