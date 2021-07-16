using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class BinarySearchWord
    {
        public static void BinarySearch(List<string> list)
        {
            int mid, start = 0;
            int end = list.Count - 1;
            bool result = false;
            Console.Write("Enter the word to be search : ");
            string search = Console.ReadLine();

            while (start <= end)
            {
                mid = start + (end - start) / 2;
                int flag = search.CompareTo(list[mid]);
                if (flag == 0)
                {
                    Console.WriteLine("Given word is present in text File!");
                    result = true;
                    break;
                }
                else if (flag > 0)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            if (!result)
            {
                Console.WriteLine("Given word is not present in text File!");
            }

        }
    }
}
