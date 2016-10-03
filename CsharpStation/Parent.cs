using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpStation
{
    public class Parent
    {
        string parentString;

        public Parent()
        {
            Console.WriteLine("Parent Constructor");
        }

        public Parent(string myString)
        {
            parentString = myString;
            Console.WriteLine(parentString);
        }

        public void Print()
        {
            Console.WriteLine("I am parent class");
        }
    }
}
