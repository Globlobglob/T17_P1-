using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employe p1 = new Employe(15,"Alex","Brown","Microsoft","Enjeneer");
            p1.Print();
            Console.WriteLine("\n");
            Person p2 = new Person(25, "Chimichimiai", "Chonchicid");
            p2.Print();
            Console.WriteLine("\n");
           Person p3 = new Student(25, "Anton", "Beburshvili", new DateTime(2024,02,12), 215);
            p3.Print();
           
                 Console.ReadLine();
        }
    }
}
