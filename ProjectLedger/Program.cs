using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLedger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum of two numbers 5 and 6 is: "+ Sum(5, 6));

            System.Threading.Thread.Sleep(1000);


        }

        public static int Sum (int a, int b)
        {
            return a + b; 
        }


    }
}
