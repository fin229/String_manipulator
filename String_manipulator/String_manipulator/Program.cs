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
            int keuze;

            do
            {
                Console.WriteLine("Geef een string in");
               input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));

            Console.WriteLine("Hier is het menu met keuzes:" + Environment.NewLine);
            Console.WriteLine("1: vervang lower case naar upper case." + Environment.NewLine + "2: vervang upper case naar lower case." + Environment.NewLine
                + "3: geef de lengete van de string weer." + Environment.NewLine + "4: verwijder de spaties in de string.");
            Console.WriteLine("Voor het programma te stoppen geef 0 in");
            keuze = int.Parse(Console.ReadLine());

            while (keuze > 0)
            {
               

                switch (keuze)
                {
                    case 1:
                        Console.WriteLine(LowerToUpper(input));
                        break;
                    case 2:
                        Console.WriteLine(UpperToLower(input));
                        break;
                    case 3:
                        Console.WriteLine(NumberOfChar(input));
                        break;
                    case 4:
                        Console.WriteLine(RemoveWhiteSpace(input));
                        break;
                }
                Console.WriteLine("Hier is het menu met keuzes:" + Environment.NewLine);
                Console.WriteLine("1: vervang lower case naar upper case." + Environment.NewLine + "2: vervang upper case naar lower case." + Environment.NewLine
                    + "3: geef de lengete van de string weer." + Environment.NewLine + "4: verwijder de spaties in de string.");
                Console.WriteLine("Voor het programma te stoppen geef 0 in");
                keuze = int.Parse(Console.ReadLine());
            }

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
                string[] res=input.Split(',');
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