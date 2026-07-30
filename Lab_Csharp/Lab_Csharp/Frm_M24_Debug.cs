using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Csharp
{
    public partial class Frm_M24_Debug : Form
    {
        public Frm_M24_Debug()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            string result = "66666";
            button1.Top = 100;
            button1.Left = 200;

            try
            {
                for (int i = 0; i < 10; i++, x++)
                {
                    result += i;
                    throw new ExecutionEngineException("自訂錯誤訊息");
                }
            }
            catch(AccessViolationException ex)
            {
                MessageBox.Show(ex.Message);
                // 存log
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
                // 存log
            }
            catch (Exception ex)
            {

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string dir = "C:\\Cs\\OneDrive_1_2026 - 7 - 23";
            string dir = @"C:\Cs\OneDrive_1_2026 - 7 - 23";

            string a = "aa\n";
        }
    }
}
