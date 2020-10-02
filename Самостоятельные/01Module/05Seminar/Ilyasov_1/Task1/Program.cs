using System;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstA;

            Console.Write("Enter first number of array : ");

            if (!int.TryParse(Console.ReadLine(), out firstA))
            {
                Console.WriteLine("Incorrect input");
            }
            else
            {
                FormArray(firstA);
            }

            ExitOrRepeat(args);
        }

        private static void ExitOrRepeat(string[] args)
        {
            // Метод чтобы выйти из консоли или повторить решение.

            Console.WriteLine("Press Escape to exit, or other button to repeat");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Main(args);
            }
        }

        private static void FormArray(int firstA)
        {
            // Метод чтобы сформировать массив(лист).

            List<int> integers = new List<int>();
            integers.Add(firstA);

            while (firstA != 1)
            {
                firstA = firstA % 2 == 0 ? firstA / 2 : 3 * firstA + 1;
                integers.Add(firstA);
            }

            Print(integers);
        }

        private static void Print(List<int> integers)
        {
            // Метод чтобы вывести на экран полученный массив.

            for (int i = 0; i < integers.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write($"[{i}] =\t{integers[i]}\t");
                }
                else if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine($"[{i}] =\t{integers[i]}");
                }
                else
                {
                    Console.Write($"[{i}] =\t{integers[i]}\t");
                }
            }
            Console.WriteLine();
        }
    }
}
