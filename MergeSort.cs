using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgo
{
    internal class MergeSort
    {
        public void Sort(int[] arr)
        {
            mergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted input array: [{0}]", string.Join(", ", arr));
        }
        private void mergeSort(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                var midIndex = (startIndex + endIndex) / 2;
                mergeSort(arr, startIndex, midIndex);
                mergeSort(arr, midIndex + 1, endIndex);
                Combine(arr, startIndex, midIndex, endIndex);
            }      
        }
        void Combine(int[] arr, int startIndex, int midIndex, int endIndex)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = midIndex - startIndex + 1;
            int n2 = endIndex - midIndex;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[startIndex + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[midIndex + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = startIndex;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
