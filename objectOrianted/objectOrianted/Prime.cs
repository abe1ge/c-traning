using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrianted
{
    class Prime
    {
        static int number = 100;

        //bool[] arr = new bool[number];

        public void print()
        {
        for (int i = 0; i <= number ; i++)
            {
                if (isPrime(i) == true) Console.WriteLine(i);
            }
        }

        public bool isPrime(int n)
        {

            if (n <= 1) return false;
            else if (n <= 3) return true;
            else if ((n % 2) == 0 || (n % 3) == 0) return false;

            int i = 5;

            while ((i * i) <= n )
            {
                if ((n % i == 0 || (n % (i + 2) == 0))) return false;
                i += 6;
            }

            return true;
        }

        
    }
}
