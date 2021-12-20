using System;
using System.Collections.Generic;
using System.Linq;

namespace Hw1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string num2;
            short st = 1;
            Console.Write("Введите номер дня недели:");
            num2 = Console.ReadLine();
            D1(num2);

            Console.ReadKey();

        }
        public static void D1(string n)
        {
            switch (n)
            {
                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Нет такого");
                    break;

            }

        }

        //"Говно" код
        public static void Dn2()
        {
            short num;
            short st = 1;
            while (st == 1)
            {
                Console.Write("Введите номер дня недели:");
                num = Convert.ToInt16(Console.ReadLine());

                if (num == 1)
                {
                    Console.WriteLine("Monday");
                    st = 2;
                }
                if (num == 2)
                {
                    Console.WriteLine("Tuesday");
                    st = 2;
                }
                if (num == 3)
                {
                    Console.WriteLine("Wednesday");

                    st = 2;
                }
                if (num == 4)
                {
                    Console.WriteLine("Thursday");

                    st = 2;
                }
                if (num == 5)
                {
                    Console.WriteLine("Friday");
                    st = 2;
                }
                if (num == 6)
                {
                    Console.WriteLine("Saturday");
                    st = 2;

                }
                if (num == 7)
                {
                    Console.WriteLine("Sunday");
                    st = 2;
                }
                if (num != 1 | num != 2 | num != 3 | num != 4 | num != 5 | num != 6 | num != 7)
                {
                    Console.WriteLine("Такого нет");
                }
            }
        }
    }
}