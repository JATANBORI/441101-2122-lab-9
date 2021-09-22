using System;

namespace L9._3_VowelsAndConsonants
{
    class Program
    {

        static void RemoveWhitespace(ref string pString)
        {
            string noWhiteSpaces = "";
            char[] characters = pString.ToCharArray();

            foreach (char ch in characters)
            {
                if (!Char.IsWhiteSpace(ch))
                {
                    noWhiteSpaces = noWhiteSpaces + ch;
                }
            }
            //pString = noWhiteSpaces;
        }

        // method to count vowels and consonants here
        static void CountVowelsAndConsonants(string pString, out int pNumberOfVowels, out int pNumberOfConsonants)
        {
            // your codes here

            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Counting Vowels and Consonants!");

            string myString = "The staging area";

            //remove the white spaces
            RemoveWhitespace(ref myString);
            Console.WriteLine("String without Whitespaces: " + myString);

            // Write your codes here.
            

        }
    }
}
