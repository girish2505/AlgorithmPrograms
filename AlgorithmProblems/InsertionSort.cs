using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class InsertionSort
    {
        public void PrintArray(string[] arr)
        {
            Console.WriteLine("The Sorted array is : ");
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }
        public void Sort(string[] arr)
        {
            int size = arr.Length;
            for (int i = 1; i < size; i++)
            {
                string max = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j].Length > max.Length)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = max;
            }
        }
    }
}
