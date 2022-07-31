using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывод чисел от 0 до 4
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //// Вывод чисел от 0 до 4
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //// Вывод четных чисел от 0 до 4 v1
            //for (int i = 0; i < 5; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //// Вывод четных чисел от 0 до 4 v2
            //for (int i = 0; i < 5; i++)
            //{
            //    if (i % 2 != 0)
            //        continue;

            //    Console.WriteLine(i);
            //}

            //Запрашиваем число, пока пользователь не введет значение больше нуля v1
            //while (true)
            //{
            //    string str = Console.ReadLine();

            //    if (Int32.Parse(str) > 0)
            //        break;
            //}

            // Запрашиваем число, пока пользователь не введет значение больше нуля v2
            string str;
            do
            {
                str = Console.ReadLine();
            } while (Int32.Parse(str) <= 0);
        }
    }
}
