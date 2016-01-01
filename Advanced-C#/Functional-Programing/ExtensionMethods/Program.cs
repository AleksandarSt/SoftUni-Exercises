using System;
using System.Text;

namespace ExtensionMethods
{
    class Program
    {
        static void Main()
        {
            StringBuilder alphabet = new StringBuilder();

            for (int i = 'a'; i <= 'z'; i++)
            {
                alphabet.Append((char)i);
            }


            string firstTenLetters = alphabet.Substring(0, 10);

            Console.WriteLine(firstTenLetters);
        }
    }
}
