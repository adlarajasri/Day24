using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpModel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpDBEntities e=new EmpDBEntities();
            foreach(var item in e.Employees) {
                Console.WriteLine(item.EmpName);
            }
        }
    }
}
