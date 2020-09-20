using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Task6
{
    class Program
    {
        public static void Main(string[] args)
        {

            /*Получить от пользователя вещественное значение – бюджет пользователя и целое число – процент бюджета, 
            выделенный на компьютерные игры.Вычислить и вывести на экран сумму в рублях\евро или долларах, выделенную 
            на компьютерные игры. Использовать спецификаторы формата для валют.*/

            double budget = 0;
            int percentage = 0;
            string Budget = "", Percentage = "";

            Console.Write("\r\nYour budget is : ");
            Budget = Console.ReadLine();
            Console.WriteLine("Percentage of your budget which is for playing games (Enter integer)");
            Percentage = Console.ReadLine();

            if (!Validation(ref budget, ref percentage, Budget, Percentage))
            {
                Console.WriteLine("ERROR while entering values");
            }
            else
            {
                Calculate(budget, percentage);
            }

            Console.WriteLine("\r\nPress ENTER to exit Console, or other button to repeat \r\n"); //цикл повторения решения
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Main(args);
            }
        }

        public static bool Validation(ref double budget, ref int percentage, string Budget, string Percentage)
        {
            //метод чтобы проверить правильное число ввел ли пользователь или нет

            bool output = true;

            if (!double.TryParse(Budget, out budget) || !int.TryParse(Percentage, out percentage) || percentage < 0 || percentage > 100)
            {
                output = false;
            }

            return output;
        }
        public static void Calculate(double budget, int percentage)
        {
            //метод чтобы вычислить сумму выделенную для комп. игр

            double S = budget * percentage / 100;
            Console.WriteLine($"Your budget for playing games is {S:f3}$");
        }
    }
}
