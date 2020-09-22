using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать метод, вычисляющий значение функции G=F(X) 
                =(sin⁡(𝜋/2), 𝑋 ≤ 0.5 
            𝐺=
                =sin⁡((𝜋∙(𝑥−1))/2), 𝑋 > 0.5 */

            string X;
            double x;

            EnterValue(out X);

            if (!Validation(X, out x))
            {
                Console.WriteLine("ERROR while entering values!");
            }
            else
            {
                Calculate(x);
            }

            ExitOrRepeat(args);
        }

        private static void EnterValue(out string X)
        {
            //метод для ввода данных

            Console.Write("\r\nEnter value of X : ");
            X = Console.ReadLine();

            X = X.Replace(',', '.');
        }

        private static bool Validation(string X, out double x)
        {
            //метод чтобы проверить правильное значение ввел пользователь или нет

            bool output = true;

            if (!double.TryParse(X, out x))
            {
                output = false;
            }

            return output;
        }

        private static void Calculate(double x)
        {
            //метод вычисляющий значение функции G=F(X)

            double res;

            if (x <= 0.5)
            {
                res = Math.Sin(Math.PI / 2);
                Console.WriteLine("G = sin(pi/2) = " + res);
            }
            else
            {
                res = Math.Sin(Math.PI * (x - 1) / 2);
                Console.WriteLine("G = sin((pi∙(x-1))/2) = " + res);
            }
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
