using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Ввести значение x и вывести значение полинома: F(x) = 12x4 + 9x3 - 3x2 + 2x – 4.
            Не применять возведение в степень. Использовать минимальное количество операций умножения.*/

            double x = 0,
                   answer = 0;
            string input = "";

            Console.Write("\r\nFormula is F(x) = 12x^4 + 9x^3 - 3x^2 + 2x – 4. \r\nEnter value of X: ");
            input = Console.ReadLine();

            if (!Validation(ref x, ref input))
            {
                Console.WriteLine("ERROR while entering values!");
            }
            else
            {
                Formula(ref x, ref answer);

                Console.WriteLine("F(x) = " + answer.ToString("f3"));
            }

            Console.WriteLine("Press ENTER to exit Console, or other button to repeat \r\n"); //цикл повторения решения
            while(Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Main(args);
            }
        }

        public static bool Validation(ref double x, ref string input)
        {
            //метод чтобы определить правильное число ввел пользователь или нет
            
            bool output = true;

            if (!double.TryParse(input, out x))
            {
                output = false;
            }

            return output;
        }
        public static void Formula(ref double x, ref double answer)
        {
            //метод чтобы высчитать ответ
            answer = x * (x * (x * (12 * x + 9) - 3) + 2) - 4;
        }
    }
}
