using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgo
{
    internal class SimpleSort
    {
        public void Sort(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i]) 
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp; 
                    }
                }
            }
            Console.WriteLine("Sorted input array: [{0}]", string.Join(", ", arr));
        }
    }
}
