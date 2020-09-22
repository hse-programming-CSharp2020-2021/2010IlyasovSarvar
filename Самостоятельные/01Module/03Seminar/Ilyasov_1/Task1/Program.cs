using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать метод, находящий трехзначное десятичное число s, все цифры которого 
            одинаковы и которое представляет собой сумму первых членов натурального ряда, 
            то есть s = 1+2+3+4+… Вывести полученное число, количество членов ряда и условное 
            изображение соответствующей суммы, в которой указаны первые три и последние три члена, 
            а средние члены обозначены многоточием. Например, если последний член равен 25, 
            то вывести: 1+2+3+…+23+24+25.*/

            FindNumber();
            ExitOrRepeat(args);
        }

        private static void FindNumber()
        {
            //метод находящий трехзначное десятичное число S

            int n = 1;
            
            while ( (n*(n + 1) / 2) % 111 != 0 )
            {
                n++;
            }

            int S = n * (n + 1) / 2;

            Console.WriteLine($"Our number is {S}, and n is {n} \r\n1 + 2 + 3 + ... + {n-2} + {n-1} + {n} = {S}");
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