using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Assignment2Entities())
            {
                var std = new Client_Master()
                {
                    ClientNo = "C00002",

                    Name = "Bill",

                    Address1 = "123 street",

                    Address2 = "abc street",

                    City = "Kochi",

                    State = "Kerala",

                    BalDue = 40000

                    


                };
                context.Client_Master.Add(std);

                context.SaveChanges();
            }
        }
    }
}
