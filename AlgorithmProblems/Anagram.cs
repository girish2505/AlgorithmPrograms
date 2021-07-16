using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class Anagram
    {
        public void CheckAnagram()
        {
            Console.Write("Enter first word:");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string word2 = Console.ReadLine();
            //converting to char array
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            //sorting the array  
            Array.Sort(char1);
            Array.Sort(char2);
 
            string w1 = new string(char1);
            string w2 = new string(char2);

            if (w1 == w2)
            {
                Console.WriteLine("Yes! Both the strings are anagram");
            }
            else
            {
                Console.WriteLine("No! Both the strings are not anagram");
            }
        }
    }
}
