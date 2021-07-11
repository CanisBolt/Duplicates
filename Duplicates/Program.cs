using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicates
{
    class Program
    {
         /*
         * Function that will return the count of distinct case-insensitive alphabetic characters and numeric digits 
         * that occur more than once in the input string. 
         * The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits. 
         */
        static void Main(string[] args)
        {
            string str = "";
            do
            {
                Console.WriteLine("Enter the string (may contains upper and lower case letter and digits)");
                str = Console.ReadLine();
            } while (str.Length < 0);

            List<char> duplicateLetters = new List<char>();
            int numberOfDuplicates = 0;

            string newStr = str.ToLower();
            for(int i = 0; i < newStr.Length; i++)
            {
                for(int j = i+1; j < newStr.Length; j++)
                {
                    if(newStr[i].Equals(newStr[j]) && !duplicateLetters.Contains(newStr[i]))
                    {
                        duplicateLetters.Add(newStr[i]);
                        numberOfDuplicates++;
                    }
                }
            }

            Console.WriteLine($"Number Of Duplicates letters in word: '{str}' equals: {numberOfDuplicates}");
            Console.ReadKey();
        }
    }
}
