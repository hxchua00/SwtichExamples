using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwtichExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose from the options: ");
            Console.WriteLine("Option 1");
            Console.WriteLine("Option 2");
            Console.WriteLine("Option 3");

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();


            switch (input)
            {
                case 1:
                    Console.WriteLine("I'm at Option 1");
                    break;
                case 2:
                    Console.WriteLine("I'm at Option 2");
                    break;
                case 3:
                    Console.WriteLine("I'm at Option 3");
                    break;
                default:
                    Console.WriteLine("Please choose from the option available!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
