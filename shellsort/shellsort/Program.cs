using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shellsort
{
    internal class Program
    {
        public static void shellsort(int[] array)
        {
            int n=array.Length;
            int gap = n / 2;
            while (gap > 0)
            {
                for(int i=gap; i<n; i++)
                {
                    int temp = array[i];
                    int j = i;
                    while(j>=gap && array[j-gap]>temp)
                    {
                        array[j] = array[j - gap];
                        j -= gap;

                    }
                    array[j] = temp;

                }
                gap /= 2;
            }
        }
        public static void Print(int[]arr)
        { 
            for(int i=0;i<arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 7, 4, 5, 2, 45, 78, 90, 12 };
            Console.WriteLine("Print array without sort");
            Print(arr);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            shellsort(arr); 
            stopwatch.Stop();
            Console.WriteLine("After shell sort");
            Print(arr);
            Console.WriteLine($"Arraysize {arr.Length} time taken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();

        }
    }
}
