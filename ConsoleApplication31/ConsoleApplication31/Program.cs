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
            Int32.TryParse(Console.ReadLine(), out firstNumber);
            Int32.TryParse(Console.ReadLine(), out secondNumber);

            bool isCompare = CompareTwoNumbers(firstNumber, secondNumber);

            if(isCompare)
            {
                Console.WriteLine("first");
            }
            else
            {
                Console.WriteLine("second");
            }

        }

        public static bool CompareTwoNumbers(int firstNum, int secondNum)
        {
            if (firstNum > secondNum || firstNum == secondNum)
            {
                return true;
            }
            else
            {
                return false; 
            }
            Console.WriteLine("first");
            Console.WriteLine("second");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("5");
        }

        public void PrintAskar()
        {
            Console.WriteLine("Hello world!");
        }
    }

    
}
