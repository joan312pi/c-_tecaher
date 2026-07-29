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
    }
}
