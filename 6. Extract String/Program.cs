using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Extract_String
{
    internal class Program
    {
        static string ExtractString(string input)
        {
            int startIndex = input.IndexOf("##") + 2;
            int endIndex = input.LastIndexOf("##");

            if (startIndex >= 2 && endIndex > startIndex)
            {
                return input.Substring(startIndex, endIndex - startIndex);
            }
            else
            {
                return string.Empty;
            }
        }
        static void Main(string[] args)
        {

            Console.Write("Enter a string with double hash signs (##): ");
            string inputString = Console.ReadLine();

            string result = ExtractString(inputString);

            Console.WriteLine("Extracted substring: " + result);

            Console.WriteLine();
            string str1 = "##abc##def";
            string str2 = "12####78";
            string str3 = "gar##d#en";
            string str4 = "+##--##+*";

            Console.WriteLine(ExtractString(str1)); // abc
            Console.WriteLine($"{ExtractString(str2)} empty string"); //7 empty string
           // Console.WriteLine(ExtractString(str3), ". Empty string"); // empty string
            Console.WriteLine(ExtractString(str4)); // --
            Console.ReadLine();
        }
    }
}
