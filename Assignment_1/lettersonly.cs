using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class lettersonly
    {
        public void solution()
        {
            string word;
            Console.WriteLine("Enter the string: ");
            word = Console.ReadLine();
            int flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'a' && word[i] <= 'z' || word[i] >= 'A' && word[i] <= 'Z' || word[i] == ' ')
                {
                    continue;
                }
                else
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
