﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baslangıc = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            Random random = new Random();
            int sonuc = random.Text(baslangıc, bitis+1);
            textBox3.Text = sonuc.ToString();
        }
    }
}
