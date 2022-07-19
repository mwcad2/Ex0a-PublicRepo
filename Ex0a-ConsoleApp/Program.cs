using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your PUBLIC name.");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            Console.ReadKey();
        }
    }
}
