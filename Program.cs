using System;
using System.Text.RegularExpressions;

namespace ConsoleLabsOOP
{
    class Program
    {
        static int Punctuation(string str = "Hey, this is test string!!!")
        {
            int n = 0;
            System.Text.StringBuilder line = new System.Text.StringBuilder(str);
            for (int i = 0; i < str.Length; i++)
                if (Char.IsPunctuation(line[i]))
                    n++;
            return n;
        }
        
        static string Hyphen(string str = "Hey, this is hey-hey test- str-ing")
        {
            string[] words = str.Split(' ');
            string new_line = "";

            Regex regex = new Regex(@"\w+-\w+");

            foreach (string word in words)
                if (regex.IsMatch(word)) new_line += word + "; ";

            return new_line;
        }

        static void Main(string[] args)
        {
            Console.Write("Ex 1. Input text: ");
            string str = Console.ReadLine();

            int n = Punctuation(str);

            Console.WriteLine($"In this string {n} punctuation marks.");

            Console.Write("\nEx2. Input text:");
            string str0 = Console.ReadLine();

            string new_str = Hyphen(str0);

            if (new_str.Length <= 0)
                Console.WriteLine("This text no match words with hyphen.");
            else
                Console.WriteLine($"Words: {new_str}\n");

            return;
        }
    }
}
