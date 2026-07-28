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
    public partial class Frm_M14 : Form
    {
        public Frm_M14()
        {
            InitializeComponent();
        }



      

        private void button2_Click(object sender, EventArgs e)
        {
            Member mem1 = new Member()
            {
                Name = "大樂透",
                Phone = "0912345678",
                BirthDate = new DateTime(1900, 1, 1)
            };
            MessageBox.Show($"Name: {mem1.Name}, BirthDate: {mem1.BirthDate.ToShortDateString()}");

            PassByReferenceType(mem1);

            MessageBox.Show($"Name: {mem1.Name}, BirthDate: {mem1.BirthDate.ToShortDateString()}");

        }

        void PassByReferenceType(Member member)
        {
            member.BirthDate = DateTime.Now.AddYears(-18);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int A = 900;
            MessageBox.Show($"A: {A}");
            PassByValueType(A);
            MessageBox.Show($"A: {A}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int A = 900;
            MessageBox.Show($"A: {A}");
            PassByRef(ref A);
            MessageBox.Show($"A: {A}");
        }

        void PassByRef(ref int X)
        {
            X = 100;
        }

        void PassByValueType(int X)
        {
            X = 100;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int A;

            PassByOut(out A);
            MessageBox.Show($"A: {A}");
        }

        void PassByOut(out int X)
        {
            X = 100;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           string totalChi =  TotalScore("國文", 100, 80, 70);
            MessageBox.Show(totalChi);
            string totalMath = TotalScore("數學", 50, 90, 50, 80);
            MessageBox.Show(totalMath);
        }


        string TotalScore(string Course , params int[] Scores)
        {
            int Total = 0;

            for(int i = 0; i<Scores.Length ;  i++)
            {
                //Total = Total + Scores[i];
                Total += Scores[i];
            }

            return $"{Course} 的總成績: {Total} 分";

            // {100, 80, 70}
            // Scores.Length => 3
            // i :  0, 1, 2
            // Scores[i]: 100, 80, 70
            // Total: 100, 180, 250

        }

    

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Admin  = 10   ,    User  = 20
            int Admin = 10, User = 20;

            int UserRole = 10;

            //// 測試中啦 上線要拿掉
            //Admin = 100000;

            if(UserRole == Admin)
            {
                btnProduct.Enabled = true;
            }
            else
            {
                btnProduct.Enabled = false;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Admin  = 10   ,    User  = 20
            const int Admin = 10, User = 20;

            int UserRole = 10;

            //Admin = 100000;

            if (UserRole == Admin)
            {
                btnProduct.Enabled = true;
            }
            else
            {
                btnProduct.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Role UserRole = Role.User;

            if(UserRole == Role.Admin)
            {
                btnProduct.Enabled = true;
            }
            else
            {
                btnProduct.Enabled = false;
            }


        }
    }
}
