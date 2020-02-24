using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobCandidate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Years of experience do you have?");

            var Years = 0;

            if (Years <= 0)
            {
                Console.WriteLine("You are a Inexperienced");
            }
            else if (Years == 1)
            {
                Console.WriteLine("You are a Junior");
            }
            else if (Years == 2)
            {
                Console.WriteLine("You are an Intermediate");
            }
            else if (Years == 3) 
            {
                Console.WriteLine("You are Advanced");
            }
            else if (Years >= 4)
            {
                Console.WriteLine("You are Senior");
            }

            Console.ReadLine();
        }
    }
}
