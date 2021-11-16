using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Checkrange
    {
        public void solution()
        {
            Console.Write("Input a first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(((num1 >= -10 && num1 <= 10)) || ((num2 >= -10 && num2 <= 10)));

        }
    }
}
