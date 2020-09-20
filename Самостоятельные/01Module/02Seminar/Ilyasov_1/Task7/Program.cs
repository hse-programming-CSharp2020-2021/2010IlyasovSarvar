using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Написать программу с использованием двух методов. Первый метод возвращает дробную и целую часть числа. 
            Второй метод возвращает квадрат и корень из числа. В основной программе пользователь вводит дробное число.
            Программа должна вычислить, если это возможно, значение корня, квадрата числа, выделить целую и дробную часть из числа.*/

            string input = "";
            double num = 0;

            Console.Write("Write value of X : ");
            input = Console.ReadLine();

            if (!double.TryParse(input, out num)) //проверка правильно ввел ли пользователь число или нет
            {
                Console.WriteLine("ERROR: entered incorrect number");
            }
            else
            {
                FindParts(num);
                Calculate(num);
            }

            Console.WriteLine("\r\nPress ENTER to exit Console, or other button to repeat \r\n"); //цикл повторения решения
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Main(args);
            }
        }

        public static void FindParts(double num)
        {
            //метод возвращает дробную и целую часть числа
            int a = (int)num;
            double b = num - a;

            Console.WriteLine($"\r\nIntegral part is {a}, and fractrional part is {b:f3}");
        }

        public static void Calculate(double num)
        {
            //метод возвращает квадрат и корень из числа
            double pow = num * num;
            double sqrt;

            if (num >= 0)
            {
                sqrt = Math.Sqrt(num);
                Console.WriteLine($"\r\nX^2 is {pow:f3}, and square root of X is {sqrt:f3}");
            }
            else
            {
                Console.WriteLine($"\r\nX^2 is {pow:f3}, and no square root because X is less than zero");
            }
        }
    }
}
