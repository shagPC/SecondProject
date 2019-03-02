using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first");
            Console.WriteLine("second");
            Console.WriteLine("3");
            Console.WriteLine("4");

            HelloPrint.Print();
        }

        public void PrintAskar()
        {
            Console.WriteLine("Hello world!");
        }
    }
    public class HelloPrint
    {
        public static void Print()
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
    }
}
