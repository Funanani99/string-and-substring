using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_and_substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter a string: ");
                string mainString = Console.ReadLine();

                Console.Write("Enter the substring to count: ");
                string substringToFind = Console.ReadLine();

                int count = CountSubstringOccurrences(mainString, substringToFind);

                Console.WriteLine("Number of occurrences of " + substringToFind + " in the string: " + count);
            Console.ReadLine();
        }

            static int CountSubstringOccurrences(string mainString, string substringToFind)
            {
                int count = 0;
                int index = mainString.IndexOf(substringToFind);

                while (index != -1)
                {
                    count++;
                    index = mainString.IndexOf(substringToFind, index + 1);
                }

                return count;
            }
    }
}

