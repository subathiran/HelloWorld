using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name??");
            var test = Console.ReadLine();

            Console.WriteLine(String.Format("Hello World, {0}!", test));

            Console.ReadLine();
        }
    }
}
