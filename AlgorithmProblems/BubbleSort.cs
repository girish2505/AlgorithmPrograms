using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class BubbleSort<T> where T : IComparable
    {
        public void PrintArray(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
        public void Sort(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j - 1]) < 0)
                    {
                        // swap temp and arr[i]
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
