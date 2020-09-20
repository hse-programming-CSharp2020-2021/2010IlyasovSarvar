using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Получить от пользователя четырехзначное натуральное число и напечатать его цифры в обратном порядке.*/

            int abcd = 0,
                a = 0,
                b = 0,
                c = 0,
                d = 0;
            string input = "";

            Console.Write("\r\nEnter four-digit number : ");
            input = Console.ReadLine();

            if (!Validation(ref input, ref abcd))
            {
                Console.WriteLine("ERROR: Incorrect number, REENTER!");
            }
            else
            {
                FindingDigits(ref abcd, ref a, ref b, ref c, ref d, ref input);
                Console.WriteLine($"\r\nNew Number is {d}{c}{b}{a}\r\n");
            }

            Console.WriteLine("Press ENTER to exit Console, or other button to repeat \r\n"); //цикл повторения решения
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Main(args);
            }
        }

        public static bool Validation(ref string input, ref int abcd)
        {
            //метод чтобы проверить правильное число ввел пользователь или нет

            bool output = true;

            if (!int.TryParse(input, out abcd) || int.Parse(input) < 1000 || int.Parse(input) > 9999)
            {
                output = false;
            }

            return output;
        }
        public static void FindingDigits(ref int abcd, ref int a, ref int b, ref int c, ref int d, ref string input)
        {
            //метод чтобы найти нужные нам числа
            a = abcd / 1000;
            b = (abcd - a * 1000) / 100;
            c = (abcd - a * 1000 - b * 100) / 10;
            d = abcd - a * 1000 - b * 100 - c * 10;
        }
    }
}
