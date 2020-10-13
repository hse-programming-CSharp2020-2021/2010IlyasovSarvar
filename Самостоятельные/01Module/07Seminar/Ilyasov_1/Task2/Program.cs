using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = "input.txt";
            string outputFilePath = "output.txt";
            int lengthOfArray;

            Console.Write("Enter length of array you want to create : ");
            string inputNumber = Console.ReadLine();

            if (!Validation(inputNumber, out lengthOfArray))
            {
                Console.WriteLine("Incorrect Input");
            }
            else
            {
                CreateAndWriteArray(inputFilePath, lengthOfArray);
                ReWriteArray(inputFilePath, outputFilePath, lengthOfArray);
            }

        }

        private static void ReWriteArray(string input, string output, int num)
        {
            // Метод чтобы переписать массив который мы создали раннее, и переписать его в булевский массив, и сохранить его в "output.txt".

            string[] oldArray = File.ReadAllLines(input);
            int[] numArray = new int[num];
            string[] newArray = new string[num];

            for (int i = 0; i < num; i++)
            {
                numArray[i] = int.Parse(oldArray[i]);
            }
            
            for (int i = 0; i < num; i++)
            {
                int checkNumber = 1;

                if (numArray[i] == 0)
                {
                    newArray[i] = "1";
                }
                else
                {
                    while(checkNumber < numArray[i])
                    {
                        checkNumber *= 2;
                    }

                    if (checkNumber == numArray[i])
                    {
                        newArray[i] = $"{checkNumber}";
                    }
                    else
                    {
                        newArray[i] = $"{checkNumber / 2}";
                    }
                }
            }

            File.WriteAllLines(output, newArray);
        }

        private static void CreateAndWriteArray(string path, int num)
        {
            // Метод чтобы создать массив, числа которого в диапозоне [0, 10000], и пишем этот массив в наш "input.txt".

            Random randomNum = new Random();
            string[] arrayNum = new string[num];

            for (int i = 0; i < num; i++)
            {
                arrayNum[i] = $"{randomNum.Next(0, 10001)}";
            }

            File.WriteAllLines(path, arrayNum);
        }

        private static bool Validation(string input, out int num)
        {
            // Метод чтобы проверить правильное значение ввел пользователь или нет.

            bool output = true;

            if (!int.TryParse(input, out num))
            {
                output = false;
            }

            return output;
        }
    }
}
