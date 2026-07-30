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
    public partial class Frm_M21_進階方法 : Form
    {
        public Frm_M21_進階方法()
        {
            InitializeComponent();
        }

        void Swap(ref int A ,ref  int B)
        {
            int T = A;
            A = B;
            B = T;
        }
        void Swap(ref string A , ref string B)
        {
            string T = A;
            A = B;
            B = T;
        }

        void GenericSwap<Tt>(ref Tt A , ref Tt B)
        {
            Tt T = A;
            A = B;
            B = T;
        }

        void GenericSwap<Tt,Yy>(ref Tt A , ref Tt B ,  Yy Y)
        {
            Tt T = A;
            A=B;
            B = T;

            MessageBox.Show(Y.ToString());
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int iA = 100, iB = 200;
            MessageBox.Show($"A: {iA}, B: {iB}");
            GenericSwap<int>(ref iA, ref iB);
            MessageBox.Show($"A: {iA}, B: {iB}");

            string sA = "AAA", sB = "BBB";
            MessageBox.Show($"A: {sA}, B: {sB}");
            GenericSwap<string>(ref sA, ref sB);
            MessageBox.Show($"A: {sA}, B: {sB}");

            Point a = new Point(100, 100) , b = new Point(200, 200) ;
            GenericSwap<Point, DateTime>(ref a, ref b, DateTime.Now);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iA = 100 ,  iB = 200;
            MessageBox.Show($"A: {iA}, B: {iB}");
            Swap(ref iA, ref iB);
            MessageBox.Show($"A: {iA}, B: {iB}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sA = "AAA", sB = "BBB";
            MessageBox.Show($"A: {sA}, B: {sB}");
            Swap(ref sA, ref sB);
            MessageBox.Show($"A: {sA}, B: {sB}");


        }

        void MyMethod(int Top , string Name = "John" , string ID = "AAA")
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyMethod(10, ID :"John" , Name: "bbb");
        }
    }
}
