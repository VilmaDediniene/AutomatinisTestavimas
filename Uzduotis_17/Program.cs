using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 995;
            int number2 = 3;

            if (Calculator2.Divide(number1, number2) == 331 )
            {
                Console.WriteLine($"Dividion of {number1} and {number2} works as expected");
            }
        }
    }

    internal class Calculator2
    {

        static public double Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
