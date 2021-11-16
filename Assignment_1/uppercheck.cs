using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class uppercheck
    {
        public void solution()
        {
            int flag = 0;
            string word;
            Console.WriteLine("Enter the word to check");
            word = Console.ReadLine();
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsUpper(word[i]) == true)
                {
                    continue;
                }
                if (Char.IsDigit(word[i]))
                {
                    flag = 1;
                    break;
                }
                foreach (var item in specialChar)
                {
                    if (word.Contains(item))
                    {
                        flag = 1;
                        break;
                    }
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

        }
    }
}
