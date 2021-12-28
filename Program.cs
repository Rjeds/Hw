using System;
using System.Collections.Generic;
using System.Linq;

namespace Hw2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int size_y = 0;
            int size_x = 0;
            Console.WriteLine("Укажите расзмер массива");
            Console.WriteLine("Длина по Y");
            size_y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Длина по X");
            size_x = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[size_y, size_x];


            Zapolnenie(arr, size_y, size_x);
            Vivod(arr, size_y, size_x);


            bool exit = true;
            while (exit == true)
            {
                //Не работает ревёрст с отрицательными и полсе сортировки , проблемы не понял , было бы круто еслибы обяснил
                Console.WriteLine("1 - Количество положительных/отрицательных чисел в матрице");
                Console.WriteLine("2 - Сортировка элементов матрицы построчно (в двух направлениях)");
                Console.WriteLine("3 - Инверсия элементов матрицы построчно");
                Console.WriteLine("4 - Выход");
                Console.WriteLine();
                string n = Console.ReadLine();
                switch (n)
                {
                    case "1":
                        Search(arr, size_y, size_x);
                        break;
                    case "2":
                        Sort(arr, size_y, size_x);
                        Vivod(arr, size_y, size_x);
                        break;
                    case "3":
                        resev(arr, size_y, size_x);
                        Vivod(arr, size_y, size_x);
                        break;
                    case "4":
                        Console.WriteLine();
                        Console.WriteLine("Пока");
                        exit = false;
                        return;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Такого нет");
                        Console.WriteLine();
                        break;
                }
            }





        }

        public static void Vivod(int[,] arr, int size_y, int size_x)
        {
            Console.WriteLine();
            for (int i = 0; i < size_y; i++)
            {
                for (int j = 0; j < size_x; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Zapolnenie(int[,] arr, int size_y, int size_x)
        {
            Console.WriteLine("Заполните массив");
            for (int i = 0; i < size_y; i++)
            {
                for (int j = 0; j < size_x; j++)
                {
                    int zap = Convert.ToInt32(Console.ReadLine());
                    arr[i, j] = zap;
                }

            }
        }

        public static void Search(int[,] arr, int size_y, int size_x)
        {
            int number = 0;
            int number2 = 0;
            for (int i = 0; i < size_y; i++)
            {
                for (int j = 0; j < size_x; j++)
                {
                    if (arr[i, j] == 0) ;
                    else
                    if (arr[i, j] < 0)
                    {
                        number++;
                    }
                    else
                    {
                        number2++;
                    }

                }
            }
            Console.WriteLine($"Отрицательных: {number} ");
            Console.WriteLine($"Положительных: {number2} ");
            Console.WriteLine();

        }

        public static void Sort(int[,] arr, int size_y, int size_x)
        {
            Console.WriteLine("1-Сортировка слева");
            Console.WriteLine("2-Сортировка справа");
            Console.WriteLine();
            string narprav = Console.ReadLine();
            switch (narprav)
            {
                case "1":
                    for (int k = 0; k < size_x; k++)
                    {
                        for (int i = 0; i < size_y; i++)
                        {
                            for (int j = 0; j < size_x - 1; j++)
                            {

                                if (arr[i, j] > arr[i, j + 1])
                                {
                                    int per = arr[i, j];
                                    arr[i, j] = arr[i, j + 1];
                                    arr[i, j + 1] = per;
                                }
                            }
                        }
                    }
                    break;
                case "2":
                    for (int k = 0; k < size_x; k++)
                    {
                        for (int i = 0; i < size_y; i++)
                        {
                            for (int j = 0; j < size_x - 1; j++)
                            {

                                if (arr[i, j] < arr[i, j + 1])
                                {
                                    int per = arr[i, j];
                                    arr[i, j] = arr[i, j + 1];
                                    arr[i, j + 1] = per;
                                }
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Такого нет");
                    break;

            }


        }
        public static void resev(int[,] arr, int size_y, int size_x)
        {
            for (int k = 0; k < size_x; k++)
            {
                for (int i = 0; i < size_y; i++)
                {
                    for (int f = 0, l = size_x - 1; f < l; f++, l--)
                    {
                        int vrem = arr[i, f];
                        arr[i, f] = arr[i, l];
                        arr[i, l] = vrem;

                    }
                }
            }
        }

    }
}