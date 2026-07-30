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
    public partial class Frm_M19_Array : Form
    {
        public Frm_M19_Array()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] arr = new int[3];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;

            //int[] arr = new int[3] { 1, 2, 3 };

            int[] arr = { 1, 2, 3 };

            string result = "";

            for(int i = 0; i < arr.Length; i++)
            {
                result += arr[i] + "\n";
            }

            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           int[] myArr  = GetRandomArray(10);

            string result = "";

            foreach (int num in myArr)
            {
                result += num + "\n";
            }

            //for(int i = 0; i < myArr.Length; i++)
            //{
            //    result += myArr[i] + "\n";
            //}

            MessageBox.Show(result);
        }
        int[] GetRandomArray(int ArrayLength)
        {
            int[] arr = new int[ArrayLength];

             Random rd = new Random();
            
            for(int i = 0; i < ArrayLength; i++)
            {
                //int rNum = rd.Next(100);

                //while(Array.IndexOf(arr, rNum) != -1)
                //{
                //    rNum = rd.Next(100);
                //}

                int rNum = 0;
                do
                {
                    rNum = rd.Next(ArrayLength)+1;
                } while (Array.IndexOf(arr, rNum) != -1);

                arr[i] = rNum;
            }

            return  arr;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] arr = { 3, 6, 9 };
            ArrayParam(arr);

            MessageBox.Show(arr[0].ToString());

        }

        void ArrayParam(int[] array)
        {
            array[0] += 100;
        }

    }
}
