using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yapılacak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte sayi1, sayi2;
            sayi1 = Convert.ToByte(textBox1.Text);
            sayi2 = Convert.ToByte(textBox2.Text);
            if (sayi1 > sayi2)
            {
            MessageBox.Show("1.sayi 2.sayıdan büyüktür.");
            }
            if (sayi1 == sayi2)
            {
            MessageBox.Show("Sayılar birbirine eşittir.");
            }
            if (sayi1 < sayi2)
            {
            MessageBox.Show("2.sayi 1.sayıdan büyüktür");
            } 
        }
    }
}
