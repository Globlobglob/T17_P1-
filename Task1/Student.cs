using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student:Person
    {
        DateTime birthday;
        int kurs;

        private int Kurs { get=>kurs; set=>kurs=value; }
        private DateTime Birthday { get => birthday; set => birthday=value; }

        public Student() { }

       public  Student(int age, string name,string surname, DateTime birthday,int kurs):base(age,name,surname )
       {
            this.birthday = birthday; this.kurs = kurs;
       }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"birthday {Birthday}\nkurs {Kurs}");
        }

    }
}
