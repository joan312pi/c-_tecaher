using Lab_Form;
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
    public partial class Frm_M11 : Form
    {
        public Frm_M11()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {     
            count += 1;  // count = count + 1;
            labCount.Text = "Count: " + count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b =  ++count;  // count = count + 1 ;     b = count;
            labCount.Text = "Count: " + count;
            labB1.Text = "b1: " + b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int b = count++;  //  b = count;    count = count + 1;
            labCount.Text = "Count: " + count;
            labB2.Text = "b2: " + b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //const int number ;
            //number = 100;
            //x = 100;
        }
        int count = 0;
        private void button5_Click(object sender, EventArgs e)
        {
           
            int x = 100;

            if (true)
            {
                //y = 200;
                int y = 200;
                x = x + y; // x += y;
            }

            //y = 300;

        }


        StaticLab sl = new StaticLab();
        StaticLab sl2 = new StaticLab();
        private void button6_Click(object sender, EventArgs e)
        {
            sl.InstanceCount++;      // 要new才有實體, 可以有好幾份
            labInstance.Text = "instance Count: " + sl.InstanceCount;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StaticLab.StaticCount++;     // 不用new, 程式開始執行時製作實體, 只會有一份存在記憶體
            labStatic.Text = "static Count: " + StaticLab.StaticCount;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Frm_HelloForm frm = new Frm_HelloForm();
            frm.Show();
        }
    }
}
