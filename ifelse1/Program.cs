using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else if (num % 2 == 1)
            {
              Console.WriteLine("number is odd");
            }
            else
            {
              Console.WriteLine("input is wrong");
            }

        }
    }
}
