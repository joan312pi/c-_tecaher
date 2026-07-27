using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
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
            DialogResult result =  hello.ShowDialog();

            if(result == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }

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

        private void button4_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.Method06();
            mc.Method03();
            mc.Method04();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Member member01 =  new Member();
            member01.Name = "John";
            member01.Phone = "0123456789";
            member01.BirthDate = new DateTime(1990, 8, 20);

            Member member02 = new Member()
            {
                Name = "陳庭妮",
                Phone = "09123789456",
                BirthDate = new DateTime(1980, 1, 1)
            };

            MessageBox.Show(member01.Name + ", " + member01.Phone + ", " + member01.BirthDate
                +"\n"+ member02.Name + ", " + member02.Phone + ", " + member02.BirthDate);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.btnOpenHelloForm.Click += new System.EventHandler(this.btnOpenHelloForm_Click);
            btnRegisterEvent01.Click += new EventHandler(RegisterEvent01_Click);
            //btnRegisterEvent02.Click += MyString;
            btnRegisterEvent02.Click += RegisterEvent02_Click;
        }

        string MyString()
        {
            return "";
        }

        private void RegisterEvent02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register Event 02");
        }

        //private void RegisterEvent02_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Register Event 02");
        //}

        private void RegisterEvent01_Click (object sender , EventArgs e)
        {
            MessageBox.Show("Register Event 01");
        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            //  當現在時間 分是奇數, 以A方案計價, 反之為B方案
            Payment pay;

            if(DateTime.Now.Minute%2 == 0)
            {
                pay = priceB;
            }
            else
            {
                pay = priceA;
            }

             decimal amount = decimal.Parse(  txtPrice.Text);
            decimal result = pay(amount);
            MessageBox.Show("價格: " + result);
        }

        delegate decimal Payment (decimal amount);

        decimal priceA(decimal OPrice)
        {
            decimal pA = OPrice * Convert.ToDecimal( 0.8);
            return pA;
        }

        decimal priceB(decimal OPrice)
        {
            decimal pB = OPrice * Convert.ToDecimal(1.2);
            return pB;
        }

        private void button7_Click(object sender, EventArgs e)
        {
           DialogResult result =  MessageBox.Show("今天是星期一嗎?", "問你喔", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                MessageBox.Show("答對了");
            }
            else
            {
                MessageBox.Show("答錯了");
            }


            float ft =  0.001F;

            decimal dec = 10000;

        }
    }
}
