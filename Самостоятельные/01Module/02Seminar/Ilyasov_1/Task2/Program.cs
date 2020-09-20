using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Ввести натуральное трехзначное число Р.Найти наибольшее целое число, 
            которое можно получить, переставляя цифры числа Р.*/

            int P = 0,
                a = 0,
                b = 0,
                c = 0;
            string input = "";

            Console.Write("\r\nEnter three-digit number : ");
            input = Console.ReadLine();

            if (!Validation(ref input, ref P))
            {
                Console.WriteLine("ERROR: Incorrect number, REENTER!");
            }
            else
            {
                FindingDigits(ref P, ref a, ref b, ref c, ref input);
                SortingValues(ref a, ref b, ref c);

                Console.WriteLine($"{a}{b}{c}");
            }

            Console.WriteLine("Press ENTER to exit Console, or other button to repeat \r\n"); //цикл повторения решения
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Main(args);
            }
        }

        public static bool Validation(ref string input, ref int P)
        {
            //метод чтобы проверить правильное число ввел пользователь или нет

            bool output = true;

            if (!int.TryParse(input, out P) || int.Parse(input) < 100 || int.Parse(input) > 999)
            {
                output = false;
            }

            return output;
        }
        public static void FindingDigits(ref int P, ref int a, ref int b, ref int c, ref string input)
        {
            //метод чтобы найти нужные нам числа
            a = P / 100;
            b = (P - a * 100) / 10;
            c = P - a * 100 - b * 10;
        }
        public static void SortingValues(ref int a, ref int b, ref int c)
        {
            // в этом методе создается массив в который входит три числа (которые ввел пользователь), и находит макс. и мин. чтобы их упорядочить

            int a1, a2, a3;
            int[] integers = { a, b, c };
            a1 = integers.Min();
            a3 = integers.Max();
            a2 = ((a1 == a && a3 == c) || (a1 == c && a3 == a)) ? (b) : (((a1 == a && a3 == b) || (a1 == b && a3 == a)) ? (c) : (((a1 == b && a3 == c) || (a1 == c && a3 == b)) ? (a) : (a)));

            a = a3;
            b = a2;
            c = a1;
        }

    }
}
