using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrianted
{
    class Prime
    {
        int number = 100;

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

    class PrimeTwo
    {
        bool[] number = new bool[50];
        
        public void calculate(int n)
        {
            int i = 2;

            while (i != n)
            { 
                if (number[i] == false)
                {
                    Console.WriteLine(i);

                    for (int x = 2; x < n; x++)
                    {
                        int result = i * x;
                        
                        if (result >= n)
                        {
                            break;
                        }
                        else
                        {
                            try
                            {
                                number[result] = true;
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                break;
                            }
                            
                        }
                    }
                }
                i++;
            }

        }


    }
}
