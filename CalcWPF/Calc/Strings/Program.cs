using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Канкатенация строк
            string str1 = "Привет, ";
            string str2 = "мир!";

            string str = str1 + str2;
            // string str += str2;
            Console.WriteLine(str);


            // Длина строки
            int length = str1.Length;
            Console.WriteLine(length);

            // Символы
            char a = 'a';
            char b = 'b';
            int aInt = (int)a;
            int bInt = (int)b;
            char c = (char)((int)b + 1);

            for (int i = aInt; i <= (int)'z'; i++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine();

            // Доступ к элементу
            char cFirst = str[0];   // Первый символ
            char cLast = str[str.Length - 1];  // Последний символ

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();
            // П р и в е т , м и р !
            
            str = str.Remove(1, 1);
            Console.WriteLine();

            str = str.Remove(str.Length - 1, 1);
            Console.WriteLine();
        }
    }
}
