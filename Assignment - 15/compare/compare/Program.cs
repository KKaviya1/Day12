using System;
using System.Diagnostics;

class SortingComparison
{
    static void Main()
    {
        int[] sizes = { 20, 30, 50 };
        foreach (int size in sizes)
        {
            int[] randomArray = GenerateRandomArray(size);

            
            int[] arrForQuickSort = new int[randomArray.Length];
            int[] arrForMergeSort = new int[randomArray.Length];
            Array.Copy(randomArray, arrForQuickSort, randomArray.Length);
            Array.Copy(randomArray, arrForMergeSort, randomArray.Length);


            Stopwatch quickSortStopwatch = new Stopwatch();
            quickSortStopwatch.Start();
           
            quickSortStopwatch.Stop();
            TimeSpan quickSortTime = quickSortStopwatch.Elapsed;

            
            Stopwatch mergeSortStopwatch = new Stopwatch();
            mergeSortStopwatch.Start();

            mergeSortStopwatch.Stop();
            TimeSpan mergeSortTime = mergeSortStopwatch.Elapsed;

          
            Console.WriteLine($"Array size: {size}");
            Console.WriteLine($"Quick Sort Time: {quickSortTime.TotalMilliseconds} ms");
            

            Console.WriteLine($"Merge Sort Time: {mergeSortTime.TotalMilliseconds} ms");
            Console.WriteLine();
        }
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(1, 100);
        }
        return arr;
    }
}

