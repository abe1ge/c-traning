using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberReader
{
    class change
    {

        public double giveChange(double cost, double given)
        {
            if (cost > given)
            {
                Console.WriteLine("more money is required");
            } 
            else
            {
                double leftover = Math.Round(given - cost , 2);

                Console.WriteLine("Total change is £" + leftover);
                if (leftover >= 20)
                {
                    Console.WriteLine( "£20      :"+ Math.Floor(leftover / 20));
                    leftover = leftover % 20;
                }
                if (leftover >= 10)
                {
                    Console.WriteLine("£10      :" + Math.Floor(leftover / 10));
                    leftover = leftover % 10;
                }
                if (leftover >= 5)
                {
                    Console.WriteLine("£5       :" + Math.Floor(leftover / 5));
                    leftover = leftover % 5;
                }
                if (leftover >= 2)
                {
                    Console.WriteLine("£2       :" + Math.Floor(leftover / 2));
                    leftover = leftover % 2;
                }
                if (leftover >= 1)
                {
                    Console.WriteLine("£1       :" + Math.Floor(leftover / 1));
                    leftover = leftover % 1;
                }
                if (leftover >= 0.5)
                {
                    Console.WriteLine("50p      :" + Math.Floor(leftover / 0.5));
                    leftover = leftover % 0.5;
                }
                if (leftover >= 0.2)
                {
                    Console.WriteLine("20p      :" + Math.Floor(leftover / 0.2));
                    leftover = Math.Round(leftover % 0.2, 2);
                }
                if (leftover >= 0.1)
                {
                    Console.WriteLine("10p      :" + Math.Ceiling(leftover / 0.1));
                    leftover = Math.Round(leftover % 0.1);
                }
                if (leftover >= 0.05)
                {
                    Console.WriteLine("5p       :" + Math.Ceiling(leftover / 0.05));
                    leftover = Math.Round(leftover % 0.05);
                }
                if (leftover >= 0.02)
                {
                    Console.WriteLine("2p       :" + Math.Ceiling(leftover / 0.02));
                    leftover = Math.Round(leftover % 0.02);
                }
                if (leftover >= 0.01)
                {
                    Console.WriteLine("1p       :" + Math.Ceiling(leftover / 0.01));
                    leftover = leftover % 0.01;
                }
            }
            
            return 0.0;
        }
    }
}
