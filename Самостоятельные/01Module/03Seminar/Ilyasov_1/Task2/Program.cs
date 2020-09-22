using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать метод, преобразующий число переданное в качестве параметра в число, 
            записанное теми же цифрами, но идущими в обратном порядке. */

            int num = 0;
            string input;

            Console.Write("Write any integer : ");
            input = Console.ReadLine();

            if (!Validation(input, ref num)) //проверка ввода
            {
                Console.WriteLine("Incorrect input");
            }
            else
            {
                FindNumber(num);
            }

            ExitOrRepeat(args);
        }

        private static bool Validation(string input, ref int num)
        {
            //метод чтобы проверить правильное значение ввел пользователь или нет

            bool output = true;

            if (!int.TryParse(input, out num))
            {
                output = false;
            }

            return output;
        }

        private static void FindNumber(int num)
        {
            //метод чтобы написать введенное число в обратном порядке

            int digit = (int)Math.Ceiling(Math.Log10(num));
            int[] digits = new int[digit];
            double res = 0;

            Console.Write($"{num} => ");

            for (int i = 0; i < digit; i++)
            {
                digits[i] = num % 10;
                num = (num - (num % 10)) / 10;
                res = res + Math.Pow(10, digit - i - 1) * digits[i];
            }

            Console.WriteLine((int)res);
        }

        private static void ExitOrRepeat(string[] args)
        {
            //метод чтобы выйти или повторить решение

            Console.WriteLine("Press ENTER to exit Console, or other button to repeat \r\n"); //цикл повторения решения
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Main(args);
            }
        }

    }
}
