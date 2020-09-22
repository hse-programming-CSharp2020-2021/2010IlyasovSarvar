using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать метод, вычисляющий значение функции G=F(X,Y) 
                 = 𝑋+sin⁡(𝑌),𝑋<𝑌 и 𝑋>0
            𝐺 =
                 = 𝑌−cos⁡(𝑋),𝑋>𝑌 и 𝑋<0
                 = 0.5∙𝑋∙𝑌, в остальных случаях)*/

            double x = 0, y = 0;
            string X, Y;

            EnterValues(out X, out Y);

            if (!Validation(X, Y, ref x, ref y))
            {
                Console.WriteLine("ERROR while entering values!");
            }
            else
            {
                Calculate(x, y);
            }

            ExitOrRepeat(args);
        }

        private static void EnterValues(out string X, out string Y)
        {
            //метод для ввода данных

            Console.Write("\r\nEnter value of X : ");
            X = Console.ReadLine();
            Console.Write("Enter value of Y : ");
            Y = Console.ReadLine();

            X = X.Replace(',', '.');
            Y = Y.Replace(',', '.');
        }

        private static void ExitOrRepeat(string[] args)
        {
            //метод чтобы выйти или повторить решение

            Console.WriteLine("Press ENTER to exit Console, or other button to repeat \r\n"); 
            
            //цикл повторения решения
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Main(args);
            }
        }

        private static bool Validation(string X, string Y, ref double x, ref double y)
        {
            //метод чтобы проверить правильное значение ввел пользователь или нет

            bool output = true;

            if (!double.TryParse(X, out x) || !double.TryParse(Y, out y))
            {
                output = false;
            }

            return output;
        }

        private static void Calculate(double x, double y)
        {
            //метод вычисляющий значение функции G = F(X, Y)

            double res = 0;

            if (x<y && x>0)
            {
                res = x + Math.Sin(y);
                Console.WriteLine($"G = X + sin(Y) is : {res}" );
            }
            else if(x>y && x<0)
            {
                res = y - Math.Cos(x);
                Console.WriteLine($"G = Y - cos(X) is : {res}");
            }
            else
            {
                res = 0.5 * x * y;
                Console.WriteLine($"G = 0.5∙X∙Y is : {res}");
            }
        }
    }
}
