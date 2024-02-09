using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employe:Person
    {
        string company;
            string job;

        public string Job { get => job; set => job = value; }
        public string Company { get => company; set => company = value; }
        public Employe() { }

        public Employe(int age,string name, string surname, string company, string job) : base(age, name, surname)
        {
            this.company = company;
            this.job = job;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Company: {Company}\nJob: {Job}");
        }

    }
}
