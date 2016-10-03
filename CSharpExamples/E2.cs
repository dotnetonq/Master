using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    public class E2
    {
        public void SwapNumbers()
        {
            int c1, c2, c3;

            Console.WriteLine("ENTER A NUMBER1:");
            c1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER A NUMBER2:");
            c2 = int.Parse(Console.ReadLine());

            c3 = c1;
            c1 = c2;
            c2 = c3;

            Console.WriteLine("SWAPPED NUMBER1:" + c1);
            Console.WriteLine("SWAPPED NUMBER2:" + c2);

            Console.ReadLine();
            

        }
        
    }
}
