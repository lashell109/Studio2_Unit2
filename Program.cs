using System;
using System.Globalization;

namespace Studio2_Unit2.CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string poem;
            Console.WriteLine("Please enter a string:");
            poem = Console.ReadLine().ToLower(); 
            Console.WriteLine("Here is your character count:");
            while (poem.Length > 0)
            {
                Console.Write(poem[0] + "=");
                int letters = 0;
                for (int j = 0; j < poem.Length; j++)
                {
                    if (poem[0] == poem[j])
                    {
                        letters++;
                    }
                }
                Console.WriteLine(letters);
                poem = poem.Replace(poem[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}

