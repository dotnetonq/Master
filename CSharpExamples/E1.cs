using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    public class E1
    {
        static void Main(string[] args)
        {
            E8 e8 = new E8();
            e8.insert(10);
            Console.WriteLine("Data : {0}", e8.data);
            Console.WriteLine("Data : {0}", e8.delete());
            Console.ReadLine();

        }

        //public string void GetNumber()
        //{
        //    int i;
            
        //    Console.WriteLine("Enter A Number");

        //    i = int.Parse(Console.ReadLine());

        //    if(i%2 == 0)
        //    {
        //        Console.WriteLine("Entered Number Is EVEN");

        //        Console.Read();
        //    }

        //    else
        //    {
        //        Console.WriteLine("Entered Number Is ODD");

        //        Console.Read();
        //    }
        //}
    }
}
