using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrianted
{
    class Program
    {
       
        static void Main(string[] args)
        {


            Prime calculate = new Prime();

            calculate.print();

           // Console.WriteLine(calculate.isPrime(37));

            ////delegation
            //Delegation.Ops cal = (x, y) =>
            //{
            //    Console.WriteLine(x + y);
            //    Console.WriteLine(x * y);
            //    Console.WriteLine(x / y);
            //};

            
            
        }
    }
}
