using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace String_manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            do
            {
                Console.WriteLine("Geef een string in");
               input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));

            static string LowerToUpper(string input)
            {
                return input.ToUpper();
            }

            static string UpperToLower(string input)
            {
                return input.ToLower();
            }

            static int NumberOfChar(string input)
            {
                string[] res=input.Split();
                return res.Length;
            }

            static string RemoveWhiteSpace(string input)
            {
                string res=String.Concat(input.Where(c => !Char.IsWhiteSpace(c)));
                return res;
            }
        }
    }
}