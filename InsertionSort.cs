using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgo
{
    internal class InsertionSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > current)
                {
                    arr[j+1]= arr[j];
                    j--;
                }
                arr[j+1]= current;
            }
            Console.WriteLine("Sorted input array: [{0}]", string.Join(", ", arr));
        }
    }
}
