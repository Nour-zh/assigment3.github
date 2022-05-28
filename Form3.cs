using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment3.github
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your order is completed ");
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this iteam deleted sucessfulu from your basket");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this iteam in your basket now");
        }
    }
}
