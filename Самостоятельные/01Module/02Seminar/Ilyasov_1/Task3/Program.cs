using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Введя значения коэффициентов А, В, С, вычислить корни квадратного уравнения.
            Учесть(как хотите) возможность появления комплексных корней. Оператор if не применять.*/

            double a = 0,
                   b = 0,
                   c = 0,
                   x1 = 0,
                   x2 = 0;
            string A = "", B = "", C = "";

            Console.Write("\r\nFormula: ax^2 + bx + c = 0 \r\nEnter value of A: ");
            A = Console.ReadLine();
            Console.Write("Enter value of B: ");
            B = Console.ReadLine();
            Console.Write("Enter value of C: ");
            C = Console.ReadLine();

            if(!Validation(ref a, ref b, ref c, A, B, C)) //тут без оператора if не обошлось
            {
                Console.WriteLine("ERROR while entering values!");
            }
            else
            {
                FindRoots(ref a, ref b, ref c, ref x1, ref x2);
            }

            Console.WriteLine("Press ENTER to exit Console, or other button to repeat \r\n"); //цикл повторения решения
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Main(args);
            }
        }

        public static bool Validation(ref double a, ref double b, ref double c, string A, string B, string C)
        {
            //метод чтобы определить правильное число ввел пользователь или нет

            bool output = true;

            output = (!double.TryParse(A, out a) || !double.TryParse(B, out b) || !double.TryParse(C, out c) || a == 0) ? false : true;

            return output;
        }
        public static void FindRoots(ref double a, ref double b, ref double c, ref double x1, ref double x2)
        {
            // метод чтобы найти корни квадратного уравнения
            double D = 0;

            D = b * b - (4 * a * c);
            
            if (D >= 0) //ну тут тоже без оператора if не обошлось
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine((x1 != x2) 
                    ? ($"\r\nx1 = {x1.ToString("f3")}, x2 = {x2.ToString("f3")}\r\n") 
                    : ($"\r\nx = {x1.ToString("f3")}\r\n"));
            }
            else
            {
                Console.WriteLine("\r\nThere is no roots\r\n");
            }
        }
    }
}
