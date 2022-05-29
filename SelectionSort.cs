using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgo
{
    internal class SelectionSort
    {
        public void Sort(int[] arr, int n) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++) 
                {
                    if (Math.Min(arr[i], arr[j]) != arr[i])
                    {
                        Swap(arr, i, j);
                    }
                }
            }
            Console.WriteLine("Sorted input array: [{0}]", string.Join(", ", arr));
        }
        public void Swap(int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
    }
}
