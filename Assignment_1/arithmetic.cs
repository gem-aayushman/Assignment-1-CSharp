using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class arithmetic
    {
        public int compute(int num1, int num2, char op)
        {
            if (op == '+')
            {
                return num1 + num2;
            }
            else if (op == '-')
            {
                return num1 - num2;
            }
            else if (op == '/')
            {
                return num1 / num2;
            }
            else
            {
                return num1 * num2;
            }
        }
        public void solution()
        {
            Console.WriteLine("Enter data of set 1");
            Console.WriteLine("Enter 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator");
            char op1 = Console.ReadLine()[0];
            int result1 = compute(num1, num2, op1);
            Console.WriteLine("Enter data of set 2");
            Console.WriteLine("Enter 1st number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator");
            char op2 = Console.ReadLine()[0];
            int result2 = compute(num3, num4, op2);
            if (result1 == result2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
