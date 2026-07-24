using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Csharp
{
    public partial class Frm_M04 : Form
    {
        public Frm_M04()
        {
            InitializeComponent();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            MyMethod();
         
        }


        private void btnOpenHelloForm_Click(object sender, EventArgs e)
        {
            Frm_HelloForm hello = new Frm_HelloForm();
            hello.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass mc =  new MyClass();
            mc.MyNewMethod();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string  result = BirthYear(46);
            MessageBox.Show(result);
        }

        string BirthYear(int Age)
        {
           int  birthYear  = DateTime.Now.Year - Age;
            return "出生年: " + birthYear + "年";
        }


        void MyMethod()
        {
            string name = "紅霞颱風";
            MessageBox.Show("My Name is " + name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyClass mc =  new MyClass();
            //mc.Method01();
            //mc.Method02();
            mc.Method03();
            mc.Method04();
            mc.Method05();
        }
    }
}
