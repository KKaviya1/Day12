using Assignment___15;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___15
{
    
    class QuickSort
    {
        public static void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        private static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                Sort(arr, low, pivotIndex - 1);
                Sort(arr, pivotIndex + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 3,6,9,4,-2,12,20,-10,17};
        Console.WriteLine("Unsorted array: \n" + string.Join(", ", arr));
        Console.WriteLine();
        QuickSort.Sort(arr);
        Console.WriteLine("Sorted array: \n" + string.Join(", ", arr));
        Console.WriteLine();
        
        
        int[] sizes = { 20, 30, 50 };
        foreach (int size in sizes)
        {
            int[] randomArray = GenerateRandomArray(size);

            int[] arrToSort = new int[randomArray.Length];
            Array.Copy(randomArray, arrToSort, randomArray.Length);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            Console.WriteLine($"Time taken to sort {size} elements: {elapsedTime.TotalMilliseconds} ms");
           
            Console.WriteLine();
        }
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next();
        }
        return arr;
    }
}
