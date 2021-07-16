using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class MergeSort<T> where T : IComparable
    {
        public static void Merge(T[] arr1, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            T[] left = new T[n1];
            T[] right = new T[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
            {
                left[i] = arr1[l + i];
            }
            for (j = 0; j < n2; ++j)
            {
                right[j] = arr1[m + 1 + j];
            }
            //initial index
            i = 0;
            j = 0;

            // Initial index of merged subarry array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (left[i].CompareTo(right[j]) < 0 || left[i].CompareTo(right[j]) == 0)
                {
                    arr1[k] = left[i];
                    i++;
                }
                else
                {
                    arr1[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr1[k] = left[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr1[k] = right[j];
                j++;
                k++;
            }
        }
        public static void Sort(T[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                Sort(arr, l, m);
                Sort(arr, m + 1, r);
                // Merge the sorted halves
                Merge(arr, l, m, r);
            }
        }
        public static void PrintArray(T[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
