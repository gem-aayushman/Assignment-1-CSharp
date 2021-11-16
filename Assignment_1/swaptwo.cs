using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class swaptwo
    {
        public void solution()
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int temp;
            Console.WriteLine("Numbers before swapping");
            Console.WriteLine("First Number is {0}", num1);
            Console.WriteLine("Second Number is {0}", num2);
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Numbers after swapping");
            Console.WriteLine("First Number is {0}", num1);
            Console.WriteLine("Second Number is {0}", num2);
        }
    }
}
