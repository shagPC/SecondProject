﻿using System;
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

            List<Employee> emps = new List<Employee>()
            {
                new Employee("John", 32, 100000),
                new Employee("Mary", 25, 150000),
                new Employee("Phil", 21, 120000),
            };

            foreach (var item in emps)
            {
                item.PrintInfo();
            }
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
        public static void Print2()
        {
            Console.WriteLine("Введите фамилию");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }

        public static void Print4()
        {
            Console.WriteLine("Введите фамилию");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
    }
}
