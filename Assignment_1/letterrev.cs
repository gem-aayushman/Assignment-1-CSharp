using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class letterrev
    {
        public void solution()
        {
            Console.WriteLine("Enter three letters: ");
            var arr = Console.ReadLine();
            var arrList = arr.Split(' ');
            Console.WriteLine("Letters in reverse are: ");
            for (int i = arrList.Length - 1; i >= 0; i--)
            {
                Console.Write(arrList[i] + " ");
            }
        }
    }
}
