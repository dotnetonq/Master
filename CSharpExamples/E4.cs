using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
   public class E4
    {
       int y;

       public void readdate()
       {
           Console.WriteLine("Enter the year in 4 digits");
           y = Convert.ToInt32(Console.ReadLine());
       }

       public void leap()
       {
           //if((y % 4 == 0 && y % 100! = 0) || (y % 400 == 0))
             if((y % 4 == 0 && y % 100!= 0) || (y % 400 == 0))
           {
               Console.WriteLine("{0} is a leap year",y);
           }
           else
           {
               Console.WriteLine("{0} is a leap year",y);
           }
            Console.ReadLine();
       }
       

    }
}
