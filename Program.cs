using System;

namespace SortingAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            Console.WriteLine("Write size of array");
            var size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(101);
            }
            Console.WriteLine("Random input array: [{0}]", string.Join(", ", arr));
            Console.WriteLine("" +
                  "Press 1 for Simple sort." +
                "\nPress 2 for Selection sort" +
                "\nPress 3 for Bubble sort"+
                "\nPress 4 for Insertion sort"+
                "\nPress 5 for Merge sort"
                );
            int sortAlgo = Convert.ToInt32(Console.ReadLine());
            switch (sortAlgo)
            {
                case 1:
                    var simple = new SimpleSort();
                    simple.Sort(arr);
                    break;
                case 2:
                    var selection = new SelectionSort();
                    selection.Sort(arr,arr.Length);
                    break;
                case 3:
                    var bubble = new BubbleSort();
                    bubble.Sort(arr);
                    break;
                case 4:
                    var insert = new InsertionSort();
                    insert.Sort(arr);
                    break;
                case 5:
                    var merge = new MergeSort();
                    merge.Sort(arr);
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
}
}
