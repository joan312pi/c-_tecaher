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
    public partial class Frm_M13_CTS : Form
    {
        public Frm_M13_CTS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = 100 , B = 200;

            int C = B;

            MessageBox.Show("A: " + A + ",B: " + B + ",C: " + C);

            B = 300;

            MessageBox.Show($"A: {A},B: {B}, C: {C}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox tb = txtReferenceType;

            tb.BackColor = Color.NavajoWhite;
            tb.ForeColor = Color.OldLace;
            tb.Text = "666666";


        }
    }
}
