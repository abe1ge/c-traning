using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrianted
{
     class Delegation
    {
        public delegate void Ops(int a, int b);

        public void add(int a, int b)
        {
            Console.WriteLine("addition:" + a + " + " + b + "=" + (a + b));
        }

        public void subtract(int a, int b)
        {
            Console.WriteLine("subtract:" + a + " - " + b + "=" + (a - b));
        }

        public void devide(int a, int b)
        {
            Console.WriteLine("devide:" + a + " / " + b + "=" + (a / b));
        }

        public void multiply(int a, int b)
        {
            Console.WriteLine("multiply:" + a + " x " + b + "=" + (a * b));
        }

        
    }
}
