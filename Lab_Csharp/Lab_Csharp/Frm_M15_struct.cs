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
    public partial class Frm_M15_struct : Form
    {
        public Frm_M15_struct()
        {
            InitializeComponent();
        }

        public Frm_M15_struct(string Name)
        {
            InitializeComponent();
            this.Text = Name;
        }


        string result = "產品\n";
        private void button1_Click(object sender, EventArgs e)
        {
            //Product pro ;
            //pro.Name = txtProductName.Text;
            //pro.Price = decimal.Parse( txtProductPrice.Text);

            //Product pro = new Product();
            //pro.Name = txtProductName.Text;
            //pro.Price = decimal.Parse(txtProductPrice.Text);

            //Product pro = new Product(txtProductName.Text,decimal.Parse(  txtProductPrice.Text));

            decimal price = 0;
            bool isNum = decimal.TryParse(txtProductPrice.Text, out price);

            if(isNum == true)
            {
                Product pro = new Product(txtProductName.Text, price);
                result = result + $"名稱: {pro.Name}, 價格: {pro.Price}\n";
            }
            else
            {
                MessageBox.Show("價格請輸入數字");
                //txtProductPrice.Text = "";
                txtProductPrice.Clear();
                txtProductPrice.Focus();
            }

            //result += $"名稱: {pro.Name}, 價格: {pro.Price}\n";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labShow.Text = result; 
        }
    }
}
