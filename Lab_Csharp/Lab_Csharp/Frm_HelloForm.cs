using System;
using System.Windows.Forms;

namespace Lab_Form
{
    public  partial class Frm_HelloForm : System.Windows.Forms.Form
    {
        public Frm_HelloForm()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)  // click事件 -> 方法
        {
            // todo 說hello
            string name = txtName.Text;
           MessageBox.Show("Hello " + name + "!");
            this.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(StaticLab.StaticCount.ToString());
        }
    }
}
