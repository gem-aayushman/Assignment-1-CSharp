using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class passwordcheck
    {
        public void solution()
        {
            string user = "username";
            string pwd = "password";
            int ctr = 0;
            string uid;
            string p;
            while (ctr < 3)
            {
                Console.WriteLine("Enter username");
                uid = Console.ReadLine();
                Console.WriteLine("Enter password");
                p = Console.ReadLine();
                if (uid == user && p == pwd)
                {
                    Console.WriteLine("Success!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong credentials!");
                    ctr += 1;
                }
            }
            if (ctr == 3)
            {
                Console.WriteLine("User was rejected after 3 failed attempts");
            }

        }
    }
}
