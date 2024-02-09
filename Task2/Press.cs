using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Press
    {
        int copies;
        string name;
        double price;

        private int Copies { get => copies; set => copies = value; }
        private string Name { get => name; set => name = value; }
        private double Price { get => price; set => price = value; }


       public Press() { }
       public Press(int copies,string name,double price) {
        
            this.copies = copies;
            this.name = name;
            this.price = price;
       }

        public double Cost()
        {
            return copies * price;
        }

        public void Output()
        {
            Console.WriteLine($"Copies:{Copies}\nName {Name}\n Price 1st {price}\nCost {Cost():f1}");
        }
    }
}
