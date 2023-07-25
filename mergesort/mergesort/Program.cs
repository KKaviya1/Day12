using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergesort
{
    internal class Program
    {
        public static void mergesort(int[] arr)
        {
            mergesort(arr, 0, arr.Length - 1);
        }
        private static void mergesort(int[] arr,int left, int right)
        {
            if(left<right)
            {
                int mid=(left+right)/2;
                mergesort(arr, left, mid);
                mergesort(arr,mid+1, right);
                merge(arr, left, mid, right);
            }
        }
        private static void merge(int[] arr, int left, int mid, int right)
        {
            int n1 =mid-left+1;
            int n2 =right- mid;
            int[] leftArray =new int[n1];
            int[] rightArray =new int[n2];
            Array.Copy(arr, left, leftArray, 0, n1);
            Array.Copy(arr, mid+1, rightArray, 0, n2);
            int i = 0;
            int j = 0;
            int k = left;
            while(i<n1 && j<n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            while(i<n1)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
            Console.WriteLine("Original array: "+string.Join(",",arr));
           
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            mergesort(arr);
            stopwatch.Stop();
            Console.WriteLine("Merge sorted array: " + string.Join(",", arr));
            Console.WriteLine($"Arraysize {arr.Length} time taken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();  
        }
    }
}
