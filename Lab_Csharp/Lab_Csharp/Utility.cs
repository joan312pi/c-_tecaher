using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Form
{
    public class Member
    {
        public string Name;
        public string Phone;
        public DateTime BirthDate;
    }

    public class StaticLab
    {
        public int InstanceCount;  // 實體屬性的變數
        public static int StaticCount;  // 靜態屬性的變數, 全域變數
    }


}
