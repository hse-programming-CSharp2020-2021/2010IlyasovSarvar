using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        /*Написать метод, вычисляющий логическое значение функции G=F(X,Y). 
        Результат равен true, если точка с координатами (X,Y) попадает в фигуру G, и результат равен false,
        если точка с координатами (X,Y) не попадает в фигуру G. Фигура G - сектор круга радиусом R=2 в 
        диапазоне углов -90<= fi <=45.*/

        static void Main(string[] args)
        {
            double xPoint = 0, yPoint = 0;
            string xStr, yStr;

            Console.WriteLine("\r\nR = 2, and sector is between -90 <= fi <= 45");
            EnterValues(out xStr, out yStr);

            if (!Validation(xStr, yStr, ref xPoint, ref yPoint))
            {
                Console.WriteLine("ERROR while entering values! \a");
            }
            else
            {
                PointBelong(xPoint, yPoint);
            }

            ExitOrRepeat(args);
        }

        private static bool Validation(string xStr, string yStr, ref double xPoint, ref double yPoint)
        {
            //метод проверяющий правильно ввел ли данные пользователь или нет

            bool output = true;

            if (!double.TryParse(xStr, out xPoint) || !double.TryParse(yStr, out yPoint))
            {
                output = false;
            }

            return output;
        }

        private static void EnterValues(out string xStr, out string yStr)
        {
            //метод чтобы пользователь ввел значения

            Console.Write("To know is point belong to sector or not \r\nEnter value of X : ");
            xStr = Console.ReadLine();
            Console.Write("Enter value of Y : ");
            yStr = Console.ReadLine();
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

        private static void PointBelong(double x, double y)
        {
            //метод проверяющий входит ли точка в сектор или нет, если да то выводится true, если нет то false

            double atan = Math.Atan2(y, x);
            if (x * x + y * y <= 4 && -0.5 * Math.PI <= atan && atan <= 0.25 * Math.PI)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
