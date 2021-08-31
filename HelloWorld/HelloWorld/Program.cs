using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World :)");

            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            Console.WriteLine($"you are {input} years old, thats old");
            Console.ReadKey();
        }
    }
}
