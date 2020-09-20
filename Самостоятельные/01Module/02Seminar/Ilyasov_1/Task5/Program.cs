using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Получить от пользователя три вещественных числа и проверить для них неравенство треугольника. 
            Оператор if не применять.Точность вывода три знака после запятой.*/

            double a = 0, b = 0, c = 0;
            string A = "", B = "", C = "";

            Console.Write("\r\nTriangle Inequality Theorem \r\nEnter first side of triangle   : ");
            A = Console.ReadLine();
            Console.Write("\r\nTriangle Inequality Theorem \r\nEnter another side of triangle : ");
            B = Console.ReadLine();
            Console.Write("\r\nTriangle Inequality Theorem \r\nEnter last side of triangle    : ");
            C = Console.ReadLine();

            if (!Validation(ref a, ref b, ref c, A, B, C)) //тут без оператора if не обошлось
            {
                Console.WriteLine("ERROR while entering values!");
            }
            else
            {
                Theorem(a, b, c);
            }

            Console.WriteLine("Press ENTER to exit Console, or other button to repeat \r\n"); //цикл повторения решения
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Main(args);
            }
        }

        public static bool Validation(ref double a, ref double b, ref double c, string A, string B, string C)
        {
            //метод чтобы проверить правильные значения ввел пользователь или нет
            
            bool output;

            output = (!double.TryParse(A, out a) || !double.TryParse(B, out b) || !double.TryParse(C, out c)) ? (false) : (true);

            return output;
        }
        public static void Theorem(double a, double b, double c)
        {
            //этот метод будет проверять существует ли треугольник с такими сторонами            

            string theorem = ((a<b+c) || (b<a+c) || (c<a+b)) ? ($"A triangle could have side lengths as {a:f3}, {b:f3} and {c:f3}") : ("A triangle cannot have these side lengths as {a:f3}, {b:f3} and {c:f3}");
            Console.WriteLine($"\r\n{theorem}\r\n");
        }
    }
}
