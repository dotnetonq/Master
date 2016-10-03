using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    public class E3
    {
        public void ReverseNumber()
        {
            int num, reverse = 0;

            Console.WriteLine("Enter a number:");

            num = int.Parse(Console.ReadLine());

            while(num !=0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }

            Console.WriteLine("Entered reverse number is:" + reverse);

            Console.ReadLine();
        }
    }
}
