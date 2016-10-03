using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpStation
{
    public class Child : Parent
    {
        public Child() : base("From Derived")
        {
            Console.WriteLine("Child Constructor");
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine("Child Class");
        }
    }

}
