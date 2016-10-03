using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    public class E8
    {
       public int data;

       public void insert(object x)
        {
            data = (int)x * 5;
        }

       public object delete()
        {
            data = 0;
            return (object)data;
        }
    }
}
