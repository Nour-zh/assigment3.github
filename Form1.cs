namespace assigment3.github
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("sign in pleas");
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(txtusername.Text);
            frm.Show();

        }
    }
}