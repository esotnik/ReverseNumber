using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string s = Console.ReadLine();
            Console.WriteLine("Ваше число в обратном виде");
            if (s[0] != '-')
                for (int i = s.Length - 1; i > -1; --i)
                    Console.Write((s[i]));
            else
            {
                Console.Write("-");
                for (int i = s.Length - 1; i > 0; --i)
                    Console.Write((s[i]));
            }
            Console.Read();
        }
    }
}
