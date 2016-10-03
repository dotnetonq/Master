using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Print();
            ((Parent)child).Print();
        }
    }
}
