using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not;
            not = Convert.ToByte(textBox1.Text);
            if (not >= 51)
            {
                MessageBox.Show("Sınıfı geçtiniz.");
            }
            if (not >= 85)
            {
                MessageBox.Show("Taktir aldınız.");
            }
            
            else if (not >= 70 & not < 85)
            {
                MessageBox.Show("Teşekkür aldınız.");
            }
            else if (not >= 0 & < 49)
            {
                MessageBox.Show("Sınıfta kaldınız.");
            }
            else if (not >= 100)
            {
                MessageBox.Show("Yanlış değer girdiniz.");
            }
            if (not == 50)
            {
                MessageBox.Show("Geçtiniz.");
            }
            else if (not >= 50 & not < 70)
            {
                MessageBox.Show("Belge almadan geçtiniz.");
            }
           
        }
    }
}
