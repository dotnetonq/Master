using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Cat", 1);
            dictionary.Add("Dog", 2);
            dictionary.Add("Tiger", 3);
            dictionary.Add("Elephant", 4);
            dictionary.Add("Deer", 5);

            Customer customer1 = new Customer() {Id=1,fname="uday",lname="Reddy" };
        }
    }

    public class Customer
    {
        public int Id;
        public string fname;
        public string lname;
    }
}
