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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("서울특별시");
            comboBox2.Items.Add("인천광역시");
            comboBox2.Items.Add("대전광역시");
            comboBox2.Items.Add("대구광역시");
            comboBox2.Items.Add("부산광역시");

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text + textBox1.Text + "님은 " + comboBox2.Text + "에 거주하십니다", "알림창~");
        }
    }
}
