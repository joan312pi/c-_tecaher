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
    public partial class Frm_M17 : Form
    {
        public Frm_M17()
        {
            InitializeComponent();
        }
        bool flag = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if(flag)
            {
                btnReverse.BackColor = Color.NavajoWhite;
                //flag = false; 
                //flag = !flag;
            }
            else
            {
                btnReverse.BackColor = Color.Honeydew;
                //flag = true;
                //flag =!flag;
            }

            flag = !flag;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnReverse.BackColor = flag ? Color.NavajoWhite : Color.Honeydew;
            flag = !flag;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 90 ~ 100 => A
            // 80 ~ 89 => B
            // 70 ~ 79 => C
            // 60 ~ 69 => D
            // ~59 => E

            //int score = int.Parse( txtScore.Text);
            int score = 0;
            if (int.TryParse(txtScore.Text, out  score))
            {
                if (score >= 90 && score <= 100)
                {
                    labGrade.Text = "A級";
                }
                else if (score >= 80)
                {
                    labGrade.Text = "B級";
                }
                else if (score >= 70)
                {
                    labGrade.Text = "C級";
                }
                else if (score >= 60)
                {
                    labGrade.Text = "D級";
                }
                else
                {
                    labGrade.Text = "E級";
                }

                //switch (score)
                //{
                //    case 100:
                //    case 99:
                //    case 98:
                //        labGrade.Text = "A級";
                //        break;
                //    case 79:
                //        labGrade.Text = "C級";
                //        break;
                //    case 69:
                //        labGrade.Text = "D級";
                //        break;
                //}


            }
            else
            {
                MessageBox.Show("不知道什麼是阿拉伯數字?");
                txtScore.Clear();
                txtScore.Focus();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";

            while(i < 10)
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }

                result += i++ + "\n";
                //i++;
            }

            MessageBox.Show(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";

            do
            {
                if(i >= 5)
                {
                    break;
                }

                result += i + "\n";
                ++i;
            } while (i < 10);

            MessageBox.Show(result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string result = "";
            for( int i = 0  ; i<10 ; i++ )
            {
                result += i + "\n";
            }

            MessageBox.Show(result);

            string result2 = "";
            for (int x = 100, y = 10, z = 1; x / y > z; x /= 2, y -= 2 , z++  )
            {
                result2 += $"x: {x}, y: {y}, z: {z}\n";
            }

            MessageBox.Show(result2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] arr = { 0, 10, 2, 3, 4, 5, 6, 7, 8, 900 };

            string result = "";

            foreach( int i in arr)
            {
                result += i + "\n";
            }

            MessageBox.Show(result);
        }
    }
}
