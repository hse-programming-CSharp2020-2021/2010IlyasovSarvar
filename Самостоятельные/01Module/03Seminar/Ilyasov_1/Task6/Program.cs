using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Трехзначным целым числом кодируется номер аудитории в учебном корпусе. 
            Старшая цифра обозначают номер этажа, а две младшие –  номер аудитории на этаже. 
            Из трех аудиторий определить и вывести на экран ту аудиторию, которая имеет минимальный номер внутри этажа. 
            Если таких аудиторий несколько - вывести любую из них. */

            int first = 0, second = 0, third = 0;
            string firstString, secondString, thirdString;

            Console.WriteLine("\r\nEnter three three-digit value in which first digit is number of the floor, \r\nand second & third digits are number of audience");
            EnterValues(out firstString, out secondString, out thirdString);

            if (!Validation(ref first, ref second, ref third, firstString, secondString, thirdString))
            {
                Console.WriteLine("ERROR while entering values\a");
            }
            else
            {
                FindMin(first, second, third);
            }

            ExitOrRepeat(args);
        }

        private static bool Validation(ref int first, ref int second, ref int third, string firstString, string secondString, string thirdString)
        {
            //метод чтобы проверить правильное значение ввел пользователь или нет

            bool output = true;

            if (!int.TryParse(firstString, out first) || !int.TryParse(secondString, out second) || !int.TryParse(thirdString, out third) || first <= 100 || first > 999 || second <= 100 || second > 999 || third <= 100 || third > 999)
            {
                output = false;
            }

            return output;
        }

        private static void FindMin(int x, int y, int z)
        {
            //метод чтобы определить минимальный номер внутри этажа

            int a = x % 100,
                b = y % 100,
                c = z % 100;
            int[] array = { a, b, c };

            if (array.Min() == a && array.Min() == b && array.Min() == c)
            {
                Console.WriteLine($"Minimum numbers of audience are {x} and {y} and {z}");
            }
            else if (array.Min() == a && array.Min() == b)
            {
                Console.WriteLine($"Minimum numbers of audience are {x} and {y}");
            }
            else if (array.Min() == a && array.Min() == c)
            {
                Console.WriteLine($"Minimum numbers of audience are {x} and {z}");
            }
            else if (array.Min() == c && array.Min() == b)
            {
                Console.WriteLine($"Minimum numbers of audience are {y} and {z}");
            }
            else if (array.Min() == a)
            {
                Console.WriteLine("Minimum number of audience is "+ x);
            }
            else if (array.Min() == b)
            {
                Console.WriteLine("Minimum number of audience is " + y);
            }
            else if (array.Min() == c)
            {
                Console.WriteLine("Minimum number of audience is " + z);
            }
        }

        private static void EnterValues(out string firstString, out string secondString, out string thirdString)
        {
            //метод чтобы пользователь ввел значения

            Console.Write("First three-digit number : ");
            firstString = Console.ReadLine();
            Console.Write("Second three-digit number : ");
            secondString = Console.ReadLine();
            Console.Write("Third three-digit number : ");
            thirdString = Console.ReadLine();
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
