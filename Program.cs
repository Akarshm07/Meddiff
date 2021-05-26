using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string abc = Console.ReadLine().ToLower();
            int count = 0;
            if (abc.Length > 0)
            {
                for (int i = 0; i < abc.Length; i++)
                {
                    if (abc[i] == abc[((abc.Length - 1) - i)])
                    {
                        count++;
                    }
                }

                if (abc.Length == count)
                {
                    Console.WriteLine(abc + " is a Palindrome");
                }
                else
                {
                    Console.WriteLine(abc + " is not a Palindrome");
                }
            }
        }
    }
}
