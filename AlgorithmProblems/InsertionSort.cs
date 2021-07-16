using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class InsertionSort<T> where T : IComparable
    {
        public void PrintArray(T[] arr)
        {
            Console.WriteLine("The Sorted array is : ");
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }
        // Function to sort array
        public void Sort(T[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                T max = arr[i];
                int j = i - 1;
                //searching for minmum element in the array and move to the first position
                while ((j >= 0) &&(arr[j].CompareTo(max) > 0))
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = max;
            }
        }
    }
}
