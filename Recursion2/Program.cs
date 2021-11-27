using System;

namespace Recursion2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int number = 0;
            Recursion(text, number);
        }

        public static void Recursion(string text, int number)
        {
            if(number == text.Length - 1)
            {
                Console.Write(text[(text.Length - 1) - number]);
            }
            else
            {
                Console.Write(text[(text.Length - 1) - number]);
                number++;
                Recursion(text, number);
            }
        }
    }
}
