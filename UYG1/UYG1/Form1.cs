using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYG1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Click_Click(object sender, EventArgs e)
        {
            byte skor1, skor2;
            skor1 = 4;
            skor2 = 1;
            if (skor1 > skor2)
            {
                MessageBox.Show("Selam Canım ;)");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
