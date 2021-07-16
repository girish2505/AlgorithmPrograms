using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class PalindromePrime
    {
        public void ReadInput()
        {
            Console.WriteLine("Enter First number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            PalindromePrime.checkPrime(num1);
            PalindromePrime.checkPrime(num2);
            bool anagram = PalindromePrime.FindAnagram(Convert.ToString(num1), Convert.ToString(num2));
            bool palindormres = PalindromePrime.Palindrome(num1);
            if (anagram)
            {
                Console.WriteLine("both values are anagrams");

            }
            else
            {
                Console.WriteLine("both the values are not anagrams");
            }
            if (palindormres)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not a palindrome");
            }
        }
        public static int checkPrime(int number)
        {
            int flag = 1;
            if (number == 1 || number == 0) { flag = 0; }

            for (int i = 2; i <= number / 2; ++i)
            {
                if (number % i == 0)
                {
                    flag = 0;
                    break;
                }
            }
            return flag;
        }
        public static bool Palindrome(int number)
        {
            int rem, sum = 0, temp;
            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                number = number / 10;
                sum = sum * 10 + rem;
            }
            if (temp == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool FindAnagram(string string1, string string2)
        {

            char[] ch1 = string1.ToLower().ToCharArray();
            char[] ch2 = string2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string newString1 = new string(ch1);
            string newString2 = new string(ch2);
            if (newString1 == newString2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
