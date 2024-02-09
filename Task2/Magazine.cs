using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Magazine : Press
    {
        string quality;
        public string Quality { get => quality; set => quality = value; }

        public Magazine() { }

        public Magazine(int copies,string name,double price,string quality) :base(copies, name,price)
        { 
            this.quality = quality;
        }

        public new double Cost()
        {
            base.Cost();
            if (quality == "высокое")
            {
                base.Cost();
            }

        }

    }
}
