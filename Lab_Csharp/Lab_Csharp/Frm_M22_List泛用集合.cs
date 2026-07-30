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
    public partial class Frm_M22_List泛用集合 : Form
    {
        public Frm_M22_List泛用集合()
        {
            InitializeComponent();
        }

        List<Employee> lsEmp = new List<Employee>();
        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Name = txtEmployeeName.Text;
            emp.Age = int.Parse(txtEmployeeAge.Text);

            lsEmp.Add(emp);

            ShowMyEmployee();
        }

        private void ShowMyEmployee()
        {
            labShowEmployee.Text = "員工\n";

            for (int i = 0; i < lsEmp.Count; i++)
            {
                labShowEmployee.Text +=
                    $"姓名: {lsEmp[i].Name}, " +
                    $"年齡: {lsEmp[i].Age}\n";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //lsEmp.Add("string");
            //lsEmp.Add(100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Name = txtEmployeeName.Text;
            emp.Age = int.Parse(txtEmployeeAge.Text);

            lsEmp.Insert(0, emp);

            ShowMyEmployee();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lsEmp.Clear();

            ShowMyEmployee();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lsEmp.RemoveAt(0);

            ShowMyEmployee();
        }
    }
}
