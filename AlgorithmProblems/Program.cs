using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace AlgorithmProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Algorithm Problems***");
            Console.WriteLine("1.Permutation of string");
            Console.WriteLine("2.Binary search word");
            Console.WriteLine("3.Insertion sort");
            Console.WriteLine("4.Bubble sort");
            Console.WriteLine("5.Merge sort");
            Console.WriteLine("6.Anagram");
            Console.WriteLine("7.Prime Number");
            Console.WriteLine("8.Anagaram and palindrome Prime Number");
            Console.Write("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter The  String : ");
                    string str = Console.ReadLine();
                    int length = str.Length;
                    Permutation.permute(str, 0, length - 1);
                    break;
                case 2:
                    string filepath = File.ReadAllText(@"C:\Users\giris\source\repos\AlgorithmProblems\AlgorithmProblems\WordList.txt");
                    List<string> list = new List<string>(filepath.Split(' '));
                    list.Sort();
                    BinarySearchWord<string> binarySearch = new BinarySearchWord<string>();
                    binarySearch.BinarySearch(list);
                    break;
                case 3:
                    InsertionSort<string> insertionSort = new InsertionSort<string>();
                    string[] arr = { "My", "Name", "Is", "Girish" };
                    insertionSort.Sort(arr);
                    insertionSort.PrintArray(arr);
                    break;
                case 4:
                    BubbleSort<int> bubbleSort = new BubbleSort<int>();
                    int[] array = { 4,9,3,1,8 };
                    bubbleSort.Sort(array);
                    bubbleSort.PrintArray(array);
                    break;
                case 5:
                    int[] arr1 = { 4, 9, 3, 1, 8 };
                    MergeSort<int>.Sort(arr1, 0, arr1.Length - 1);
                    MergeSort<int>.PrintArray(arr1);
                    break;
                case 6:
                    Anagram anagram = new Anagram();
                    anagram.CheckAnagram();
                    break;
                case 7:
                    PrimeNumber prime = new PrimeNumber();
                    prime.FindPrime();
                    break;
                case 8:
                    PalindromePrime palindromePrime = new PalindromePrime();
                    palindromePrime.ReadInput();
                    break;
                default:
                    break;
            }
        }
    }
}
