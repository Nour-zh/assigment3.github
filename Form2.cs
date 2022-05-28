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
    public partial class Form2 : Form
    {

        private string _username;
        private int _phone;
        public Form2(string username, int phone)
        {
            _username = username;
            _phone = phone;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblmessagename.Text = _username;
            lblmessagphone.Text = _phone.ToString();
        }
    }
}
