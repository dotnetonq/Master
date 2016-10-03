using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    public class E5
    {
        private int x;
        protected int y;
        internal int z;
        public int a;
        protected internal int b;
    }

    public class E6 : E5
    {
        public void show()
        {
            //x=10;
            y = 20;
            z = 30;
            a = 40;
            b = 50;

            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
