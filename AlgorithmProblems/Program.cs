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
            Console.WriteLine("3.insertion sort");
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
                    BinarySearchWord.BinarySearch(list);
                    break;
                case 3:
                    InsertionSort insertionSort = new InsertionSort();
                    string[] arr = { "My", "Name", "Is", "Girish" };
                    insertionSort.Sort(arr);
                    insertionSort.PrintArray(arr);
                    break;
                default:
                    break;
            }
        }
    }
}
