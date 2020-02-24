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

            var Years = int.Parse(Console.ReadLine());

            switch (Years)
            {
                case 0:
                Console.WriteLine("You are a Inexperienced");
             break;

                case 1:
                    Console.WriteLine("You are a Junior");
                    break;

                case 2:
                    Console.WriteLine("You are an Intermediate");
                    break;

                case 3:
                    Console.WriteLine("You are Advanced");
                    break;

                default:
                    Console.WriteLine("You are a Senior");
                    break;

            }

            //Switch works better in this scenario than if else because too many cases here. 
            //if (Years <= 0)
            //{
            //    Console.WriteLine("You are a Inexperienced");
            //}
            //else if (Years == 1)
            //{
            //    Console.WriteLine("You are a Junior");
            //}
            //else if (Years == 2)
            //{
            //    Console.WriteLine("You are an Intermediate");
            //}
            //else if (Years == 3) 
            //{
            //    Console.WriteLine("You are Advanced");
            //}
            //else 
            //{
            //    Console.WriteLine("You are Senior");
            //}

           
        }
    }
}
