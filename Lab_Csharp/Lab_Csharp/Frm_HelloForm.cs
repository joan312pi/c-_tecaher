using System;
using System.Windows.Forms;

namespace Lab_Csharp
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
        }

    
    }
}
