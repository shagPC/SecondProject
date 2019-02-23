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

            int firstNumber;
            int secondNumber;

            Int32.TryParse(Console.ReadLine(), out firstNumber);
            Int32.TryParse(Console.ReadLine(), out secondNumber);

            if(firstNumber > secondNumber)
            {
                Console.WriteLine("first");
            }
            else
            {
                Console.WriteLine("second");
            }

        }
    }
}
