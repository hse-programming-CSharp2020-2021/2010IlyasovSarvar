using System;
using System.Collections.Generic;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.Write("Enter length of array : ");

            if (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Incorrect input");
            }
            else
            {
                List<int> integers = MakeArray(N);
                ArraySqueeze(integers);
                Print(integers);
            }

            ExitOrRepeat(args);
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

        private static void ArraySqueeze(List<int> integers)
        {
            // Метод чтобы сжать наш массив(список).

            for (int i = 0; i < integers.Count; i++)
            {
                if ((integers[i] + integers[i + 1]) % 3 == 0)
                {
                    integers[i] = integers[i] * integers[i + 1];
                    integers.Remove(integers[i + 1]);
                }
            }
        }

        private static List<int> MakeArray(int N)
        {
            // Метод чтобы создать массив(список).

            Random generator = new Random();
            List<int> integers = new List<int>();

            for (int i = 0; i < N; i++)
            {
                integers.Add(generator.Next(-10, 11));
            }

            return integers;
        }
    }
}
