﻿using System;
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
    public partial class _06_Substring : Form
    {
        public _06_Substring()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.Substring(0, 3);
            textBox3.Text = textBox1.Text.Substring(textBox1.Text.Length-3, 3);
            textBox4.Text = textBox1.Text.Substring(5, 3);
            textBox5.Text = textBox1.Text.Length.ToString();
        }
    }
}
