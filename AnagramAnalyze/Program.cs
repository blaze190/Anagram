using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace AnagramAnalyze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Anagram checker");
            Console.WriteLine("Enter First Word");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter Second Word");
            string word2 = Console.ReadLine();
            if (word1 == word2)
            {
                Console.WriteLine("Dont give the same word for a anagram check");
            }
            else if (!Regex.IsMatch(word1, @"^[a-zA-Z]+$") || !Regex.IsMatch(word2, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("This program uses alphabetical characters only");
            }
            else
            {
                char[] char1 = word1.ToLower().ToCharArray();
                char[] char2 = word2.ToLower().ToCharArray();

                Array.Sort(char1);
                Array.Sort(char2);

                bool same = char1.SequenceEqual(char2);
                if (same)
                {
                    Console.WriteLine("{0} and {1} are anagrams", word1, word2);
                }
                else
                {
                    Console.WriteLine("{0} and {1} are not anagrams", word1, word2);
                }
            }
            Console.ReadKey();
        }
    }
}
