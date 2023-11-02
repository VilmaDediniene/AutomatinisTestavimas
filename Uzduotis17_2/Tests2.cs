using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis17_2
{
    public class Tests2
    {
        [Test]

        public static void Main()  
        {

            DateTime currentTime = DateTime.Now;

            // Check if it is 13:00 (1:00 PM)
            if (currentTime.Hour == 13 && currentTime.Minute == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("It is 13 o'clock now!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("It is not 13 o'clock yet.");
            }
        }
    }
}

