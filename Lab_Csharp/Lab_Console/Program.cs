
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Form;

namespace Lab_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Frm_HelloForm hello = new Frm_HelloForm();
            //hello.ShowDialog();

            //Console.WriteLine("Hello C#!");

            //Console.Write("請輸入姓名:");
            //string name =  Console.ReadLine();   // string => 字串
            //Console.WriteLine("Hello, " + name + "!");

            MyClass mc =  new MyClass();
            mc.Method04();
            mc.Method05();
            mc.Method06();

            Program p = new Program();
            p.MyMethod();
        }

         void MyMethod()
        {

        }
    }
}
